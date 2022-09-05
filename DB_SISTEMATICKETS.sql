CREATE DATABASE DB_SISTEMATICKETS

GO

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
	Documento varchar(50),
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
	IdCliente int references CLIENTE(IdCliente),
	Factura bit,
	HojaServicio bit,
	IdEstadoServicio int references ESTADOSERVICIO(IdEstadoServicio),
	Bitacora varchar(250),
	Descripcion varchar(250),
	Solucion varchar(250),
	FechaRegistro datetime default getdate()
)

GO

CREATE TABLE MOVIMIENTO(
	IdMovimiento int primary key identity,
	IdServicio int references SERVICIO(IdServicio),
	IdUsuario int references USUARIO(IdUsuario),
	FechaRegistro datetime default getdate()
)

GO

/*************************** CREACION DE PROCEDIMIENTOS ALMACENADOS ***************************/
/*--------------------------------------------------------------------------------------------*/

go

/* ---------- PROCEDIMIENTOS PARA USUARIOS -----------------*/

/* ---------- PROCEDIMIENTOS PARA CREAR USUARIOS -----------------*/
create PROC SP_REGISTRARUSUARIO(
@Documento varchar(50),
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


	if not exists(select * from USUARIO where Documento = @Documento)
	begin
		insert into usuario(Documento,NombreCompleto,Correo,Clave,IdRol,Estado) values
		(@Documento,@NombreCompleto,@Correo,@Clave,@IdRol,@Estado)

		set @IdUsuarioResultado = SCOPE_IDENTITY()
		
	end
	else
		set @Mensaje = 'No se puede repetir el usuario'


end

go

/* ---------- PROCEDIMIENTOS PARA EDITAR USUARIOS -----------------*/
create PROC SP_EDITARUSUARIO(
@IdUsuario int,
@Documento varchar(50),
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


	if not exists(select * from USUARIO where Documento = @Documento and idusuario != @IdUsuario)
	begin
		update  usuario set
		Documento = @Documento,
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
		set @Mensaje = 'El cliente ya existe'
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
	[IdUsuario] int NULL
)


GO
CREATE PROCEDURE sp_RegistrarServicio(
@IdUsuario int,
@IdUAsignado int,
@IdCliente int,
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

		insert into SERVICIO(IdUsuario,IdUAsignado,IdCliente,IdEstadoServicio,Factura,HojaServicio,Descripcion)
		values(@IdUsuario,@IdUAsignado,@IdCliente,@IdEstadoServicio,@Factura,@HojaServicio,@Descripcion)

		set @IdServicio = SCOPE_IDENTITY()

		insert into MOVIMIENTO(IdServicio,IdUsuario)
		select @IdServicio, IdUsuario from @DetalleMovimiento

		commit transaction registro


	end try
	begin catch
		set @Resultado = 0
		set @Mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch

end


GO

/**/
insert into ESTADOSERVICIO(descripcion) values('Pendiente')
insert into ESTADOSERVICIO(descripcion) values('Finalizado')
insert into ESTADOSERVICIO(descripcion) values('No Completado')
