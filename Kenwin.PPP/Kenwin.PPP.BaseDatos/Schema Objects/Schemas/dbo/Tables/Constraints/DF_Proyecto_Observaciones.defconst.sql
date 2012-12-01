ALTER TABLE [dbo].[Proyecto]
    ADD CONSTRAINT [DF_Proyecto_Observaciones] DEFAULT ('') FOR [Observaciones];

