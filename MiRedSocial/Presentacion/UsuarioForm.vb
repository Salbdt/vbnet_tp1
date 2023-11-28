Public Class UsuarioForm
    Private idUsuario As Integer

    Public Sub New(id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        idUsuario = id
    End Sub

    Private Sub Obtener(id As Integer)
        Try
            Dim usuario As New Entidades.Usuario
            Dim neg As New Negocio.NUsuario
            usuario = neg.Obtener(id)
            If (usuario Is Nothing) Then
                Dim caja As New MensajeCaja("Error al obtener los datos del usuario, reinicie el sistema", vbOKOnly + vbCritical, "Error de usuario")
                caja.ShowDialog()
            Else
                idLabel.Text = usuario.IdUsuario
                RolesComboBox.SelectedValue = usuario.Rol.IdRol
                NombreUsuarioTextBox.Text = usuario.NombreUsuario
                AvatarTextBox.Text = usuario.Avatar
                Try
                    AvatarPictureBox.Image = Image.FromFile(Variables.directorioImagen & usuario.Avatar)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                EmailTextBox.Text = usuario.Email
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CargarRoles()
        Try
            Dim neg As New Negocio.NRol
            RolesComboBox.DataSource = neg.Listar()
            RolesComboBox.ValueMember = "id_rol"
            RolesComboBox.DisplayMember = "nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub UsuarioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarRoles()
        Me.Obtener(idUsuario)
    End Sub
End Class