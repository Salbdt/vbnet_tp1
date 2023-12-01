Imports Entidades

Public Class PublicacionPanel
    Private puntoSiguiente As Point
    Private siguienteY As Integer

    Public Sub New(puntoInicial As Point, siguienteY As Integer)
        Me.puntoSiguiente = puntoInicial
        Me.siguienteY = siguienteY
    End Sub

    Public Function CrearPanelPublicacion(avatar As String, nombreUsuario As String, nombreRol As String, fecha As String,
                                          fechaModificacion As String, mensaje As String, imagen As String) As Panel
        Dim panel As New Panel
        panel.Anchor = 13
        panel.Location = puntoSiguiente
        panel.Margin = New Padding(3)
        panel.Size = New Size(820, 158)
        puntoSiguiente = New Point(5, puntoSiguiente.Y + siguienteY)

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
        pictureBox.Location = New Point(633, 3)
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
End Class