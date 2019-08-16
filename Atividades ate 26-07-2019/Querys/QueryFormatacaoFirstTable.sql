select 
		Aluno,
		Idade,
		iif(Ativo = 1, 'ativo','inativo') as 'Status'
	from AulaCsharp
where Id in 
	(select Id 
		from AulaCsharp 
		where Idade < 36)
order by Idade asc