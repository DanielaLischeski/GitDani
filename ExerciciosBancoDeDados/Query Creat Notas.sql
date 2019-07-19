CREATE TABLE [dbo].[Notas]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Nota] INT NOT NULL,
	[Aluno] INT NOT NULL 
 
    CONSTRAINT [FK_Notas_Alunos] 
	FOREIGN KEY ([Aluno]) 
	REFERENCES [Alunos]([Id]),

)
