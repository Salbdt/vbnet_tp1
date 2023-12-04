Public Class MensajeCaja
    Private mensaje As String
    Private titulo As String = "Mensaje"
    Private estilo As MsgBoxStyle = vbOKOnly + vbInformation

    Public Function MostrarMensaje(mensaje As String, estilo As MsgBoxStyle, titulo As String) As DialogResult
        Me.mensaje = mensaje
        Me.titulo = titulo
        Me.estilo = estilo
        Return Me.ShowDialog()
    End Function

    Public Function MostrarMensaje(mensaje As String, estilo As MsgBoxStyle) As DialogResult
        Me.mensaje = mensaje
        Me.estilo = estilo
        Return Me.ShowDialog()
    End Function

    Public Function MostrarMensaje(mensaje As String) As DialogResult
        Me.mensaje = mensaje
        Return Me.ShowDialog()
    End Function

    Private Sub Limpiar()
        SiNoTableLayoutPanel.Visible = False
        OkTableLayoutPanel.Visible = False
    End Sub

    Private Sub CargarIcono()
        If estilo.HasFlag(MsgBoxStyle.Question) Then
            IconoPictureBox.Image = My.Resources.pregunta
        ElseIf estilo.HasFlag(MsgBoxStyle.Information) Then
            IconoPictureBox.Image = My.Resources.informacion
        ElseIf estilo.HasFlag(MsgBoxStyle.Exclamation) Then
            IconoPictureBox.Image = My.Resources.advertencia
        ElseIf estilo.HasFlag(MsgBoxStyle.Critical) Then
            IconoPictureBox.Image = My.Resources._error
        Else
            IconoPictureBox.Image = Nothing
        End If

        If estilo.HasFlag(MsgBoxStyle.YesNo) Then
            SiNoTableLayoutPanel.Visible = True
        ElseIf estilo.HasFlag(MsgBoxStyle.OkOnly) Then
            OkTableLayoutPanel.Visible = True
        End If
    End Sub

    Private Sub CajaMensaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MensajeLabel.Text = mensaje
        Me.Text = titulo
        Me.Limpiar()
        Me.CargarIcono()
    End Sub

    Private Sub SiButton_Click(sender As Object, e As EventArgs) Handles SiButton.Click
        Me.DialogResult = DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Me.DialogResult = DialogResult.No
        Me.Close()
    End Sub

    Private Sub XButton_Click(sender As Object, e As EventArgs)
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
