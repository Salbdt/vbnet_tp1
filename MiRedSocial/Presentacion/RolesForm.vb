Public Class RolesForm
    Private Sub Formato()
        ListadoDataGridView.Columns(0).Width = 120
        ListadoDataGridView.Columns(0).HeaderText = "ID"
        ListadoDataGridView.Columns(1).Width = 180
        ListadoDataGridView.Columns(1).HeaderText = "Nombre"
        ListadoDataGridView.Columns(2).Width = 240
        ListadoDataGridView.Columns(2).HeaderText = "Descripcion"
    End Sub

    Private Sub Listar()
        Try
            Dim neg As New Negocio.NRol
            ListadoDataGridView.DataSource = neg.Listar()
            TotalRolesLabel.Text = "Roles: " & ListadoDataGridView.RowCount
            Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RolForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
    End Sub
End Class