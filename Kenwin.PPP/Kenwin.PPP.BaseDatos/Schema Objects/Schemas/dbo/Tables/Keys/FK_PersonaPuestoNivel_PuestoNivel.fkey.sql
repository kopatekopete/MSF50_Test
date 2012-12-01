ALTER TABLE [dbo].[PersonaPuestoNivel]
    ADD CONSTRAINT [FK_PersonaPuestoNivel_PuestoNivel] FOREIGN KEY ([IdPuestoNivel]) REFERENCES [dbo].[PuestoNivel] ([IdPuestoNivel]) ON DELETE NO ACTION ON UPDATE NO ACTION;

