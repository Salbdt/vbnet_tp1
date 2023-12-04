<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PublicacionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextoTextBox = New System.Windows.Forms.TextBox()
        Me.ImagenPictureBox = New System.Windows.Forms.PictureBox()
        Me.ElegirImagenButton = New System.Windows.Forms.Button()
        Me.ImagenLabel = New System.Windows.Forms.Label()
        Me.ImagenTextBox = New System.Windows.Forms.TextBox()
        Me.TextoLabel = New System.Windows.Forms.Label()
        Me.PublicarButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrivacidadComboBox = New System.Windows.Forms.ComboBox()
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.ActualizarButton = New System.Windows.Forms.Button()
        Me.IdLabel = New System.Windows.Forms.Label()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextoTextBox
        '
        Me.TextoTextBox.Location = New System.Drawing.Point(12, 69)
        Me.TextoTextBox.Multiline = True
        Me.TextoTextBox.Name = "TextoTextBox"
        Me.TextoTextBox.Size = New System.Drawing.Size(478, 150)
        Me.TextoTextBox.TabIndex = 0
        '
        'ImagenPictureBox
        '
        Me.ImagenPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImagenPictureBox.Location = New System.Drawing.Point(609, 49)
        Me.ImagenPictureBox.Name = "ImagenPictureBox"
        Me.ImagenPictureBox.Size = New System.Drawing.Size(170, 170)
        Me.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagenPictureBox.TabIndex = 5
        Me.ImagenPictureBox.TabStop = False
        '
        'ElegirImagenButton
        '
        Me.ElegirImagenButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ElegirImagenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ElegirImagenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ElegirImagenButton.Location = New System.Drawing.Point(789, 17)
        Me.ElegirImagenButton.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ElegirImagenButton.Name = "ElegirImagenButton"
        Me.ElegirImagenButton.Size = New System.Drawing.Size(50, 26)
        Me.ElegirImagenButton.TabIndex = 2
        Me.ElegirImagenButton.Text = "..."
        Me.ElegirImagenButton.UseVisualStyleBackColor = True
        '
        'ImagenLabel
        '
        Me.ImagenLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImagenLabel.Location = New System.Drawing.Point(446, 20)
        Me.ImagenLabel.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ImagenLabel.Name = "ImagenLabel"
        Me.ImagenLabel.Size = New System.Drawing.Size(120, 20)
        Me.ImagenLabel.TabIndex = 37
        Me.ImagenLabel.Text = "Imagen"
        Me.ImagenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImagenTextBox
        '
        Me.ImagenTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImagenTextBox.Location = New System.Drawing.Point(579, 17)
        Me.ImagenTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ImagenTextBox.Name = "ImagenTextBox"
        Me.ImagenTextBox.ReadOnly = True
        Me.ImagenTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ImagenTextBox.TabIndex = 3
        '
        'TextoLabel
        '
        Me.TextoLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextoLabel.Location = New System.Drawing.Point(15, 20)
        Me.TextoLabel.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.TextoLabel.Name = "TextoLabel"
        Me.TextoLabel.Size = New System.Drawing.Size(120, 20)
        Me.TextoLabel.TabIndex = 38
        Me.TextoLabel.Text = "Mensaje"
        Me.TextoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PublicarButton
        '
        Me.PublicarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PublicarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PublicarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PublicarButton.Location = New System.Drawing.Point(587, 230)
        Me.PublicarButton.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.PublicarButton.Name = "PublicarButton"
        Me.PublicarButton.Size = New System.Drawing.Size(120, 26)
        Me.PublicarButton.TabIndex = 4
        Me.PublicarButton.Text = "Publicar"
        Me.PublicarButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(147, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Privacidad"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrivacidadComboBox
        '
        Me.PrivacidadComboBox.FormattingEnabled = True
        Me.PrivacidadComboBox.Items.AddRange(New Object() {"Pública", "Privada"})
        Me.PrivacidadComboBox.Location = New System.Drawing.Point(276, 17)
        Me.PrivacidadComboBox.Name = "PrivacidadComboBox"
        Me.PrivacidadComboBox.Size = New System.Drawing.Size(121, 28)
        Me.PrivacidadComboBox.TabIndex = 1
        Me.PrivacidadComboBox.Text = "Pública"
        '
        'CancelarButton
        '
        Me.CancelarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CancelarButton.Location = New System.Drawing.Point(719, 230)
        Me.CancelarButton.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(120, 26)
        Me.CancelarButton.TabIndex = 6
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'ActualizarButton
        '
        Me.ActualizarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActualizarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActualizarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ActualizarButton.Location = New System.Drawing.Point(587, 230)
        Me.ActualizarButton.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ActualizarButton.Name = "ActualizarButton"
        Me.ActualizarButton.Size = New System.Drawing.Size(120, 26)
        Me.ActualizarButton.TabIndex = 5
        Me.ActualizarButton.Text = "Actualizar"
        Me.ActualizarButton.UseVisualStyleBackColor = True
        Me.ActualizarButton.Visible = False
        '
        'IdLabel
        '
        Me.IdLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IdLabel.Location = New System.Drawing.Point(15, 236)
        Me.IdLabel.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.IdLabel.Name = "IdLabel"
        Me.IdLabel.Size = New System.Drawing.Size(120, 20)
        Me.IdLabel.TabIndex = 44
        Me.IdLabel.Text = "IdPublicacion"
        Me.IdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IdLabel.Visible = False
        '
        'PublicacionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(854, 273)
        Me.Controls.Add(Me.IdLabel)
        Me.Controls.Add(Me.ActualizarButton)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.PrivacidadComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PublicarButton)
        Me.Controls.Add(Me.TextoLabel)
        Me.Controls.Add(Me.ElegirImagenButton)
        Me.Controls.Add(Me.ImagenLabel)
        Me.Controls.Add(Me.ImagenTextBox)
        Me.Controls.Add(Me.ImagenPictureBox)
        Me.Controls.Add(Me.TextoTextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "PublicacionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Publicación"
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextoTextBox As TextBox
    Friend WithEvents ImagenPictureBox As PictureBox
    Friend WithEvents ElegirImagenButton As Button
    Friend WithEvents ImagenLabel As Label
    Friend WithEvents ImagenTextBox As TextBox
    Friend WithEvents TextoLabel As Label
    Friend WithEvents PublicarButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PrivacidadComboBox As ComboBox
    Friend WithEvents CancelarButton As Button
    Friend WithEvents ActualizarButton As Button
    Friend WithEvents IdLabel As Label
End Class
