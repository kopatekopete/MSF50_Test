ALTER DATABASE [$(DatabaseName)]
    ADD FILE (NAME = [Proyectos], FILENAME = '$(DefaultDataPath)$(DatabaseName).mdf', FILEGROWTH = 1024 KB) TO FILEGROUP [PRIMARY];

