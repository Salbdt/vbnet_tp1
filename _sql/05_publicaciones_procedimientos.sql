-- Procedimiento Listar
create procedure publicaciones_listar
as
	select p.id_publicacion, p.id_usuario, p.texto, p.imagen,
		p.privacidad, p.fecha, p.fecha_modificacion,
		u.nombre_usuario as usuario, u.avatar, r.nombre as rol
	from publicaciones p 
		inner join usuarios u on p.id_usuario = u.id_usuario
		inner join roles r on u.id_rol = r.id_rol
	order by fecha desc;
go

-- Procedimiento Buscar_Fecha
create procedure publicaciones_buscar_fecha
@id_usuario integer,
@fecha_inicio datetime,
@fecha_fin datetime
as
	select p.id_publicacion, p.id_usuario, p.texto, p.imagen,
		p.privacidad, p.fecha, p.fecha_modificacion,
		u.nombre_usuario as usuario, u.avatar, r.nombre as rol
	from publicaciones p 
		inner join usuarios u on p.id_usuario = u.id_usuario
		inner join roles r on u.id_rol = r.id_rol
	where p.id_usuario = @id_usuario and p.fecha between @fecha_inicio and @fecha_fin
	order by fecha desc;
go


-- Procedimiento Buscar_Usuario
create procedure publicaciones_buscar_usuario
@id_usuario integer
as
	select p.id_publicacion, p.id_usuario, p.texto, p.imagen,
		p.privacidad, p.fecha, p.fecha_modificacion,
		u.nombre_usuario as usuario, u.avatar, r.nombre as rol
	from publicaciones p 
		inner join usuarios u on p.id_usuario = u.id_usuario
		inner join roles r on u.id_rol = r.id_rol
	where p.id_usuario = @id_usuario
	order by fecha desc;
go

-- Procedimiento Insertar
create procedure publicaciones_insertar
@id_publicacion integer output,
@id_usuario integer,
@texto varchar(510),
@imagen varchar(100),
@privacidad varchar(30)
as
begin
	insert into publicaciones (id_usuario, texto, imagen, privacidad, fecha, fecha_modificacion)
	values (@id_usuario, @texto, @imagen, @privacidad, GETDATE(), GETDATE());
end
go

-- Procedimiento Actualizar
create procedure publicaciones_actualizar
@id_publicacion integer,
@id_usuario integer, -- Id del usuario que quiere actualizar la publicación
@texto varchar(510),
@imagen varchar(100),
@privacidad varchar(30)
as
begin
	update publicaciones
	set
		texto = @texto,
		imagen = @imagen,
		privacidad = @privacidad
	where id_publicacion = @id_publicacion and id_usuario = @id_usuario;
end
go

-- Procedimiento Eliminar
create procedure publicaciones_eliminar
@id_publicacion integer,
@id_usuario integer
as
	delete from publicaciones
	where id_publicacion = @id_publicacion and id_usuario = @id_usuario;
go