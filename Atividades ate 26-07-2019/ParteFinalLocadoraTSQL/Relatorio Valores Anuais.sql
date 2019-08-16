select
	C.Modelo as 'Modelo',	
  	SUM(DATEDIFF(day, L.DataLocacao, L.DataDevolucao))  as 'Dias Locados',
	C.ValorDiaria as 'Valor da diária (em reais)',
	(SUM(DATEDIFF(day, L.DataLocacao, L.DataDevolucao)) * C.ValorDiaria) as 'Total valores (em reais)'
 from Carros C
	inner join Locacao L on L.IdCarro=C.Id
group by C.Modelo, C.ValorDiaria
order by SUM(DATEDIFF(day, L.DataLocacao, L.DataDevolucao)) desc