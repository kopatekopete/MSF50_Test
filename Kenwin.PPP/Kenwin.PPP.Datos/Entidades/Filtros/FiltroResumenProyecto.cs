using System;
using System.Collections.Generic;

namespace Kenwin.PPP.Negocio.Entidades.Filtros
{
    public class FiltroResumenProyecto
    {
        public int? IdPais { get; set; }
        public string ClienteDescripcion { get; set; }
        public string CodigoOT { get; set; }
        public int? IdUnidadNegocio { get; set; }
        public DateTime? FechaInicioAnteriorA { get; set; }
        public List<int> ListaIdEstados { get; set; }
        public string NombreProyectoPadre { get; set; }
        public string NombreProyecto { get; set; }
    }
}
