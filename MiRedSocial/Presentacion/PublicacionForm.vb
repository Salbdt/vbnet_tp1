Imports System.IO
Imports Presentacion.Variables

Public Class PublicacionForm
    Private idUsuario, idPublicacion As Integer
    Private rutaOrigen As String
    Private rutaDestino As String
    Private imagenAnterior As String

    Public Sub New(idUsuario As Integer)
        InitializeComponent()
        Me.idUsuario = idUsuario
    End Sub

    Public Sub New(idUsuario As Integer, idPublicacion As Integer)
        InitializeComponent()
        Me.idUsuario = idUsuario
        Me.idPublicacion = idPublicacion
    End Sub

    Private Sub Limpiar()
        PrivacidadComboBox.SelectedText = "Pública"
        TextoTextBox.Text = ""
        ImagenTextBox.Text = ""
        ImagenPictureBox.Image = Nothing
    End Sub

    Private Sub Obtener()
        Try
            Dim neg As New Negocio.NPublicacion
            Dim publicacion As Entidades.Publicacion = neg.Obtener(idPublicacion)

            IdLabel.Text = Convert.ToInt64(publicacion.IdPublicacion.ToString)
            PrivacidadComboBox.Text = publicacion.Privacidad
            TextoTextBox.Text = publicacion.Texto
            If (publicacion.Imagen <> "") Then
                Try
                    ImagenTextBox.Text = publicacion.Imagen
                    ImagenPictureBox.Image = Image.FromFile(rutaImagenes & publicacion.Imagen)
                Catch ex As Exception
                    caja.MostrarMensaje(ex.Message)
                End Try
            End If
        Catch ex As Exception
            caja.MostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub ElegirImagenButton_Click(sender As Object, e As EventArgs) Handles ElegirImagenButton.Click
        Dim file As New OpenFileDialog
        file.Filter = "Image Files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
        If file.ShowDialog() = DialogResult.OK Then
            imagenAnterior = ImagenTextBox.Text
            ImagenPictureBox.Image = Image.FromFile(file.FileName)
            rutaOrigen = file.FileName
            ImagenTextBox.Text = file.FileName.Substring(file.FileName.LastIndexOf("\") + 1)
        End If
    End Sub

    Private Sub PublicarButton_Click(sender As Object, e As EventArgs) Handles PublicarButton.Click
        Try
            If (PrivacidadComboBox.Text <> "") And (TextoTextBox.Text <> "") Then
                Dim publicacion As New Entidades.Publicacion
                Dim neg As New Negocio.NPublicacion

                publicacion.IdUsuario = idUsuario
                publicacion.Texto = TextoTextBox.Text
                publicacion.Privacidad = PrivacidadComboBox.Text
                publicacion.Imagen = ImagenTextBox.Text

                If (neg.Insertar(publicacion)) Then
                    If (ImagenTextBox.Text <> "") Then
                        rutaDestino = Variables.rutaImagenes & ImagenTextBox.Text
                        File.Copy(rutaOrigen, rutaDestino)
                    End If
                    Me.Limpiar()
                    caja.MostrarMensaje("Se ha publicado correctamente", vbOKOnly + vbInformation, "Publicación correcta")
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    caja.MostrarMensaje("No se ha podido publicar", vbOKOnly + vbCritical, "Publicación incorrecta")
                End If
            Else
                caja.MostrarMensaje("Rellene todos los campos obligatorios", vbOKOnly + vbInformation, "Campos incompletos")
            End If
        Catch ex As Exception
            caja.MostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub

    Private Sub ActualizarButton_Click(sender As Object, e As EventArgs) Handles ActualizarButton.Click
        Try
            If (PrivacidadComboBox.Text <> "") And (TextoTextBox.Text <> "") Then
                Dim publicacion As New Entidades.Publicacion
                Dim neg As New Negocio.NPublicacion

                publicacion.IdPublicacion = idPublicacion
                publicacion.Texto = TextoTextBox.Text
                publicacion.Privacidad = PrivacidadComboBox.Text
                publicacion.Imagen = ImagenTextBox.Text

                If (neg.Actualizar(publicacion)) Then
                    If (ImagenTextBox.Text <> "") Then
                        rutaDestino = Variables.rutaImagenes & ImagenTextBox.Text
                        File.Copy(rutaOrigen, rutaDestino)
                    End If
                    Me.Limpiar()
                    caja.MostrarMensaje("Se ha actualizado correctamente", vbOKOnly + vbInformation, "Actualización correcta")
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    caja.MostrarMensaje("No se ha podido actualizar", vbOKOnly + vbCritical, "Actualización incorrecta")
                End If
            Else
                caja.MostrarMensaje("Rellene todos los campos obligatorios", vbOKOnly + vbInformation, "Campos incompletos")
            End If
        Catch ex As Exception
            caja.MostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub PublicacionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (idPublicacion > 0) Then
            PublicarButton.Visible = False
            ActualizarButton.Visible = True
            Me.Obtener()
        End If
    End Sub
End Class