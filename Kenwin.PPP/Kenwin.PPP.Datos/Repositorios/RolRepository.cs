using System;
using Kenwin.PPP.Negocio.Comun.Excepciones;
using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Data.EF;
using System.Linq;

namespace Kenwin.PPP.Negocio.Repositorios
{
    public class RolRepository: BaseRepository<PPPObjectContext, Rol>
    {
		public RolRepository(RepositoryManager<PPPObjectContext> repositoryManager)
            : base(repositoryManager)
        {
        }

		public override Rol InsertABM(Rol rol)
		{
			this.ValidarRol(rol);

			return base.InsertABM(rol);
		}

		public override Rol UpdateABM(Rol rol)
		{
			this.ValidarRol(rol);

			return base.UpdateABM(rol);
		}

		public override void Delete(Rol rol)
		{
			ValidarEliminar(rol);

			base.Delete(rol);
		}

		private void ValidarEliminar(Rol rol)
    	{
			var puedeEliminar = ObjectContext.ProyectoAsignacionSet
				.Any(x => x.IdRol == rol.IdRol);

			if (puedeEliminar)
			{
				throw new PPPNegocioException("No se puede eliminar el Rol ya que participa en la relación ProyectoAsignacion.");
			}
    	}

    	private void ValidarRol(Rol rol)
		{
			var descripcionRepetida = ObjectContext.RolSet
				.Where(x => x.IdRol != rol.IdRol)
				.Where(x => x.DescripcionRol == rol.DescripcionRol)
				.Any();

			if (descripcionRepetida)
			{
				throw new PPPNegocioException("Ya existe una Rol con igual descripción.");
			}
		}
    }
}
