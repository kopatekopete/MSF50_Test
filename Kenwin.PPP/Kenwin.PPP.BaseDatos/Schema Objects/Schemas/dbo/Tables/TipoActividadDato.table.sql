CREATE TABLE [dbo].[TipoActividadDato] (
    [IdTipoActividadDato] INT             IDENTITY (1, 1) NOT NULL,
    [IdTipoActividad]     INT             NOT NULL,
    [OrdenColumna]        INT             NOT NULL,
    [LabelColumna]        VARCHAR (50)    NOT NULL,
    [EsEditable]          BIT             NOT NULL,
    [ValorDefault]        NUMERIC (10, 2) NULL
);



