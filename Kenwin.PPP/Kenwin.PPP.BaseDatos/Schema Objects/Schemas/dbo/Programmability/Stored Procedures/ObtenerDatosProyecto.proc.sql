CREATE PROCEDURE [dbo].[ObtenerDatosProyecto]
	@IdProyecto INT,
	@NroVersion INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Tabla temporal para almacenar los datos finales
	DECLARE @Tabla TABLE
	(
		EsFilaDato BIT NOT NULL, 

		IdTipoActividad INT NOT NULL,
		IdProyectoActividad UNIQUEIDENTIFIER,
		IdActividad INT,
		OrdenActividad INT,
		Descripcion VARCHAR(50),
		
		IdProyectoVersionActividad UNIQUEIDENTIFIER, 
		
		IdUnidadMedida INT,
		IdTipoCalculo INT, 
		EsCOPC VARCHAR(50), 
		HorasPorDia VARCHAR(50), 
		HorasCorreccion VARCHAR(50), 
		Dato1 VARCHAR(50), ValorOriginalDato1 AS (CASE WHEN EsFilaDato = 1 THEN Dato1 ELSE NULL END),
		Dato2 VARCHAR(50), ValorOriginalDato2 AS (CASE WHEN EsFilaDato = 1 THEN Dato2 ELSE NULL END),
		Dato3 VARCHAR(50), ValorOriginalDato3 AS (CASE WHEN EsFilaDato = 1 THEN Dato3 ELSE NULL END),
		Dato4 VARCHAR(50), ValorOriginalDato4 AS (CASE WHEN EsFilaDato = 1 THEN Dato4 ELSE NULL END),
		Dato5 VARCHAR(50), ValorOriginalDato5 AS (CASE WHEN EsFilaDato = 1 THEN Dato5 ELSE NULL END),
		Dato6 VARCHAR(50), ValorOriginalDato6 AS (CASE WHEN EsFilaDato = 1 THEN Dato6 ELSE NULL END),
		Dato7 VARCHAR(50), ValorOriginalDato7 AS (CASE WHEN EsFilaDato = 1 THEN Dato7 ELSE NULL END),
		Dato8 VARCHAR(50), ValorOriginalDato8 AS (CASE WHEN EsFilaDato = 1 THEN Dato8 ELSE NULL END),
		Dato9 VARCHAR(50), ValorOriginalDato9 AS (CASE WHEN EsFilaDato = 1 THEN Dato9 ELSE NULL END),
		Dato10 VARCHAR(50), ValorOriginalDato10 AS (CASE WHEN EsFilaDato = 1 THEN Dato10 ELSE NULL END),
		Dato11 VARCHAR(50), ValorOriginalDato11 AS (CASE WHEN EsFilaDato = 1 THEN Dato11 ELSE NULL END)
	);

	--Obtener los titulos de cada TipoActividad
	WITH Titulos (IdTipoActividad, Descripcion, Dato1, Dato2, Dato3, Dato4, Dato5, Dato6, Dato7, Dato8, Dato9)
	AS (
		SELECT ad.IdTipoActividad,
			ta.DescripcionTipoActividad Descripcion,
			CASE WHEN ad.OrdenColumna = 1 THEN ad.LabelColumna END d1, 
			CASE WHEN ad.OrdenColumna = 2 THEN ad.LabelColumna END d2, 
			CASE WHEN ad.OrdenColumna = 3 THEN ad.LabelColumna END d3, 
			CASE WHEN ad.OrdenColumna = 4 THEN ad.LabelColumna END d4, 
			CASE WHEN ad.OrdenColumna = 5 THEN ad.LabelColumna END d5, 
			CASE WHEN ad.OrdenColumna = 6 THEN ad.LabelColumna END d6, 
			CASE WHEN ad.OrdenColumna = 7 THEN ad.LabelColumna END d7, 
			CASE WHEN ad.OrdenColumna = 8 THEN ad.LabelColumna END d8, 
			CASE WHEN ad.OrdenColumna = 9 THEN ad.LabelColumna END d9
		FROM TipoActividad ta
		INNER JOIN TipoActividadDato ad ON ad.IdTipoActividad = ta.IdTipoActividad
	)
	INSERT INTO @Tabla (EsFilaDato, IdTipoActividad, Descripcion, EsCOPC, HorasPorDia, HorasCorreccion, Dato1, Dato2, Dato3, Dato4, Dato5, Dato6, Dato7, Dato8, Dato9)
		SELECT 0, IdTipoActividad, Descripcion, 'COPC', 'HorasPorDia', 'HorasCorreccion', MIN(Dato1) Dato1, MIN(Dato2) Dato2, MIN(Dato3) Dato3, MIN(Dato4) Dato4, MIN(Dato5) Dato5, 
			MIN(Dato6) Dato6, MIN(Dato7) Dato7, MIN(Dato8) Dato8, MIN(Dato9) Dato9
	FROM Titulos
	GROUP BY IdTipoActividad, Descripcion;

	--Obtener los datos de las actividades
	WITH Datos ( IdTipoActividad, IdProyectoActividad, IdActividad, OrdenActividad, Descripcion, IdProyectoVersionActividad,
		IdUnidadMedida, IdTipoCalculo, EsCOPC, HorasPorDia, HorasCorreccion,
			Dato1, Dato2, Dato3, Dato4, Dato5, Dato6, Dato7, Dato8, Dato9, Dato10, Dato11
		)
	AS (

		SELECT a.IdTipoActividad, pa.IdProyectoActividad, pa.IdActividad, pa.NroOrden, pa.DescripcionReal Descripcion, pva.IdProyectoVersionActividad,
			a.IdUnidadMedida, a.IdTipoCalculo, pa.EsCOPC, pva.HorasPorDia, pva.HorasCorreccion,
			pva.Dato1, pva.Dato2, pva.Dato3, pva.Dato4, pva.Dato5, pva.Dato6, pva.Dato7, pva.Dato8, pva.Dato9, pva.Dato10, pva.Dato11
		FROM ProyectoActividad pa
		INNER JOIN Actividad a ON a.IdActividad = pa.IdActividad
		LEFT JOIN ProyectoVersion pv ON pv.IdProyecto = @IdProyecto AND pv.[Version] = @NroVersion
		LEFT JOIN ProyectoVersionActividad pva ON pva.IdProyectoVersion = pv.IdProyectoVersion AND pva.IdProyectoActividad = pa.IdProyectoActividad
		WHERE pa.IdProyecto = @IdProyecto
	)
	INSERT INTO @Tabla (EsfilaDato, IdTipoActividad, IdProyectoActividad, IdActividad, OrdenActividad, Descripcion, IdProyectoVersionActividad, IdUnidadMedida,
		IdTipoCalculo, EsCOPC, HorasPorDia, HorasCorreccion,
		Dato1, Dato2, Dato3, Dato4, Dato5, Dato6, Dato7, Dato8, Dato9, Dato10, Dato11)
	SELECT 1 EsfilaDato, IdTipoActividad, IdProyectoActividad, IdActividad, OrdenActividad, Descripcion, IdProyectoVersionActividad, IdUnidadMedida,
		IdTipoCalculo, EsCOPC, HorasPorDia, HorasCorreccion,
		Dato1, Dato2, Dato3, Dato4, Dato5, Dato6,  Dato7, Dato8, Dato9, Dato10, Dato11
	FROM Datos
	ORDER BY IdTipoActividad, OrdenActividad

	SELECT * FROM @Tabla ORDER BY IdTipoActividad, esfilaDato 
END