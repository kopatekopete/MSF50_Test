using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Kenwin.PPP.Negocio.Modelo;
using Kenwin.PPP.Negocio.Repositorios;
using Vemn.Fwk.Common;
using Vemn.Fwk.Data.EF;
using Vemn.Fwk.Windows.Controls;
using Kenwin.PPP.Cliente.Comun.Controles.SelectorForms;

namespace Kenwin.PPP.Cliente.Comun.Controles.FKBoxes
{
    public class ProyectoPadreSelector : GenericSelector<ProyectoPadre>
    {
        public ProyectoPadreSelector(Form parentForm, RepositoryManager<PPPObjectContext> repositoryManager)
            : base(parentForm)
        {
            if (repositoryManager == null)
            {
                throw new ArgumentNullException("repositoryManager");
            }

            RepositoryManager = repositoryManager;

			//Instanciar y asociar el selectorForm personalizado
			SelectorForm = new ProyectoPadreSelectorForm(RepositoryManager, this, true);
        }

		protected override List<ProyectoPadre> GetData(FilterSortPaging filterSortPaging)
		{
			return RepositoryManager.GetRepository<ProyectoPadreRepository>().GetAll(filterSortPaging);
		}

        protected override List<SelectorColumn> GetColumnDefinitions()
        {
            var columnas = new List<SelectorColumn>
                {
                    new SelectorColumn
                        {
                            Name = "NombreProyectoPadre",
                            Header = "Nombre",
                            DataType = typeof(string),
                            Align= ColumnAlign.Left,
                            Width = 300,
                            UseEquals = false
                        }
                };
            return columnas;
        }

        protected override string Title
        {
            get { return "Proyecto Padre"; }
        }

        private RepositoryManager<PPPObjectContext> RepositoryManager { get; set; }
    }
}
