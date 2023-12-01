Imports System.Windows.Forms

Public Class PrincipalForm

    Private m_ChildFormNumber As Integer
    Private _usuario As Entidades.Usuario

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub BarraDeHerramientasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarraDeHerramientasToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.BarraDeHerramientasToolStripMenuItem.Checked
    End Sub

    Private Sub BarraDeEstadoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BarraDeEstadoToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.BarraDeEstadoToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        Me.CerrarFormularios()
    End Sub

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
        If _usuario.Rol.Nombre <> "Administrador" Then
            AccesosToolStripMenuItem.Enabled = False
        End If
    End Sub

    Public Sub Cargar()
        EstadoToolStrip.Text = "Usuario actual: " & _usuario.NombreUsuario
        UsuarioToolStripMenuItem.Text = _usuario.NombreUsuario
        Me.ActivarPermisos()
    End Sub

    Private Sub PrincipalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cargar()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim caja As New MensajeCaja("¿Está seguro que desea salir?", vbYesNo + vbQuestion, "Salir de MiRedSocial")
        If (caja.ShowDialog() = DialogResult.Yes) Then
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
        Dim caja As New MensajeCaja("¿Está seguro que desea cerrar la sesión?", vbYesNo + vbQuestion, "Cerrar sesión de MiRedSocial")
        If (caja.ShowDialog() = DialogResult.Yes) Then
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
End Class
