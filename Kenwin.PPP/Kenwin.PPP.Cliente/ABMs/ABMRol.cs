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
	public partial class ABMRol : PPPFormCrudBase
	{
		private IList<Rol> _source;

		#region Propiedades

		public Rol SelectedObject
		{
			get { return (Rol)_bs.Current; }
		}

		private RepositoryManager<PPPObjectContext> Manager { get; set; }

		private RolRepository Repository
		{
			get
			{
				return Manager.GetRepository<RolRepository>();
			}
		}

		#endregion

		#region Binding objects

		private Binding DescripcionBinding;

		#endregion Binding Objects

		#region Constructor

		public ABMRol()
		{
			InitializeComponent();

			_sortClause = "IdRol ASC";

			this.Manager = RepositoryFactory.GetManager();
		}

		private void ABMRol_Load(object sender, EventArgs e)
		{
			PrintButtonVisible = false;
		}

		#endregion

		#region Métodos BindControls

		protected override void BindControls()
		{
			DescripcionBinding = descripcionTB.DataBindings.Add("Text", _bs, "DescripcionRol", true, DataSourceUpdateMode.Never);

			_bs.AddingNew += Bs_AddingNew;
		}

		private void WriteBinding()
		{
			try
			{
				_bs.RaiseListChangedEvents = false;

				DescripcionBinding.WriteValue();
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
			var editor = dgVemn.ColumnEditor<Rol>();

			var c = editor.AddColumn(x => x.DescripcionRol, "Descripción", 100);
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

			result &= ValidateDescripcion();

			return result;
		}

		#region Razon Social

		private void Descripcion_Validating(object sender, CancelEventArgs e)
		{
			if ((_state != CrudState.StandBy) && !ValidateDescripcion())
				e.Cancel = true;
		}

		private bool ValidateDescripcion()
		{
			var result = true;

			descripcionTB.Text = descripcionTB.Text.Trim();

			SetError(descripcionTB, String.Empty);

			if (string.IsNullOrEmpty(descripcionTB.Text))
			{
				SetError(descripcionTB, "Dato obligatorio");
				result = false;
			}

			return result;
		}

		#endregion

		#endregion

		#region CRUD

		protected override void AddObject()
		{
			//Setear foco al control descripcionTB
			descripcionTB.Focus();
		}

		private void Bs_AddingNew(object sender, AddingNewEventArgs e)
		{
			e.NewObject = new Rol();
		}

		protected override void EditObject()
		{
			base.EditObject();

			//Setear foco al control descripcionTB
			descripcionTB.Focus();
		}

		protected override void SaveObject()
		{
			try
			{
				WriteBinding();

				Rol insertedObject;

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
