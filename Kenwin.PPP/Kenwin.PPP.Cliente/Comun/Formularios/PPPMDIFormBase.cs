using System.Linq;
using System.Windows.Forms;

namespace Kenwin.PPP.Cliente.Comun.Formularios
{
    public class PPPMDIFormBase:PPPFormBase
    {
        /// <summary>
        /// Crea una instancia de un formulario hijo y lo muestra.
        /// </summary>
        /// <typeparam name="T">Tipo del formulario hijo a instanciar.</typeparam>
        public void InstanciarFormularioHijo<T>() where  T : Form, new()
        {
            InstanciarFormularioHijo<T>(FormWindowState.Normal);
        }

        /// <summary>
        /// Crea una instancia de un formulario hijo y lo muestra.
        /// </summary>
        /// <typeparam name="T">Tipo del formulario hijo a instanciar.</typeparam>
        /// <param name="estadoInicial">Forma en la que se abre el formulario.</param>
        public void InstanciarFormularioHijo<T>(FormWindowState estadoInicial) where T : Form, new()
        {
            //Crea la instancia del formulario
            var formHijo = new T();

            //Si el formulario es tipo FormBase y no permite multiples instancias...
            var formTipoBase = formHijo as IPPPForm;
            if (formTipoBase != null && !formTipoBase.PermiteMultiplesInstancias)
            {
                //Busca si existe alguna instancia del tipo de formulario
                var anotherInstance = MdiChildren.Where(x => x.GetType() == typeof(T)).FirstOrDefault();
                if (anotherInstance != null)
                {
                    //Si el formulario hijo esta minimizado, lo restaura.
                    if (anotherInstance.WindowState == FormWindowState.Minimized)
                    {
                        anotherInstance.WindowState = estadoInicial;
                    }
                    anotherInstance.Activate();
                    return;
                }
            }

            //Abre el formulario y lo asocia como hijo
            formHijo.MdiParent = this;
            formHijo.WindowState = estadoInicial;
            formHijo.Show();

        }

        /// <summary>
        /// Crea una instancia de un formulario y los abre como Dialogo.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public DialogResult InstanciarDialogo<T>() where T : Form, new()
        {
            //Crea la instancia del formulario
            var formHijo = new T();
            formHijo.StartPosition = FormStartPosition.CenterParent;
            formHijo.FormBorderStyle = FormBorderStyle.SizableToolWindow;

            return formHijo.ShowDialog();
        }

        public void MostrarFormularioHijo(Form formHijo, FormWindowState estadoInicial)
        {
            //Abre el formulario y lo asocia como hijo
            formHijo.MdiParent = this;
            formHijo.WindowState = estadoInicial;
            formHijo.Show();
        }

    }
}
