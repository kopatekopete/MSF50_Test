ALTER TABLE [dbo].[ActividadPuestoNivel]
    ADD CONSTRAINT [FK_ActividadPuestoNivel_Actividad] FOREIGN KEY ([IdActividad]) REFERENCES [dbo].[Actividad] ([IdActividad]) ON DELETE NO ACTION ON UPDATE NO ACTION;

