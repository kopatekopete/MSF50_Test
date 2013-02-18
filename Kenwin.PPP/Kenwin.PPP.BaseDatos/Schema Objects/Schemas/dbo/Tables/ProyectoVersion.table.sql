CREATE TABLE [dbo].[ProyectoVersion] (
    [IdProyectoVersion]   INT          IDENTITY (1, 1) NOT NULL,
    [IdProyecto]          INT          NOT NULL,
    [Version]             INT          NOT NULL,
    [FechaVersion]        DATETIME     NOT NULL,
    [IdEstadoProyecto]    INT          NOT NULL,
    [FechaInicioProyecto] DATETIME     NULL,
    [Entidad]             VARCHAR (50) NULL,
    [Probabilidad]        INT          NULL,
    [Cerrada]             BIT          NOT NULL
);



