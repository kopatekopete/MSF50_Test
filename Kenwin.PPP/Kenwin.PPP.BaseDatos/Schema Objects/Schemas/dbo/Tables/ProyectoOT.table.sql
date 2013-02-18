CREATE TABLE [dbo].[ProyectoOT] (
    [IdProyectoOt]    INT          IDENTITY (1, 1) NOT NULL,
    [IdProyectoPadre] INT          NOT NULL,
    [Ot]              VARCHAR (50) NOT NULL
);

