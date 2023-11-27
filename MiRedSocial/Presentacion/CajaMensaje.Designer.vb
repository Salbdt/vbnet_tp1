<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MensajeCaja
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
        Me.SiNoTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.SiButton = New System.Windows.Forms.Button()
        Me.NoButton = New System.Windows.Forms.Button()
        Me.MensajeLabel = New System.Windows.Forms.Label()
        Me.IconoPictureBox = New System.Windows.Forms.PictureBox()
        Me.OkTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.SiNoTableLayoutPanel.SuspendLayout()
        CType(Me.IconoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OkTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'SiNoTableLayoutPanel
        '
        Me.SiNoTableLayoutPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SiNoTableLayoutPanel.ColumnCount = 2
        Me.SiNoTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.SiNoTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.SiNoTableLayoutPanel.Controls.Add(Me.SiButton, 0, 0)
        Me.SiNoTableLayoutPanel.Controls.Add(Me.NoButton, 1, 0)
        Me.SiNoTableLayoutPanel.Location = New System.Drawing.Point(13, 152)
        Me.SiNoTableLayoutPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SiNoTableLayoutPanel.Name = "SiNoTableLayoutPanel"
        Me.SiNoTableLayoutPanel.RowCount = 1
        Me.SiNoTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.SiNoTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.SiNoTableLayoutPanel.Size = New System.Drawing.Size(408, 45)
        Me.SiNoTableLayoutPanel.TabIndex = 2
        '
        'SiButton
        '
        Me.SiButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SiButton.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.SiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SiButton.Location = New System.Drawing.Point(52, 5)
        Me.SiButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SiButton.Name = "SiButton"
        Me.SiButton.Size = New System.Drawing.Size(100, 35)
        Me.SiButton.TabIndex = 0
        Me.SiButton.Text = "Si"
        '
        'NoButton
        '
        Me.NoButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NoButton.DialogResult = System.Windows.Forms.DialogResult.No
        Me.NoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NoButton.Location = New System.Drawing.Point(256, 5)
        Me.NoButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(100, 35)
        Me.NoButton.TabIndex = 1
        Me.NoButton.Text = "No"
        '
        'MensajeLabel
        '
        Me.MensajeLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MensajeLabel.Location = New System.Drawing.Point(12, 93)
        Me.MensajeLabel.Name = "MensajeLabel"
        Me.MensajeLabel.Size = New System.Drawing.Size(410, 54)
        Me.MensajeLabel.TabIndex = 1
        Me.MensajeLabel.Text = "Mensaje"
        Me.MensajeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IconoPictureBox
        '
        Me.IconoPictureBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconoPictureBox.Location = New System.Drawing.Point(19, 19)
        Me.IconoPictureBox.Margin = New System.Windows.Forms.Padding(10)
        Me.IconoPictureBox.Name = "IconoPictureBox"
        Me.IconoPictureBox.Size = New System.Drawing.Size(396, 64)
        Me.IconoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.IconoPictureBox.TabIndex = 2
        Me.IconoPictureBox.TabStop = False
        '
        'OkTableLayoutPanel
        '
        Me.OkTableLayoutPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OkTableLayoutPanel.ColumnCount = 1
        Me.OkTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.OkTableLayoutPanel.Controls.Add(Me.OkButton, 0, 0)
        Me.OkTableLayoutPanel.Location = New System.Drawing.Point(13, 152)
        Me.OkTableLayoutPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OkTableLayoutPanel.Name = "OkTableLayoutPanel"
        Me.OkTableLayoutPanel.RowCount = 1
        Me.OkTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.OkTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.OkTableLayoutPanel.Size = New System.Drawing.Size(408, 45)
        Me.OkTableLayoutPanel.TabIndex = 3
        '
        'OkButton
        '
        Me.OkButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OkButton.Location = New System.Drawing.Point(154, 5)
        Me.OkButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(100, 35)
        Me.OkButton.TabIndex = 0
        Me.OkButton.Text = "Ok"
        '
        'MensajeCaja
        '
        Me.AcceptButton = Me.SiButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.NoButton
        Me.ClientSize = New System.Drawing.Size(434, 211)
        Me.Controls.Add(Me.OkTableLayoutPanel)
        Me.Controls.Add(Me.IconoPictureBox)
        Me.Controls.Add(Me.MensajeLabel)
        Me.Controls.Add(Me.SiNoTableLayoutPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MensajeCaja"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CajaMensaje"
        Me.SiNoTableLayoutPanel.ResumeLayout(False)
        CType(Me.IconoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OkTableLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SiNoTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SiButton As System.Windows.Forms.Button
    Friend WithEvents NoButton As System.Windows.Forms.Button
    Friend WithEvents MensajeLabel As Label
    Friend WithEvents IconoPictureBox As PictureBox
    Friend WithEvents OkTableLayoutPanel As TableLayoutPanel
    Friend WithEvents OkButton As Button
End Class
