ALTER TABLE [dbo].[Proyecto]
    ADD CONSTRAINT [FK_Proyecto_ProyectoOT] FOREIGN KEY ([IdProyectoOt]) REFERENCES [dbo].[ProyectoOT] ([IdProyectoOt]) ON DELETE NO ACTION ON UPDATE NO ACTION;

