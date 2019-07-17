insert into AulaCsharp
(Aluno,Idade,Ativo,UsuInc,UsuAlt,DatInc,DatAlt)
values
('Daniela',35,1,22031984,20051985,GETDATE(),GETDATE()),
('Gilberto',34,1,22031984,20051985,GETDATE(),GETDATE()),
('Vanessa',33,1,22031984,10071986,GETDATE(),GETDATE()),
('Andrei',24,0,22031984,17071995,GETDATE(),GETDATE()),
('David',24,0,22031984,26051995,GETDATE(),GETDATE());
go
select * from AulaCsharp