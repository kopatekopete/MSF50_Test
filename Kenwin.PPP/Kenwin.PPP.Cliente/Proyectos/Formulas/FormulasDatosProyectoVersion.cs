using System.Collections.Generic;
using Kenwin.PPP.Cliente.Comun.Calculations;
using Kenwin.PPP.Negocio.Comun;
using Kenwin.PPP.Negocio.Modelo;

namespace Kenwin.PPP.Cliente.Proyectos.Formulas
{
	/// <summary>
	/// Define las formulas para los datos de un proyecto y permite aplicarlas.
	/// </summary>
	public class FormulasDatosProyectoVersion
	{
		private CalculationManager<DatosProyecto> _calcManagerComun;

		private CalculationManager<DatosProyecto> _calcManagerHsTotales1;
		private CalculationManager<DatosProyecto> _calcManagerHsTotales2;
		private CalculationManager<DatosProyecto> _calcManagerHsTotales3;
		private CalculationManager<DatosProyecto> _calcManagerHsTotales4;
		private CalculationManager<DatosProyecto> _calcManagerHsTotales5;

		private CalculationManager<DatosProyecto> _calcManagerPrecioBruto1;
		private CalculationManager<DatosProyecto> _calcManagerPrecioBruto2;
		private CalculationManager<DatosProyecto> _calcManagerPrecioBruto3;
		private CalculationManager<DatosProyecto> _calcManagerPrecioBruto4;

		public FormulasDatosProyectoVersion()
		{
			DefinirFormulas();
		}

		/// <summary>
		/// Asocia las formulas correspondientes a cada item de la lista
		/// </summary>
		/// <param name="datosProyectoVersion"></param>
		public void Aplicar(List<DatosProyecto> datosProyectoVersion)
		{
			_calcManagerComun.ApplyToAll(datosProyectoVersion);
			_calcManagerComun.AfterFormulaExecution += CalcManager_AfterFormulaExecution;

			//Calculo de horas
			_calcManagerHsTotales1.ApplyToAll(datosProyectoVersion, x => x.TipoCalculoHoras == 1);
			_calcManagerHsTotales1.AfterFormulaExecution += CalcManager_AfterFormulaExecution;

			_calcManagerHsTotales2.ApplyToAll(datosProyectoVersion, x => x.TipoCalculoHoras == 2);
			_calcManagerHsTotales2.AfterFormulaExecution += CalcManager_AfterFormulaExecution;

			_calcManagerHsTotales3.ApplyToAll(datosProyectoVersion, x => x.TipoCalculoHoras == 3);
			_calcManagerHsTotales3.AfterFormulaExecution += CalcManager_AfterFormulaExecution;

			_calcManagerHsTotales4.ApplyToAll(datosProyectoVersion, x => x.TipoCalculoHoras == 4);
			_calcManagerHsTotales4.AfterFormulaExecution += CalcManager_AfterFormulaExecution;

			_calcManagerHsTotales5.ApplyToAll(datosProyectoVersion, x => x.TipoCalculoHoras == 5);
			_calcManagerHsTotales5.AfterFormulaExecution += CalcManager_AfterFormulaExecution;

			//Calculo de precio
			_calcManagerPrecioBruto1.ApplyToAll(datosProyectoVersion, x => x.TipoCalculoPrecio == 1);
			_calcManagerPrecioBruto1.AfterFormulaExecution += CalcManager_AfterFormulaExecution;

			_calcManagerPrecioBruto2.ApplyToAll(datosProyectoVersion, x => x.TipoCalculoPrecio == 2);
			_calcManagerPrecioBruto2.AfterFormulaExecution += CalcManager_AfterFormulaExecution;

			_calcManagerPrecioBruto3.ApplyToAll(datosProyectoVersion, x => x.TipoCalculoPrecio == 3);
			_calcManagerPrecioBruto3.AfterFormulaExecution += CalcManager_AfterFormulaExecution;

			_calcManagerPrecioBruto4.ApplyToAll(datosProyectoVersion, x => x.TipoCalculoPrecio == 4);
			_calcManagerPrecioBruto4.AfterFormulaExecution += CalcManager_AfterFormulaExecution;
		}

		private static void CalcManager_AfterFormulaExecution(object sender, FormulaExecutionEventArgs<DatosProyecto> e)
		{
			//Cuando cambia PrecioBruto, copia el valor a precio final
			if (e.ColumnName == "PrecioBruto")
			{
				e.ObjectSource.PrecioFinal = (string)e.NewValue;
			}
		}

		/// <summary>
		/// Comprueba de que el item posea una formula asociada en su columna.
		/// </summary>
		/// <param name="itemDatoProyecto"></param>
		/// <param name="nombreColumna"></param>
		/// <returns></returns>
		public bool TieneFormula(DatosProyecto itemDatoProyecto, string nombreColumna)
		{
			bool tieneFormula = _calcManagerComun.HasFormula(nombreColumna);

			if (!tieneFormula)
			{
				switch (itemDatoProyecto.TipoCalculoHoras)
				{
					case 1:
						tieneFormula = _calcManagerHsTotales1.HasFormula(nombreColumna);
						break;
					case 2:
						tieneFormula = _calcManagerHsTotales2.HasFormula(nombreColumna);
						break;
					case 3:
						tieneFormula = _calcManagerHsTotales3.HasFormula(nombreColumna);
						break;
					case 4:
						tieneFormula = _calcManagerHsTotales4.HasFormula(nombreColumna);
						break;
					case 5:
						tieneFormula = _calcManagerHsTotales5.HasFormula(nombreColumna);
						break;
				}
			}

			if (!tieneFormula)
			{
				switch (itemDatoProyecto.TipoCalculoPrecio)
				{
					case 1:
						tieneFormula = _calcManagerPrecioBruto1.HasFormula(nombreColumna);
						break;
					case 2:
						tieneFormula = _calcManagerPrecioBruto2.HasFormula(nombreColumna);
						break;
					case 3:
						tieneFormula = _calcManagerPrecioBruto3.HasFormula(nombreColumna);
						break;
					case 4:
						tieneFormula = _calcManagerPrecioBruto4.HasFormula(nombreColumna);
						break;
				}
			}
			return tieneFormula;

		}

		/// <summary>
		/// Asocia las formulas correspondientes al item
		/// </summary>
		public void Aplicar(DatosProyecto itemDatoProyecto, bool ejecutarConstantes)
		{
			//aplica los calculos comunes
			_calcManagerComun.ApplyToItem(itemDatoProyecto, ejecutarConstantes);

			//aplica los calculos especificos del tipo de calculo de horas
			switch (itemDatoProyecto.TipoCalculoHoras)
			{
				case 1:
					_calcManagerHsTotales1.ApplyToItem(itemDatoProyecto, ejecutarConstantes);
					break;
				case 2:
					_calcManagerHsTotales2.ApplyToItem(itemDatoProyecto, ejecutarConstantes);
					break;
				case 3:
					_calcManagerHsTotales3.ApplyToItem(itemDatoProyecto, ejecutarConstantes);
					break;
				case 4:
					_calcManagerHsTotales4.ApplyToItem(itemDatoProyecto, ejecutarConstantes);
					break;
				case 5:
					_calcManagerHsTotales5.ApplyToItem(itemDatoProyecto, ejecutarConstantes);
					break;
			}

			//aplica los calculos especificos del tipo de calculo de precio
			switch (itemDatoProyecto.TipoCalculoPrecio)
			{
				case 1:
					_calcManagerPrecioBruto1.ApplyToItem(itemDatoProyecto, ejecutarConstantes);
					break;
				case 2:
					_calcManagerPrecioBruto2.ApplyToItem(itemDatoProyecto, ejecutarConstantes);
					break;
				case 3:
					_calcManagerPrecioBruto3.ApplyToItem(itemDatoProyecto, ejecutarConstantes);
					break;
				case 4:
					_calcManagerPrecioBruto4.ApplyToItem(itemDatoProyecto, ejecutarConstantes);
					break;
			}

		}

		private void DefinirFormulas()
		{
			#region Calculos comunes

			_calcManagerComun = CalculationManager<DatosProyecto>.Create();
			_calcManagerComun.AfterFormulaExecution += CalcManager_AfterFormulaExecution;

			//Cant Dias = Horas Totales / Horas x Día
			_calcManagerComun.DefineFormula(x => x.Dias, x => (x.HorasTotales.ConvertirADecimal(0) / x.HorasPorDia.ConvertirADecimal()).ConvertirAString());
			// %Evento = 1 / Cant Eventos
			_calcManagerComun.DefineFormula(x => x.PorcentajeEvento, x => (1 / x.CantidadEventos.ConvertirADecimal()).ConvertirAString(Formatos.FormatoPorcentajeConDecimales));

			// Horas/Evento = Horas Totales / Cant Eventos
			_calcManagerComun.DefineFormula(x => x.HorasEvento, x => (x.HorasTotales.ConvertirADecimal(0) / x.CantidadEventos.ConvertirADecimal()).ConvertirAString());

			//El Precio Bruto = Honorarios / (1-Factor o Tasa) + Gastos
			_calcManagerComun.DefineFormula(x => x.PrecioBruto, x => ((x.Honorarios.ConvertirADecimal(0) / (1 - x.Factor.ConvertirADecimal(0))) + x.Gastos.ConvertirADecimal(0)).ConvertirAString(Formatos.FormatoEntero));

			#endregion

			#region Calculos de Hs

			#region Calculo de Hs - Tipo 1

			_calcManagerHsTotales1 = CalculationManager<DatosProyecto>.Create()
				//Horas Totales = Cant Cursos * (Dias de la semana *  Horas x Dia + Cant Participantes * Horas x Correccion)					
				.DefineFormula(x => x.HorasTotales,
					x => (x.CantidadEventos.ConvertirADecimal(0) * (x.DiasPorSemana.ConvertirADecimal(0) * x.HorasPorDia.ConvertirADecimal(0) + x.CantidadParticipantes.ConvertirADecimal(0) * x.HorasCorreccion.ConvertirADecimal(0))).ConvertirAString());
			_calcManagerHsTotales1.AfterFormulaExecution += CalcManager_AfterFormulaExecution;
			#endregion

			#region Calculo de Hs - Tipo 2

			//TODO: Unificar con HsTotales1 (+ HorasAdicionales)
			_calcManagerHsTotales2 = CalculationManager<DatosProyecto>.Create()
				//Horas Totales = Cant Talleres * (Dias de la semana *  Horas x Dia + Cant a corregir * Horas x Corrección) + Horas de customizado
				.DefineFormula(x => x.HorasTotales,
					x => ((x.CantidadEventos.ConvertirADecimal(0) * (x.DiasPorSemana.ConvertirADecimal(0) * x.HorasPorDia.ConvertirADecimal(0) + x.CantidadParticipantes.ConvertirADecimal(0) * x.HorasCorreccion.ConvertirADecimal(0)))
								+ x.HorasAdicionales.ConvertirADecimal(0)).ConvertirAString());
			_calcManagerHsTotales2.AfterFormulaExecution += CalcManager_AfterFormulaExecution;
			#endregion

			#region Calculo de Hs - Tipo 3
			_calcManagerHsTotales3 = CalculationManager<DatosProyecto>.Create()
				//Horas Totales = Cant Eventos * Horas x Evento
				.DefineFormula(x => x.HorasTotales, x => (x.CantidadEventos.ConvertirADecimal(0) * x.HorasEventoIngresado.ConvertirADecimal(0)).ConvertirAString());
			_calcManagerHsTotales3.AfterFormulaExecution += CalcManager_AfterFormulaExecution;
			#endregion

			#region Calculo de Hs - Tipo 4
			_calcManagerHsTotales4 = CalculationManager<DatosProyecto>.Create()
				//Horas Totales= Cant Eventos*(DiasPorSemana * Horas x Dia +Cant participantes* Hs Corrección)					
				.DefineFormula(x => x.HorasTotales,
					x => (x.CantidadEventos.ConvertirADecimal(0)
						* (x.DiasPorSemana.ConvertirADecimal(0) * x.HorasPorDia.ConvertirADecimal(0) + x.CantidadParticipantes.ConvertirADecimal(0) * x.HorasCorreccion.ConvertirADecimal(0))).ConvertirAString());

			_calcManagerHsTotales4.AfterFormulaExecution += CalcManager_AfterFormulaExecution;
			#endregion

			#region Calculo de Hs - Tipo 5

			_calcManagerHsTotales5 = CalculationManager<DatosProyecto>.Create();
			//HoralTotales = HorasPorEventoIngresado
			_calcManagerHsTotales5.DefineFormula(x => x.HorasTotales, x => x.HorasEventoIngresado.ConvertirADecimal(0).ConvertirAString());

			_calcManagerHsTotales5.AfterFormulaExecution += CalcManager_AfterFormulaExecution;
			#endregion

			#endregion

			#region Calculos de Honorarios

			#region Calculo de Honorarios - Tipo 1

			_calcManagerPrecioBruto1 = CalculationManager<DatosProyecto>.Create()
				//Honorarios = Rate Fijo
				.DefineFormula(x => x.Honorarios, x => (x.RateFijo.ConvertirADecimal(0)).ConvertirAString(Formatos.FormatoEntero));

			_calcManagerPrecioBruto1.AfterFormulaExecution += CalcManager_AfterFormulaExecution;

			#endregion

			#region Calculo de Honorarios - Tipo 2

			_calcManagerPrecioBruto2 = CalculationManager<DatosProyecto>.Create()
				// Honorarios = ( Rate Fijo + Rate Variable* Cant. Personas adicionales )* Cant Cursos
				.DefineFormula(x => x.Honorarios,
					x => ((x.RateFijo.ConvertirADecimal(0) + (x.RateVariable.ConvertirADecimal(0) * CalcularParticipantesAdicionales(x.CantidadTopeRateFijo.ConvertirADecimal(0), x.CantidadParticipantes.ConvertirADecimal(0)))
							) * x.CantidadEventos.ConvertirADecimal(0)
						).ConvertirAString(Formatos.FormatoEntero));

			_calcManagerPrecioBruto2.AfterFormulaExecution += CalcManager_AfterFormulaExecution;
			#endregion

			#region Calculo de Honorarios - Tipo 3
			_calcManagerPrecioBruto3 = CalculationManager<DatosProyecto>.Create()
				//Honorarios = (Horas Totales * RateVariable)
				.DefineFormula(x => x.Honorarios, x => (x.HorasTotales.ConvertirADecimal(0) * x.RateVariable.ConvertirADecimal(0)).ConvertirAString(Formatos.FormatoEntero));

			_calcManagerPrecioBruto3.AfterFormulaExecution += CalcManager_AfterFormulaExecution;
			#endregion

			#region Calculo de Honorarios - Tipo 4
			_calcManagerPrecioBruto4 = CalculationManager<DatosProyecto>.Create()
				//Honorarios = (Cant Participantes * Precio x Participante* Cant Eventos)
				.DefineFormula(x => x.Honorarios,
					x => (x.CantidadParticipantes.ConvertirADecimal(0) * x.RateVariable.ConvertirADecimal(0) * x.CantidadEventos.ConvertirADecimal(0)).ConvertirAString(Formatos.FormatoEntero));

			_calcManagerPrecioBruto4.AfterFormulaExecution += CalcManager_AfterFormulaExecution;
			#endregion


			#endregion
		}

		private static decimal CalcularParticipantesAdicionales(decimal topeRateFijo, decimal participantes)
		{
			var participantesAdicionales = participantes - topeRateFijo;

			if (participantesAdicionales < 0)
			{
				return 0;
			}

			return participantesAdicionales;
		}
	}
}
