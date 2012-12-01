using System.Text.RegularExpressions;

namespace Kenwin.PPP.Cliente.Comun
{
	public static class ClaseValidadora
	{
		/// <summary>
		/// Retorna true si el string tiene un formato de email valido
		/// </summary>
		/// <param name="valor"></param>
		/// <returns></returns>
		public static bool EsEmailValido(string valor)
		{
			return Regex.IsMatch(valor,
				   @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
				   @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
		}
	}
}
