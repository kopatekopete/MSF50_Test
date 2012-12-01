ALTER TABLE [dbo].[ProyectoVersionActividad]
    ADD CONSTRAINT [FK_ProyectoVersionActividad_ProyectoActividad] FOREIGN KEY ([IdProyectoActividad]) REFERENCES [dbo].[ProyectoActividad] ([IdProyectoActividad]) ON DELETE NO ACTION ON UPDATE NO ACTION;

