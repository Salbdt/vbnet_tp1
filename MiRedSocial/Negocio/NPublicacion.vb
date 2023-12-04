Imports Datos
Imports Entidades

Public Class NPublicacion

    Public Function Listar() As DataTable
        Try
            Dim datos As New DPublicacion
            Dim tabla As New DataTable
            tabla = datos.Listar()
            Return tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function Obtener(id As Integer) As Publicacion
        Try
            Dim datos As New DPublicacion
            Dim tabla As New DataTable
            Dim publicacion As New Publicacion
            tabla = datos.Obtener(id)
            If (tabla.Rows.Count > 0) Then
                publicacion.IdPublicacion = tabla.Rows(0).Item(0).ToString
                publicacion.IdUsuario = tabla.Rows(0).Item(1).ToString
                publicacion.Texto = tabla.Rows(0).Item(2).ToString
                publicacion.Imagen = tabla.Rows(0).Item(3).ToString
                publicacion.Privacidad = tabla.Rows(0).Item(4).ToString
                publicacion.Fecha = tabla.Rows(0).Item(5).ToString
                publicacion.FechaModificacion = tabla.Rows(0).Item(6).ToString
                Return publicacion
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function BuscarFecha(fechaInicio As DateTime, fechaModificacion As DateTime) As DataTable
        Try
            Dim datos As New DPublicacion
            Dim tabla As New DataTable
            tabla = datos.BuscarFecha(fechaInicio, fechaModificacion)
            Return tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function BuscarUsuario(id As Integer) As DataTable
        Try
            Dim datos As New DPublicacion
            Dim tabla As New DataTable
            tabla = datos.BuscarUsuario(id)
            Return tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Insertar(obj As Publicacion) As Boolean
        Try
            Dim datos As New DPublicacion
            datos.Insertar(obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Actualizar(obj As Publicacion) As Boolean
        Try
            Dim datos As New DPublicacion
            datos.Actualizar(obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Eliminar(id As Integer) As Boolean
        Try
            Dim datos As New DPublicacion
            datos.Eliminar(id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class