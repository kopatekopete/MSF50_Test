using System;
using System.Linq.Expressions;
using Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.Base;
using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Windows.Controls;

namespace Kenwin.PPP.Cliente.Comun.Controles.FKBoxes
{
	public class ProyectoPadreFKBox : DescripcionFKBox<ProyectoPadre>
    {
		private ProyectoPadreSelector _selector;

		protected override Expression<Func<ProyectoPadre, string>> ValueMemberExpression
		{
			get { return x => x.IdProyectoPadre.ToString(); }
		}

		protected override Expression<Func<ProyectoPadre, string>> DescriptionExpression
        {
            get { return x => x.NombreProyectoPadre; }
        }

		protected override GenericSelector<ProyectoPadre> GetSelector
        {
            get
            {
                if (_selector == null)
                {
					_selector = new ProyectoPadreSelector(this.ParentForm, this.Manager);
                }

                return _selector;
            }
        }
    }
}
