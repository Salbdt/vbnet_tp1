Public Class PersonaForm
    Private idUsuario As Integer

    Public Sub New(idUsuario As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.idUsuario = idUsuario
    End Sub

    Private Sub Obtener(idUsuario As Integer)
        Try
            Dim caja As MensajeCaja
            Dim neg As New Negocio.NPersona
            Dim persona As Entidades.Persona = neg.Obtener(idUsuario)

            If (persona IsNot Nothing) Then
                IdPersonaLabel.Text = persona.IdPersona
                IdUsuarioLabel.Text = persona.IdUsuario
                NombreTextBox.Text = persona.Nombre
                ApellidoTextBox.Text = persona.Apellido
                TipoDocumentoTextBox.Text = persona.TipoDocumento
                NumDocumentoTextBox.Text = persona.NumDocumento
                DomicilioTextBox.Text = persona.Domicilio
                TelefonoTextBox.Text = persona.Telefono
            Else
                caja = New MensajeCaja("Error al obtener los datos de la persona", vbOKOnly + vbCritical, "Persona no encontrada")
                caja.ShowDialog()
            End If
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar()
        EmailTextBox.Text = ""
        ClaveTextBox.Text = ""
    End Sub

    Private Function LeerPersona() As Entidades.Persona
        Dim persona As New Entidades.Persona
        persona.IdPersona = IdPersonaLabel.Text
        persona.IdUsuario = IdUsuarioLabel.Text
        persona.Nombre = NombreTextBox.Text
        persona.Apellido = ApellidoTextBox.Text
        persona.TipoDocumento = TipoDocumentoTextBox.Text
        persona.NumDocumento = NumDocumentoTextBox.Text
        persona.Domicilio = DomicilioTextBox.Text
        persona.Telefono = TelefonoTextBox.Text
        Return persona
    End Function

    Private Sub PersonaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Obtener(idUsuario)
    End Sub

    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub

    Private Sub ActualizarButton_Click(sender As Object, e As EventArgs) Handles ActualizarButton.Click
        Try
            Dim caja As MensajeCaja
            If (EmailTextBox.Text <> "" And ClaveTextBox.Text <> "") Then
                Dim neg As New Negocio.NPersona
                Dim persona As Entidades.Persona = Me.LeerPersona()
                Dim email, clave As String
                email = EmailTextBox.Text
                clave = ClaveTextBox.Text

                If (neg.Actualizar(persona, email, clave)) Then
                    caja = New MensajeCaja("Se ha actualizado correctamente", vbOKOnly + vbInformation, "Actualización correcta")
                    caja.ShowDialog()
                Else
                    caja = New MensajeCaja("No se ha podido actualizar", vbOKOnly + vbCritical, "Actualización incorrecta")
                    caja.ShowDialog()
                End If
                Me.Obtener(idUsuario)
            Else
                caja = New MensajeCaja("Rellene todos los campos obligatorios", vbOKOnly + vbInformation, "Campos incompletos")
                caja.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class