CREATE TABLE [Videogames] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(80) NOT NULL,
    [Description] nvarchar(300) NULL,
    [ReleaseDate] Date NULL,
    [Released] bit NOT NULL,
    [Developer] nvarchar(80) NOT NULL,
    [Platforms] nvarchar(120) NOT NULL,
    CONSTRAINT [PK_Videogames] PRIMARY KEY ([Id])
);
GO


