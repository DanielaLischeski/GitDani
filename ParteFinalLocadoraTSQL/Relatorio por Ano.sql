select 
	C.Modelo as 'Modelo',	
	YEAR(L.DataLocacao) as 'Mês',
	count(*) as 'Número de locações'
from Carros C
	inner join Locacao L on L.IdCarro=C.Id
group by C.Modelo,YEAR(L.DataLocacao)