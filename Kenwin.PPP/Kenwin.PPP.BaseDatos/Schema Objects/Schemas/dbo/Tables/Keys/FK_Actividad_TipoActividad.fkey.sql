ALTER TABLE [dbo].[Actividad]
    ADD CONSTRAINT [FK_Actividad_TipoActividad] FOREIGN KEY ([IdTipoActividad]) REFERENCES [dbo].[TipoActividad] ([IdTipoActividad]) ON DELETE NO ACTION ON UPDATE NO ACTION;

