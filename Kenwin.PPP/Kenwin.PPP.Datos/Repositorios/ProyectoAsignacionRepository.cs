using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Data.EF;

namespace Kenwin.PPP.Negocio.Repositorios
{
	public class ProyectoAsignacionRepository : BaseRepository<PPPObjectContext, ProyectoAsignacion>
    {
		public ProyectoAsignacionRepository(RepositoryManager<PPPObjectContext> repositoryManager)
            : base(repositoryManager)
        {
        }
    }
}
