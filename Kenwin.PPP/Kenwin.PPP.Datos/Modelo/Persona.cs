using System;
using System.Text;
using Vemn.Fwk.Data.EF;

namespace Kenwin.PPP.Negocio.Modelo
{
	public partial class Persona
	{
		public virtual String NombreCompleto
		{
			get
			{
				return String.Format("{0}, {1}", this.Apellido, this.Nombre);
			}
		}

		public String IdiomasDescripcion
		{
			get
			{
				var stringBuilder = new StringBuilder();

				var idiomas = this.IdiomaSet
					.ToListExt();

				if (idiomas == null || idiomas.Count == 0)
				{
					return string.Empty;
				}

				var separador = " - ";

				foreach (var idioma in idiomas)
				{
					stringBuilder.Append(idioma.DescripcionIdioma);
					stringBuilder.Append(separador);
				}

				var length = stringBuilder.ToString().EndsWith(separador)
					? stringBuilder.Length - 3
					: stringBuilder.Length;

				return stringBuilder.ToString(0, length);
			}
		}
	}
}
