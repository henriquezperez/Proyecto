create database ProyectoBD

go

USE ProyectoBD


create table Tamanho(

	TamanhoId int identity (1,1) not null primary key,
	NombreTamanho varchar (25)  not null
)


create table ClasificacionBici(

	ClasificacionBiciId int identity (1,1) not null primary key,
	NombreClasificacion varchar (25) not null,
	--TamanhoId int not null foreign key (TamanhoId) references Tamanho(TamanhoId)
)

create table Categoria(

	CategoriaId int identity (1,1) not null primary key,
	NombreCategoria varchar (25) not null,
	ClasificacionBiciId int not null foreign key (ClasificacionBiciId) references ClasificacionBici(ClasificacionBiciId)

)


create table Marca(
	MarcaId int identity (1,1) not null primary key,
	NombreMarca varchar (25)  not null
)


create table Color(

	ColorId int identity (1,1) not null primary key,
	NombreColor varchar (25) not null

)


create table Garantia(

	GarantiaId int not null primary key,
	Nombre varchar (50) not null,
	TiempoGarantia int not null
)


create table Bicicleta(
 BicicletaId int identity (1,1) not null primary key,
 TamanhoId int not null foreign key (TamanhoId) references Tamanho(TamanhoId),
 CategoriaId int not null foreign key (CategoriaId) references Categoria(CategoriaId),
 MarcaId int not null foreign key (MarcaId) references Marca(MarcaId),
 GarantiaId int null foreign key(GarantiaId) references Garantia(GarantiaId),
 ColorId int not null foreign key (ColorId) references Color(ColorId),
 Precio money not null
)


create table Cliente(

	 ClienteId int identity (1,1) not null primary key,
	 Nombres varchar (67) not null,
	 Apellidos varchar (67) not null,
	 Dui varchar (10) not null,
	 Telefono char (10) not null,
	 Direccion varchar (60) not null,
	 Correo varchar (60) not null
)

create table TipoPago(
	
	PagoId int identity  not null primary key,
	NombreTipo varchar (20),
	EfectivoCant  money not null,
)

create table Estados(

	EstadoId int identity (1,1) not null primary key,
	NombreEstado varchar(45) not null

)


create table Venta(
	VentaId int identity (1,1) not null primary key,
	BicicletaId int not null foreign key (BicicletaId) references Bicicleta(BicicletaId),
	ClienteId int not null foreign key (ClienteId) references Cliente(ClienteId), 
	Fecha datetime not null,
	PagoId int not null foreign key (PagoId) references TipoPago(PagoId),
	EstadoId int foreign key (EstadoId) references Estados(EstadoId),
	--GarantiaId int null foreign key(GarantiaId) references Garantia(GarantiaId),
	--Cantidad int not null,
	--Subtotal decimal not null,
	Total money not null
)

create table DetalleVenta(

	DellVentaId int identity (1,1) not null primary key,
	VentaId int not null foreign key (VentaId) references Venta(VentaId),
	BicicletaId int not null foreign key (BicicletaId) references Bicicleta(BicicletaId),
	Cantidad int not null,
	Precio money not null,
	Total money not null
)