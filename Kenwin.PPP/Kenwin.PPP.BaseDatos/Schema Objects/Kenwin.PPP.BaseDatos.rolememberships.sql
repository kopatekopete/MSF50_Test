EXECUTE sp_addrolemember @rolename = N'db_ddladmin', @membername = N'VEMN\Mariana';


GO
EXECUTE sp_addrolemember @rolename = N'db_datareader', @membername = N'VEMN\Mariana';


GO
EXECUTE sp_addrolemember @rolename = N'db_datawriter', @membername = N'VEMN\Mariana';

