CREATE TABLE [dbo].[Persona] (
    [IdPersona]        INT          IDENTITY (1, 1) NOT NULL,
    [Nombre]           VARCHAR (50) NOT NULL,
    [Apellido]         VARCHAR (50) NOT NULL,
    [Alias]            CHAR (6)     NULL,
    [Activo]           BIT          NULL,
    [IdPaisResidencia] INT          NOT NULL,
    [Email]            VARCHAR (60) NULL
);

