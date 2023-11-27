use redsocial_prueba;
go

create table roles (
	id_rol integer primary key identity,
	nombre varchar(30) not null,
	descripcion varchar(255) null,
	estado bit default(1)
);
go

create table usuarios(
	id_usuario integer primary key identity,
	id_rol integer not null,
	nombre_usuario varchar(100) not null,
	email varchar(50) not null,
	clave varbinary(MAX) not null,
	avatar varchar(100) null,
	estado bit default(1),
	FOREIGN KEY (id_rol) REFERENCES roles (id_rol)
);
go

create table personas(
	id_persona integer primary key identity,
	id_usuario integer not null,
	nombre varchar(100) not null,
	apellido varchar(100) not null,
	tipo_documento varchar(20) null,
	num_documento varchar(20) null,
	domicilio varchar(100) null,
	telefono varchar(20) null,
	FOREIGN KEY (id_usuario) REFERENCES usuarios (id_usuario)
);
go

--------------------------------------------------

create table publicaciones(
	id_publicacion integer primary key identity,
	id_usuario integer not null,
	texto varchar(510),
	imagen varchar(100),
	privacidad varchar(30), -- público, privado
	fecha datetime not null,
	fecha_modificacion datetime not null,
	FOREIGN KEY (id_usuario) REFERENCES usuarios (id_usuario)
);
go

create table mensajes_privados(
	id_mensaje integer primary key identity,
	id_remitente integer not null,
	id_destinatario integer not null,
	texto varchar(510),
	fecha datetime not null,
	fecha_modificacion datetime not null,
	FOREIGN KEY (id_remitente) REFERENCES usuarios (id_usuario),
	FOREIGN KEY (id_destinatario) REFERENCES usuarios (id_usuario)
);
go