
select 	
		BL.Nome,
		COUNT(LV.Id) as 'QuantidadeDeLivros'
	from Biblioteca BL
	inner join Livros LV on BL.Id = LV.Biblioteca
	group by BL.Nome