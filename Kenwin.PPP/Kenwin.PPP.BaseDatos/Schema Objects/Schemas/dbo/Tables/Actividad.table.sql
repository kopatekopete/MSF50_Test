CREATE TABLE [dbo].[Actividad] (
    [IdActividad]          INT            IDENTITY (1, 1) NOT NULL,
    [DescripcionActividad] VARCHAR (50)   NOT NULL,
    [IdTipoActividad]      INT            NOT NULL,
    [Orden]                INT            NOT NULL,
    [IdTipoCalculo]        INT            NOT NULL,
    [IdUnidadMedida]       INT            NOT NULL,
    [EsCOPC]               BIT            NOT NULL,
    [HorasPorDia]          NUMERIC (6, 2) NULL,
    [HorasCorreccion]      NUMERIC (6, 2) NULL
);



