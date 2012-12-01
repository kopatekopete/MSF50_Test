using Kenwin.PPP.Negocio.Comun.Excepciones;
using Kenwin.PPP.Negocio.Modelo;
using System.Linq;
using Vemn.Fwk.Data.EF;

namespace Kenwin.PPP.Negocio.Repositorios
{
	public class IdiomaRepository : BaseRepository<PPPObjectContext, Idioma>
    {
		public IdiomaRepository(RepositoryManager<PPPObjectContext> repositoryManager)
            : base(repositoryManager)
        {
			
        }

		public override Idioma InsertABM(Idioma idioma)
		{
			this.ValidarIdioma(idioma);

			return base.InsertABM(idioma);
		}

		public override Idioma UpdateABM(Idioma idioma)
		{
			this.ValidarIdioma(idioma);

			return base.UpdateABM(idioma);
		}

		private void ValidarIdioma(Idioma idioma)
		{
			var descripcionRepetida = ObjectContext.IdiomaSet
				.Where(x => x.IdIdioma != idioma.IdIdioma)
				.Where(x => x.DescripcionIdioma == idioma.DescripcionIdioma)
				.Any();

			if (descripcionRepetida)
			{
				throw new PPPNegocioException("Ya existe una Idioma con igual descripción.");
			}
		}
    }
}
