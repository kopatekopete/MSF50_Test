ALTER TABLE [dbo].[Proyecto]
    ADD CONSTRAINT [FK_Proyecto_TipoProyecto] FOREIGN KEY ([IdTipoProyecto]) REFERENCES [dbo].[TipoProyecto] ([IdTipoProyecto]) ON DELETE NO ACTION ON UPDATE NO ACTION;

