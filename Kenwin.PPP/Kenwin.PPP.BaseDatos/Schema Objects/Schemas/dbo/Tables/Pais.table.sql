CREATE TABLE [dbo].[Pais] (
    [IdPais]          INT          IDENTITY (1, 1) NOT NULL,
    [DescripcionPais] VARCHAR (50) NOT NULL,
    [IdIdioma]        INT          NOT NULL,
    [Sigla]           CHAR (3)     NULL
);

