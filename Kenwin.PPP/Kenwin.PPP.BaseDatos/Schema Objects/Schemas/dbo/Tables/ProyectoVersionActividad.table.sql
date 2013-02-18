CREATE TABLE [dbo].[ProyectoVersionActividad] (
    [IdProyectoVersionActividad] UNIQUEIDENTIFIER NOT NULL,
    [IdProyectoVersion]          INT              NOT NULL,
    [IdProyectoActividad]        UNIQUEIDENTIFIER NOT NULL,
    [HorasPorDia]                NUMERIC (10, 2)  NULL,
    [HorasCorreccion]            NUMERIC (10, 2)  NULL,
    [Dias]                       NUMERIC (10, 2)  NULL,
    [Cantidad]                   NUMERIC (10, 2)  NULL,
    [Dato3]                      NUMERIC (10, 2)  NULL,
    [HorasTotales]               NUMERIC (10, 2)  NULL,
    [HorasEvento]                NUMERIC (10, 2)  NULL,
    [PorcentajeEvento]           NUMERIC (10, 2)  NULL,
    [Gastos]                     NUMERIC (10, 2)  NULL,
    [PrecioBruto]                NUMERIC (10, 2)  NULL,
    [PrecioFinal]                NUMERIC (10, 2)  NULL,
    [Dato10]                     NUMERIC (10, 2)  NULL,
    [Dato11]                     NUMERIC (10, 2)  NULL
);





