ALTER TABLE [dbo].[ProyectoVersionDocumento]
    ADD CONSTRAINT [FK_ProyectoVersionDocumentos_ProyectoVersion] FOREIGN KEY ([IdProyectoVersion]) REFERENCES [dbo].[ProyectoVersion] ([IdProyectoVersion]) ON DELETE NO ACTION ON UPDATE NO ACTION;

