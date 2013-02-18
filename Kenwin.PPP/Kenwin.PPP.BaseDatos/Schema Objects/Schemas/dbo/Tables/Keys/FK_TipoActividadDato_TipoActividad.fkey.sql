ALTER TABLE [dbo].[TipoActividadDato]
    ADD CONSTRAINT [FK_TipoActividadDato_TipoActividad] FOREIGN KEY ([IdTipoActividad]) REFERENCES [dbo].[TipoActividad] ([IdTipoActividad]) ON DELETE NO ACTION ON UPDATE NO ACTION;

