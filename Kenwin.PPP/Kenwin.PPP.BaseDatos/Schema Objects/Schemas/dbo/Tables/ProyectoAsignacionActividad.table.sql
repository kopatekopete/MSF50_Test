CREATE TABLE [dbo].[ProyectoAsignacionActividad] (
    [IdProyectoAsignacionActividad] INT              IDENTITY (1, 1) NOT NULL,
    [IdProyectoAsignacion]          INT              NOT NULL,
    [IdProyectoVersionActividad]    UNIQUEIDENTIFIER NOT NULL,
    [FechaInicioSemana]             INT              NOT NULL,
    [CantDias]                      INT              NOT NULL
);





