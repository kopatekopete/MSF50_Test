CREATE TABLE [dbo].[EstadoProyecto] (
    [IdEstadoProyecto]          INT            IDENTITY (1, 1) NOT NULL,
    [DescripcionEstadoProyecto] VARCHAR (50)   NOT NULL,
    [Orden]                     INT            NOT NULL,
    [ProbabilidadProbable]      NUMERIC (6, 2) NULL,
    [ProbabilidadMinima]        NUMERIC (6, 2) NULL
);



