ALTER TABLE [dbo].[Proyecto]
    ADD CONSTRAINT [FK_Proyecto_Persona] FOREIGN KEY ([IdPersonaCreador]) REFERENCES [dbo].[Persona] ([IdPersona]) ON DELETE NO ACTION ON UPDATE NO ACTION;

