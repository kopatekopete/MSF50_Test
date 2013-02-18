using System;
using System.ComponentModel;

namespace Kenwin.PPP.Cliente.Comun.Calculations
{
    public class FormulaExecutionEventArgs<T> : EventArgs where T : INotifyPropertyChanged
    {
        public FormulaExecutionEventArgs(T objectSource, string columnName, object newValue)
        {
            ObjectSource = objectSource;
            NewValue = newValue;
            ColumnName = columnName;
        }

        public object NewValue { get; set; }
        public T ObjectSource { get; private set; }
        public string ColumnName { get; private set; }
    }
}