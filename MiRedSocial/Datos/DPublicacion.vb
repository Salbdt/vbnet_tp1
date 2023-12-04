Imports System.Data.SqlClient
Imports Entidades

Public Class DPublicacion
    Inherits Conexion

    ' Listar
    ' BuscarFecha, BuscarUsuario
    ' Insertar, Actualizar
    ' Eliminar

    Public Function Listar() As DataTable
        Try
            Dim resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("publicaciones_listar", MyBase.conn)
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

    Public Function Obtener(id As Integer) As DataTable
        Try
            Dim resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("publicaciones_obtener", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@id_publicacion", SqlDbType.Int).Value = id
            MyBase.conn.Open()
            resultado = comando.ExecuteReader()
            tabla.Load(resultado)
            MyBase.conn.Close()
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarFecha(fechaInicio As DateTime, fechaModificacion As DateTime) As DataTable
        Try
            Dim resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("publicaciones_buscar_fecha", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@fecha_inicio", SqlDbType.DateTime).Value = fechaInicio
            comando.Parameters.Add("@fecha_modificacion", SqlDbType.DateTime).Value = fechaModificacion
            MyBase.conn.Open()
            resultado = comando.ExecuteReader()
            tabla.Load(resultado)
            MyBase.conn.Close()
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarUsuario(id As Integer) As DataTable
        Try
            Dim resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("publicaciones_buscar_usuario", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@id_usuario", SqlDbType.Int).Value = id
            MyBase.conn.Open()
            resultado = comando.ExecuteReader()
            tabla.Load(resultado)
            MyBase.conn.Close()
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Insertar(obj As Publicacion)
        Try
            Dim comando As New SqlCommand("publicaciones_insertar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@id_publicacion", SqlDbType.Int).Value = obj.IdPublicacion
            comando.Parameters("@id_publicacion").Direction = ParameterDirection.Output
            comando.Parameters.Add("@id_usuario", SqlDbType.Int).Value = obj.IdUsuario
            comando.Parameters.Add("@texto", SqlDbType.VarChar).Value = obj.Texto
            comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = obj.Imagen
            comando.Parameters.Add("@privacidad", SqlDbType.VarChar).Value = obj.Privacidad
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Actualizar(obj As Publicacion)
        Try
            Dim comando As New SqlCommand("publicaciones_actualizar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@id_publicacion", SqlDbType.Int).Value = obj.IdPublicacion
            comando.Parameters.Add("@texto", SqlDbType.VarChar).Value = obj.Texto
            comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = obj.Imagen
            comando.Parameters.Add("@privacidad", SqlDbType.VarChar).Value = obj.Privacidad
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(id As Integer)
        Try
            Dim comando As New SqlCommand("publicaciones_eliminar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@id_publicacion", SqlDbType.Int).Value = id
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class