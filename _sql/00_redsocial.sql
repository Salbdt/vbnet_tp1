create database redsocial_prueba;
go

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
	texto varchar(510) not null,
	imagen varchar(100),
	privacidad varchar(30) not null default 'Pública', -- Pública, Privada
	fecha datetime not null,
	fecha_modificacion datetime not null,
	FOREIGN KEY (id_usuario) REFERENCES usuarios (id_usuario)
);
go

-- Esto fue para corregir algo en la tabla, en este script no es necesario (a menos que se prefiera mejorar el nombre de la restricción)
-- alter table publicaciones add constraint df_privacidad default 'Pública' for privacidad;

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

--------------------------------------------------

create table contactos(
	id_contacto integer primary key identity, -- La clave primaria podría ser la convinación de contacto uno y dos
	id_contacto_uno integer not null,
	id_contacto_dos integer not null,
	tipo varchar(30) not null default 'Amigo', -- Amigo, Bloqueado
	fecha datetime not null,
	fecha_modificacion datetime not null,
);
go