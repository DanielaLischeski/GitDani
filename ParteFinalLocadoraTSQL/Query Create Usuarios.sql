CREATE TABLE [dbo].[Usuarios]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Nome] VARCHAR(50) NOT NULL,
	[UsuInc] INT           NOT NULL,
    [UsuAlt] INT           NOT NULL,
    [DatInc] DATETIME      NOT NULL,
    [DatAlt] DATETIME      NOT NULL,
)
