Public Class Reporte_de_ventas

    Dim caj As New MetodoReportesVentas
    Private Sub Reporte_de_ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpInicial.Visible = False
        dtpFinal.Visible = False
        lblFechaFinal.Visible = False
        lblfeInicial.Visible = False
        lblHasta.Visible = False
        cboDatos.Visible = False
        txtNombre.Visible = False
        lblNombre.Visible = False
        jtableNombres.Visible = False
        txtNombreCleintes.Visible = False
        cboDatos.ResetText()

    End Sub

    Private Sub mosCaja()
        Try
            caj.Caja(cboDatos)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mostraem()
        Dim mos As New MetodoReportesVentas
        jtableNombres.DataSource = mos.Empleados
    End Sub

    Private Sub mostta()
        Try
            caj.Sucursal(cboDatos)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mostrarClientes()
        Dim mos As New MetodoReportesVentas
        jtableNombres.DataSource = mos.Cliente
    End Sub



    Private Sub chbCaja_CheckedChanged(sender As Object, e As EventArgs) Handles chbCaja.CheckedChanged
        If chbCaja.Checked = True Then
            chbSucursal.Enabled = False
            chbCliente.Enabled = False
            chbEmpleado.Enabled = False
            chbFechas.Enabled = False
            cboDatos.Visible = True
            mosCaja()
        ElseIf chbCaja.Checked = False Then
            chbSucursal.Enabled = True
            chbCliente.Enabled = True
            chbEmpleado.Enabled = True
            chbFechas.Enabled = True
            dtpInicial.Enabled = True
            dtpFinal.Enabled = True
            cboDatos.Visible = False
            cboDatos.ResetText()
        End If
    End Sub

    Private Sub chbSucursal_CheckedChanged(sender As Object, e As EventArgs) Handles chbSucursal.CheckedChanged
        If chbSucursal.Checked = True Then
            chbCaja.Enabled = False
            chbCliente.Enabled = False
            chbEmpleado.Enabled = False
            chbFechas.Enabled = False
            cboDatos.Visible = True
            mostta()
        ElseIf chbSucursal.Checked = False Then
            chbCaja.Enabled = True
            chbCliente.Enabled = True
            chbEmpleado.Enabled = True
            chbFechas.Enabled = True
            dtpInicial.Enabled = True
            dtpFinal.Enabled = True
            cboDatos.Visible = False
            cboDatos.ResetText()
        End If
    End Sub


    Private Sub btnGenerar1_Click(sender As Object, e As EventArgs) Handles btnGenerar1.Click
        Dim con As Integer
        con = 0

        While Not con > 5

            con = con + 1

            Select Case con
                Case 1
                    If chbCaja.Checked Then
                        Dim caja As String = (cboDatos.Text)
                        Dim reportcaja As New ReporteVentas2
                        reportcaja.nomCaja = caja
                        reportcaja.ShowDialog()
                        Exit Select

                    End If

                Case 2
                    If chbSucursal.Checked Then
                        Dim su As String = (cboDatos.Text)
                        Dim reporSu As New ReportSucursal
                        reporSu.nomSu = su
                        reporSu.ShowDialog()
                        Exit Select
                    End If
                Case 3
                    If chbCliente.Checked Then
                        Dim cli As String = jtableNombres.CurrentRow.Cells(0).Value
                        Dim reporClien As New ReporteCliente
                        reporClien.nomCli = cli
                        reporClien.ShowDialog()
                        Exit Select
                    End If
                Case 4
                    If chbEmpleado.Checked Then
                        Dim emple As String = jtableNombres.CurrentRow.Cells(0).Value
                        Dim reporEm As New ReportEmpleado
                        reporEm.nomEm = emple
                        reporEm.ShowDialog()
                        Exit Select
                    End If
                Case 5
                    If chbFechas.Checked Then
                        Dim fechaIni As Date = CDate(dtpInicial.Text)
                        Dim fechaFin As Date = CDate(dtpFinal.Text)
                        Dim reporFechas As New ReportFechas

                        reporFechas.feIni = fechaIni
                        reporFechas.feFin = fechaFin

                        reporFechas.ShowDialog()

                    End If

                Case Else

            End Select

        End While

    End Sub

    Private Sub chbFechas_CheckedChanged_1(sender As Object, e As EventArgs) Handles chbFechas.CheckedChanged
        If chbFechas.Checked = True Then
            chbCaja.Enabled = False
            chbSucursal.Enabled = False
            chbCliente.Enabled = False
            chbEmpleado.Enabled = False
            dtpInicial.Visible = True
            dtpFinal.Visible = True
            lblFechaFinal.Visible = True
            lblfeInicial.Visible = True
            lblHasta.Visible = True
        ElseIf chbFechas.Checked = False Then
            chbCaja.Enabled = True
            chbSucursal.Enabled = True
            chbCliente.Enabled = True
            chbEmpleado.Enabled = True
            dtpInicial.Visible = False
            dtpFinal.Visible = False
            lblFechaFinal.Visible = False
            lblfeInicial.Visible = False
            lblHasta.Visible = False
            cboDatos.ResetText()
        End If
    End Sub

    Private Sub chbEmpleado_CheckedChanged_1(sender As Object, e As EventArgs) Handles chbEmpleado.CheckedChanged
        If chbEmpleado.Checked = True Then
            chbCaja.Enabled = False
            chbSucursal.Enabled = False
            chbCliente.Enabled = False
            chbFechas.Enabled = False
            dtpInicial.Enabled = False
            dtpFinal.Enabled = False
            cboDatos.Visible = False
            txtNombre.Visible = True
            lblNombre.Visible = True
            jtableNombres.Visible = True
            txtNombreCleintes.Visible = False
            mostraem()
        ElseIf chbEmpleado.Checked = False Then
            chbCaja.Enabled = True
            chbSucursal.Enabled = True
            chbCliente.Enabled = True
            chbFechas.Enabled = True
            dtpInicial.Enabled = True
            dtpFinal.Enabled = True
            cboDatos.ResetText()
            txtNombre.Visible = False
            lblNombre.Visible = False
            jtableNombres.Visible = False
            txtNombreCleintes.Visible = False
        End If
    End Sub

    Private Sub chbCliente_CheckedChanged_1(sender As Object, e As EventArgs) Handles chbCliente.CheckedChanged
        If chbCliente.Checked = True Then
            chbCaja.Enabled = False
            chbSucursal.Enabled = False
            chbEmpleado.Enabled = False
            chbFechas.Enabled = False
            cboDatos.Visible = False
            txtNombre.Visible = False
            lblNombre.Visible = True
            jtableNombres.Visible = True
            txtNombreCleintes.Visible = True
            mostrarClientes()
        ElseIf chbCliente.Checked = False Then
            chbCaja.Enabled = True
            chbSucursal.Enabled = True
            chbEmpleado.Enabled = True
            chbFechas.Enabled = True
            dtpInicial.Enabled = True
            dtpFinal.Enabled = True
            txtNombre.Visible = False
            txtNombreCleintes.Visible = False
            lblNombre.Visible = False
            jtableNombres.Visible = False
            cboDatos.ResetText()
        End If
    End Sub

    Private Sub txtNombreCleintes_TextChanged(sender As Object, e As EventArgs) Handles txtNombreCleintes.TextChanged
        If caj.BuscarNombreClientes(txtNombre.Text).rows.count > 0 Then
            jtableNombres.DataSource = caj.BuscarNombreClientes(txtNombre.Text)
        End If

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        If caj.BuscarNombre(txtNombre.Text).rows.count > 0 Then
            jtableNombres.DataSource = caj.BuscarNombre(txtNombre.Text)
        End If
    End Sub
End Class