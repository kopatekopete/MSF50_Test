using System.ComponentModel;
using System.Windows.Forms;
using Kenwin.PPP.Cliente.Comun.Formularios;
using Kenwin.PPP.Negocio.Modelo;
using Kenwin.PPP.Negocio.Repositorios;
using Vemn.Fwk.Data.EF;

namespace Kenwin.PPP.Cliente.Comun.Controles
{
	public partial class PPPUserControlBase : UserControl
	{
		public PPPUserControlBase()
		{
			InitializeComponent();
		}

		private readonly object _repositoryLock = new object();

		private RepositoryManager<PPPObjectContext> _repositoryManager;

		/// <summary>
		/// Devuelve una referencia al RepositoryManager del control
		/// </summary>
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual RepositoryManager<PPPObjectContext> RepositoryManager
		{
			get
			{
				lock (_repositoryLock)
				{
					if (_repositoryManager == null)
					{
						var formularioContenedor = this.FindForm() as IPPPForm;
						if (formularioContenedor != null)
						{
							//Si el formulario padre es un IPPPForm, obtiene el mismo RepositoryManager.
							_repositoryManager = formularioContenedor.RepositoryManager;
						}
						else
						{
							_repositoryManager = RepositoryFactory.GetManager();
						}
					}

					return _repositoryManager;
				}
			}

			set
			{
				lock (_repositoryLock)
				{
					_repositoryManager = value;
				}
			}
		}
	}
}
