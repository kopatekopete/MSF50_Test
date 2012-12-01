using System;
using System.Linq.Expressions;
using Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.Base;
using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Windows.Controls;

namespace Kenwin.PPP.Cliente.Comun.Controles.FKBoxes
{
	public class MonedaFKBox : DescripcionFKBox<Moneda>
    {
        private MonedaSelector _selector;

		protected override Expression<Func<Moneda, string>> ValueMemberExpression
		{
			get { return x => x.IdMoneda.ToString(); }
		}

		protected override Expression<Func<Moneda, string>> DescriptionExpression
        {
            get { return x => x.CodigoMoneda; }
        }

		protected override GenericSelector<Moneda> GetSelector
        {
            get
            {
                if (_selector == null)
                {
					_selector = new MonedaSelector(this.ParentForm, this.Manager);
                }

                return _selector;
            }
        }
    }
}
