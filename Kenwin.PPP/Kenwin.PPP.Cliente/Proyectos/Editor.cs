using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Kenwin.PPP.Cliente.Comun;
using Kenwin.PPP.Cliente.Comun.Controles.FKBoxes;
using Kenwin.PPP.Cliente.Comun.Formularios;
using Kenwin.PPP.Cliente.Properties;
using Kenwin.PPP.Cliente.Proyectos.Formulas;
using Kenwin.PPP.Negocio.Comun;
using Kenwin.PPP.Negocio.Modelo;
using Kenwin.PPP.Negocio.Repositorios;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Vemn.Fwk.Windows.Controls;
using Vemn.Fwk.Windows.Controls.Extensions;
using Vemn.Fwk.Windows.Tools;

namespace Kenwin.PPP.Cliente.Proyectos
{
	public partial class Editor : PPPMDIFormBase
	{
		private bool HayCambios { get; set; }

		private ProyectoVersion _proyectoVersion;
		private ProyectoVersion _proyectoVersionAnterior;

		private readonly FormulasDatosProyectoVersion _formulas = new FormulasDatosProyectoVersion();

		private int? _idProyecto;

		private readonly BindingSource _proyectoBindingSource = new BindingSource();
		private readonly BindingSource _proyectoVersion1BindingSource = new BindingSource();
		private readonly BindingSource _proyectoVersion2BindingSource = new BindingSource();
		private readonly BindingSource _datosProyectoGrilla1BindingSource = new BindingSource();
		private readonly BindingSource _datosProyectoGrilla2BindingSource = new BindingSource();

		private Proyecto _proyecto;

		private Proyecto Proyecto
		{
			get { return _proyecto; }
			set
			{
				_proyecto = value;

				_proyectoBindingSource.DataSource = value;
			}
		}

		#region Columnas

		private Column _columnaEsCOPC;
		private Column _columnaDescripcionActividad;

		private Column _columnaHorasPorDia;
		private Column _columnaHorasCorreccion;
		private Column _columnaDias;
		private Column _columnaCantidadEventos;
		private Column _columnaCantidadParticipantes;
		private Column _columnaHorasTotales;
		private Column _columnaHorasEvento;
		private Column _columnaPorcentajeEvento;
		private Column _columnaHonorarios;
		private Column _columnaGastos;
		private Column _columnaPrecioBruto;
		private Column _columnaPrecioFinal;
		private Column _columnaRateFijo;
		private Column _columnaRateVariable;
		private Column _columnaDiasPorSemana;
		private Column _columnaFactor;

		#endregion

		private readonly Image _checkedImage;
		private readonly Image _uncheckedImage;

		private ActividadCustomSelector ActividadSelector { get; set; }

		public Editor()
		{
			InitializeComponent();

			if (!DesignMode)
			{
				_checkedImage = Resources.Checked_Image;
				_uncheckedImage = Resources.Unchecked_Image;

				versionAnteriorComboBox.FormattingEnabled = true;
				versionAnteriorComboBox.Format += ComboBox_Format;

				HabilitarVersionesAnteriores(false);

				probabilidadVersion1C1NumericEdit.EditFormat.FormatType = FormatTypeEnum.CustomFormat;
				probabilidadVersion1C1NumericEdit.EditFormat.CustomFormat = Formatos.FormatoPorcentaje;

				probabilidadVersion1C1NumericEdit.DisplayFormat.FormatType = FormatTypeEnum.CustomFormat;
				probabilidadVersion1C1NumericEdit.DisplayFormat.CustomFormat = Formatos.FormatoPorcentaje;
			}
		}

		public Editor(int idProyecto) : this()
		{
			_idProyecto = idProyecto;
		}

		private ProyectoVersion ProyectoVersionActual
		{
			get { return _proyectoVersion; }
			set
			{
				if (value == null)
				{
					throw new Exception();
				}

				_proyectoVersion = value;

				_proyectoVersion1BindingSource.DataSource = value;

				versionV1Label.Text = String.Format("Versión {0}", value.Version);

			}
		}

		private ProyectoVersion ProyectoVersionAnterior
		{
			get { return _proyectoVersionAnterior; }
			set
			{
				_proyectoVersionAnterior = value;

				_proyectoVersion2BindingSource.DataSource = value;

				if (value != null)
				{
					ObtenerDatosVersionAnterior(value.IdProyecto, value.Version);
				}
				else
				{
					ObtenerDatosVersionAnterior(Proyecto.IdProyecto, -1);
				}
			}
		}

		#region Metodos privados

		/// <summary>
		/// Crea una nueva fila para una actividad, y la inserta al final de su TipoActividad
		/// </summary>
		/// <param name="actividad"></param>
		private void AgregarActividad(Actividad actividad)
		{
			var datosProyectos = (List<DatosProyecto>)_datosProyectoGrilla1BindingSource.DataSource;

			//Busca el indice de la ultima actividad del mismo tipo
			var indiceUltimaActividad = datosProyectos
				.FindLastIndex(x => x.IdTipoActividad == actividad.IdTipoActividad);

			var ultimaActividad = datosProyectos[indiceUltimaActividad];

			var datoProyecto = new DatosProyecto
			{
				EsFilaDato = true,
				EsFilaActiva = true,

				Descripcion = actividad.DescripcionActividad,
				EsCOPC = actividad.EsCOPC ? "1" : "0",
				HorasPorDia = actividad.HorasPorDia.ToString(),
				HorasCorreccion = actividad.HorasCorreccion.ToString(),
				IdTipoActividad = actividad.IdTipoActividad,
				IdActividad = actividad.IdActividad,
				TipoCalculoHoras = actividad.TipoCalculoHoras,
				TipoCalculoPrecio = actividad.TipoCalculoPrecio,
				IdUnidadMedida = actividad.IdUnidadMedida,
				OrdenActividad = ultimaActividad.OrdenActividad + 1,
				Factor = null
			};

			//Obtiene el valor por defecto de su TipoActividadDato
			datoProyecto.DiasPorSemana = actividad.TipoActividad.TipoActividadDato
				.Where(x => x.OrdenColumna == (int)OrdenColumnasEnum.DiasPorSemana)
				.Select(x => x.ValorDefault)
				.FirstOrDefault()
				.ConvertirAString();

			Rates tarifas;
			if (actividad.TipoCalculoPrecio.HasValue)
			{
				tarifas = ObtenerRates(actividad, 0);

				if (tarifas == null)
				{
					return;
				}

				datoProyecto.RateFijo = tarifas.RateFijo != null ? tarifas.RateFijo.Rate.ConvertirAString(Formatos.FormatoEntero) : null;
				datoProyecto.CantidadTopeRateFijo = tarifas.RateFijo != null ? UtilidadesDecimal.ConvertirAString(tarifas.RateFijo.CantidadTope) : null;
				datoProyecto.RateVariable = tarifas.RateVariable != null ? tarifas.RateVariable.Rate.ConvertirAString(Formatos.FormatoEntero) : null;
				datoProyecto.CantidadTopeRateVariable = tarifas.RateVariable != null ? UtilidadesDecimal.ConvertirAString(tarifas.RateVariable.CantidadTope) : null;
			}

			_formulas.Aplicar(datoProyecto, true);

			var nuevoIndiceFila = indiceUltimaActividad + 1;

			//Inserta la nueva actividad como ultimo item del mismo tipo.
			_datosProyectoGrilla1BindingSource.Insert(nuevoIndiceFila, datoProyecto);

			AgregarActividadFalsaEnVersionAnterior(nuevoIndiceFila);

			HabilitarCambiosCabecera(false);

			//Hace foco en la nueva fila ingresada
			version1C1FlexGrid.Select(nuevoIndiceFila + 1, 1, true);

			version1C1FlexGrid.Refresh();

			HayCambios = true;
		}

		private void AgregarActividadFalsaEnVersionAnterior(int nuevoIndiceFila)
		{
			if (ProyectoVersionAnterior != null)
			{
				var proyectoTemp = new DatosProyecto
					{
						EsFilaDato = true
					};

				_datosProyectoGrilla2BindingSource.Insert(nuevoIndiceFila, proyectoTemp);
			}
		}

		private void HabilitarVersionesAnteriores(bool habilitar)
		{
			if(habilitar)
			{
				if (versionesSplitContainer.Panel2Collapsed)
				{
					expandirPanelVersionButton.Enabled = true;
				}
			}
			else
			{
				expandirPanelVersionButton.Enabled = false;
				versionesSplitContainer.Panel2Collapsed = true;
			}
		}

		private void HabilitarCambiosCabecera(bool permiteCambios)
		{
			proyectoPadreFKBox.Enabled = permiteCambios;
			nombreProyectoTextBox.ReadOnly = !permiteCambios;
			proyectoOTFKBox.Enabled = permiteCambios;
			clienteFKBox.Enabled = permiteCambios;
			monedaFKBox.Enabled = permiteCambios;
			paisFKBox.Enabled = permiteCambios;
		}

		private Rates ObtenerRates(Actividad actividad, int cantidad)
		{
			var fechaHoy = DateTime.Today;

			//Obtener todos los rates para la actividad, cliente, moneda y pais. Cliente y/o pais pueden ser nulos.
			var rates = RepositoryManager.ObjectContext
				.ActividadRateSet
				.Where(x => x.IdActividad == actividad.IdActividad)
				.Where(x => x.IdMoneda == monedaFKBox.SelectedItem.IdMoneda)
				.Where(x => x.Pais == null || x.IdPais == paisFKBox.SelectedItem.IdPais)
				.Where(x => x.Cliente == null || x.IdCliente == clienteFKBox.SelectedItem.IdCliente)
				.Where(x => x.FechaVigencia <= fechaHoy)
				.ToList();

			//Obtiene el primer rate fijo
			var rateFijo = rates
				.Where(x => x.EsRateFijo)
				.OrderByDescending(x => x.IdCliente)
				.ThenByDescending(x => x.IdPais)
				.FirstOrDefault();

			//Calcula la diferencia entre la cantidad ingresada y el tope del rate fijo
			// - Si no hay rate: cantidad (completa)
			// - Si el tope es mayor que la cantidad: 0
			//int cantidadRestante = rateFijo != null ? cantidad - (rateFijo.CantidadTope ?? cantidad) : cantidad;

			//Obtiene el primer rate variable
			var rateVariable = rates
				.Where(x => !x.EsRateFijo)
				//Obtener el rate variable que se ajuste a la cantidad restante
				//.Where(x => cantidadRestante <= 0 || (x.CantidadTope ?? cantidadRestante) <= cantidadRestante)
				//.OrderBy(x => x.CantidadTope ?? Int32.MaxValue)
				.OrderByDescending(x => x.IdCliente)
				.ThenByDescending(x => x.IdPais)
				.FirstOrDefault();

			if ((rateFijo == null && (actividad.TipoCalculoPrecio == 1 || actividad.TipoCalculoPrecio == 2)) ||
			   (rateVariable == null && (actividad.TipoCalculoPrecio == 2 || actividad.TipoCalculoPrecio == 3 || actividad.TipoCalculoPrecio == 4)))
			{
				MessageHelper.MostrarMensajeAtencion("No se encontraron rates necesarios para la actividad seleccionada.");
				return null;
			}

			return new Rates { RateFijo = rateFijo, RateVariable = rateVariable };
		}

		private bool GuardarCambios(bool solicitarConfirmacion)
		{
			if (!ValidarControles())
			{
				MessageHelper.MostrarMensajeAtencion("Existen datos no válidos. Debe corregirlos para poder guardar.");
				return false;
			}

			if (solicitarConfirmacion && MessageHelper.MostrarPregunta("¿Confirma que desea guardar los cambios?") != DialogResult.Yes)
			{
				return false;
			}

			try
			{
				var proyectoRepository = RepositoryManager.GetRepository<ProyectoRepository>();

				//Escribir bindings
				EscribirBindings(_proyectoBindingSource);
				EscribirBindings(_proyectoVersion1BindingSource);

				var proyecto = Proyecto;
				var proyectoVersion = ProyectoVersionActual;
				var datosProyecto = (List<DatosProyecto>)_datosProyectoGrilla1BindingSource.DataSource;

				proyectoRepository.GuardarProyectoCompleto(proyecto, proyectoVersion, datosProyecto);

				//Recargar el combo de versiones anteriores
				CargarComboVersionesAnteriores();

				ObtenerDatosVersionActual();

				HayCambios = false;

				return true;
			}
			catch (Exception ex)
			{
				ExceptionPolicy.HandleException(ex, Constantes.ElErrorPolicy);
				return false;
			}
		}

		private void EscribirBindings(BindingSource bindingSource)
		{
			try
			{
				bindingSource.RaiseListChangedEvents = false;

				BindingContext[bindingSource].Bindings
					.OfType<Binding>()
					.ToList()
					.ForEach(b => b.WriteValue());
			}
			finally
			{
				bindingSource.RaiseListChangedEvents = true;
			}
		}

		private bool ValidarControles()
		{
			bool hayError = !ValidarDatosObligatoriosProyecto(true);

			hayError |= ValidarControl(estadoVersionActualComboBox, x => x.SelectedIndex == -1, "Valor requerido", hayError);
			hayError |= !asignacionPersonal1.ValidarDatos();

			return !hayError;
		}

		private bool ValidarDatosObligatoriosProyecto(bool limpiarErroresPrevios)
		{
			if (limpiarErroresPrevios)
			{
				errorProvider.Clear();
			}

			bool hayError = false;

			hayError = ValidarControl(proyectoPadreFKBox, x => x.SelectedItem == null, "Valor requerido", hayError);
			hayError = ValidarControl(nombreProyectoTextBox, x => String.IsNullOrWhiteSpace(x.Text), "Valor requerido", hayError);
			hayError = ValidarControl(proyectoOTFKBox, x => x.SelectedItem == null, "Valor requerido", hayError);
			hayError = ValidarControl(clienteFKBox, x => x.SelectedItem == null, "Valor requerido", hayError);
			hayError = ValidarControl(monedaFKBox, x => x.SelectedItem == null, "Valor requerido", hayError);
			hayError = ValidarControl(paisFKBox, x => x.SelectedItem == null, "Valor requerido", hayError);
			hayError = ValidarControl(tipoEmpresaFKBox, x => x.SelectedItem == null, "Valor requerido", hayError);
			hayError = ValidarControl(tipoProyectoFKBox, x => x.SelectedItem == null, "Valor requerido", hayError);
			hayError = ValidarControl(unidadNegocioFKBox, x => x.SelectedItem == null, "Valor requerido", hayError);

			return !hayError;
		}

		private bool ValidarControl<T>(T control, Func<T, bool> condicion, string mensajeError, bool hayErrorPrevio) where T : Control
		{
			bool hayError = false;
			if (condicion(control))
			{
				hayError = true;

				errorProvider.SetError(control, mensajeError);
				if (!hayErrorPrevio)
				{
					control.Focus();
				}
			}
			return hayError || hayErrorPrevio;
		}

		private void ConfigurarGrillas()
		{
			#region Grilla 1 - Version Actual

			version1C1FlexGrid.Rows[0].Visible = false;
			version1C1FlexGrid.SelectionMode = SelectionModeEnum.Row;

			var editorColumnas = version1C1FlexGrid.ColumnEditor<DatosProyecto>();

			_columnaDescripcionActividad = editorColumnas.AddColumn(x => x.Descripcion, String.Empty, 120, true, true);
			_columnaEsCOPC = editorColumnas.AddColumn(x => x.EsCOPC, String.Empty, 40);

			_columnaHorasPorDia = editorColumnas.AddColumn(x => x.HorasPorDia, String.Empty, 45, true, true);
			_columnaHorasPorDia.TextAlign = TextAlignEnum.RightCenter;
			_columnaHorasPorDia.Editor = new DecimalBox();

			_columnaHorasCorreccion = editorColumnas.AddColumn(x => x.HorasCorreccion, String.Empty, 35, true, true);
			_columnaHorasCorreccion.TextAlign = TextAlignEnum.RightCenter;
			_columnaHorasCorreccion.Editor = new DecimalBox();

			_columnaDias = editorColumnas.AddColumn(x => x.Dias, String.Empty, 45, true, true);
			_columnaDias.TextAlign = TextAlignEnum.RightCenter;
			_columnaDias.Editor = new DecimalBox();

			_columnaCantidadEventos = editorColumnas.AddColumn(x => x.CantidadEventos, String.Empty, 45, true, true);
			_columnaCantidadEventos.TextAlign = TextAlignEnum.RightCenter;
			_columnaCantidadEventos.Editor = new DecimalBox();

			_columnaCantidadParticipantes = editorColumnas.AddColumn(x => x.CantidadParticipantes, String.Empty, 55, true, true);
			_columnaCantidadParticipantes.TextAlign = TextAlignEnum.RightCenter;
			_columnaCantidadParticipantes.Editor = new DecimalBox();

			var columna = editorColumnas.AddColumn(x => x.HorasEventoIngresado, String.Empty, 45, true, true);
			columna.TextAlign = TextAlignEnum.RightCenter;
			columna.Editor = new DecimalBox();

			columna = editorColumnas.AddColumn(x => x.HorasAdicionales, String.Empty, 45, true, true);
			columna.TextAlign = TextAlignEnum.RightCenter;
			columna.Editor = new DecimalBox();

			_columnaHorasTotales = editorColumnas.AddColumn(x => x.HorasTotales, String.Empty, 65, true, true);
			_columnaHorasTotales.TextAlign = TextAlignEnum.RightCenter;
			_columnaHorasTotales.Editor = new DecimalBox();

			_columnaHorasEvento = editorColumnas.AddColumn(x => x.HorasEvento, String.Empty, 45, true, true);
			_columnaHorasEvento.TextAlign = TextAlignEnum.RightCenter;
			_columnaHorasEvento.Editor = new DecimalBox();

			_columnaPorcentajeEvento = editorColumnas.AddColumn(x => x.PorcentajeEvento, String.Empty, 55, true, true);
			_columnaPorcentajeEvento.TextAlign = TextAlignEnum.RightCenter;
			_columnaPorcentajeEvento.Editor = new DecimalBox();

			_columnaHonorarios = editorColumnas.AddColumn(x => x.Honorarios, String.Empty, 65, true, true);
			_columnaHonorarios.TextAlign = TextAlignEnum.RightCenter;
			_columnaHonorarios.Editor = new DecimalBox();

			_columnaGastos = editorColumnas.AddColumn(x => x.Gastos, String.Empty, 55, true, true);
			_columnaGastos.TextAlign = TextAlignEnum.RightCenter;
			_columnaGastos.Editor = new DecimalBox();

			_columnaPrecioBruto = editorColumnas.AddColumn(x => x.PrecioBruto, String.Empty, 65, true, true);
			_columnaPrecioBruto.TextAlign = TextAlignEnum.RightCenter;
			_columnaPrecioBruto.Editor = new DecimalBox();

			_columnaPrecioFinal = editorColumnas.AddColumn(x => x.PrecioFinal, String.Empty, 65, true, true);
			_columnaPrecioFinal.TextAlign = TextAlignEnum.RightCenter;
			_columnaPrecioFinal.Editor = new DecimalBox();

			_columnaRateFijo = editorColumnas.AddColumn(x => x.RateFijo, String.Empty, 55, true, true);
			_columnaRateFijo.TextAlign = TextAlignEnum.RightCenter;
			_columnaRateFijo.Editor = new DecimalBox();

			_columnaRateVariable = editorColumnas.AddColumn(x => x.RateVariable, String.Empty, 45, true, true);
			_columnaRateVariable.TextAlign = TextAlignEnum.RightCenter;
			_columnaRateVariable.Editor = new DecimalBox();

			_columnaDiasPorSemana = editorColumnas.AddColumn(x => x.DiasPorSemana, String.Empty, 35, true, true);
			_columnaDiasPorSemana.TextAlign = TextAlignEnum.RightCenter;
			_columnaDiasPorSemana.Editor = new DecimalBox();

			_columnaFactor = editorColumnas.AddColumn(x => x.Factor, String.Empty, 55, true, true);
			_columnaFactor.TextAlign = TextAlignEnum.RightCenter;
			_columnaFactor.Editor = new DecimalBox();

			version1C1FlexGrid.Cols.Frozen = 2;

			#endregion

			#region Grilla 2 - Version Anterior

			version2C1FlexGrid.Cols[0].Visible = false;
			version2C1FlexGrid.Rows[0].Visible = false;
			version2C1FlexGrid.SelectionMode = SelectionModeEnum.Row;

			editorColumnas = version2C1FlexGrid.ColumnEditor<DatosProyecto>();

			editorColumnas.AddColumn(x => x.HorasPorDia, String.Empty, 45)
				.TextAlign = TextAlignEnum.RightCenter;
			editorColumnas.AddColumn(x => x.HorasCorreccion, String.Empty, 35)
				.TextAlign = TextAlignEnum.RightCenter;

			editorColumnas.AddColumn(x => x.Dias, String.Empty, 45)
				.TextAlign = TextAlignEnum.RightCenter;
			editorColumnas.AddColumn(x => x.CantidadEventos, String.Empty, 45)
				.TextAlign = TextAlignEnum.RightCenter;
			editorColumnas.AddColumn(x => x.CantidadParticipantes, String.Empty, 55)
				.TextAlign = TextAlignEnum.RightCenter;
			editorColumnas.AddColumn(x => x.HorasEventoIngresado, String.Empty, 45)
				.TextAlign = TextAlignEnum.RightCenter;
			editorColumnas.AddColumn(x => x.HorasAdicionales, String.Empty, 45)
				.TextAlign = TextAlignEnum.RightCenter;
			editorColumnas.AddColumn(x => x.HorasTotales, String.Empty, 65)
				.TextAlign = TextAlignEnum.RightCenter;
			editorColumnas.AddColumn(x => x.HorasEvento, String.Empty, 45)
				.TextAlign = TextAlignEnum.RightCenter;
			editorColumnas.AddColumn(x => x.PorcentajeEvento, String.Empty, 55)
				.TextAlign = TextAlignEnum.RightCenter;
			editorColumnas.AddColumn(x => x.Honorarios, String.Empty, 65)
				.TextAlign = TextAlignEnum.RightCenter;
			editorColumnas.AddColumn(x => x.Gastos, String.Empty, 55)
				.TextAlign = TextAlignEnum.RightCenter;
			editorColumnas.AddColumn(x => x.PrecioBruto, String.Empty, 65)
				.TextAlign = TextAlignEnum.RightCenter;
			editorColumnas.AddColumn(x => x.PrecioFinal, String.Empty, 65)
				.TextAlign = TextAlignEnum.RightCenter;
			editorColumnas.AddColumn(x => x.RateFijo, String.Empty, 55)
				.TextAlign = TextAlignEnum.RightCenter;
			editorColumnas.AddColumn(x => x.RateVariable, String.Empty, 45)
				.TextAlign = TextAlignEnum.RightCenter;
			editorColumnas.AddColumn(x => x.DiasPorSemana, String.Empty, 35)
				.TextAlign = TextAlignEnum.RightCenter;
			editorColumnas.AddColumn(x => x.Factor, String.Empty, 55)
				.TextAlign = TextAlignEnum.RightCenter;

			#endregion
		}

		private void CrearNuevoProyecto()
		{
			Proyecto = new Proyecto
			{
				Creador = RepositoryManager.GetRepository<PersonaRepository>()
					.GetEntity(ContextoAplicacion.Instancia.UsuarioLogueado.IdPersona)

			};

			ProyectoVersionActual = new ProyectoVersion
			{
				Proyecto = Proyecto,
				Version = 1,
				FechaVersion = DateTime.Now,
			};

			//ProyectoVersionAnterior = null;

			HabilitarVersionesAnteriores(false);
		}

		private void AplicarFormulas(List<DatosProyecto> datosProyectoVersion)
		{
			_formulas.Aplicar(datosProyectoVersion);
		}

		private void ConfigurarBindings()
		{
			#region Proyecto

			_proyectoBindingSource.DataSource = typeof(Proyecto);

			//Datos en el encabezado
			proyectoPadreFKBox.DataBindings.Add("SelectedItem", _proyectoBindingSource, "ProyectoOT.ProyectoPadre", true, DataSourceUpdateMode.Never);
			nombreProyectoTextBox.DataBindings.Add("Text", _proyectoBindingSource, "NombreProyecto", true, DataSourceUpdateMode.Never);
			proyectoOTFKBox.DataBindings.Add("SelectedItem", _proyectoBindingSource, "ProyectoOT", true, DataSourceUpdateMode.Never);
			clienteFKBox.DataBindings.Add("SelectedItem", _proyectoBindingSource, "Cliente", true, DataSourceUpdateMode.Never);
			monedaFKBox.DataBindings.Add("SelectedItem", _proyectoBindingSource, "Moneda", true, DataSourceUpdateMode.Never);

			//Datos en la solapa de Datos Generales
			paisFKBox.DataBindings.Add("SelectedItem", _proyectoBindingSource, "Pais", true, DataSourceUpdateMode.Never);
			unidadNegocioFKBox.DataBindings.Add("SelectedItem", _proyectoBindingSource, "UnidadNegocio", true, DataSourceUpdateMode.Never);
			tipoEmpresaFKBox.DataBindings.Add("SelectedItem", _proyectoBindingSource, "TipoEmpresa", true, DataSourceUpdateMode.Never);
			tipoProyectoFKBox.DataBindings.Add("SelectedItem", _proyectoBindingSource, "TipoProyecto", true, DataSourceUpdateMode.Never);
			contactoComercialTextBox.DataBindings.Add("Text", _proyectoBindingSource, "ContactoComercial", true, DataSourceUpdateMode.Never);
			liderClienteTextBox.DataBindings.Add("Text", _proyectoBindingSource, "LiderEnCliente", true, DataSourceUpdateMode.Never);
			observacionesTextBox.DataBindings.Add("Text", _proyectoBindingSource, "Observaciones", true, DataSourceUpdateMode.Never);
			usuarioCreadorTextBox.DataBindings.Add("Text", _proyectoBindingSource, "Creador.Alias", true, DataSourceUpdateMode.Never);

			#endregion

			#region Proyecto Version 1
			_proyectoVersion1BindingSource.DataSource = typeof(ProyectoVersion);

			//Fecha version
			var fechaVersionBinding = fechaVersionV1TextBox.DataBindings.Add("Text", _proyectoVersion1BindingSource, "FechaVersion", true, DataSourceUpdateMode.Never);
			fechaVersionBinding.FormatString = "d";

			//Estado
			estadoVersionActualComboBox.DataSource = RepositoryManager.ObjectContext.EstadoProyectoSet.ToList();
			estadoVersionActualComboBox.DisplayMember = "DescripcionEstadoProyecto";
			estadoVersionActualComboBox.ValueMember = "IdEstadoProyecto";
			estadoVersionActualComboBox.DataBindings.Add("SelectedValue", _proyectoVersion1BindingSource, "IdEstadoProyecto", false, DataSourceUpdateMode.Never);

			//Probabilidad
			probabilidadVersion1C1NumericEdit.DataBindings.Add("Value", _proyectoVersion1BindingSource, "Probabilidad", true, DataSourceUpdateMode.Never);

			//Fecha Inicio Proyecto
			var fechaInicioProyecto = fechaInicioProyectoVersionActualC1DateEdit.DataBindings.Add("Value", _proyectoVersion1BindingSource, "FechaInicioProyecto", true, DataSourceUpdateMode.Never);
			fechaInicioProyecto.FormatString = "d";

			version1C1FlexGrid.DataSource = _datosProyectoGrilla1BindingSource;

			#endregion

			#region Proyecto Version 2

			_proyectoVersion2BindingSource.DataSource = typeof(ProyectoVersion);

			//Fecha version
			fechaVersionBinding = fechaVersionV2TextBox.DataBindings.Add("Text", _proyectoVersion2BindingSource, "FechaVersion", true);
			fechaVersionBinding.FormatString = "d";

			//Estado
			estadoVersionAnteriorComboBox.DataSource = RepositoryManager.ObjectContext.EstadoProyectoSet.ToList();
			estadoVersionAnteriorComboBox.DisplayMember = "DescripcionEstadoProyecto";
			estadoVersionAnteriorComboBox.ValueMember = "IdEstadoProyecto";
			estadoVersionAnteriorComboBox.DataBindings.Add("SelectedValue", _proyectoVersion2BindingSource, "IdEstadoProyecto");

			//Probabilidad
			var probabilidadBinding = probabilidadVersion2TextBox.DataBindings.Add("Text", _proyectoVersion2BindingSource, "Probabilidad");
			probabilidadBinding.FormatString = Formatos.FormatoPorcentaje;
			probabilidadBinding.FormattingEnabled = true;

			//Fecha Inicio Proyecto
			var fechaInicioProyectoBinding = fechaInicioProyectoVersionAnteriorTextBox.DataBindings.Add("Text", _proyectoVersion2BindingSource, "FechaInicioProyecto", true);
			fechaInicioProyectoBinding.FormatString = "d";

			version2C1FlexGrid.DataSource = _datosProyectoGrilla2BindingSource;

			#endregion
		}

		private void CargarProyecto(int idProyecto)
		{
			Proyecto = RepositoryManager.GetRepository<ProyectoRepository>()
				.ObtenerProyecto(idProyecto);

			this.Text = String.Format("{0} {1}", this.Text, Proyecto.NombreProyecto);

			ProyectoVersionActual = Proyecto.ProyectoVersionSet
				.OrderByDescending(x => x.Version)
				.FirstOrDefault();

			ObtenerDatosVersionActual();
		}

		private void CrearVersionProyecto(ProyectoVersion versionOrigen, List<DatosProyecto> datosVersion)
		{
			if (!GuardarCambios(false))
			{
				return;
			}

			var nuevaVersion = new ProyectoVersion
			{
				Cerrada = false,
				Entidad = versionOrigen.Entidad,
				EstadoProyecto = versionOrigen.EstadoProyecto,
				FechaInicioProyecto = versionOrigen.FechaInicioProyecto,
				FechaVersion = DateTime.Now,
				IdProyecto = ProyectoVersionActual.IdProyecto,
				IdEstadoProyecto = versionOrigen.IdEstadoProyecto,
				Probabilidad = versionOrigen.Probabilidad,
				Version = ProyectoVersionActual.Version + 1
			};

			ProyectoVersionActual = nuevaVersion;

			datosVersion.ForEach(x => x.IdProyectoVersionActividad = null);

			_datosProyectoGrilla1BindingSource.DataSource = datosVersion;

			CalcularSumatoriasVersionActual();

			HayCambios = true;

			HabilitarVersionesAnteriores(true);

			CargarComboVersionesAnteriores();

			//Mostrar mensaje
			MessageHelper.MostrarMensajeInfo("Se ha creado una nueva Versión " + nuevaVersion.Version);
		}

		private void CargarComboVersionesAnteriores()
		{
			if (Proyecto == null || Proyecto.IdProyecto == 0)
			{
				return;
			}

			//Obtiene la lista de versiones del proyecto.
			var listaVersiones = RepositoryManager.ObjectContext
				.ProyectoVersionSet
				.Where(x => x.IdProyecto == Proyecto.IdProyecto)
				.OrderByDescending(x => x.Version)
				.ToList();

			//guarda la version seleccionada
			var versionSeleccionada = ProyectoVersionAnterior;

			versionAnteriorComboBox.DataSource = listaVersiones;
			versionAnteriorComboBox.DisplayMember = "Version";
			versionAnteriorComboBox.ValueMember = "IdProyectoVersion";

			if (versionAnteriorComboBox.Items.Count > 0)
			{
				if (versionSeleccionada != null)
				{
					//selecciona el item previamente seleccionado
					versionAnteriorComboBox.SelectedItem = versionSeleccionada;
				}
				else
				{
					//Si hay mas de un item, seleccionada el segundo, sino el primero
					versionAnteriorComboBox.SelectedIndex = versionAnteriorComboBox.Items.Count > 1 ? 1 : 0;
				}

				HabilitarVersionesAnteriores(true);
			}
			else
			{
				HabilitarVersionesAnteriores(false);
			}

		}

		private void ObtenerDatosVersionActual()
		{
			var versionActual = ProyectoVersionActual;

			var proyectoVersion = RepositoryManager.GetRepository<ProyectoRepository>()
				.ObtenerDatosProyectoVersion(versionActual.IdProyecto, versionActual.Version);

			foreach (var dato in proyectoVersion.Where(x => x.EsFilaDato))
			{
				//Formatear los datos de la columna PorcentajeEvento y Factor
				dato.PorcentajeEvento = dato.PorcentajeEvento.ConvertirADecimal().ConvertirAString(Formatos.FormatoPorcentajeConDecimales);
				dato.Factor = dato.Factor.ConvertirADecimal().ConvertirAString(Formatos.FormatoDecimalExtendido);
			}

			AplicarFormulas(proyectoVersion);

			_datosProyectoGrilla1BindingSource.DataSource = proyectoVersion;

			version1C1FlexGrid.AllowEditing = !versionActual.Cerrada;

			CalcularSumatoriasVersionActual();

			asignacionSemanal1.FechaInicio = DateTime.Today;
			asignacionSemanal1.ActividadesProyecto = proyectoVersion;
		}

		private void ObtenerDatosVersionAnterior(int idProyecto, int nroVersion)
		{
			var proyectoVersion = RepositoryManager.GetRepository<ProyectoRepository>()
				.ObtenerDatosProyectoVersion(idProyecto, nroVersion);

			foreach (var dato in proyectoVersion.Where(x => x.EsFilaDato))
			{
				//Formatear los datos de la columna PorcentajeEvento y Factor
				dato.PorcentajeEvento = dato.PorcentajeEvento.ConvertirADecimal().ConvertirAString(Formatos.FormatoPorcentajeConDecimales);
				dato.Factor = dato.Factor.ConvertirADecimal().ConvertirAString(Formatos.FormatoDecimalExtendido);
			}

			_datosProyectoGrilla2BindingSource.DataSource = proyectoVersion;

			var datosProyectoOriginal = (List<DatosProyecto>)_datosProyectoGrilla1BindingSource.DataSource;
			if (datosProyectoOriginal != null)
			{
				for (int i = 0; i < datosProyectoOriginal.Count; i++)
				{
					var filaDato = datosProyectoOriginal[i];

					//Si la actividad es nueva para el proyecto, agregar un item falso a la version anterior
					if (filaDato.EsFilaDato && !filaDato.IdProyectoActividad.HasValue)
					{
						AgregarActividadFalsaEnVersionAnterior(i);
					}
				}
			}

			CalcularSumatoriasVersionAnterior();
		}

		private static bool FilaTieneTitulo(C1FlexGrid grilla, int nroFila, int nroColumna)
		{
			int nroFilaTitulo = nroFila;

			DatosProyecto datoFila;
			do
			{
				nroFilaTitulo--;
				datoFila = (DatosProyecto)grilla.Rows[nroFilaTitulo].DataSource;
			} while (datoFila.EsFilaDato);

			return grilla[nroFilaTitulo, nroColumna] != null;
		}

		private void SincronizarBarraScroll(C1FlexGrid grillaOrigen)
		{
			//Selecciona la grilla restante
			var grillaDestino = grillaOrigen == version1C1FlexGrid
				? version2C1FlexGrid
				: version1C1FlexGrid;

			//Iguala los valores de scroll vertical (Y) de las grillas.
			grillaDestino.ScrollPosition = new Point(grillaDestino.ScrollPosition.X, grillaOrigen.ScrollPosition.Y);
		}

		private void EliminarActividad(int nroFila)
		{
			var datoFila = (DatosProyecto)version1C1FlexGrid.Rows[nroFila].DataSource;
			if (datoFila == null)
			{
				return;
			}

			//Si la actividad fue agregada sin guardar
			if (!datoFila.IdProyectoActividad.HasValue)
			{
				//se eliminan las filas en ambas grillas.
				version1C1FlexGrid.Rows.Remove(nroFila);

				if (version2C1FlexGrid.IsCellValid(nroFila, 0))
				{
					version2C1FlexGrid.Rows.Remove(nroFila);
				}
			}
			else
			{
				datoFila.Dias = null;
				datoFila.CantidadEventos = null;
				datoFila.CantidadParticipantes = null;
				datoFila.HorasTotales = null;
				datoFila.HorasEvento = null;
				datoFila.PorcentajeEvento = null;
				datoFila.Gastos = null;
				datoFila.PrecioBruto = null;
				datoFila.PrecioFinal = null;
				datoFila.HorasAdicionales = null;
				datoFila.RateFijo = null;
				datoFila.RateVariable = null;
				datoFila.Factor = null;
				datoFila.HorasCorreccion = null;
				datoFila.HorasPorDia = null;

				datoFila.EsFilaActiva = false;
			}

			CalcularSumatoriasVersionActual();
		}

		private void CalcularSumatoriasVersionActual()
		{
			var datosVersion = (List<DatosProyecto>)_datosProyectoGrilla1BindingSource.DataSource;

			//Total horas
			textBox1.Text = datosVersion
				.Where(x => x.EsFilaDato)
				.Sum(x => x.HorasTotales.ConvertirADecimal() ?? 0)
				.ConvertirAString();

			//Total dias
			textBox2.Text = datosVersion
				.Where(x => x.EsFilaDato)
				.Sum(x => x.Dias.ConvertirADecimal() ?? 0)
				.ConvertirAString();

			//Precio Bruto
			textBox3.Text = datosVersion
				.Where(x => x.EsFilaDato)
				.Sum(x => x.PrecioBruto.ConvertirADecimal() ?? 0)
				.ConvertirAString();

			//Precio Final
			textBox4.Text = datosVersion
				.Where(x => x.EsFilaDato)
				.Sum(x => x.PrecioFinal.ConvertirADecimal() ?? 0)
				.ConvertirAString();

			//Total Gastos
			textBox5.Text = datosVersion
				.Where(x => x.EsFilaDato)
				.Sum(x => x.Gastos.ConvertirADecimal() ?? 0)
				.ConvertirAString();

			//Total COPC
			textBox6.Text = datosVersion
				.Where(x => x.EsFilaDato && x.EsCOPC == "1")
				.Sum(x => x.PrecioFinal.ConvertirADecimal() ?? 0)
				.ConvertirAString();

			//Total no COPC
			textBox7.Text = datosVersion
				.Where(x => x.EsFilaDato && x.EsCOPC == "0")
				.Sum(x => x.PrecioFinal.ConvertirADecimal() ?? 0)
				.ConvertirAString();
		}

		private void CalcularSumatoriasVersionAnterior()
		{
			var datosVersion = (List<DatosProyecto>)_datosProyectoGrilla2BindingSource.DataSource;

			//Total horas
			textBox8.Text = datosVersion
				.Where(x => x.EsFilaDato)
				.Sum(x => x.HorasTotales.ConvertirADecimal() ?? 0)
				.ConvertirAString();

			//Total dias
			textBox9.Text = datosVersion
				.Where(x => x.EsFilaDato)
				.Sum(x => x.Dias.ConvertirADecimal() ?? 0)
				.ConvertirAString();

			//Precio Bruto
			textBox10.Text = datosVersion
				.Where(x => x.EsFilaDato)
				.Sum(x => x.PrecioBruto.ConvertirADecimal() ?? 0)
				.ConvertirAString();

			//Precio Final
			textBox11.Text = datosVersion
				.Where(x => x.EsFilaDato)
				.Sum(x => x.PrecioFinal.ConvertirADecimal() ?? 0)
				.ConvertirAString();

			//Total Gastos
			textBox12.Text = datosVersion
				.Where(x => x.EsFilaDato)
				.Sum(x => x.Gastos.ConvertirADecimal() ?? 0)
				.ConvertirAString();

			//Total COPC
			textBox13.Text = datosVersion
				.Where(x => x.EsFilaDato && x.EsCOPC == "1")
				.Sum(x => x.PrecioFinal.ConvertirADecimal() ?? 0)
				.ConvertirAString();

			//Total no COPC
			textBox14.Text = datosVersion
				.Where(x => x.EsFilaDato && x.EsCOPC == "0")
				.Sum(x => x.PrecioFinal.ConvertirADecimal() ?? 0)
				.ConvertirAString();
		}

		private bool ReactivarFila(int nroFila)
		{
			if (!version1C1FlexGrid.IsCellValid(nroFila, 0))
			{
				return false;
			}

			var datosProyecto = (DatosProyecto)version1C1FlexGrid.Rows[nroFila].DataSource;

			if (datosProyecto.EsFilaActiva)
			{
				return true;
			}

			if (datosProyecto.EsFilaDato)
			{
				var actividad = RepositoryManager
					.GetRepository<ActividadRepository>()
					.GetEntity(datosProyecto.IdActividad);

				if (actividad != null)
				{
					var tarifas = ObtenerRates(actividad, 0);
					if (tarifas != null)
					{
						datosProyecto.HorasPorDia = actividad.HorasPorDia.ConvertirAString();
						datosProyecto.HorasCorreccion = actividad.HorasCorreccion.ConvertirAString();

						datosProyecto.RateFijo = tarifas.RateFijo != null ? tarifas.RateFijo.Rate.ConvertirAString(Formatos.FormatoEntero) : null;
						datosProyecto.CantidadTopeRateFijo = tarifas.RateFijo != null ? UtilidadesDecimal.ConvertirAString(tarifas.RateFijo.CantidadTope) : null;
						datosProyecto.RateVariable = tarifas.RateVariable != null ? tarifas.RateVariable.Rate.ConvertirAString(Formatos.FormatoEntero) : null;
						datosProyecto.CantidadTopeRateVariable = tarifas.RateVariable != null ? UtilidadesDecimal.ConvertirAString(tarifas.RateVariable.CantidadTope) : null;

						datosProyecto.Factor = null;

						datosProyecto.EsFilaActiva = true;

						version1C1FlexGrid.Refresh();

						return true;
					}
				}
			}

			return false;
		}

		private bool CeldaEsEditable(C1FlexGrid grilla, int nroFila, int nroColumna)
		{
			if (!grilla.AllowEditing || !grilla.IsCellValid(nroFila, nroColumna)
				|| !grilla.Cols[nroColumna].AllowEditing || !grilla.Rows[nroFila].AllowEditing)
			{
				return false;
			}

			var datoProyecto = grilla.Rows[nroFila].DataSource as DatosProyecto;
			if (datoProyecto != null)
			{
				var columna = grilla.Cols[nroColumna];

				return datoProyecto.EsFilaDato && FilaTieneTitulo(grilla, nroFila, nroColumna) && !_formulas.TieneFormula(datoProyecto, columna.Name);
			}
			return false;
		}

		private void BorrarCeldaActual(C1FlexGrid grilla)
		{
			var nroFila = grilla.Row;
			var nroColumna = grilla.Col;

			if (!grilla.IsCellValid(nroFila, nroColumna))
			{
				return;
			}

			if (CeldaEsEditable(grilla, nroFila, nroColumna))
			{
				grilla.SetData(nroFila, nroColumna, null);
				CalcularSumatoriasVersionActual();
			}
		}

		private void CrearProyectoDesdeActual()
		{
			GuardarCambios(false);

			var proyectoOriginal = Proyecto;

			//Crear proyecto y version nuevos
			CrearNuevoProyecto();

			HabilitarCambiosCabecera(true);

			clienteFKBox.SelectedItem = proyectoOriginal.Cliente;
			clienteFKBox.Enabled = false;

			paisFKBox.SelectedItem = proyectoOriginal.Pais;
			paisFKBox.Enabled = false;

			monedaFKBox.SelectedItem = proyectoOriginal.Moneda;
			monedaFKBox.Enabled = false;

			var proyectoVersion = (List<DatosProyecto>)_datosProyectoGrilla1BindingSource.DataSource;

			proyectoVersion.ForEach(x =>
			{
				x.IdProyectoActividad = null;
				x.IdProyectoVersionActividad = null;
			});

			//Seleccionar tab de datos generales
			tabControl1.SelectedIndex = 0;
		}

		private bool ComprobarCambios()
		{
			bool hayCambios = false;

			//Cabecera
			hayCambios |= Proyecto.ProyectoOT != null
				? Proyecto.ProyectoOT.ProyectoPadre != proyectoPadreFKBox.SelectedItem
				: true;
			hayCambios |= Proyecto.NombreProyecto != nombreProyectoTextBox.Text;
			hayCambios |= Proyecto.ProyectoOT != proyectoOTFKBox.SelectedItem;
			hayCambios |= Proyecto.Cliente != clienteFKBox.SelectedItem;
			hayCambios |= Proyecto.Moneda != monedaFKBox.SelectedItem;

			//Solapa Datos
			hayCambios |= Proyecto.Pais != paisFKBox.SelectedItem;
			hayCambios |= Proyecto.TipoEmpresa != tipoEmpresaFKBox.SelectedItem;
			hayCambios |= Proyecto.TipoProyecto != tipoProyectoFKBox.SelectedItem;
			hayCambios |= Proyecto.UnidadNegocio != unidadNegocioFKBox.SelectedItem;
			hayCambios |= Proyecto.ContactoComercial != contactoComercialTextBox.Text;
			hayCambios |= Proyecto.LiderEnCliente != liderClienteTextBox.Text;
			hayCambios |= Proyecto.Observaciones != observacionesTextBox.Text;

			//Solapa Actividades
			hayCambios |= ProyectoVersionActual.EstadoProyecto != estadoVersionActualComboBox.SelectedItem;
			hayCambios |= ProyectoVersionActual.Probabilidad !=
				(probabilidadVersion1C1NumericEdit.ValueIsDbNull
				? null
				: (decimal?)probabilidadVersion1C1NumericEdit.Value);
			hayCambios |= ProyectoVersionActual.FechaInicioProyecto !=
				(fechaInicioProyectoVersionActualC1DateEdit.ValueIsDbNull
				? null
				: (DateTime?)fechaInicioProyectoVersionActualC1DateEdit.Value);
			hayCambios |= HayCambios;

			return hayCambios;
		}

		#endregion

		#region Manejadores de eventos

		private void Editor_Load(object sender, EventArgs e)
		{
			proyectoPadreFKBox.Manager = RepositoryManager;
			proyectoOTFKBox.Manager = RepositoryManager;
			clienteFKBox.Manager = RepositoryManager;
			monedaFKBox.Manager = RepositoryManager;
			paisFKBox.Manager = RepositoryManager;
			unidadNegocioFKBox.Manager = RepositoryManager;
			tipoEmpresaFKBox.Manager = RepositoryManager;
			tipoProyectoFKBox.Manager = RepositoryManager;

			ActividadSelector = new ActividadCustomSelector(this, RepositoryManager);

			ConfigurarBindings();

			ConfigurarGrillas();

			if (_idProyecto.HasValue)
			{
				//Edicion
				HabilitarCambiosCabecera(false);

				CargarProyecto(_idProyecto.Value);

				CargarComboVersionesAnteriores();

				HayCambios = false;
			}
			else
			{
				//Alta
				HabilitarCambiosCabecera(true);

				CrearNuevoProyecto();

				ObtenerDatosVersionActual();

				HayCambios = true;
			}


			//TODO: Fix temporal para que bindee los controles de la solapa de actividades
			tabControl1.SelectedIndex = 1;
			System.Threading.Thread.Sleep(50);
			if (!_idProyecto.HasValue)
			{
				//Si es un pedido nuevo, mostrar el tab de datos generales
				tabControl1.SelectedIndex = 0;
			}

			asignacionPersonal1.RepositoryManager = RepositoryManager;
			asignacionPersonal1.CargarAsignacionesProyecto(Proyecto);
		}

		private void Editor_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (ComprobarCambios())
			{
				var resultado = MessageHelper.MostrarPregunta("Existen datos pendientes de ser guardados. ¿Está seguro de salir y deshacer los últimos cambios?");
				if (resultado == DialogResult.No)
				{
					e.Cancel = true;
				}
			}
		}

		private static void ComboBox_Format(object sender, ListControlConvertEventArgs e)
		{
			e.Value = String.Format("Versión {0}", e.Value);
		}

		private void ProyectoPadreFKBox_SelectedItemChanged(object sender, EventArgs e)
		{
			proyectoOTFKBox.ProyectoPadre = proyectoPadreFKBox.SelectedItem;
		}

		private void GuardarButton_Click(object sender, EventArgs e)
		{
			GuardarCambios(true);
		}

		private void AgregarActividadButton_Click(object sender, EventArgs e)
		{
			if (ValidarDatosObligatoriosProyecto(true))
			{
				var seleccionoItem = ActividadSelector.Show(true);
				if (seleccionoItem)
				{
					var actividadCustom = ActividadSelector.SelectedItem;

					var actividad = RepositoryManager.GetRepository<ActividadRepository>()
						.GetEntity(actividadCustom.IdActividad);

					AgregarActividad(actividad);
				}
			}
		}

		private void CrearVersionDesdeActualButton_Click(object sender, EventArgs e)
		{
			var datosVersion = (List<DatosProyecto>)_datosProyectoGrilla1BindingSource.DataSource;
			CrearVersionProyecto(ProyectoVersionActual, datosVersion);

			//Seleccionar la ultima version del proyecto
			if (versionAnteriorComboBox.Items.Count > 0)
			{
				versionAnteriorComboBox.SelectedIndex = 0;
			}
		}

		private void ExpandirPanelVersionButton_Click(object sender, EventArgs e)
		{
			versionesSplitContainer.Panel2Collapsed = false;
			contraerPanelVersionButton.Enabled = true;
			expandirPanelVersionButton.Enabled = false;
		}

		private void EstadoVersionActualComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var estado = estadoVersionActualComboBox.SelectedItem as EstadoProyecto;
			if (estado != null)
			{
				probabilidadVersion1C1NumericEdit.Value = estado.ProbabilidadProbable;
			}
		}

		private void ProbabilidadVersion1C1NumericEdit_PostValidating(object sender, PostValidationEventArgs e)
		{
			if (e.Value is DBNull)
			{
				return;
			}

			var valor = (decimal)e.Value;
			if (valor < 0 || valor > 1)
			{
				e.Succeeded = false;
			}
		}

		private void ContraerPanelVersionButton_Click(object sender, EventArgs e)
		{
			versionesSplitContainer.Panel2Collapsed = true;
			contraerPanelVersionButton.Enabled = false;
			expandirPanelVersionButton.Enabled = true;
		}

		private void CrearVersionV2Button_Click(object sender, EventArgs e)
		{
			var datosVersion = (List<DatosProyecto>)_datosProyectoGrilla2BindingSource.DataSource;
			CrearVersionProyecto(ProyectoVersionAnterior, datosVersion);
		}

		private void IncrementarVersionAnteriorButton_Click(object sender, EventArgs e)
		{
			if (versionAnteriorComboBox.SelectedIndex > 0)
			{
				versionAnteriorComboBox.SelectedIndex--;
			}
		}

		private void DecrementarVersionAnteriorButton_Click(object sender, EventArgs e)
		{
			if (versionAnteriorComboBox.SelectedIndex < versionAnteriorComboBox.Items.Count - 1)
			{
				versionAnteriorComboBox.SelectedIndex++;
			}
		}

		private void VersionAnteriorComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var proyectoVersion = versionAnteriorComboBox.SelectedItem as ProyectoVersion;
			ProyectoVersionAnterior = proyectoVersion;

			if (versionAnteriorComboBox.Items.Count <= 1)
			{
				//sin items o uno solo
				incrementarVersionAnteriorButton.Enabled = false;
				decrementarVersionAnteriorButton.Enabled = false;
			}
			else if (versionAnteriorComboBox.SelectedIndex == 0)
			{
				//primer item
				incrementarVersionAnteriorButton.Enabled = false;
				decrementarVersionAnteriorButton.Enabled = true;
			}
			else if (versionAnteriorComboBox.SelectedIndex == versionAnteriorComboBox.Items.Count - 1)
			{
				//ultimo item
				incrementarVersionAnteriorButton.Enabled = true;
				decrementarVersionAnteriorButton.Enabled = false;
			}
			else
			{
				//item intermedio
				incrementarVersionAnteriorButton.Enabled = true;
				decrementarVersionAnteriorButton.Enabled = true;
			}

		}

		private void CrearProyectoButton_Click(object sender, EventArgs e)
		{
			CrearProyectoDesdeActual();
		}

		private void AsignacionPersonal1_CambioEnAsginaciones(object sender, EventArgs e)
		{
			HayCambios = true;
		}

		private void NombreProyectoTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			var nombreProyecto = nombreProyectoTextBox.Text;
			if (Proyecto.IdProyecto == 0 && !String.IsNullOrWhiteSpace(nombreProyecto))
			{
				//Validar nombre de proyecto unico
				var nombreRepetido = RepositoryManager.ObjectContext.ProyectoSet
					.Where(x => x.NombreProyecto.ToLower() == nombreProyecto.ToLower())
					.Any();

				if (nombreRepetido)
				{
					e.Cancel = true;
					MessageHelper.MostrarMensajeAtencion(String.Format("Ya existe otro proyecto con el nombre '{0}'.", nombreProyecto));
				}
			}
		}

		private void C1FlexGrid_OwnerDrawCell(object sender, OwnerDrawCellEventArgs e)
		{
			var grilla = (C1FlexGrid)sender;

			if (!grilla.IsCellValid(e.Row, e.Col) || e.Col < 1)
			{
				return;
			}

			var datoProyecto = grilla.Rows[e.Row].DataSource as DatosProyecto;
			if (datoProyecto != null)
			{
				if (!datoProyecto.EsFilaDato)
				{
					//Estilo de las filas Titulo
					e.Style = grilla.Styles.Fixed;
				}
				else
				{
					var nombreColumna = grilla.Cols[e.Col].Name;

					//Columna "EsCOPC"
					if (nombreColumna == _columnaEsCOPC.Name)
					{
						Image imagen = datoProyecto.EsCOPC == "1" ? _checkedImage : _uncheckedImage;
						var x = e.Bounds.X + (e.Bounds.Width / 2) - (imagen.Width / 2);
						e.Graphics.DrawImage(imagen, x, e.Bounds.Y);
						e.Handled = true;
					}
					else
					{
						if (grilla.IsCellSelected(e.Row, e.Col))
						{
							return;
						}

						if (grilla == version1C1FlexGrid && e.Col == _columnaDescripcionActividad.Index)
						{
							e.Style = grilla.Styles.Frozen;
						}
						else if (datoProyecto.EsFilaActiva && CeldaEsEditable(grilla, e.Row, e.Col))
						{
							e.Style = grilla.Styles.Frozen;
						}
						else if (!datoProyecto.EsFilaActiva || !FilaTieneTitulo(grilla, e.Row, e.Col))
						{
							var brush = new SolidBrush(Color.LightGray);
							e.Graphics.FillRectangle(brush, e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
							e.Handled = true;
						}
					}
				}
			}
		}

		private void VersionesSplitContainer_SplitterMoving(object sender, SplitterCancelEventArgs e)
		{
			if (e.SplitX < 270)
			{
				e.SplitX = 270;
			}
		}

		private void C1FlexGrid_AfterScroll(object sender, RangeEventArgs e)
		{
			SincronizarBarraScroll((C1FlexGrid)sender);
		}

		private void Version1C1FlexGrid_SetupEditor(object sender, RowColEventArgs e)
		{
			//Configurar editor al momento de entrar en edicion

			if (e.Col == _columnaHorasPorDia.SafeIndex ||
				e.Col == _columnaHorasCorreccion.SafeIndex ||
				e.Col == _columnaDias.SafeIndex ||
				e.Col == _columnaHorasTotales.SafeIndex ||
				e.Col == _columnaHorasEvento.SafeIndex ||
				e.Col == _columnaPorcentajeEvento.SafeIndex ||
				e.Col == _columnaDiasPorSemana.SafeIndex)
			{
				//Formato con 2 decimales
				var editor = version1C1FlexGrid.Editor as DecimalBox;

				if (editor != null)
				{
					editor.Format = DecimalBoxFormat.CustomFormat;
					editor.CustomFormat = Formatos.FormatoDecimal;
				}
			}
			else if (e.Col == _columnaCantidadParticipantes.SafeIndex ||
				e.Col == _columnaCantidadEventos.SafeIndex ||
				e.Col == _columnaHonorarios.SafeIndex ||
				e.Col == _columnaGastos.SafeIndex ||
				e.Col == _columnaPrecioBruto.SafeIndex ||
				e.Col == _columnaPrecioFinal.SafeIndex ||
				e.Col == _columnaRateFijo.SafeIndex ||
				e.Col == _columnaRateVariable.SafeIndex)
			{
				//Formato sin decimales
				var editor = version1C1FlexGrid.Editor as DecimalBox;

				if (editor != null)
				{
					editor.Format = DecimalBoxFormat.CustomFormat;
					editor.CustomFormat = Formatos.FormatoEntero;
				}
			}
			else if (e.Col == _columnaFactor.SafeIndex)
			{
				//Formato con 2 decimales
				var editor = version1C1FlexGrid.Editor as DecimalBox;

				if (editor != null)
				{
					editor.Format = DecimalBoxFormat.CustomFormat;
					editor.CustomFormat = Formatos.FormatoDecimalExtendido;
				}
			}
		}

		private void Version1C1FlexGrid_ValidateEdit(object sender, ValidateEditEventArgs e)
		{
			if (!version1C1FlexGrid.IsCellValid(e.Row, e.Col))
			{
				return;
			}

			if (e.Col != _columnaDescripcionActividad.SafeIndex)
			{
				//Colocar el valor modificado para que mantenga el formato
				var valor = version1C1FlexGrid.Editor.Text.ConvertirADecimal();
				if (valor.HasValue)
				{
					if (e.Col == _columnaHorasPorDia.SafeIndex ||
						e.Col == _columnaHorasCorreccion.SafeIndex ||
						e.Col == _columnaDias.SafeIndex ||
						e.Col == _columnaHorasTotales.SafeIndex ||
						e.Col == _columnaHorasEvento.SafeIndex ||
						e.Col == _columnaPorcentajeEvento.SafeIndex ||
						e.Col == _columnaDiasPorSemana.SafeIndex)
					{
						//Formato con 2 decimales
						version1C1FlexGrid.Editor.Text = valor.ConvertirAString();
					}
					else if (e.Col == _columnaCantidadParticipantes.SafeIndex ||
						e.Col == _columnaHonorarios.SafeIndex ||
						e.Col == _columnaGastos.SafeIndex ||
						e.Col == _columnaCantidadEventos.SafeIndex ||
						e.Col == _columnaPrecioBruto.SafeIndex ||
						e.Col == _columnaPrecioFinal.SafeIndex ||
						e.Col == _columnaRateFijo.SafeIndex ||
						e.Col == _columnaRateVariable.SafeIndex)
					{
						//Formato sin decimales
						version1C1FlexGrid.Editor.Text = valor.ConvertirAString(Formatos.FormatoEntero);
					}
					else if (e.Col == _columnaFactor.SafeIndex)
					{
						if(valor < 0 || valor >= 1)
						{
							MessageHelper.MostrarMensajeAlto("El valor debe ser mayor o igual a 0%, y menor a 100%.");
							e.Cancel = true;
							return;
						}

						//Formato con 4 decimales
						version1C1FlexGrid.Editor.Text = valor.ConvertirAString(Formatos.FormatoDecimalExtendido);
					}
				}
				else
				{
					version1C1FlexGrid.Editor.Text = string.Empty;
				}
			}

			if (!ReactivarFila(e.Row))
			{
				e.Cancel = true;
				return;
			}

			HayCambios = true;
		}

		private void EliminarActividadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var nroFila = version1C1FlexGrid.RowSel;
			EliminarActividad(nroFila);
		}

		private void Version1C1FlexGrid_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				//Si la celda esta seleccionada
				var hti = version1C1FlexGrid.HitTest(e.X, e.Y);
				if (version1C1FlexGrid.IsCellValid(hti.Row, 0))
				{
					var datosFila = (DatosProyecto)version1C1FlexGrid.Rows[hti.Row].DataSource;
					if (datosFila.EsFilaDato)
					{
						version1C1FlexGrid.Select(hti.Row, 0);
						//Abre el menu contextual
						contextMenuStrip.Show((Control)sender, e.X, e.Y);
					}
				}
			}
		}

		private void CerrarButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Version1C1FlexGrid_AfterEdit(object sender, RowColEventArgs e)
		{
			CalcularSumatoriasVersionActual();
		}

		private void Version1C1FlexGrid_StartEdit(object sender, RowColEventArgs e)
		{
			e.Cancel = !CeldaEsEditable((C1FlexGrid)sender, e.Row, e.Col);
		}

		private void Version1C1FlexGrid_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Delete)
			{
				return;
			}

			BorrarCeldaActual((C1FlexGrid)sender);
		}

		#endregion
	}

	internal class Rates
	{
		public ActividadRate RateFijo;
		public ActividadRate RateVariable;
	}
}
