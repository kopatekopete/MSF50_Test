﻿ALTER TABLE [dbo].[TipoEmpresa]
    ADD CONSTRAINT [PK_TipoEmpresa] PRIMARY KEY CLUSTERED ([IdTipoEmpresa] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

