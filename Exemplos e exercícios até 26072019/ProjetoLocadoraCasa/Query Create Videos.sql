CREATE TABLE [dbo].[Videos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Nome] VARCHAR(100) NOT NULL,
	[IdTipo] INT NOT NULL,	
	[IdGenero] INT NOT NULL,
	[IdClassificacao] INT NOT NULL,
	[IdLocadora] INT NOT NULL
	
	CONSTRAINT [FK_Filmes_Tipos] 
	FOREIGN KEY ([IdTipo]) 
	REFERENCES [Tipos]([Id]),
	
	CONSTRAINT [FK_Filmes_Generos] 
	FOREIGN KEY ([IdGenero]) 
	REFERENCES [Generos]([Id]),
	
	CONSTRAINT [FK_Filmes_Classificacao] 
	FOREIGN KEY ([IdClassificacao]) 
	REFERENCES [Classificacao]([Id]),	

	CONSTRAINT [FK_Filmes_Locadora] 
	FOREIGN KEY ([IdLocadora]) 
	REFERENCES [Locadora]([Id])
)
