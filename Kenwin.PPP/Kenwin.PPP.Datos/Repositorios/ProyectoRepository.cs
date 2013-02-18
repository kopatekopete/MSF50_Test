using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Kenwin.PPP.Negocio.Comun;
using Kenwin.PPP.Negocio.Comun.Excepciones;
using Kenwin.PPP.Negocio.Entidades;
using Kenwin.PPP.Negocio.Entidades.Filtros;
using Kenwin.PPP.Negocio.Modelo;
using Vemn.Fwk.Data.EF;

namespace Kenwin.PPP.Negocio.Repositorios
{
	public class ProyectoRepository : BaseRepository<PPPObjectContext, Proyecto>
	{
		public ProyectoRepository(RepositoryManager<PPPObjectContext> repositoryManager)
			: base(repositoryManager)
		{

		}

		public IQueryable<Proyecto> ProyectoSet
		{
			get { return RepositoryManager.ObjectContext.ProyectoSet; }
		}

		/// <summary>
		/// Obtiene datos generales de los proyectos que coincidan con el filtro.
		/// </summary>
		/// <param name="filtro"></param>
		/// <returns></returns>
		public List<ResumenProyecto> ObtenerResumenesProyecto(FiltroResumenProyecto filtro, string ordenamiento)
		{
			var resumenesQuery = ObjectContext.ProyectoSet
				.Where(x => !x.EsTemplate)
				.Select(p => new
				{
					Proyecto = p,
					UltimaVersion = p.ProyectoVersionSet.OrderByDescending(x => x.Version).FirstOrDefault(),
				})
				.Select(x => new ResumenProyecto
						{
							OrdenTrabajoCodigo = x.Proyecto.ProyectoOT.Ot,
							MonedaDescripcion = x.Proyecto.Moneda.CodigoMoneda,
							ClienteDescripcion = x.Proyecto.Cliente.RazonSocial,
							AvancePorcentaje = 0, //TODO: Calcular
							DiasDisponibles = 0, //TODO: Calcular
							IdEstado = x.UltimaVersion.EstadoProyecto.IdEstadoProyecto,
							EstadoDescripcion = x.UltimaVersion.EstadoProyecto.DescripcionEstadoProyecto,
							IdPais = x.Proyecto.Pais.IdPais,
							PaisDescripcion = x.Proyecto.Pais.DescripcionPais,
							IdProyecto = x.Proyecto.IdProyecto,
							PrecioFinal = x.UltimaVersion.ProyectoVersionActividad.Sum(a => a.PrecioFinal) ?? 0,
							ProductividadPorcentaje = 0,//TODO: Calcular
							//TotalCOPC: Suma de los precios finales para las actividades que sean COPC
							TotalCOPC = x.UltimaVersion.ProyectoVersionActividad.Where(a => a.ProyectoActividad.EsCOPC).Sum(a => a.PrecioFinal) ?? 0,
							//TotalNoCOPC: Suma de los precios finales para las actividades que no sean COPC
							TotalNoCOPC = x.UltimaVersion.ProyectoVersionActividad.Where(a => !a.ProyectoActividad.EsCOPC).Sum(a => a.PrecioFinal) ?? 0,
							FechaInicio = x.UltimaVersion.FechaInicioProyecto,
							UltimaActualizacion = x.UltimaVersion.FechaVersion,
							IdUnidadNegocio = x.Proyecto.UnidadNegocio.IdUnidadNegocio,
							UnidadNegocioDescripcion = x.Proyecto.UnidadNegocio.DescripcionUnidadNegocio,
							UsuarioCreadorSiglas = x.Proyecto.Creador.Alias,
							UsuarioLiderSiglas = String.Empty, //TODO: Calcular
							IdProyectoPadre = x.Proyecto.ProyectoOT.ProyectoPadre.IdProyectoPadre,
							NombreProyectoPadre = x.Proyecto.ProyectoOT.ProyectoPadre.NombreProyectoPadre,
							NombreProyecto = x.Proyecto.NombreProyecto,
							Probabilidad = x.UltimaVersion.Probabilidad
						});

			#region Aplicar Filtros

			if (filtro != null)
			{
				//IdPais
				if (filtro.IdPais != null)
				{
					resumenesQuery = resumenesQuery.Where(x => x.IdPais == filtro.IdPais);
				}

				//Fecha Anterior a
				if (filtro.FechaInicioAnteriorA != null)
				{
					var fecha = filtro.FechaInicioAnteriorA.Value;
					resumenesQuery = resumenesQuery.Where(x => x.FechaInicio <= fecha);
				}

				//IdUnidadNegocio
				if (filtro.IdUnidadNegocio != null)
				{
					resumenesQuery = resumenesQuery.Where(x => x.IdUnidadNegocio == filtro.IdUnidadNegocio);
				}

				//Estado
				if (filtro.ListaIdEstados.Count > 0)
				{
					resumenesQuery = resumenesQuery.WhereIn(x => x.IdEstado ?? 0, filtro.ListaIdEstados);
				}

				//Cliente
				if (!String.IsNullOrWhiteSpace(filtro.ClienteDescripcion))
				{
					resumenesQuery = resumenesQuery.Where(x => x.ClienteDescripcion.ToUpper().Contains(filtro.ClienteDescripcion));
				}

				//Codigo OT
				if (!String.IsNullOrWhiteSpace(filtro.CodigoOT))
				{
					resumenesQuery = resumenesQuery.Where(x => x.OrdenTrabajoCodigo.ToUpper().Contains(filtro.CodigoOT));
				}

				//Nombre Proyecto Padre
				if (!String.IsNullOrWhiteSpace(filtro.NombreProyectoPadre))
				{
					resumenesQuery = resumenesQuery.Where(x => x.NombreProyectoPadre.ToUpper().Contains(filtro.NombreProyectoPadre));
				}

				//Nombre Proyecto
				if (!String.IsNullOrWhiteSpace(filtro.NombreProyecto))
				{
					resumenesQuery = resumenesQuery.Where(x => x.NombreProyecto.ToUpper().Contains(filtro.NombreProyecto));
				}
			}

			#endregion

			var listaProyectos = resumenesQuery
				.OrderBy(ordenamiento)
				.ToList();

			return listaProyectos;
		}

		/// <summary>
		/// Obtiene la lista de templates
		/// </summary>
		/// <returns></returns>
		public List<ResumenProyecto> ObtenerProyectosTemplate()
		{
			var objectContext = RepositoryManager.ObjectContext;

			var listaTemplates = objectContext.ProyectoSet
				.Where(x => x.EsTemplate)
				.Select(p => new
				{
					Proyecto = p,
					UltimaVersion = p.ProyectoVersionSet.OrderByDescending(x => x.Version).FirstOrDefault()
				})
				.Select(x => new ResumenProyecto
				{
					OrdenTrabajoCodigo = x.Proyecto.ProyectoOT.Ot,
					MonedaDescripcion = x.Proyecto.Moneda.CodigoMoneda,
					ClienteDescripcion = x.Proyecto.Cliente.RazonSocial,
					AvancePorcentaje = 0, //No aplica
					DiasDisponibles = 0, //No aplica
					IdEstado = x.UltimaVersion.EstadoProyecto.IdEstadoProyecto,
					EstadoDescripcion = x.UltimaVersion.EstadoProyecto.DescripcionEstadoProyecto,
					IdPais = x.Proyecto.Pais.IdPais,
					PaisDescripcion = x.Proyecto.Pais.DescripcionPais,
					IdProyecto = x.Proyecto.IdProyecto,
					PrecioFinal = 0,//No aplica
					ProductividadPorcentaje = 0,//No aplica
					TotalCOPC = 0,//No aplica
					TotalNoCOPC = 0,//No aplica
					FechaInicio = x.UltimaVersion.FechaInicioProyecto,
					UltimaActualizacion = x.UltimaVersion.FechaVersion,
					IdUnidadNegocio = x.Proyecto.UnidadNegocio.IdUnidadNegocio,
					UnidadNegocioDescripcion = x.Proyecto.UnidadNegocio.DescripcionUnidadNegocio,
					UsuarioCreadorSiglas = x.Proyecto.Creador.Alias,
					UsuarioLiderSiglas = String.Empty, //TODO: Calcular
					IdProyectoPadre = x.Proyecto.ProyectoOT.ProyectoPadre.IdProyectoPadre,
					NombreProyectoPadre = x.Proyecto.ProyectoOT.ProyectoPadre.NombreProyectoPadre,
					NombreProyecto = x.Proyecto.NombreProyecto,
					Probabilidad = x.UltimaVersion.Probabilidad
				})
				.ToList();

			return listaTemplates;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="idProyecto"></param>
		/// <param name="nroVersion"></param>
		/// <returns></returns>
		public List<DatosProyecto> ObtenerDatosProyectoVersion(int idProyecto, int nroVersion)
		{
			var datosProyectos = ObjectContext.ObtenerDatosProyecto(idProyecto, nroVersion)
				.ToList();

			return datosProyectos;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="idProyecto"></param>
		/// <returns></returns>
		public ProyectoVersion ObtenerUltimaVersion(int idProyecto)
		{
			var ultimaVersion = RepositoryManager.ObjectContext
				.ProyectoVersionSet
				.Where(x => x.IdProyecto == idProyecto)
				.OrderByDescending(x => x.Version)
				.FirstOrDefault();

			return ultimaVersion;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="idProyecto"></param>
		/// <returns></returns>
		public Proyecto ObtenerProyecto(int idProyecto)
		{
			var proyecto = RepositoryManager.ObjectContext
				.ProyectoSet
				.Where(x => x.IdProyecto == idProyecto)
				.FirstOrDefault();

			return proyecto;
		}

		/// <summary>
		/// Elimina el idProyectoActividadDato, y si es el unico para la Actividad, tambien el ProyectoActividadRelacionado.
		/// </summary>
		/// <param name="idProyectoVersionActividad"></param>
		public bool EliminarProyectoVersionActividad(Guid idProyectoVersionActividad)
		{
			var proyectoVersionActividad = ObjectContext.ProyectoVersionActividadSet
				.Where(x => x.IdProyectoVersionActividad == idProyectoVersionActividad)
				.FirstOrDefault();

			if (proyectoVersionActividad == null)
			{
				//TODO: Cambiar a NegocioException
				throw new Exception();
			}

			var proyectoActividad = proyectoVersionActividad.ProyectoActividad;

			ObjectContext.DeleteObject(proyectoVersionActividad);

			//Si no otros hay datos para el ProyectoVersion, entonces se elimina.
			bool proyectoActividadEliminado = false;
			if (!proyectoActividad.ProyectoVersionActividad.Any())
			{
				ObjectContext.DeleteObject(proyectoActividad);
				proyectoActividadEliminado = true;
			}

			ObjectContext.SaveChanges();

			return proyectoActividadEliminado;
		}

		/// <summary>
		/// Comprueba si existe o no un proyecto con el nombre indicado.
		/// </summary>
		/// <param name="nombreProyecto"></param>
		/// <returns></returns>
		public bool ExisteProyecto(string nombreProyecto)
		{
			var existeProyecto = ObjectContext.ProyectoSet
				.Where(x => x.NombreProyecto.ToUpper() == nombreProyecto.ToUpper())
				.Any();

			return existeProyecto;
		}

		public void GuardarProyectoCompleto(Proyecto proyecto, ProyectoVersion proyectoVersion, List<DatosProyecto> datosProyecto)
		{
			if (proyecto.EntityState == EntityState.Added)
			{
				//Validar nombre de proyecto unico
				var nombreRepetido = ObjectContext.ProyectoSet
					.Where(x => x.NombreProyecto.ToLower() == proyecto.NombreProyecto.ToLower())
					.Any();

				if(nombreRepetido)
				{
					throw new PPPNegocioException("Ya existe otro proyecto con el nombre '{0}'.", proyecto.NombreProyecto);
				}
			}
			
			var listaProyectosVersionActividad = new List<ProyectoVersionActividad>();
			//Si el proyecto es nuevo, lo agrega
			if (proyectoVersion.EntityState == EntityState.Added)
			{
				ObjectContext.AddToProyectoVersionSet(proyectoVersion);
			}
			else
			{
				//Obtiene todos los datos de las actividad de la version a guardar
				listaProyectosVersionActividad = ObjectContext
					.ProyectoVersionActividadSet
					.Where(x => x.IdProyectoVersion == proyectoVersion.IdProyectoVersion)
					.ToList();
			}

			if (datosProyecto != null)
			{
				var listaDatos = datosProyecto
					.Where(x => x.EsFilaDato)
					.ToList();

				foreach (var datoVersion in listaDatos)
				{
					//Si la fila no esta activa
					if (!datoVersion.EsFilaActiva)
					{
						#region Eliminar fila

						//Si la actividad tiene datos guardados para la version actual, es que el usuario quiere eliminar los datos
						if (datoVersion.IdProyectoActividad.HasValue && datoVersion.IdProyectoVersionActividad.HasValue)
						{
							//Eliminar ProyectoVersionActividad actual y, si es posible, el ProyectoActividad
							RepositoryManager.GetRepository<ProyectoRepository>()
								.EliminarProyectoVersionActividad(datoVersion.IdProyectoVersionActividad.Value);
						}

						#endregion
					}
					else
					{
						ProyectoVersionActividad proyectoVersionActividad;

						Guid idProyectoActividad;
						if (datoVersion.IdProyectoActividad.HasValue)
						{
							#region Obtener actividad existente en otra version

							idProyectoActividad = datoVersion.IdProyectoActividad.Value;

							//Obtiene la actividad del proyecto
							DatosProyecto version = datoVersion;
							var proyectoActividad = ObjectContext.ProyectoActividadSet
								.Where(x => x.IdProyectoActividad == version.IdProyectoActividad)
								.First();

							//actualiza la descripcion
							proyectoActividad.DescripcionReal = datoVersion.Descripcion;

							#endregion
						}
						else
						{
							#region Nueva actividad para el proyecto

							//Creo un nuevo UniqueIdentifier para el ProyectoActividad
							idProyectoActividad = Guid.NewGuid();

							//Actualizar los datos con el nuevo Id
							datoVersion.IdProyectoActividad = idProyectoActividad;

							var proyectoActividad = new ProyectoActividad
							{
								IdProyectoActividad = idProyectoActividad,
								IdActividad = datoVersion.IdActividad.Value,
								IdProyecto = proyecto.IdProyecto,
								DescripcionReal = datoVersion.Descripcion,
								EsCOPC = datoVersion.EsCOPC == "1",
								NroOrden = datoVersion.OrdenActividad
							};

							ObjectContext.AddToProyectoActividadSet(proyectoActividad);

							#endregion
						}

						if (datoVersion.IdProyectoVersionActividad.HasValue)
						{
							//Obtener ProyectoVersionActividad
							var idProyectoVersionActividad = datoVersion.IdProyectoVersionActividad.Value;

							proyectoVersionActividad = listaProyectosVersionActividad
								.First(x => x.IdProyectoVersionActividad == idProyectoVersionActividad);
						}
						else
						{

							var idProyectoVersionActividad = Guid.NewGuid();

							//Actualizar los datos con el nuevo Id
							datoVersion.IdProyectoVersionActividad = idProyectoVersionActividad;

							//Crear actividad para la version
							proyectoVersionActividad = new ProyectoVersionActividad
							{
								IdProyectoVersionActividad = idProyectoVersionActividad,
								IdProyectoActividad = idProyectoActividad,
							};

							proyectoVersion.ProyectoVersionActividad.Add(proyectoVersionActividad);
						}

						#region Datos ProyectoVersionActividad

						proyectoVersionActividad.HorasPorDia = datoVersion.HorasPorDia.ConvertirADecimal();
						proyectoVersionActividad.HorasCorreccion = datoVersion.HorasCorreccion.ConvertirADecimal();

						proyectoVersionActividad.Dias = datoVersion.Dias.ConvertirADecimal();
						proyectoVersionActividad.CantidadEventos = datoVersion.CantidadEventos.ConvertirADecimal();
						proyectoVersionActividad.CantidadParticipantes = datoVersion.CantidadParticipantes.ConvertirADecimal();
						proyectoVersionActividad.HorasEventoIngresado = datoVersion.HorasEventoIngresado.ConvertirADecimal();
						proyectoVersionActividad.HorasAdicionales = datoVersion.HorasAdicionales.ConvertirADecimal();
						proyectoVersionActividad.HorasTotales = datoVersion.HorasTotales.ConvertirADecimal();
						proyectoVersionActividad.HorasEvento = datoVersion.HorasEvento.ConvertirADecimal();
						proyectoVersionActividad.PorcentajeEvento = datoVersion.PorcentajeEvento.ConvertirADecimal();
						proyectoVersionActividad.Honorarios = datoVersion.Honorarios.ConvertirADecimal();
						proyectoVersionActividad.Gastos = datoVersion.Gastos.ConvertirADecimal();
						proyectoVersionActividad.PrecioBruto = datoVersion.PrecioBruto.ConvertirADecimal();
						proyectoVersionActividad.PrecioFinal = datoVersion.PrecioFinal.ConvertirADecimal();
						proyectoVersionActividad.RateFijo = datoVersion.RateFijo.ConvertirADecimal();
						proyectoVersionActividad.RateVariable = datoVersion.RateVariable.ConvertirADecimal();
						proyectoVersionActividad.DiasPorSemana = datoVersion.DiasPorSemana.ConvertirADecimal();
						proyectoVersionActividad.Factor = datoVersion.Factor.ConvertirADecimal();

						proyectoVersionActividad.CantidadTopeRateFijo = datoVersion.CantidadTopeRateFijo.ConvertirADecimal();
						proyectoVersionActividad.CantidadTopeRateVariable = datoVersion.CantidadTopeRateVariable.ConvertirADecimal();

						#endregion
					}
				}
			}

			ObjectContext.SaveChanges();
		}
	}
}
