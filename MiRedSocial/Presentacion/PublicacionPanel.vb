Public Class PublicacionPanel
    Private puntoSiguiente As Point
    Private siguienteY As Integer
    Private _botonesBorrar As Dictionary(Of Button, Integer)
    Private _botonesEditar As Dictionary(Of Button, Integer)

    Public Sub New(puntoInicial As Point, siguienteY As Integer)
        Me.puntoSiguiente = puntoInicial
        Me.siguienteY = siguienteY
        Me.BotonesBorrar = New Dictionary(Of Button, Integer)
        Me.BotonesEditar = New Dictionary(Of Button, Integer)
    End Sub

    Public Property BotonesBorrar As Dictionary(Of Button, Integer)
        Get
            Return _botonesBorrar
        End Get
        Set(value As Dictionary(Of Button, Integer))
            _botonesBorrar = value
        End Set
    End Property

    Public Property BotonesEditar As Dictionary(Of Button, Integer)
        Get
            Return _botonesEditar
        End Get
        Set(value As Dictionary(Of Button, Integer))
            _botonesEditar = value
        End Set
    End Property

    Public Function CrearPanelPrincipal() As Panel
        Dim panel As New Panel
        panel.Anchor = 15
        panel.AutoScroll = True
        panel.Location = New Point(12, 54)
        panel.Margin = New Padding(3)
        panel.Padding = New Padding(3)
        panel.Size = New Size(830, 419)
        Return panel
    End Function

    Public Function CrearPanelPublicacion(idPublicacion As Integer, avatar As String, nombreUsuario As String, nombreRol As String, fecha As String,
                                          fechaModificacion As String, mensaje As String, imagen As String) As Panel
        Dim panel As New Panel
        Dim borrarButton, editarButton As Button
        panel.BackColor = Color.Snow
        panel.BorderStyle = BorderStyle.FixedSingle
        panel.Anchor = 13
        panel.Location = puntoSiguiente
        panel.Margin = New Padding(3)
        panel.Size = New Size(820, 190)
        puntoSiguiente = New Point(5, puntoSiguiente.Y + siguienteY)

        panel.Controls.Add(CrearIdLabel(idPublicacion))
        panel.Controls.Add(CrearAvatarPictureBox(avatar))
        panel.Controls.Add(CrearUsuarioLabel(nombreUsuario))
        panel.Controls.Add(CrearRolLabel(nombreRol))
        panel.Controls.Add(CrearFechaLabel(fecha, fechaModificacion))
        If (imagen <> "") Then
            panel.Controls.Add(CrearMensajePublicacionLabel(mensaje, 478))
            panel.Controls.Add(CrearImagenPictureBox(imagen))
        Else
            panel.Controls.Add(CrearMensajePublicacionLabel(mensaje, 654))
        End If
        borrarButton = CrearBorrarPublicacionButton()
        panel.Controls.Add(borrarButton)
        Me.BotonesBorrar.Add(borrarButton, idPublicacion)
        editarButton = CrearEditarPublicacionButton()
        panel.Controls.Add(editarButton)
        Me.BotonesEditar.Add(editarButton, idPublicacion)

        Return panel
    End Function

    Private Function CrearAvatarPictureBox(imagen As String) As PictureBox
        Dim pictureBox As New PictureBox
        pictureBox.BorderStyle = BorderStyle.FixedSingle
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBox.Anchor = 5
        pictureBox.Location = New Point(23, 3)
        pictureBox.Size = New Size(100, 100)
        If (imagen <> "") Then
            Try
                pictureBox.Image = Image.FromFile(Variables.rutaAvatares & imagen)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Return pictureBox
    End Function

    Private Function CrearUsuarioLabel(nombre As String) As Label
        Dim label As New Label
        label.Text = nombre
        label.TextAlign = ContentAlignment.MiddleCenter
        label.Anchor = 5
        label.Location = New Point(3, 106)
        label.AutoSize = False
        label.Size = New Size(140, 20)
        Return label
    End Function

    Private Function CrearRolLabel(rol As String) As Label
        Dim label As New Label
        label.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
        label.Text = rol
        label.TextAlign = ContentAlignment.MiddleCenter
        label.Anchor = 5
        label.Location = New Point(3, 126)
        label.AutoSize = False
        label.Size = New Size(140, 20)
        Return label
    End Function

    Private Function CrearIdLabel(idPublicacion As Integer) As Label
        Dim label As New Label
        label.Text = idPublicacion.ToString
        label.TextAlign = ContentAlignment.MiddleCenter
        label.Visible = False
        label.Anchor = 5
        label.Location = New Point(4, 3)
        Return label
    End Function

    Private Function CrearFechaLabel(fecha As String, fechaModificacion As String) As Label
        Dim label As New Label
        label.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
        If (fechaModificacion.Equals(fecha) = True) Then
            label.Text = "Creada el " & fecha & "."
        Else
            label.Text = "Creada el " & fecha & ". Editada el " & fechaModificacion & "."
        End If
        label.Anchor = 5
        label.Location = New Point(149, 3)
        label.AutoSize = False
        label.Size = New Size(478, 20)
        Return label
    End Function

    Private Function CrearMensajePublicacionLabel(mensaje As String, ancho As Integer) As Label
        Dim label As New Label
        label.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
        label.Text = mensaje
        label.Anchor = 15
        label.Location = New Point(149, 23)
        label.AutoSize = False
        label.Padding = New Padding(3)
        label.Size = New Size(ancho, 150)
        Return label
    End Function

    Private Function CrearImagenPictureBox(imagen As String) As PictureBox
        Dim pictureBox As New PictureBox
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBox.Anchor = 11
        pictureBox.Location = New Point(633, 9)
        pictureBox.Size = New Size(170, 170)
        If (imagen <> "") Then
            Try
                pictureBox.Image = Image.FromFile(Variables.rutaImagenes & imagen)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Return pictureBox
    End Function

    Private Function CrearBorrarPublicacionButton() As Button
        Dim button As New Button
        button.BackColor = Color.Tomato
        button.FlatStyle = FlatStyle.Flat
        button.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
        button.ForeColor = SystemColors.ControlLight
        button.Text = "Borrar"
        button.Anchor = 6
        button.Location = New Point(6, 154)
        button.Size = New Size(58, 26)
        Return button
    End Function

    Private Function CrearEditarPublicacionButton() As Button
        Dim button As New Button
        button.FlatStyle = FlatStyle.Flat
        button.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
        button.Text = "Editar"
        button.Anchor = 6
        button.Location = New Point(65, 154)
        button.Size = New Size(58, 26)
        Return button
    End Function
End Class