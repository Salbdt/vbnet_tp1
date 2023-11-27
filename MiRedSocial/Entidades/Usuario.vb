Public Class Usuario
    Private _idUsuario As Integer
    Private _rol As Rol
    Private _nombreUsuario As String
    Private _email As String
    Private _clave As String
    Private _avatar As String
    Private _estado As Boolean

    Public Property IdUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(value As Integer)
            _idUsuario = value
        End Set
    End Property

    Public Property Rol As Rol
        Get
            Return _rol
        End Get
        Set(value As Rol)
            _rol = value
        End Set
    End Property

    Public Property NombreUsuario As String
        Get
            Return _nombreUsuario
        End Get
        Set(value As String)
            _nombreUsuario = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Clave As String
        Get
            Return _clave
        End Get
        Set(value As String)
            _clave = value
        End Set
    End Property

    Public Property Avatar As String
        Get
            Return _avatar
        End Get
        Set(value As String)
            _avatar = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property
End Class