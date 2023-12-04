use redsocial_prueba;
go

--Procedimiento Listar
create procedure usuarios_listar
as
	select u.id_rol, r.nombre as rol, r.estado as estado_rol,
		u.id_usuario, u.nombre_usuario, u.avatar, u.email, u.estado
	from usuarios u inner join roles r on u.id_rol = r.id_rol
	order by u.id_usuario desc
go

--Procedimiento Obtener
create procedure usuarios_obtener
@id_usuario integer
as
	select u.id_rol, r.nombre as rol, r.estado as estado_rol,
		u.id_usuario, u.nombre_usuario, u.avatar, u.email, u.estado
	from usuarios u inner join roles r on u.id_rol = r.id_rol
	where u.id_usuario = @id_usuario
go

--Procedimiento Buscar
create procedure usuarios_buscar
@valor varchar(50)
as
	select u.id_rol, r.nombre as rol, r.estado as estado_rol,
		u.id_usuario, u.nombre_usuario, u.avatar, u.email, u.estado
	from usuarios u inner join roles r on u.id_rol = r.id_rol
	where u.nombre_usuario like '%' + @valor + '%' or u.email like '%' + @valor + '%'
	order by u.nombre_usuario asc
go

-- Table type personas
create type type_persona as table
(
	nombre varchar(100),
	apellido varchar(100),
	tipo_documento varchar(20),
	num_documento varchar(20),
	domicilio varchar(100),
	telefono varchar(20)
);
go

--Procedimiento Insertar
create procedure usuarios_insertar
@id_usuario integer output,
@id_rol integer,
@nombre_usuario varchar(100),
@email varchar(50),
@avatar varchar(100),
@clave varchar(50),
@persona type_persona readonly
as
begin
	-- insert usuarios
	insert into usuarios (id_rol, nombre_usuario, email, avatar, clave)
	values (@id_rol, @nombre_usuario, @email, @avatar, hashbytes('SHA2_256', @clave));

	set @id_usuario = @@identity

	-- insert personas
	insert into personas (id_usuario, nombre, apellido, tipo_documento, num_documento, domicilio, telefono)
	select @id_usuario, p.nombre, p.apellido, p.tipo_documento, p.num_documento, p.domicilio, p.telefono
	from @persona p
end;
go

--Procedimiento Actualizar
create procedure usuarios_actualizar
@id_usuario integer,
@id_rol integer,
@nombre_usuario varchar(100),
@email varchar(50),
@email_nuevo varchar(50),
@avatar varchar(100),
@clave varchar(50),
@clave_nueva varchar(50)
as
begin
	select id_usuario from usuarios
	where id_usuario = @id_usuario and email = @email and clave = hashbytes('SHA2_256', @clave);

	update usuarios set
	id_rol = @id_rol,
	nombre_usuario = @nombre_usuario,
	avatar = @avatar
	where id_usuario = @id_usuario and email = @email and clave = hashbytes('SHA2_256', @clave);

	if @clave_nueva <> ''
	begin
		update usuarios set
		clave = hashbytes('SHA2_256', @clave_nueva)
		where id_usuario = @id_usuario and email = @email and clave = hashbytes('SHA2_256', @clave);
	end

	if @email_nuevo <> ''
	begin
		update usuarios set
		email = @email_nuevo
		where id_usuario = @id_usuario and email = @email and clave = hashbytes('SHA2_256', @clave);
	end
end
go

--Procedimiento Eliminar
create procedure usuarios_eliminar
@id_usuario integer
as
	delete from personas
	where id_usuario = @id_usuario;
	
	delete from usuarios
	where id_usuario = @id_usuario;

go

--Procedimiento Desactivar
create procedure usuarios_desactivar
@id_usuario integer
as
	update usuarios set estado = 0
	where id_usuario = @id_usuario
go

--Procedimiento Activar
create procedure usuarios_activar
@id_usuario integer
as
	update usuarios set estado = 1
	where id_usuario = @id_usuario
go

--Procedimiento login
create procedure usuarios_login
@email varchar(50),
@clave varchar(50)
as
	select u.id_rol, r.nombre as rol, r.estado,
		u.id_usuario, u.nombre_usuario as usuario, u.avatar, u.email, u.estado
	from usuarios u inner join roles r on u.id_rol = r.id_rol
	where u.email = @email and u.clave = hashbytes('SHA2_256', @clave)
go