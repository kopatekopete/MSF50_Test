ALTER TABLE [dbo].[ActividadRate]
    ADD CONSTRAINT [FK_ActividadRate_Cliente] FOREIGN KEY ([IdCliente]) REFERENCES [dbo].[Cliente] ([IdCliente]) ON DELETE NO ACTION ON UPDATE NO ACTION;

