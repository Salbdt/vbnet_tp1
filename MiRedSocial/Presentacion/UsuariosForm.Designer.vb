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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.ActualizarButton = New System.Windows.Forms.Button()
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.InsertarButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ElegirAvatarButton = New System.Windows.Forms.Button()
        Me.AvatarLabel = New System.Windows.Forms.Label()
        Me.IdUsuarioLabel = New System.Windows.Forms.Label()
        Me.AvatarTextBox = New System.Windows.Forms.TextBox()
        Me.AvatarPictureBox = New System.Windows.Forms.PictureBox()
        Me.ClaveLabel = New System.Windows.Forms.Label()
        Me.ClaveTextBox = New System.Windows.Forms.TextBox()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.RolLabel = New System.Windows.Forms.Label()
        Me.NombreUsuarioLabel = New System.Windows.Forms.Label()
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListadoDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.ListadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListadoDataGridView.DefaultCellStyle = DataGridViewCellStyle8
        Me.ListadoDataGridView.Location = New System.Drawing.Point(7, 44)
        Me.ListadoDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListadoDataGridView.Name = "ListadoDataGridView"
        Me.ListadoDataGridView.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListadoDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.ListadoDataGridView.RowHeadersVisible = False
        Me.ListadoDataGridView.RowTemplate.Height = 30
        Me.ListadoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListadoDataGridView.Size = New System.Drawing.Size(840, 467)
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
        Me.EliminarButton.Location = New System.Drawing.Point(223, 521)
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
        Me.DesactivarButton.Location = New System.Drawing.Point(115, 521)
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
        Me.ActivarButton.Location = New System.Drawing.Point(7, 521)
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
        Me.TabControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl.Multiline = True
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(862, 587)
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
        Me.ListaTabPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListaTabPage.Name = "ListaTabPage"
        Me.ListaTabPage.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListaTabPage.Size = New System.Drawing.Size(854, 554)
        Me.ListaTabPage.TabIndex = 0
        Me.ListaTabPage.Text = "Lista"
        Me.ListaTabPage.UseVisualStyleBackColor = True
        '
        'MantenimientoTabPage
        '
        Me.MantenimientoTabPage.Controls.Add(Me.ActualizarButton)
        Me.MantenimientoTabPage.Controls.Add(Me.CancelarButton)
        Me.MantenimientoTabPage.Controls.Add(Me.InsertarButton)
        Me.MantenimientoTabPage.Controls.Add(Me.GroupBox2)
        Me.MantenimientoTabPage.Controls.Add(Me.GroupBox1)
        Me.MantenimientoTabPage.Location = New System.Drawing.Point(4, 29)
        Me.MantenimientoTabPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MantenimientoTabPage.Name = "MantenimientoTabPage"
        Me.MantenimientoTabPage.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MantenimientoTabPage.Size = New System.Drawing.Size(854, 554)
        Me.MantenimientoTabPage.TabIndex = 1
        Me.MantenimientoTabPage.Text = "Ingresar"
        Me.MantenimientoTabPage.UseVisualStyleBackColor = True
        '
        'ActualizarButton
        '
        Me.ActualizarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActualizarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ActualizarButton.Location = New System.Drawing.Point(8, 519)
        Me.ActualizarButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ActualizarButton.Name = "ActualizarButton"
        Me.ActualizarButton.Size = New System.Drawing.Size(100, 26)
        Me.ActualizarButton.TabIndex = 4
        Me.ActualizarButton.Text = "Actualizar"
        Me.ActualizarButton.UseVisualStyleBackColor = True
        '
        'CancelarButton
        '
        Me.CancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CancelarButton.Location = New System.Drawing.Point(116, 519)
        Me.CancelarButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(100, 26)
        Me.CancelarButton.TabIndex = 5
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'InsertarButton
        '
        Me.InsertarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InsertarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.InsertarButton.Location = New System.Drawing.Point(8, 519)
        Me.InsertarButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.InsertarButton.Name = "InsertarButton"
        Me.InsertarButton.Size = New System.Drawing.Size(100, 26)
        Me.InsertarButton.TabIndex = 3
        Me.InsertarButton.Text = "Insertar"
        Me.InsertarButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.IdPersonaLabel)
        Me.GroupBox2.Controls.Add(Me.TelefonoLabel)
        Me.GroupBox2.Controls.Add(Me.TelefonoTextBox)
        Me.GroupBox2.Controls.Add(Me.DomicilioLabel)
        Me.GroupBox2.Controls.Add(Me.DomicilioTextBox)
        Me.GroupBox2.Controls.Add(Me.ApellidoLabel)
        Me.GroupBox2.Controls.Add(Me.ApellidoTextBox)
        Me.GroupBox2.Controls.Add(Me.NumDocumentoLabel)
        Me.GroupBox2.Controls.Add(Me.NumDocumentoTextBox)
        Me.GroupBox2.Controls.Add(Me.TipoDocumentoLabel)
        Me.GroupBox2.Controls.Add(Me.TipoDocumentoTextBox)
        Me.GroupBox2.Controls.Add(Me.NombreLabel)
        Me.GroupBox2.Controls.Add(Me.NombreTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 285)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(838, 224)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mis datos"
        '
        'IdPersonaLabel
        '
        Me.IdPersonaLabel.AutoSize = True
        Me.IdPersonaLabel.Location = New System.Drawing.Point(403, 28)
        Me.IdPersonaLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IdPersonaLabel.Name = "IdPersonaLabel"
        Me.IdPersonaLabel.Size = New System.Drawing.Size(89, 20)
        Me.IdPersonaLabel.TabIndex = 9
        Me.IdPersonaLabel.Text = "ID Persona"
        Me.IdPersonaLabel.Visible = False
        '
        'TelefonoLabel
        '
        Me.TelefonoLabel.Location = New System.Drawing.Point(8, 190)
        Me.TelefonoLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TelefonoLabel.Name = "TelefonoLabel"
        Me.TelefonoLabel.Size = New System.Drawing.Size(180, 20)
        Me.TelefonoLabel.TabIndex = 15
        Me.TelefonoLabel.Text = "Teléfono"
        Me.TelefonoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.Location = New System.Drawing.Point(196, 188)
        Me.TelefonoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.TelefonoTextBox.TabIndex = 6
        '
        'DomicilioLabel
        '
        Me.DomicilioLabel.Location = New System.Drawing.Point(8, 158)
        Me.DomicilioLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DomicilioLabel.Name = "DomicilioLabel"
        Me.DomicilioLabel.Size = New System.Drawing.Size(180, 20)
        Me.DomicilioLabel.TabIndex = 13
        Me.DomicilioLabel.Text = "Domicilio"
        Me.DomicilioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DomicilioTextBox
        '
        Me.DomicilioTextBox.Location = New System.Drawing.Point(196, 155)
        Me.DomicilioTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DomicilioTextBox.Name = "DomicilioTextBox"
        Me.DomicilioTextBox.Size = New System.Drawing.Size(200, 26)
        Me.DomicilioTextBox.TabIndex = 5
        '
        'ApellidoLabel
        '
        Me.ApellidoLabel.Location = New System.Drawing.Point(8, 60)
        Me.ApellidoLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ApellidoLabel.Name = "ApellidoLabel"
        Me.ApellidoLabel.Size = New System.Drawing.Size(180, 20)
        Me.ApellidoLabel.TabIndex = 11
        Me.ApellidoLabel.Text = "Apellido (*)"
        Me.ApellidoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.Location = New System.Drawing.Point(196, 58)
        Me.ApellidoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ApellidoTextBox.TabIndex = 2
        '
        'NumDocumentoLabel
        '
        Me.NumDocumentoLabel.Location = New System.Drawing.Point(8, 126)
        Me.NumDocumentoLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NumDocumentoLabel.Name = "NumDocumentoLabel"
        Me.NumDocumentoLabel.Size = New System.Drawing.Size(180, 20)
        Me.NumDocumentoLabel.TabIndex = 6
        Me.NumDocumentoLabel.Text = "Número Documento"
        Me.NumDocumentoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumDocumentoTextBox
        '
        Me.NumDocumentoTextBox.Location = New System.Drawing.Point(196, 122)
        Me.NumDocumentoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumDocumentoTextBox.Name = "NumDocumentoTextBox"
        Me.NumDocumentoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NumDocumentoTextBox.TabIndex = 4
        '
        'TipoDocumentoLabel
        '
        Me.TipoDocumentoLabel.Location = New System.Drawing.Point(8, 94)
        Me.TipoDocumentoLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TipoDocumentoLabel.Name = "TipoDocumentoLabel"
        Me.TipoDocumentoLabel.Size = New System.Drawing.Size(180, 20)
        Me.TipoDocumentoLabel.TabIndex = 4
        Me.TipoDocumentoLabel.Text = "Tipo Documento"
        Me.TipoDocumentoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TipoDocumentoTextBox
        '
        Me.TipoDocumentoTextBox.Location = New System.Drawing.Point(196, 91)
        Me.TipoDocumentoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TipoDocumentoTextBox.Name = "TipoDocumentoTextBox"
        Me.TipoDocumentoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.TipoDocumentoTextBox.TabIndex = 3
        '
        'NombreLabel
        '
        Me.NombreLabel.Location = New System.Drawing.Point(8, 28)
        Me.NombreLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(180, 20)
        Me.NombreLabel.TabIndex = 1
        Me.NombreLabel.Text = "Nombre (*)"
        Me.NombreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Location = New System.Drawing.Point(196, 25)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.GroupBox1.Controls.Add(Me.AvatarLabel)
        Me.GroupBox1.Controls.Add(Me.IdUsuarioLabel)
        Me.GroupBox1.Controls.Add(Me.AvatarTextBox)
        Me.GroupBox1.Controls.Add(Me.AvatarPictureBox)
        Me.GroupBox1.Controls.Add(Me.ClaveLabel)
        Me.GroupBox1.Controls.Add(Me.ClaveTextBox)
        Me.GroupBox1.Controls.Add(Me.EmailLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(Me.RolLabel)
        Me.GroupBox1.Controls.Add(Me.NombreUsuarioLabel)
        Me.GroupBox1.Controls.Add(Me.NombreUsuarioTextBox)
        Me.GroupBox1.Controls.Add(Me.RolesComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(838, 267)
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
        'AvatarLabel
        '
        Me.AvatarLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AvatarLabel.Location = New System.Drawing.Point(446, 28)
        Me.AvatarLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AvatarLabel.Name = "AvatarLabel"
        Me.AvatarLabel.Size = New System.Drawing.Size(120, 20)
        Me.AvatarLabel.TabIndex = 8
        Me.AvatarLabel.Text = "Avatar"
        Me.AvatarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IdUsuarioLabel
        '
        Me.IdUsuarioLabel.AutoSize = True
        Me.IdUsuarioLabel.Location = New System.Drawing.Point(341, 28)
        Me.IdUsuarioLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IdUsuarioLabel.Name = "IdUsuarioLabel"
        Me.IdUsuarioLabel.Size = New System.Drawing.Size(85, 20)
        Me.IdUsuarioLabel.TabIndex = 0
        Me.IdUsuarioLabel.Text = "ID Usuario"
        Me.IdUsuarioLabel.Visible = False
        '
        'AvatarTextBox
        '
        Me.AvatarTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AvatarTextBox.Location = New System.Drawing.Point(574, 25)
        Me.AvatarTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AvatarTextBox.Name = "AvatarTextBox"
        Me.AvatarTextBox.ReadOnly = True
        Me.AvatarTextBox.Size = New System.Drawing.Size(200, 26)
        Me.AvatarTextBox.TabIndex = 6
        '
        'AvatarPictureBox
        '
        Me.AvatarPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AvatarPictureBox.Location = New System.Drawing.Point(574, 58)
        Me.AvatarPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AvatarPictureBox.Name = "AvatarPictureBox"
        Me.AvatarPictureBox.Size = New System.Drawing.Size(200, 200)
        Me.AvatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AvatarPictureBox.TabIndex = 5
        Me.AvatarPictureBox.TabStop = False
        '
        'ClaveLabel
        '
        Me.ClaveLabel.Location = New System.Drawing.Point(7, 188)
        Me.ClaveLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ClaveLabel.Name = "ClaveLabel"
        Me.ClaveLabel.Size = New System.Drawing.Size(120, 20)
        Me.ClaveLabel.TabIndex = 6
        Me.ClaveLabel.Text = "Clave (*)"
        Me.ClaveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ClaveTextBox
        '
        Me.ClaveTextBox.Location = New System.Drawing.Point(134, 185)
        Me.ClaveTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClaveTextBox.Name = "ClaveTextBox"
        Me.ClaveTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.ClaveTextBox.Size = New System.Drawing.Size(300, 26)
        Me.ClaveTextBox.TabIndex = 4
        '
        'EmailLabel
        '
        Me.EmailLabel.Location = New System.Drawing.Point(7, 158)
        Me.EmailLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(120, 20)
        Me.EmailLabel.TabIndex = 4
        Me.EmailLabel.Text = "Email (*)"
        Me.EmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(134, 155)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(300, 26)
        Me.EmailTextBox.TabIndex = 3
        '
        'RolLabel
        '
        Me.RolLabel.Location = New System.Drawing.Point(7, 28)
        Me.RolLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RolLabel.Name = "RolLabel"
        Me.RolLabel.Size = New System.Drawing.Size(120, 20)
        Me.RolLabel.TabIndex = 1
        Me.RolLabel.Text = "Rol (*)"
        Me.RolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NombreUsuarioLabel
        '
        Me.NombreUsuarioLabel.Location = New System.Drawing.Point(7, 62)
        Me.NombreUsuarioLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NombreUsuarioLabel.Name = "NombreUsuarioLabel"
        Me.NombreUsuarioLabel.Size = New System.Drawing.Size(120, 20)
        Me.NombreUsuarioLabel.TabIndex = 1
        Me.NombreUsuarioLabel.Text = "Nombre (*)"
        Me.NombreUsuarioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NombreUsuarioTextBox
        '
        Me.NombreUsuarioTextBox.Location = New System.Drawing.Point(134, 59)
        Me.NombreUsuarioTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NombreUsuarioTextBox.Name = "NombreUsuarioTextBox"
        Me.NombreUsuarioTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NombreUsuarioTextBox.TabIndex = 2
        '
        'RolesComboBox
        '
        Me.RolesComboBox.FormattingEnabled = True
        Me.RolesComboBox.Location = New System.Drawing.Point(134, 24)
        Me.RolesComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RolesComboBox.Name = "RolesComboBox"
        Me.RolesComboBox.Size = New System.Drawing.Size(200, 28)
        Me.RolesComboBox.TabIndex = 1
        '
        'UsuariosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(886, 610)
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
    Friend WithEvents IdUsuarioLabel As Label
    Friend WithEvents RolLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NombreUsuarioLabel As Label
    Friend WithEvents NombreUsuarioTextBox As TextBox
    Friend WithEvents RolesComboBox As ComboBox
    Friend WithEvents ClaveLabel As Label
    Friend WithEvents ClaveTextBox As TextBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents ElegirAvatarButton As Button
    Friend WithEvents AvatarLabel As Label
    Friend WithEvents AvatarTextBox As TextBox
    Friend WithEvents AvatarPictureBox As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ApellidoLabel As Label
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents NumDocumentoLabel As Label
    Friend WithEvents NumDocumentoTextBox As TextBox
    Friend WithEvents TipoDocumentoLabel As Label
    Friend WithEvents TipoDocumentoTextBox As TextBox
    Friend WithEvents NombreLabel As Label
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents TelefonoLabel As Label
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents DomicilioLabel As Label
    Friend WithEvents DomicilioTextBox As TextBox
    Friend WithEvents InsertarButton As Button
    Friend WithEvents CancelarButton As Button
    Friend WithEvents ActualizarButton As Button
    Friend WithEvents IdPersonaLabel As Label
End Class
