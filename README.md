# vbnet_tp1
VB.NET, Windows Forms, SQL Server, CRUD

- Para crear la BD ejecutar los scripts de la carpeta "_sql"

- Para conectar a la BD
	- Renombrar ConexionExample.vb por Conexion.vb
	- Poner los nombres correctos de la BD, Usuario y Clave del servidor SQL Server

Funcionalidades de la aplicación
- Podemos registrarnos, iniciar y cerrar sesión.
- Los usuarios están separados por roles
- Podemos actualizar nuestros datos (uno de ellos es una imagen para el avatar).
- El admin puede modificar los datos de todos.

- Tenemos un muro personal de publicaciones (todavía no se implementó la parte de amigos)
- Solo vemos nuestras publicaciones, podemos crear, editar y eliminar publicaciones.
- La publicación puede ser solo texto o tener una imagen.

Funcionalidades no alcanzadas
- Sistema de amigos o seguimiento para poder ver el muro de otra persona
	- Seguir o añadir amigo con notifiación o mensaje privado para confirmar
	- Bloquear usuario para que no pueda ver mis publicaciones
- Sistema de mensajes privados, similar a la publicación exclusiva entre dos usuarios
