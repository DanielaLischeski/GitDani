CREATE TABLE [dbo].[Locacao]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[IdCliente] INT NOT NULL,
	[IdCarro] INT NOT NULL,
	[DataLocacao] DATE DEFAULT GETDATE() NOT NULL,
	[DataDevolucao] DATE DEFAULT GETDATE() NOT NULL, 

    CONSTRAINT [FK_Locacao_Clientes] 
	FOREIGN KEY ([IdCliente]) 
	REFERENCES [Clientes]([Id]), 

    CONSTRAINT [FK_Locacao_Carros] 
	FOREIGN KEY ([IdCarro]) 
	REFERENCES [Carros]([Id])
)
