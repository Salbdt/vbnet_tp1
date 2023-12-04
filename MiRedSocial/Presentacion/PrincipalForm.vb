Imports Presentacion.Variables

Public Class PrincipalForm
    Private m_ChildFormNumber As Integer
    Private _usuario As Entidades.Usuario

    Public Property Usuario As Entidades.Usuario
        Get
            Return _usuario
        End Get
        Set(value As Entidades.Usuario)
            _usuario = value
        End Set
    End Property

    Private Sub CerrarFormularios()
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub ActivarPermisos()
        If _usuario.Rol.Nombre = "Administrador" Then
            AccesosToolStripMenuItem.Enabled = True
        Else
            AccesosToolStripMenuItem.Enabled = False
        End If
    End Sub

    Public Sub Iniciar()
        EstadoToolStrip.Text = "Usuario actual: " & _usuario.NombreUsuario
        UsuarioToolStripMenuItem.Text = _usuario.NombreUsuario
        Me.ActivarPermisos()
    End Sub

    Private Sub PrincipalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Iniciar()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim resultado As DialogResult = caja.MostrarMensaje("¿Está seguro que desea salir?", vbYesNo + vbQuestion, "Salir de MiRedSocial")
        If (resultado = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub RolesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RolesToolStripMenuItem.Click
        Dim rolesForm As New RolesForm
        rolesForm.MdiParent = Me
        rolesForm.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim usuariosForm As New UsuariosForm(True)
        usuariosForm.MdiParent = Me
        usuariosForm.Show()
    End Sub

    Private Sub PrincipalForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub ConfiguracionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiPerfilToolStripMenuItem.Click
        Dim usuarioForm As New UsuarioForm(_usuario.IdUsuario)
        usuarioForm.MdiParent = Me
        usuarioForm.Show()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Dim resultado As DialogResult = caja.MostrarMensaje("¿Está seguro que desea cerrar la sesión?", vbYesNo + vbQuestion, "Cerrar sesión de MiRedSocial")
        If (resultado = DialogResult.Yes) Then
            Me.Usuario = Nothing
            Me.CerrarFormularios()
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub

    Private Sub DatosPersonalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosPersonalesToolStripMenuItem.Click
        Dim personaForm As New PersonaForm(_usuario.IdUsuario)
        personaForm.MdiParent = Me
        personaForm.Show()
    End Sub

    Private Sub MuroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiMuroToolStripMenuItem.Click
        Dim muroForm As New MuroForm(_usuario.IdUsuario, _usuario.IdUsuario)
        muroForm.MdiParent = Me
        muroForm.Show()
    End Sub

    Private Sub PersonasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonasToolStripMenuItem.Click
        Dim personasForm As New PersonasForm(_usuario.IdUsuario)
        personasForm.MdiParent = Me
        personasForm.Show()
    End Sub
End Class
