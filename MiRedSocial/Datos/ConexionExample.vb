﻿Imports System.Data.SqlClient
Public Class ConexionExample
    Private _Base As String
    Private _Servidor As String
    Private _Usuario As String
    Private _Clave As String
    Private _Seguridad As Boolean = True 'Tipo de autentificación: true = Windows ; false = SQL Server
    Public conn As SqlConnection

    Public Property Base As String
        Get
            Return _Base
        End Get
        Set(value As String)
            _Base = value
        End Set
    End Property

    Public Property Servidor As String
        Get
            Return _Servidor
        End Get
        Set(value As String)
            _Servidor = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return _Usuario
        End Get
        Set(value As String)
            _Usuario = value
        End Set
    End Property

    Public Property Clave As String
        Get
            Return _Clave
        End Get
        Set(value As String)
            _Clave = value
        End Set
    End Property

    Public Property Seguridad As Boolean
        Get
            Return _Seguridad
        End Get
        Set(value As Boolean)
            _Seguridad = value
        End Set
    End Property

    Public Sub New()
        Me.Base = "xxx"
        Me.Servidor = Environ("computername") & "\SQLEXPRESS"
        Me.Usuario = ""
        Me.Clave = ""
        Me.conn = New SqlConnection(CrearCadena)
    End Sub

    Private Function CrearCadena() As String
        'Como hacer la cadena: https://www.connectionstrings.com/sql-server/
        Dim cadena As String
        cadena = "Server=" & Me.Servidor & "; Database=" & Me.Base & ";"
        If Me.Seguridad Then
            'Autentificación de Windows
            cadena = cadena & "Integrated Security= SSPI"
        Else
            'Autentificación de SQL Server
            cadena = cadena & "User Id=" & Me.Usuario & "; Password=" & Me.Clave & ";"
        End If
        Return cadena
    End Function
End Class