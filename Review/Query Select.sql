select 
		tr.Nome as 'Turma',
		a.Aluno		
	from Turmas tr 
		inner join TurmaAlunos ta on tr.Id=ta.Turma
		inner join Alunos a on ta.Aluno=a.Id
	--traz todos os alunos da turma

select 
		d.[Data],   --vai dentro [] pois é uma palavra reservada
		a.Aluno,
		n.Nota
	from Diarios d 
	inner join Turmas t on d.Turma=t.Id
	inner join TurmaAlunos tr on t.Id=tr.Turma
	inner join Alunos a on tr.Aluno=a.Id
	left join Notas n on tr.Aluno=n.Aluno


--versão do Felipe, prefiro a de cima, é mais clara
select 
		d.[Data],  --vai dentro [] pois é uma palavra reservada
		a.Aluno,
		n.Nota
	from Diarios d 
	inner join TurmaAlunos tr on d.Turma=tr.Turma
	inner join Turmas t on tr.Turma=t.Id	
	inner join Alunos a on tr.Aluno=a.Id
	left join Notas n on tr.Aluno=n.Aluno


--para simplificar:
select 
		d.[Data],  --vai dentro [] pois é uma palavra reservada
		--a.Aluno,
		n.Nota as 'Média',
		COUNT(p.Id) as 'Presenças'
	from Diarios d 
		inner join TurmaAlunos tr on d.Turma=tr.Turma
		--inner join Turmas t on tr.Turma=t.Id	
		--inner join Alunos a on tr.Aluno=a.Id
		left join Presenca p on d.Id=p.Diario and tr.Aluno=p.Aluno
		left join Notas n on tr.Aluno=n.Aluno and d.Id=n.Diario
group by d.[Data],n.Nota


select 
		d.[Data],  
		tr.Aluno,
		n.Nota as 'Média',
		IIF(COUNT(p.Id) = 1,'Presente','Ausente') as 'Presenças'
	from Diarios d 
		inner join TurmaAlunos tr on d.Turma=tr.Turma		
		left join Presenca p on d.Id=p.Diario and tr.Aluno=p.Aluno
		left join Notas n on tr.Aluno=n.Aluno and d.Id=n.Diario
group by d.[Data],tr.Aluno,n.Nota