--Trazer somente as marcas que Felipe cadastrou
select 
	Nome as 'Marcas cadastradas por Felipe'
from Marcas 
where UsuInc = 1;

--Trazer somente as marcas que Giomar cadastrou
select 
	Nome as 'Marcas cadastradas por Giomar'
from Marcas 
where UsuInc = 2;

--Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor
select 
	count(*) as 'Número de marcas cadastradas por Felipe'
from Marcas 
where UsuInc = 1
order by count(*) desc;

--Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior
select 
	count(*) as 'Número de marcas cadastradas por Giomar'
from Marcas 
where UsuInc = 2
order by count(*) asc;

--Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram 
select 
	count(*) as 'Númro de marcas cadastradas'
from Marcas ;

--Trazer somente os carros que Felipe cadastrou
select 
	Modelo as 'Carros cadastrados por Felipe'
from Carros 
where UsuInc = 1;

--Trazer somente os carros que Giomar cadastrou
select 
	Modelo as 'Carros cadastrados por Giomar'
from Carros 
where UsuInc = 2;

--Trazer somente a quantidade de carros que Felipe cadastrou maior para menor
select 
	count(*) as 'Número de carros cadastrados por Felipe'
from Carros 
where UsuInc = 1
order by count(*) desc;

--Trazer somente a quantidade de carros que Giomar cadastrou menor para maior
select 
	count(*) as 'Número de carros cadastrados por Giomar'
from Carros 
where UsuInc = 2
order by count(*) asc;

--Trazer somente a quantidade de carros que Felipe e Giomar cadastraram 
select 
	count(*) as 'Número de carros cadastrados'
from Carros;

--Trazer somente os carros das marcas que Felipe cadastrou
select 
	C.Modelo as 'Carros das marcas que Felipe cadastrou'
from Carros C
inner join Marcas M on M.Id=C.Marca
where M.UsuInc = 1;

--Trazer somente os carros das marcas que Giomar cadastrou
select 
	C.Modelo as 'Carros das marcas que Giomar cadastrou'
from Carros C
inner join Marcas M on M.Id=C.Marca
where M.UsuInc = 2;

--Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor
select 
	count(*) as 'Quantidade de carros das marcas que Felipe cadastrou'
from Carros C
inner join Marcas M on M.Id=C.Marca
where M.UsuInc = 1
order by count(*) desc;

--Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior
select 
	count(*) as 'Quantidade de carros das marcas que Giomar cadastrou'
from Carros C
inner join Marcas M on M.Id=C.Marca
where M.UsuInc = 2
order by count(*) asc;

--Trazer o valor total de vendas 2019 isolado
select 
	SUM(Quantidade * Valor) as 'Valor de vendas 2019'
from Vendas
where YEAR(DatInc) = 2019;

--Trazer a quantidade total de vendas 2019 isolado
select 
	SUM(Quantidade) as 'Total de vendas 2019'
from Vendas
where YEAR(DatInc) = 2019;

--Trazer o valor total de vendas em cada ano e ordernar do maior para o menor
select 
	SUM(Quantidade * Valor) as 'Valor de vendas',
	YEAR(DatInc) as 'Ano de venda'
from Vendas
group by YEAR(DatInc) 
order by SUM(Quantidade * Valor) desc;

--Trazer a quantidade de vendas em cada ano e ordernar do maior para o menor
select 
	SUM(Quantidade) as 'Quantidade de vendas',
	YEAR(DatInc) as 'Ano de venda'
from Vendas
group by YEAR(DatInc)
order by SUM(Quantidade) desc;

--Trazer o mês de cada ano que retornou a maior quantidade de vendas
select 
	SUM(Quantidade) as 'Quantidade de vendas',
	FORMAT(DatInc, 'MM-yyyy') as 'Mês - Ano'
from Vendas
group by FORMAT(DatInc, 'MM-yyyy')
order by SUM(Quantidade) desc;

--Trazer o mês de cada ano que retornou o maior valor de vendas
select 
	SUM(Quantidade * Valor) as 'Valor de vendas',
	FORMAT(DatInc, 'MM-yyyy') as 'Mês - Ano'
from Vendas
group by FORMAT(DatInc, 'MM-yyyy')
order by SUM(Quantidade * Valor) desc;

--Trazer o valor total de vendas que Felipe realizou
select 
	SUM(Quantidade * Valor) as 'Valor de vendas Felipe'
from Vendas 
where UsuInc = 1;

--Trazer o valor total de vendas que Giomar realizou
select 
	SUM(Quantidade * Valor) as 'Valor de vendas Giomar'
from Vendas 
where UsuInc = 2;

--Trazer a quantidade total de vendas que Felipe realizou
select 
	SUM(Quantidade) as 'Quantidade de vendas Felipe'	
from Vendas
where UsuInc = 1;

--Trazer a quantidade de vendas que Giomar realizou
select 
	SUM(Quantidade) as 'Quantidade de vendas Giomar'	
from Vendas
where UsuInc = 2;

--Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select 
	SUM(Quantidade) as 'Quantidade de vendas Total'	
from Vendas
order by SUM(Quantidade) desc;

--Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select 
	SUM(Quantidade * Valor) as 'Valor de vendas Total'
from Vendas 
order by SUM(Quantidade * Valor) desc;

--Trazer  a marca mais vendida de todos os anos
select
	M.Nome as 'Marcas',
	SUM(V.Quantidade) as 'Quantidade de vendas'
from Marcas M
inner join Carros C on C.Marca=M.Id
inner join Vendas V on V.Carro=C.Id
group by M.Nome
order by SUM(V.Quantidade) desc;

--Trazer o valor total da marca mais vendida de todos os anos	
select
	M.Nome as 'Marcas',
	SUM(V.Quantidade * V.Valor) as 'Valor de vendas'
from Marcas M
inner join Carros C on C.Marca=M.Id
inner join Vendas V on V.Carro=C.Id
group by M.Nome
order by SUM(V.Quantidade * V.Valor) desc;

--Trazer a quantidade do carro mais vendido de todos os anos
select
	C.Modelo as 'Carros',
	SUM(V.Quantidade) as 'Quantidade de vendas'
from Carros C
inner join Vendas V on C.Id=V.Carro
group by C.Modelo
order by SUM(V.Quantidade) desc;

--Trazer o valor do carro mais vendido de todos os anos
select
	C.Modelo as 'Carros',
	SUM(V.Quantidade * V.Valor) as 'Valor de vendas'
from Carros C
inner join Vendas V on C.Id=V.Carro
group by C.Modelo
order by SUM(V.Quantidade * V.Valor) desc;