ALTER TABLE [dbo].[PersonaIdioma]
    ADD CONSTRAINT [FK_PersonaIdioma_Persona] FOREIGN KEY ([IdPersona]) REFERENCES [dbo].[Persona] ([IdPersona]) ON DELETE NO ACTION ON UPDATE NO ACTION;

