
CREATE PROCEDURE CrearVersionProyecto
	@IdProyecto INT,
	@NroProyecto INT,
	@CrearComoTemplate BIT = 0
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @TablaIdProyectoVersion TABLE
	(
		idProyectoVersion INT
	)

	DECLARE @IdProyectoVersionOriginal INT
	DECLARE @IdProyectoVersionNuevo INT


	BEGIN TRY
		BEGIN TRANSACTION

		-- Cerrar la version original del proyecto
		UPDATE ProyectoVersion
			SET Cerrada = 1
			OUTPUT INSERTED.IdProyectoVersion INTO @TablaIdProyectoVersion
		WHERE IdProyecto = @IdProyecto AND Version = @NroProyecto

		-- Obtener obtener el ID de la version original
		SELECT @IdProyectoVersionOriginal = IdProyectoVersion FROM @TablaIdProyectoVersion
		DELETE @TablaIdProyectoVersion
		
		
		IF @IdProyectoVersionOriginal IS NULL
		BEGIN
			--TODO: Arrojar exception
			RAISERROR(1,1,2,2)
		END
			
		-- Crear la nueva version
		INSERT INTO [ProyectoVersion]
				([IdProyecto]
				,[Version]
				,[FechaVersion]
				,[IdEstadoProyecto]
				,[FechaInicioProyecto]
				,[Entidad]
				,[Probabilidad]
				,[Cerrada])
			OUTPUT INSERTED.IdProyectoVersion INTO @TablaIdProyectoVersion
			SELECT [IdProyecto]
				,(SELECT MAX(Version) + 1 FROM ProyectoVersion WHERE IdProyecto = @IdProyecto)
				,CONVERT(DATETIME, CONVERT(VARCHAR, GETDATE(), 103))
				,[IdEstadoProyecto]
				,[FechaInicioProyecto]
				,[Entidad]
				,[Probabilidad]
				,0 --Cerrada
			FROM [ProyectoVersion]
			WHERE [IdProyectoVersion] = @IdProyectoVersionOriginal

		-- Obtener obtener el ID de la nueva version
		SELECT @IdProyectoVersionNuevo = IdProyectoVersion FROM @TablaIdProyectoVersion
		DELETE @TablaIdProyectoVersion

		--Copiar los datos de la version
		INSERT INTO [ProyectoVersionActividad]
			   ([IdProyectoVersion]
			   ,[IdProyectoActividad]
			   ,[HorasPorDia]
			   ,[HorasCorreccion]
			   ,[Dato1]
			   ,[Dato2]
			   ,[Dato3]
			   ,[Dato4]
			   ,[Dato5]
			   ,[Dato6]
			   ,[Dato7]
			   ,[Dato8]
			   ,[Dato9]
			   ,[Dato10]
			   ,[Dato11])
		 SELECT @IdProyectoVersionNuevo
				  ,[IdProyectoActividad]
				  ,[HorasPorDia]
				  ,[HorasCorreccion]
				  ,[Dato1]
				  ,[Dato2]
				  ,[Dato3]
				  ,[Dato4]
				  ,[Dato5]
				  ,[Dato6]
				  ,[Dato7]
				  ,[Dato8]
				  ,[Dato9]
				  ,[Dato10]
				  ,[Dato11]
			  FROM [ProyectoVersionActividad]
			  WHERE [IdProyectoVersion] = @IdProyectoVersionOriginal

		COMMIT TRANSACTION
	
	END TRY
	BEGIN CATCH
	
		ROLLBACK TRANSACTION
	
		--TODO: Arrojar exception
		
	END CATCH
END