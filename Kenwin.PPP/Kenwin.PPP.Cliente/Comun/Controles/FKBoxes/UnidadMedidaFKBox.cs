using System;
using System.Linq.Expressions;
using Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.Base;
using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Windows.Controls;

namespace Kenwin.PPP.Cliente.Comun.Controles.FKBoxes
{
	public class UnidadMedidaFKBox : DescripcionFKBox<UnidadMedida>
    {
		private UnidadMedidaSelector _selector;

		protected override Expression<Func<UnidadMedida, string>> ValueMemberExpression
		{
			get { return x => x.IdUnidadMedida.ToString(); }
		}

		protected override Expression<Func<UnidadMedida, string>> DescriptionExpression
        {
            get { return x => x.DescripcionUnidadMedida; }
        }

		protected override GenericSelector<UnidadMedida> GetSelector
        {
            get
            {
                if (_selector == null)
                {
					_selector = new UnidadMedidaSelector(this.ParentForm, this.Manager);
                }

                return _selector;
            }
        }
    }
}
