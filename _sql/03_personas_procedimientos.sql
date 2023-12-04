use redsocial_prueba;
go

--Procedimiento Listar
create procedure personas_listar
as
	select id_usuario, id_persona, nombre, apellido,
		tipo_documento, num_documento, domicilio, telefono
	from personas
	order by id_persona desc
go

--Procedimiento Listar Amigos
create procedure personas_listar_amigos
as
	select p.id_usuario, p.id_persona, p.nombre, p.apellido,
		p.tipo_documento, p.num_documento, p.domicilio, p.telefono
	from personas p
	inner join contactos c on p.id_usuario = c.id_contacto_uno
	where c.tipo = 'Amigo'
	order by nombre asc
go

--Procedimiento Listar Bloqueados
create procedure personas_listar_bloqueados
as
	select p.id_usuario, p.id_persona, p.nombre, p.apellido,
		p.tipo_documento, p.num_documento, p.domicilio, p.telefono
	from personas p
	inner join contactos c on p.id_usuario = c.id_contacto_uno
	where c.tipo = 'Bloqueado'
	order by nombre asc
go

--Procedimiento Buscar
create procedure personas_buscar
@valor varchar(50)
as
	select id_usuario, id_persona, nombre, apellido,
		tipo_documento, num_documento, domicilio, telefono
	from personas
	where nombre like '%' + @valor + '%' or apellido like '%' + @valor + '%'
		or num_documento like '%' + @valor + '%' or domicilio like '%' + @valor + '%'
	order by id_persona desc
go

--Procedimiento Buscar Amigos
create procedure personas_buscar_amigos
@valor varchar(50)
as
	select p.id_usuario, p.id_persona, p.nombre, p.apellido,
		p.tipo_documento, p.num_documento, p.domicilio, p.telefono
	from personas p
	inner join contactos c on p.id_usuario = c.id_contacto_uno
	where c.tipo = 'Amigo' and p.nombre like '%' + @valor + '%' or p.apellido like '%' + @valor + '%'
		or p.num_documento like '%' + @valor + '%' or p.domicilio like '%' + @valor + '%'
	order by nombre asc
go

--Procedimiento Buscar Bloqueados
create procedure personas_buscar_bloqueados
@valor varchar(50)
as
	select p.id_usuario, p.id_persona, p.nombre, p.apellido,
		p.tipo_documento, p.num_documento, p.domicilio, p.telefono
	from personas p
	inner join contactos c on p.id_usuario = c.id_contacto_uno
	where c.tipo = 'Bloqueado' and p.nombre like '%' + @valor + '%' or p.apellido like '%' + @valor + '%'
		or p.num_documento like '%' + @valor + '%' or p.domicilio like '%' + @valor + '%'
	order by nombre asc
go

--Procedimiento Obtener
create procedure personas_obtener
@id_usuario int
as
	select p.id_usuario, p.id_persona, p.nombre, p.apellido,
		p.tipo_documento, p.num_documento, p.domicilio, p.telefono
	from personas p inner join usuarios u on p.id_usuario = u.id_usuario
	where p.id_usuario = @id_usuario
	order by p.id_persona desc
go

--Procedimiento Actualizar
create procedure personas_actualizar
@id_persona integer,
@id_usuario integer,
@nombre varchar(100),
@apellido varchar(100),
@tipo_documento varchar(20),
@num_documento varchar(20),
@domicilio varchar(100),
@telefono varchar(20),
@email varchar(50),
@clave varchar(50)
as
begin
	select p.id_persona from personas p
	inner join usuarios u on p.id_usuario = u.id_usuario
	where p.id_persona = @id_persona and p.id_usuario = @id_usuario
	and u.email = @email and u.clave = hashbytes('SHA2_256', @clave);

	-- Actualizamos la persona
	if @nombre <> ''
	begin
		update personas set	nombre = @nombre
		from personas p inner join usuarios u on p.id_usuario = u.id_usuario
		where p.id_usuario = @id_usuario and p.id_persona = @id_persona
		and u.email = @email and u.clave = hashbytes('SHA2_256', @clave);
	end

	if @apellido <> ''
	begin
		update personas set	apellido = @apellido
		from personas p inner join usuarios u on p.id_usuario = u.id_usuario
		where p.id_usuario = @id_usuario and p.id_persona = @id_persona
		and u.email = @email and u.clave = hashbytes('SHA2_256', @clave);
	end

	if @tipo_documento <> ''
	begin
		update personas set	tipo_documento = @tipo_documento
		from personas p inner join usuarios u on p.id_usuario = u.id_usuario
		where p.id_usuario = @id_usuario and p.id_persona = @id_persona
		and u.email = @email and u.clave = hashbytes('SHA2_256', @clave);
	end

	if @num_documento <> ''
	begin
		update personas set	num_documento = @num_documento
		from personas p inner join usuarios u on p.id_usuario = u.id_usuario
		where p.id_usuario = @id_usuario and p.id_persona = @id_persona
		and u.email = @email and u.clave = hashbytes('SHA2_256', @clave);
	end

	if @domicilio <> ''
	begin
		update personas set	domicilio = @domicilio
		from personas p inner join usuarios u on p.id_usuario = u.id_usuario
		where p.id_usuario = @id_usuario and p.id_persona = @id_persona
		and u.email = @email and u.clave = hashbytes('SHA2_256', @clave);
	end

	if @telefono <> ''
	begin
		update personas set	telefono = @telefono
		from personas p inner join usuarios u on p.id_usuario = u.id_usuario
		where p.id_usuario = @id_usuario and p.id_persona = @id_persona
		and u.email = @email and u.clave = hashbytes('SHA2_256', @clave);
	end
end
go