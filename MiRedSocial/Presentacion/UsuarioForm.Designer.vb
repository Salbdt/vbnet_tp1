<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuarioForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ElegirAvatarButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.idLabel = New System.Windows.Forms.Label()
        Me.AvatarTextBox = New System.Windows.Forms.TextBox()
        Me.AvatarPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ClaveTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NombreUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.RolesComboBox = New System.Windows.Forms.ComboBox()
        Me.ActualizarButton = New System.Windows.Forms.Button()
        Me.CancelarButton = New System.Windows.Forms.Button()
        CType(Me.AvatarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElegirAvatarButton
        '
        Me.ElegirAvatarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ElegirAvatarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ElegirAvatarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ElegirAvatarButton.Location = New System.Drawing.Point(736, 14)
        Me.ElegirAvatarButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ElegirAvatarButton.Name = "ElegirAvatarButton"
        Me.ElegirAvatarButton.Size = New System.Drawing.Size(50, 26)
        Me.ElegirAvatarButton.TabIndex = 30
        Me.ElegirAvatarButton.Text = "..."
        Me.ElegirAvatarButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Location = New System.Drawing.Point(401, 17)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 20)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Avatar"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'idLabel
        '
        Me.idLabel.AutoSize = True
        Me.idLabel.Location = New System.Drawing.Point(349, 13)
        Me.idLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.idLabel.Name = "idLabel"
        Me.idLabel.Size = New System.Drawing.Size(18, 13)
        Me.idLabel.TabIndex = 22
        Me.idLabel.Text = "ID"
        Me.idLabel.Visible = False
        '
        'AvatarTextBox
        '
        Me.AvatarTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AvatarTextBox.Location = New System.Drawing.Point(529, 14)
        Me.AvatarTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AvatarTextBox.Name = "AvatarTextBox"
        Me.AvatarTextBox.ReadOnly = True
        Me.AvatarTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AvatarTextBox.TabIndex = 32
        '
        'AvatarPictureBox
        '
        Me.AvatarPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AvatarPictureBox.Location = New System.Drawing.Point(529, 47)
        Me.AvatarPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AvatarPictureBox.Name = "AvatarPictureBox"
        Me.AvatarPictureBox.Size = New System.Drawing.Size(200, 200)
        Me.AvatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AvatarPictureBox.TabIndex = 31
        Me.AvatarPictureBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(13, 175)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Clave (*)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ClaveTextBox
        '
        Me.ClaveTextBox.Location = New System.Drawing.Point(141, 173)
        Me.ClaveTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClaveTextBox.Name = "ClaveTextBox"
        Me.ClaveTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.ClaveTextBox.Size = New System.Drawing.Size(302, 20)
        Me.ClaveTextBox.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(13, 143)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Email (*)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(141, 140)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(302, 20)
        Me.EmailTextBox.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Rol (*)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(13, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nombre (*)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NombreUsuarioTextBox
        '
        Me.NombreUsuarioTextBox.Location = New System.Drawing.Point(141, 44)
        Me.NombreUsuarioTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NombreUsuarioTextBox.Name = "NombreUsuarioTextBox"
        Me.NombreUsuarioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombreUsuarioTextBox.TabIndex = 26
        '
        'RolesComboBox
        '
        Me.RolesComboBox.FormattingEnabled = True
        Me.RolesComboBox.Location = New System.Drawing.Point(141, 10)
        Me.RolesComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RolesComboBox.Name = "RolesComboBox"
        Me.RolesComboBox.Size = New System.Drawing.Size(200, 21)
        Me.RolesComboBox.TabIndex = 25
        '
        'ActualizarButton
        '
        Me.ActualizarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActualizarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ActualizarButton.Location = New System.Drawing.Point(13, 263)
        Me.ActualizarButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ActualizarButton.Name = "ActualizarButton"
        Me.ActualizarButton.Size = New System.Drawing.Size(100, 26)
        Me.ActualizarButton.TabIndex = 35
        Me.ActualizarButton.Text = "Actualizar"
        Me.ActualizarButton.UseVisualStyleBackColor = True
        '
        'CancelarButton
        '
        Me.CancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CancelarButton.Location = New System.Drawing.Point(121, 263)
        Me.CancelarButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(100, 26)
        Me.CancelarButton.TabIndex = 36
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'UsuarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 303)
        Me.Controls.Add(Me.ActualizarButton)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.ElegirAvatarButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.idLabel)
        Me.Controls.Add(Me.AvatarTextBox)
        Me.Controls.Add(Me.AvatarPictureBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ClaveTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NombreUsuarioTextBox)
        Me.Controls.Add(Me.RolesComboBox)
        Me.Name = "UsuarioForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UsuarioForm"
        CType(Me.AvatarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ElegirAvatarButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents idLabel As Label
    Friend WithEvents AvatarTextBox As TextBox
    Friend WithEvents AvatarPictureBox As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ClaveTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NombreUsuarioTextBox As TextBox
    Friend WithEvents RolesComboBox As ComboBox
    Friend WithEvents ActualizarButton As Button
    Friend WithEvents CancelarButton As Button
End Class
