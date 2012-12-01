using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Data.EF;

namespace Kenwin.PPP.Negocio.Repositorios
{
    public class TipoEmpresaRepository: BaseRepository<PPPObjectContext, TipoEmpresa>
    {
        public TipoEmpresaRepository(RepositoryManager<PPPObjectContext> repositoryManager)
            : base(repositoryManager)
        {
        }
    }
}
