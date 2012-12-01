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
using System.IO;
using C1.Win.C1FlexGrid;
using System.Diagnostics;

namespace Kenwin.PPP.Cliente.ABMs
{
	public partial class ABMPais : PPPFormCrudBase
	{
		private IList<Pais> _source;

		#region Propiedades

		public Pais SelectedObject
		{
			get { return (Pais)_bs.Current; }
		}

		private RepositoryManager<PPPObjectContext> Manager { get; set; }

		private PaisRepository Repository
		{
			get
			{
				return Manager.GetRepository<PaisRepository>();
			}
		}

		#endregion

		#region Binding objects

		private Binding DescripcionBinding;
		private Binding IdiomaBinding;
		private Binding SiglaBinding;

		#endregion Binding Objects

		#region Constructor

		public ABMPais()
		{
			InitializeComponent();

			_sortClause = "IdPais ASC";

			this.Manager = RepositoryFactory.GetManager();
			fKBoxIdioma.Manager = this.Manager;
		}

		private void ABMPais_Load(object sender, EventArgs e)
		{
			PrintButtonVisible = false;
		}

		#endregion

		#region Métodos BindControls

		protected override void BindControls()
		{
			DescripcionBinding = DescripcionTB.DataBindings.Add("Text", _bs, "DescripcionPais", true, DataSourceUpdateMode.Never);
			IdiomaBinding = fKBoxIdioma.DataBindings.Add("SelectedItem", _bs, "Idioma", true, DataSourceUpdateMode.Never);
			SiglaBinding = siglaTB.DataBindings.Add("Text", _bs, "Sigla", true, DataSourceUpdateMode.Never);

			_bs.AddingNew += Bs_AddingNew;
		}

		private void WriteBinding()
		{
			try
			{
				_bs.RaiseListChangedEvents = false;

				DescripcionBinding.WriteValue();
				IdiomaBinding.WriteValue();
				SiglaBinding.WriteValue();
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
			var editor = dgVemn.ColumnEditor<Pais>();

			var c = editor.AddColumn(x => x.DescripcionPais, "Descripción País", 140);
			this.AddFilter(c.DataType, c.Caption, c.Name, null, null, null, null, null);

			c = editor.AddColumn("Idioma.DescripcionIdioma", "Idioma", 120, x => x.Idioma.DescripcionIdioma);
			this.AddFilter(c.DataType, c.Caption, c.Name, null, null, null, null, null);

			c = editor.AddColumn(x => x.Sigla, "Sigla", 100);
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
			result &= ValidateIdioma();
			result &= ValidateSigla();

			return result;
		}

		#region Descripcion

		private void Descripcion_Validating(object sender, CancelEventArgs e)
		{
			if ((_state != CrudState.StandBy) && !ValidateDescripcion())
				e.Cancel = true;
		}

		private bool ValidateDescripcion()
		{
			var result = true;

			DescripcionTB.Text = DescripcionTB.Text.Trim();

			SetError(DescripcionTB, String.Empty);

			if (string.IsNullOrEmpty(DescripcionTB.Text))
			{
				SetError(DescripcionTB, "Dato obligatorio");
				result = false;
			}

			return result;
		}

		#endregion

		#region Idioma

		private void FKBoxIdioma_Validating(object sender, CancelEventArgs e)
		{
			if ((_state != CrudState.StandBy) && !ValidateIdioma())
				e.Cancel = true;
		}

		private bool ValidateIdioma()
		{
			var resultado = true;

			SetError(fKBoxIdioma, String.Empty);

			if (fKBoxIdioma.SelectedItem == null)
			{
				SetError(fKBoxIdioma, "Dato obligatorio");
				resultado = false;
			}

			return resultado;
		}

		#endregion

		#region Sigla

		private void SiglaTB_Validating(object sender, CancelEventArgs e)
		{
			if ((_state != CrudState.StandBy) && !ValidateSigla())
				e.Cancel = true;
		}

		private bool ValidateSigla()
		{
			var result = true;

			siglaTB.Text = siglaTB.Text.Trim();

			SetError(siglaTB, String.Empty);

			if (string.IsNullOrEmpty(siglaTB.Text))
			{
				SetError(siglaTB, "Dato obligatorio");
				result = false;
			}

			return result;
		}

		#endregion

		#endregion

		#region CRUD

		protected override void AddObject()
		{
			//Setear foco al control DescripcionTB
			DescripcionTB.Focus();
		}

		private void Bs_AddingNew(object sender, AddingNewEventArgs e)
		{
			e.NewObject = new Pais();
		}

		protected override void EditObject()
		{
			base.EditObject();

			//Setear foco al control DescripcionTB
			DescripcionTB.Focus();
		}

		protected override void SaveObject()
		{
			try
			{
				WriteBinding();

				Pais insertedObject;

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
