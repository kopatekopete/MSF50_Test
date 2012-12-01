using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using Kenwin.PPP.Cliente.Comun;
using Kenwin.PPP.Cliente.Comun.Formularios;
using Kenwin.PPP.Negocio.Comun;
using Kenwin.PPP.Negocio.Entidades;
using Kenwin.PPP.Negocio.Entidades.Filtros;
using Kenwin.PPP.Negocio.Modelo;
using Kenwin.PPP.Negocio.Repositorios;
using Vemn.Fwk.Data.Linq;
using Vemn.Fwk.Windows.Controls.Extensions;

namespace Kenwin.PPP.Cliente.Proyectos
{
    public partial class Buscador : PPPFormBase
    {
        private readonly BindingSource _grillaBindingSource = new BindingSource();

        /// <summary>
        /// Flag que indica si se esta actualizando el CheckedListBox del filtro de Estados.
        /// Es para evitar que salte el evento ItemCheck.
        /// </summary>
        private bool _marcandoEstados;

        private ResumenProyecto _itemSeleccionado;

		private int _ordenamientoColumna;
		private SortFlags _ordenamientoDireccion;

        #region Constructores
        public Buscador()
        {
            InitializeComponent();
        }
        #endregion

        #region Propiedades

        public override bool PermiteMultiplesInstancias
        {
            get { return false; }
        }

        #endregion

        #region Metodos Privados

        /// <summary>
        /// Carga los datos y configura los filtros de busqueda.
        /// </summary>
        private void PrepararFiltros()
        {
            //Lista de Estados
            List<EstadoProyecto> listaEstados = RepositoryManager
                .GetRepository<EstadoProyectoRepository>()
                .EstadoProyectoSet.ToList();

            listaEstados.Insert(0, new EstadoProyecto { DescripcionEstadoProyecto = "<Todos>", IdEstadoProyecto = -1 });
            filtroEstadosCheckedListBox.DataSource = null;
            filtroEstadosCheckedListBox.DataSource = listaEstados;
            filtroEstadosCheckedListBox.DisplayMember = "DescripcionEstadoProyecto";
            filtroEstadosCheckedListBox.SetItemChecked(0, true);

            //Combo de Paises
            List<Pais> listaPaises = RepositoryManager
                .GetRepository<PaisRepository>()
                .ObtenerPaises(null);

            listaPaises = listaPaises.OrderBy(x => x.DescripcionPais).ToList();

            listaPaises.Insert(0, new Pais { DescripcionPais = "<Todos>", IdPais = -1 });
            filtroPaisComboBox.DataSource = listaPaises;
            filtroPaisComboBox.DisplayMember = "DescripcionPais";

            //Combo de Unidades de Negocio
            List<UnidadNegocio> listaUnidadesNegocio = RepositoryManager
                .GetRepository<UnidadNegocioRepository>()
                //HACK: evitar esto agregando una sobrecarga que no tenga parametro?
                .ObtenerUnidadesNegocio(null);

            //HACK: El order by no deberia estar en el metodo ObtenerUnidadesNegocio?
            listaUnidadesNegocio = listaUnidadesNegocio
                .OrderBy(x => x.DescripcionUnidadNegocio)
                .ToList();

            listaUnidadesNegocio.Insert(0, new UnidadNegocio { DescripcionUnidadNegocio = "<Todos>", IdUnidadNegocio = -1 });
            filtroUnidadNegocioComboBox.DataSource = listaUnidadesNegocio;
            filtroUnidadNegocioComboBox.DisplayMember = "DescripcionUnidadNegocio";
        }

        private void ConfigurarGrilla()
        {
            proyectosC1FlexGrid.DataSource = _grillaBindingSource;

            var columnsEditor = proyectosC1FlexGrid.ColumnEditor<ResumenProyecto>();

            //Definicion de las columnas
            columnsEditor.AddColumn(x => x.EstadoDescripcion, "Estado", 100);
            columnsEditor.AddColumn(x => x.NombreProyectoPadre, "Proyecto Padre", 100);
			columnsEditor.AddColumn(x => x.OrdenTrabajoCodigo, "OT", 100);
			columnsEditor.AddColumn(x => x.AvancePorcentaje, "Avance", 50);
			columnsEditor.AddColumn(x => x.UsuarioLiderSiglas, "Líder", 50);
			columnsEditor.AddColumn(x => x.ProductividadPorcentaje, "Productividad", 60);
			columnsEditor.AddColumn(x => x.FechaInicio, "Inicio Proyecto", 80);
			columnsEditor.AddColumn(x => x.UltimaActualizacion, "Actualizado a", 80);
			columnsEditor.AddColumn(x => x.DiasDisponibles, "Días Disponibles", 70);
			columnsEditor.AddColumn(x => x.PrecioFinal, "Precio Final", 70);
			columnsEditor.AddColumn(x => x.MonedaDescripcion, "Moneda", 50);
			columnsEditor.AddColumn(x => x.TotalCOPC, "COPC", 60);
			columnsEditor.AddColumn(x => x.TotalNoCOPC, "No COPC", 60);
			var columnaNombre = columnsEditor.AddColumn(x => x.NombreProyecto, "Nombre", 100);
            var columnaProbabilidad = columnsEditor.AddColumn(x => x.Probabilidad, "Probabilidad", 80);
        	columnaProbabilidad.Format = Formatos.FormatoPorcentaje;
            columnsEditor.AddColumn(x => x.PaisDescripcion, "País", 80);
            columnsEditor.AddColumn(x => x.UnidadNegocioDescripcion, "UN", 70);
            columnsEditor.AddColumn(x => x.ClienteDescripcion, "Cliente", 120);
            columnsEditor.AddColumn(x => x.UsuarioCreadorSiglas, "Creador", 50);

			//Configurar ordenamiento por defecto
			_ordenamientoColumna = columnaNombre.SafeIndex;
			_ordenamientoDireccion = SortFlags.Ascending;
        }

        private void ObtenerDatos()
        {
            FiltroResumenProyecto filtro = ObtenerFiltro();

			var nombreColumna = proyectosC1FlexGrid.Cols[_ordenamientoColumna].Name;
			var descendente = (_ordenamientoDireccion == SortFlags.Descending) ? " DESC" : " ASC";
			var ordenamiento = nombreColumna + descendente;

            List<ResumenProyecto> listaProyectos = RepositoryManager.GetRepository<ProyectoRepository>()
				.ObtenerResumenesProyecto(filtro, ordenamiento);

            _grillaBindingSource.DataSource = listaProyectos;

			//mostrar triangulito de ordenamiento
			proyectosC1FlexGrid.ShowSortAt(_ordenamientoDireccion, _ordenamientoColumna);
        }

        /// <summary>
        /// Prepara un objeto FiltroResumenProyecto con los datos de los filtros de busqueda elegidos.
        /// </summary>
        /// <returns></returns>
        private FiltroResumenProyecto ObtenerFiltro()
        {
            var nuevoFiltro = new FiltroResumenProyecto();

            //Fecha Inicio
            nuevoFiltro.FechaInicioAnteriorA = filtroFechaInicioDateTimeBox.Value;

            //Codigo OT
            nuevoFiltro.CodigoOT = filtroCodigoOTTextBox.Text;

            //Pais
            var paisSeleccionado = (Pais)filtroPaisComboBox.SelectedItem;
            if (paisSeleccionado != null && paisSeleccionado.IdPais != -1)
            {
                nuevoFiltro.IdPais = paisSeleccionado.IdPais;
            }

            //Unidad de Negocio
            var unidadNegocioSeleccionado = (UnidadNegocio)filtroUnidadNegocioComboBox.SelectedItem;
            if (unidadNegocioSeleccionado != null && unidadNegocioSeleccionado.IdUnidadNegocio != -1)
            {
                nuevoFiltro.IdUnidadNegocio = unidadNegocioSeleccionado.IdUnidadNegocio;
            }

            //Cliente
            nuevoFiltro.ClienteDescripcion = filtroClienteTextBox.Text;

            //Estados
            nuevoFiltro.ListaIdEstados = filtroEstadosCheckedListBox.CheckedItems
                .OfType<EstadoProyecto>()
                .Where(x => x.IdEstadoProyecto != -1)
                .Select(x => x.IdEstadoProyecto)
                .ToList();

            //Proyecto Padre
            nuevoFiltro.NombreProyectoPadre = filtroProyectoPadreTextBox.Text;

            //Nombre Proyecto
            nuevoFiltro.NombreProyecto = filtroNombreProyectoTextBox.Text;

            return nuevoFiltro;
        }

        /// <summary>
        /// Abre la ventana de edicion de proyectos.
        /// </summary>
        /// <param name="idProyecto">Indica el Id del proyecto a editar.</param>
        private static void AbrirProyecto(int idProyecto)
        {
            var editorForm = new Editor(idProyecto);
            ContextoAplicacion.Instancia.FormularioPrincipal.MostrarFormularioHijo(editorForm, FormWindowState.Maximized);
        }

        private void LimpiarFormulario()
        {
            filtroFechaInicioDateTimeBox.Value = null;
            filtroClienteTextBox.Clear();
            filtroCodigoOTTextBox.Clear();
            filtroProyectoPadreTextBox.Clear();
            filtroNombreProyectoTextBox.Clear();

            _grillaBindingSource.Clear();

            PrepararFiltros();
        }

        #endregion

        #region Manejadores de eventos

        private void BuscarButton_Click(object sender, EventArgs e)
		{
			ObtenerDatos();
		}

        private void Buscador_Load(object sender, EventArgs e)
        {
            ConfigurarGrilla();
            PrepararFiltros();
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            var nroFila = proyectosC1FlexGrid.Row;
            if (proyectosC1FlexGrid.IsCellValid(nroFila, 0))
            {
                var datosProyecto = proyectosC1FlexGrid.Rows[nroFila].DataSource as ResumenProyecto;

                if (datosProyecto != null)
                {
                    AbrirProyecto(datosProyecto.IdProyecto);
                }
            }
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProyectosC1FlexGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hitTestInfo = proyectosC1FlexGrid.HitTest(e.X, e.Y);

            //Si el doble click se hizo sobre una celda...
            if (proyectosC1FlexGrid.IsCellValid(hitTestInfo.Row, hitTestInfo.Column))
            {
                //Obtiene los datos de la fila y muestra el proyecto
                var proyecto = proyectosC1FlexGrid.Rows[hitTestInfo.Row].DataSource as ResumenProyecto;
                if (proyecto != null)
                {
                    AbrirProyecto(proyecto.IdProyecto);
                }
            }
        }

        private void FiltroEstadosCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_marcandoEstados)
            {
                return;
            }

            if (e.Index == 0)
            {
                //Si se esta tildando el item de "Todos"
                if (e.NewValue == CheckState.Checked)
                {
                    //Desmarcar todos los items
                    _marcandoEstados = true;
                    for (int i = 1; i < filtroEstadosCheckedListBox.Items.Count; i++)
                    {
                        filtroEstadosCheckedListBox.SetItemCheckState(i, CheckState.Indeterminate);
                    }
                    _marcandoEstados = false;
                }
                else
                {
                    //Volver a marcar el item Todos
                    e.NewValue = CheckState.Checked;
                }
            }
            else
            {
                //Se esta cambiando cualquier otro item

                //Si el "Todos" esta marcado
                if (filtroEstadosCheckedListBox.GetItemCheckState(0) == CheckState.Checked)
                {
                    _marcandoEstados = true;

                    //Desmarcar "Todos"
                    filtroEstadosCheckedListBox.SetItemCheckState(0, CheckState.Unchecked);

                    //Limpiar los otros items
                    for (int i = 1; i < filtroEstadosCheckedListBox.Items.Count; i++)
                    {
                        if (filtroEstadosCheckedListBox.GetItemCheckState(i) == CheckState.Indeterminate)
                        {
                            filtroEstadosCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
                        }
                    }

                    e.NewValue = CheckState.Checked;
                    _marcandoEstados = false;
                }
                //Si se esta desmarcando el ultimo item
                else if (e.NewValue == CheckState.Unchecked && filtroEstadosCheckedListBox.CheckedIndices.Count == 1)
                {
                    //marcar el item "Todos"
                    filtroEstadosCheckedListBox.SetItemChecked(0, true);
                    e.NewValue = CheckState.Indeterminate;
                }
            }
        }

        private void ProyectosC1FlexGrid_RowColChange(object sender, EventArgs e)
        {
            var nroFila = proyectosC1FlexGrid.Row;
            if (proyectosC1FlexGrid.IsCellValid(nroFila, 0))
            {
                var datosProyecto = proyectosC1FlexGrid.Rows[nroFila].DataSource as ResumenProyecto;
                if (datosProyecto != null)
                {
                    aceptarButton.Enabled = true;
                }
            }

        }

        #endregion

        private void ProyectosC1FlexGrid_AfterSort(object sender, SortColEventArgs e)
        {
            if (_itemSeleccionado != null)
            {
                //Buscar el item seleccionado y actualizar la seleccion
                for (int i = 0; i < proyectosC1FlexGrid.Rows.Count; i++)
                {
                    var dato = proyectosC1FlexGrid.Rows[i].DataSource as ResumenProyecto;
                    if (dato != null && dato.IdProyecto == _itemSeleccionado.IdProyecto)
                    {
                        proyectosC1FlexGrid.Select(i, -1, true);
                        return;
                    }
                }
            }
            //Si no existe el item seleccionado, se vacia la seleccion
            proyectosC1FlexGrid.Select(-1, -1);
        }

        private void ProyectosC1FlexGrid_BeforeSort(object sender, SortColEventArgs e)
        {
            var nroFilaActual = proyectosC1FlexGrid.Row;

            if (proyectosC1FlexGrid.IsCellValid(nroFilaActual, 0))
            {
                //Si la celda seleccionada es valida, se guarda el item
                _itemSeleccionado = proyectosC1FlexGrid.Rows[nroFilaActual].DataSource as ResumenProyecto;
            }
            else
            {
                _itemSeleccionado = null;
            }

			if (proyectosC1FlexGrid.Cols[e.Col] == null)
			{
				return;
			}

			_ordenamientoColumna = e.Col;
			_ordenamientoDireccion = e.Order;

			ObtenerDatos();
        }
    }
}
