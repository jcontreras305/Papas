Imports System.Data.SqlClient
Public Class NuevaVenta
    Public user, idEmpleado, lim, saldo As String
    Dim savef As String
    Dim flag As Boolean = False
    Public explicita As Boolean
    Public idCaja As String
    Dim folio As Int16
    Dim mtdv As New MetodosVenta
    Public descuentoC As String

    Public idCliente, nombreCliente As String


    Private Sub NuevaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mtdv.llenarDatagridview(tblDetalleVenta)

        npdCantidadPagada.Increment = 0.01
        npdCantidadPagada.DecimalPlaces = 2
        npdCantidadPagada.Maximum = 9999
        cmbFormaPago.SelectedIndex = 1
        cmbFiltroVenta.SelectedIndex = 0
        npdCantidadPagada.ThousandsSeparator = True
        npdkilos.Increment = 0.01
        npdkilos.DecimalPlaces = 2
        npdkilos.ThousandsSeparator = True
        npdprecio.Increment = 0.01
        npdprecio.DecimalPlaces = 2
        npdprecio.ThousandsSeparator = True
        mtdv.llenarComboBodega(cmbBodega)
        mtdv.llenarComboProducto(tblProductos, cmbBodega.Text)

        Dim i As Int64

        For i = 0 To tblDetalleVenta.RowCount

        Next

        savef = DateTime.Now.ToString("dd/MM/yyyy")
        flag = True
        cmbBodega.DropDownStyle = 2

        cmbFormaPago.DropDownStyle = 2

        npdkilos.Value = 1.0
        cmbBodega.Text = "Selecciona"

        If tblProductos.RowCount > 1 Then
            npdprecio.Value = Convert.ToDecimal(Convert.ToString(tblProductos.CurrentRow.Cells(1).Value))
        End If
        If tblventa.RowCount < 1 Then

            tblventa.Columns.Add("Producto", "Producto")
            tblventa.Columns.Add("Kilogramos", "Kilogramos")
            tblventa.Columns.Add("Precio", "Precio")


        End If
        tblDetalleVenta.Columns.Item("idventadetalle").Visible = False
    End Sub

    Private Sub cmbFormaPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFormaPago.SelectedIndexChanged
        If cmbFormaPago.Text = "Credito" Then
            npdCantidadPagada.Enabled = True
            AddOwnedForm(Montocredito)
            npdCantidadPagada.Minimum = 0
            npdCantidadPagada.Maximum = Convert.ToDecimal(lim) - Convert.ToDecimal(saldo)


        Else
            npdCantidadPagada.Enabled = False
            npdCantidadPagada.Value = t
        End If
    End Sub

    Dim t As Double

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtNombreCliente.Text <> String.Empty Then
            tblventa.Rows.Add(Convert.ToString(tblProductos.CurrentRow.Cells(0).Value), npdkilos.Value, (npdprecio.Value * npdkilos.Value))
        Else
            MsgBox("Seleccione un Cliente")
        End If
        If tblventa.RowCount > 1 And txtNombreCliente.Text <> String.Empty Then
            Dim i As Integer
            Dim total As Double
            For i = 1 To tblventa.RowCount
                total += Convert.ToDecimal(Convert.ToString(tblventa.Rows(i - 1).Cells(2).Value))
                t = total
            Next
            lblTotal.Text = Convert.ToString(total)

        ElseIf txtNombreCliente.Text <> String.Empty Then
            lblTotal.Text = Convert.ToString(Convert.ToString((npdprecio.Value * npdkilos.Value)))
            t = (npdprecio.Value * npdkilos.Value)
        End If
    End Sub


    Dim c As String 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        AddOwnedForm(CantidadMonetariaExplicitaInicio)
        CantidadMonetariaExplicitaInicio.txtTotalPagar.Text = lblTotal.Text
        CantidadMonetariaExplicitaInicio.vn = True
        CantidadMonetariaExplicitaInicio.ShowDialog()
        Dim estado As String

        Dim j As Integer
        Dim existencia As Boolean = True
        For j = 1 To tblventa.RowCount
            c = mtdv.existenciaAlmacen(Convert.ToString(tblventa.Rows(j - 1).Cells(0).Value), cmbBodega.Text)
            If c = 0 Then
                MessageBox.Show("Tiene una existencia del producto " + Convert.ToString(tblventa.Rows(j - 1).Cells(1).Value) + "en estado de agotado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                existencia = False
            End If
        Next

        If explicita And existencia Then
            If txtNombreCliente.Text <> String.Empty And tblventa.RowCount > 0 And npdCantidadPagada.Value >= 0 Then
                If cmbFormaPago.Text = "Credito" Then
                    If Convert.ToDecimal(lim - saldo) > Convert.ToDecimal(lblTotal.Text) Then

                        If Convert.ToDecimal(saldo) < Convert.ToDecimal(lim) Then

                            If MessageBox.Show("¿Desea utilizar su saldo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                mtdv.actualizar_credito(idCliente, (Convert.ToDouble(lblTotal.Text.Replace(",", ".")) - npdCantidadPagada.Value))

                                If cbxEspera.Checked Then
                                    estado = "E"
                                    mtdv.insertarVenta(savef.ToString, t.ToString.Replace(",", "."), npdCantidadPagada.Value, txtNombreCliente.Text, idEmpleado, cmbBodega.Text, estado, cmbFormaPago.Text, idCaja, idCliente)
                                    MsgBox("Venta exitosa")
                                Else

                                    estado = "D"
                                    mtdv.insertarVenta(savef.ToString, t.ToString.Replace(",", "."), lblTotal.Text.Replace(",", "."), txtNombreCliente.Text, idEmpleado, cmbBodega.Text, estado, cmbFormaPago.Text, idCaja, idCliente)
                                    MsgBox("Venta exitosa")
                                  
                                End If
                                Dim i As Integer
                                Try
                                    For i = 1 To tblventa.RowCount
                                        c = mtdv.existenciaAlmacen(Convert.ToString(tblventa.Rows(i - 1).Cells(0).Value), cmbBodega.Text)
                                        If c > 200 Then
                                            mtdv.insertarVentaDetalle(Convert.ToString(tblventa.Rows(i - 1).Cells(0).Value),
                                                      Convert.ToString(tblventa.Rows(i - 1).Cells(1).Value).Replace(",", "."),
                                                      Convert.ToString(tblventa.Rows(i - 1).Cells(2).Value).Replace(",", "."),
                                                      cmbBodega.Text, If(estado = "D", True, False))
                                        Else
                                            MessageBox.Show("Tiene una existencia del producto " + Convert.ToString(tblventa.Rows(i - 1).Cells(0).Value) + " menos a 200", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            mtdv.insertarVentaDetalle(Convert.ToString(tblventa.Rows(i - 1).Cells(0).Value),
                                                      Convert.ToString(tblventa.Rows(i - 1).Cells(1).Value).Replace(",", "."),
                                                      Convert.ToString(tblventa.Rows(i - 1).Cells(2).Value).Replace(",", "."),
                                                      cmbBodega.Text, If(estado = "D", True, False))
                                        End If
                                    Next
                                Catch ex As Exception
                                    MsgBox("Actualizar_Producto duplicado")
                                End Try


                            Else
                                mtdv.actualizar_credito(idCliente, npdCantidadPagada.Value)

                                If cbxEspera.Checked Then
                                    estado = "E"
                                    mtdv.insertarVenta(savef.ToString, t.ToString, npdCantidadPagada.Value, txtNombreCliente.Text, idEmpleado, cmbBodega.Text, estado, cmbFormaPago.Text, idCaja, idCliente)
                                    MsgBox("Venta exitosa")
                                Else

                                    estado = "D"
                                    mtdv.insertarVenta(savef.ToString, t.ToString, lblTotal.Text.Replace(",", "."), txtNombreCliente.Text, idEmpleado, cmbBodega.Text, estado, cmbFormaPago.Text, idCaja, idCliente)
                                    MsgBox("Venta exitosa")

                                End If
                                Dim i As Integer
                                Try
                                    For i = 1 To tblventa.RowCount
                                        c = mtdv.existenciaAlmacen(Convert.ToString(tblventa.Rows(i - 1).Cells(0).Value), cmbBodega.Text)
                                        If c > 200 Then
                                            mtdv.insertarVentaDetalle(Convert.ToString(tblventa.Rows(i - 1).Cells(0).Value),
                                                      Convert.ToString(tblventa.Rows(i - 1).Cells(1).Value).Replace(",", "."),
                                                      Convert.ToString(tblventa.Rows(i - 1).Cells(2).Value).Replace(",", "."),
                                                      cmbBodega.Text, If(estado = "D", True, False))
                                        Else
                                            MessageBox.Show("Tiene una existencia del producto " + Convert.ToString(tblventa.Rows(i - 1).Cells(0).Value) + " menos a 200", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            mtdv.insertarVentaDetalle(Convert.ToString(tblventa.Rows(i - 1).Cells(0).Value),
                                                      Convert.ToString(tblventa.Rows(i - 1).Cells(1).Value).Replace(",", "."),
                                                      Convert.ToString(tblventa.Rows(i - 1).Cells(2).Value).Replace(",", "."),
                                                      cmbBodega.Text, If(estado = "D", True, False))
                                        End If
                                    Next
                                Catch ex As Exception
                                    MsgBox("Actualizar_Producto duplicado")
                                End Try


                            End If
                        Else
                            MsgBox("Tu credito se encuentra al limite")
                        End If

                    Else
                        MsgBox("Lo sentimos el Cliente Solo puede realizar ventas al contado")
                    End If

                ElseIf cmbFormaPago.Text = "Contado" Then

                    If cbxEspera.Checked Then
                        estado = "E"
                        mtdv.insertarVenta(savef.ToString, t.ToString, npdCantidadPagada.Value, txtNombreCliente.Text, idEmpleado, cmbBodega.Text, "E", cmbFormaPago.Text, idCaja, idCliente)
                        MsgBox("Venta exitosa")
                    Else
                        estado = "P"
                        mtdv.insertarVenta(savef.ToString, t.ToString, npdCantidadPagada.Value.ToString.Replace(",", "."), txtNombreCliente.Text, idEmpleado, cmbBodega.Text, "P", cmbFormaPago.Text, idCaja, idCliente)
                        MsgBox("Venta exitosa")
                    End If

                    Try
                        For i = 1 To tblventa.RowCount
                            c = mtdv.existenciaAlmacen(Convert.ToString(tblventa.Rows(i - 1).Cells(0).Value), cmbBodega.Text)
                            If c > 200 Then

                                mtdv.insertarVentaDetalle(Convert.ToString(tblventa.Rows(i - 1).Cells(0).Value),
                                                      Convert.ToString(tblventa.Rows(i - 1).Cells(1).Value).Replace(",", "."),
                                                      Convert.ToString(tblventa.Rows(i - 1).Cells(2).Value).Replace(",", "."),
                                                      cmbBodega.Text, If(estado = "P", True, False))
                            Else
                                MessageBox.Show("Tiene una existencia del producto " + Convert.ToString(tblventa.Rows(i - 1).Cells(0).Value) + " menos a 200", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                mtdv.insertarVentaDetalle(Convert.ToString(tblventa.Rows(i - 1).Cells(0).Value),
                                                      Convert.ToString(tblventa.Rows(i - 1).Cells(1).Value),
                                                      Convert.ToString(tblventa.Rows(i - 1).Cells(2).Value),
                                                      cmbBodega.Text, If(estado = "P", True, False))
                            End If
                        Next
                    Catch ex As Exception
                        MsgBox("Actualizar_Producto duplicado")
                    End Try

                End If

            Else
                MsgBox("Completa los campos")
            End If

        End If

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxBusquedaFiltrada.KeyPress
        If cmbFiltroVenta.Text = "Cliente" Then
            mtdv.llenarDatagridview_filtroCliente(tblDetalleVenta, tbxBusquedaFiltrada.Text)

        ElseIf cmbFiltroVenta.Text = "Clave Venta" Then
            mtdv.llenarDatagridview_filtroIdVenta(tblDetalleVenta, tbxBusquedaFiltrada.Text)

        ElseIf cmbFiltroVenta.Text = "Empleado" Then
            mtdv.llenarDatagridview_filtroEmpleado(tblDetalleVenta, tbxBusquedaFiltrada.Text)

        ElseIf cmbFiltroVenta.Text = "Fecha" Then
            mtdv.llenarDatagridview_filtroFecha(tblDetalleVenta, tbxBusquedaFiltrada.Text)

        ElseIf cmbFiltroVenta.Text = "Total de Venta" Then
            mtdv.llenarDatagridview_filtroTotal(tblDetalleVenta, tbxBusquedaFiltrada.Text)

        ElseIf cmbFiltroVenta.Text = "Producto" Then
            mtdv.llenarDatagridview_filtroVersion(tblDetalleVenta, tbxBusquedaFiltrada.Text)

        ElseIf cmbFiltroVenta.Text = "Cantidad" Then
            mtdv.llenarDatagridview_filtroCantidad(tblDetalleVenta, tbxBusquedaFiltrada.Text)

        ElseIf cmbFiltroVenta.Text = "Bodega" Then
            mtdv.llenarDatagridview_filtroBodega(tblDetalleVenta, tbxBusquedaFiltrada.Text)

        ElseIf cmbFiltroVenta.Text = "Precio" Then
            mtdv.llenarDatagridview_filtroPrecio(tblDetalleVenta, tbxBusquedaFiltrada.Text)
        Else
            mtdv.llenarDatagridview(tblDetalleVenta)

        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If cmbFiltroVenta.Text = "Cliente" Then
            mtdv.llenarDatagridview_filtroCliente(tblDetalleVenta, tbxBusquedaFiltrada.Text)

        ElseIf cmbFiltroVenta.Text = "Clave Venta" Then
            mtdv.llenarDatagridview_filtroIdVenta(tblDetalleVenta, tbxBusquedaFiltrada.Text)

        ElseIf cmbFiltroVenta.Text = "Empleado" Then
            mtdv.llenarDatagridview_filtroEmpleado(tblDetalleVenta, tbxBusquedaFiltrada.Text)

        ElseIf cmbFiltroVenta.Text = "Fecha" Then
            mtdv.llenarDatagridview_filtroFecha(tblDetalleVenta, tbxBusquedaFiltrada.Text)

        ElseIf cmbFiltroVenta.Text = "Total de Venta" Then
            mtdv.llenarDatagridview_filtroTotal(tblDetalleVenta, tbxBusquedaFiltrada.Text)

        ElseIf cmbFiltroVenta.Text = "Producto" Then
            mtdv.llenarDatagridview_filtroVersion(tblDetalleVenta, tbxBusquedaFiltrada.Text)

        ElseIf cmbFiltroVenta.Text = "Cantidad" Then
            mtdv.llenarDatagridview_filtroCantidad(tblDetalleVenta, tbxBusquedaFiltrada.Text)

        ElseIf cmbFiltroVenta.Text = "Bodega" Then
            mtdv.llenarDatagridview_filtroBodega(tblDetalleVenta, tbxBusquedaFiltrada.Text)

        ElseIf cmbFiltroVenta.Text = "Precio" Then
            mtdv.llenarDatagridview_filtroPrecio(tblDetalleVenta, tbxBusquedaFiltrada.Text)
        Else
            mtdv.llenarDatagridview(tblDetalleVenta)

        End If
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Try
            Dim id As String = Convert.ToString(tblDetalleVenta.CurrentRow.Cells(0).Value)
            Dim estatus As String = Convert.ToString(tblDetalleVenta.CurrentRow.Cells("estatus").Value)
            If estatus <> "P" Then
                Actualizar_Venta.idCliente = idCliente
                Actualizar_Venta.id = id
                Actualizar_Venta.user = idEmpleado
                Actualizar_Venta.Show()
            Else
                MsgBox("venta Cobrada, no es posible realizar alteraciones.")
            End If
        Catch
            MsgBox("Seleciona un renglos")
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If tblDetalleVenta.CurrentRow.Cells("estatus").Value = "D" Then
            If tblDetalleVenta.CurrentRow.Cells("cantidadPagada").Value < tblDetalleVenta.CurrentRow.Cells("totalPagar").Value Then

                If MessageBox.Show("¿Desea utilizar su saldo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim datos() As String = mtdv.infcliente(tblDetalleVenta.CurrentRow.Cells("Cliente").Value)
                    AddOwnedForm(Montocredito)
                    Montocredito.npdCredito.Maximum = Convert.ToDecimal(datos(1)) - Convert.ToDecimal(datos(2))
                    Montocredito.npdCredito.Minimum = 0
                    Montocredito.ShowDialog()

                    If Convert.ToDecimal(datos(1)) > Convert.ToDecimal(datos(2)) Then
                        mtdv.actualizar_credito(datos(0), descuentoC)
                        mtdv.actualizar_totalpagado(descuentoC, tblDetalleVenta.CurrentRow.Cells(0).Value)
                        mtdv.llenarDatagridview(tblDetalleVenta)


                    End If

                End If
            Else
                MsgBox("Venta Pagada")
            End If
        Else
            MessageBox.Show("Este empleado no cuenta con saldo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub




    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txbFiltro.TextChanged
        mtdv.llenarComboProductofiltro(tblProductos, cmbBodega.Text, txbFiltro.Text)
    End Sub



    Private Sub lblTotal_TextChanged(sender As Object, e As EventArgs) Handles lblTotal.TextChanged
        If cmbFormaPago.Text = "Contado" Then
            npdCantidadPagada.Value = Convert.ToDecimal(lblTotal.Text)

        End If

    End Sub



    Private Sub tblProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblProductos.CellClick
        npdprecio.Value = Convert.ToDecimal(Convert.ToString(tblProductos.CurrentRow.Cells(1).Value))

    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim clave As String = tblDetalleVenta.CurrentRow.Cells(0).Value

        If tblDetalleVenta.CurrentRow.Cells("estatus").Value = "E" Then

            If tblDetalleVenta.CurrentRow.Cells("cantidadPagada").Value = tblDetalleVenta.CurrentRow.Cells("totalPagar").Value Then

                For i = 1 To tblDetalleVenta.RowCount
                    If clave = tblDetalleVenta.Rows(i - 1).Cells(0).Value Then
                        mtdv.updateExistencia(tblDetalleVenta.Rows(i - 1).Cells(2).Value, tblDetalleVenta.Rows(i - 1).Cells(3).Value, tblDetalleVenta.Rows(i - 1).Cells(4).Value, tblDetalleVenta.CurrentRow.Cells(0).Value)
                    End If
                Next
            Else
                MsgBox("Cantidad pagada incompleta")
            End If


        Else
            MsgBox("La venta debe estar en espera")
        End If

    End Sub






    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If tblventa.RowCount > 0 And txtNombreCliente.Text <> String.Empty Then
            tblventa.Rows.Remove(tblventa.CurrentRow)
            Dim i As Integer
            Dim total As Double
            For i = 1 To tblventa.RowCount
                total += Convert.ToDecimal(Convert.ToString(tblventa.Rows(i - 1).Cells(2).Value))
                t = total
            Next

            lblTotal.Text = Convert.ToString(total)

        Else

            lblTotal.Text = Convert.ToString(0)

        End If

    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        If tblventa.Rows.Count > 0 Then
            MsgBox("No puedes cambiar de Cliente en un venta." + vbCrLf + "Puedes poner en espera o concretar la venta")
        Else
            Dim bc As New BuscaCliente
            AddOwnedForm(bc)
            bc.ShowDialog()
            If lim > 0 And Convert.ToDecimal(saldo) < Convert.ToDecimal(lim) Then
                cmbFormaPago.Items.Clear()
                cmbFormaPago.Items.Add("Contado")
                cmbFormaPago.Items.Add("Credito")
                cmbFormaPago.SelectedIndex = 1
            Else
                MsgBox("Es probable que el cliente no tenga autorizado un credito o " + vbCrLf + "el saldo es insuficiente." + vbCrLf + "Limiite de credito: " + CDbl(lim).ToString("N") + " Saldo al día: " + CDbl(saldo).ToString("N"))
                cmbFormaPago.Items.Clear()
                cmbFormaPago.Items.Add("Contado")
                cmbFormaPago.SelectedIndex = 0
            End If
        End If
    End Sub
End Class