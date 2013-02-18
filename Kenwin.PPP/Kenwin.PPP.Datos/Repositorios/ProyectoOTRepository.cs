using System.Collections.Generic;
using System.Linq;
using Kenwin.PPP.Negocio.Entidades;
using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Common;
using Vemn.Fwk.Data.EF;

namespace Kenwin.PPP.Negocio.Repositorios
{
    public class ProyectoOTRepository: BaseRepository<PPPObjectContext, ProyectoOT>
    {
        public ProyectoOTRepository(RepositoryManager<PPPObjectContext> repositoryManager)
            : base(repositoryManager)
        {
        }

		public List<ProyectoOT> ObtenerProyectosOTPorIdPadre(FilterSortPaging fsp, int idProyectoPadre)
		{
			var lista = ObjectContext.ProyectoOTSet
				.Where(ObjectContext, fsp.FilterData)
				.Where(x => x.IdProyectoPadre == idProyectoPadre)	//Los proyectosOT deben ser del padre indicado
				.OrderBy(fsp.SortData)
				.Paging(fsp.PagingData)
				.ToList();

			return lista;
		}
    }
}
