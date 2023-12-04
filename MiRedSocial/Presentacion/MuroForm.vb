Public Class MuroForm
    Private usuario As Entidades.Usuario
    Private idUsuarioViendo As Integer
    Private puntoSiguiente As Point
    Private panelPublicacion As PublicacionPanel
    Private panelPrincipal As Panel

    Public Sub New(miIdUsuario As Integer, idUsuarioViendo As Integer)
        InitializeComponent()
        Me.usuario = Me.ObtenerUsuario(miIdUsuario)
        Me.idUsuarioViendo = idUsuarioViendo
    End Sub

    Private Sub Listar()
        Dim caja As New MensajeCaja
        Try
            Dim neg As New Negocio.NPublicacion
            Dim publicaciones As DataTable = neg.BuscarUsuario(idUsuarioViendo)
            CantidadPublicacionesLabel.Text = "Publicaciones: " & publicaciones.Rows.Count
            panelPublicacion = New PublicacionPanel(New Point(5, 5), 193)
            panelPrincipal = panelPublicacion.CrearPanelPrincipal()
            For Each row As DataRow In publicaciones.Rows
                Dim panel As Panel = panelPublicacion.CrearPanelPublicacion(
                    row.Item("id_publicacion").ToString,
                    row.Item("avatar").ToString,
                    row.Item("usuario").ToString,
                    row.Item("rol").ToString,
                    row.Item("fecha").ToString,
                    row.Item("fecha_modificacion").ToString,
                    row.Item("texto").ToString,
                    row.Item("imagen").ToString
                )
                panelPrincipal.Controls.Add(panel)
            Next
            For Each button As Button In panelPublicacion.BotonesBorrar.Keys
                AddHandler button.Click, AddressOf BorrarPublicacionButton_click
            Next
            For Each button As Button In panelPublicacion.BotonesEditar.Keys
                AddHandler button.Click, AddressOf EditarPublicacionButton_click
            Next
            Me.Controls.Add(panelPrincipal)
        Catch ex As Exception
            caja.MostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Function ObtenerUsuario(idUsuario As Integer) As Entidades.Usuario
        Dim caja As New MensajeCaja
        Try
            Dim neg As New Negocio.NUsuario
            Dim usuario As Entidades.Usuario = neg.Obtener(idUsuario)

            If (usuario Is Nothing) Then
                caja.MostrarMensaje("Error al obtener los datos de la persona", vbOKOnly + vbCritical, "Persona no encontrada")
                Me.Close()
            Else
                Return usuario
            End If
        Catch ex As Exception
            caja.MostrarMensaje(ex.Message)
        End Try
    End Function

    Private Sub MuroForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
    End Sub

    Private Sub CrearPublicacionButton_Click(sender As Object, e As EventArgs) Handles CrearPublicacionButton.Click
        Dim publicacionForm As New PublicacionForm(usuario.IdUsuario)
        Dim resultado As DialogResult = publicacionForm.ShowDialog()
        If (resultado = DialogResult.OK) Then
            Me.Controls.Remove(panelPrincipal)
            Me.Listar()
        End If
    End Sub

    Public Sub BorrarPublicacionButton_click(sender As Object, e As System.EventArgs)
        Dim caja As New MensajeCaja
        Dim resultado As DialogResult = caja.MostrarMensaje("¿Estás seguro/a de eliminar la publicación?", vbYesNo + vbCritical, "Eliminar publicación")
        If (resultado = DialogResult.Yes) Then
            Try
                Dim idPublicacion As Integer = panelPublicacion.BotonesBorrar.Item(sender)
                Dim neg As New Negocio.NPublicacion
                If (neg.Eliminar(idPublicacion) = True) Then
                    Me.Controls.Remove(panelPrincipal)
                    Me.Listar()
                Else
                    caja.MostrarMensaje("Hubo un error y no se pudo eliminar la publición", vbOKOnly + vbCritical, "Error al eliminar")
                End If
            Catch ex As Exception
                caja.MostrarMensaje(ex.Message)
            End Try
        End If
    End Sub

    Public Sub EditarPublicacionButton_click(sender As Object, e As System.EventArgs)
        Dim idPublicacion As Integer = panelPublicacion.BotonesEditar.Item(sender)
        Dim publicacionForm As New PublicacionForm(usuario.IdUsuario, idPublicacion)
        Dim resultado As DialogResult = publicacionForm.ShowDialog()
        If (resultado = DialogResult.OK) Then
            Me.Controls.Remove(panelPrincipal)
            Me.Listar()
        End If
    End Sub
End Class