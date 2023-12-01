Imports Datos

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

End Class