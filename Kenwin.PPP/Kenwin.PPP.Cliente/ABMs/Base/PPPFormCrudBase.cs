using System;
using Kenwin.PPP.Cliente.Comun.Formularios;
using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Data.EF;
using Vemn.Fwk.Windows;

namespace Kenwin.PPP.Cliente.ABMs.Base
{
	public class PPPFormCrudBase : FormCrudBase, IPPPForm
	{
		public bool PermiteMultiplesInstancias
		{
			get { return false; }
		}

		public RepositoryManager<PPPObjectContext> RepositoryManager
		{
			//TODO: Obtener RepositoryManager
			get { return null; }
		}
	}
}
