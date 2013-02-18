using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Kenwin.PPP.Negocio.Modelo;
using Kenwin.PPP.Negocio.Repositorios;
using Vemn.Fwk.Common;
using Vemn.Fwk.Data.EF;
using Vemn.Fwk.Windows.Controls;
using Kenwin.PPP.Negocio.Entidades;

namespace Kenwin.PPP.Cliente.Comun.Controles.FKBoxes
{
	public class ActividadCustomSelector : GenericSelector<ActividadCustom>
	{
		public ActividadCustomSelector(Form parentForm, RepositoryManager<PPPObjectContext> repositoryManager)
			: base(parentForm)
		{
			if (repositoryManager == null)
			{
				throw new ArgumentNullException("repositoryManager");
			}

			RepositoryManager = repositoryManager;
		}

		protected override List<ActividadCustom> GetData(FilterSortPaging filterSortPaging)
		{
			return RepositoryManager.GetRepository<ActividadRepository>().GetAllActividadesCustom(filterSortPaging);
		}

		protected override List<SelectorColumn> GetColumnDefinitions()
		{
			var columnas = new List<SelectorColumn>
                {
                    new SelectorColumn
                        {
                            Name = "DescripcionActividad",
                            Header = "Descripción",
							Width = 200
                        },
                    new SelectorColumn
                    	{
                            Name = "DescripcionTipoActividad",
                            Header = "Tipo de Actividad",
							Width = 90
                        }
                };

			return columnas;
		}

		protected override string Title
		{
			get { return "Actividad"; }
		}

		private RepositoryManager<PPPObjectContext> RepositoryManager { get; set; }
	}
}
