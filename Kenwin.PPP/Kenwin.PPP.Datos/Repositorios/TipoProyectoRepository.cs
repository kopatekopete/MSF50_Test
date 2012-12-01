using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Data.EF;

namespace Kenwin.PPP.Negocio.Repositorios
{
    public class TipoProyectoRepository: BaseRepository<PPPObjectContext, TipoProyecto>
    {
        public TipoProyectoRepository(RepositoryManager<PPPObjectContext> repositoryManager)
            : base(repositoryManager)
        {
        }
    }
}
