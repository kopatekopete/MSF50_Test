ALTER TABLE [dbo].[Proyecto]
    ADD CONSTRAINT [FK_Proyecto_Cliente] FOREIGN KEY ([IdCliente]) REFERENCES [dbo].[Cliente] ([IdCliente]) ON DELETE NO ACTION ON UPDATE NO ACTION;

