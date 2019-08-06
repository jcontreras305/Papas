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

        Consul()
    End Sub

    Private Sub txtNombreEm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreEm.KeyPress
        Dim no As String = txtNombreEm.Text
        Dim bo As String = txtNombreEm.Text
        Dim pu As String = txtNombreEm.Text
        Dim fu As New MetodosEmpleado

        Try
            If filtro.SelectedIndex = 0 Then
                DataListado.DataSource = fu.BuscarEm(no)
            ElseIf filtro.SelectedIndex = 1 Then
                DataListado.DataSource = fu.BuscarEmBo(bo)
            ElseIf filtro.SelectedIndex = 2 Then
                DataListado.DataSource = fu.BuscarEmPu(pu)
            End If
        Catch ex As Exception

        End Try
    End Sub


End Class