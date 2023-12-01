<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MuroForm
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
        Me.PublicacionPanel = New System.Windows.Forms.Panel()
        Me.FechaLabel = New System.Windows.Forms.Label()
        Me.ImagenPictureBox = New System.Windows.Forms.PictureBox()
        Me.RolLabel = New System.Windows.Forms.Label()
        Me.TextoLabel = New System.Windows.Forms.Label()
        Me.UsuarioLabel = New System.Windows.Forms.Label()
        Me.AvatarPictureBox = New System.Windows.Forms.PictureBox()
        Me.CrearPublicacionButton = New System.Windows.Forms.Button()
        Me.PublicacionesPanel = New System.Windows.Forms.Panel()
        Me.PublicacionPanel.SuspendLayout()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvatarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PublicacionesPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PublicacionPanel
        '
        Me.PublicacionPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PublicacionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PublicacionPanel.Controls.Add(Me.FechaLabel)
        Me.PublicacionPanel.Controls.Add(Me.ImagenPictureBox)
        Me.PublicacionPanel.Controls.Add(Me.RolLabel)
        Me.PublicacionPanel.Controls.Add(Me.TextoLabel)
        Me.PublicacionPanel.Controls.Add(Me.UsuarioLabel)
        Me.PublicacionPanel.Controls.Add(Me.AvatarPictureBox)
        Me.PublicacionPanel.Location = New System.Drawing.Point(10, 10)
        Me.PublicacionPanel.Margin = New System.Windows.Forms.Padding(5)
        Me.PublicacionPanel.Name = "PublicacionPanel"
        Me.PublicacionPanel.Size = New System.Drawing.Size(808, 178)
        Me.PublicacionPanel.TabIndex = 2
        Me.PublicacionPanel.Visible = False
        '
        'FechaLabel
        '
        Me.FechaLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaLabel.Location = New System.Drawing.Point(149, 3)
        Me.FechaLabel.Name = "FechaLabel"
        Me.FechaLabel.Size = New System.Drawing.Size(478, 20)
        Me.FechaLabel.TabIndex = 5
        Me.FechaLabel.Text = "Fecha"
        '
        'ImagenPictureBox
        '
        Me.ImagenPictureBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImagenPictureBox.Location = New System.Drawing.Point(633, 3)
        Me.ImagenPictureBox.Name = "ImagenPictureBox"
        Me.ImagenPictureBox.Size = New System.Drawing.Size(170, 170)
        Me.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagenPictureBox.TabIndex = 4
        Me.ImagenPictureBox.TabStop = False
        '
        'RolLabel
        '
        Me.RolLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RolLabel.Location = New System.Drawing.Point(3, 126)
        Me.RolLabel.Name = "RolLabel"
        Me.RolLabel.Size = New System.Drawing.Size(140, 20)
        Me.RolLabel.TabIndex = 3
        Me.RolLabel.Text = "Rol"
        Me.RolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextoLabel
        '
        Me.TextoLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoLabel.Location = New System.Drawing.Point(149, 23)
        Me.TextoLabel.Name = "TextoLabel"
        Me.TextoLabel.Padding = New System.Windows.Forms.Padding(3)
        Me.TextoLabel.Size = New System.Drawing.Size(478, 150)
        Me.TextoLabel.TabIndex = 2
        Me.TextoLabel.Text = "Mensaje de la publicación"
        '
        'UsuarioLabel
        '
        Me.UsuarioLabel.Location = New System.Drawing.Point(3, 106)
        Me.UsuarioLabel.Name = "UsuarioLabel"
        Me.UsuarioLabel.Size = New System.Drawing.Size(140, 20)
        Me.UsuarioLabel.TabIndex = 1
        Me.UsuarioLabel.Text = "Usuario"
        Me.UsuarioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AvatarPictureBox
        '
        Me.AvatarPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AvatarPictureBox.Location = New System.Drawing.Point(23, 3)
        Me.AvatarPictureBox.Name = "AvatarPictureBox"
        Me.AvatarPictureBox.Size = New System.Drawing.Size(100, 100)
        Me.AvatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AvatarPictureBox.TabIndex = 0
        Me.AvatarPictureBox.TabStop = False
        '
        'CrearPublicacionButton
        '
        Me.CrearPublicacionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CrearPublicacionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CrearPublicacionButton.Location = New System.Drawing.Point(15, 17)
        Me.CrearPublicacionButton.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.CrearPublicacionButton.Name = "CrearPublicacionButton"
        Me.CrearPublicacionButton.Size = New System.Drawing.Size(150, 26)
        Me.CrearPublicacionButton.TabIndex = 10
        Me.CrearPublicacionButton.Text = "Crear Publicación"
        Me.CrearPublicacionButton.UseVisualStyleBackColor = True
        '
        'PublicacionesPanel
        '
        Me.PublicacionesPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PublicacionesPanel.AutoScroll = True
        Me.PublicacionesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PublicacionesPanel.Controls.Add(Me.PublicacionPanel)
        Me.PublicacionesPanel.Location = New System.Drawing.Point(12, 54)
        Me.PublicacionesPanel.Name = "PublicacionesPanel"
        Me.PublicacionesPanel.Padding = New System.Windows.Forms.Padding(5)
        Me.PublicacionesPanel.Size = New System.Drawing.Size(830, 419)
        Me.PublicacionesPanel.TabIndex = 11
        '
        'MuroForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(854, 485)
        Me.Controls.Add(Me.PublicacionesPanel)
        Me.Controls.Add(Me.CrearPublicacionButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MuroForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MuroForm"
        Me.PublicacionPanel.ResumeLayout(False)
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvatarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PublicacionesPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PublicacionPanel As Panel
    Friend WithEvents AvatarPictureBox As PictureBox
    Friend WithEvents UsuarioLabel As Label
    Friend WithEvents RolLabel As Label
    Friend WithEvents TextoLabel As Label
    Friend WithEvents ImagenPictureBox As PictureBox
    Friend WithEvents CrearPublicacionButton As Button
    Friend WithEvents PublicacionesPanel As Panel
    Friend WithEvents FechaLabel As Label
End Class
