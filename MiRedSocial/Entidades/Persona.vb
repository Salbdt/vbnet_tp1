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

    Public Function ToDatatable(id As Boolean) As DataTable
        Dim personaDatatable As New DataTable("persona")

        If (id = True) Then
            personaDatatable.Columns.Add("id_persona", System.Type.GetType("System.String"))
            personaDatatable.Columns.Add("id_usuario", System.Type.GetType("System.String"))
        End If

        personaDatatable.Columns.Add("nombre", System.Type.GetType("System.String"))
        personaDatatable.Columns.Add("apellido", System.Type.GetType("System.String"))
        personaDatatable.Columns.Add("tipo_documento", System.Type.GetType("System.String"))
        personaDatatable.Columns.Add("num_documento", System.Type.GetType("System.String"))
        personaDatatable.Columns.Add("domicilio", System.Type.GetType("System.String"))
        personaDatatable.Columns.Add("telefono", System.Type.GetType("System.String"))

        If (id = True) Then
            personaDatatable.Rows.Add({_idPersona, IdUsuario, _nombre, _apellido, _tipoDocumento, _numDocumento, _domicilio, _telefono})
        Else
            personaDatatable.Rows.Add({_nombre, _apellido, _tipoDocumento, _numDocumento, _domicilio, _telefono})
        End If


        Return personaDatatable
    End Function
End Class