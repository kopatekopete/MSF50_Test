using System;
using System.Linq;
using System.Windows.Forms;
using Kenwin.PPP.Cliente.Comun.Controles.FKBoxes;
using Kenwin.PPP.Cliente.Comun.Formularios;
using Kenwin.PPP.Cliente.Properties;
using Kenwin.PPP.Negocio.Comun.Excepciones;
using Kenwin.PPP.Negocio.Modelo;
using Kenwin.PPP.Negocio.Repositorios;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Vemn.Fwk.Data.EF;
using Vemn.Fwk.Windows.Controls;

namespace Kenwin.PPP.Cliente.Comun.Controles.SelectorForms
{
	public class ProyectoPadreSelectorForm : SelectorForm<ProyectoPadre>
	{
		private readonly RepositoryManager<PPPObjectContext> _repositoryManager;

		public ProyectoPadreSelectorForm(RepositoryManager<PPPObjectContext> repositoryManager, ProyectoPadreSelector selector, bool forzarApertura)
			: base(selector, forzarApertura)
		{
			if (repositoryManager == null)
			{
				throw new ArgumentNullException("repositoryManager");
			}

			_repositoryManager = repositoryManager;

			#region Crear boton que permite realizar altas

			var botonAgregar = new ToolStripButton
			{
				Image = Resources.Agregar,
				DisplayStyle = ToolStripItemDisplayStyle.Image,
				ToolTipText = "Agregar Proyecto Padre"
			};

			botonAgregar.Click += Agregar_Click;

			//Agregar el boton que permite realizar altas
			filtroToolStrip.Items.Add(botonAgregar);

			#endregion
		}

		private void Agregar_Click(object sender, EventArgs e)
		{
			AgregarNuevoProyectoPadre();
		}

		private void AgregarNuevoProyectoPadre()
		{
			//Abrir la ventana que permite crear un nuevo item
			using (var nuevoProyectoPadreForm = new NuevoItemForm(
				"Agregar nuevo Proyecto Padre",
				"Ingrese la descripción del nuevo Proyecto Padre:",
				50))
			{
				var resultado = nuevoProyectoPadreForm.ShowDialog();

				if (resultado != DialogResult.OK)
				{
					return;
				}

				var proyectoPadre = GrabarProyectoPadre(nuevoProyectoPadreForm.Descripcion);

				if (proyectoPadre == null)
				{
					return;
				}

				//Asignar el item creado al selector
				this.SelectedItem = proyectoPadre;
			}

			//Cerrar el form con OK para que se refresque el resultado
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private ProyectoPadre GrabarProyectoPadre(string descripcion)
		{
			ProyectoPadre proyectoPadre = null;

			try
			{
				//Obtener un nuevo objectContext para grabar el objeto
				var objectContext = RepositoryFactory.GetManager().ObjectContext;

				#region Validaciones

				var existeDescripcion = objectContext.ProyectoPadreSet
					.Where(x => x.NombreProyectoPadre == descripcion)
					.Any();

				if (existeDescripcion)
				{
					throw new PPPNegocioException("No se puede grabar el ProyectoPadre, ya existe un ProyectoPadre con igual descripción.");
				}

				#endregion

				//Crear el ProyectoPadre a grabar
				proyectoPadre = new ProyectoPadre
				{
					NombreProyectoPadre = descripcion
				};

				//Grabar el proyectoPadre en el nuevo objectContext
				objectContext.AddToProyectoPadreSet(proyectoPadre);
				objectContext.SaveChanges();

				//Desatachar el objeto del nuevo objectContext para quitarle el tracking
				objectContext.Detach(proyectoPadre);

				//Atachar el objeto al objectContext del formulario
				_repositoryManager.ObjectContext.Attach(proyectoPadre);
			}
			catch (Exception ex)
			{
				ExceptionPolicy.HandleException(ex, Constantes.ElErrorPolicy);
			}

			return proyectoPadre;
		}
	}
}
