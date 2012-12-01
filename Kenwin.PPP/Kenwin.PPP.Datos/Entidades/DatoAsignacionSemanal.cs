using System;
using System.Collections.Generic;
using System.Linq;
using Kenwin.PPP.Negocio.Comun;
using Kenwin.PPP.Negocio.Comun.Excepciones;
using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Data.EF;

namespace Kenwin.PPP.Negocio.Entidades
{
	public class DatoAsignacionSemanal
	{
		private readonly DatosProyecto _actividadProyecto;

		private ProyectoAsignacionActividad _datosAsignacion;
		private readonly List<ProyectoAsignacionActividadPeriodo> _datosAsignacionSemanas = new List<ProyectoAsignacionActividadPeriodo>();

		public string TipoActividadDescripcion { get; set; }


		public DatoAsignacionSemanal(DatosProyecto actividadProyecto)
		{
			_actividadProyecto = actividadProyecto;
		}


		public Guid? IdProyectoActividad
		{
			get { return _actividadProyecto.IdProyectoActividad; }
		}

		public string ProyectoActividadDescripcion
		{
			get { return _actividadProyecto.Descripcion; }
		}

		public int? IdProyectoAsignacion { get; set; }
		public string PersonaAsignacionAlias { get; set; }

		private DateTime _fechaInicioSemanaA;
		public DateTime FechaInicio
		{
			get
			{
				return _fechaInicioSemanaA;
			}
			set
			{
				if (value.DayOfWeek != DayOfWeek.Monday)
				{
					throw new PPPNegocioException("La fecha de inicio debe ser un Lunes");
				}

				_fechaInicioSemanaA = value;

				_datoSemanaA = _datosAsignacionSemanas.Where(x => x.InicioSemana == value).FirstOrDefault();
				_datoSemanaB = _datosAsignacionSemanas.Where(x => x.InicioSemana == value.AddDays(7)).FirstOrDefault();
				_datoSemanaC = _datosAsignacionSemanas.Where(x => x.InicioSemana == value.AddDays(7 * 2)).FirstOrDefault();
				_datoSemanaD = _datosAsignacionSemanas.Where(x => x.InicioSemana == value.AddDays(7 * 3)).FirstOrDefault();
				_datoSemanaE = _datosAsignacionSemanas.Where(x => x.InicioSemana == value.AddDays(7 * 4)).FirstOrDefault();
				_datoSemanaF = _datosAsignacionSemanas.Where(x => x.InicioSemana == value.AddDays(7 * 5)).FirstOrDefault();
				_datoSemanaG = _datosAsignacionSemanas.Where(x => x.InicioSemana == value.AddDays(7 * 6)).FirstOrDefault();
				_datoSemanaH = _datosAsignacionSemanas.Where(x => x.InicioSemana == value.AddDays(7 * 7)).FirstOrDefault();

			}
		}

		public int OrdenActividad { get; set; }
		public int OrdenTipoActividad { get; set; }

		#region Datos Semanas

		private ProyectoAsignacionActividadPeriodo _datoSemanaA;
		public decimal? DiasPorSemanaA
		{
			get
			{
				if (_datoSemanaA== null)
				{
					return null;
				}
				return _datoSemanaA.CantDias;
			}
			set
			{
				_datoSemanaA = AsignarValorSemana(_datoSemanaA, value, FechaInicio);
			}
		}

		private ProyectoAsignacionActividadPeriodo _datoSemanaB;
		public decimal? DiasPorSemanaB
		{
			get
			{
				if (_datoSemanaB == null)
				{
					return null;
				}
				return _datoSemanaB.CantDias;
			}
			set
			{
				_datoSemanaB = AsignarValorSemana(_datoSemanaB, value, FechaInicio.AddDays(7));
			}
		}
		private ProyectoAsignacionActividadPeriodo _datoSemanaC;
		public decimal? DiasPorSemanaC
		{
			get
			{
				if (_datoSemanaC == null)
				{
					return null;
				}
				return _datoSemanaC.CantDias;
			}
			set
			{
				_datoSemanaC = AsignarValorSemana(_datoSemanaC, value, FechaInicio.AddDays(7*2));
			}
		}

		private ProyectoAsignacionActividadPeriodo _datoSemanaD;
		public decimal? DiasPorSemanaD
		{
			get
			{
				if (_datoSemanaD == null)
				{
					return null;
				}
				return _datoSemanaD.CantDias;
			}
			set
			{
				_datoSemanaD = AsignarValorSemana(_datoSemanaD, value, FechaInicio.AddDays(7 * 3));
			}
		}

		private ProyectoAsignacionActividadPeriodo _datoSemanaE;
		public decimal? DiasPorSemanaE
		{
			get
			{
				if (_datoSemanaE == null)
				{
					return null;
				}
				return _datoSemanaE.CantDias;
			}
			set
			{
				_datoSemanaE = AsignarValorSemana(_datoSemanaE, value, FechaInicio.AddDays(7 * 4));
			}
		}

		private ProyectoAsignacionActividadPeriodo _datoSemanaF;
		public decimal? DiasPorSemanaF
		{
			get
			{
				if (_datoSemanaF == null)
				{
					return null;
				}
				return _datoSemanaF.CantDias;
			}
			set
			{
				_datoSemanaF = AsignarValorSemana(_datoSemanaF, value, FechaInicio.AddDays(7 * 5));
			}
		}

		private ProyectoAsignacionActividadPeriodo _datoSemanaG;
		public decimal? DiasPorSemanaG
		{
			get
			{
				if (_datoSemanaG == null)
				{
					return null;
				}
				return _datoSemanaG.CantDias;
			}
			set
			{
				_datoSemanaG = AsignarValorSemana(_datoSemanaG, value, FechaInicio.AddDays(7 * 6));
			}
		}

		private ProyectoAsignacionActividadPeriodo _datoSemanaH;
		public decimal? DiasPorSemanaH
		{
			get
			{
				if (_datoSemanaH == null)
				{
					return null;
				}
				return _datoSemanaH.CantDias;
			}
			set
			{
				_datoSemanaH = AsignarValorSemana(_datoSemanaH, value, FechaInicio.AddDays(7 * 7));
			}
		}
		#endregion


		private ProyectoAsignacionActividadPeriodo AsignarValorSemana(ProyectoAsignacionActividadPeriodo datoSemana, decimal? value, DateTime fechaInicioSemana)
		{
			if (datoSemana != null)
			{
				//Existe un valor previo...
				if (!value.HasValue || value == 0)
				{
					//...y el valor es vacio: Se borra el dato
					BorrarDato(datoSemana);
					return null;
				}
			}
			else
			{
				//No existe un valor previo...
				if (!value.HasValue || value == 0)
				{
					//...y el valor es vacio: No se hace nada
					return null;
				}
				//Crear item nuevo y agregarlo a la lista
				datoSemana = new ProyectoAsignacionActividadPeriodo {InicioSemana = fechaInicioSemana};
				_datosAsignacionSemanas.Add(datoSemana);
			}

			datoSemana.CantDias = value.Value;

			return datoSemana;
		}

		private void BorrarDato(ProyectoAsignacionActividadPeriodo datoSemana)
		{
			_datosAsignacionSemanas.Remove(datoSemana);
		}

		public decimal DiasPresupuestados
		{
			get
			{
				var valor = _actividadProyecto.Dias.ConvertirADecimal(0m);
				return valor;
			}
		}

		public decimal? DiasPrevistos { get; set; }

		public decimal DiasAsignados
		{
			get
			{
				var sumaDiasAsignados = _datosAsignacionSemanas
					.Sum(x => (decimal?)x.CantDias) ?? 0;

				return sumaDiasAsignados;
			}
		}

		public static List<DatoAsignacionSemanal> CrearDesdeListaTareas(RepositoryManager<PPPObjectContext> repositoryManager, List<DatosProyecto> tareasProyecto, DateTime fechaInicio)
		{
			var data = repositoryManager.ObjectContext;

			var lista = tareasProyecto
				.Where(x => x.EsFilaDato)
				.Where(x => x.EsFilaActiva)
				.Select(x => new DatoAsignacionSemanal(x)
				{
					OrdenTipoActividad = data.TipoActividadSet.Where(y => y.IdTipoActividad == x.IdTipoActividad).First().OrdenTipoActividad,
					OrdenActividad = x.OrdenActividad,
					TipoActividadDescripcion = data.TipoActividadSet.Where(y => y.IdTipoActividad == x.IdTipoActividad).First().DescripcionTipoActividad,
					FechaInicio = fechaInicio,
					IdProyectoAsignacion = null,
					PersonaAsignacionAlias = "(Sin asignar)",
				})
				.ToList();

			return lista;
		}
	}
}
