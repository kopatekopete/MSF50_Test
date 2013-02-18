using System;
using System.Linq.Expressions;
using Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.Base;
using Vemn.Fwk.Windows.Controls;

namespace Kenwin.PPP.Cliente.Comun.Controles.FKBoxes
{
	public class ClienteFKBox : DescripcionFKBox<Negocio.Modelo.Cliente>
	{
		private ClienteSelector _selector;

		protected override Expression<Func<Negocio.Modelo.Cliente, string>> ValueMemberExpression
		{
			get { return x => x.IdCliente.ToString(); }
		}

		protected override Expression<Func<Negocio.Modelo.Cliente, string>> DescriptionExpression
		{
			get { return x => x.RazonSocial; }
		}

		protected override GenericSelector<Negocio.Modelo.Cliente> GetSelector
		{
			get
			{
				if (_selector == null)
				{
					_selector = new ClienteSelector(this.ParentForm, this.Manager);
				}

				return _selector;
			}
		}
	}
}
