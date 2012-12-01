using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Data.EF;

namespace Kenwin.PPP.Negocio.Repositorios
{
    public class PersonaRepository: BaseRepository<PPPObjectContext, Persona>
    {
		public PersonaRepository(RepositoryManager<PPPObjectContext> repositoryManager)
            : base(repositoryManager)
        {
        }
	}
}
