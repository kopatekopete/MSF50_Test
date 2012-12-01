ALTER TABLE [dbo].[Actividad]
    ADD CONSTRAINT [FK_Actividad_TipoCalculo] FOREIGN KEY ([IdTipoCalculo]) REFERENCES [dbo].[TipoCalculo] ([IdTipoCalculo]) ON DELETE NO ACTION ON UPDATE NO ACTION;

