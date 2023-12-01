Public Class CrearPublicacionForm
    Private idUsuario As Integer
    Private rutaOrigen As String
    Private rutaDestino As String
    Private imagenAnterior As String


    Public Sub New(idUsuario As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.idUsuario = idUsuario
    End Sub

    Private Sub CrearPublicacionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        Me.Close()
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
End Class