using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Data.EF;

namespace Kenwin.PPP.Negocio.Repositorios
{
    public class ClienteRepository: BaseRepository<PPPObjectContext, Cliente>
    {
        public ClienteRepository(RepositoryManager<PPPObjectContext> repositoryManager)
            : base(repositoryManager)
        {
        }
    }
}
