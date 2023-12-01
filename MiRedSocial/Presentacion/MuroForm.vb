Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class MuroForm
    Private usuario As Entidades.Usuario
    Private idUsuarioViendo As Integer
    Private puntoSiguiente As Point

    Public Sub New(miIdUsuario As Integer, idUsuarioViendo As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.usuario = Me.ObtenerUsuario(miIdUsuario)
        Me.idUsuarioViendo = idUsuarioViendo
    End Sub

    Private Sub Listar()
        Try
            Dim neg As New Negocio.NPublicacion
            Dim publicacionPanel As New PublicacionPanel(New Point(5, 5), 168)
            For Each row As DataRow In neg.BuscarUsuario(idUsuarioViendo).Rows
                Dim panel As Panel = publicacionPanel.CrearPanelPublicacion(
                    row.Item("avatar").ToString,
                    row.Item("usuario").ToString,
                    row.Item("rol").ToString,
                    row.Item("fecha").ToString,
                    row.Item("fecha_modificacion").ToString,
                    row.Item("texto").ToString,
                    row.Item("imagen").ToString
                )
                PublicacionesPanel.Controls.Add(panel)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ObtenerUsuario(idUsuario As Integer) As Entidades.Usuario
        Try
            Dim caja As MensajeCaja
            Dim neg As New Negocio.NUsuario
            Dim usuario As Entidades.Usuario = neg.Obtener(idUsuario)

            If (usuario Is Nothing) Then
                caja = New MensajeCaja("Error al obtener los datos de la persona", vbOKOnly + vbCritical, "Persona no encontrada")
                caja.ShowDialog()
                Me.Close()
            Else
                Return usuario
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub MuroForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
    End Sub

    Private Sub CrearPublicacionButton_Click(sender As Object, e As EventArgs) Handles CrearPublicacionButton.Click
        Dim crearPublicacionForm As New CrearPublicacionForm(usuario.IdUsuario)
        crearPublicacionForm.ShowDialog()
    End Sub
End Class