ALTER TABLE [dbo].[TipoProyecto]
    ADD CONSTRAINT [FK_TipoProyecto_GrupoProyecto] FOREIGN KEY ([IdGrupoProyecto]) REFERENCES [dbo].[GrupoProyecto] ([IdGrupoProyecto]) ON DELETE NO ACTION ON UPDATE NO ACTION;

