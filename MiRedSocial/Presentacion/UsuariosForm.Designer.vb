<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsuariosForm
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ListadoDataGridView = New System.Windows.Forms.DataGridView()
        Me.TotalUsuariosLabel = New System.Windows.Forms.Label()
        Me.BuscarTextBox = New System.Windows.Forms.TextBox()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.EliminarButton = New System.Windows.Forms.Button()
        Me.DesactivarButton = New System.Windows.Forms.Button()
        Me.ActivarButton = New System.Windows.Forms.Button()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.ListaTabPage = New System.Windows.Forms.TabPage()
        Me.MantenimientoTabPage = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DomicilioTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumeroDocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TipoDocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        CType(Me.ListadoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.ListaTabPage.SuspendLayout()
        Me.MantenimientoTabPage.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AvatarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListadoDataGridView
        '
        Me.ListadoDataGridView.AllowUserToAddRows = False
        Me.ListadoDataGridView.AllowUserToDeleteRows = False
        Me.ListadoDataGridView.AllowUserToResizeRows = False
        Me.ListadoDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ListadoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListadoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListadoDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.ListadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListadoDataGridView.DefaultCellStyle = DataGridViewCellStyle11
        Me.ListadoDataGridView.Location = New System.Drawing.Point(7, 44)
        Me.ListadoDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListadoDataGridView.Name = "ListadoDataGridView"
        Me.ListadoDataGridView.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListadoDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.ListadoDataGridView.RowHeadersVisible = False
        Me.ListadoDataGridView.RowTemplate.Height = 30
        Me.ListadoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListadoDataGridView.Size = New System.Drawing.Size(840, 516)
        Me.ListadoDataGridView.TabIndex = 3
        '
        'TotalUsuariosLabel
        '
        Me.TotalUsuariosLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalUsuariosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalUsuariosLabel.Location = New System.Drawing.Point(667, 570)
        Me.TotalUsuariosLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 0)
        Me.TotalUsuariosLabel.Name = "TotalUsuariosLabel"
        Me.TotalUsuariosLabel.Size = New System.Drawing.Size(180, 31)
        Me.TotalUsuariosLabel.TabIndex = 3
        Me.TotalUsuariosLabel.Text = "Usuarios: 000"
        Me.TotalUsuariosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BuscarTextBox
        '
        Me.BuscarTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BuscarTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarTextBox.Location = New System.Drawing.Point(7, 8)
        Me.BuscarTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BuscarTextBox.MaxLength = 50
        Me.BuscarTextBox.Name = "BuscarTextBox"
        Me.BuscarTextBox.Size = New System.Drawing.Size(200, 26)
        Me.BuscarTextBox.TabIndex = 1
        '
        'BuscarButton
        '
        Me.BuscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BuscarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BuscarButton.Location = New System.Drawing.Point(215, 8)
        Me.BuscarButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(100, 26)
        Me.BuscarButton.TabIndex = 2
        Me.BuscarButton.Text = "Buscar"
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'EliminarButton
        '
        Me.EliminarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EliminarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.EliminarButton.Location = New System.Drawing.Point(223, 570)
        Me.EliminarButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EliminarButton.Name = "EliminarButton"
        Me.EliminarButton.Size = New System.Drawing.Size(100, 26)
        Me.EliminarButton.TabIndex = 6
        Me.EliminarButton.Text = "Eliminar"
        Me.EliminarButton.UseVisualStyleBackColor = True
        '
        'DesactivarButton
        '
        Me.DesactivarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DesactivarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DesactivarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DesactivarButton.Location = New System.Drawing.Point(115, 570)
        Me.DesactivarButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DesactivarButton.Name = "DesactivarButton"
        Me.DesactivarButton.Size = New System.Drawing.Size(100, 26)
        Me.DesactivarButton.TabIndex = 5
        Me.DesactivarButton.Text = "Desactivar"
        Me.DesactivarButton.UseVisualStyleBackColor = True
        '
        'ActivarButton
        '
        Me.ActivarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ActivarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActivarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ActivarButton.Location = New System.Drawing.Point(7, 570)
        Me.ActivarButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ActivarButton.Name = "ActivarButton"
        Me.ActivarButton.Size = New System.Drawing.Size(100, 26)
        Me.ActivarButton.TabIndex = 4
        Me.ActivarButton.Text = "Activar"
        Me.ActivarButton.UseVisualStyleBackColor = True
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.ListaTabPage)
        Me.TabControl.Controls.Add(Me.MantenimientoTabPage)
        Me.TabControl.Location = New System.Drawing.Point(12, 12)
        Me.TabControl.Multiline = True
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(862, 637)
        Me.TabControl.TabIndex = 1
        '
        'ListaTabPage
        '
        Me.ListaTabPage.Controls.Add(Me.BuscarTextBox)
        Me.ListaTabPage.Controls.Add(Me.ActivarButton)
        Me.ListaTabPage.Controls.Add(Me.BuscarButton)
        Me.ListaTabPage.Controls.Add(Me.DesactivarButton)
        Me.ListaTabPage.Controls.Add(Me.TotalUsuariosLabel)
        Me.ListaTabPage.Controls.Add(Me.EliminarButton)
        Me.ListaTabPage.Controls.Add(Me.ListadoDataGridView)
        Me.ListaTabPage.Location = New System.Drawing.Point(4, 29)
        Me.ListaTabPage.Name = "ListaTabPage"
        Me.ListaTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ListaTabPage.Size = New System.Drawing.Size(854, 604)
        Me.ListaTabPage.TabIndex = 0
        Me.ListaTabPage.Text = "Lista"
        Me.ListaTabPage.UseVisualStyleBackColor = True
        '
        'MantenimientoTabPage
        '
        Me.MantenimientoTabPage.Controls.Add(Me.GroupBox2)
        Me.MantenimientoTabPage.Controls.Add(Me.GroupBox1)
        Me.MantenimientoTabPage.Location = New System.Drawing.Point(4, 29)
        Me.MantenimientoTabPage.Name = "MantenimientoTabPage"
        Me.MantenimientoTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.MantenimientoTabPage.Size = New System.Drawing.Size(854, 604)
        Me.MantenimientoTabPage.TabIndex = 1
        Me.MantenimientoTabPage.Text = "Mantenimiento"
        Me.MantenimientoTabPage.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TelefonoTextBox)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.DomicilioTextBox)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.ApellidoTextBox)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.NumeroDocumentoTextBox)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TipoDocumentoTextBox)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.NombreTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 307)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(838, 289)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mis datos"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 190)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(180, 20)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Teléfono"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.Location = New System.Drawing.Point(196, 187)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TelefonoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.TelefonoTextBox.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 158)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Domicilio"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DomicilioTextBox
        '
        Me.DomicilioTextBox.Location = New System.Drawing.Point(196, 155)
        Me.DomicilioTextBox.Name = "DomicilioTextBox"
        Me.DomicilioTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.DomicilioTextBox.Size = New System.Drawing.Size(200, 26)
        Me.DomicilioTextBox.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 60)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(180, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Apellido (*)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.Location = New System.Drawing.Point(196, 57)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ApellidoTextBox.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 126)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(180, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Número Documento"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumeroDocumentoTextBox
        '
        Me.NumeroDocumentoTextBox.Location = New System.Drawing.Point(196, 123)
        Me.NumeroDocumentoTextBox.Name = "NumeroDocumentoTextBox"
        Me.NumeroDocumentoTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.NumeroDocumentoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NumeroDocumentoTextBox.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 94)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(180, 20)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Tipo Documento"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TipoDocumentoTextBox
        '
        Me.TipoDocumentoTextBox.Location = New System.Drawing.Point(196, 91)
        Me.TipoDocumentoTextBox.Name = "TipoDocumentoTextBox"
        Me.TipoDocumentoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.TipoDocumentoTextBox.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 28)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(180, 20)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Nombre (*)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Location = New System.Drawing.Point(196, 25)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NombreTextBox.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ElegirAvatarButton)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.idLabel)
        Me.GroupBox1.Controls.Add(Me.AvatarTextBox)
        Me.GroupBox1.Controls.Add(Me.AvatarPictureBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ClaveTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NombreUsuarioTextBox)
        Me.GroupBox1.Controls.Add(Me.RolesComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(838, 289)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuario"
        '
        'ElegirAvatarButton
        '
        Me.ElegirAvatarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ElegirAvatarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ElegirAvatarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ElegirAvatarButton.Location = New System.Drawing.Point(781, 25)
        Me.ElegirAvatarButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ElegirAvatarButton.Name = "ElegirAvatarButton"
        Me.ElegirAvatarButton.Size = New System.Drawing.Size(50, 26)
        Me.ElegirAvatarButton.TabIndex = 5
        Me.ElegirAvatarButton.Text = "..."
        Me.ElegirAvatarButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Location = New System.Drawing.Point(446, 28)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Avatar"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'idLabel
        '
        Me.idLabel.AutoSize = True
        Me.idLabel.Location = New System.Drawing.Point(344, 27)
        Me.idLabel.Margin = New System.Windows.Forms.Padding(5)
        Me.idLabel.Name = "idLabel"
        Me.idLabel.Size = New System.Drawing.Size(26, 20)
        Me.idLabel.TabIndex = 0
        Me.idLabel.Text = "ID"
        Me.idLabel.Visible = False
        '
        'AvatarTextBox
        '
        Me.AvatarTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AvatarTextBox.Location = New System.Drawing.Point(574, 25)
        Me.AvatarTextBox.Name = "AvatarTextBox"
        Me.AvatarTextBox.ReadOnly = True
        Me.AvatarTextBox.Size = New System.Drawing.Size(200, 26)
        Me.AvatarTextBox.TabIndex = 6
        '
        'AvatarPictureBox
        '
        Me.AvatarPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AvatarPictureBox.Location = New System.Drawing.Point(574, 57)
        Me.AvatarPictureBox.Name = "AvatarPictureBox"
        Me.AvatarPictureBox.Size = New System.Drawing.Size(200, 200)
        Me.AvatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AvatarPictureBox.TabIndex = 5
        Me.AvatarPictureBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 190)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Clave (*)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ClaveTextBox
        '
        Me.ClaveTextBox.Location = New System.Drawing.Point(136, 187)
        Me.ClaveTextBox.Name = "ClaveTextBox"
        Me.ClaveTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.ClaveTextBox.Size = New System.Drawing.Size(302, 26)
        Me.ClaveTextBox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 158)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Email (*)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(136, 155)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(302, 26)
        Me.EmailTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Rol (*)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre (*)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NombreUsuarioTextBox
        '
        Me.NombreUsuarioTextBox.Location = New System.Drawing.Point(136, 59)
        Me.NombreUsuarioTextBox.Name = "NombreUsuarioTextBox"
        Me.NombreUsuarioTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NombreUsuarioTextBox.TabIndex = 2
        '
        'RolesComboBox
        '
        Me.RolesComboBox.FormattingEnabled = True
        Me.RolesComboBox.Location = New System.Drawing.Point(136, 25)
        Me.RolesComboBox.Name = "RolesComboBox"
        Me.RolesComboBox.Size = New System.Drawing.Size(200, 28)
        Me.RolesComboBox.TabIndex = 1
        '
        'UsuariosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(886, 661)
        Me.Controls.Add(Me.TabControl)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "UsuariosForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UsuariosForm"
        CType(Me.ListadoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.ListaTabPage.ResumeLayout(False)
        Me.ListaTabPage.PerformLayout()
        Me.MantenimientoTabPage.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AvatarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListadoDataGridView As DataGridView
    Friend WithEvents TotalUsuariosLabel As Label
    Friend WithEvents BuscarTextBox As TextBox
    Friend WithEvents BuscarButton As Button
    Friend WithEvents EliminarButton As Button
    Friend WithEvents DesactivarButton As Button
    Friend WithEvents ActivarButton As Button
    Friend WithEvents TabControl As TabControl
    Friend WithEvents ListaTabPage As TabPage
    Friend WithEvents MantenimientoTabPage As TabPage
    Friend WithEvents idLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NombreUsuarioTextBox As TextBox
    Friend WithEvents RolesComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ClaveTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents ElegirAvatarButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents AvatarTextBox As TextBox
    Friend WithEvents AvatarPictureBox As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents NumeroDocumentoTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TipoDocumentoTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DomicilioTextBox As TextBox
End Class
