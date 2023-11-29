use redsocial_prueba;
go

--Procedimiento Listar
create procedure personas_listar
as
	select p.id_usuario, p.id_persona, p.nombre, p.apellido,
		p.tipo_documento, p.num_documento, p.domicilio, p.telefono
	from personas p
	order by p.id_persona desc
go

--Procedimiento Buscar
create procedure personas_buscar
@valor varchar(50)
as
	select p.id_usuario, p.id_persona, p.nombre, p.apellido,
		p.tipo_documento, p.num_documento, p.domicilio, p.telefono
	from personas p
	where p.nombre like '%' + @valor + '%' or p.apellido like '%' + @valor + '%'
		or p.num_documento like '%' + @valor + '%' or p.domicilio like '%' + @valor + '%'
	order by p.id_persona desc
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
	where p.id_persona = @id_persona
	and u.email = @email and u.clave = hashbytes('SHA2_256', @clave);

	update personas	set
	nombre = @nombre,
	apellido = @apellido,
	tipo_documento = @tipo_documento,
	num_documento = @num_documento
	from personas p inner join usuarios u on p.id_usuario = u.id_usuario
	where p.id_persona = @id_persona
	and u.email = @email and u.clave = hashbytes('SHA2_256', @clave);
end
go