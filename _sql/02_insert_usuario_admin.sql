/*
	Insertar usuario Admin
	Email: admin@mail.com
	Clave: 123
*/
insert into usuarios (id_rol, nombre_usuario, email, clave)
values (1, 'Admin', 'admin@mail.com', HASHBYTES('SHA2_256', '123'));