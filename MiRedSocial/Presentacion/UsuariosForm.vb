Public Class UsuariosForm
    Private rutaOrigen As String
    Private rutaDestino As String
    Private directorio As String = "C:\Proyecto\TP1\img\"

    Private Sub Formato()
        ListadoDataGridView.Columns(0).Name = "idRol"
        ListadoDataGridView.Columns(0).Visible = False
        ListadoDataGridView.Columns(1).Width = 120
        ListadoDataGridView.Columns(1).Name = "rol"
        ListadoDataGridView.Columns(1).HeaderText = "Rol"
        ListadoDataGridView.Columns(2).Name = "estadoRol"
        ListadoDataGridView.Columns(2).Visible = False
        ListadoDataGridView.Columns(3).Width = 90
        ListadoDataGridView.Columns(3).Name = "id"
        ListadoDataGridView.Columns(3).HeaderText = "ID"
        ListadoDataGridView.Columns(4).Width = 180
        ListadoDataGridView.Columns(4).Name = "nombre"
        ListadoDataGridView.Columns(4).HeaderText = "Nombre"
        ListadoDataGridView.Columns(5).Width = 180
        ListadoDataGridView.Columns(5).Name = "avatar"
        ListadoDataGridView.Columns(5).HeaderText = "Avatar"
        ListadoDataGridView.Columns(6).Width = 180
        ListadoDataGridView.Columns(6).Name = "email"
        ListadoDataGridView.Columns(6).HeaderText = "Email"
        ListadoDataGridView.Columns(7).Width = 90
        ListadoDataGridView.Columns(7).Name = "estado"
        ListadoDataGridView.Columns(7).HeaderText = "Estado"
    End Sub

    Private Sub Listar()
        Try
            Dim neg As New Negocio.NUsuario
            ListadoDataGridView.DataSource = neg.Listar()
            TotalUsuariosLabel.Text = "Usuarios: " & ListadoDataGridView.RowCount
            Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Buscar()
        Try
            Dim neg As New Negocio.NUsuario
            Dim valor As String
            valor = BuscarTextBox.Text
            ListadoDataGridView.DataSource = neg.Buscar(valor)
            TotalUsuariosLabel.Text = "Usuarios: " & ListadoDataGridView.RowCount
            Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CargarRoles()
        Try
            Dim neg As New Negocio.NRol
            RolesComboBox.DataSource = neg.Listar()
            RolesComboBox.ValueMember = "id_rol"
            RolesComboBox.DisplayMember = "nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub UsuariosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
        Me.CargarRoles()
    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click
        Me.Buscar()
    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles EliminarButton.Click
        Dim caja As New SiNoMensajeCaja("¿Estás seguro/a de eliminar los registros seleccionados?", vbCritical, "Eliminar registros")
        If (caja.ShowDialog() = DialogResult.Yes) Then
            Try
                Dim Neg As New Negocio.NUsuario
                For Each row As DataGridViewRow In ListadoDataGridView.SelectedRows
                    Neg.Eliminar(Convert.ToInt32(row.Cells("id").Value))
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DesactivarButton_Click(sender As Object, e As EventArgs) Handles DesactivarButton.Click
        Dim caja As New SiNoMensajeCaja("¿Estás seguro/a de desactivar los registros seleccionados?", vbQuestion, "Desactivar registros")

        'If (MsgBox("¿Estás seguro/a de desactivar los registros seleccionados?", vbYesNo + vbQuestion, "Desactivar registros") = vbYes) Then
        If (caja.ShowDialog() = DialogResult.Yes) Then
            Try
                Dim Neg As New Negocio.NUsuario
                For Each row As DataGridViewRow In ListadoDataGridView.SelectedRows
                    Neg.Desactivar(Convert.ToInt32(row.Cells("id").Value))
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ActivarButton_Click(sender As Object, e As EventArgs) Handles ActivarButton.Click
        Dim caja As New SiNoMensajeCaja("¿Estás seguro/a de activar los registros seleccionados?", vbQuestion, "Activar registros")
        If (caja.ShowDialog() = DialogResult.Yes) Then
            Try
                Dim Neg As New Negocio.NUsuario
                For Each row As DataGridViewRow In ListadoDataGridView.SelectedRows
                    Neg.Activar(Convert.ToInt32(row.Cells("id").Value))
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ElegirAvatarButton_Click(sender As Object, e As EventArgs) Handles ElegirAvatarButton.Click
        Dim file As New OpenFileDialog
        file.Filter = "Image Files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
        If file.ShowDialog() = DialogResult.OK Then
            AvatarPictureBox.Image = Image.FromFile(file.FileName)
            rutaOrigen = file.FileName
            AvatarTextBox.Text = file.FileName.Substring(file.FileName.LastIndexOf("\") + 1)
        End If
    End Sub
End Class