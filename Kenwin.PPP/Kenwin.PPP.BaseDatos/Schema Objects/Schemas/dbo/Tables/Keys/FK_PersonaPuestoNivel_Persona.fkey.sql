ALTER TABLE [dbo].[PersonaPuestoNivel]
    ADD CONSTRAINT [FK_PersonaPuestoNivel_Persona] FOREIGN KEY ([IdPersona]) REFERENCES [dbo].[Persona] ([IdPersona]) ON DELETE NO ACTION ON UPDATE NO ACTION;

