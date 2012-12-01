using System;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Windows.Forms;
using Kenwin.PPP.Negocio.Comun.Excepciones;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Configuration;
using Vemn.Fwk.Windows.Tools;

namespace Kenwin.PPP.Cliente.Comun.Excepciones
{
	[ConfigurationElementType(typeof(CustomHandlerData))]
	public class PPPExceptionHandler : IExceptionHandler
	{
		public PPPExceptionHandler(NameValueCollection ignore)
	    {
	    }

	    Exception IExceptionHandler.HandleException(Exception exception, Guid handlingInstanceId)
	    {
	        DialogResult result = this.ShowThreadExceptionDialog(exception, handlingInstanceId);
	        return exception;
	    }

	    /// <summary>
	    /// Crea el mensaje de error y lo muestra
	    /// </summary>
	    /// <param name="ex"></param>
	    /// <param name="handlingInstanceId"></param>
	    /// <returns></returns>
		private DialogResult ShowThreadExceptionDialog(Exception exception, Guid handlingInstanceId)
	    {
			//Capturar las excepciones para las cuales no se quiere mostrar el dialogo de exception, sino un mensaje estandar
			if (exception is PPPNegocioException)
			{
				MessageHelper.MostrarMensajeAlerta(exception.Message);
				return DialogResult.OK;
			}

			//Capturar las excepciones para las cuales se muestra la innerException
			if (exception.InnerException != null)
			{
				if (exception.InnerException is SqlException)
				{
					exception = exception.InnerException;
				}
			}

			var form = new ExceptionMessageBox(exception.Message);
	        
			return form.ShowDialog();
	    }
	}
}
