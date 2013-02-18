ALTER TABLE [dbo].[ProyectoVersionActividad]
    ADD CONSTRAINT [DF_ProyectoVersionActividad_IdProyectoVersionActividad] DEFAULT (newsequentialid()) FOR [IdProyectoVersionActividad];

