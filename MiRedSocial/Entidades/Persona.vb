Public Class Persona
    Private _idPersona As Integer
    Private _idUsuario As Integer
    Private _nombre As String
    Private _apellido As String
    Private _tipoDocumento As String
    Private _numDocumento As String
    Private _domicilio As String
    Private _telefono As String

    Public Property IdPersona As Integer
        Get
            Return _idPersona
        End Get
        Set(value As Integer)
            _idPersona = value
        End Set
    End Property

    Public Property IdUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(value As Integer)
            _idUsuario = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property TipoDocumento As String
        Get
            Return _tipoDocumento
        End Get
        Set(value As String)
            _tipoDocumento = value
        End Set
    End Property

    Public Property NumDocumento As String
        Get
            Return _numDocumento
        End Get
        Set(value As String)
            _numDocumento = value
        End Set
    End Property

    Public Property Domicilio As String
        Get
            Return _domicilio
        End Get
        Set(value As String)
            _domicilio = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property
End Class