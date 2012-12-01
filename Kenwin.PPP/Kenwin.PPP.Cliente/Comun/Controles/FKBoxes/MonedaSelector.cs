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
    public class MonedaSelector : GenericSelector<Moneda>
    {
        public MonedaSelector(Form parentForm, RepositoryManager<PPPObjectContext> repositoryManager)
            : base(parentForm)
        {
            if (repositoryManager == null)
            {
                throw new ArgumentNullException("repositoryManager");
            }

            RepositoryManager = repositoryManager;
        }

		protected override List<Moneda> GetData(FilterSortPaging filterSortPaging)
		{
			return RepositoryManager.GetRepository<MonedaRepository>().GetAll(filterSortPaging);
		}

        protected override List<SelectorColumn> GetColumnDefinitions()
        {
            var columnas = new List<SelectorColumn>
                {
                    new SelectorColumn
                        {
                            Name = "CodigoMoneda",
                            Header = "Código",
                            DataType = typeof(string),
                            Align= ColumnAlign.Left,
                            Width = 40,
                            UseEquals = false
                        },
                         new SelectorColumn
                        {
                            Name = "DescripcionMoneda",
                            Header = "Descripción",
                            DataType = typeof(string),
                            Align= ColumnAlign.Left,
                            Width = 200,
                            UseEquals = false
                        }
                };
            return columnas;
        }

        protected override string Title
        {
            get { return "Moneda"; }
        }

        private RepositoryManager<PPPObjectContext> RepositoryManager { get; set; }
    }
}
