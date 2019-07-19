CREATE TABLE [dbo].[Frequencia]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Ativo]	BIT NOT NULL,
	[Data]  DATETIME DEFAULT (getdate()) NOT NULL,
	[Aluno] INT NOT NULL, 

    CONSTRAINT [FK_Frequencia_Alunos] 
	FOREIGN KEY ([Aluno]) 
	REFERENCES [Alunos]([Id])
)
