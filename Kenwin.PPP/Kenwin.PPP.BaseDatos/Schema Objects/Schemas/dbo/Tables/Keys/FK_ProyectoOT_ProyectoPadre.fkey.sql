ALTER TABLE [dbo].[ProyectoOT]
    ADD CONSTRAINT [FK_ProyectoOT_ProyectoPadre] FOREIGN KEY ([IdProyectoPadre]) REFERENCES [dbo].[ProyectoPadre] ([IdProyectoPadre]) ON DELETE NO ACTION ON UPDATE NO ACTION;

