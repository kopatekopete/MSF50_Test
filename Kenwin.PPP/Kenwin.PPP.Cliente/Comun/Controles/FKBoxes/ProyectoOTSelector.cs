using System;
using System.Linq;
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
    public class ProyectoOTSelector : GenericSelector<ProyectoOT>
    {
        public ProyectoOTSelector(Form parentForm, RepositoryManager<PPPObjectContext> repositoryManager)
            : base(parentForm)
        {
            if (repositoryManager == null)
            {
                throw new ArgumentNullException("repositoryManager");
            }

            RepositoryManager = repositoryManager;

			//Instanciar y asociar el selectorForm personalizado
			SelectorForm = new ProyectoOTSelectorForm(RepositoryManager, this, true);
        }

		protected override List<ProyectoOT> GetData(FilterSortPaging filterSortPaging)
		{
			if (ProyectoPadre == null)
			{
				return new List<ProyectoOT>();
			}

			var listaProyectosOT = RepositoryManager
					.GetRepository<ProyectoOTRepository>()
					.ObtenerProyectosOTPorIdPadre(filterSortPaging, ProyectoPadre.IdProyectoPadre);

			return listaProyectosOT;
		}

        protected override List<SelectorColumn> GetColumnDefinitions()
        {
            var columnas = new List<SelectorColumn>
                {
                    new SelectorColumn
                        {
                            Name = "Ot",
                            Header = "Código",
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
            get { return "Código OT"; }
        }

        private RepositoryManager<PPPObjectContext> RepositoryManager { get; set; }

        private ProyectoPadre _proyectoPadre;

        public ProyectoPadre ProyectoPadre
        {
            get { return _proyectoPadre; }
            set
            {
                if (value == null || (_proyectoPadre != null && value.IdProyectoPadre != _proyectoPadre.IdProyectoPadre))
                {
                    this.Clean();
                }

                _proyectoPadre = value;
            }
        }
    }
}
