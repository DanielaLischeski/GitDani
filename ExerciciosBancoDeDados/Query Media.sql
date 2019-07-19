select 
	AL.Nome,
	SUM(NT.Nota) / COUNT(*) as 'Media',
	IIF(SUM(NT.Nota) / COUNT(*) >= 7,'Nota suficiente','Nota insuficiente') as 'Status Nota'
from Alunos AL
inner join Notas NT on AL.Id = NT.Aluno
group by AL.Nome