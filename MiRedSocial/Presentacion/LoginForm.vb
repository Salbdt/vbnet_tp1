Public Class LoginForm

    Private Sub Limpiar()
        EmailTextBox.Text = ""
        ClaveTextBox.Text = ""
    End Sub

    Private Sub IngresarButton_Click(sender As Object, e As EventArgs) Handles IngresarButton.Click
        Dim caja As New MensajeCaja
        Try
            Dim email, clave As String
            Dim usuario As New Entidades.Usuario
            Dim neg As New Negocio.NUsuario
            email = EmailTextBox.Text.Trim()
            clave = ClaveTextBox.Text.Trim()
            usuario = neg.Login(email, clave)
            If (usuario Is Nothing) Then
                caja.MostrarMensaje("No existe un usuario con ese email o clave", vbOKOnly + vbCritical, "Datos incorrectos")
            Else
                If (usuario.Estado = True And usuario.Rol.Estado = True) Then
                    PrincipalForm.Usuario = usuario
                    Me.Hide()
                    PrincipalForm.Iniciar() 'Sirve para actualizar cuando se cierra la sesión desde el menú
                    PrincipalForm.Show()
                Else
                    caja.MostrarMensaje("El usuario está bloqueado", vbOKOnly + vbCritical, "Usuario inhabilitado")
                End If
            End If
        Catch ex As Exception
            caja.MostrarMensaje(ex.Message)
        End Try
        Limpiar()
    End Sub

    Private Sub SalirButton_Click(sender As Object, e As EventArgs) Handles SalirButton.Click
        Application.Exit()
    End Sub

    Private Sub RegistrarseLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RegistrarseLinkLabel.LinkClicked
        Dim usuariosForm As New UsuariosForm(False)
        usuariosForm.TabControl.TabPages.Remove(usuariosForm.ListaTabPage)
        usuariosForm.ShowDialog()
        Limpiar()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmailTextBox.Focus()
    End Sub
End Class
