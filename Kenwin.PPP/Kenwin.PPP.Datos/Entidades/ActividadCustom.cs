using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kenwin.PPP.Negocio.Entidades
{
	public class ActividadCustom
	{
		public int IdActividad { get; set; }
		public string DescripcionActividad { get; set; }
		public int Orden { get; set; }
		
		public int IdTipoActividad { get; set; }
		public string DescripcionTipoActividad { get; set; }
		public int OrdenTipoActividad { get; set; }
	}
}
