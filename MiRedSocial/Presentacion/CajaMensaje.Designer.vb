<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SiNoMensajeCaja
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SiButton = New System.Windows.Forms.Button()
        Me.NoButton = New System.Windows.Forms.Button()
        Me.MensajeLabel = New System.Windows.Forms.Label()
        Me.IconoPictureBox = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.IconoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SiButton, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NoButton, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 152)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(408, 45)
        Me.TableLayoutPanel1.TabIndex = 2
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
        'SiNoMensajeCaja
        '
        Me.AcceptButton = Me.SiButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.NoButton
        Me.ClientSize = New System.Drawing.Size(434, 211)
        Me.Controls.Add(Me.IconoPictureBox)
        Me.Controls.Add(Me.MensajeLabel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SiNoMensajeCaja"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CajaMensaje"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.IconoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SiButton As System.Windows.Forms.Button
    Friend WithEvents NoButton As System.Windows.Forms.Button
    Friend WithEvents MensajeLabel As Label
    Friend WithEvents IconoPictureBox As PictureBox
End Class
