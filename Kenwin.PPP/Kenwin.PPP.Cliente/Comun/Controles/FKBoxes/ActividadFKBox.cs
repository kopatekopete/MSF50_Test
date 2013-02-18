using System;
using System.Linq.Expressions;
using Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.Base;
using Kenwin.PPP.Negocio.Entidades;
using Vemn.Fwk.Windows.Controls;
using Kenwin.PPP.Negocio.Modelo;

namespace Kenwin.PPP.Cliente.Comun.Controles.FKBoxes
{
	public class ActividadFKBox : DescripcionFKBox<Actividad>
    {
		private ActividadSelector _selector;

		protected override Expression<Func<Actividad, string>> ValueMemberExpression
		{
			get { return x => x.IdActividad.ToString(); }
		}

		protected override Expression<Func<Actividad, string>> DescriptionExpression
        {
            get { return x => x.DescripcionActividad; }
        }

		protected override GenericSelector<Actividad> GetSelector
        {
            get
            {
                if (_selector == null)
                {
					_selector = new ActividadSelector(this.ParentForm, this.Manager);
                }

                return _selector;
            }
        }
    }
}
