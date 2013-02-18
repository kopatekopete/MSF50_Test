CREATE TABLE [dbo].[TipoProyecto] (
    [IdTipoProyecto]          INT          IDENTITY (1, 1) NOT NULL,
    [IdGrupoProyecto]         INT          NOT NULL,
    [DescripcionTipoProyecto] VARCHAR (50) NOT NULL
);

