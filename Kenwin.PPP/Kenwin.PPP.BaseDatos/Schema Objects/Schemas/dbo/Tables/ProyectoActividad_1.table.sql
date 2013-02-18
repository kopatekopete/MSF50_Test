CREATE TABLE [dbo].[ProyectoActividad] (
    [IdProyectoActividad] UNIQUEIDENTIFIER NOT NULL,
    [IdProyecto]          INT              NOT NULL,
    [IdActividad]         INT              NOT NULL,
    [DescripcionReal]     VARCHAR (50)     NOT NULL,
    [NroOrden]            INT              NOT NULL,
    [EsCOPC]              BIT              NOT NULL
);

