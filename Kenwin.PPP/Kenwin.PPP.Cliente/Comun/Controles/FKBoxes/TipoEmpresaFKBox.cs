using System;
using System.Linq.Expressions;
using Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.Base;
using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Windows.Controls;

namespace Kenwin.PPP.Cliente.Comun.Controles.FKBoxes
{
	public class TipoEmpresaFKBox : DescripcionFKBox<TipoEmpresa>
    {
		private TipoEmpresaSelector _selector;

		protected override Expression<Func<TipoEmpresa, string>> ValueMemberExpression
		{
			get { return x => x.IdTipoEmpresa.ToString(); }
		}

		protected override Expression<Func<TipoEmpresa, string>> DescriptionExpression
        {
            get { return x => x.DescripcionTipoEmpresa; }
        }

		protected override GenericSelector<TipoEmpresa> GetSelector
        {
            get
            {
                if (_selector == null)
                {
					_selector = new TipoEmpresaSelector(this.ParentForm, this.Manager);
                }

                return _selector;
            }
        }
    }
}
