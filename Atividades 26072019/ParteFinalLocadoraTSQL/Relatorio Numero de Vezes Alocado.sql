
select 
	C.Modelo as 'Modelo',
	count(*) as 'Número de alocações'
from Carros C
	inner join Locacao L on L.IdCarro=C.Id
group by C.Modelo
order by count(*) desc