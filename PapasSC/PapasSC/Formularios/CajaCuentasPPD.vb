Public Class CajaCuentasPPD
    Public idEmpleado, idVenta, idCliente As String

    Private Sub tblVentasPendientes_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tblVentasPendientes.MouseDoubleClick
        Try
            '5
            Dim dinero As String = tblVentasPendientes.CurrentRow.Cells("Debe").Value.ToString("N")
            txtDebeVenta.Text = dinero
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CajaCuentasPPD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sprAbono.DecimalPlaces = 2
        sprAbono.ThousandsSeparator = True
    End Sub
End Class