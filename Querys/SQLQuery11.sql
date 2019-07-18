select 
		Id,
		TipoDog,	
		SUM(Vendas) as 'Total Vendas',
		MONTH(DataVenda) as 'Mês'
	from HotDog	
	where Id BETWEEN 2 AND 5
	group by Id,TipoDog,MONTH(DataVenda)
	order by 'Total Vendas' desc