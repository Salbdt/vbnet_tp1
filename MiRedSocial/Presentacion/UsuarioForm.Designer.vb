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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ClaveNuevaTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EmailNuevoTextBox = New System.Windows.Forms.TextBox()
        CType(Me.AvatarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElegirAvatarButton
        '
        Me.ElegirAvatarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ElegirAvatarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ElegirAvatarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ElegirAvatarButton.Location = New System.Drawing.Point(821, 22)
        Me.ElegirAvatarButton.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ElegirAvatarButton.Name = "ElegirAvatarButton"
        Me.ElegirAvatarButton.Size = New System.Drawing.Size(50, 26)
        Me.ElegirAvatarButton.TabIndex = 7
        Me.ElegirAvatarButton.Text = "..."
        Me.ElegirAvatarButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Location = New System.Drawing.Point(478, 25)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 20)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Avatar"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'idLabel
        '
        Me.idLabel.AutoSize = True
        Me.idLabel.Location = New System.Drawing.Point(355, 19)
        Me.idLabel.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.idLabel.Name = "idLabel"
        Me.idLabel.Size = New System.Drawing.Size(26, 20)
        Me.idLabel.TabIndex = 22
        Me.idLabel.Text = "ID"
        Me.idLabel.Visible = False
        '
        'AvatarTextBox
        '
        Me.AvatarTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AvatarTextBox.Location = New System.Drawing.Point(611, 22)
        Me.AvatarTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AvatarTextBox.Name = "AvatarTextBox"
        Me.AvatarTextBox.ReadOnly = True
        Me.AvatarTextBox.Size = New System.Drawing.Size(200, 26)
        Me.AvatarTextBox.TabIndex = 8
        '
        'AvatarPictureBox
        '
        Me.AvatarPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AvatarPictureBox.Location = New System.Drawing.Point(611, 54)
        Me.AvatarPictureBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AvatarPictureBox.Name = "AvatarPictureBox"
        Me.AvatarPictureBox.Size = New System.Drawing.Size(200, 200)
        Me.AvatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AvatarPictureBox.TabIndex = 31
        Me.AvatarPictureBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(15, 213)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Clave (*)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ClaveTextBox
        '
        Me.ClaveTextBox.Location = New System.Drawing.Point(145, 210)
        Me.ClaveTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ClaveTextBox.Name = "ClaveTextBox"
        Me.ClaveTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.ClaveTextBox.Size = New System.Drawing.Size(300, 26)
        Me.ClaveTextBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(15, 149)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Email (*)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(145, 146)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(300, 26)
        Me.EmailTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Rol (*)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(15, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nombre (*)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NombreUsuarioTextBox
        '
        Me.NombreUsuarioTextBox.Location = New System.Drawing.Point(145, 50)
        Me.NombreUsuarioTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NombreUsuarioTextBox.Name = "NombreUsuarioTextBox"
        Me.NombreUsuarioTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NombreUsuarioTextBox.TabIndex = 2
        '
        'RolesComboBox
        '
        Me.RolesComboBox.FormattingEnabled = True
        Me.RolesComboBox.Location = New System.Drawing.Point(145, 16)
        Me.RolesComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RolesComboBox.Name = "RolesComboBox"
        Me.RolesComboBox.Size = New System.Drawing.Size(200, 28)
        Me.RolesComboBox.TabIndex = 1
        '
        'ActualizarButton
        '
        Me.ActualizarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ActualizarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActualizarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ActualizarButton.Location = New System.Drawing.Point(659, 279)
        Me.ActualizarButton.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ActualizarButton.Name = "ActualizarButton"
        Me.ActualizarButton.Size = New System.Drawing.Size(100, 26)
        Me.ActualizarButton.TabIndex = 9
        Me.ActualizarButton.Text = "Actualizar"
        Me.ActualizarButton.UseVisualStyleBackColor = True
        '
        'CancelarButton
        '
        Me.CancelarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CancelarButton.Location = New System.Drawing.Point(771, 279)
        Me.CancelarButton.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(100, 26)
        Me.CancelarButton.TabIndex = 10
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(15, 245)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 20)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Nueva clave"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ClaveNuevaTextBox
        '
        Me.ClaveNuevaTextBox.Location = New System.Drawing.Point(145, 242)
        Me.ClaveNuevaTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ClaveNuevaTextBox.Name = "ClaveNuevaTextBox"
        Me.ClaveNuevaTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.ClaveNuevaTextBox.Size = New System.Drawing.Size(300, 26)
        Me.ClaveNuevaTextBox.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(15, 181)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 20)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Nuevo email"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmailNuevoTextBox
        '
        Me.EmailNuevoTextBox.Location = New System.Drawing.Point(145, 178)
        Me.EmailNuevoTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EmailNuevoTextBox.Name = "EmailNuevoTextBox"
        Me.EmailNuevoTextBox.Size = New System.Drawing.Size(300, 26)
        Me.EmailNuevoTextBox.TabIndex = 4
        '
        'UsuarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 322)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.EmailNuevoTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ClaveNuevaTextBox)
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
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
    Friend WithEvents Label6 As Label
    Friend WithEvents ClaveNuevaTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents EmailNuevoTextBox As TextBox
End Class
