ALTER TABLE [dbo].[ProyectoActividad]
    ADD CONSTRAINT [FK_ProyectoActividad_Proyecto] FOREIGN KEY ([IdProyecto]) REFERENCES [dbo].[Proyecto] ([IdProyecto]) ON DELETE NO ACTION ON UPDATE NO ACTION;

