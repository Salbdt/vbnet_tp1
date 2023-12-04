<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonasForm
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ListaTabPage = New System.Windows.Forms.TabPage()
        Me.PersonasDataGridView = New System.Windows.Forms.DataGridView()
        Me.EliminarButton = New System.Windows.Forms.Button()
        Me.TotalPersonasLabel = New System.Windows.Forms.Label()
        Me.DesactivarButton = New System.Windows.Forms.Button()
        Me.BuscarPersonasButton = New System.Windows.Forms.Button()
        Me.ActivarButton = New System.Windows.Forms.Button()
        Me.BuscarPersonasTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.AmigosTabPage = New System.Windows.Forms.TabPage()
        Me.BloqueadosTabPage = New System.Windows.Forms.TabPage()
        Me.BuscarAmigosTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BuscarAmigosButton = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TotalAmigosLabel = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.AmigosDataGridView = New System.Windows.Forms.DataGridView()
        Me.BuscarBloqueadosTextBox = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BuscarBloqueadosButton = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TotalBloqueadosLabel = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.BloqueadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.ListaTabPage.SuspendLayout()
        CType(Me.PersonasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.AmigosTabPage.SuspendLayout()
        Me.BloqueadosTabPage.SuspendLayout()
        CType(Me.AmigosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloqueadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaTabPage
        '
        Me.ListaTabPage.Controls.Add(Me.BuscarPersonasTextBox)
        Me.ListaTabPage.Controls.Add(Me.ActivarButton)
        Me.ListaTabPage.Controls.Add(Me.BuscarPersonasButton)
        Me.ListaTabPage.Controls.Add(Me.DesactivarButton)
        Me.ListaTabPage.Controls.Add(Me.TotalPersonasLabel)
        Me.ListaTabPage.Controls.Add(Me.EliminarButton)
        Me.ListaTabPage.Controls.Add(Me.PersonasDataGridView)
        Me.ListaTabPage.Location = New System.Drawing.Point(4, 29)
        Me.ListaTabPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListaTabPage.Name = "ListaTabPage"
        Me.ListaTabPage.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListaTabPage.Size = New System.Drawing.Size(854, 554)
        Me.ListaTabPage.TabIndex = 0
        Me.ListaTabPage.Text = "Lista"
        Me.ListaTabPage.UseVisualStyleBackColor = True
        '
        'PersonasDataGridView
        '
        Me.PersonasDataGridView.AllowUserToAddRows = False
        Me.PersonasDataGridView.AllowUserToDeleteRows = False
        Me.PersonasDataGridView.AllowUserToResizeRows = False
        Me.PersonasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PersonasDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.PersonasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PersonasDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PersonasDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.PersonasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PersonasDataGridView.DefaultCellStyle = DataGridViewCellStyle11
        Me.PersonasDataGridView.Location = New System.Drawing.Point(7, 44)
        Me.PersonasDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PersonasDataGridView.Name = "PersonasDataGridView"
        Me.PersonasDataGridView.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PersonasDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.PersonasDataGridView.RowHeadersVisible = False
        Me.PersonasDataGridView.RowTemplate.Height = 30
        Me.PersonasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PersonasDataGridView.Size = New System.Drawing.Size(840, 467)
        Me.PersonasDataGridView.TabIndex = 3
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
        'TotalPersonasLabel
        '
        Me.TotalPersonasLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalPersonasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPersonasLabel.Location = New System.Drawing.Point(667, 521)
        Me.TotalPersonasLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 0)
        Me.TotalPersonasLabel.Name = "TotalPersonasLabel"
        Me.TotalPersonasLabel.Size = New System.Drawing.Size(180, 31)
        Me.TotalPersonasLabel.TabIndex = 3
        Me.TotalPersonasLabel.Text = "Personas: 000"
        Me.TotalPersonasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'BuscarPersonasButton
        '
        Me.BuscarPersonasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BuscarPersonasButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BuscarPersonasButton.Location = New System.Drawing.Point(215, 8)
        Me.BuscarPersonasButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BuscarPersonasButton.Name = "BuscarPersonasButton"
        Me.BuscarPersonasButton.Size = New System.Drawing.Size(100, 26)
        Me.BuscarPersonasButton.TabIndex = 2
        Me.BuscarPersonasButton.Text = "Buscar"
        Me.BuscarPersonasButton.UseVisualStyleBackColor = True
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
        'BuscarPersonasTextBox
        '
        Me.BuscarPersonasTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BuscarPersonasTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarPersonasTextBox.Location = New System.Drawing.Point(7, 8)
        Me.BuscarPersonasTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BuscarPersonasTextBox.MaxLength = 50
        Me.BuscarPersonasTextBox.Name = "BuscarPersonasTextBox"
        Me.BuscarPersonasTextBox.Size = New System.Drawing.Size(200, 26)
        Me.BuscarPersonasTextBox.TabIndex = 1
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.ListaTabPage)
        Me.TabControl.Controls.Add(Me.AmigosTabPage)
        Me.TabControl.Controls.Add(Me.BloqueadosTabPage)
        Me.TabControl.Location = New System.Drawing.Point(12, 12)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl.Multiline = True
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(862, 587)
        Me.TabControl.TabIndex = 2
        '
        'AmigosTabPage
        '
        Me.AmigosTabPage.Controls.Add(Me.BuscarAmigosTextBox)
        Me.AmigosTabPage.Controls.Add(Me.Button1)
        Me.AmigosTabPage.Controls.Add(Me.BuscarAmigosButton)
        Me.AmigosTabPage.Controls.Add(Me.Button3)
        Me.AmigosTabPage.Controls.Add(Me.TotalAmigosLabel)
        Me.AmigosTabPage.Controls.Add(Me.Button4)
        Me.AmigosTabPage.Controls.Add(Me.AmigosDataGridView)
        Me.AmigosTabPage.Location = New System.Drawing.Point(4, 29)
        Me.AmigosTabPage.Name = "AmigosTabPage"
        Me.AmigosTabPage.Size = New System.Drawing.Size(854, 554)
        Me.AmigosTabPage.TabIndex = 1
        Me.AmigosTabPage.Text = "Amigos"
        Me.AmigosTabPage.UseVisualStyleBackColor = True
        '
        'BloqueadosTabPage
        '
        Me.BloqueadosTabPage.Controls.Add(Me.BuscarBloqueadosTextBox)
        Me.BloqueadosTabPage.Controls.Add(Me.Button5)
        Me.BloqueadosTabPage.Controls.Add(Me.BuscarBloqueadosButton)
        Me.BloqueadosTabPage.Controls.Add(Me.Button7)
        Me.BloqueadosTabPage.Controls.Add(Me.TotalBloqueadosLabel)
        Me.BloqueadosTabPage.Controls.Add(Me.Button8)
        Me.BloqueadosTabPage.Controls.Add(Me.BloqueadosDataGridView)
        Me.BloqueadosTabPage.Location = New System.Drawing.Point(4, 29)
        Me.BloqueadosTabPage.Name = "BloqueadosTabPage"
        Me.BloqueadosTabPage.Size = New System.Drawing.Size(854, 554)
        Me.BloqueadosTabPage.TabIndex = 2
        Me.BloqueadosTabPage.Text = "Bloqueados"
        Me.BloqueadosTabPage.UseVisualStyleBackColor = True
        '
        'BuscarAmigosTextBox
        '
        Me.BuscarAmigosTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BuscarAmigosTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarAmigosTextBox.Location = New System.Drawing.Point(7, 5)
        Me.BuscarAmigosTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BuscarAmigosTextBox.MaxLength = 50
        Me.BuscarAmigosTextBox.Name = "BuscarAmigosTextBox"
        Me.BuscarAmigosTextBox.Size = New System.Drawing.Size(200, 26)
        Me.BuscarAmigosTextBox.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(7, 518)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 26)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Activar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BuscarAmigosButton
        '
        Me.BuscarAmigosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BuscarAmigosButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BuscarAmigosButton.Location = New System.Drawing.Point(215, 5)
        Me.BuscarAmigosButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BuscarAmigosButton.Name = "BuscarAmigosButton"
        Me.BuscarAmigosButton.Size = New System.Drawing.Size(100, 26)
        Me.BuscarAmigosButton.TabIndex = 8
        Me.BuscarAmigosButton.Text = "Buscar"
        Me.BuscarAmigosButton.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button3.Location = New System.Drawing.Point(115, 518)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 26)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Desactivar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TotalAmigosLabel
        '
        Me.TotalAmigosLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalAmigosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmigosLabel.Location = New System.Drawing.Point(667, 518)
        Me.TotalAmigosLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 0)
        Me.TotalAmigosLabel.Name = "TotalAmigosLabel"
        Me.TotalAmigosLabel.Size = New System.Drawing.Size(180, 31)
        Me.TotalAmigosLabel.TabIndex = 9
        Me.TotalAmigosLabel.Text = "Personas: 000"
        Me.TotalAmigosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button4.Location = New System.Drawing.Point(223, 518)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 26)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Eliminar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'AmigosDataGridView
        '
        Me.AmigosDataGridView.AllowUserToAddRows = False
        Me.AmigosDataGridView.AllowUserToDeleteRows = False
        Me.AmigosDataGridView.AllowUserToResizeRows = False
        Me.AmigosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AmigosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.AmigosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AmigosDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AmigosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.AmigosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AmigosDataGridView.DefaultCellStyle = DataGridViewCellStyle14
        Me.AmigosDataGridView.Location = New System.Drawing.Point(7, 41)
        Me.AmigosDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AmigosDataGridView.Name = "AmigosDataGridView"
        Me.AmigosDataGridView.ReadOnly = True
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AmigosDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.AmigosDataGridView.RowHeadersVisible = False
        Me.AmigosDataGridView.RowTemplate.Height = 30
        Me.AmigosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AmigosDataGridView.Size = New System.Drawing.Size(840, 467)
        Me.AmigosDataGridView.TabIndex = 10
        '
        'BuscarBloqueadosTextBox
        '
        Me.BuscarBloqueadosTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BuscarBloqueadosTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarBloqueadosTextBox.Location = New System.Drawing.Point(7, 5)
        Me.BuscarBloqueadosTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BuscarBloqueadosTextBox.MaxLength = 50
        Me.BuscarBloqueadosTextBox.Name = "BuscarBloqueadosTextBox"
        Me.BuscarBloqueadosTextBox.Size = New System.Drawing.Size(200, 26)
        Me.BuscarBloqueadosTextBox.TabIndex = 7
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button5.Location = New System.Drawing.Point(7, 518)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 26)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Activar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'BuscarBloqueadosButton
        '
        Me.BuscarBloqueadosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BuscarBloqueadosButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BuscarBloqueadosButton.Location = New System.Drawing.Point(215, 5)
        Me.BuscarBloqueadosButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BuscarBloqueadosButton.Name = "BuscarBloqueadosButton"
        Me.BuscarBloqueadosButton.Size = New System.Drawing.Size(100, 26)
        Me.BuscarBloqueadosButton.TabIndex = 8
        Me.BuscarBloqueadosButton.Text = "Buscar"
        Me.BuscarBloqueadosButton.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button7.Location = New System.Drawing.Point(115, 518)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(100, 26)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "Desactivar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TotalBloqueadosLabel
        '
        Me.TotalBloqueadosLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalBloqueadosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalBloqueadosLabel.Location = New System.Drawing.Point(667, 518)
        Me.TotalBloqueadosLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 0)
        Me.TotalBloqueadosLabel.Name = "TotalBloqueadosLabel"
        Me.TotalBloqueadosLabel.Size = New System.Drawing.Size(180, 31)
        Me.TotalBloqueadosLabel.TabIndex = 9
        Me.TotalBloqueadosLabel.Text = "Personas: 000"
        Me.TotalBloqueadosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button8.Location = New System.Drawing.Point(223, 518)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(100, 26)
        Me.Button8.TabIndex = 13
        Me.Button8.Text = "Eliminar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'BloqueadosDataGridView
        '
        Me.BloqueadosDataGridView.AllowUserToAddRows = False
        Me.BloqueadosDataGridView.AllowUserToDeleteRows = False
        Me.BloqueadosDataGridView.AllowUserToResizeRows = False
        Me.BloqueadosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BloqueadosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.BloqueadosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BloqueadosDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BloqueadosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.BloqueadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BloqueadosDataGridView.DefaultCellStyle = DataGridViewCellStyle17
        Me.BloqueadosDataGridView.Location = New System.Drawing.Point(7, 41)
        Me.BloqueadosDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BloqueadosDataGridView.Name = "BloqueadosDataGridView"
        Me.BloqueadosDataGridView.ReadOnly = True
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BloqueadosDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.BloqueadosDataGridView.RowHeadersVisible = False
        Me.BloqueadosDataGridView.RowTemplate.Height = 30
        Me.BloqueadosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BloqueadosDataGridView.Size = New System.Drawing.Size(840, 467)
        Me.BloqueadosDataGridView.TabIndex = 10
        '
        'PersonasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(886, 610)
        Me.Controls.Add(Me.TabControl)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "PersonasForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PersonasForm"
        Me.ListaTabPage.ResumeLayout(False)
        Me.ListaTabPage.PerformLayout()
        CType(Me.PersonasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.AmigosTabPage.ResumeLayout(False)
        Me.AmigosTabPage.PerformLayout()
        Me.BloqueadosTabPage.ResumeLayout(False)
        Me.BloqueadosTabPage.PerformLayout()
        CType(Me.AmigosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloqueadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListaTabPage As TabPage
    Friend WithEvents BuscarPersonasTextBox As TextBox
    Friend WithEvents ActivarButton As Button
    Friend WithEvents BuscarPersonasButton As Button
    Friend WithEvents DesactivarButton As Button
    Friend WithEvents TotalPersonasLabel As Label
    Friend WithEvents EliminarButton As Button
    Friend WithEvents PersonasDataGridView As DataGridView
    Friend WithEvents TabControl As TabControl
    Friend WithEvents AmigosTabPage As TabPage
    Friend WithEvents BloqueadosTabPage As TabPage
    Friend WithEvents BuscarAmigosTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BuscarAmigosButton As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TotalAmigosLabel As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents AmigosDataGridView As DataGridView
    Friend WithEvents BuscarBloqueadosTextBox As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents BuscarBloqueadosButton As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents TotalBloqueadosLabel As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents BloqueadosDataGridView As DataGridView
End Class
