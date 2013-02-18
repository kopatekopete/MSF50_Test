ALTER TABLE [dbo].[ProyectoVersion]
    ADD CONSTRAINT [FK_ProyectoVersion_Proyecto] FOREIGN KEY ([IdProyecto]) REFERENCES [dbo].[Proyecto] ([IdProyecto]) ON DELETE NO ACTION ON UPDATE NO ACTION;

