ALTER TABLE [dbo].[ProyectoVersion]
    ADD CONSTRAINT [FK_ProyectoVersion_EstadoProyecto] FOREIGN KEY ([IdEstadoProyecto]) REFERENCES [dbo].[EstadoProyecto] ([IdEstadoProyecto]) ON DELETE NO ACTION ON UPDATE NO ACTION;

