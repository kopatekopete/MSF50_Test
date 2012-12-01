using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Kenwin.PPP.Negocio.Modelo;
using Kenwin.PPP.Negocio.Repositorios;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Kenwin.PPP.Cliente.Comun;
using System.Threading;
using System.Diagnostics;
using Vemn.Fwk.Windows.Tools;

namespace Kenwin.PPP.Cliente
{
    static class Program
    {
		//El mutex debe ser una variable estatica para que el garbage colector no la borre
		private static Mutex _mutexUnico;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			if (!VerificarUnicaInstanciaDeAplicacion())
			{
				MessageHelper.MostrarMensajeInfo("La aplicación ya se está ejecutando.");
				return;
			}

			AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
			Application.ThreadException += Application_ThreadExceptionHandler;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

			try
			{
				ConfigurarCultura();

				if (!VerificarConexionDB())
				{
					MessageHelper.MostrarMensajeAlto("Error", "No es posible conectarse con la base de datos.");
					return;
				}

				InicializarContexto();

				//Inicia la aplicacion y muestra el formulario principal
				Application.Run(ContextoAplicacion.Instancia.FormularioPrincipal);
			}
			catch (Exception ex)
			{
				ExceptionPolicy.HandleException(ex, Constantes.ElErrorPolicy);
			}
        }

        private static void InicializarContexto()
        {
            var contexto = ContextoAplicacion.Instancia;

            contexto.FormularioPrincipal = new Principal();

            //TODO: Obtener usuario desde login
			//Obtiene el usuario ADR, como usuario de prueba
            contexto.UsuarioLogueado = RepositoryFactory.GetManager()
                .ObjectContext.PersonaSet
				.Where(x => x.Alias == "ADR")
                .FirstOrDefault();

			if(contexto.UsuarioLogueado == null)
			{
				//Si no existe, obtiene el primero que encuentre en la tabla.
				contexto.UsuarioLogueado = RepositoryFactory.GetManager()
				.ObjectContext.PersonaSet
				.First();
			}
        }

		private static void ConfigurarCultura()
		{
			var nfi = new NumberFormatInfo
			{
				//Moneda
				CurrencyDecimalDigits = 2,
				CurrencyDecimalSeparator = ".",
				CurrencyGroupSeparator = ",",
				CurrencySymbol = "$",

				//Numeros
				NumberDecimalDigits = 2,
				NumberDecimalSeparator = ".",
				NumberGroupSeparator = ",",

				//Porcentaje
				PercentDecimalDigits = 2,
				PercentDecimalSeparator = ".",
				PercentGroupSeparator = ",",
			};

			var ci = new CultureInfo("es-AR") { NumberFormat = nfi };

			Application.CurrentCulture = ci;
		}

        static bool VerificarConexionDB()
        {
            PPPObjectContext objectContext;
            try
            {
                objectContext = new PPPObjectContext();
                objectContext.Connection.Open();
                objectContext.ProyectoSet.Count();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

		private static bool VerificarUnicaInstanciaDeAplicacion()
		{
			bool esPrimeraInstancia;
			
			var nombreProceso = Process.GetCurrentProcess().ProcessName;

			//Crear un mutex con el nombre del proceso para evitar que se cree mas de una instancia de la aplicacion
			_mutexUnico = new Mutex(true, nombreProceso, out esPrimeraInstancia);

			return esPrimeraInstancia;
		}

		#region Manejadores de excepciones
		
		private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			if (e.ExceptionObject == null || !(e.ExceptionObject is Exception))
				return;

			Exception ex = (Exception)e.ExceptionObject;
			ExceptionPolicy.HandleException(ex, Constantes.ElErrorPolicy);
			Application.Exit();
		}

		private static void Application_ThreadExceptionHandler(object sender, ThreadExceptionEventArgs e)
		{
			if (e.Exception == null)
				return;

			var a = AppDomain.CurrentDomain.GetAssemblies();
			ExceptionPolicy.HandleException(e.Exception, Constantes.ElErrorPolicy);
		}
		
		#endregion
    }
}
