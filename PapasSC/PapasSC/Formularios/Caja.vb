Public Class Caja
    Dim mtdCaja As New MetodosCaja

    Private Sub Caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmbTipoPersona.SelectedIndex = 0
            Dim d1 As Date = Date.Now
            Dim d2 As Date = d1.AddMonths(-1)
            txtFecha1.Text = String.Format(d1.ToShortDateString(), "dd,MM,yyyy")
            txtFecha2.Text = String.Format(d2.ToShortDateString(), "dd,MM,yyyy")
            mtdCaja.select_ventasCajas(tblVentas, "", "", txtCaja.Text, txtFecha1.Text, txtFecha2.Text, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chbTodos.CheckedChanged
        Try
            If chbTodos.Checked Then
                mtdCaja.select_ventasCajas(tblVentas, "", "", txtCaja.Text, txtFecha1.Text, txtFecha2.Text, True) 'stpFechaInicio.Value.ToLongDateString, stpFechaFin.Value.ToLongDateString)
            Else
                mtdCaja.select_ventasCajas(tblVentas, "", "", txtCaja.Text, txtFecha1.Text, txtFecha2.Text, False) 'stpFechaInicio.Value.ToLongDateString, stpFechaFin.Value.ToLongDateString)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chbCobrados_CheckedChanged(sender As Object, e As EventArgs)
        Try
            mtdCaja.select_ventasCajas(tblVentas, "%", txtCaja.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tabControl1_SelectedIndex(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then 'General
            chbTodos.Checked = False
            mtdCaja.select_ventasCajas(tblVentas, cmbTipoPersona.Text, txtFiltro1.Text, txtCaja.Text, txtFecha1.Text, txtFecha2.Text, False) 'stpFechaInicio.Value.ToLongDateString, stpFechaFin.Value.ToLongDateString)
        ElseIf TabControl1.SelectedIndex = 1 Then ' Abonos y anticipos

        ElseIf TabControl1.SelectedIndex = 2 Then ' Cuentas por cobrar
            mtdCaja.select_CuentaPorCobrar(tblCuentasPorPagar, txtCaja.Text)
        ElseIf TabControl1.SelectedIndex = 3 Then ' Pre-corte

        End If
    End Sub

    Private Sub stpFechaInicio_ValueChanged(sender As Object, e As EventArgs)
        Try
            'Dim fecha1 = stpFechaInicio.Value

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            chbTodos.Checked = False
            cmbFiltar.SelectedIndex = 0
            txtFiltro1.Text = ""
            Dim d1 As Date = Date.Now
            Dim d2 As Date = d1.AddMonths(-1)
            txtFecha1.Text = String.Format(d1.ToShortDateString(), "dd,MM,yyyy")
            txtFecha2.Text = String.Format(d2.ToShortDateString(), "dd,MM,yyyy")
            mtdCaja.select_ventasCajas(tblVentas, "", "", txtCaja.Text, txtFecha1.Text, txtFecha2.Text, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtFiltro_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyUp
        Try
            If chbTodosCPP.Checked = True Then
                mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, "", "", "", "", "", True)
            Else
                If cmbFiltar.SelectedIndex = 0 Then ' cliente
                    mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, txtFechaInicio.Text, txtFechaFin.Text, txtFiltro.Text, "", "", False)
                ElseIf cmbFiltar.SelectedIndex = 1 Then ' Folio
                    mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, txtFechaInicio.Text, txtFechaFin.Text, "", "", txtFiltro.Text, False)
                ElseIf cmbFiltar.SelectedIndex = 2 Then ' Caja
                    mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, txtFechaInicio.Text, txtFechaFin.Text, "", txtFiltro.Text, "", False)
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

    Private Sub dtpFechaInicio_ValueChanged(sender As Object, e As EventArgs)
        Try
            If chbTodosCPP.Checked = True Then
                mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, "", "", "", "", "", True)
            Else
                If cmbFiltar.SelectedIndex = 0 Then ' cliente
                    mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, txtFechaInicio.Text, txtFechaFin.Text, txtFiltro.Text, "", "", False)
                ElseIf cmbFiltar.SelectedIndex = 1 Then ' Folio
                    mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, txtFechaInicio.Text, txtFechaFin.Text, "", "", txtFiltro.Text, False)
                ElseIf cmbFiltar.SelectedIndex = 2 Then ' Caja
                    mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, txtFechaInicio.Text, txtFechaFin.Text, "", txtFiltro.Text, "", False)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtpFechaFin_ValueChanged(sender As Object, e As EventArgs)
        Try
            If chbTodosCPP.Checked = True Then
                mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, "", "", "", "", "", True)
            Else
                If cmbFiltar.SelectedIndex = 0 Then ' cliente
                    mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, txtFechaInicio.Text, txtFechaFin.Text, txtFiltro.Text, "", "", False)
                ElseIf cmbFiltar.SelectedIndex = 1 Then ' Folio
                    mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, txtFechaInicio.Text, txtFechaFin.Text, "", "", txtFiltro.Text, False)
                ElseIf cmbFiltar.SelectedIndex = 2 Then ' Caja
                    mtdCaja.buscarCuentasPorPagar(tblCuentasPorPagar, txtFechaInicio.Text, txtFechaFin.Text, "", txtFiltro.Text, "", False)
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

    Private Sub txtFolio_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFiltro1.KeyUp
        Try

            If chbTodos.Checked Then
                mtdCaja.select_ventasCajas(tblVentas, cmbTipoPersona.Text, txtFiltro1.Text, txtCaja.Text, txtFecha2.Text, txtFecha1.Text, True)
            Else
                mtdCaja.select_ventasCajas(tblVentas, cmbTipoPersona.Text, txtFiltro1.Text, txtCaja.Text, txtFecha2.Text, txtFecha1.Text, False)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtFecha1_Click(sender As Object, e As EventArgs) Handles txtFecha1.Click
        Try
            txtFecha1.Visible = False
            mtcFecha1.Visible = True
            txtFecha2.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mtcFecha1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles mtcFecha1.DateSelected

    End Sub

    Private Sub txtFecha2_Click(sender As Object, e As EventArgs) Handles txtFecha2.Click
        Try
            txtFecha2.Visible = False
            mtcFecha2.Visible = True
        Catch ex As Exception

        End Try
    End Sub




    Private Sub mtcFecha2_DateChanged(sender As Object, e As DateRangeEventArgs) Handles mtcFecha2.DateChanged
        Try
            txtFecha2.Visible = True
            mtcFecha2.Visible = False
            Dim d2 As String = Convert.ToDateTime(mtcFecha2.SelectionEnd.ToShortDateString())
            txtFecha2.Text = d2
            mtdCaja.select_ventasCajas(tblVentas, cmbTipoPersona.Text, txtFiltro1.Text, txtCaja.Text, txtFecha2.Text, txtFecha1.Text, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mtcFecha1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles mtcFecha1.DateChanged
        Try
            txtFecha1.Visible = True
            txtFecha2.Visible = True
            mtcFecha1.Visible = False
            Dim d1 As String = Convert.ToDateTime(mtcFecha1.SelectionEnd.ToShortDateString())
            txtFecha1.Text = d1

            If chbTodos.Checked Then
                mtdCaja.select_ventasCajas(tblVentas, cmbTipoPersona.Text, txtFiltro1.Text, txtCaja.Text, txtFecha2.Text, txtFecha1.Text, True)
            Else
                mtdCaja.select_ventasCajas(tblVentas, cmbTipoPersona.Text, txtFiltro1.Text, txtCaja.Text, txtFecha2.Text, txtFecha1.Text, False)
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class