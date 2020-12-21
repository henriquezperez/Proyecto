use ProyectoBD

go

select * from Estados

insert into Estados(NombreEstado)
	values
	('Vendido')
go

select * from Marca

insert into Marca values (1,'Corsario')
go
 
select * from Color

insert into Color(NombreColor)
	 values
	 ('Negro')

go

select * from Tamanho

insert into Tamanho
	values
	('Grande')
go

select * from ClasificacionBici
insert into ClasificacionBici values ('Montaña')
insert into ClasificacionBici values ('De cidad')
go

select * from Garantia
insert into Garantia values (1,'1 Mes',1)
insert into Garantia values (2,'2 Mes',2)
insert into Garantia values (3,'3 Mes',3)
insert into Garantia values (4,'4 Mes',4)
insert into Garantia values (5,'5 Mes',5)
insert into Garantia values (6,'6 Mes',6)
go

select * from Bicicleta
insert into Bicicleta values(1,1,1,1,1,150.00)

select * from Categoria
insert into Categoria values ('Adulto',1)
insert into Categoria values ('Niño',2)
go