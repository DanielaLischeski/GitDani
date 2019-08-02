CREATE TABLE [dbo].[Alunos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Nome] VARCHAR(100) NOT NULL, 
	[Disciplina] INT NOT NULL
    CONSTRAINT [FK_Alunos_Disciplinas] 
	FOREIGN KEY ([Disciplina]) 
	REFERENCES [Disciplinas]([Id])
)
