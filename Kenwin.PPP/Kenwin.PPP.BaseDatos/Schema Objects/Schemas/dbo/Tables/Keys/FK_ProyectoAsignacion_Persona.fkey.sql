ALTER TABLE [dbo].[ProyectoAsignacion]
    ADD CONSTRAINT [FK_ProyectoAsignacion_Persona] FOREIGN KEY ([IdPersona]) REFERENCES [dbo].[Persona] ([IdPersona]) ON DELETE NO ACTION ON UPDATE NO ACTION;

