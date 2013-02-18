ALTER TABLE [dbo].[ActividadRate]
    ADD CONSTRAINT [FK_ActividadRate_Actividad] FOREIGN KEY ([IdActividad]) REFERENCES [dbo].[Actividad] ([IdActividad]) ON DELETE NO ACTION ON UPDATE NO ACTION;

