Public Class ConsultarEmpleado
    Dim dv As New DataView

    Public Sub Consul()
        Dim fun As New MetodosEmpleado
        DataListado.DataSource = fun.Consultar
    End Sub

    Private Sub ConsultarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Consul()
    End Sub

    Private Sub btnNombreE_Click(sender As Object, e As EventArgs) Handles btnNombreE.Click
        Dim no As String = txtNombreEm.Text
        Dim bo As String = txtNombreEm.Text
        Dim pu As String = txtNombreEm.Text
        Dim sa As String = txtNombreEm.Text
        Dim fu As New MetodosEmpleado

        If txtNombreEm.Text = "" Or txtNombreEm.Text = Nothing Then
        ElseIf filtro.SelectedIndex = 0 Then
            DataListado.DataSource = fu.BuscarEm(no)
            ElseIf filtro.SelectedIndex = 1 Then
                DataListado.DataSource = fu.BuscarEmBo(bo)
            ElseIf filtro.SelectedIndex = 2 Then
                DataListado.DataSource = fu.BuscarEmPu(pu)
            ElseIf filtro.SelectedIndex = 3 Then
                DataListado.DataSource = fu.BuscarEmSa(sa)
            End If
    End Sub



    Private Sub txtNombreEm_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombreEm.KeyDown
        Dim no As String = txtNombreEm.Text
        Dim bo As String = txtNombreEm.Text
        Dim pu As String = txtNombreEm.Text
        Dim sa As String = txtNombreEm.Text
        Dim fu As New MetodosEmpleado

        Try
            If filtro.SelectedIndex = 0 Then
                DataListado.DataSource = fu.BuscarEm(no)
            ElseIf filtro.SelectedIndex = 1 Then
                DataListado.DataSource = fu.BuscarEmBo(bo)
            ElseIf filtro.SelectedIndex = 2 Then
                DataListado.DataSource = fu.BuscarEmPu(pu)
            ElseIf filtro.SelectedIndex = 3 Then
                DataListado.DataSource = fu.BuscarEmSa(sa)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEliminarEm_Click(sender As Object, e As EventArgs) Handles btnEliminarEm.Click
        Dim fu As New MetodosEmpleado
        Dim nombre As String = Convert.ToString(DataListado.CurrentRow.Cells(0).Value)

        If MessageBox.Show("Deseas eliminar empleado " + nombre + "", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If fu.EliminarEmple() Then
                Consul()
            End If
        End If


    End Sub
End Class