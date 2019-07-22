select 	
	count(*) as 'Número de locações no ano'
from Carros C
	inner join Locacao L on L.IdCarro=C.Id