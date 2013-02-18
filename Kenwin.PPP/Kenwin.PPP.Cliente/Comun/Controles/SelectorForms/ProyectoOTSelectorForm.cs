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
using Vemn.Fwk.Windows.Tools;

namespace Kenwin.PPP.Cliente.Comun.Controles.SelectorForms
{
	public class ProyectoOTSelectorForm : SelectorForm<ProyectoOT>
	{
		private readonly RepositoryManager<PPPObjectContext> _repositoryManager;
		private readonly ProyectoOTSelector _selector;

		public ProyectoOTSelectorForm(RepositoryManager<PPPObjectContext> repositoryManager, ProyectoOTSelector selector, bool forzarApertura)
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
				ToolTipText = "Agregar Proyecto OT"
			};

			botonAgregar.Click += Agregar_Click;

			//Agregar el boton que permite realizar altas
			filtroToolStrip.Items.Add(botonAgregar);

			#endregion

			//Guardar una referencia al selector para poder tener acceso al proyectoPadre
			_selector = selector;
		}

		private void Agregar_Click(object sender, EventArgs e)
		{
			if (_selector.ProyectoPadre == null)
			{
				MessageHelper.MostrarMensajeAlerta("No se puede agregar un nuevo ProyectoOT, ya que no hay un padre seleccionado.");
				return;
			}

			AgregarNuevoProyectoOT();
		}

		private void AgregarNuevoProyectoOT()
		{
			//Abrir la ventana que permite crear un nuevo item
			using (var nuevoProyectoForm = new NuevoItemForm(
				"Agregar nuevo Proyecto OT",
				"Ingrese la descripción del nuevo Proyecto OT:",
				50))
			{
				var resultado = nuevoProyectoForm.ShowDialog();

				if (resultado != DialogResult.OK)
				{
					return;
				}

				var proyectoOT = GrabarProyectoOT(nuevoProyectoForm.Descripcion);

				if (proyectoOT == null)
				{
					return;
				}

				//Asignar el item creado al selector
				this.SelectedItem = proyectoOT;
			}

			//Cerrar el form con OK para que se refresque el resultado
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private ProyectoOT GrabarProyectoOT(string descripcion)
		{
			ProyectoOT proyectoOT = null;

			try
			{
				//Obtener un nuevo objectContext para grabar el objeto
				var objectContext = RepositoryFactory.GetManager().ObjectContext;

				#region Validaciones

				var existeDescripcion = objectContext.ProyectoOTSet
					.Where(x => x.Ot == descripcion)
					.Any();

				if (existeDescripcion)
				{
					throw new PPPNegocioException("No se puede grabar el ProyectoOT, ya existe un ProyectoOT con igual descripción.");
				}

				#endregion

				//Crear el proyectoOT a grabar
				proyectoOT = new ProyectoOT
				{
					IdProyectoPadre = _selector.ProyectoPadre.IdProyectoPadre,
					Ot = descripcion,
				};

				//Grabar el proyectoOT en el nuevo objectContext
				objectContext.AddToProyectoOTSet(proyectoOT);
				objectContext.SaveChanges();

				//Desatachar el objeto del nuevo objectContext para quitarle el tracking
				objectContext.Detach(proyectoOT);

				//Atachar el objeto al objectContext del formulario
				_repositoryManager.ObjectContext.Attach(proyectoOT);
			}
			catch (Exception ex)
			{
				ExceptionPolicy.HandleException(ex, Constantes.ElErrorPolicy);
			}

			return proyectoOT;
		}
	}
}
