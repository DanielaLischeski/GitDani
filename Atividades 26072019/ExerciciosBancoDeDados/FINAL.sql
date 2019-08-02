select 
	AL.Nome,
	SUM(NT.Nota) / COUNT(*) as 'Media',
	IIF((SUM(CONVERT(money,FR.Ativo)) / CONVERT(money,count(FR.Ativo)) * 100) >= 75, 'Frequencia suficiente','Frequencia insuficiente') as 'Fequencia',
	IIF(SUM(NT.Nota) / COUNT(*) >= 7
	AND (SUM(CONVERT(money,FR.Ativo)) / CONVERT(money,count(FR.Ativo)) * 100) >= 75,'Aprovado','Reprovado') as 'Status Final'
	from Alunos AL
inner join Notas NT on AL.Id = NT.Aluno
inner join Frequencia FR on FR.Aluno = AL.Id
group by AL.Nome