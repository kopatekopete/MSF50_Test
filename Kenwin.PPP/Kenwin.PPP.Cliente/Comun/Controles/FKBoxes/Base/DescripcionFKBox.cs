using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;
using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Data.EF;
using Vemn.Fwk.Windows.Controls;

namespace Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.Base
{
	public abstract partial class DescripcionFKBox<T> : UserControl where T : class
	{
		private GenericSelector<T> _selector;
		public event EventHandler<EventArgs> SelectedItemChanged;
		private Type _tipoDatoClave = typeof(string);
		private string _nombreColumnaFiltro;

		/// <summary>
		/// Funcion que obtiene la descripcion del Item utilizando la expresion ExpressionDescripcion sobrecargada en el hijo
		/// </summary>
		private Func<T, string> ObtenerDescripcionDeItem;

		/// <summary>
		/// Funcion que obtiene el valor del Item utilizando la expresion ExpressionAtributoValor sobrecargada en el hijo
		/// </summary>
		private Func<T, string> ObtenerClaveDeItem;

		protected DescripcionFKBox()
		{
			InitializeComponent();
		}

		#region Eventos

		private void Selector_CambioItemSeleccionadoSelector(object sender, EventArgs e)
		{
			if (SelectedItemChanged != null)
			{
				SelectedItemChanged(this, new EventArgs());
			}
		}

		private void BotonAbrirSelector_Click(object sender, EventArgs e)
		{
			OpenSelector();
		}

		#endregion

		#region Metodos

		/// <summary>
		/// Aisgna el selector a un atributo privado, pero todavia no va a buscar los datos
		/// </summary>
		private void SetSelector()
		{
			var childSelector = GetSelector;

			if (childSelector == null)
				return;

			//Tomo el valor y la descripcion de los Hijos del FKBoxGenerico (Propiedades sobreescritas)
			Expression<Func<T, string>> valorExpression = ValueMemberExpression;
			Expression<Func<T, string>> descripcionExpression = DescriptionExpression;

			//Obtengo el nombre de la PK
			string nombreAtributo = GetAttributeUniqueName(valorExpression);

			#region Validar nombreAtributo
			if (String.IsNullOrEmpty(nombreAtributo))
			{
				throw new ArgumentException("ValorExpression solo permite la referencia a un solo atributo del objeto.");
			}
			#endregion

			_nombreColumnaFiltro = nombreAtributo;

			#region Asignar las funciones de obtencion de Descripcion y Valor
			//Compilo las expresiones de de la implementacion en el hijo y asigno las funciones
			ObtenerDescripcionDeItem = descripcionExpression.Compile();
			ObtenerClaveDeItem = valorExpression.Compile();
			#endregion

			_selector = childSelector;

			if (this.Selector == null)
			{
				throw new Exception(this.Name + ": El selector no puede ser nulo");
			}

			//Suscribirse al evento que notifica sobre cambios en el item seleccionado del selector
			_selector.SelectorSelectedItemChanged += Selector_CambioItemSeleccionadoSelector;
		}

		/// <summary>
		/// Abrir la ventana de selector, y si el usuario selecciona un item, asignarlo
		/// </summary>
		public void OpenSelector()
		{
			//Si no hay selector, salir
			if (Selector == null)
			{
				return;
			}

			//Mostrar la ventana de selector
			bool seleccionado = Selector.Show(true);

			//Si se seleccionó un item, actualizar
			if (seleccionado)
			{
				RefreshSelection();
			}
		}

		/// <summary>
		/// Actualiza los controles con el ItemSeleccionado
		/// </summary>
		private void RefreshSelection()
		{
			var descripcion = String.Empty;

			var itemSeleccionado = Selector.SelectedItem;

			if (itemSeleccionado != null)
			{
				//Si selecciono un item lo actualizo
				descripcion = ObtenerDescripcionDeItem(itemSeleccionado);
			}

			//Asigno los datos del item seleccionado en los controles
			descripcionLabel.Text = descripcion;

			this.AsignarTooltips();
		}

		/// <summary>
		/// 
		/// </summary>
		private void AsignarTooltips()
		{
			descripcionToolTip.SetToolTip(descripcionLabel, descripcionLabel.Text);
		}

		/// <summary>
		/// Blanquea el control y elimina el item seleccionado
		/// </summary>
		public void Clean()
		{
			Selector.Clean();

			//Limpiar controles y error
			RefreshSelection();
		}

		/// <summary>
		/// Obtener el primer miembro de la expresion
		/// </summary>
		/// <param name="expression"></param>
		/// <returns></returns>
		private string GetValueMemberPropertyName(Expression<Func<T, string>> expression)
		{
			try
			{
				if (expression == null)
				{
					throw new ArgumentNullException("expression");
				}

				MemberExpression memberExpression = null;

				if (expression.Body is MethodCallExpression)
				{
					memberExpression = ((MethodCallExpression)expression.Body).Object as MemberExpression;
				}
				else if (expression.Body is UnaryExpression)
				{
					memberExpression = ((UnaryExpression)expression.Body).Operand as MemberExpression;
				}
				else
				{
					memberExpression = expression.Body as MemberExpression;
				}
				/*
				var unaryExpression = expression.Body as UnaryExpression;
				MemberExpression memberExpression = unaryExpression == null
														? expression.Body as MemberExpression
														: unaryExpression.Operand as MemberExpression;
				*/
				if (memberExpression == null || !(memberExpression.Member is PropertyInfo))
				{
					throw new ArgumentException("Expresión invalida.");
				}
				return memberExpression.Member.Name;
			}
			catch (Exception)
			{
				throw;
			}
		}

		/// <summary>
		/// Obtiene y asigna el valor sin abrir el selector
		/// </summary>
		/// <param name="clave"></param>
		private void ObtenerItem(string clave)
		{
			#region Validacion de selector no nulo y clave valida

			//Si no hay selector, salir
			if (Selector == null)
			{
				return;
			}

			var valorFiltro = clave;

			//Si la clave escrita no es válida
			if (String.IsNullOrEmpty(valorFiltro))
			{
				this.Clean();

				return;
			}

			#endregion

			//Si viene un valor...
			ProcesarItem(valorFiltro);
		}

		/// <summary>
		/// Obtiene el nombre del atributo especificado en la expresion de valor
		/// </summary>
		/// <param name="expressionValue"></param>
		/// <returns></returns>
		private string GetAttributeUniqueName(Expression<Func<T, string>> expressionValue)
		{
			Expression expression = expressionValue.Body;
			bool encontroAtributo = false;
			string nombreAtributo = String.Empty;

			do
			{
				if (expression is MemberExpression)
				{
					nombreAtributo = ((MemberExpression)expression).Member.Name;
					encontroAtributo = true;
				}
				else if (expression is UnaryExpression)
				{
					expression = ((UnaryExpression)expression).Operand;
				}
				else if (expression is MethodCallExpression)
				{
					MethodCallExpression exp = ((MethodCallExpression)expression);
					if (exp.Method.Name == "ToString")
					{
						expression = exp.Object;

						//Obtener el tipo de dato de la PK (por default es string)
						_tipoDatoClave = expression.Type;

						//Validar que el tipo de dato sea valido para PKs
						if (_tipoDatoClave != typeof(Byte) &&
							_tipoDatoClave != typeof(Int16) &&
							_tipoDatoClave != typeof(Int32) &&
							_tipoDatoClave != typeof(Int64))
						{
							return null;
						}
					}
					else
					{
						return null;
					}
				}
				else
				{
					return null;
				}
			}
			while (!encontroAtributo);

			return nombreAtributo;
		}

		private void ProcesarItem(string valorFiltro)
		{
			//Modificado para FiltroYPaginacion

			//Obtener el item
			bool itemValido = Selector.GetItem(_nombreColumnaFiltro, valorFiltro);

			//Si se procesa y no es valido, mantener anterior
			if (itemValido)
			{
				//Si se procesa y es valido, asignar los nuevos valores
				this.RefreshSelection();
			}
			else
			{
				this.Clean();
			}
		}

		#endregion

		#region Propiedades

		/// <summary>
		/// Sobrecargar utilizando para obtener el valor del TextBox
		/// No llamar si el ItemSeleccionado es NULL
		/// </summary>
		protected abstract Expression<Func<T, string>> ValueMemberExpression { get; }

		/// <summary>
		/// Sobrecargar utilizando para obtener la descripcion del control
		/// No llamar si el ItemSeleccionado es NULL
		/// </summary>
		protected abstract Expression<Func<T, string>> DescriptionExpression { get; }

		private GenericSelector<T> Selector
		{
			get
			{
				if (_selector == null)
				{
					this.SetSelector();
				}

				return _selector;
			}
		}

		protected abstract GenericSelector<T> GetSelector { get; }

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public T SelectedItem
		{
			get
			{
				return Selector.SelectedItem;
			}
			set
			{
				Selector.SelectedItem = value;
	
				descripcionLabel.Text = value == null ?
					string.Empty : ObtenerDescripcionDeItem(value);

				this.AsignarTooltips();
			}
		}

		/// <summary>
		/// Retorna el valor de la descripcion del DescripcionFKBOX
		/// Implementado en la propiedad ExpressionDescripcion
		/// del control que hereda de esta clase
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string ItemDescription
		{
			get
			{
				//Si no tengo item seleccionado se retorna vacio
				if (Selector.SelectedItem == null)
				{
					return String.Empty;
				}

				var result = ObtenerDescripcionDeItem(Selector.SelectedItem);
				return result;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public RepositoryManager<PPPObjectContext> Manager { get; set; }

		/// <summary>
		/// Retorna el valor de la clave del FKBOX
		/// Implementado en la propiedad ExpressionAtributoValor
		/// del control que hereda de esta clase
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string ItemKey
		{
			get
			{
				//Si no tengo item seleccionado se retorna vacio
				if (Selector.SelectedItem == null)
				{
					return String.Empty;
				}

				var result = ObtenerClaveDeItem(Selector.SelectedItem);
				return result;
			}
			set
			{
				//Obtener el item por un Set de programacion (binding), generar errores
				ObtenerItem(value);
			}
		}

		#endregion
	}
}
