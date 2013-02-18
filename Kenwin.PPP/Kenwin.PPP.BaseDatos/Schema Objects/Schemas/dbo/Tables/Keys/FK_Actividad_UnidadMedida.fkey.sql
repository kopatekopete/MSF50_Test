ALTER TABLE [dbo].[Actividad]
    ADD CONSTRAINT [FK_Actividad_UnidadMedida] FOREIGN KEY ([IdUnidadMedida]) REFERENCES [dbo].[UnidadMedida] ([IdUnidadMedida]) ON DELETE NO ACTION ON UPDATE NO ACTION;

