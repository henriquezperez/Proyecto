use ProyectoBD

go

--ESTADOS
--SELECT ALL
create proc sp_EstadosSelectAll
	
as 
begin

	select * from Estados
end	
go

--SELECT BY ID
create proc sp_EstadosSelectById
(
	@EstadoId int --solo las ID
)
as begin 
	select * from Estados where EstadoId = @EstadoId
end
go

--INSERT
create proc sp_EstadosInsert

	@NombreEstado varchar (45)

as begin
	insert into Estados (NombreEstado) values (@NombreEstado)
end
go


--UPDATE
create proc sp_EstadosUpdate
(
	@EstadosId int,
	@NombreEstado varchar (45)
)
as begin 
	update Estados set NombreEstado = @NombreEstado where EstadoId = @EstadosId
end
go


--DELETE

create proc sp_EstadosDelete
(
	@Estadoid int
)
as begin
	delete from Estados where EstadoId = @Estadoid
end
go
--_______________________________________________________________________________________

	--MARCA
--SELECT ALL
create proc sp_MarcaSelectAll
	
as 
begin

	select * from Marca
end	
go


--SELECT BY ID
create proc sp_MarcaSelectById
(
	@MarcaId int --solo las ID
)
as begin 
	select * from Marca where MarcaId = @MarcaId
end
go

--INSERT
create proc sp_MarcaInsert

	@NombreMarca varchar (25)

as begin
	insert into Marca (NombreMarca) values (@NombreMarca)
end
go


--UPDATE
create proc sp_MarcaUpdate
(
	@MarcaId int,
	@NombreMarca varchar (25)
)
as begin 
	update Marca set NombreMarca = @NombreMarca where MarcaId = @MarcaId
end
go

--DELETE
create proc sp_MarcaDelete
(
	@MarcaId int
)
as begin
	delete from Marca where MarcaId = @MarcaId
end
go

--_______________________________________________________________________________________

--COLOR

--SELECT ALL
create proc sp_ColorSelectAll
	
as 
begin

	select * from Color
end	
go


--SELECT BY ID
create proc sp_ColorSelectById
(
	@ColorId int --solo las ID
)
as begin 
	select * from Color where ColorId = @ColorId
end
go

--INSERT
create proc sp_ColorInsert

	@NombreColor varchar (25)

as begin
	insert into Color(NombreColor) values (@NombreColor)
end
go


--UPDATE
create proc sp_ColorUpdate
(
	@ColorId int,
	@NombreColor varchar (25)
)
as begin 
	update Color set NombreColor = @NombreColor where ColorId = @ColorId
end
go

--DELETE
create proc Sp_ColorDelete
(
	@ColorId int
)
as begin
	delete from Color where ColorId = @ColorId
end
go

--_______________________________________________________________________________________

--TAMANHO

--SELECT ALL
create proc sp_TamanhoBiciSelectAll
	
as 
begin

	select * from Tamanho
end	
go


--SELECT BY ID
create proc sp_TamanhoBiciSelectById
(
	@TamanhoId int --solo las ID
)
as begin 
	select * from Tamanho where TamanhoId = @TamanhoId
end
go

--INSERT
create proc sp_TamanhoBiciInsert

	@NombreTamanho varchar (25)

as begin
	insert into Tamanho(NombreTamanho) values (@NombreTamanho)
end
go


--UPDATE
create proc sp_TamanhoBiciUpdate
(
	@TamanhoId int,
	@NombreTamanho varchar (25)
)
as begin 
	update Tamanho set NombreTamanho = @NombreTamanho where TamanhoId = @TamanhoId
end
go

--DELETE
create proc sp_TamanhoBiciDelete
(
	@TamanhoId int
)
as begin
	delete from Tamanho where TamanhoId = @TamanhoId
end
go

--_______________________________________________________________________________________

--CATEGORIA

--SELECT ALL
create proc sp_CategoriaSelectAll
	
as 
begin

	select * from Categoria
end	
go

--SELECT BY ID
create proc sp_CategoriaSelectById
(
	@CategoriaId int --solo las ID
)
as begin 
	select * from Categoria where CategoriaId = @CategoriaId
end
go

--INSERT
create proc sp_CategoriaInsert

	@NombreCategoria varchar (25)

as begin
	insert into Categoria(NombreCategoria) values (@NombreCategoria)
end
go

--UPDATE
create proc sp_CategoriaUpdate
(
	@CategoriaId int,
	@NombreCategoria varchar (25),
	@ClasificacionBiciId int
	
)
as begin 
	update Categoria set NombreCategoria = @NombreCategoria, ClasificacionBiciId = @ClasificacionBiciId where CategoriaId = @CategoriaId
end
go

--DELETE
create proc sp_CategoriaDelete
(
	@CategoriaId int
)
as begin
	delete from Categoria where CategoriaId = @CategoriaId
end
go

--_______________________________________________________________________________________

--CLIENTES

--SELECT ALL
create proc sp_ClienteSelectAll
	
as 
begin

	select * from Cliente
end	
go

--SELECT BY ID
create proc sp_ClienteSelectById
(
	@ClienteId int --solo las ID
)
as begin 
	select * from Cliente where ClienteId = @ClienteId
end
go

--INSERT
create proc sp_ClienteInsert

	@Nombres varchar (67),
	@Apellidos varchar (67),
	@Dui varchar (10),
	@Telefono char (10),
	@Direccion varchar (60),
	@Correo varchar (60)

as begin
	insert into Cliente(Nombres) values (@Nombres)
	insert into Cliente(Apellidos) values (@Apellidos)
	insert into Cliente(Dui) values (@Dui)
	insert into Cliente(Telefono) values (@Telefono)
	insert into Cliente(Direccion) values (@Direccion)
	insert into Cliente(Correo) values (@Correo)
end
go

--UPDATE
create proc sp_ClienteUpdate
(
	@ClienteId int,
	@Nombres varchar (67),
	@Apellidos varchar (67),
	@Dui varchar (10),
	@Telefono char (10),
	@Direccion varchar (60),
	@Correo varchar (60)
	
)
as begin 
	update Cliente set 
	Nombres = @Nombres,
	Apellidos = @Apellidos,
	Dui = @Dui,
	Telefono = @Telefono,
	Direccion = @Direccion,
	Correo = @Correo
	where ClienteId = @ClienteId
end
go

--DELETE
create proc sp_ClienteDelete
(
	@ClienteId int
)
as begin
	delete from Cliente where ClienteId = @ClienteId
end
go

--_______________________________________________________________________________________

--BICICLETAS

--SELECT ALL
create proc sp_BicicletaSelectAll
	
as 
begin

	select * from Bicicleta
end	
go

--SELECT BY ID
create proc sp_BicicletaSelectById
(
	@BicicletaId int
)
as begin 
	select * from Bicicleta where BicicletaId = @BicicletaId
end
go

--INSERT
create proc sp_BicicletaInsert

	@TamanhoId int,
	@CategoriaId int,
	@MarcaId int,
	@GarantiaId int,
	@ColorId int,
	@Precio money

as begin
	insert into Bicicleta(TamanhoId) values (@TamanhoId)
	insert into Bicicleta(MarcaId) values (@MarcaId)
	insert into Bicicleta(GarantiaId) values (@GarantiaId)
	insert into Bicicleta(ColorId) values (@ColorId)
	insert into Bicicleta(Precio) values (@Precio)
end
go

--UPDATE
create proc sp_BicicletaUpdate
(
	@BicicletaId int,
	@TamanhoId int,
	@CategoriaId int,
	@MarcaId int,
	@GarantiaId int,
	@ColorId int,
	@Precio money
	
)
as begin 
	update Bicicleta set 
	TamanhoId = @TamanhoId,
	CategoriaId = @CategoriaId,
	MarcaId = @MarcaId,
	GarantiaId = @GarantiaId,
	ColorId = @ColorId,
	Precio = @Precio
	where BicicletaId = @BicicletaId
end
go

--DELETE
create proc sp_BicicletaDelete
(
	@BicicletaId int
)
as begin
	delete from Bicicleta where BicicletaId = @BicicletaId
end
go

--_______________________________________________________________________________________

--CLASIFICACION

--SELECT ALL
create proc sp_ClasificacionSelectAll
	
as 
begin

	select * from ClasificacionBici
end	
go

--SELECT BY ID
create proc sp_ClasificacionSelectById
(
	@ClasificacionBiciId int
)
as begin 
	select * from ClasificacionBici where ClasificacionBiciId = @ClasificacionBiciId
end
go

--INSERT
create proc sp_ClasificacionInsert

	@NombreClasificacion varchar (25)
	

as begin
	insert into ClasificacionBici(NombreClasificacion) values (@NombreClasificacion)
	
end
go

--UPDATE
create proc sp_ClasificacionUpdate
(
	@ClasificacionBiciId int,
	@NombreClasificacion varchar (25)

)
as begin 
	update ClasificacionBici set 
	NombreClasificacion = @NombreClasificacion where ClasificacionBiciId = @ClasificacionBiciId
end
go

--DELETE
create proc sp_ClasificacionDelete
(
	@ClasificacionBiciId int
)
as begin
	delete from ClasificacionBici where ClasificacionBiciId = @ClasificacionBiciId
end
go