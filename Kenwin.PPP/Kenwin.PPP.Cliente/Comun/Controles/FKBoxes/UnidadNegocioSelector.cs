using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Kenwin.PPP.Negocio.Modelo;
using Kenwin.PPP.Negocio.Repositorios;
using Vemn.Fwk.Common;
using Vemn.Fwk.Data.EF;
using Vemn.Fwk.Windows.Controls;

namespace Kenwin.PPP.Cliente.Comun.Controles.FKBoxes
{
	public class UnidadNegocioSelector : GenericSelector<UnidadNegocio>
	{
		public UnidadNegocioSelector(Form parentForm, RepositoryManager<PPPObjectContext> repositoryManager)
			: base(parentForm)
		{
			if (repositoryManager == null)
			{
				throw new ArgumentNullException("repositoryManager");
			}

			RepositoryManager = repositoryManager;
		}

		protected override string Title
		{
			get { return "Unidad de Negocio"; }
		}

		private RepositoryManager<PPPObjectContext> RepositoryManager { get; set; }

		protected override List<UnidadNegocio> GetData(FilterSortPaging filterSortPaging)
		{
			return RepositoryManager.GetRepository<UnidadNegocioRepository>().GetAll(filterSortPaging);
		}

		protected override List<SelectorColumn> GetColumnDefinitions()
		{
			var columnas = new List<SelectorColumn>
				{
					new SelectorColumn
						{
							Name = "DescripcionUnidadNegocio",
							Header = "Descripción",
							DataType = typeof (string),
							Align = ColumnAlign.Left,
							Width = 300,
							UseEquals = false
						},
				};
			return columnas;
		}
	}
}