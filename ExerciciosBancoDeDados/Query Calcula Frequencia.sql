select AL.Nome,
       IIF((SUM(CONVERT(money,FR.Ativo)) / CONVERT(money,count(fr.Ativo)) * 100) >= 75, 'Frequencia suficiente','Frequencia insuficiente') as 'Fequencia'
	   from Alunos AL 
inner join Frequencia FR on AL.Id = FR.Aluno
group by AL.Nome