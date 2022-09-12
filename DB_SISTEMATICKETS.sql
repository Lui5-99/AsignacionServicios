/*CREATE DATABASE DB_SISTEMATICKETS

GO*/

USE DB_SISTEMATICKETS

GO

CREATE TABLE ROL(
	IdRol INT PRIMARY KEY IDENTITY,
	Descripcion varchar(50),
	FechaRegistro datetime default getdate()
)

GO

CREATE TABLE PERMISO(
	IdPermiso int primary key identity,
	IdRol int references ROL(IdRol),
	NombreMenu varchar(100),
	Estado bit,
	FechaRegistro datetime default getdate()
)

GO

CREATE TABLE ESTADOSERVICIO(
	IdEstadoServicio int primary key identity,
	Descripcion varchar(50),
)

GO

create table CLIENTE(
	IdCliente int primary key identity,
	Codigo varchar(50),
	RazonSocial varchar(50),
	Correo varchar(50),
	Telefono varchar(50),
	Estado bit,
	FechaRegistro datetime default getdate()
)

GO

CREATE TABLE USUARIO(
	IdUsuario int primary key identity,
	UserName varchar(50),
	NombreCompleto varchar(50),
	Correo varchar(50),
	Clave varchar(50),
	IdRol int references ROL(IdRol),
	Estado bit,
	FechaRegistro datetime default getdate()
)

GO

CREATE TABLE SERVICIO(
	IdServicio int primary key identity,
	IdUsuario int references USUARIO(IdUsuario),
	IdUAsignado int references USUARIO(IdUsuario),
	CodigoServicio varchar (50),
	RazonSocial varchar(50),
	Factura bit,
	HojaServicio bit,
	IdEstadoServicio int references ESTADOSERVICIO(IdEstadoServicio),
	Descripcion varchar(500),
	Solucion varchar(500),
	FechaRegistro datetime default getdate()
)

GO

CREATE TABLE MOVIMIENTO(
	IdMovimiento int primary key identity,
	IdServicio int references SERVICIO(IdServicio),
	IdUsuario int references USUARIO(IdUsuario),
	IdEstadoServicio int references ESTADOSERVICIO(IdEstadoServicio),
	Bitacora VARCHAR(500),
	FechaRegistro datetime default getdate()
)

GO

/*************************** CREACION DE PROCEDIMIENTOS ALMACENADOS ***************************/
/*--------------------------------------------------------------------------------------------*/

go

/* ---------- PROCEDIMIENTOS PARA USUARIOS -----------------*/

/* ---------- PROCEDIMIENTOS PARA CREAR USUARIOS -----------------*/
create PROC SP_REGISTRARUSUARIO(
@UserName varchar(50),
@NombreCompleto varchar(100),
@Correo varchar(100),
@Clave varchar(100),
@IdRol int,
@Estado bit,
@IdUsuarioResultado int output,
@Mensaje varchar(500) output
)
as
begin
	set @IdUsuarioResultado = 0
	set @Mensaje = ''


	if not exists(select * from USUARIO where UserName = @UserName)
	begin
		insert into usuario(UserName,NombreCompleto,Correo,Clave,IdRol,Estado) values
		(@UserName,@NombreCompleto,@Correo,@Clave,@IdRol,@Estado)

		set @IdUsuarioResultado = SCOPE_IDENTITY()
		
	end
	else
		set @Mensaje = 'El Usuario  ya existe'


end

go

/* ---------- PROCEDIMIENTOS PARA EDITAR USUARIOS -----------------*/
create PROC SP_EDITARUSUARIO(
@IdUsuario int,
@UserName varchar(50),
@NombreCompleto varchar(100),
@Correo varchar(100),
@Clave varchar(100),
@IdRol int,
@Estado bit,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''


	if not exists(select * from USUARIO where UserName = @UserName and idusuario != @IdUsuario)
	begin
		update  usuario set
		UserName = @UserName,
		NombreCompleto = @NombreCompleto,
		Correo = @Correo,
		Clave = @Clave,
		IdRol = @IdRol,
		Estado = @Estado
		where IdUsuario = @IdUsuario

		set @Respuesta = 1
		
	end
	else
		set @Mensaje = 'No se puede repetir el usuario'


end
go

/* ---------- PROCEDIMIENTOS PARA ELIMINAR USUARIOS -----------------*/
create PROC SP_ELIMINARUSUARIO(
@IdUsuario int,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''
	declare @pasoreglas bit = 1

	IF EXISTS (SELECT * FROM SERVICIO S 
	INNER JOIN USUARIO U ON U.IdUsuario = S.IdUsuario
	INNER JOIN USUARIO U2 ON U2.IdUsuario = S.IdUAsignado
	WHERE (U.IDUSUARIO = @IdUsuario OR U2.IDUSUARIO = @IdUsuario)
	)
	BEGIN
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar el usuario, se encuentra relacionado a un Servicio\n' 
	END

	if(@pasoreglas = 1)
	begin
		delete from USUARIO where IdUsuario = @IdUsuario
		set @Respuesta = 1 
	end

end

go

/* ---------- PROCEDIMIENTOS PARA CLIENTE -----------------*/
/* ---------- PROCEDIMIENTOS PARA CREAR CLIENTE -----------------*/
create PROC sp_RegistrarCliente(
@Codigo varchar(50),
@RazonSocial varchar(50),
@Correo varchar(50),
@Telefono varchar(50),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)as
begin
	SET @Resultado = 0
	DECLARE @IDPERSONA INT 
	IF NOT EXISTS (SELECT * FROM CLIENTE WHERE Codigo = @Codigo)
	begin
		insert into CLIENTE(Codigo,RazonSocial,Correo,Telefono,Estado) values (
		@Codigo,@RazonSocial,@Correo,@Telefono,@Estado)

		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'El Cliente ' + @Codigo + ' - ' + @RazonSocial  + ' ya existe'
end

go

/* ---------- PROCEDIMIENTOS PARA MODIFICAR CLIENTE -----------------*/
create PROC sp_ModificarCliente(
@IdCliente int,
@Codigo varchar(50),
@RazonSocial varchar(50),
@Correo varchar(50),
@Telefono varchar(50),
@Estado bit,
@Resultado bit output,
@Mensaje varchar(500) output
)as
begin
	SET @Resultado = 1
	DECLARE @IDPERSONA INT 
	IF NOT EXISTS (SELECT * FROM CLIENTE WHERE Codigo = @Codigo and IdCliente != @IdCliente)
	begin
		update CLIENTE set
		Codigo = @Codigo,
		RazonSocial = @RazonSocial,
		Correo = @Correo,
		Telefono = @Telefono,
		Estado = @Estado
		where IdCliente = @IdCliente
	end
	else
	begin
		SET @Resultado = 0
		set @Mensaje = 'El cliente ya existe'
	end
end

GO
/* ---------- PROCEDIMIENTOS PARA USUARIOS -----------------*/
/* -----------PROCESOS PARA REGISTRAR UN SERVICIO---------- */
CREATE TYPE [dbo].[EMovimiento] AS TABLE(
	[IdUsuario] int NULL,
	[IdEstadoServicio] int null,
	[Bitacora] VARCHAR(500)
)


GO
CREATE PROCEDURE sp_RegistrarServicio(
@IdUsuario int,
@IdUAsignado int,
@CodigoServicio varchar (50),
@RazonSocial varchar(50),
@IdEstadoServicio int,
@Factura bit,
@HojaServicio bit,
@Descripcion varchar(500),
@DetalleMovimiento [EMovimiento] ReadOnly,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	
	begin try

		declare @IdServicio int = 0
		set @Resultado = 1
		set @Mensaje = ''

		begin transaction registro

		insert into SERVICIO(IdUsuario,IdUAsignado,RazonSocial,CodigoServicio,IdEstadoServicio,Factura,HojaServicio,Descripcion)
		values(@IdUsuario,@IdUAsignado,@RazonSocial,@CodigoServicio,@IdEstadoServicio,@Factura,@HojaServicio,@Descripcion)

		set @IdServicio = SCOPE_IDENTITY()

		insert into MOVIMIENTO(IdServicio,IdUsuario, IdEstadoServicio, Bitacora)
		select @IdServicio, IdUsuario, IdEstadoServicio, Bitacora from @DetalleMovimiento

		commit transaction registro


	end try
	begin catch
		set @Resultado = 0
		set @Mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch

end


GO

/* -----------PROCESOS PARA MODIFICAR UN SERVICIO---------- */
create PROC sp_ModificarServicio(
@IdServicio int,
@IdUAsignado int,
@IdEstadoServicio int,
@Descripcion varchar(500),
@Solucion varchar(500),
@Resultado bit output,
@Mensaje varchar(500) output
)as
begin
	SET @Resultado = 1
	DECLARE @IDPERSONA INT 
	IF EXISTS (SELECT * FROM SERVICIO WHERE IdServicio = @IdServicio)
	begin
		update Servicio set
		IdUAsignado = @IdUAsignado,
		IdEstadoServicio = @IdEstadoServicio,
		Descripcion = @Descripcion,
		Solucion = @Solucion
		where IdServicio = @IdServicio
	end
	else
	begin
		SET @Resultado = 0
		set @Mensaje = 'No se pudo actualizar el servicio'
	end

	IF(@Resultado != 0)
	BEGIN
		insert into Movimiento(IdServicio, IdUsuario, IdEstadoServicio, Bitacora) values (@IdServicio, @IdUAsignado, @IdEstadoServicio, @Solucion)
	end
	ELSE
	BEGIN
		SET @Resultado = 0
		set @Mensaje = 'No se pudo crear el Movimiento'
	end
end

GO

/* --------------- Inserciones preedefinidas --------------- */
insert into ESTADOSERVICIO(descripcion) values('Pendiente'),
											  ('Finalizado'),
                                              ('No Completado')

insert into Rol(Descripcion) values ('ADMINISTRADOR'),
                                    ('SUPERVISOR'),
									('VENTAS/COMPRAS'),
									('SOPORTE'),
									('DESARROLLO'),
									('COBRANZA')

insert into USUARIO(UserName, NombreCompleto, Correo, Clave, IdRol, Estado) 
values ('Admin', 'Adminstrador', '@gmail.com', 'w1whFM059LQ=', 1, 1), /* 123456 */
	   ('Super', 'Supervisor', '@gmail.com', '2IyLhUv5ltc=', 2, 1), /* 789 */
	   ('Ventas', 'Ventas', '@gmail.com', 'sLQmoonjf+w=', 3, 1), /* 123 */
       ('Soporte', 'Soporte', '@gmail.com', 'vanymv6+tZg=', 4, 1) /* 789456 */

insert into Permiso(IdRol, NombreMenu, Estado) 
	    /* ADMINISTRADOR */
values (1,	'menuUsuario', 1),
	   (1,	'menuServicio', 1),
       (1,	'menuClientes', 1),
       (1,	'menuConfiguracion', 1),
	   (1,	'menuAcercade', 1),
	   /*  SUPERVISOR  */
       (2,	'menuUsuario', 0),
       (2,	'menuServicio', 0),
       (2,	'menuClientes', 1),
       (2,	'menuConfiguracion', 1),
       (2, 	'menuAcercade', 1),
	   	/*  VENTAS/COMPRAS  */
       (3,	'menuUsuario', 0),
       (3,	'menuServicio', 1),
       (3,	'menuClientes', 1),
       (3,	'menuConfiguracion', 0),
       (3, 	'menuAcercade', 1),
	    /*  SOPORTE  */
       (4,	'menuUsuario', 0),
       (4,	'menuServicio', 1),
       (4,	'menuClientes', 0),
       (4,	'menuConfiguracion', 0),
       (4, 	'menuAcercade', 1),
	    /*  DESARROLLO  */
       (5,	'menuUsuario', 0),
       (5,	'menuServicio', 0),
       (5,	'menuClientes', 0),
       (5,	'menuConfiguracion', 0),
       (5, 	'menuAcercade', 1),
	    /*  COBRANZA  */
       (6,	'menuUsuario', 0),
       (6,	'menuServicio', 0),
       (6,	'menuClientes', 0),
       (6,	'menuConfiguracion', 0),
       (6, 	'menuAcercade', 1)