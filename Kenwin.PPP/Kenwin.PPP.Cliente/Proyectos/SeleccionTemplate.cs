using System;
using System.Windows.Forms;
using Kenwin.PPP.Cliente.Comun.Formularios;
using Kenwin.PPP.Negocio.Entidades;
using Kenwin.PPP.Negocio.Repositorios;
using Vemn.Fwk.Windows.Controls.Extensions;

namespace Kenwin.PPP.Cliente.Proyectos
{
    public partial class SeleccionTemplate : PPPFormBase
    {
        private readonly BindingSource _grillaBindingSource = new BindingSource();

        #region Constructores

        public SeleccionTemplate()
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

        private void ConfigurarGrilla()
        {
            proyectosC1FlexGrid.DataSource = _grillaBindingSource;

            var columnsEditor = proyectosC1FlexGrid.ColumnEditor<ResumenProyecto>();

            columnsEditor.AddColumn(x => x.PaisDescripcion, "País", 80);
            columnsEditor.AddColumn(x => x.UnidadNegocioDescripcion, "UN", 50);
            columnsEditor.AddColumn(x => x.UsuarioCreadorSiglas, "Creador", 50);
            columnsEditor.AddColumn(x => x.ClienteDescripcion, "Cliente", 120);
            columnsEditor.AddColumn(x => x.OrdenTrabajoCodigo, "OT", 100);
            columnsEditor.AddColumn(x => x.MonedaDescripcion, "Moneda", 50);
            columnsEditor.AddColumn(x => x.UsuarioLiderSiglas, "Líder", 50);
        }

        private void ObtenerDatos()
        {
            var listaProyectosTemplate = RepositoryManager.GetRepository<ProyectoRepository>()
                .ObtenerProyectosTemplate();

            _grillaBindingSource.DataSource = listaProyectosTemplate;
        }

        #endregion

        #region Manejadores de eventos

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Buscador_Load(object sender, EventArgs e)
        {
            ConfigurarGrilla();
            ObtenerDatos();
        }

        #endregion

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Crear proyecto basado en Template seleccionado.", "Funcionalidad pendiente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void proyectosC1FlexGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hitTestInfo = proyectosC1FlexGrid.HitTest(e.X, e.Y);

            if (proyectosC1FlexGrid.IsCellValid(hitTestInfo.Row, hitTestInfo.Column))
            {
                var proyecto = proyectosC1FlexGrid.Rows[hitTestInfo.Row].DataSource as ResumenProyecto;
                if (proyecto != null)
                {
                    MessageBox.Show("Crear proyecto basado en Template seleccionado.", "Funcionalidad pendiente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}