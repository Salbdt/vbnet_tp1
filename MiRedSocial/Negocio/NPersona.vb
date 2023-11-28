Imports Datos
Imports Entidades

Public Class NPersona

    Public Function Listar() As DataTable
        Try
            Dim datos As New DPersona
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
            Dim datos As New DPersona
            Dim tabla As New DataTable
            tabla = datos.Buscar(valor)
            Return tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Obtener(id As Integer) As Persona
        Try
            Dim persona As New Persona
            Dim datos As New DPersona
            Dim tabla As New DataTable
            tabla = datos.Obtener(id)

            If (tabla.Rows.Count > 0) Then
                persona.IdUsuario = tabla.Rows(0).Item(0).ToString
                persona.IdPersona = tabla.Rows(0).Item(1).ToString
                persona.Nombre = tabla.Rows(0).Item(2).ToString
                persona.Apellido = tabla.Rows(0).Item(3).ToString
                persona.TipoDocumento = tabla.Rows(0).Item(4).ToString
                persona.NumDocumento = tabla.Rows(0).Item(5).ToString
                persona.Domicilio = tabla.Rows(0).Item(6).ToString
                persona.Telefono = tabla.Rows(0).Item(7).ToString
                Return persona
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Actualizar(obj As Persona, email As String, clave As String) As Boolean
        Try
            Dim datos As New DPersona
            Dim tabla As New DataTable
            tabla = datos.Actualizar(obj, email, clave)

            If (tabla.Rows.Count > 0) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class