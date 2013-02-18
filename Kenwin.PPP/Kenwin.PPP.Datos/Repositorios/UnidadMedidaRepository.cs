using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Data.EF;

namespace Kenwin.PPP.Negocio.Repositorios
{
    public class UnidadMedidaRepository: BaseRepository<PPPObjectContext, UnidadMedida>
    {
		public UnidadMedidaRepository(RepositoryManager<PPPObjectContext> repositoryManager)
            : base(repositoryManager)
        {
        }
    }
}
