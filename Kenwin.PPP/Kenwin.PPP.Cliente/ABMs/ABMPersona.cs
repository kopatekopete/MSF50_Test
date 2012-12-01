using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
	public partial class ABMPersona : PPPFormCrudBase
	{
		private IList<Persona> _source;

		#region Propiedades

		public Persona SelectedObject
		{
			get { return (Persona)_bs.Current; }
		}

		private RepositoryManager<PPPObjectContext> Manager { get; set; }

		private PersonaRepository Repository
		{
			get
			{
				return Manager.GetRepository<PersonaRepository>();
			}
		}

		#endregion

		#region Binding objects

		private Binding NombreBinding;
		private Binding ApellidoBinding;
		private Binding AliasBinding;
		private Binding ActivoBinding;
		private Binding PaisBinding;
		private Binding Email;

		#endregion Binding Objects

		#region Constructor

		public ABMPersona()
		{
			InitializeComponent();

			_sortClause = "IdPersona ASC";

			this.Manager = RepositoryFactory.GetManager();
		}

		private void ABMPersona_Load(object sender, EventArgs e)
		{
			PrintButtonVisible = false;

			fKBoxPais.Manager = this.Manager;

			ObtenerIdiomas();
		}

		#endregion

		#region Métodos BindControls

		protected override void BindControls()
		{
			NombreBinding = nombreTB.DataBindings.Add("Text", _bs, "Nombre", true, DataSourceUpdateMode.Never);
			ApellidoBinding = apellidoTB.DataBindings.Add("Text", _bs, "Apellido", true, DataSourceUpdateMode.Never);
			AliasBinding = aliasTB.DataBindings.Add("Text", _bs, "Alias", true, DataSourceUpdateMode.Never);
			ActivoBinding = activoCB.DataBindings.Add("Checked", _bs, "Activo", true, DataSourceUpdateMode.Never);
			PaisBinding = fKBoxPais.DataBindings.Add("SelectedItem", _bs, "PaisResidencia", true, DataSourceUpdateMode.Never);
			Email = emailTB.DataBindings.Add("Text", _bs, "Email", true, DataSourceUpdateMode.Never);

			_bs.AddingNew += Bs_AddingNew;
		}

		private void WriteBinding()
		{
			try
			{
				_bs.RaiseListChangedEvents = false;

				NombreBinding.WriteValue();
				ApellidoBinding.WriteValue();
				AliasBinding.WriteValue();
				ActivoBinding.WriteValue();
				PaisBinding.WriteValue();
				Email.WriteValue();

				#region AsignarPropiedades no bindeadas

				//Limpiar idiomas y recargar con los seleccionados
				SelectedObject.IdiomaSet.Clear();

				var listaIdiomas = idiomasCLB.CheckedItems
					.OfType<Idioma>()
					.ToListExt();

				SelectedObject.IdiomaSet.AddRangeExt(listaIdiomas);

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
			var editor = dgVemn.ColumnEditor<Persona>();

			var c = editor.AddColumn(x => x.Nombre, "Nombre", 250);
			this.AddFilter(c.DataType, c.Caption, c.Name, null, null, null, null, null);

			c = editor.AddColumn(x => x.Apellido, "Apellido", 250);
			this.AddFilter(c.DataType, c.Caption, c.Name, null, null, null, null, null);

			c = editor.AddColumn(x => x.Alias, "Alias", 70);
			this.AddFilter(c.DataType, c.Caption, c.Name, null, null, null, null, null);

			c = editor.AddColumn(x => x.Activo, "Activo", 40);
			this.AddFilter(c.DataType, c.Caption, c.Name, null, null, null, null, null);

			c = editor.AddColumn("PaisResidencia.DescripcionPais", "País", 120, x => x.PaisResidencia.DescripcionPais);
			this.AddFilter(c.DataType, c.Caption, c.Name, null, null, null, null, null);

			c = editor.AddColumn(x => x.Email, "Email", 150);
			this.AddFilter(c.DataType, c.Caption, c.Name, null, null, null, null, null);

			c = editor.AddColumn(x => x.IdiomasDescripcion, "Idiomas", 100);
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

			result &= ValidateNombre();
			result &= ValidateApellido();
			result &= ValidatePais();
			result &= ValidateAlias();
			result &= ValidateEmail();

			return result;
		}

		#region Nombre

		private void NombreTB_Validating(object sender, CancelEventArgs e)
		{
			if ((_state != CrudState.StandBy) && !ValidateNombre())
				e.Cancel = true;
		}

		private bool ValidateNombre()
		{
			var result = true;

			nombreTB.Text = nombreTB.Text.Trim();

			SetError(nombreTB, String.Empty);

			if (string.IsNullOrEmpty(nombreTB.Text))
			{
				SetError(nombreTB, "Dato obligatorio");
				result = false;
			}

			return result;
		}

		#endregion

		#region Apellido

		private void ApellidoTB_Validating(object sender, CancelEventArgs e)
		{
			if ((_state != CrudState.StandBy) && !ValidateApellido())
				e.Cancel = true;
		}

		private bool ValidateApellido()
		{
			var result = true;

			apellidoTB.Text = apellidoTB.Text.Trim();

			SetError(apellidoTB, String.Empty);

			if (string.IsNullOrEmpty(apellidoTB.Text))
			{
				SetError(apellidoTB, "Dato obligatorio");
				result = false;
			}

			return result;
		}

		#endregion

		#region Pais

		private void FKBoxpais_Validating(object sender, CancelEventArgs e)
		{
			if ((_state != CrudState.StandBy) && !ValidatePais())
				e.Cancel = true;
		}

		private bool ValidatePais()
		{
			var result = true;

			SetError(fKBoxPais, String.Empty);

			if (fKBoxPais.SelectedItem == null)
			{
				SetError(fKBoxPais, "Dato obligatorio");
				result = false;
			}

			return result;
		}

		#endregion

		#region Alias

		private bool ValidateAlias()
		{
			var result = true;

			SetError(aliasTB, String.Empty);

			if (string.IsNullOrEmpty(aliasTB.Text))
			{
				SetError(aliasTB, "Dato obligatorio");
				result = false;
			}

			return result;
		}

		private void AliasTB_Validating(object sender, CancelEventArgs e)
		{
			if ((_state != CrudState.StandBy) && !ValidateAlias())
				e.Cancel = true;
		}

		#endregion


		#region Email

		private void EmailTB_Validating(object sender, CancelEventArgs e)
		{
			if ((_state != CrudState.StandBy) && !ValidateEmail())
				e.Cancel = true;
		}

		private bool ValidateEmail()
		{
			var result = true;

			SetError(emailTB, String.Empty);

			if (!ClaseValidadora.EsEmailValido(emailTB.Text))
			{
				SetError(emailTB, "Formato de email invalido");
				result = false;
			}

			return result;
		}

		#endregion

		#endregion

		#region CRUD

		protected override void AddObject()
		{
			//Setear foco al control nombreTB
			nombreTB.Focus();

			LimpiarCheckedListBoxIdiomas();
		}

		private void Bs_AddingNew(object sender, AddingNewEventArgs e)
		{
			e.NewObject = new Persona();
		}

		private void Bs_PositionChanged(object sender, EventArgs e)
		{
			//Si al cambiar de posicion estoy en la solapa distinta de la de detalle, no es necesario actualizar los idiomas
			if (CrudTab.SelectedIndex != 1)
			{
				return;
			}

			//Al cambiar el item actual y estar en modo consulta, cargar los idiomas
			if (_state == CrudState.StandBy)
			{
				//panelContainerDetail.Enabled = false;
				CargarIdiomas();
			}
		}

		protected override void EditObject()
		{
			base.EditObject();

			//Setear foco al control nombreTB
			nombreTB.Focus();

			CargarIdiomas();
		}

		protected override void SaveObject()
		{
			try
			{
				WriteBinding();

				Persona insertedObject;

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

			//Al cancelar se deben recargar los idiomas que tenga la persona refrescada
			CargarIdiomas();
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

		private void CrudTab_Selecting(object sender, TabControlCancelEventArgs e)
		{
			//Al cambiar la solapa del crud, si se quiere cambiar a la primera y esta en modo consulta, cargar los idiomas
			if (e.TabPageIndex == 1 && _state == CrudState.StandBy)
			{
				CargarIdiomas();
			}
		}

		#endregion CRUD

		#region Metodos privados

		/// <summary>
		/// Limpia y recarga los idiomas asociados al usuario en la CheckedListBox de Idiomas
		/// </summary>
		private void CargarIdiomas()
		{
			LimpiarCheckedListBoxIdiomas();

			CargarCheckedListBoxIdiomas();
		}

		/// <summary>
		/// Limpiar los items tildados de la CheckedListBox de Idiomas
		/// </summary>
		private void LimpiarCheckedListBoxIdiomas()
		{
			for (int i = 0; i < idiomasCLB.Items.Count; i++)
			{
				idiomasCLB.SetItemChecked(i, false);
			}
		}

		/// <summary>
		/// Tilda los items de la CheckedListBox de Idiomas que tenga asociados el usuario
		/// </summary>
		private void CargarCheckedListBoxIdiomas()
		{
			foreach (var idioma in SelectedObject.IdiomaSet)
			{
				var indice = idiomasCLB.Items.IndexOf(idioma);

				if (indice >= 0)
				{
					idiomasCLB.SetItemChecked(indice, true);
				}
			}
		}

		/// <summary>
		/// Obtiene todos los idiomas y las asocia con el CheckedListBox
		/// </summary>
		private void ObtenerIdiomas()
		{
			var listaIdiomas = Manager
				.GetRepository<IdiomaRepository>()
				.GetAll();

			idiomasCLB.DataSource = listaIdiomas;
			idiomasCLB.DisplayMember = "DescripcionIdioma";
		}

		#endregion
	}
}
