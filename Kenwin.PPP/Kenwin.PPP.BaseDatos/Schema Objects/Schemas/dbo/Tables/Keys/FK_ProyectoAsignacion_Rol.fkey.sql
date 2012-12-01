ALTER TABLE [dbo].[ProyectoAsignacion]
    ADD CONSTRAINT [FK_ProyectoAsignacion_Rol] FOREIGN KEY ([IdRol]) REFERENCES [dbo].[Rol] ([IdRol]) ON DELETE NO ACTION ON UPDATE NO ACTION;

