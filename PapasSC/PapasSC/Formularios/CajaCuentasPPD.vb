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

    Private Sub btnImprimirVPPC_Click(sender As Object, e As EventArgs) Handles btnImprimirVPPC.Click
        Try
            If tblVentasPendientes.Rows.Count > 0 Then
                Dim ds As New tablaVentasPorPagarDetalladaCliente
                Dim dt As New DataTable
                dt = tblVentasPendientes.DataSource
                ds.Ventas_Pendientes.Rows.Clear()
                For Each row As DataRow In dt.Rows
                    ds.Ventas_Pendientes.AddVentas_PendientesRow(row("Folio").ToString(), row("Fecha").ToString(), row("Cliente").ToString(), row("Total").ToString(), row("Saldado").ToString(), row("Debe").ToString(), row("Día límite").ToString(), row("Días").ToString(), row("Estado").ToString())
                Next
                Dim reportecppc As New VentasPorPagarCliente
                reportecppc.SetDataSource(ds)
                Dim fromreporteVPPC As New ReporteVentasPorPagarCliente
                fromreporteVPPC.CrystalReportViewer1.ReportSource = reportecppc
                fromreporteVPPC.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class