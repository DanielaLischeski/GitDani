select 
		TipoDog,	
		SUM(Vendas) as 'Total Vendas',
		MONTH(DataVenda) as 'Mês'
	from HotDog	
	WHERE month(DataVenda) BETWEEN 1 AND 2
	group by TipoDog,MONTH(DataVenda)
	order by 'Total Vendas' desc

	--É o mesmo que:
	--select 
	--	TipoDog,	
	--	SUM(Vendas) as 'Total Vendas',
	--	MONTH(DataVenda) as 'Mês'
	--from HotDog	
	--where MONTH(DataVenda)  >= 1
	--  AND MONTH(DataVenda) <= 3
	--group by TipoDog,MONTH(DataVenda)
	--order by 'Total Vendas' desc