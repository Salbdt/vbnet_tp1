Imports Datos

Public Class NRol
    Public Function Listar() As DataTable
        Try
            Dim datos As New DRol
            Dim tabla As New DataTable
            tabla = datos.Listar()
            Return tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class