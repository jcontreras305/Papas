Imports PapasSC.MetodosCliente
Public Class Consulta_Cliente
    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim MTCLI As New MetodosCliente
        MTCLI.llenarDatagridview(TablaCLientes)
        TablaCLientes.ReadOnly = True
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim MTCLI As New MetodosCliente
        TablaCLientes.ReadOnly = True
        Try
            If FiltroClientes.SelectedIndex = 0 Then
                MTCLI.llenarDatagridview_filtro(TablaCLientes, TextBox1.Text)
            ElseIf FiltroClientes.SelectedIndex = 1 Then
                MTCLI.llenarDatagridview_filtroTipo(TablaCLientes, TextBox1.Text)
            ElseIf FiltroClientes.SelectedIndex = 2 Then
                MTCLI.llenarDatagridview_filtroRazonSocial(TablaCLientes, TextBox1.Text)
            ElseIf FiltroClientes.SelectedIndex = 3 Then
                MTCLI.llenarDatagridview_filtroalias(TablaCLientes, TextBox1.Text)
            ElseIf FiltroClientes.SelectedIndex = 4 Then
                MTCLI.llenarDatagridview_filtroRFC(TablaCLientes, TextBox1.Text)
            ElseIf FiltroClientes.SelectedIndex = 5 Then
                MTCLI.llenarDatagridview_filtroLimitecredito(TablaCLientes, TextBox1.Text)
            ElseIf FiltroClientes.SelectedIndex = 6 Then
                MTCLI.llenarDatagridview_filtroDiasCredito(TablaCLientes, TextBox1.Text)

            End If
        Catch

        End Try


    End Sub
End Class