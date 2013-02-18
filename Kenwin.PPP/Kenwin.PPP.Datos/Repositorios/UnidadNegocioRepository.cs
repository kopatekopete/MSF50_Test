using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Kenwin.PPP.Negocio.Comun.Excepciones;
using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Data.EF;
using System.Linq;

namespace Kenwin.PPP.Negocio.Repositorios
{
    public class UnidadNegocioRepository : BaseRepository<PPPObjectContext, UnidadNegocio>
    {
        public UnidadNegocioRepository(RepositoryManager<PPPObjectContext> repositoryManager)
            : base(repositoryManager)
        {

        }

        public List<UnidadNegocio> ObtenerUnidadesNegocio()
        {
            return this.ObtenerUnidadesNegocio(null);
        }

        public List<UnidadNegocio> ObtenerUnidadesNegocio(Expression<Func<UnidadNegocio, bool>> condicion)
        {
            var lista = RepositoryManager.ObjectContext.UnidadNegocioSet
                .AsQueryable();

            if(condicion != null)
            {
                lista = lista.Where(condicion);
            }

            return lista.ToList();
        }

		public override UnidadNegocio InsertABM(UnidadNegocio unidadNegocio)
		{
			this.ValidarUnidadNegocio(unidadNegocio);

			return base.InsertABM(unidadNegocio);
		}

		public override UnidadNegocio UpdateABM(UnidadNegocio unidadNegocio)
		{
			this.ValidarUnidadNegocio(unidadNegocio);

			return base.UpdateABM(unidadNegocio);
		}
		
		private void ValidarUnidadNegocio(UnidadNegocio unidadNegocio)
		{
			var descripcionRepetida = ObjectContext.UnidadNegocioSet
				.Where(x => x.IdUnidadNegocio != unidadNegocio.IdUnidadNegocio)
				.Where(x => x.DescripcionUnidadNegocio == unidadNegocio.DescripcionUnidadNegocio)
				.Any();

			if (descripcionRepetida)
			{
				throw new PPPNegocioException("Ya existe una Unidad Negocio con igual descripción.");
			}
		}
    }
}
