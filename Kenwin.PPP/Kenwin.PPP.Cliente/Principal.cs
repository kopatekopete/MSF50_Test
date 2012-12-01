using System;
using System.Windows.Forms;
using Kenwin.PPP.Cliente.ABMs;
using Kenwin.PPP.Cliente.Comun.Formularios;
using Kenwin.PPP.Cliente.Proyectos;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Kenwin.PPP.Cliente.Comun;

namespace Kenwin.PPP.Cliente
{
    public partial class Principal : PPPMDIFormBase
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InstanciarFormularioHijo<Buscador>(FormWindowState.Maximized);

            ConfigurarMenu();
        }

        /// <summary>
        /// Crea los items del menu y asigna los eventos
        /// </summary>
        private void ConfigurarMenu()
        {
            //TODO
            mainMenuStrip.MdiWindowListItem = toolStripMenuItem2;
        }

        private void BuscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciarFormularioHijo<Buscador>(FormWindowState.Maximized);
        }

        private void DesdeTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciarDialogo<SeleccionTemplate>();
        }

        private void VacioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextoAplicacion.Instancia.FormularioPrincipal.InstanciarFormularioHijo<Editor>();
        }

		private void AbmClienteTSMI_Click(object sender, EventArgs e)
		{
			InstanciarFormularioHijo<ABMCliente>(FormWindowState.Maximized);
		}

		private void AbmTarifaTSMI_Click(object sender, EventArgs e)
		{
			InstanciarFormularioHijo<ABMTarifa>(FormWindowState.Maximized);
		}

		private void AbmIdiomaTSMI_Click(object sender, EventArgs e)
		{
			InstanciarFormularioHijo<ABMIdioma>(FormWindowState.Maximized);
		}

		private void AbmPaisTSMI_Click(object sender, EventArgs e)
		{
			InstanciarFormularioHijo<ABMPais>(FormWindowState.Maximized);
		}

		private void AbmUnidadNegocioTSMI(object sender, EventArgs e)
		{
			InstanciarFormularioHijo<ABMUnidadNegocio>(FormWindowState.Maximized);
		}

		private void AbmRolTSMI_Click(object sender, EventArgs e)
		{
			InstanciarFormularioHijo<ABMRol>(FormWindowState.Maximized);
		}

		private void AbmPersonaTSMI_Click(object sender, EventArgs e)
		{
			InstanciarFormularioHijo<ABMPersona>(FormWindowState.Maximized);
		}

		private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			InstanciarFormularioHijo<Prueba>(FormWindowState.Maximized);
		}

		private void Principal_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = this.CerrarSolapas(e.CloseReason);
		}

		/// <summary>
		/// Cierra todas las solapas abiertas por el usuario
		/// </summary>
		private bool CerrarSolapas(CloseReason cr)
		{
			try
			{
				//Por cada ventana MDI abierta, cerrarla y verificar el resultado
				foreach (var form in this.MdiChildren)
				{
					form.Close();

					if (form.DialogResult == DialogResult.Cancel)
					{
						//cancelar el cierre de las solapas
						return true;
					}
				}
			}
			catch (Exception ex)
			{
				ExceptionPolicy.HandleException(ex, Constantes.ElErrorPolicy);
			}

			return false;
		}
    }
}
