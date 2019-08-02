select 
	AL.Nome,
	IIF(SUM(NT.Nota) / COUNT(*) >= 7
	AND (SUM(CONVERT(money,FR.Ativo)) / CONVERT(money,count(FR.Ativo)) * 100) >= 75,'Aprovado','Reprovado') as 'Status'
	from Alunos AL
inner join Notas NT on AL.Id = NT.Aluno
inner join Frequencia FR on FR.Aluno = AL.Id
group by AL.Nome