<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClaveTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IngresarButton As System.Windows.Forms.Button
    Friend WithEvents SalirButton As System.Windows.Forms.Button

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.ClaveTextBox = New System.Windows.Forms.TextBox()
        Me.IngresarButton = New System.Windows.Forms.Button()
        Me.SalirButton = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(258, 37)
        Me.UsernameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(330, 35)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "Email"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(258, 125)
        Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(330, 35)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Clave"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(261, 68)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(328, 26)
        Me.EmailTextBox.TabIndex = 1
        '
        'ClaveTextBox
        '
        Me.ClaveTextBox.Location = New System.Drawing.Point(261, 155)
        Me.ClaveTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ClaveTextBox.Name = "ClaveTextBox"
        Me.ClaveTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ClaveTextBox.Size = New System.Drawing.Size(328, 26)
        Me.ClaveTextBox.TabIndex = 3
        '
        'IngresarButton
        '
        Me.IngresarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IngresarButton.Location = New System.Drawing.Point(299, 215)
        Me.IngresarButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IngresarButton.Name = "IngresarButton"
        Me.IngresarButton.Size = New System.Drawing.Size(141, 35)
        Me.IngresarButton.TabIndex = 4
        Me.IngresarButton.Text = "Ingresar"
        '
        'SalirButton
        '
        Me.SalirButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SalirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalirButton.Location = New System.Drawing.Point(448, 215)
        Me.SalirButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SalirButton.Name = "SalirButton"
        Me.SalirButton.Size = New System.Drawing.Size(141, 35)
        Me.SalirButton.TabIndex = 5
        Me.SalirButton.Text = "Salir"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(603, 297)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.Location = New System.Drawing.Point(299, 255)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(289, 31)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Registrarse"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LoginForm
        '
        Me.AcceptButton = Me.IngresarButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.SalirButton
        Me.ClientSize = New System.Drawing.Size(602, 295)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.SalirButton)
        Me.Controls.Add(Me.IngresarButton)
        Me.Controls.Add(Me.ClaveTextBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesión"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
End Class
