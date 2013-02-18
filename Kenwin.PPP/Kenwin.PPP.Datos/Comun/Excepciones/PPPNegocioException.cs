using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vemn.Fwk.ExceptionManagement;

namespace Kenwin.PPP.Negocio.Comun.Excepciones
{
	/// <summary>
	/// Excepciones que puede retornar una capa de negocio y podria no interesar logear
	/// </summary>
	public class PPPNegocioException : NegocioException
	{
		public PPPNegocioException(string mensaje)
			: base(mensaje)
		{
		}

		public PPPNegocioException(string mensajeConFormato, params object[] parametros)
			: base(String.Format(mensajeConFormato, parametros))
		{
		}
	}
}
