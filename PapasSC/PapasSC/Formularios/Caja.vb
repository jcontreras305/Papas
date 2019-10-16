Public Class Caja
    Dim mtdCaja As New MetodosCaja

    Private Sub Caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mtdCaja.select_ventasCajas(tblVentas, "%", txtCaja.Text)
            cmbTipoPersona.SelectedIndex = 0

        Catch ex As Exception

        End Try
    End Sub

    Private Sub tblVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblVentas.CellContentClick

    End Sub

    Private Sub chbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chbTodos.CheckedChanged
        Try
            mtdCaja.select_ventasCajas(tblVentas, "%", txtCaja.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chbCobrados_CheckedChanged(sender As Object, e As EventArgs) Handles chbCobrados.CheckedChanged
        Try
            mtdCaja.select_ventasCajas(tblVentas, "%", txtCaja.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tabControl1_SelectedIndex(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            mtdCaja.select_ventasCajas(tblVentas, cmbTipoPersona.Text, txtCaja.Text, stpFechaInicio.Value.ToLongDateString, stpFechaFin.Value.ToLongDateString)
        ElseIf TabControl1.SelectedIndex = 1 Then
        ElseIf TabControl1.SelectedIndex = 2 Then
            mtdCaja.select_CuentaPorCobrar(tblCuentasPorPagar, txtCaja.Text)
        End If
    End Sub

    Private Sub stpFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles stpFechaInicio.ValueChanged
        Try
            Dim fecha1 = stpFechaInicio.Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

    End Sub
End Class