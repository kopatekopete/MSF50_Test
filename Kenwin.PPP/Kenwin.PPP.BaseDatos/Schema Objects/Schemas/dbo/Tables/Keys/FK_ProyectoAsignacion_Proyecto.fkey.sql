ALTER TABLE [dbo].[ProyectoAsignacion]
    ADD CONSTRAINT [FK_ProyectoAsignacion_Proyecto] FOREIGN KEY ([IdProyecto]) REFERENCES [dbo].[Proyecto] ([IdProyecto]) ON DELETE NO ACTION ON UPDATE NO ACTION;

