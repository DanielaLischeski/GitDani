CREATE TABLE [dbo].[Clientes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Nome] VARCHAR(100) NOT NULL,
	[Idade] INT NOT NULL,
	[Obs] VARCHAR(250) NULL, 
	[IdUsuario] INT NOT NULL,

    CONSTRAINT [FK_Clientes_Usuarios] 
	FOREIGN KEY ([IdUsuario]) 
	REFERENCES [Usuarios]([Id]) 		   
)
