Public Class CajaCuentasPPD
    Public idEmpleado, idVenta, idCliente As String
    Public mtdcaja As New MetodosCaja


    Private Sub tblVentasPendientes_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tblVentasPendientes.MouseDoubleClick
        Try

            Dim dinero As String = tblVentasPendientes.CurrentRow.Cells("Debe").Value
            txtDebeVenta.Text = dinero
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtSaldo_TextChanged(sender As Object, e As EventArgs) Handles txtSaldo.TextChanged
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub tbnSalir_Click(sender As Object, e As EventArgs) Handles tbnSalir.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tblVentasPendientes_SelectionChanged(sender As Object, e As EventArgs) Handles tblVentasPendientes.SelectionChanged
        Try
            Dim debe As Double = 0.0
            For Each row As DataGridViewRow In tblVentasPendientes.SelectedRows


                debe = debe + CDbl(row.Cells("Debe").Value)
            Next

            txtDebeVenta.Text = debe.ToString("N")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtDebeVenta_TextChanged(sender As Object, e As EventArgs) Handles txtDebeVenta.TextChanged
        Try
            Dim max = CDbl(txtDebeVenta.Text)
            sprAbono.Maximum = max
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If MessageBox.Show("¿Desea realizar el pago de las cuentas seleccionadaes con un total de: " + sprAbono.Value.ToString("N") + "?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                '################################
                Dim dt As New DataTable
                dt.Columns.Add("idVenta")
                dt.Columns.Add("debe")
                For Each row As DataGridViewRow In tblVentasPendientes.SelectedRows
                    dt.Rows.Add(row.Cells("idVenta").Value, row.Cells("debe").Value)
                Next
                mtdcaja.agregarAbono(dt, CDbl(sprAbono.Value), idEmpleado, idCliente)
                tblVentasPendientes.Rows.Clear()
                mtdcaja.selectVentasPendientesCliente(tblVentasPendientes, idCliente)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CajaCuentasPPD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sprAbono.DecimalPlaces = 2
        sprAbono.ThousandsSeparator = True
        Dim totaldebe As Double = 0.0
        For Each row As DataGridViewRow In tblVentasPendientes.Rows
            totaldebe = totaldebe + CDbl(row.Cells("Debe").Value)
        Next
        txtSaldo.Text = totaldebe.ToString()

    End Sub

    Private Sub btnImprimirVPPC_Click(sender As Object, e As EventArgs) Handles btnImprimirVPPC.Click
        Try
            If tblVentasPendientes.Rows.Count > 0 Then
                Dim ds As New tablaVentasPorPagarDetalladaCliente
                Dim dt As New DataTable
                dt = tblVentasPendientes.DataSource
                ds.Ventas_Pendientes.Rows.Clear()
                For Each row As DataRow In dt.Rows
                    Dim diaLim() As String = Split(row("Día límite").ToString(), " ")
                    Dim fec() As String = Split(row("Fecha").ToString(), " ")
                    ds.Ventas_Pendientes.AddVentas_PendientesRow(row("Folio").ToString(), fec(0), row("Cliente").ToString(), row("Total").ToString(), row("Saldado").ToString(), CDbl(row("Debe").ToString()), diaLim(0), row("Días").ToString(), row("Estado").ToString())
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