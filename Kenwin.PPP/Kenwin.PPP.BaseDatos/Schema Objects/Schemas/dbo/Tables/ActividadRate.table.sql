CREATE TABLE [dbo].[ActividadRate] (
    [IdActividadRate] INT             IDENTITY (1, 1) NOT NULL,
    [IdActividad]     INT             NOT NULL,
    [IdMoneda]        INT             NOT NULL,
    [IdCliente]       INT             NOT NULL,
    [Rate]            NUMERIC (10, 2) NULL
);

