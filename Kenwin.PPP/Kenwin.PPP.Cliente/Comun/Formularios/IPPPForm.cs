using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Data.EF;

namespace Kenwin.PPP.Cliente.Comun.Formularios
{
	public interface IPPPForm
	{
		/// <summary>
		/// Indica si el formulario puede abrirse mas de 1 vez.
		/// </summary>
		bool PermiteMultiplesInstancias { get; }

		/// <summary>
		/// Devuelve una referencia del RepositoryManager utilizado por el formulario.
		/// </summary>
		RepositoryManager<PPPObjectContext> RepositoryManager { get; }
	}
}
