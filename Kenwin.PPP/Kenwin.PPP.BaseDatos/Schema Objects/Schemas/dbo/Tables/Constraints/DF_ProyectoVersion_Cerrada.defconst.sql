ALTER TABLE [dbo].[ProyectoVersion]
    ADD CONSTRAINT [DF_ProyectoVersion_Cerrada] DEFAULT ((0)) FOR [Cerrada];

