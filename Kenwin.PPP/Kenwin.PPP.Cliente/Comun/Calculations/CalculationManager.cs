using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Kenwin.PPP.Cliente.Comun.Calculations
{
    public class CalculationManager<T> where T : INotifyPropertyChanged
    {
        private readonly Dictionary<string, List<string>> _invertedDependencyDictionary = new Dictionary<string, List<string>>();
        private readonly Dictionary<string, object> _formulasDictionary = new Dictionary<string, object>();

        private readonly List<string> _independentFormulas = new List<string>();

        private readonly Dictionary<string, object> _alreadyCalculatedValues = new Dictionary<string, object>();

        private CalculationManager()
        {

        }

        public static CalculationManager<T> Create()
        {
            return new CalculationManager<T>();
        }

        public event EventHandler<FormulaExecutionEventArgs<T>> AfterFormulaExecution;

        public object OnAfterFormulaExecution(T objectSource, string columnName, object newValue)
        {
            EventHandler<FormulaExecutionEventArgs<T>> handler = AfterFormulaExecution;
            if (handler != null)
            {
                handler(this, new FormulaExecutionEventArgs<T>(objectSource, columnName, newValue));
            }

            return newValue;
        }

        public CalculationManager<T> DefineFormula<T2>(Expression<Func<T, T2>> destinationMember, Expression<Func<T, T2>> formulaExpression)
        {
            var dependantMembers = FindDependantMembers(formulaExpression.Body)
                .Distinct()
                .ToList();

            var destinationMemberName = GetPropertyInfo(destinationMember).Name;

            var compiledFunction = formulaExpression.Compile();

            if (dependantMembers.Any())
            {
                foreach (var dependantMember in dependantMembers)
                {
                    List<string> lista;
                    if (!_invertedDependencyDictionary.TryGetValue(dependantMember, out lista))
                    {
                        lista = new List<string>();
                        _invertedDependencyDictionary.Add(dependantMember, lista);
                    }
                    lista.Add(destinationMemberName);
                }
            }
            else
            {
                _independentFormulas.Add(destinationMemberName);
            }

            _formulasDictionary.Add(destinationMemberName, compiledFunction);

            return this;
        }

        private static IEnumerable<string> FindDependantMembers(Expression expression)
        {
            var list = new List<string>();

            if (expression == null)
            {
                return list;
            }

            if (expression is MemberExpression)
            {
                var memberName = ((MemberExpression)expression).Member.Name;
                list.Add(memberName);
                return list;
            }

            if (expression is MethodCallExpression)
            {
                var objectMemberList = FindDependantMembers(((MethodCallExpression)expression).Object);
                list.AddRange(objectMemberList);

                foreach (var argumentExpression in ((MethodCallExpression)expression).Arguments)
                {
                    var argumentMemberList = FindDependantMembers(argumentExpression);
                    list.AddRange(argumentMemberList);
                }
                return list;
            }

            if (expression is BinaryExpression)
            {
                var leftList = FindDependantMembers(((BinaryExpression)expression).Left);
                var rightList = FindDependantMembers(((BinaryExpression)expression).Right);
                list.AddRange(leftList);
                list.AddRange(rightList);

                return list;
            }

            if(expression is UnaryExpression)
            {
                var operand = ((UnaryExpression)expression).Operand;
                if(operand != null)
                {
                    var resultList = FindDependantMembers(operand);
                    list.AddRange(resultList);
                }
                return list;
            }

            if (expression is ConstantExpression)
            {
                return list;
            }

            throw new NotImplementedException(expression.GetType().FullName);
        }

        public void ApplyToAll(List<T> list)
        {
            ApplyToAll(list, x => true);
        }

        public void ApplyToAll(List<T> list, Func<T, bool> condition)
        {
            foreach (var item in list.Where(condition))
            {
                ApplyToItem(item, false);
            }
        }

        public void ApplyToItem(T item, bool executeConstant)
        {
            item.PropertyChanged += PropertyChangedHandler;

            if (executeConstant)
            {
                foreach (string destinationName in _independentFormulas)
                {
                    ExecuteFormula(item, destinationName);
                }
            }
        }

        private void PropertyChangedHandler(object sender, PropertyChangedEventArgs e)
        {
            ExecuteDependantFormulas((T)sender, e.PropertyName);
        }

        private void ExecuteDependantFormulas(T source, string destinationColumnName)
        {
            //gets dependent columns list 
            List<string> list = null;
            if (_invertedDependencyDictionary.TryGetValue(destinationColumnName, out list))
            {
                foreach (var resultMemberName in list)
                {
                    ExecuteFormula(source, resultMemberName);
                }
            }
        }

        private void ExecuteFormula(T source, string destinationColumnName)
        {
            var sourceType = typeof(T);
            var function = _formulasDictionary[destinationColumnName];
            var property = sourceType.GetProperty(destinationColumnName);

            object value;
            try
            {
                var resultValue = ((Func<T, object>)function).Invoke(source);
                value = OnAfterFormulaExecution(source, destinationColumnName, resultValue);
            }
            catch (Exception)
            {
                value = null;
            }

            //TODO: Validate writing property

            var oldValue = property.GetValue(source, null);
            if (oldValue != value)
            {
                property.SetValue(source, value, null);    
            }
        }

        public bool HasFormula(string columnName)
        {
            return _formulasDictionary.ContainsKey(columnName);
        }

        private static PropertyInfo GetPropertyInfo<T2>(Expression<Func<T, T2>> expression)
        {
            if (expression == null)
            {
                throw new ArgumentNullException("expression");
            }

            var unaryExpression = expression.Body as UnaryExpression;
            MemberExpression memberExpression = unaryExpression == null
                ? expression.Body as MemberExpression
                : unaryExpression.Operand as MemberExpression;

            if (memberExpression == null || !(memberExpression.Member is PropertyInfo))
            {
                throw new ArgumentException("Expresión invalida.");
            }
            return (PropertyInfo)memberExpression.Member;
        }
    }
}