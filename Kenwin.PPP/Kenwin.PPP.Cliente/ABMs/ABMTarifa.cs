using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Kenwin.PPP.Cliente.ABMs.Base;
using Kenwin.PPP.Cliente.Comun;
using Kenwin.PPP.Negocio.Comun;
using Kenwin.PPP.Negocio.Modelo;
using Kenwin.PPP.Negocio.Repositorios;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Vemn.Fwk.Data.EF;
using Vemn.Fwk.Windows.Controls.Extensions;
using Vemn.Fwk.Windows.Controls;

namespace Kenwin.PPP.Cliente.ABMs
{
	public partial class ABMTarifa : PPPFormCrudBase
	{
		private IList<ActividadRate> _source;

		#region Propiedades

		public ActividadRate SelectedObject
		{
			get { return (ActividadRate)_bs.Current; }
		}

		private RepositoryManager<PPPObjectContext> Manager { get; set; }

		private ActividadRateRepository Repository
		{
			get
			{
				return Manager.GetRepository<ActividadRateRepository>();
			}
		}

		#endregion

		#region Binding objects

		private Binding _actividadBinding;
		private Binding _monedaBinding;
		private Binding _paisBinding;
		private Binding _clienteBinding;
		private Binding _unidadMedidaBinding;
		private Binding _cantidadTopeBinding;
		private Binding _rateBinding;
		private Binding _esRateFijoBinding;

		#endregion Binding Objects

		#region Constructor

		public ABMTarifa()
		{
			InitializeComponent();

			_sortClause = "Actividad.DescripcionActividad ASC";

			Manager = RepositoryFactory.GetManager();

			RateDB.CustomFormat = Formatos.FormatoEntero;
			RateDB.Format = DecimalBoxFormat.CustomFormat;

			#region Cargar FKBOXes

			fKBoxActividad.Manager = this.Manager;
			fKBoxMoneda.Manager = this.Manager;
			fKBoxPais.Manager = this.Manager;
			fKBoxCliente.Manager = this.Manager;
			fKBoxUM.Manager = this.Manager;

			#endregion
		}

		private void ABMTarifa_Load(object sender, EventArgs e)
		{
			PrintButtonVisible = false;
		}

		#endregion

		#region Métodos BindControls

		protected override void BindControls()
		{
			_actividadBinding = fKBoxActividad.DataBindings.Add("ItemKey", _bs, "IdActividad", true, DataSourceUpdateMode.Never);
			_monedaBinding = fKBoxMoneda.DataBindings.Add("SelectedItem", _bs, "Moneda", true, DataSourceUpdateMode.Never);
			_paisBinding = fKBoxPais.DataBindings.Add("SelectedItem", _bs, "Pais", true, DataSourceUpdateMode.Never);
			_clienteBinding = fKBoxCliente.DataBindings.Add("SelectedItem", _bs, "Cliente", true, DataSourceUpdateMode.Never);
			_unidadMedidaBinding = fKBoxUM.DataBindings.Add("SelectedItem", _bs, "UnidadMedida", true, DataSourceUpdateMode.Never);
			_cantidadTopeBinding = CantidadTopeIB.DataBindings.Add("Value", _bs, "CantidadTope", true, DataSourceUpdateMode.Never);
			_rateBinding = RateDB.DataBindings.Add("Text", _bs, "Rate", true, DataSourceUpdateMode.Never);
			_esRateFijoBinding = EsRateFijoCB.DataBindings.Add("Checked", _bs, "EsRateFijo", true, DataSourceUpdateMode.Never);

			_bs.AddingNew += Bs_AddingNew;
		}

		private void WriteBinding()
		{
			try
			{
				_bs.RaiseListChangedEvents = false;

				_actividadBinding.WriteValue();
				_monedaBinding.WriteValue();
				_paisBinding.WriteValue();
				_clienteBinding.WriteValue();
				_unidadMedidaBinding.WriteValue();
				_cantidadTopeBinding.WriteValue();
				_rateBinding.WriteValue();
				_esRateFijoBinding.WriteValue();

				#region AsignarPropiedades no bindeadas

				var actividadCustom = fKBoxActividad.SelectedItem;

				var actividad = Manager.GetRepository<ActividadRepository>()
					.GetEntity(actividadCustom.IdActividad);

				SelectedObject.Actividad = actividad;

				SelectedObject.FechaAlta = DateTime.Today;
				SelectedObject.FechaVigencia = DateTime.Today;

				#endregion
			}
			finally
			{
				_bs.RaiseListChangedEvents = true;
			}
		}

		#endregion

		#region Configuracion Columas

		protected override void ConfigureColumns()
		{
			var editor = dgVemn.ColumnEditor<ActividadRate>();

			var c = editor.AddColumn("Actividad.DescripcionActividad", "Actividad", 250, x => x.Actividad.DescripcionActividad);
			this.AddFilter(c.DataType, c.Caption, c.Name, null, null, null, null, null);

			c = editor.AddColumn("Moneda.DescripcionMoneda", "Moneda", 120, x => x.Moneda.DescripcionMoneda);
			this.AddFilter(c.DataType, c.Caption, c.Name, null, null, null, null, null);

			c = editor.AddColumn("Pais.DescripcionPais", "País", 120, x => (x.Pais == null ? "<Todos>" : x.Pais.DescripcionPais));
			this.AddFilter(c.DataType, c.Caption, c.Name, null, null, null, null, null);

			c = editor.AddColumn("Cliente.RazonSocial", "Cliente", 120, x => (x.Cliente == null ? "<Todos>" : x.Cliente.RazonSocial));
			this.AddFilter(c.DataType, c.Caption, c.Name, null, null, null, null, null);

			c = editor.AddColumn("UnidadMedida.DescripcionUnidadMedida", "Unidad Medida", 120, x => x.UnidadMedida.DescripcionUnidadMedida);
			this.AddFilter(c.DataType, c.Caption, c.Name, null, null, null, null, null);

			//Se sobreescribe el dataType real para que el filtro funcione correctamente, ya que no funciona bien cuando los tipos de datos son nullables
			//TODO: arreglar filtro del FWK para que maneje automaticamente los campos nullables
			c = editor.AddColumn(x => x.CantidadTope, "Cantidad Hasta", 100);
			this.AddFilter(/*c.DataType*/typeof(Int32), c.Caption, c.Name, null, null, null, null, null);

			c = editor.AddColumn(x => x.Rate, "Rate", 100).Formato(Formatos.FormatoEntero);
			this.AddFilter(c.DataType, c.Caption, c.Name, null, null, null, null, null);

			c = editor.AddColumn(x => x.EsRateFijo, "Rate Fijo", 40);
			this.AddFilter(c.DataType, c.Caption, c.Name, null, null, null, null, null);
		}

		#endregion

		#region Método GetDataPage

		protected override void GetData()
		{
			try
			{
				_source = Repository.GetAll();
				_bs.DataSource = _source;
			}
			catch (Exception ex)
			{
				ExceptionPolicy.HandleException(ex, Constantes.ElErrorPolicy);
			}
		}

		protected override void GetDataPage()
		{
			try
			{
				var total = Repository.Count(this.FilterSortPaging.FilterData);

				this.CalculatePages(total);

				_source = Repository.GetAll(this.FilterSortPaging);
				_bs.DataSource = _source;
			}
			catch (Exception ex)
			{
				ExceptionPolicy.HandleException(ex, Constantes.ElErrorPolicy);
			}
		}

		#endregion GetDataPage method

		#region Validacion datos

		protected override bool ValidateAll()
		{
			var resultado = true;
			this.ClearErrors();

			resultado &= ValidateActividad();
			resultado &= ValidateMoneda();
			resultado &= ValidateUM();
			resultado &= ValidateRate();

			return resultado;
		}

		#region Actividad

		private void FKBoxActividad_Validating(object sender, CancelEventArgs e)
		{
			if ((_state != CrudState.StandBy) && !ValidateActividad())
				e.Cancel = true;
		}

		private bool ValidateActividad()
		{
			var resultado = true;

			SetError(fKBoxActividad, String.Empty);

			if (fKBoxActividad.SelectedItem == null)
			{
				SetError(fKBoxActividad, "Dato obligatorio");
				resultado = false;
			}

			return resultado;
		}

		#endregion

		#region Moneda

		private void FKBoxMoneda_Validating(object sender, CancelEventArgs e)
		{
			if ((_state != CrudState.StandBy) && !ValidateMoneda())
				e.Cancel = true;
		}

		private bool ValidateMoneda()
		{
			var resultado = true;

			SetError(fKBoxMoneda, String.Empty);

			if (fKBoxMoneda.SelectedItem == null)
			{
				SetError(fKBoxMoneda, "Dato obligatorio");
				resultado = false;
			}

			return resultado;
		}

		#endregion

		#region Unidad de Medida

		private void FKBoxUM_Validating(object sender, CancelEventArgs e)
		{
			if ((_state != CrudState.StandBy) && !ValidateUM())
				e.Cancel = true;
		}

		private bool ValidateUM()
		{
			var resultado = true;

			SetError(fKBoxUM, String.Empty);

			if (fKBoxUM.SelectedItem == null)
			{
				SetError(fKBoxUM, "Dato obligatorio");
				resultado = false;
			}

			return resultado;
		}

		#endregion

		#region Rate

		private void RateDB_Validating(object sender, CancelEventArgs e)
		{
			if ((_state != CrudState.StandBy) && !ValidateRate())
				e.Cancel = true;
		}

		private bool ValidateRate()
		{
			var resultado = true;

			SetError(RateDB, String.Empty);

			if (!RateDB.IsValid())
			{
				SetError(RateDB, "Cantidad no válida");
				resultado = false;
			}

			return resultado;
		}

		#endregion

		#endregion

		#region CRUD

		protected override void AddObject()
		{
			#region Activar los controles para permitir edicion

			fKBoxActividad.Enabled = true;
			fKBoxMoneda.Enabled = true;
			fKBoxPais.Enabled = true;
			fKBoxCliente.Enabled = true;
			fKBoxUM.Enabled = true;
			EsRateFijoCB.Enabled = true;

			limpiarPaisButton.Enabled = true;
			limpiarClienteB.Enabled = true;

			#endregion

			//Setear foco al control FKBox Actividad
			fKBoxActividad.Focus();
		}

		private void Bs_AddingNew(object sender, AddingNewEventArgs e)
		{
			e.NewObject = new ActividadRate();
		}

		protected override void EditObject()
		{
			base.EditObject();

			#region Setear controles como read only

			fKBoxActividad.Enabled = false;
			fKBoxMoneda.Enabled = false;
			fKBoxPais.Enabled = false;
			fKBoxCliente.Enabled = false;
			fKBoxUM.Enabled = false;
			EsRateFijoCB.Enabled = false;

			limpiarPaisButton.Enabled = false;
			limpiarClienteB.Enabled = false;

			#endregion

			//Setear foco al control FKBox Actividad
			CantidadTopeIB.Focus();
		}

		protected override void SaveObject()
		{
			try
			{
				WriteBinding();

				ActividadRate insertedObject;

				if (_state == CrudState.AddNew)
				{
					insertedObject = this.Repository.InsertABM(SelectedObject);
					this.UpdateInsertedEntity(SelectedObject, insertedObject);
				}
				else
				{
					insertedObject = this.Repository.UpdateABM(SelectedObject);
					this.UpdateModifiedEntity(SelectedObject, insertedObject);
				}
			}
			catch (Exception ex)
			{
				ExceptionPolicy.HandleException(ex, Constantes.ELSaveObjectCrudPolicy);
			}
		}

		protected override void DeleteObject()
		{
			try
			{
				Repository.Delete(SelectedObject);
			}
			catch (Exception ex)
			{
				ExceptionPolicy.HandleException(ex, Constantes.ElErrorPolicy);
			}
		}

		protected override void CancelObjectModifications()
		{
			this.ClearErrors();

			this.RefreshEntity();
		}

		/// <summary>
		/// Recargar la entidad luego la cancelacion de un save
		/// </summary>
		private void RefreshEntity()
		{
			try
			{
				var resultado = this.Repository.RefreshEntity(SelectedObject);
				this.UpdateModifiedEntity(SelectedObject, resultado);
			}
			catch (Exception)
			{
				this.GetDataPage();
			}
		}

		private void LimpiarPaisButton_Click(object sender, EventArgs e)
		{
			fKBoxPais.SelectedItem = null;
		}

		private void LimpiarClienteB_Click(object sender, EventArgs e)
		{
			fKBoxCliente.SelectedItem = null;
		}

		#endregion CRUD
	}
}
