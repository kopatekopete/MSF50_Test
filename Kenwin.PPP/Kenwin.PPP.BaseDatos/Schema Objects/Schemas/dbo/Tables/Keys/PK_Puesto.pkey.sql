﻿ALTER TABLE [dbo].[Puesto]
    ADD CONSTRAINT [PK_Puesto] PRIMARY KEY CLUSTERED ([IdPuesto] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
