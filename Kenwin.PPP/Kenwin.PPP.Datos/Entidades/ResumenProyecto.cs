using System;

namespace Kenwin.PPP.Negocio.Entidades
{
    /// <summary>
    /// Representa una vision general de un proyecto.
    /// </summary>
    public class ResumenProyecto
    {
        public int IdUnidadNegocio { get; set; }
        public int IdProyecto { get; set; }
        public string NombreProyecto { get; set; }
        public decimal? Probabilidad { get; set; }
        public string PaisDescripcion { get; set; }
        public string UnidadNegocioDescripcion { get; set; }
        public string UsuarioCreadorSiglas { get; set; }
        public string ClienteDescripcion { get; set; }
        public string OrdenTrabajoCodigo { get; set; }
        public string EstadoDescripcion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? UltimaActualizacion { get; set; }
        public decimal PrecioFinal { get; set; }
        public string MonedaDescripcion { get; set; }
        public decimal TotalCOPC { get; set; }
        public decimal TotalNoCOPC { get; set; }
        public decimal AvancePorcentaje { get; set; }
        public decimal ProductividadPorcentaje { get; set; }
        public decimal DiasDisponibles { get; set; } //TODO: Revisar si no es int.
        public string UsuarioLiderSiglas { get; set; }
        public int IdPais { get; set; }
        public int? IdEstado { get; set; }
        public int IdProyectoPadre { get; set; }
        public string NombreProyectoPadre { get; set; }
    }
}
