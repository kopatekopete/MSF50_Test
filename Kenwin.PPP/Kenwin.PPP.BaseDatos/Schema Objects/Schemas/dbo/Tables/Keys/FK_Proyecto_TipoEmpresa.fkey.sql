ALTER TABLE [dbo].[Proyecto]
    ADD CONSTRAINT [FK_Proyecto_TipoEmpresa] FOREIGN KEY ([IdTipoEmpresa]) REFERENCES [dbo].[TipoEmpresa] ([IdTipoEmpresa]) ON DELETE NO ACTION ON UPDATE NO ACTION;

