using System;
using System.Linq.Expressions;
using Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.Base;
using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Windows.Controls;

namespace Kenwin.PPP.Cliente.Comun.Controles.FKBoxes
{
	public class UnidadNegocioFKBox : DescripcionFKBox<UnidadNegocio>
	{
		private UnidadNegocioSelector _selector;

		protected override Expression<Func<UnidadNegocio, string>> ValueMemberExpression
		{
			get { return x => x.IdUnidadNegocio.ToString(); }
		}

		protected override Expression<Func<UnidadNegocio, string>> DescriptionExpression
		{
			get { return x => x.DescripcionUnidadNegocio; }
		}

		protected override GenericSelector<UnidadNegocio> GetSelector
		{
			get
			{
				if (_selector == null)
				{
					_selector = new UnidadNegocioSelector(this.ParentForm, this.Manager);
				}

				return _selector;
			}
		}
	}
}
