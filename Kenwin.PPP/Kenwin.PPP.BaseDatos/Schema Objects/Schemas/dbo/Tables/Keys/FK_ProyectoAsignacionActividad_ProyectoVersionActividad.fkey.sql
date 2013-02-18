ALTER TABLE [dbo].[ProyectoAsignacionActividad]
    ADD CONSTRAINT [FK_ProyectoAsignacionActividad_ProyectoVersionActividad] FOREIGN KEY ([IdProyectoVersionActividad]) REFERENCES [dbo].[ProyectoVersionActividad] ([IdProyectoVersionActividad]) ON DELETE NO ACTION ON UPDATE NO ACTION;

