using System;
using System.ComponentModel;
using System.Linq.Expressions;
using Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.Base;
using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Windows.Controls;

namespace Kenwin.PPP.Cliente.Comun.Controles.FKBoxes
{
	public class ProyectoOTFKBox : DescripcionFKBox<ProyectoOT>
    {
		private ProyectoOTSelector _selector;

		protected override Expression<Func<ProyectoOT, string>> ValueMemberExpression
		{
			get { return x => x.IdProyectoOt.ToString(); }
		}

		protected override Expression<Func<ProyectoOT, string>> DescriptionExpression
        {
            get { return x => x.Ot; }
        }

		protected override GenericSelector<ProyectoOT> GetSelector
        {
            get
            {
                if (_selector == null)
                {
					_selector = new ProyectoOTSelector(this.ParentForm, this.Manager);
                }

                return _selector;
            }
        }

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public ProyectoPadre ProyectoPadre
		{
			get
			{
				return ((ProyectoOTSelector) GetSelector).ProyectoPadre;
			}
			set 
			{
				((ProyectoOTSelector) GetSelector).ProyectoPadre = value;
			}
			
		}
    }
}
