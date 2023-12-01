Public Class Publicacion
    Private _idPublicacion As Integer
	Private _idUsuario As Integer
	Private _texto As String
	Private _imagen As String
	Private _privacidad As String
	Private _fecha As DateTime
	Private _fechaModificacion As DateTime

    Public Property IdPublicacion As Integer
        Get
            Return _idPublicacion
        End Get
        Set(value As Integer)
            _idPublicacion = value
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

    Public Property Texto As String
        Get
            Return _texto
        End Get
        Set(value As String)
            _texto = value
        End Set
    End Property

    Public Property Imagen As String
        Get
            Return _imagen
        End Get
        Set(value As String)
            _imagen = value
        End Set
    End Property

    Public Property Privacidad As String
        Get
            Return _privacidad
        End Get
        Set(value As String)
            _privacidad = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Property FechaModificacion As Date
        Get
            Return _fechaModificacion
        End Get
        Set(value As Date)
            _fechaModificacion = value
        End Set
    End Property
End Class