CREATE TABLE [dbo].[Proyecto] (
    [IdProyecto]        INT          IDENTITY (1, 1) NOT NULL,
    [IdProyectoOt]      INT          NOT NULL,
    [NombreProyecto]    VARCHAR (50) NOT NULL,
    [IdCliente]         INT          NOT NULL,
    [IdPais]            INT          NOT NULL,
    [IdUnidadNegocio]   INT          NOT NULL,
    [IdTipoEmpresa]     INT          NOT NULL,
    [IdTipoProyecto]    INT          NOT NULL,
    [ContactoComercial] VARCHAR (50) NOT NULL,
    [LiderEnCliente]    VARCHAR (50) NOT NULL,
    [IdMoneda]          INT          NOT NULL,
    [EsTemplate]        BIT          NOT NULL,
    [Observaciones]     VARCHAR (50) NOT NULL,
    [IdPersonaCreador]  INT          NOT NULL
);





