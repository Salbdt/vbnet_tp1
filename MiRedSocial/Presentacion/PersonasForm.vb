Imports Presentacion.Variables

Public Class PersonasForm
    Private idUsuario As Integer

    Public Sub New(idUsuario As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.idUsuario = idUsuario
    End Sub

    Private Sub Formato()
        PersonasDataGridView.Columns(0).Name = "idUsuario"
        PersonasDataGridView.Columns(0).Visible = False
        PersonasDataGridView.Columns(1).Name = "idPersona"
        PersonasDataGridView.Columns(1).Visible = False
        PersonasDataGridView.Columns(2).Width = 180
        PersonasDataGridView.Columns(2).Name = "nombre"
        PersonasDataGridView.Columns(2).HeaderText = "Nombre"
        PersonasDataGridView.Columns(3).Width = 180
        PersonasDataGridView.Columns(3).Name = "apellido"
        PersonasDataGridView.Columns(3).HeaderText = "Apellido"
    End Sub

    Private Sub ListarPersonas()
        Try
            Dim neg As New Negocio.NPersona
            PersonasDataGridView.DataSource = neg.ListarPersonas()
            TotalPersonasLabel.Text = "Personas: " & PersonasDataGridView.RowCount
            Me.Formato()
        Catch ex As Exception
            caja.MostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub ListarAmigos()
        Try
            Dim neg As New Negocio.NPersona
            PersonasDataGridView.DataSource = neg.ListarAmigos()
            TotalPersonasLabel.Text = "Personas: " & PersonasDataGridView.RowCount
            Me.Formato()
        Catch ex As Exception
            caja.MostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub ListarBloqueados()
        Try
            Dim neg As New Negocio.NPersona
            PersonasDataGridView.DataSource = neg.ListarBloqueados()
            TotalPersonasLabel.Text = "Personas: " & PersonasDataGridView.RowCount
            Me.Formato()
        Catch ex As Exception
            caja.MostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub PersonasForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ListarPersonas()
    End Sub

    Private Sub TabControl_TabIndexChanged(sender As Object, e As EventArgs) Handles TabControl.TabIndexChanged
        Select Case (TabControl.SelectedIndex = 0)
            Case 0
                Me.ListarPersonas()
            Case 1
                Me.ListarAmigos()
            Case 2
                Me.ListarBloqueados()
        End Select



    End Sub
End Class