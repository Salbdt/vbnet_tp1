﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrincipalForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrincipalForm))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiPerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosPersonalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccesosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RolesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SocialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiMuroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MensajesPrivadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarraDeHerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarraDeEstadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanasMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.EstadoToolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem, Me.AccesosToolStripMenuItem, Me.SocialToolStripMenuItem, Me.VerMenu, Me.VentanasMenu, Me.AyudaMenu, Me.CerrarSesionToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.VentanasMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip.Size = New System.Drawing.Size(1178, 31)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiPerfilToolStripMenuItem, Me.DatosPersonalesToolStripMenuItem})
        Me.UsuarioToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(81, 25)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'MiPerfilToolStripMenuItem
        '
        Me.MiPerfilToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiPerfilToolStripMenuItem.Name = "MiPerfilToolStripMenuItem"
        Me.MiPerfilToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.MiPerfilToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.MiPerfilToolStripMenuItem.Text = "Mi &Perfil"
        '
        'DatosPersonalesToolStripMenuItem
        '
        Me.DatosPersonalesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatosPersonalesToolStripMenuItem.Name = "DatosPersonalesToolStripMenuItem"
        Me.DatosPersonalesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DatosPersonalesToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.DatosPersonalesToolStripMenuItem.Text = "Mis &Datos"
        '
        'AccesosToolStripMenuItem
        '
        Me.AccesosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RolesToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.AccesosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccesosToolStripMenuItem.Name = "AccesosToolStripMenuItem"
        Me.AccesosToolStripMenuItem.Size = New System.Drawing.Size(77, 25)
        Me.AccesosToolStripMenuItem.Text = "Accesos"
        '
        'RolesToolStripMenuItem
        '
        Me.RolesToolStripMenuItem.Name = "RolesToolStripMenuItem"
        Me.RolesToolStripMenuItem.Size = New System.Drawing.Size(141, 26)
        Me.RolesToolStripMenuItem.Text = "Roles"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(141, 26)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'SocialToolStripMenuItem
        '
        Me.SocialToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiMuroToolStripMenuItem, Me.MensajesPrivadosToolStripMenuItem, Me.PersonasToolStripMenuItem})
        Me.SocialToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SocialToolStripMenuItem.Name = "SocialToolStripMenuItem"
        Me.SocialToolStripMenuItem.Size = New System.Drawing.Size(63, 25)
        Me.SocialToolStripMenuItem.Text = "Social"
        '
        'MiMuroToolStripMenuItem
        '
        Me.MiMuroToolStripMenuItem.Name = "MiMuroToolStripMenuItem"
        Me.MiMuroToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MiMuroToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.MiMuroToolStripMenuItem.Text = "Mi &Muro"
        '
        'MensajesPrivadosToolStripMenuItem
        '
        Me.MensajesPrivadosToolStripMenuItem.Name = "MensajesPrivadosToolStripMenuItem"
        Me.MensajesPrivadosToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.MensajesPrivadosToolStripMenuItem.Text = "Mensajes Privados"
        '
        'PersonasToolStripMenuItem
        '
        Me.PersonasToolStripMenuItem.Name = "PersonasToolStripMenuItem"
        Me.PersonasToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.PersonasToolStripMenuItem.Text = "Personas"
        '
        'VerMenu
        '
        Me.VerMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarraDeHerramientasToolStripMenuItem, Me.BarraDeEstadoToolStripMenuItem})
        Me.VerMenu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerMenu.Name = "VerMenu"
        Me.VerMenu.Size = New System.Drawing.Size(45, 25)
        Me.VerMenu.Text = "Ver"
        '
        'BarraDeHerramientasToolStripMenuItem
        '
        Me.BarraDeHerramientasToolStripMenuItem.Checked = True
        Me.BarraDeHerramientasToolStripMenuItem.CheckOnClick = True
        Me.BarraDeHerramientasToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BarraDeHerramientasToolStripMenuItem.Name = "BarraDeHerramientasToolStripMenuItem"
        Me.BarraDeHerramientasToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.BarraDeHerramientasToolStripMenuItem.Text = "Barra de herramientas"
        '
        'BarraDeEstadoToolStripMenuItem
        '
        Me.BarraDeEstadoToolStripMenuItem.Checked = True
        Me.BarraDeEstadoToolStripMenuItem.CheckOnClick = True
        Me.BarraDeEstadoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BarraDeEstadoToolStripMenuItem.Name = "BarraDeEstadoToolStripMenuItem"
        Me.BarraDeEstadoToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.BarraDeEstadoToolStripMenuItem.Text = "Barra de estado"
        '
        'VentanasMenu
        '
        Me.VentanasMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
        Me.VentanasMenu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentanasMenu.Name = "VentanasMenu"
        Me.VentanasMenu.Size = New System.Drawing.Size(85, 25)
        Me.VentanasMenu.Text = "Ventanas"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.CascadeToolStripMenuItem.Text = "&Cascade"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.TileVerticalToolStripMenuItem.Text = "Tile &Vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.CloseAllToolStripMenuItem.Text = "C&lose All"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Arrange Icons"
        '
        'AyudaMenu
        '
        Me.AyudaMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.AyudaMenu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AyudaMenu.Name = "AyudaMenu"
        Me.AyudaMenu.Size = New System.Drawing.Size(66, 25)
        Me.AyudaMenu.Text = "Ayuda"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(202, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.AboutToolStripMenuItem.Text = "&About ..."
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(116, 25)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(53, 25)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip.Location = New System.Drawing.Point(0, 31)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip.Size = New System.Drawing.Size(1178, 25)
        Me.ToolStrip.TabIndex = 2
        Me.ToolStrip.Text = "ToolStrip"
        '
        'StatusStrip
        '
        Me.StatusStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstadoToolStrip})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 548)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1178, 26)
        Me.StatusStrip.TabIndex = 3
        Me.StatusStrip.Text = "StatusStrip"
        '
        'EstadoToolStrip
        '
        Me.EstadoToolStrip.Name = "EstadoToolStrip"
        Me.EstadoToolStrip.Size = New System.Drawing.Size(125, 21)
        Me.EstadoToolStrip.Text = "Usuario actual: ..."
        '
        'PrincipalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 574)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "PrincipalForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MiRedSocial"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentanasMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents EstadoToolStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents VerMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarraDeHerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarraDeEstadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SocialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MiMuroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MensajesPrivadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccesosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RolesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MiPerfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatosPersonalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonasToolStripMenuItem As ToolStripMenuItem
End Class
