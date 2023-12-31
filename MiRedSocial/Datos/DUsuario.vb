﻿Imports System.Data.SqlClient
Imports Entidades

Public Class DUsuario
    Inherits Conexion

    ' Listar, Buscar, Obtener
    ' Login
    ' Insertar, Actualizar
    ' Eliminar, Desactivar, Activar

    Public Function Listar() As DataTable
        Try
            Dim resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("usuarios_listar", MyBase.conn)
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
            Dim comando As New SqlCommand("usuarios_buscar", MyBase.conn)
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
            Dim comando As New SqlCommand("usuarios_obtener", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@id_usuario", SqlDbType.VarChar).Value = id
            MyBase.conn.Open()
            resultado = comando.ExecuteReader()
            tabla.Load(resultado)
            MyBase.conn.Close()
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Login(email As String, clave As String) As DataTable
        Try
            Dim resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("usuarios_login", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
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

    Public Sub Insertar(obj As Usuario, persona As DataTable)
        Try
            Dim comando As New SqlCommand("usuarios_insertar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@id_usuario", SqlDbType.Int).Value = obj.IdUsuario
            comando.Parameters("@id_usuario").Direction = ParameterDirection.Output
            comando.Parameters.Add("@id_rol", SqlDbType.Int).Value = obj.Rol.IdRol
            comando.Parameters.Add("@nombre_usuario", SqlDbType.VarChar).Value = obj.NombreUsuario
            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.Email
            comando.Parameters.Add("@avatar", SqlDbType.VarChar).Value = obj.Avatar
            comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = obj.Clave
            comando.Parameters.Add("@persona", SqlDbType.Structured).Value = persona
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function Actualizar(Obj As Usuario, emailNuevo As String, claveNueva As String) As DataTable
        Try
            Dim resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("usuarios_actualizar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@id_usuario", SqlDbType.Int).Value = Obj.IdUsuario
            comando.Parameters.Add("@id_rol", SqlDbType.Int).Value = Obj.Rol.IdRol
            comando.Parameters.Add("@nombre_usuario", SqlDbType.VarChar).Value = Obj.NombreUsuario
            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Obj.Email
            comando.Parameters.Add("@email_nuevo", SqlDbType.VarChar).Value = emailNuevo
            comando.Parameters.Add("@avatar", SqlDbType.VarChar).Value = Obj.Avatar
            comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = Obj.Clave
            comando.Parameters.Add("@clave_nueva", SqlDbType.VarChar).Value = claveNueva
            MyBase.conn.Open()
            resultado = comando.ExecuteReader()
            tabla.Load(resultado)
            MyBase.conn.Close()
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Actualizar(obj As Usuario, persona As Persona) As DataTable
        Try
            Dim resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("usuarios_personas_actualizar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@id_usuario", SqlDbType.Int).Value = obj.IdUsuario
            comando.Parameters.Add("@id_rol", SqlDbType.Int).Value = obj.Rol.IdRol
            comando.Parameters.Add("@nombre_usuario", SqlDbType.VarChar).Value = obj.NombreUsuario
            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.Email
            comando.Parameters.Add("@avatar", SqlDbType.VarChar).Value = obj.Avatar
            comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = obj.Clave
            comando.Parameters.Add("@id_persona", SqlDbType.Int).Value = persona.IdPersona
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = persona.Nombre
            comando.Parameters.Add("@apellido", SqlDbType.VarChar).Value = persona.Apellido
            comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = persona.TipoDocumento
            comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = persona.NumDocumento
            comando.Parameters.Add("@domicilio", SqlDbType.VarChar).Value = persona.Domicilio
            comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = persona.Telefono
            MyBase.conn.Open()
            resultado = comando.ExecuteReader()
            tabla.Load(resultado)
            MyBase.conn.Close()
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Eliminar(id As Integer)
        Try
            Dim comando As New SqlCommand("usuarios_eliminar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@id_usuario", SqlDbType.Int).Value = id
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Desactivar(id As Integer)
        Try
            Dim comando As New SqlCommand("usuarios_desactivar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@id_usuario", SqlDbType.Int).Value = id
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Activar(id As Integer)
        Try
            Dim comando As New SqlCommand("usuarios_activar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@id_usuario", SqlDbType.Int).Value = id
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class