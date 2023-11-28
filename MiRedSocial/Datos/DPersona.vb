Imports System.Data.SqlClient
Imports Entidades

Public Class DPersona
    Inherits Conexion

    ' Listar, Buscar, Obtener
    ' Actualizar

    Public Function Listar() As DataTable
        Try
            Dim resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("personas_listar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            MyBase.conn.Open()
            resultado = comando.ExecuteReader()
            tabla.Load(resultado)
            MyBase.conn.Close()
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Buscar(valor As String) As DataTable
        Try
            Dim resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("personas_buscar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor
            MyBase.conn.Open()
            resultado = comando.ExecuteReader()
            tabla.Load(resultado)
            MyBase.conn.Close()
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(id As Integer) As DataTable
        Try
            Dim resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("personas_obtener", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@id_persona", SqlDbType.VarChar).Value = id
            MyBase.conn.Open()
            resultado = comando.ExecuteReader()
            tabla.Load(resultado)
            MyBase.conn.Close()
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Actualizar(Obj As Persona, email As String, clave As String) As DataTable
        Try
            Dim resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("personas_actualizar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@id_persona", SqlDbType.Int).Value = Obj.IdPersona
            comando.Parameters.Add("@id_usuario", SqlDbType.Int).Value = Obj.IdUsuario
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre
            comando.Parameters.Add("@apellido", SqlDbType.VarChar).Value = Obj.Apellido
            comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = Obj.TipoDocumento
            comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = Obj.NumDocumento
            comando.Parameters.Add("@domicilio", SqlDbType.VarChar).Value = Obj.Domicilio
            comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = Obj.Telefono
            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = email
            comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = clave
            MyBase.conn.Open()
            resultado = comando.ExecuteReader()
            tabla.Load(resultado)
            MyBase.conn.Close()
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class