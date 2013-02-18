using System;
using System.Linq.Expressions;
using Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.Base;
using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Windows.Controls;

namespace Kenwin.PPP.Cliente.Comun.Controles.FKBoxes
{
	public class TipoProyectoFKBox : DescripcionFKBox<TipoProyecto>
    {
		private TipoProyectoSelector _selector;

		protected override Expression<Func<TipoProyecto, string>> ValueMemberExpression
		{
			get { return x => x.IdTipoProyecto.ToString(); }
		}

		protected override Expression<Func<TipoProyecto, string>> DescriptionExpression
        {
            get { return x => x.DescripcionTipoProyecto; }
        }

		protected override GenericSelector<TipoProyecto> GetSelector
        {
            get
            {
                if (_selector == null)
                {
					_selector = new TipoProyectoSelector(this.ParentForm, this.Manager);
                }

                return _selector;
            }
        }
    }
}
