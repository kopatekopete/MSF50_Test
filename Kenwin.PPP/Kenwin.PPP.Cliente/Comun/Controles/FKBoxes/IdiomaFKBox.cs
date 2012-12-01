using System;
using System.Linq.Expressions;
using Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.Base;
using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Windows.Controls;

namespace Kenwin.PPP.Cliente.Comun.Controles.FKBoxes
{
	public class IdiomaFKBox : DescripcionFKBox<Idioma>
	{
		private IdiomaSelector _selector;

		protected override Expression<Func<Idioma, string>> ValueMemberExpression
		{
			get { return x => x.IdIdioma.ToString(); }
		}

		protected override Expression<Func<Idioma, string>> DescriptionExpression
		{
			get { return x => x.DescripcionIdioma; }
		}

		protected override GenericSelector<Idioma> GetSelector
		{
			get
			{
				if (_selector == null)
				{
					_selector = new IdiomaSelector(this.ParentForm, this.Manager);
				}

				return _selector;
			}
		}
	}
}
