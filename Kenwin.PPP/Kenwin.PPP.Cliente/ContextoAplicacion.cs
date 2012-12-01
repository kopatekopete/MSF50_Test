using System;
using Kenwin.PPP.Cliente.Comun.Formularios;
using Kenwin.PPP.Negocio.Modelo;

namespace Kenwin.PPP.Cliente
{
    public class ContextoAplicacion
    {
        private static ContextoAplicacion _instancia;
        
        private ContextoAplicacion()
        {
            
        }
        
        public static ContextoAplicacion Instancia
        {
            get
            {
                if(_instancia == null)
                {
                    _instancia = new ContextoAplicacion();
                }
                return _instancia;
            }
        }

        public PPPMDIFormBase FormularioPrincipal { get; set; }
        public Persona UsuarioLogueado  { get; set; }
    }
}
