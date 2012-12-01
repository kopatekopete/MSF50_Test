ALTER TABLE [dbo].[PuestoNivel]
    ADD CONSTRAINT [FK_PuestoNivel_Puesto] FOREIGN KEY ([IdPuesto]) REFERENCES [dbo].[Puesto] ([IdPuesto]) ON DELETE NO ACTION ON UPDATE NO ACTION;

