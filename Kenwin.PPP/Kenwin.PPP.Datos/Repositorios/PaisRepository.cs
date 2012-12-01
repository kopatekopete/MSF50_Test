using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Kenwin.PPP.Negocio.Comun.Excepciones;
using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Data.EF;

namespace Kenwin.PPP.Negocio.Repositorios
{
    public class PaisRepository : BaseRepository<PPPObjectContext, Pais>
    {
        public PaisRepository(RepositoryManager<PPPObjectContext> repositoryManager)
            : base(repositoryManager)
        {

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="condicion"></param>
        /// <returns></returns>
        public List<Pais> ObtenerPaises(Expression<Func<Pais, bool>> condicion)
        {
            var paisesQuery = RepositoryManager.ObjectContext.PaisSet
                .AsQueryable();

            if(condicion != null)
            {
                paisesQuery = paisesQuery.Where(condicion);
            }

            return paisesQuery.ToList();
        }

		public override Pais InsertABM(Pais pais)
		{
			this.ValidarPais(pais);

			return base.InsertABM(pais);
		}

		public override Pais UpdateABM(Pais pais)
		{
			this.ValidarPais(pais);

			return base.UpdateABM(pais);
		}

		private void ValidarPais(Pais pais)
		{
			var descripcionRepetida = ObjectContext.PaisSet
				.Where(x => x.IdPais != pais.IdPais)
				.Where(x => x.DescripcionPais == pais.DescripcionPais)
				.Any();

			if (descripcionRepetida)
			{
				throw new PPPNegocioException("Ya existe una País con igual descripción.");
			}

			var siglaRepetida = ObjectContext.PaisSet
				.Where(x => x.IdPais != pais.IdPais)
				.Where(x => x.Sigla == pais.Sigla)
				.Any();

			if (siglaRepetida)
			{
				throw new PPPNegocioException("Ya existe una País con igual sigla.");
			}
		}
    }
}
