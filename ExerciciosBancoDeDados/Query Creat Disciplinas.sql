CREATE TABLE [dbo].[Disciplinas]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[NomeDisciplina] VARCHAR(100) NOT NULL,
	[Ativo] BIT NOT NULL,
)
