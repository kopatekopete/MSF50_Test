﻿ALTER TABLE [dbo].[TipoProyecto]
    ADD CONSTRAINT [PK_TipoProyecto] PRIMARY KEY CLUSTERED ([IdTipoProyecto] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
