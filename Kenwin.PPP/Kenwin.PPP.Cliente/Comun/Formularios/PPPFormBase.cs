using System.ComponentModel;
using System.Windows.Forms;
using Kenwin.PPP.Negocio.Modelo;
using Kenwin.PPP.Negocio.Repositorios;
using Vemn.Fwk.Data.EF;

namespace Kenwin.PPP.Cliente.Comun.Formularios
{
    public class PPPFormBase : Form, IPPPForm
    {
        private readonly object _repositoryManagerLock = new object();

		public PPPFormBase()
		{
			this.Padding = new Padding(5);
		}

		public PPPFormBase(RepositoryManager<PPPObjectContext> repositoryManager) : this()
		{
			_repositoryManager = repositoryManager;
		}

        /// <summary>
        /// Indica si el formulario puede abrirse mas de 1 vez.
        /// </summary>
        /// <returns></returns>
        [DefaultValue(true)]
        public virtual bool PermiteMultiplesInstancias
        {
            get { return true; }
        }

		private RepositoryManager<PPPObjectContext> _repositoryManager;

        /// <summary>
        /// Devuelve una referencia al RepositoryManager del formulario
        /// </summary>
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual RepositoryManager<PPPObjectContext> RepositoryManager
        {
            get
            {
                lock (_repositoryManagerLock)
                {
                    if (_repositoryManager == null)
                    {
                        _repositoryManager = RepositoryFactory.GetManager();
                    }

                    return _repositoryManager;
                }
            }
        }
    }
}
