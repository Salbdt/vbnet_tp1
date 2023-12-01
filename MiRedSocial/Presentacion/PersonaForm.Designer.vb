<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonaForm
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
        Me.IdPersonaLabel = New System.Windows.Forms.Label()
        Me.TelefonoLabel = New System.Windows.Forms.Label()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.DomicilioLabel = New System.Windows.Forms.Label()
        Me.DomicilioTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoLabel = New System.Windows.Forms.Label()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.NumDocumentoLabel = New System.Windows.Forms.Label()
        Me.NumDocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.TipoDocumentoLabel = New System.Windows.Forms.Label()
        Me.TipoDocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.IdUsuarioLabel = New System.Windows.Forms.Label()
        Me.ClaveLabel = New System.Windows.Forms.Label()
        Me.ClaveTextBox = New System.Windows.Forms.TextBox()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.ActualizarButton = New System.Windows.Forms.Button()
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'IdPersonaLabel
        '
        Me.IdPersonaLabel.AutoSize = True
        Me.IdPersonaLabel.Location = New System.Drawing.Point(407, 14)
        Me.IdPersonaLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IdPersonaLabel.Name = "IdPersonaLabel"
        Me.IdPersonaLabel.Size = New System.Drawing.Size(89, 20)
        Me.IdPersonaLabel.TabIndex = 33
        Me.IdPersonaLabel.Text = "ID Persona"
        Me.IdPersonaLabel.Visible = False
        '
        'TelefonoLabel
        '
        Me.TelefonoLabel.Location = New System.Drawing.Point(13, 164)
        Me.TelefonoLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TelefonoLabel.Name = "TelefonoLabel"
        Me.TelefonoLabel.Size = New System.Drawing.Size(180, 20)
        Me.TelefonoLabel.TabIndex = 36
        Me.TelefonoLabel.Text = "Teléfono"
        Me.TelefonoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.Location = New System.Drawing.Point(200, 161)
        Me.TelefonoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.TelefonoTextBox.TabIndex = 6
        '
        'DomicilioLabel
        '
        Me.DomicilioLabel.Location = New System.Drawing.Point(13, 134)
        Me.DomicilioLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DomicilioLabel.Name = "DomicilioLabel"
        Me.DomicilioLabel.Size = New System.Drawing.Size(180, 20)
        Me.DomicilioLabel.TabIndex = 35
        Me.DomicilioLabel.Text = "Domicilio"
        Me.DomicilioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DomicilioTextBox
        '
        Me.DomicilioTextBox.Location = New System.Drawing.Point(200, 131)
        Me.DomicilioTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DomicilioTextBox.Name = "DomicilioTextBox"
        Me.DomicilioTextBox.Size = New System.Drawing.Size(200, 26)
        Me.DomicilioTextBox.TabIndex = 5
        '
        'ApellidoLabel
        '
        Me.ApellidoLabel.Location = New System.Drawing.Point(13, 44)
        Me.ApellidoLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ApellidoLabel.Name = "ApellidoLabel"
        Me.ApellidoLabel.Size = New System.Drawing.Size(180, 20)
        Me.ApellidoLabel.TabIndex = 34
        Me.ApellidoLabel.Text = "Apellido"
        Me.ApellidoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.Location = New System.Drawing.Point(200, 41)
        Me.ApellidoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ApellidoTextBox.TabIndex = 2
        '
        'NumDocumentoLabel
        '
        Me.NumDocumentoLabel.Location = New System.Drawing.Point(13, 104)
        Me.NumDocumentoLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NumDocumentoLabel.Name = "NumDocumentoLabel"
        Me.NumDocumentoLabel.Size = New System.Drawing.Size(180, 20)
        Me.NumDocumentoLabel.TabIndex = 32
        Me.NumDocumentoLabel.Text = "Número Documento"
        Me.NumDocumentoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumDocumentoTextBox
        '
        Me.NumDocumentoTextBox.Location = New System.Drawing.Point(200, 101)
        Me.NumDocumentoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumDocumentoTextBox.Name = "NumDocumentoTextBox"
        Me.NumDocumentoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NumDocumentoTextBox.TabIndex = 4
        '
        'TipoDocumentoLabel
        '
        Me.TipoDocumentoLabel.Location = New System.Drawing.Point(13, 74)
        Me.TipoDocumentoLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TipoDocumentoLabel.Name = "TipoDocumentoLabel"
        Me.TipoDocumentoLabel.Size = New System.Drawing.Size(180, 20)
        Me.TipoDocumentoLabel.TabIndex = 29
        Me.TipoDocumentoLabel.Text = "Tipo Documento"
        Me.TipoDocumentoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TipoDocumentoTextBox
        '
        Me.TipoDocumentoTextBox.Location = New System.Drawing.Point(200, 71)
        Me.TipoDocumentoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TipoDocumentoTextBox.Name = "TipoDocumentoTextBox"
        Me.TipoDocumentoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.TipoDocumentoTextBox.TabIndex = 3
        '
        'NombreLabel
        '
        Me.NombreLabel.Location = New System.Drawing.Point(13, 14)
        Me.NombreLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(180, 20)
        Me.NombreLabel.TabIndex = 24
        Me.NombreLabel.Text = "Nombre"
        Me.NombreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Location = New System.Drawing.Point(200, 11)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NombreTextBox.TabIndex = 1
        '
        'IdUsuarioLabel
        '
        Me.IdUsuarioLabel.AutoSize = True
        Me.IdUsuarioLabel.Location = New System.Drawing.Point(507, 224)
        Me.IdUsuarioLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IdUsuarioLabel.Name = "IdUsuarioLabel"
        Me.IdUsuarioLabel.Size = New System.Drawing.Size(85, 20)
        Me.IdUsuarioLabel.TabIndex = 37
        Me.IdUsuarioLabel.Text = "ID Usuario"
        Me.IdUsuarioLabel.Visible = False
        '
        'ClaveLabel
        '
        Me.ClaveLabel.Location = New System.Drawing.Point(13, 251)
        Me.ClaveLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ClaveLabel.Name = "ClaveLabel"
        Me.ClaveLabel.Size = New System.Drawing.Size(180, 20)
        Me.ClaveLabel.TabIndex = 41
        Me.ClaveLabel.Text = "Clave (*)"
        Me.ClaveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ClaveTextBox
        '
        Me.ClaveTextBox.Location = New System.Drawing.Point(200, 251)
        Me.ClaveTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClaveTextBox.Name = "ClaveTextBox"
        Me.ClaveTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.ClaveTextBox.Size = New System.Drawing.Size(300, 26)
        Me.ClaveTextBox.TabIndex = 8
        '
        'EmailLabel
        '
        Me.EmailLabel.Location = New System.Drawing.Point(13, 224)
        Me.EmailLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(180, 20)
        Me.EmailLabel.TabIndex = 40
        Me.EmailLabel.Text = "Email (*)"
        Me.EmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(200, 221)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(300, 26)
        Me.EmailTextBox.TabIndex = 7
        '
        'ActualizarButton
        '
        Me.ActualizarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ActualizarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActualizarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ActualizarButton.Location = New System.Drawing.Point(371, 287)
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
        Me.CancelarButton.Location = New System.Drawing.Point(483, 287)
        Me.CancelarButton.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(100, 26)
        Me.CancelarButton.TabIndex = 10
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'PersonaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(598, 330)
        Me.Controls.Add(Me.ActualizarButton)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.IdUsuarioLabel)
        Me.Controls.Add(Me.ClaveLabel)
        Me.Controls.Add(Me.ClaveTextBox)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.IdPersonaLabel)
        Me.Controls.Add(Me.TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(Me.DomicilioLabel)
        Me.Controls.Add(Me.DomicilioTextBox)
        Me.Controls.Add(Me.ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(Me.NumDocumentoLabel)
        Me.Controls.Add(Me.NumDocumentoTextBox)
        Me.Controls.Add(Me.TipoDocumentoLabel)
        Me.Controls.Add(Me.TipoDocumentoTextBox)
        Me.Controls.Add(Me.NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "PersonaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mis datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IdPersonaLabel As Label
    Friend WithEvents TelefonoLabel As Label
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents DomicilioLabel As Label
    Friend WithEvents DomicilioTextBox As TextBox
    Friend WithEvents ApellidoLabel As Label
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents NumDocumentoLabel As Label
    Friend WithEvents NumDocumentoTextBox As TextBox
    Friend WithEvents TipoDocumentoLabel As Label
    Friend WithEvents TipoDocumentoTextBox As TextBox
    Friend WithEvents NombreLabel As Label
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents IdUsuarioLabel As Label
    Friend WithEvents ClaveLabel As Label
    Friend WithEvents ClaveTextBox As TextBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents ActualizarButton As Button
    Friend WithEvents CancelarButton As Button
End Class
