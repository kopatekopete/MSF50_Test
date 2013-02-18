ALTER TABLE [dbo].[PersonaIdioma]
    ADD CONSTRAINT [FK_PersonaIdioma_Idioma] FOREIGN KEY ([IdIdioma]) REFERENCES [dbo].[Idioma] ([IdIdioma]) ON DELETE NO ACTION ON UPDATE NO ACTION;

