Imports System.IO
Imports Presentacion.Variables
Public Class UsuarioForm
    Private idUsuario As Integer
    Private rutaOrigen As String
    Private rutaDestino As String
    Private avatarAnterior As String

    Public Sub New(id As Integer)
        InitializeComponent()
        idUsuario = id
    End Sub

    Public Sub Limpiar()
        EmailNuevoTextBox.Text = ""
        ClaveTextBox.Text = ""
        ClaveNuevaTextBox.Text = ""
    End Sub

    Private Sub Obtener(id As Integer)
        Try
            Dim usuario As New Entidades.Usuario
            Dim neg As New Negocio.NUsuario
            usuario = neg.Obtener(id)
            If (usuario Is Nothing) Then
                caja.MostrarMensaje("Error al obtener los datos del usuario, reinicie el sistema", vbOKOnly + vbCritical, "Error de usuario")
            Else
                IdUsuarioLabel.Text = usuario.IdUsuario
                RolesComboBox.SelectedValue = usuario.Rol.IdRol
                NombreUsuarioTextBox.Text = usuario.NombreUsuario
                EmailTextBox.Text = usuario.Email

                If (usuario.Avatar <> "") Then
                    AvatarTextBox.Text = usuario.Avatar
                    Try
                        AvatarPictureBox.Image = Image.FromFile(Variables.rutaAvatares & usuario.Avatar)
                    Catch ex As Exception
                        caja.MostrarMensaje(ex.Message)
                    End Try
                End If

                Me.Limpiar()
            End If
        Catch ex As Exception
            caja.MostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub CargarRoles()
        Try
            Dim neg As New Negocio.NRol
            RolesComboBox.DataSource = neg.Listar()
            RolesComboBox.ValueMember = "id_rol"
            RolesComboBox.DisplayMember = "nombre"
        Catch ex As Exception
            caja.MostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub UsuarioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarRoles()
        Me.Obtener(idUsuario)
    End Sub

    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub

    Private Sub ActualizarButton_Click(sender As Object, e As EventArgs) Handles ActualizarButton.Click
        Try
            If (RolesComboBox.Text <> "") And (NombreUsuarioTextBox.Text <> "") And (EmailTextBox.Text <> "") And
                (ClaveTextBox.Text <> "") Then
                Dim usuario As New Entidades.Usuario
                Dim neg As New Negocio.NUsuario
                Dim emailNuevo, claveNueva As String

                usuario.IdUsuario = IdUsuarioLabel.Text
                usuario.Rol = New Entidades.Rol
                usuario.Rol.IdRol = RolesComboBox.SelectedValue
                usuario.NombreUsuario = NombreUsuarioTextBox.Text
                usuario.Email = EmailTextBox.Text
                usuario.Avatar = AvatarTextBox.Text
                usuario.Clave = ClaveTextBox.Text
                emailNuevo = EmailNuevoTextBox.Text
                claveNueva = ClaveNuevaTextBox.Text

                If (neg.Actualizar(usuario, emailNuevo, claveNueva)) Then
                    caja.MostrarMensaje("Se ha actualizado correctamente", vbOKOnly + vbInformation, "Actualización correcta")
                    If (AvatarTextBox.Text <> "") Then
                        rutaDestino = Variables.rutaAvatares & AvatarTextBox.Text
                        File.Copy(rutaOrigen, rutaDestino)
                        If (avatarAnterior <> "") Then
                            File.Delete(Variables.rutaAvatares & avatarAnterior)
                        End If
                    End If
                Else
                    caja.MostrarMensaje("No se ha podido actualizar", vbOKOnly + vbCritical, "Actualización incorrecta")
                End If
                Me.Obtener(usuario.IdUsuario)
            Else
                caja.MostrarMensaje("Rellene todos los campos obligatorios", vbOKOnly + vbInformation, "Campos incompletos")
            End If

        Catch ex As Exception
            caja.MostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub ElegirAvatarButton_Click(sender As Object, e As EventArgs) Handles ElegirAvatarButton.Click
        Dim file As New OpenFileDialog
        file.Filter = "Image Files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
        If file.ShowDialog() = DialogResult.OK Then
            avatarAnterior = AvatarTextBox.Text
            AvatarPictureBox.Image = Image.FromFile(file.FileName)
            rutaOrigen = file.FileName
            AvatarTextBox.Text = file.FileName.Substring(file.FileName.LastIndexOf("\") + 1)
        End If
    End Sub
End Class