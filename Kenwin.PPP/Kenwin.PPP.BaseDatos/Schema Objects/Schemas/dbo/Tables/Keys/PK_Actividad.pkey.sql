﻿ALTER TABLE [dbo].[Actividad]
    ADD CONSTRAINT [PK_Actividad] PRIMARY KEY CLUSTERED ([IdActividad] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

