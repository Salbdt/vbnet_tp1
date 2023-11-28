Imports System.Globalization
Imports Entidades

Public Class UsuariosForm
    Private rutaOrigen As String
    Private rutaDestino As String

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
            Me.Limpiar()
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
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar()
        InsertarButton.Visible = True
        ActualizarButton.Visible = False
        RolesComboBox.SelectedIndex = 0
        NombreUsuarioTextBox.Text = ""
        EmailTextBox.Text = ""
        ClaveTextBox.Text = ""
        AvatarTextBox.Text = ""
        AvatarPictureBox.Image = Nothing
        NombreTextBox.Text = ""
        ApellidoTextBox.Text = ""
        TipoDocumentoTextBox.Text = ""
        NumDocumentoTextBox.Text = ""
        DomicilioTextBox.Text = ""
        TelefonoTextBox.Text = ""
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
        Me.CargarRoles()
        Me.Listar()
    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click
        Me.Buscar()
    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles EliminarButton.Click
        Dim caja As New MensajeCaja("¿Estás seguro/a de eliminar los registros seleccionados?", vbYesNo + vbCritical, "Eliminar registros")
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
        Dim caja As New MensajeCaja("¿Estás seguro/a de desactivar los registros seleccionados?", vbYesNo + vbQuestion, "Desactivar registros")

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
        Dim caja As New MensajeCaja("¿Estás seguro/a de activar los registros seleccionados?", vbYesNo + vbQuestion, "Activar registros")
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

    Private Sub InsertarButton_Click(sender As Object, e As EventArgs) Handles InsertarButton.Click
        Try
            Dim caja As MensajeCaja
            If (RolesComboBox.Text <> "") And (NombreUsuarioTextBox.Text <> "") And (EmailTextBox.Text <> "") And
                (ClaveTextBox.Text <> "") And (NombreTextBox.Text <> "") And (ApellidoTextBox.Text <> "") Then

                Dim usuario As New Entidades.Usuario
                Dim persona As New Entidades.Persona
                Dim neg As New Negocio.NUsuario

                usuario.Rol = New Entidades.Rol
                usuario.Rol.IdRol = RolesComboBox.SelectedValue
                usuario.NombreUsuario = NombreUsuarioTextBox.Text
                usuario.Email = EmailTextBox.Text
                usuario.Avatar = AvatarTextBox.Text
                usuario.Clave = ClaveTextBox.Text

                persona.Nombre = NombreTextBox.Text
                persona.Apellido = ApellidoTextBox.Text
                persona.TipoDocumento = TipoDocumentoTextBox.Text
                persona.NumDocumento = NumDocumentoTextBox.Text
                persona.Domicilio = DomicilioTextBox.Text
                persona.Telefono = TelefonoTextBox.Text

                If (neg.Insertar(usuario, persona.ToDatatable(False))) Then
                    caja = New MensajeCaja("Se ha registrado correctamente", vbOKOnly + vbInformation, "Registro correcto")
                    caja.ShowDialog()
                    Me.Listar()
                Else
                    caja = New MensajeCaja("No se ha podido registgrar", vbOKOnly + vbCritical, "Registro incorrecto")
                    caja.ShowDialog()
                End If
            Else
                caja = New MensajeCaja("Rellene todos los campos obligatorios", vbOKOnly + vbInformation, "Campos incompletos")
                caja.ShowDialog()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ActualizarButton_Click(sender As Object, e As EventArgs) Handles ActualizarButton.Click

    End Sub

    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        Me.Limpiar()
        TabControl.SelectedIndex = 0
    End Sub

    Private Sub ListadoDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListadoDataGridView.CellDoubleClick
        idLabel.Text = ListadoDataGridView.SelectedCells.Item(3).Value
        RolesComboBox.SelectedValue = ListadoDataGridView.SelectedCells.Item(0).Value
        NombreUsuarioTextBox.Text = ListadoDataGridView.SelectedCells.Item(4).Value
        AvatarTextBox.Text = ListadoDataGridView.SelectedCells.Item(5).Value
        Try
            AvatarPictureBox.Image = Image.FromFile(Variables.directorioImagen & ListadoDataGridView.SelectedCells.Item(5).Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        EmailTextBox.Text = ListadoDataGridView.SelectedCells.Item(6).Value
        'TODO Cargar datos de Usuario
        'NombreTextBox.Text
        'ApellidoTextBox.Text
        'TipoDocumentoTextBox.Text
        'NumDocumentoTextBox.Text
        'DomicilioTextBox.Text
        'TelefonoTextBox.Text
        TabControl.SelectedIndex = 1
    End Sub
End Class