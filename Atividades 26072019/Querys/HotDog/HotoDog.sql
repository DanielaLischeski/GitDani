select 
		TipoDog,	
		SUM(Vendas) as 'Total Vendas',
		MONTH(DataVenda) as 'Mês'
	from HotDog	
	group by TipoDog,MONTH(DataVenda)
	order by SUM(Vendas) desc