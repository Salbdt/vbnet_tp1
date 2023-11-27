Imports Datos
Imports Entidades

Public Class NUsuario

    Public Function Listar() As DataTable
        Try
            Dim datos As New DUsuario
            Dim tabla As New DataTable
            tabla = datos.Listar()
            Return tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Buscar(valor As String) As DataTable
        Try
            Dim datos As New DUsuario
            Dim tabla As New DataTable
            tabla = datos.Buscar(valor)
            Return tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Login(email As String, clave As String) As Usuario
        Try
            Dim usuario As New Usuario
            Dim datos As New DUsuario
            Dim tabla As New DataTable
            tabla = datos.Login(email, clave)

            If (tabla.Rows.Count > 0) Then
                usuario.Rol = New Rol
                usuario.Rol.IdRol = tabla.Rows(0).Item(0).ToString
                usuario.Rol.Nombre = tabla.Rows(0).Item(1).ToString
                usuario.Rol.Estado = tabla.Rows(0).Item(2).ToString
                usuario.IdUsuario = tabla.Rows(0).Item(3).ToString
                usuario.NombreUsuario = tabla.Rows(0).Item(4).ToString
                usuario.Avatar = tabla.Rows(0).Item(5).ToString
                usuario.Email = tabla.Rows(0).Item(6).ToString
                usuario.Estado = tabla.Rows(0).Item(7).ToString
                Return usuario
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Insertar(obj As Usuario, persona As DataTable) As Boolean
        Try
            Dim datos As New DUsuario
            datos.Insertar(obj, persona)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Actualizar(obj As Usuario) As Boolean
        Try
            Dim datos As New DUsuario
            datos.Actualizar(obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Eliminar(id As Integer) As Boolean
        Try
            Dim datos As New DUsuario
            datos.Eliminar(id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Desactivar(id As Integer) As Boolean
        Try
            Dim datos As New DUsuario
            datos.Desactivar(id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Activar(id As Integer) As Boolean
        Try
            Dim datos As New DUsuario
            datos.Activar(id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class