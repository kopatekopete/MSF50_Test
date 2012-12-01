using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Data.EF;
using System.Collections.Generic;
using Kenwin.PPP.Negocio.Entidades;
using Vemn.Fwk.Common;
using System.Linq;

namespace Kenwin.PPP.Negocio.Repositorios
{
	public class ActividadRepository : BaseRepository<PPPObjectContext, Actividad>
	{
		public ActividadRepository(RepositoryManager<PPPObjectContext> repositoryManager)
			: base(repositoryManager)
		{

		}

		public List<ActividadCustom> GetAllActividadesCustom(FilterSortPaging filterSortPaging)
		{
			//Sobreescribir el filterExpression para que el filtro funcione en los campos de una entidad relacionada
			if (filterSortPaging.FilterData.FilterExpression.Contains("DescripcionTipoActividad"))
			{
				filterSortPaging.FilterData.FilterExpression = filterSortPaging.FilterData.FilterExpression.Replace("DescripcionTipoActividad", "TipoActividad.DescripcionTipoActividad");
			}

			var lista = ObjectContext.ActividadSet
				.Where(ObjectContext, filterSortPaging.FilterData)
				.Where(x=>x.TipoActividad.TipoActividadDato.Any())	//El tipo de actividad tiene que tener al menos un dato definido
				.OrderBy(x => x.TipoActividad.OrdenTipoActividad)	//Orden fijo por el orden del tipo de actidad
				.ThenBy(x => x.Orden)								//y el orden propio de la actividad
				.Paging(filterSortPaging.PagingData)
				.Select(x => new ActividadCustom
				{
					IdActividad = x.IdActividad,
					DescripcionActividad = x.DescripcionActividad,
					Orden = x.Orden,
					IdTipoActividad = x.IdTipoActividad,
					DescripcionTipoActividad = x.TipoActividad.DescripcionTipoActividad,
					OrdenTipoActividad = x.TipoActividad.OrdenTipoActividad
				})
				.ToList();

			return lista;
		}

		/// <summary>
		/// GetAll customizado para que devuelva las entidades con un orden fijo segun lo definido en los campos Orden en la Base de datos.
		/// </summary>
		/// <param name="filterSortPaging"></param>
		/// <returns></returns>
		public List<Actividad> GetAllCustom(FilterSortPaging filterSortPaging)
		{
			var lista = ObjectContext.ActividadSet
				.Where(ObjectContext, filterSortPaging.FilterData)
				.OrderBy(x => x.TipoActividad.OrdenTipoActividad)	//Orden fijo por el orden del tipo de actidad
				.ThenBy(x => x.Orden)								//y el orden propio de la actividad
				.Paging(filterSortPaging.PagingData)
				.ToList();

			return lista;
		}
	}
}
