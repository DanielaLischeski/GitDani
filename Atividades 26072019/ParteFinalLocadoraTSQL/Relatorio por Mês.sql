select 
	C.Modelo as 'Modelo',	
	MONTH(L.DataLocacao) as 'Mês',
	count(*) as 'Número de locações'
from Carros C
	inner join Locacao L on L.IdCarro=C.Id
group by C.Modelo,MONTH(L.DataLocacao)
