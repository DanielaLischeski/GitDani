CREATE TABLE [dbo].[Locacoes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[IdVideo] INT NOT NULL,
	[IdPessoa] INT NOT NULL,
	[Data] DATETIME NOT NULL
	
	CONSTRAINT [FK_Locacoes_Videos] 
	FOREIGN KEY ([IdVideo]) 
	REFERENCES [Videos]([Id]),
	
	CONSTRAINT [FK_Locacoes_Pessoa] 
	FOREIGN KEY ([IdPessoa]) 
	REFERENCES [Pessoas]([Id])
)