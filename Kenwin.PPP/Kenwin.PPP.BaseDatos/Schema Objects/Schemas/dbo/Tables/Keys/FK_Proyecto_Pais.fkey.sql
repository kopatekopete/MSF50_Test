﻿ALTER TABLE [dbo].[Proyecto]
    ADD CONSTRAINT [FK_Proyecto_Pais] FOREIGN KEY ([IdPais]) REFERENCES [dbo].[Pais] ([IdPais]) ON DELETE NO ACTION ON UPDATE NO ACTION;

