Imports System.Windows.Forms

Public Class SiNoMensajeCaja
    Private mensaje As String
    Private titulo As String
    Private icono As MessageBoxIcon

    ''' <summary>
    ''' Question = vbQuestion
    ''' <br></br>
    ''' Information = vbInformation
    ''' <br></br>
    ''' Warning = vbExclamation
    ''' <br></br>
    ''' Error = vbCritical
    ''' </summary>
    Public Sub New(mensaje As String, icono As MessageBoxIcon, titulo As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.mensaje = mensaje
        Me.titulo = titulo
        Me.icono = icono
    End Sub
    Private Sub CargarIcono()
        Select Case icono
            Case MessageBoxIcon.Question
                IconoPictureBox.Image = My.Resources.pregunta
            Case MessageBoxIcon.Information
                IconoPictureBox.Image = My.Resources.informacion
            Case MessageBoxIcon.Warning
                IconoPictureBox.Image = My.Resources.advertencia
            Case MessageBoxIcon.Error
                IconoPictureBox.Image = My.Resources._error
            Case Else
                IconoPictureBox.Image = Nothing
        End Select
    End Sub

    Private Sub CajaMensaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MensajeLabel.Text = mensaje
        Me.Text = titulo
        CargarIcono()
    End Sub

    Private Sub SiButton_Click(sender As Object, e As EventArgs) Handles SiButton.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub XButton_Click(sender As Object, e As EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
