CREATE TABLE [dbo].[ProyectoVersionDocumento] (
    [IdProyectoVersionDocumento] INT          IDENTITY (1, 1) NOT NULL,
    [IdProyectoVersion]          INT          NOT NULL,
    [DescripcionDocumento]       VARCHAR (50) NULL,
    [PathDocumento]              VARCHAR (50) NULL
);

