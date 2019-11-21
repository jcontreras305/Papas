Public Class Caja
    Dim mtdCaja As New MetodosCaja
    Public idEmpleado, idCaja As String


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

    Private Sub tabControl1_SelectedIndex(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then 'General
            chbTodos.Checked = False
            If txtFiltro1.Text = String.Empty Then
                mtdCaja.select_ventasCajas(tblVentas, "", "", txtCaja.Text, txtFecha1.Text, txtFecha2.Text, False) 'stpFechaInicio.Value.ToLongDateString, stpFechaFin.Value.ToLongDateString)
            Else
                mtdCaja.select_ventasCajas(tblVentas, cmbTipoPersona.Text, txtFiltro1.Text, txtCaja.Text, txtFecha1.Text, txtFecha2.Text, False) 'stpFechaInicio.Value.ToLongDateString, stpFechaFin.Value.ToLongDateString)
            End If

        ElseIf TabControl1.SelectedIndex = 1 Then ' Abonos y anticipos
            cmbFiltroAA.SelectedIndex = 0
            Dim d1 As Date = Date.Now
            Dim d2 As Date = d1.AddMonths(-1)
            txtDateFinal.Text = String.Format(d1.ToShortDateString(), "dd,MM,yyyy")
            txtDateInicial.Text = String.Format(d2.ToShortDateString(), "dd,MM,yyyy")
            chbTodosAA.Checked = False
            If txtFiltroAA.Text = String.Empty Then
                mtdCaja.seleccionarAbonos(tblAbonos, "", "", txtDateInicial.Text, txtDateFinal.Text, If(chbTodosAA.Checked, True, False), idCaja)
            Else
                mtdCaja.seleccionarAbonos(tblAbonos, cmbFiltroAA.Text, txtFiltroAA.Text, txtDateInicial.Text, txtDateFinal.Text, If(chbTodosAA.Checked, True, False), idCaja)
            End If
        ElseIf TabControl1.SelectedIndex = 2 Then ' Cuentas por cobrar
            Dim d1 As Date = Date.Now
            Dim d2 As Date = d1.AddMonths(-1)
            txtFechaInicio.Text = String.Format(d1.ToShortDateString(), "dd,MM,yyyy")
            txtFechaFin.Text = String.Format(d2.ToShortDateString(), "dd,MM,yyyy")
            cmbFiltar.Text = "Cliente"
            mtdCaja.select_CuentaPorCobrar(tblCuentasPorPagar, cmbFiltar.Text, txtFiltro.Text, txtFechaInicio.Text, txtFechaFin.Text, If(chbTodosCPP.Checked, True, False))
            tblCuentasPorPagar.Columns.Item("idCliente").Visible = False
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
                    mtdCaja.select_CuentaPorCobrar(tblCuentasPorPagar, cmbFiltar.Text, txtFiltro.Text, txtFechaInicio.Text, txtFechaFin.Text, If(chbTodosCPP.Checked, True, False))
                    tblCuentasPorPagar.Columns.Item("idCliente").Visible = False
                ElseIf cmbFiltar.SelectedIndex = 1 Then ' Contacto
                    mtdCaja.select_CuentaPorCobrar(tblCuentasPorPagar, cmbFiltar.Text, txtFiltro.Text, txtFechaInicio.Text, txtFechaFin.Text, If(chbTodosCPP.Checked, True, False))
                    tblCuentasPorPagar.Columns.Item("idCliente").Visible = False
                ElseIf cmbFiltar.SelectedIndex = 2 Then ' % credito
                    mtdCaja.select_CuentaPorCobrar(tblCuentasPorPagar, cmbFiltar.Text, txtFiltro.Text, txtFechaInicio.Text, txtFechaFin.Text, If(chbTodosCPP.Checked, True, False))
                    tblCuentasPorPagar.Columns.Item("idCliente").Visible = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chbTodosCPP_CheckedChanged(sender As Object, e As EventArgs) Handles chbTodosCPP.CheckedChanged
        Try
            mtdCaja.select_CuentaPorCobrar(tblCuentasPorPagar, "", "", "", "", True)
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

            ElseIf TabControl1.SelectedIndex = 1 Then 'Abonos

            ElseIf TabControl1.SelectedIndex = 2 Then 'Cuentas por pagar

            Else ' precorte 

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


    Private Sub txtFecha2_Click(sender As Object, e As EventArgs) Handles txtFecha2.Click
        Try
            txtFecha2.Visible = False
            mtcFecha2.Visible = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtFechaInicio_MouseClick(sender As Object, e As EventArgs) Handles txtFechaInicio.MouseClick
        Try
            txtFechaInicio.Visible = False
            mtcFechaInicio.Visible = True
            txtFechaFin.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtFechaFin_MouseClick(sender As Object, e As MouseEventArgs) Handles txtFechaFin.MouseClick
        Try
            txtFechaFin.Visible = False
            mtcFechaFin.Visible = True
        Catch ex As Exception

        End Try
    End Sub


    Private Sub tblCuentasPorPagar_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tblCuentasPorPagar.MouseDoubleClick
        Try
            Dim cppd As New CajaCuentasPPD
            Me.AddOwnedForm(cppd)

            Dim index As Int16 = tblCuentasPorPagar.CurrentRow.Index
            Dim cont As Int16 = tblCuentasPorPagar.Rows.Count
            If cont > 0 Then
                cont = 0
                For Each row As DataGridViewRow In tblCuentasPorPagar.Rows
                    If index = cont Then
                        mtdCaja.selectVentasPendientesCliente(cppd.tblVentasPendientes, row.Cells("idCliente").Value)
                        'cppd.txtSaldo.Text = row.Cells("Saldo").Value
                        cppd.idCliente = row.Cells("idCliente").Value.ToString()
                        cppd.idEmpleado = Me.idEmpleado
                        cppd.idCaja = Me.idCaja
                        Exit For
                    Else
                        cont += 1
                    End If
                Next
            End If

            cppd.ShowDialog()
            mtdCaja.select_CuentaPorCobrar(tblCuentasPorPagar, cmbFiltar.Text, txtFiltro.Text, txtFechaInicio.Text, txtFechaFin.Text, If(chbTodosCPP.Checked, True, False))
        Catch ex As Exception

        End Try
    End Sub



    Private Sub mtcFechaInicio_DateSelected(sender As Object, e As DateRangeEventArgs) Handles mtcFechaInicio.DateSelected
        Try
            txtFechaInicio.Visible = True
            txtFechaFin.Visible = True
            mtcFechaInicio.Visible = False
            Dim d1 As String = Convert.ToDateTime(mtcFechaInicio.SelectionEnd.ToShortDateString())
            txtFechaInicio.Text = d1
            mtdCaja.select_CuentaPorCobrar(tblCuentasPorPagar, cmbFiltar.Text, txtFiltro.Text, txtFechaInicio.Text, txtFechaFin.Text, If(chbTodosCPP.Checked, True, False))
            tblCuentasPorPagar.Columns.Item("idCliente").Visible = False
        Catch ex As Exception

        End Try
    End Sub



    Private Sub mtcFechaFin_DateSelected(sender As Object, e As DateRangeEventArgs) Handles mtcFechaFin.DateSelected
        Try
            txtFechaFin.Visible = True
            mtcFechaFin.Visible = False
            Dim d2 As String = Convert.ToDateTime(mtcFechaFin.SelectionEnd.ToShortDateString())
            txtFechaFin.Text = d2
            mtdCaja.select_CuentaPorCobrar(tblCuentasPorPagar, cmbFiltar.Text, txtFiltro.Text, txtFechaInicio.Text, txtFechaFin.Text, If(chbTodosCPP.Checked, True, False))
            tblCuentasPorPagar.Columns.Item("idCliente").Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mtcFecha1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles mtcFecha1.DateSelected
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



    Private Sub mtcFecha2_DateSelected(sender As Object, e As DateRangeEventArgs) Handles mtcFecha2.DateSelected
        Try
            txtFecha2.Visible = True
            mtcFecha2.Visible = False
            Dim d2 As String = Convert.ToDateTime(mtcFecha2.SelectionEnd.ToShortDateString())
            txtFecha2.Text = d2
            mtdCaja.select_ventasCajas(tblVentas, cmbTipoPersona.Text, txtFiltro1.Text, txtCaja.Text, txtFecha2.Text, txtFecha1.Text, False)
        Catch ex As Exception

        End Try
    End Sub


    '############################ fechas abono ############################################
    Private Sub txtDateFinal_MouseClick(sender As Object, e As MouseEventArgs) Handles txtDateFinal.MouseClick
        If mtcDateInicial.Visible Then
            mtcDateInicial.Visible = False
            txtDateInicial.Visible = False
        End If
        txtDateFinal.Visible = False
        mtcDateFinal.Visible = True
        txtDateInicial.Visible = False
    End Sub

    Private Sub txtDateInicial_MouseClick_1(sender As Object, e As MouseEventArgs) Handles txtDateInicial.MouseClick

        mtcDateInicial.Visible = True
        txtDateInicial.Visible = False
    End Sub

    Private Sub mtcDateInicial_DateSelected(sender As Object, e As DateRangeEventArgs) Handles mtcDateInicial.DateSelected
        Try
            mtcDateInicial.Visible = False
            txtDateInicial.Visible = True
            Dim d1 As String = Convert.ToDateTime(mtcDateInicial.SelectionEnd.ToShortDateString())
            txtDateInicial.Text = d1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mtcDateFinal_DateSelected(sender As Object, e As DateRangeEventArgs) Handles mtcDateFinal.DateSelected
        Try
            mtcDateFinal.Visible = False
            txtDateFinal.Visible = True
            txtDateInicial.Visible = True

            Dim d2 As String = Convert.ToDateTime(mtcDateFinal.SelectionEnd.ToShortDateString())
            txtDateFinal.Text = d2
        Catch ex As Exception

        End Try
    End Sub

End Class