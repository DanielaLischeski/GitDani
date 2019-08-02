select
	C.Modelo as 'Modelo',
  	SUM(DATEDIFF(day, L.DataLocacao, L.DataDevolucao))  as 'Dias Locados'
 from Carros C
	inner join Locacao L on L.IdCarro=C.Id
group by C.Modelo
order by SUM(DATEDIFF(day, L.DataLocacao, L.DataDevolucao)) desc



