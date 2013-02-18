using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kenwin.PPP.Negocio.Modelo;

namespace Kenwin.PPP.Negocio.Entidades
{
    public class DetalleProyectoVersion
    {
        public Proyecto Proyecto { get; set;}
        public ProyectoVersion ProyectoVersion { get; set; }
        public List<DatosProyecto> Datos { get; set; }
    }
}
