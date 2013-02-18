ALTER TABLE [dbo].[Proyecto]
    ADD CONSTRAINT [FK_Proyecto_Moneda] FOREIGN KEY ([IdMoneda]) REFERENCES [dbo].[Moneda] ([IdMoneda]) ON DELETE NO ACTION ON UPDATE NO ACTION;

