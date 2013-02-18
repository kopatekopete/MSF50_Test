using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using Kenwin.PPP.Cliente.Comun;
using Kenwin.PPP.Cliente.Comun.Controles;
using Kenwin.PPP.Negocio.Comun;
using Kenwin.PPP.Negocio.Entidades;
using Kenwin.PPP.Negocio.Modelo;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Vemn.Fwk.Windows.Controls.Extensions;

namespace Kenwin.PPP.Cliente.Proyectos
{
	public partial class AsignacionSemanal : PPPUserControlBase
	{
		private const int CantidadDiasVisibles = 8;

		private readonly BindingSource _grillaC1FlexGridBindingSource = new BindingSource();

		private Column _columnaTipoActividadDescripcion;
		private Column _columnaProyectoActividadDescripcion;
		private Column _columnaPersonaAsignacionAlias;

		private DateTime _fechaInicio;

		public DateTime FechaInicio
		{
			get { return _fechaInicio; }
			set
			{
				_fechaInicio = CalcularInicioSemana(value);

				ActualizarDatosVisibles();
				
				ActualizarCaptionsColumnasFecha();
			}
		}

		private void ActualizarDatosVisibles()
		{
			var datos = _grillaC1FlexGridBindingSource.DataSource as List<DatoAsignacionSemanal>;
			if (datos == null)
			{
				return;
			}

			foreach (var dato in datos)
			{
				dato.FechaInicio = FechaInicio;
			}
			_grillaC1FlexGridBindingSource.ResetBindings(false);
		}

		private void ActualizarCaptionsColumnasFecha()
		{
			var fecha = FechaInicio;
			foreach (var columna in _columnasSemana)
			{
				columna.Caption = fecha.ToShortDateString();
				fecha = fecha.AddDays(7);
			}
		}

		public AsignacionSemanal()
		{
			InitializeComponent();
			if (!DesignMode)
			{
				ConfigurarGrilla();
			}
		}

		private List<DatosProyecto> _actividadesProyecto;

		private readonly List<Column> _columnasSemana = new List<Column>();

		private Column _columnaIdProyectoActividad;
		private Column _columnaDiasPresupuestados;
		private Column _columnaDiasAsignados;
		private Column _columnaDiasPrevistos;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public List<DatosProyecto> ActividadesProyecto
		{
			get { return _actividadesProyecto; }
			set
			{
				_actividadesProyecto = value;

				ActualizarDatos(value);
			}
		}

		private void ActualizarDatos(List<DatosProyecto> tareasProyecto)
		{
			var asignacion = DatoAsignacionSemanal.CrearDesdeListaTareas(RepositoryManager, tareasProyecto, FechaInicio);

			_grillaC1FlexGridBindingSource.DataSource = asignacion;
		}

		private void AsignacionSemanal_Load(object sender, EventArgs e)
		{
			if (DesignMode)
			{
				return;
			}
		}

		private void ConfigurarGrilla()
		{
			grillaC1FlexGrid.AllowDragging = AllowDraggingEnum.None;
			grillaC1FlexGrid.AllowResizing = AllowResizingEnum.None;
			grillaC1FlexGrid.AllowSorting = AllowSortingEnum.None;
			grillaC1FlexGrid.AutoGenerateColumns = false;
			grillaC1FlexGrid.AutoResize = false;

			grillaC1FlexGrid.Styles[CellStyleEnum.Subtotal0].BackColor = Color.DarkGray;
			grillaC1FlexGrid.Styles[CellStyleEnum.Subtotal1].BackColor = Color.LightGray;

			grillaC1FlexGrid.Cols.RemoveRange(0, grillaC1FlexGrid.Cols.Count);

			var editorColumnas = grillaC1FlexGrid.ColumnEditor<DatoAsignacionSemanal>();

			_columnaTipoActividadDescripcion = editorColumnas.AddColumn(x => x.TipoActividadDescripcion, String.Empty, 10, false, false);
			_columnaIdProyectoActividad = editorColumnas.AddColumn(x => x.IdProyectoActividad, String.Empty, 10, false, false);
			_columnaProyectoActividadDescripcion = editorColumnas.AddColumn(x => x.ProyectoActividadDescripcion, String.Empty, 10, false, false);
			_columnaPersonaAsignacionAlias = editorColumnas.AddColumn(x => x.PersonaAsignacionAlias, "Descripción", 200);

			_columnaDiasPresupuestados = editorColumnas.AddColumn(x => x.DiasPresupuestados, "Presupuestados", 60);
			_columnaDiasPresupuestados.Format = Formatos.FormatoDecimal;

			_columnaDiasPrevistos = editorColumnas.AddColumn(x => x.DiasPrevistos, "Previstos", 60, true, true);
			_columnaDiasPrevistos.Format = Formatos.FormatoDecimal;

			_columnaDiasAsignados = editorColumnas.AddColumn(x => x.DiasAsignados, "Asignados", 60);
			_columnaDiasAsignados.Format = Formatos.FormatoDecimal;

			_columnasSemana.Clear();

			var inicioSemana = FechaInicio;

			#region SemanaA
			var columnaSemana = editorColumnas.AddColumn(x => x.DiasPorSemanaA, inicioSemana.ToShortDateString(), 60, true, true);
			columnaSemana.Format = Formatos.FormatoDecimal;
			_columnasSemana.Add(columnaSemana);
			inicioSemana = inicioSemana.AddDays(7);
			#endregion
			#region SemanaB
			columnaSemana = editorColumnas.AddColumn(x => x.DiasPorSemanaB, inicioSemana.ToShortDateString(), 60, true, true);
			columnaSemana.Format = Formatos.FormatoDecimal;
			_columnasSemana.Add(columnaSemana);
			inicioSemana = inicioSemana.AddDays(7);
			#endregion
			#region SemanaC
			columnaSemana = editorColumnas.AddColumn(x => x.DiasPorSemanaC, inicioSemana.ToShortDateString(), 60, true, true);
			columnaSemana.Format = Formatos.FormatoDecimal;
			_columnasSemana.Add(columnaSemana);
			inicioSemana = inicioSemana.AddDays(7);
			#endregion
			#region SemanaD
			columnaSemana = editorColumnas.AddColumn(x => x.DiasPorSemanaD, inicioSemana.ToShortDateString(), 60, true, true);
			columnaSemana.Format = Formatos.FormatoDecimal;
			_columnasSemana.Add(columnaSemana);
			inicioSemana = inicioSemana.AddDays(7);
			#endregion
			#region SemanaE
			columnaSemana = editorColumnas.AddColumn(x => x.DiasPorSemanaE, inicioSemana.ToShortDateString(), 60, true, true);
			columnaSemana.Format = Formatos.FormatoDecimal;
			_columnasSemana.Add(columnaSemana);
			inicioSemana = inicioSemana.AddDays(7);
			#endregion
			#region SemanaF
			columnaSemana = editorColumnas.AddColumn(x => x.DiasPorSemanaF, inicioSemana.ToShortDateString(), 60, true, true);
			columnaSemana.Format = Formatos.FormatoDecimal;
			_columnasSemana.Add(columnaSemana);
			inicioSemana = inicioSemana.AddDays(7);
			#endregion
			#region SemanaG
			columnaSemana = editorColumnas.AddColumn(x => x.DiasPorSemanaG, inicioSemana.ToShortDateString(), 60, true, true);
			columnaSemana.Format = Formatos.FormatoDecimal;
			_columnasSemana.Add(columnaSemana);
			inicioSemana = inicioSemana.AddDays(7);
			#endregion

			#region SemanaH
			columnaSemana = editorColumnas.AddColumn(x => x.DiasPorSemanaH, inicioSemana.ToShortDateString(), 60, true, true);
			columnaSemana.Format = Formatos.FormatoDecimal;
			_columnasSemana.Add(columnaSemana);
			#endregion

			grillaC1FlexGrid.DataSource = _grillaC1FlexGridBindingSource;
			grillaC1FlexGrid.Cols.Frozen = 7;

			var posicion = grillaC1FlexGrid.GetCellRect(0, _columnasSemana[0].SafeIndex);
			tableLayoutPanel1.ColumnStyles[0].Width = posicion.X;
		}

		private void GrillaC1FlexGrid_AfterDataRefresh(object sender, ListChangedEventArgs e)
		{
			if (DesignMode)
			{
				return;
			}

			try
			{
				grillaC1FlexGrid.Redraw = false;

				//Si la lista cambio (sucede cuando se refresca la lista de datos)
				if (e.ListChangedType != ListChangedType.Reset && e.ListChangedType != ListChangedType.ItemChanged)
				{
					return;
				}

				if (grillaC1FlexGrid.Cols.Count < 1 || grillaC1FlexGrid.Rows.Count < 1)
				{
					return;
				}

				//Limpiar totales anteriores
				grillaC1FlexGrid.Subtotal(AggregateEnum.Clear);

				//Indice de la columna donde se muestra el arbol (el simbolo +)
				grillaC1FlexGrid.Tree.Column = _columnaPersonaAsignacionAlias.SafeIndex;

				//Crear un nivel (1) con la suma, usando la columna de DescripcionActividad para detectar grupos
				grillaC1FlexGrid.Subtotal(AggregateEnum.Sum, 0,
								_columnaTipoActividadDescripcion.SafeIndex,
								_columnaDiasPresupuestados.SafeIndex,
								"{0}");

				//Crear un nivel (1) con la suma, usando la columna de DescripcionActividad para detectar grupos
				grillaC1FlexGrid.Subtotal(AggregateEnum.Min, 1,
								_columnaIdProyectoActividad.SafeIndex,				//Columna que se usa para detectar los agrupamientos
								_columnaProyectoActividadDescripcion.SafeIndex,
								_columnaDiasPresupuestados.SafeIndex,
								"{0}");

				CrearSubTotal(_columnaDiasPrevistos);
				CrearSubTotal(_columnaDiasAsignados);

				foreach (var columna in _columnasSemana)
				{
					CrearSubTotal(columna);
				}

				grillaC1FlexGrid.Refresh();
			}
			catch (Exception ex)
			{
				ExceptionPolicy.HandleException(ex, Constantes.ElErrorPolicy);
			}
			finally
			{
				grillaC1FlexGrid.Redraw = true;
			}
		}

		private void CrearSubTotal(Column columnaSuma)
		{
			//Crear un nivel (0) con la suma, usando la columna de DescripcionTipoActividad para detectar grupos
			grillaC1FlexGrid.Subtotal(AggregateEnum.Sum,								//Calcular una suma
							0,												//Nro de nivel de agregacion que se va a crear
							_columnaTipoActividadDescripcion.SafeIndex,			//Columna que se usa para detectar los agrupamientos
							columnaSuma.SafeIndex,							//Indice de la columna de la cual calcular el total
							"{0}");											//Titulo de la columna de agrupamiento

			//Crear un nivel (1) con la suma, usando la columna de DescripcionActividad para detectar grupos
			grillaC1FlexGrid.Subtotal(AggregateEnum.Sum,								//Calcular una suma
							1,												//Nro de nivel de agregacion que se va a crear
							_columnaIdProyectoActividad.SafeIndex,				//Columna que se usa para detectar los agrupamientos
							_columnaProyectoActividadDescripcion.SafeIndex,
							columnaSuma.SafeIndex,							//Indice de la columna de la cual calcular el total
							"{0}");											//Titulo de la columna de agrupamiento
		}

		private void GrillaC1FlexGrid_StartEdit(object sender, RowColEventArgs e)
		{
			var estiloFila = grillaC1FlexGrid.Rows[e.Row].Style;

			if (estiloFila == null)
			{
				return;
			}

			var estiloSubtotal0 = grillaC1FlexGrid.Styles[CellStyleEnum.Subtotal0];
			var estiloSubtotal1 = grillaC1FlexGrid.Styles[CellStyleEnum.Subtotal1];

			if (estiloFila.Name == estiloSubtotal0.Name || estiloFila.Name == estiloSubtotal1.Name)
			{
				e.Cancel = true;
			}
		}

		private void GrillaC1FlexGrid_OwnerDrawCell(object sender, OwnerDrawCellEventArgs e)
		{
			/*if (e.Col == _columnaDiasPresupuestados.SafeIndex)
			{
				var estiloFila = grillaC1FlexGrid.Rows[e.Row].Style;

				var estiloSubtotal0 = grillaC1FlexGrid.Styles[CellStyleEnum.Subtotal0];
				var estiloSubtotal1 = grillaC1FlexGrid.Styles[CellStyleEnum.Subtotal1];
				if (estiloFila == null || (estiloFila.Name != estiloSubtotal0.Name && estiloFila.Name != estiloSubtotal1.Name))
				{
					e.Handled = true;
				}
			}*/
		}

		private void SemanaAnteriorButton_Click(object sender, EventArgs e)
		{
			DesplazarSemanaActual(-1);
		}

		private void DesplazarSemanaActual(int cantSemanas)
		{
			FechaInicio = FechaInicio.AddDays(cantSemanas * 7);
		}

		private void PaginaSemanasAnteriorButton_Click(object sender, EventArgs e)
		{
			DesplazarSemanaActual(-CantidadDiasVisibles);
		}

		private void SemanaSiguienteButton_Click(object sender, EventArgs e)
		{
			DesplazarSemanaActual(1);
		}

		private void PaginaSemanasSiguienteButton_Click(object sender, EventArgs e)
		{
			DesplazarSemanaActual(CantidadDiasVisibles);
		}

		private void SemanaInicioProyectoButton_Click(object sender, EventArgs e)
		{
			//TODO: Hacer metodo SemanaInicioProyectoButton_Click
			//FechaInicio = 
		}

		private void SemanaActualButton_Click(object sender, EventArgs e)
		{
			FechaInicio = DateTime.Today;
		}

		private static DateTime CalcularInicioSemana(DateTime fecha)
		{
			DateTime diaTemporal = fecha.Date;
			while (diaTemporal.DayOfWeek != DayOfWeek.Monday)
			{
				diaTemporal = diaTemporal.AddDays(-1);
			}
			return diaTemporal;
		}
	}
}
