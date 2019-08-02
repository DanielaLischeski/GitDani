CREATE TABLE [dbo].[Carros]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Modelo] VARCHAR(50) NOT NULL,
	[Cor] VARCHAR(50) NOT NULL,
	[Ano] INT NOT NULL,
	[Placa] VARCHAR(10) NOT NULL,
	[ValorDiaria] INT NOT NULL,
	[Obs] VARCHAR(250),
	[IdUsuario] INT NOT NULL,
 
    CONSTRAINT [FK_Carros_Usuarios] 
	FOREIGN KEY ([IdUsuario]) 
	REFERENCES [Usuarios]([Id])	
)
