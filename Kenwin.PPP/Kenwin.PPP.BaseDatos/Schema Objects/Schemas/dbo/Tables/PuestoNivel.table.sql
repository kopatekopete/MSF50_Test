CREATE TABLE [dbo].[PuestoNivel] (
    [IdPuestoNivel]          INT          IDENTITY (1, 1) NOT NULL,
    [IdPuesto]               INT          NOT NULL,
    [Orden]                  INT          NOT NULL,
    [DescripcionPuestoNivel] VARCHAR (50) NOT NULL
);

