using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Kenwin.PPP.Cliente.Comun.Formularios;
using Kenwin.PPP.Negocio.Entidades;
using Kenwin.PPP.Negocio.Modelo;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Kenwin.PPP.Cliente.Comun;
using Kenwin.PPP.Negocio.Repositorios;
using C1.Win.C1FlexGrid;

namespace Kenwin.PPP.Cliente.ABMs
{
	public partial class Prueba : PPPFormBase
	{
		private Column _colDescripcionTipoActividad;
		private Column _colDescripcionActividad;
		private Column _colDescripcionReal;
		private Column _colNroOrden;
		private Column _colIdProyectoActividad;
		private Column _colNroOrden2;

		public Prueba()
		{
			InitializeComponent();

			ConfigurarGrilla();
		}

		private void ConfigurarGrilla()
		{
			grilla.DataSource = _bs;

			grilla.AllowDragging = AllowDraggingEnum.None;
			grilla.AllowResizing = AllowResizingEnum.None;
			grilla.AllowSorting = AllowSortingEnum.None;
			grilla.AutoGenerateColumns = false;
			grilla.AutoResize = false;

			grilla.Styles[CellStyleEnum.Subtotal0].BackColor = Color.BurlyWood;
			grilla.Styles[CellStyleEnum.Subtotal1].BackColor = Color.IndianRed;

			_colDescripcionTipoActividad = grilla.Cols.Add();
			_colDescripcionTipoActividad.Name = "DescripcionTipoActividad";
			_colDescripcionTipoActividad.Visible = false;

			_colIdProyectoActividad = grilla.Cols.Add();
			_colIdProyectoActividad.Name = "IdProyectoActividad";
			_colIdProyectoActividad.Visible = false;
	
			_colDescripcionActividad = grilla.Cols.Add();
			_colDescripcionActividad.Name = "DescripcionActividad";
			_colDescripcionActividad.Visible = false;

			_colDescripcionReal = grilla.Cols.Add();
			_colDescripcionReal.Name = "DescripcionPersona";
			_colDescripcionReal.AllowEditing = false;
			_colDescripcionReal.AllowDragging = false;
			_colDescripcionReal.AllowSorting = false;
			_colDescripcionReal.AllowResizing = false;
			_colDescripcionReal.Caption = "Descripcion";
			_colDescripcionReal.DataType = typeof(string);

			_colNroOrden = grilla.Cols.Add();
			_colNroOrden.Name = "NroOrden";
			_colNroOrden.AllowDragging = false;
			_colNroOrden.AllowSorting = false;
			_colNroOrden.AllowResizing = false;
			_colNroOrden.Caption = "Total";
			_colNroOrden.DataType = typeof(int);

			_colNroOrden2 = grilla.Cols.Add();
			_colNroOrden2.Name = "NroOrden2";
			_colNroOrden2.AllowDragging = false;
			_colNroOrden2.AllowSorting = false;
			_colNroOrden2.AllowResizing = false;
			_colNroOrden2.Caption = "Total2";
			_colNroOrden2.DataType = typeof(int);
		}

		private void getDataButton_Click(object sender, EventArgs e)
		{
			ObtenerDatos(12);
		}

		private void ObtenerDatos(int idProyecto)
		{
			try
			{
				var data = RepositoryFactory.GetManager().ObjectContext;

				var lista = (
					from pac in data.ProyectoActividadSet
					where pac.IdProyecto == idProyecto
					join a in data.ActividadSet on pac.IdActividad equals a.IdActividad
					//join p in data.PersonaSet on 1 equals 1
					//join pas in data.ProyectoAsignacionSet on pac.IdProyecto equals pas.IdProyecto
					//join pasa in data.ProyectoAsignacionActividadSet on pac.IdProyecto equals pasa.IdProyectoAsignacion
					 select new Clasesita
					 {
						 DescripcionTipoActividad = a.TipoActividad.DescripcionTipoActividad,
						 DescripcionActividad = a.DescripcionActividad,
						 IdProyectoActividad = pac.IdProyectoActividad,
						 //DescripcionPersona = p.Alias,
						 DescripcionPersona = String.Empty,
						 OrdenTipoActividad = a.TipoActividad.OrdenTipoActividad,
						 OrdenActividad = pac.NroOrden,

					 }
					)
					.OrderBy(x => x.OrdenTipoActividad)
					.ThenBy(x => x.OrdenActividad)
					.ToList();

				_bs.DataSource = lista;
			}
			catch (Exception ex)
			{
				ExceptionPolicy.HandleException(ex, Constantes.ElErrorPolicy);
			}
		}

		private void grilla_AfterDataRefresh(object sender, ListChangedEventArgs e)
		{
			try
			{
				grilla.Redraw = false;

				//Si la lista cambio (sucede cuando se refresca la lista de datos)
				if (e.ListChangedType != ListChangedType.Reset && e.ListChangedType != ListChangedType.ItemChanged)
				{
					return;
				}

				if (grilla.Cols.Count < 1 || grilla.Rows.Count < 1)
				{
					return;
				}

				//Limpiar totales anteriores
				grilla.Subtotal(AggregateEnum.Clear);

				//Indice de la columna donde se muestra el arbol (el simbolo +)
				grilla.Tree.Column = _colDescripcionReal.SafeIndex;

				//Crear un nivel (0) con la suma, usando la columna de DescripcionTipoActividad para detectar grupos
				grilla.Subtotal(AggregateEnum.Sum,								//Calcular una suma
								0,												//Nro de nivel de agregacion que se va a crear
								_colDescripcionTipoActividad.SafeIndex,			//Columna que se usa para detectar los agrupamientos
								_colNroOrden.SafeIndex,							//Indice de la columna de la cual calcular el total
								"{0}");											//Titulo de la columna de agrupamiento

				//Crear un nivel (1) con la suma, usando la columna de DescripcionActividad para detectar grupos
				grilla.Subtotal(AggregateEnum.Sum,								//Calcular una suma
								1,												//Nro de nivel de agregacion que se va a crear
								_colIdProyectoActividad.SafeIndex,				//Columna que se usa para detectar los agrupamientos
								_colDescripcionActividad.SafeIndex,
								_colNroOrden.SafeIndex,							//Indice de la columna de la cual calcular el total
								"{0}");											//Titulo de la columna de agrupamiento

				//Crear un nivel (0) con la suma, usando la columna de DescripcionTipoActividad para detectar grupos
				grilla.Subtotal(AggregateEnum.Sum,								//Calcular una suma
								0,												//Nro de nivel de agregacion que se va a crear
								_colDescripcionTipoActividad.SafeIndex,			//Columna que se usa para detectar los agrupamientos
								_colNroOrden2.SafeIndex,							//Indice de la columna de la cual calcular el total
								"{0}");											//Titulo de la columna de agrupamiento

				//Crear un nivel (1) con la suma, usando la columna de DescripcionActividad para detectar grupos
				grilla.Subtotal(AggregateEnum.Sum,								//Calcular una suma
								1,												//Nro de nivel de agregacion que se va a crear
								_colIdProyectoActividad.SafeIndex,				//Columna que se usa para detectar los agrupamientos
								_colDescripcionActividad.SafeIndex,
								_colNroOrden2.SafeIndex,							//Indice de la columna de la cual calcular el total
								"{0}");											//Titulo de la columna de agrupamiento


				/*
				 * grilla.Subtotal(AggregateEnum.Sum,								//Calcular una suma
								1,												//Nro de nivel de agregacion que se va a crear
								_colIdProyectoActividad.SafeIndex,				//Columna que se usa para detectar los agrupamientos
								_colNroOrden.SafeIndex,							//Indice de la columna de la cual calcular el total
								"{0}");											//Titulo de la columna de agrupamiento
				*/
				//Reajustar las columnas segun los datos
				grilla.AutoSizeCols(1, 1, grilla.Rows.Count - 1, grilla.Cols.Count - 1, 30, AutoSizeFlags.IgnoreHidden);
			}
			catch (Exception ex)
			{
				ExceptionPolicy.HandleException(ex, Constantes.ElErrorPolicy);
			}
			finally
			{
				grilla.Redraw = true;
			}
		}

		//No permitir editar si la celda es de las filas de los subtotales
		private void grilla_StartEdit(object sender, RowColEventArgs e)
		{
			var estiloFila = grilla.Rows[e.Row].Style;

			if (estiloFila == null)
			{
				return;
			}

			var estiloSubtotal0 = grilla.Styles[CellStyleEnum.Subtotal0];
			var estiloSubtotal1 = grilla.Styles[CellStyleEnum.Subtotal1];

			if (estiloFila.Name == estiloSubtotal0.Name || estiloFila.Name == estiloSubtotal1.Name)
			{
				e.Cancel = true;
			}
		}

		//Es necesario definir una clase para que funcione correctamente la edicion en la grilla
		private class Clasesita
		{
			public int OrdenActividad;
			public string DescripcionTipoActividad { get; set; }
			public string DescripcionActividad { get; set; }
			public string DescripcionPersona { get; set; }
			public int NroOrden { get; set; }
			public int NroOrden2 { get; set; }
			public int OrdenTipoActividad { get; set; }

			public Guid IdProyectoActividad { get; set; }
		}

		private void grilla_OwnerDrawCell(object sender, OwnerDrawCellEventArgs e)
		{
			var datoFila = grilla.Rows[e.Row].DataSource as Clasesita;
			if(datoFila != null)
			{
				if (string.IsNullOrWhiteSpace(datoFila.DescripcionPersona))
				{
					/*e.Graphics.FillRectangle(Brushes.Green, e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
					
					e.Text = "aASDAS";*/

					//e.Handled = true;
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				var actividadesProyecto = RepositoryManager.GetRepository<ProyectoRepository>().ObtenerDatosProyectoVersion(12, 14);

				asignacionSemanal1.ActividadesProyecto = actividadesProyecto;
			}
			catch (Exception ex)
			{
				ExceptionPolicy.HandleException(ex, Constantes.ElErrorPolicy);
			}

			
		}
	}
}
