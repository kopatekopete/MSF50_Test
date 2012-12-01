ALTER TABLE [dbo].[ProyectoActividad]
    ADD CONSTRAINT [DF_ProyectoActividad_IdProyectoActividad] DEFAULT (newsequentialid()) FOR [IdProyectoActividad];

