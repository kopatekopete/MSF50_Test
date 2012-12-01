ALTER TABLE [dbo].[ActividadRate]
    ADD CONSTRAINT [FK_ActividadRate_Moneda] FOREIGN KEY ([IdMoneda]) REFERENCES [dbo].[Moneda] ([IdMoneda]) ON DELETE NO ACTION ON UPDATE NO ACTION;

