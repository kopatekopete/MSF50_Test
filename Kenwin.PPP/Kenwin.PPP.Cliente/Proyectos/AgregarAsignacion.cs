using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Kenwin.PPP.Cliente.Comun.Formularios;
using Kenwin.PPP.Negocio.Modelo;
using Kenwin.PPP.Negocio.Repositorios;
using Vemn.Fwk.Data.EF;

namespace Kenwin.PPP.Cliente.Proyectos
{
	public partial class AgregarAsignacion : PPPFormBase
	{
		public List<Persona> ListaAsignados { get; private set; }

		private readonly BindingSource _asignadosBindingSource = new BindingSource();
		private readonly BindingSource _disponiblesBindingSource = new BindingSource();

		public AgregarAsignacion(RepositoryManager<PPPObjectContext> repositoryManager, List<Persona> listaAsignados)
			: base(repositoryManager)
		{
			InitializeComponent();

			if (!DesignMode)
			{
				ListaAsignados = listaAsignados;
				_asignadosBindingSource.DataSource = listaAsignados;
			}
		}

		private void AgregarAsignacion_Load(object sender, EventArgs e)
		{
			if (!DesignMode)
			{
				InicializarFormulario();
			}
		}

		private void InicializarFormulario()
		{
			CargarComboIdiomas();
			CargarComboPaises();
			CargarComboUnidadesNegocio();

			BuscarDisponibles();

			ConfigurarBindings();
		}

		private void ConfigurarBindings()
		{
			asignadosListBox.DataSource = _asignadosBindingSource;
			asignadosListBox.DisplayMember = "Alias";

			disponiblesListBox.DataSource = _disponiblesBindingSource;
			disponiblesListBox.DisplayMember = "Alias";
		}

		private void CargarComboIdiomas()
		{
			var listaIdiomas = RepositoryManager
				.GetRepository<IdiomaRepository>()
				.GetAll();

			listaIdiomas.Insert(0, new Idioma { DescripcionIdioma = "<Todos>" });

			idiomaComboBox.DataSource = listaIdiomas;
			idiomaComboBox.DisplayMember = "DescripcionIdioma";
			idiomaComboBox.ValueMember = "IdIdioma";
		}

		private void CargarComboPaises()
		{
			var listaPaises = RepositoryManager
				.GetRepository<PaisRepository>()
				.GetAll();

			listaPaises.Insert(0, new Pais { DescripcionPais = "<Todos>" });

			paisComboBox.DataSource = listaPaises;
			paisComboBox.DisplayMember = "DescripcionPais";
			paisComboBox.ValueMember = "IdPais";
		}

		private void CargarComboUnidadesNegocio()
		{
			var listaUnidadesNegocio = RepositoryManager
				.GetRepository<UnidadNegocioRepository>()
				.GetAll();

			listaUnidadesNegocio.Insert(0, new UnidadNegocio { DescripcionUnidadNegocio = "<Todos>" });

			unidadNegocioComboBox.DataSource = listaUnidadesNegocio;
			unidadNegocioComboBox.DisplayMember = "DescripcionUnidadNegocio";
			unidadNegocioComboBox.ValueMember = "IdUnidadNegocio";
		}

		private void BuscarButton_Click(object sender, EventArgs e)
		{
			BuscarDisponibles();
		}

		private void BuscarDisponibles()
		{
			var consultoresQuery = RepositoryManager
				.GetRepository<PersonaRepository>()
				.GetAll()
				.OrderBy(x=>x.Alias)
				.AsQueryable();

			var idIdioma = (int) idiomaComboBox.SelectedValue;
			if(idIdioma != 0)
			{
				consultoresQuery = consultoresQuery.Where(c => c.IdiomaSet.Any(i => i.IdIdioma == idIdioma));
			}

			var idPais = (int)paisComboBox.SelectedValue;
			if (idPais != 0)
			{
				consultoresQuery = consultoresQuery.Where(c => c.IdPaisResidencia == idPais);
			}

			var idUnidadNegocio = (int)unidadNegocioComboBox.SelectedValue;
			if (idUnidadNegocio != 0)
			{
				consultoresQuery = consultoresQuery
					.Where(c => c.PaisResidencia.UnidadNegocioSet.Any(x => x.IdUnidadNegocio == idUnidadNegocio));
			}

			var listaDisponibles = consultoresQuery
				.WhereNotIn(x => x.IdPersona, ListaAsignados.Select(x => x.IdPersona))
				.ToList();

			_disponiblesBindingSource.DataSource = listaDisponibles;
		}

		private void AgregarButton_Click(object sender, EventArgs e)
		{
			AgregarItemSeleccionado();
		}

		private void AgregarItemSeleccionado()
		{
			var seleccionado = disponiblesListBox.SelectedItem as Persona;
			if (seleccionado != null)
			{
				_asignadosBindingSource.Add(seleccionado);
				ReordenarAsignados();
				_disponiblesBindingSource.Remove(seleccionado);
			}
		}

		private void ReordenarAsignados()
		{
			var listaAnterior = (List<Persona>)_asignadosBindingSource.DataSource;

			var listaAsignados = listaAnterior
				.OrderBy(x => x.Alias)
				.ToList();

			ListaAsignados = listaAsignados;
			_asignadosBindingSource.DataSource = listaAsignados;
		}

		private void QuitarItemSeleccionado()
		{
			var seleccionado = asignadosListBox.SelectedItem as Persona;
			if (seleccionado != null)
			{
				_asignadosBindingSource.Remove(seleccionado);
				BuscarDisponibles();
			}
		}

		private void QuitarButton_Click(object sender, EventArgs e)
		{
			QuitarItemSeleccionado();
		}

		private void AceptarButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			this.Close();
		}

		private void CerrarButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void AsignadosListBox_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			QuitarItemSeleccionado();
		}

		private void DisponiblesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			AgregarItemSeleccionado();
		}

		private void LimpiarButton_Click(object sender, EventArgs e)
		{
			idiomaComboBox.SelectedIndex = 0;
			unidadNegocioComboBox.SelectedIndex = 0;
			paisComboBox.SelectedIndex = 0;
			BuscarDisponibles();
		}
	}
}
