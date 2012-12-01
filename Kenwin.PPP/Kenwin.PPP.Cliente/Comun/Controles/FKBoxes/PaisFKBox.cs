using System;
using System.Linq.Expressions;
using Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.Base;
using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Windows.Controls;

namespace Kenwin.PPP.Cliente.Comun.Controles.FKBoxes
{
	public class PaisFKBox : DescripcionFKBox<Pais>
    {
		private PaisSelector _selector;

		protected override Expression<Func<Pais, string>> ValueMemberExpression
		{
			get { return x => x.IdPais.ToString(); }
		}

		protected override Expression<Func<Pais, string>> DescriptionExpression
        {
            get { return x => x.DescripcionPais; }
        }

		protected override GenericSelector<Pais> GetSelector
        {
            get
            {
                if (_selector == null)
                {
					_selector = new PaisSelector(this.ParentForm, this.Manager);
                }

                return _selector;
            }
        }
    }
}
