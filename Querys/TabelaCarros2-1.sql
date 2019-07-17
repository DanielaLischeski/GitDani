select 'Carros' as 'Carros',
		SUM(Temp.Media) as 'Vendas',
		Temp.AnoVenda 
	from (select
					Modelo,
					Ano,
					(SUM(NumeroVendas) / COUNT(*)) as 'Media',
					YEAR(DataVenda) as 'AnoVenda'
				from TabelaCarros2				
				group by Modelo,Ano,YEAR(DataVenda)) Temp
group by Temp.AnoVenda
	