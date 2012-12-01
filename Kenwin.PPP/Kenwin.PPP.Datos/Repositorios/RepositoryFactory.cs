using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Data.EF;

namespace Kenwin.PPP.Negocio.Repositorios
{
    /// <summary>
    /// Punto Central para obtener el Manager y el Object Context de la aplicacion
    /// </summary>
    public class RepositoryFactory
    {
        public static RepositoryManager<PPPObjectContext> GetManager()
        {
            try
            {
                var ctx = new PPPObjectContext();
                var mgr = new RepositoryManager<PPPObjectContext>(ctx);

                return mgr;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
