CREATE TABLE [dbo].[Livros]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
	[Registro] INT NOT NULL,
    [Titulo] VARCHAR(1200) NOT NULL, 
    [Isbn] VARCHAR(15) NOT NULL, 
    [Genero] INT NOT NULL, 
    [Editora] INT NOT NULL, 
    [Sinopse] NVARCHAR(MAX) NULL,
	[Observacoes] VARCHAR(1000) NULL,
	[Ativo] BIT NOT NULL,
	[UsuInc] INT NOT NULL, 
    [UsuAlt] INT NOT NULL, 
    [DatInc] DATETIME NOT NULL DEFAULT GETDATE(), 
    [DatAlt] DATETIME NOT NULL DEFAULT GETDATE(),  
    CONSTRAINT [FK_Livros_To_Genero] 
	FOREIGN KEY ([Genero]) 
	REFERENCES [Generos]([Id]), 

    CONSTRAINT [FK_Livros_To_Editora] 
	FOREIGN KEY ([Editora]) 
	REFERENCES [Editoras]([Id]), 
	
	CONSTRAINT [FK_Livros_To_UsuarioInc] 
	FOREIGN KEY ([UsuInc]) 
	REFERENCES [Usuarios]([Id]), 

    CONSTRAINT [FK_Livros_To_UsuarioAlt] 
	FOREIGN KEY ([UsuAlt]) 
	REFERENCES [Usuarios]([Id]) 
)
