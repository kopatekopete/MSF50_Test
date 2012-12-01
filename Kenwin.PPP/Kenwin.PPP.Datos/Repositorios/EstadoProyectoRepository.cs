using System.Linq;
using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Data.EF;

namespace Kenwin.PPP.Negocio.Repositorios
{
    public class EstadoProyectoRepository : BaseRepository<PPPObjectContext, EstadoProyecto>
    {
        public EstadoProyectoRepository(RepositoryManager<PPPObjectContext> repositoryManager): base(repositoryManager)
        {

        }

        public IQueryable<EstadoProyecto> EstadoProyectoSet
        {
            get { return RepositoryManager.ObjectContext.EstadoProyectoSet; }
        }
    }
}
