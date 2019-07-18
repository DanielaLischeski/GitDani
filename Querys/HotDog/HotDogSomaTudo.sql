select 
		TipoDog,	
		SUM(Vendas) as 'Total Vendas'
	from HotDog	
	group by TipoDog
	order by SUM(Vendas) desc