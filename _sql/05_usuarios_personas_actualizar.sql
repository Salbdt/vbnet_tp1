use redsocial_prueba;
go

create procedure usuarios_personas_actualizar
@id_usuario integer,
@id_rol integer,
@nombre_usuario varchar(100),
@email varchar(50),
@avatar varchar(100),
@clave varchar(50),
@id_persona integer,
@nombre varchar(100),
@apellido varchar(100),
@tipo_documento varchar(20),
@num_documento varchar(20),
@domicilio varchar(100),
@telefono varchar(20)
as
begin
	select * from usuarios u inner join personas p on u.id_usuario = p.id_usuario
	where u.id_usuario = @id_usuario and p.id_persona = @id_persona;

	-- Actualizamos el usuario
	update usuarios set	id_rol = @id_rol where id_usuario = @id_usuario;

	if @nombre_usuario <> ''
	begin
		update usuarios set	nombre_usuario = @nombre_usuario where id_usuario = @id_usuario;
	end

	if @email <> ''
	begin
		update usuarios set email = @email where id_usuario = @id_usuario;
	end

	if @avatar <> ''
	begin
		update usuarios set	avatar = @avatar where id_usuario = @id_usuario;
	end

	if @clave <> ''
	begin
		update usuarios set	clave = hashbytes('SHA2_256', @clave) where id_usuario = @id_usuario;
	end

	-- Actualizamos la persona
	if @nombre <> ''
	begin
		update personas set	nombre = @nombre where id_usuario = @id_usuario and id_persona = @id_persona;
	end

	if @apellido <> ''
	begin
		update personas set	apellido = @apellido where id_usuario = @id_usuario and id_persona = @id_persona;
	end

	if @tipo_documento <> ''
	begin
		update personas set	tipo_documento = @tipo_documento where id_usuario = @id_usuario and id_persona = @id_persona;
	end

	if @num_documento <> ''
	begin
		update personas set	num_documento = @num_documento where id_usuario = @id_usuario and id_persona = @id_persona;
	end

	if @domicilio <> ''
	begin
		update personas set	domicilio = @domicilio where id_usuario = @id_usuario and id_persona = @id_persona;
	end

	if @telefono <> ''
	begin
		update personas set	telefono = @telefono where id_usuario = @id_usuario and id_persona = @id_persona;
	end
end
go