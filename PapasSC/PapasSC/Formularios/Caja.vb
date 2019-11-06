Public Class Caja
    Dim mtdCaja As New MetodosCaja

    Private Sub Caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mtdCaja.select_ventasCajas(tblVentas, "%", txtCaja.Text)
            cmbTipoPersona.SelectedIndex = 0

        Catch ex As Exception

        End Try
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
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tabControl1_SelectedIndex(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then 'General
            mtdCaja.select_ventasCajas(tblVentas, cmbTipoPersona.Text, txtCaja.Text, stpFechaInicio.Value.ToLongDateString, stpFechaFin.Value.ToLongDateString)
        ElseIf TabControl1.SelectedIndex = 1 Then ' Abonos y anticipos

        ElseIf TabControl1.SelectedIndex = 2 Then ' Cuentas por cobrar
            mtdCaja.select_CuentaPorCobrar(tblCuentasPorPagar, txtCaja.Text)
        ElseIf TabControl1.SelectedIndex = 3 Then ' Pre-corte

        End If
    End Sub

    Private Sub stpFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles stpFechaInicio.ValueChanged
        Try
            Dim fecha1 = stpFechaInicio.Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            If chbTodosCPP.Checked = True Then
                mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, "", "", "", "", "", True)
            Else
                If cmbFiltar.SelectedIndex = 0 Then ' cliente
                    mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, dtpFechaInicio.Value.ToString("yyyy-MM-dd"), dtpFechaFin.Value.ToString("yyyy-MM-dd"), txtFiltro.Text, "", "", False)
                ElseIf cmbFiltar.SelectedIndex = 1 Then ' Folio
                    mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, dtpFechaInicio.Value.ToString("yyyy-MM-dd"), dtpFechaFin.Value.ToString("yyyy-MM-dd"), "", "", txtFiltro.Text, False)
                ElseIf cmbFiltar.SelectedIndex = 2 Then ' Caja
                    mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, dtpFechaInicio.Value.ToString("yyyy-MM-dd"), dtpFechaFin.Value.ToString("yyyy-MM-dd"), "", txtFiltro.Text, "", False)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtFiltro_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyUp
        Try
            If chbTodosCPP.Checked = True Then
                mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, "", "", "", "", "", True)
            Else
                If cmbFiltar.SelectedIndex = 0 Then ' cliente
                    mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, dtpFechaInicio.Value.ToString("yyyy-MM-dd"), dtpFechaFin.Value.ToString("yyyy-MM-dd"), txtFiltro.Text, "", "", False)
                ElseIf cmbFiltar.SelectedIndex = 1 Then ' Folio
                    mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, dtpFechaInicio.Value.ToString("yyyy-MM-dd"), dtpFechaFin.Value.ToString("yyyy-MM-dd"), "", "", txtFiltro.Text, False)
                ElseIf cmbFiltar.SelectedIndex = 2 Then ' Caja
                    mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, dtpFechaInicio.Value.ToString("yyyy-MM-dd"), dtpFechaFin.Value.ToString("yyyy-MM-dd"), "", txtFiltro.Text, "", False)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chbTodosCPP_CheckedChanged(sender As Object, e As EventArgs) Handles chbTodosCPP.CheckedChanged
        Try
            mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, "", "", "", "", "", True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtpFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicio.ValueChanged
        Try
            If chbTodosCPP.Checked = True Then
                mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, "", "", "", "", "", True)
            Else
                If cmbFiltar.SelectedIndex = 0 Then ' cliente
                    mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, dtpFechaInicio.Value.ToString("yyyy-MM-dd"), dtpFechaFin.Value.ToString("yyyy-MM-dd"), txtFiltro.Text, "", "", False)
                ElseIf cmbFiltar.SelectedIndex = 1 Then ' Folio
                    mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, dtpFechaInicio.Value.ToString("yyyy-MM-dd"), dtpFechaFin.Value.ToString("yyyy-MM-dd"), "", "", txtFiltro.Text, False)
                ElseIf cmbFiltar.SelectedIndex = 2 Then ' Caja
                    mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, dtpFechaInicio.Value.ToString("yyyy-MM-dd"), dtpFechaFin.Value.ToString("yyyy-MM-dd"), "", txtFiltro.Text, "", False)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtpFechaFin_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaFin.ValueChanged
        Try
            If chbTodosCPP.Checked = True Then
                mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, "", "", "", "", "", True)
            Else
                If cmbFiltar.SelectedIndex = 0 Then ' cliente
                    mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, dtpFechaInicio.Value.ToString("yyyy-MM-dd"), dtpFechaFin.Value.ToString("yyyy-MM-dd"), txtFiltro.Text, "", "", False)
                ElseIf cmbFiltar.SelectedIndex = 1 Then ' Folio
                    mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, dtpFechaInicio.Value.ToString("yyyy-MM-dd"), dtpFechaFin.Value.ToString("yyyy-MM-dd"), "", "", txtFiltro.Text, False)
                ElseIf cmbFiltar.SelectedIndex = 2 Then ' Caja
                    mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, dtpFechaInicio.Value.ToString("yyyy-MM-dd"), dtpFechaFin.Value.ToString("yyyy-MM-dd"), "", txtFiltro.Text, "", False)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            If TabControl1.SelectedIndex = 0 Then ' General

            ElseIf TabControl1.SelectedIndex = 1 Then

            ElseIf TabControl1.SelectedIndex = 2 Then

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox4_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyUp
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class