CREATE TABLE [dbo].[ProyectoAsignacion] (
    [IdProyectoAsignacion]  INT            IDENTITY (1, 1) NOT NULL,
    [IdProyecto]            INT            NOT NULL,
    [IdPersona]             INT            NOT NULL,
    [IdRol]                 INT            NOT NULL,
    [PorcentajeRendimiento] NUMERIC (6, 2) NULL
);

