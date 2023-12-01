use redsocial_prueba;
go

insert into roles (nombre) values ('Administrador');
insert into roles (nombre) values ('Usuario');
go

create procedure roles_listar
as
select id_rol, nombre, descripcion
from roles
where estado = 1;
go

create procedure roles_listar_registro
as
select id_rol, nombre, descripcion
from roles
where nombre <> 'Administrador' and estado = 1;
go