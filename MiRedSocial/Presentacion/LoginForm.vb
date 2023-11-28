Public Class LoginForm

    Private Sub Limpiar()
        EmailTextBox.Text = ""
        ClaveTextBox.Text = ""
    End Sub

    Private Sub IngresarButton_Click(sender As Object, e As EventArgs) Handles IngresarButton.Click
        Try
            Dim caja As MensajeCaja

            Dim email, clave As String
            Dim usuario As New Entidades.Usuario
            Dim neg As New Negocio.NUsuario
            email = EmailTextBox.Text.Trim()
            clave = ClaveTextBox.Text.Trim()
            usuario = neg.Login(email, clave)
            If (usuario Is Nothing) Then
                caja = New MensajeCaja("No existe un usuario con ese email o clave", vbOKOnly + vbCritical, "Datos incorrectos")
                caja.ShowDialog()
            Else
                If (usuario.Estado = False) Then
                    caja = New MensajeCaja("El usuario est� bloqueado", vbOKOnly + vbCritical, "Usuario inhabilitado")
                    caja.ShowDialog()
                Else
                    PrincipalForm.Usuario = usuario
                    Me.Hide()
                    PrincipalForm.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Limpiar()
    End Sub

    Private Sub SalirButton_Click(sender As Object, e As EventArgs) Handles SalirButton.Click
        Application.Exit()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim usuariosForm As New UsuariosForm(False)
        usuariosForm.TabControl.TabPages.Remove(usuariosForm.ListaTabPage)
        usuariosForm.ShowDialog()
        Limpiar()
    End Sub
End Class
