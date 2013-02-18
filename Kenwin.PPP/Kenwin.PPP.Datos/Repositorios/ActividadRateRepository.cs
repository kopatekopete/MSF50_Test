using System;
using System.Linq;
using Kenwin.PPP.Negocio.Comun.Excepciones;
using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Data.EF;

namespace Kenwin.PPP.Negocio.Repositorios
{
	public class ActividadRateRepository : BaseRepository<PPPObjectContext, ActividadRate>
	{
		public ActividadRateRepository(RepositoryManager<PPPObjectContext> repositoryManager)
			: base(repositoryManager)
		{
		}

		public override ActividadRate InsertABM(ActividadRate actividadRate)
		{
			this.ValidarInsertar(actividadRate);

			return base.InsertABM(actividadRate);
		}

		private void ValidarInsertar(ActividadRate actividadRate)
		{
			//Validar que cuando EsRateFijo es true CantidadTope debe ser distinto de 0
			if (actividadRate.EsRateFijo && actividadRate.CantidadTope == 0)
			{
				throw new PPPNegocioException("La Cantidad Tope debe ser distinta de cero.");
			}

			var query = ObjectContext.ActividadRateSet
				.Where(x => x.IdActividad == actividadRate.IdActividad)
				.Where(x => x.IdMoneda == actividadRate.IdMoneda)
				.Where(x => x.EsRateFijo == actividadRate.EsRateFijo);

			//Fix para el manejo de entidades nulas, se debe colocar x.IdCliente == null para que EF lo traduzca en 'IS NULL',
			//no puede ser una variable int?, ya que EF lo compara con '= NULL' en SQL, y no funciona
			query = actividadRate.Cliente == null 
				? query.Where(x => x.IdCliente == null) 
				: query.Where(x => x.IdCliente == actividadRate.Cliente.IdCliente);

			query = actividadRate.Pais == null
				? query.Where(x => x.IdPais == null)
				: query.Where(x => x.IdPais == actividadRate.Pais.IdPais);

			var actividadRateRepetida = query.Any();

			if (actividadRateRepetida)
			{
				throw new PPPNegocioException("Ya existe una Tarifa con igual Actividad, Moneda, Pais, Cliente y Tipo de Rate.");
			}
		}
	}
}
