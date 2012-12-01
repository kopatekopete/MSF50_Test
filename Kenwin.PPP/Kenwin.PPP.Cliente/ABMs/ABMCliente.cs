using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Kenwin.PPP.Cliente.ABMs.Base;
using Kenwin.PPP.Cliente.Comun;
using Kenwin.PPP.Negocio.Modelo;
using Kenwin.PPP.Negocio.Repositorios;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Vemn.Fwk.Data.EF;
using Vemn.Fwk.Windows.Controls.Extensions;

namespace Kenwin.PPP.Cliente.ABMs
{
	public partial class ABMCliente : PPPFormCrudBase
	{
		private IList<Negocio.Modelo.Cliente> _source;

		#region Propiedades

		public Negocio.Modelo.Cliente SelectedObject
		{
			get { return (Negocio.Modelo.Cliente)_bs.Current; }
		}

		private RepositoryManager<PPPObjectContext> Manager { get; set; }

		private ClienteRepository Repository
		{
			get
			{
				return Manager.GetRepository<ClienteRepository>();
			}
		}

		#endregion

		#region Binding objects

		private Binding RazonSocialBinding;

		#endregion Binding Objects

		#region Constructor

		public ABMCliente()
		{
			InitializeComponent();

			_sortClause = "IdCliente ASC";

			this.Manager = RepositoryFactory.GetManager();
		}

		private void ABMCliente_Load(object sender, EventArgs e)
		{
			PrintButtonVisible = false;
		}

		#endregion

		#region Métodos BindControls

		protected override void BindControls()
		{
			RazonSocialBinding = RazonSocial.DataBindings.Add("Text", _bs, "RazonSocial", true, DataSourceUpdateMode.Never);

			_bs.AddingNew += Bs_AddingNew;
		}

		private void WriteBinding()
		{
			try
			{
				_bs.RaiseListChangedEvents = false;

				RazonSocialBinding.WriteValue();
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
			var editor = dgVemn.ColumnEditor<Negocio.Modelo.Cliente>();

			var c = editor.AddColumn(x => x.RazonSocial, "Razón Social", 100);
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
			var result = true;
			this.ClearErrors();

			result &= ValidateRazonSocial();

			return result;
		}

		#region Razon Social

		private void RazonSocial_Validating(object sender, CancelEventArgs e)
		{
			if ((_state != CrudState.StandBy) && !ValidateRazonSocial())
				e.Cancel = true;
		}

		private bool ValidateRazonSocial()
		{
			var result = true;

			RazonSocial.Text = RazonSocial.Text.Trim();

			SetError(RazonSocial, String.Empty);

			if (string.IsNullOrEmpty(RazonSocial.Text))
			{
				SetError(RazonSocial, "Dato obligatorio");
				result = false;
			}

			return result;
		}

		#endregion

		#endregion

		#region CRUD

		protected override void AddObject()
		{
			//Setear foco al control RazonSocial
			RazonSocial.Focus();
		}

		private void Bs_AddingNew(object sender, AddingNewEventArgs e)
		{
			e.NewObject = new Negocio.Modelo.Cliente();
		}

		protected override void EditObject()
		{
			base.EditObject();

			//Setear foco al control RazonSocial
			RazonSocial.Focus();
		}

		protected override void SaveObject()
		{
			try
			{
				WriteBinding();

				Negocio.Modelo.Cliente insertedObject;

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
				var result = this.Repository.RefreshEntity(SelectedObject);
				this.UpdateModifiedEntity(SelectedObject, result);
			}
			catch (Exception)
			{
				this.GetDataPage();
			}
		}

		#endregion CRUD
	}
}
