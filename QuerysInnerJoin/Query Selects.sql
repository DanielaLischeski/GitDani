select 
	Nome as 'Marcas cadastradas por Felipe'
from Marcas 
where UsuInc = 1;

select 
	Nome as 'Marcas cadastradas por Giomar'
from Marcas 
where UsuInc = 2;

select 
	count(*) as 'Número de marcas cadastradas por Felipe'
from Marcas 
where UsuInc = 1
order by count(*) desc;

select 
	count(*) as 'Número de marcas cadastradas por Giomar'
from Marcas 
where UsuInc = 2
order by count(*) asc;

select 
	count(*) as 'Númro de marcas cadastradas'
from Marcas ;

select 
	Modelo as 'Marcas cadastradas por Felipe'
from Carros 
where UsuInc = 1;

select 
	Modelo as 'Marcas cadastradas por Giomar'
from Carros 
where UsuInc = 2;

select 
	count(*) as 'Número de carros cadastrados por Felipe'
from Carros 
where UsuInc = 1
order by count(*) desc;

select 
	count(*) as 'Número de carros cadastrados por Giomar'
from Carros 
where UsuInc = 2
order by count(*) asc;

select 
	count(*) as 'Número de carros cadastrados'
from Carros;

select 
	C.Modelo as 'Carros das marcas que Felipe cadastrou'
from Carros C
inner join Marcas M on M.Id=C.Marca
where M.UsuInc = 1;

select 
	C.Modelo as 'Carros das marcas que Giomar cadastrou'
from Carros C
inner join Marcas M on M.Id=C.Marca
where M.UsuInc = 2;

select 
	count(*) as 'Quantidade de carros das marcas que Felipe cadastrou'
from Carros C
inner join Marcas M on M.Id=C.Marca
where M.UsuInc = 1
order by count(*) desc;

select 
	count(*) as 'Quantidade de carros das marcas que Giomar cadastrou'
from Carros C
inner join Marcas M on M.Id=C.Marca
where M.UsuInc = 2
order by count(*) asc;

select 
	SUM(Quantidade * Valor) as 'Valor de vendas 2019'
from Vendas
where YEAR(DatInc) = 2019;

select 
	SUM(Quantidade) as 'Total de vendas 2019'
from Vendas
where YEAR(DatInc) = 2019;

select 
	SUM(Quantidade * Valor) as 'Valor de vendas',
	YEAR(DatInc) as 'Ano de venda'
from Vendas
group by YEAR(DatInc) 
order by SUM(Quantidade * Valor) desc;

select 
	SUM(Quantidade) as 'Quantidade de vendas',
	YEAR(DatInc) as 'Ano de venda'
from Vendas
group by YEAR(DatInc)
order by SUM(Quantidade) desc;

select 
	SUM(Quantidade) as 'Quantidade de vendas',
	FORMAT(DatInc, 'MM-yyyy') as 'Mês - Ano'
from Vendas
group by FORMAT(DatInc, 'MM-yyyy')
order by SUM(Quantidade) desc;

select 
	SUM(Quantidade * Valor) as 'Valor de vendas',
	FORMAT(DatInc, 'MM-yyyy') as 'Mês - Ano'
from Vendas
group by FORMAT(DatInc, 'MM-yyyy')
order by SUM(Quantidade * Valor) desc;

select 
	SUM(Quantidade * Valor) as 'Valor de vendas Felipe'
from Vendas 
where UsuInc = 1;

select 
	SUM(Quantidade * Valor) as 'Valor de vendas Giomar'
from Vendas 
where UsuInc = 2;

select 
	SUM(Quantidade) as 'Quantidade de vendas Felipe'	
from Vendas
where UsuInc = 1;

select 
	SUM(Quantidade) as 'Quantidade de vendas Giomar'	
from Vendas
where UsuInc = 2;

select 
	SUM(Quantidade) as 'Quantidade de vendas Total'	
from Vendas
order by SUM(Quantidade) desc;

select 
	SUM(Quantidade * Valor) as 'Valor de vendas Total'
from Vendas 
order by SUM(Quantidade * Valor) desc;

select
	M.Nome as 'Marcas',
	SUM(V.Quantidade) as 'Quantidade de vendas'
from Marcas M
inner join Carros C on M.Id=C.Marca
inner join Vendas V on C.Id=V.Carro
group by M.Nome
order by SUM(V.Quantidade) desc;

select
	M.Nome as 'Marcas',
	SUM(V.Quantidade * V.Valor) as 'Valor de vendas'
from Marcas M
inner join Carros C on M.Id=C.Marca
inner join Vendas V on C.Id=V.Carro
group by M.Nome
order by SUM(V.Quantidade * V.Valor) desc;

select
	C.Modelo as 'Carros',
	SUM(V.Quantidade) as 'Quantidade de vendas'
from Carros C
inner join Vendas V on C.Id=V.Carro
group by C.Modelo
order by SUM(V.Quantidade) desc;

select
	C.Modelo as 'Carros',
	SUM(V.Quantidade * V.Valor) as 'Valor de vendas'
from Carros C
inner join Vendas V on C.Id=V.Carro
group by C.Modelo
order by SUM(V.Quantidade * V.Valor) desc;