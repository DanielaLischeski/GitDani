select 
	AL.Nome,
	SUM(NT.Nota) / COUNT(*) as 'Media'
from Alunos AL
inner join Notas NT on AL.Id = NT.Aluno
group by AL.Nome