using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using Kenwin.PPP.Cliente.Comun.Controles;
using Kenwin.PPP.Negocio.Comun;
using Kenwin.PPP.Negocio.Modelo;
using Kenwin.PPP.Negocio.Repositorios;
using Vemn.Fwk.Data.EF;
using Vemn.Fwk.Windows.Controls.Extensions;

namespace Kenwin.PPP.Cliente.Proyectos
{
	public partial class AsignacionPersonal : PPPUserControlBase
	{
		public AsignacionPersonal()
		{
			InitializeComponent();
		}

		public event EventHandler CambioEnAsginaciones;

		private readonly BindingSource _bindingSource = new BindingSource();
		private List<ProyectoAsignacion> _asignacionesProyecto;
		private Column _columnaPorcentajeRendimiento;
		private Column _columnaRol;
		private Proyecto Proyecto { get; set; }

		private List<ProyectoAsignacion> AsignacionesProyecto
		{
			get { return _asignacionesProyecto; }
			set
			{
				_asignacionesProyecto = value;

				_bindingSource.DataSource = _asignacionesProyecto;
			}
		}

		void AsignacionPersonal_Load(object sender, EventArgs e)
		{
			if (!DesignMode)
			{
				ConfigurarGrilla();
			}
		}

		private void ConfigurarGrilla()
		{
			grillaC1FlexGrid.ShowErrors = true;
			grillaC1FlexGrid.DataSource = _bindingSource;
			grillaC1FlexGrid.ShowButtons = ShowButtonsEnum.Always;

			//Definicion de columas
			var editorColumnas = grillaC1FlexGrid.ColumnEditor<ProyectoAsignacion>();

			editorColumnas.AddColumn("Persona.Alias", "Alias", 100, x => x.Persona.Alias);
			editorColumnas.AddColumn("Persona.NombreCompleto", "Nombre", 300, x => x.Persona.NombreCompleto);
			_columnaRol = editorColumnas.AddColumn("Rol", "Rol", 120, true, true);
			var comboRoles = new ComboBox
				{
					DataSource = RepositoryManager.GetRepository<RolRepository>().GetAll().OrderBy(x => x.DescripcionRol).ToList(),
					DisplayMember = "DescripcionRol",
					DropDownStyle = ComboBoxStyle.DropDownList
				};
			comboRoles.SelectionChangeCommitted += ComboRoles_SelectionChangeCommitted;
			_columnaRol.Editor = comboRoles;

			_columnaPorcentajeRendimiento = editorColumnas.AddColumn(x => x.PorcentajeRendimiento, "Rendimiento", 100, true, true);
			_columnaPorcentajeRendimiento.Format = Formatos.FormatoPorcentaje;

		}

		void ComboRoles_SelectionChangeCommitted(object sender, EventArgs e)
		{
			var comboRoles = (ComboBox)sender;
			int nroFila = grillaC1FlexGrid.Row;

			if (grillaC1FlexGrid.IsCellValid(nroFila, 0))
			{
				var asignacion = grillaC1FlexGrid.Rows[nroFila].DataSource as ProyectoAsignacion;
				if (asignacion != null)
				{
					asignacion.Rol = (Rol)comboRoles.SelectedItem;
					OnCambioEnAsignaciones();
				}
			}

		}

		private void OnCambioEnAsignaciones()
		{
			if(CambioEnAsginaciones!= null)
			{
				CambioEnAsginaciones(this, EventArgs.Empty);
			}
		}

		public void CargarAsignacionesProyecto(Proyecto proyecto)
		{
			Proyecto = proyecto;

			AsignacionesProyecto = Proyecto.ProyectoAsignacionSet
				.OrderBy(x=>x.Persona.Alias)
				.ToList();
		}

		private void AsignarButton_Click(object sender, EventArgs e)
		{
			var listaAsignados = AsignacionesProyecto
				.Select(x => x.Persona)
				.ToList();

			var dialogoAgregar = new AgregarAsignacion(RepositoryManager, listaAsignados);

			var resultado = dialogoAgregar.ShowDialog();
			if (resultado == DialogResult.OK)
			{
				listaAsignados = dialogoAgregar.ListaAsignados;

				SincronizarAsignaciones(listaAsignados);
			}
		}

		/// <summary>
		/// Actualiza la lista de asignaciones en base a una lista de personas
		/// </summary>
		/// <param name="listaAsignados"></param>
		private void SincronizarAsignaciones(IEnumerable<Persona> listaAsignados)
		{
			var nuevaListaAsignaciones = new List<ProyectoAsignacion>();

			foreach (var personaAsignada in listaAsignados)
			{
				var idPersonaAsignada = personaAsignada.IdPersona;

				//Buscar si existe una asignacion previa
				var asignacion = AsignacionesProyecto
					.Where(x => x.IdPersona == idPersonaAsignada)
					.FirstOrDefault();

				if (asignacion == null)
				{
					asignacion = new ProyectoAsignacion
					{
						Persona = personaAsignada
					};
				}

				nuevaListaAsignaciones.Add(asignacion);
			}

			AsignacionesProyecto = nuevaListaAsignaciones
				.OrderBy(x => x.Persona.Alias)
				.ToList();

			ActualizarPedido();
		}

		private void GrillaC1FlexGrid_AfterEdit(object sender, RowColEventArgs e)
		{
			if (e.Col == _columnaPorcentajeRendimiento.Index)
			{
				var valorTexto = grillaC1FlexGrid.GetData(e.Row, e.Col).ToString();
				decimal valor;
				if (Decimal.TryParse(valorTexto, out valor))
				{
					var nuevoValor = valor / 100;

					grillaC1FlexGrid.SetData(e.Row, e.Col, nuevoValor);
				}
			}
		}

		private void GrillaC1FlexGrid_ValidateEdit(object sender, ValidateEditEventArgs e)
		{
			if (e.Col == _columnaPorcentajeRendimiento.Index)
			{
				var valorTexto = grillaC1FlexGrid.Editor.Text;
				decimal valor;
				if (Decimal.TryParse(valorTexto, out valor))
				{
					if (valor >= 0 && valor <= 100)
					{
						return;
					}
				}
				e.Cancel = true;
			}
		}

		public bool ValidarDatos()
		{
			bool hayError = false;

			for (int i = 1; i < grillaC1FlexGrid.Rows.Count; i++)
			{
				var asignacion = (ProyectoAsignacion)grillaC1FlexGrid.Rows[i].DataSource;
				if (asignacion.IdRol == 0)
				{
					hayError = true;
					grillaC1FlexGrid.SetCellError(i, _columnaRol.Index, "Dato requerido");
				}
				else
				{
					grillaC1FlexGrid.ClearCellError(i, _columnaRol.Index);
				}
			}

			return !hayError;
		}

		private void BorrarButton_Click(object sender, EventArgs e)
		{
			var nroFila = grillaC1FlexGrid.Row;
			if (grillaC1FlexGrid.IsCellValid(nroFila, grillaC1FlexGrid.Col))
			{
				var asignacion = grillaC1FlexGrid.Rows[nroFila].DataSource as ProyectoAsignacion;
				if (asignacion != null)
				{
					_bindingSource.Remove(asignacion);
				}
			}

			ActualizarPedido();
		}

		private void ActualizarPedido()
		{
			var hayCambios = false;
			
			var listaABorrar = Proyecto.ProyectoAsignacionSet
				.Where(asignacion => !AsignacionesProyecto.Contains(asignacion))
				.ToList();

			if (listaABorrar.Any())
			{
				hayCambios = true;
				listaABorrar.ForEach(x => Proyecto.ProyectoAsignacionSet.Remove(x));
			}
			
			var listaAAgregar = AsignacionesProyecto
				.Where(asignacion => !Proyecto.ProyectoAsignacionSet.Contains(asignacion))
				.ToList();

			if (listaAAgregar.Any())
			{
				hayCambios = true;
				Proyecto.ProyectoAsignacionSet.AddRangeExt(listaAAgregar);
			}

			if (hayCambios)
			{
				OnCambioEnAsignaciones();
			}
		}
	}
}
