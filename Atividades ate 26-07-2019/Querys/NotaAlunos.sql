insert into NotaAlunos
(Nome,Materia,Nota)
values
('Daniela','Geografia',9)
select
	Nome,
	Materia,
	(SUM(Nota)  / COUNT(Nota)) as 'Media', 
	COUNT(Nota) as 'Provas'
from NotaAlunos
GROUP BY Nome, Materia
order by Nome asc
