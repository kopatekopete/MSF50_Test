ALTER TABLE [dbo].[Proyecto]
    ADD CONSTRAINT [FK_Proyecto_UnidadNegocio] FOREIGN KEY ([IdUnidadNegocio]) REFERENCES [dbo].[UnidadNegocio] ([IdUnidadNegocio]) ON DELETE NO ACTION ON UPDATE NO ACTION;

