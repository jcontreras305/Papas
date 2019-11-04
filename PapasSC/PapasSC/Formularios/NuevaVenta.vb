Public Class NuevaVenta
    Public user, idEmpleado As String
    Dim savef As String
    Dim flag As Boolean = False
    Public explicita As Boolean
    Public idCaja As String
    Dim folio As Int16
    Dim mtdv As New MetodosVenta


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
            tblventa.Columns.Add("Cliente", "Cliente")
            tblventa.Columns.Add("Producto", "Producto")
            tblventa.Columns.Add("Kilogramos", "Kilogramos")
            tblventa.Columns.Add("Precio", "Precio")
            tblventa.Columns.Add("Pago", "Pago")
            tblventa.Columns.Add("Empleado", "Empleado")
            tblventa.Columns.Add("Tipo de pago", "Tipo de pago")
            tblventa.Columns.Add("Bodega", "Bodega")
        End If
        tblDetalleVenta.Columns.Item("idventadetalle").Visible = False
    End Sub

    Private Sub cmbFormaPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFormaPago.SelectedIndexChanged
        If cmbFormaPago.SelectedIndex = 0 Then
            npdCantidadPagada.Enabled = True

        Else
            npdCantidadPagada.Enabled = False
            npdCantidadPagada.Value = t
        End If
    End Sub

    Dim t As Double

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtNombreCliente.Text <> String.Empty Then
            tblventa.Rows.Add(txtNombreCliente.Text, Convert.ToString(tblProductos.CurrentRow.Cells(0).Value), npdkilos.Value, (npdprecio.Value * npdkilos.Value), npdCantidadPagada.Value, user, cmbFormaPago.Text, cmbBodega.Text)
        Else
            MsgBox("Seleccione un Cliente")
        End If
        If tblventa.RowCount > 1 And txtNombreCliente.Text <> String.Empty Then
            Dim i As Integer
            Dim total As Double
            For i = 1 To tblventa.RowCount
                total += Convert.ToDecimal(Convert.ToString(tblventa.Rows(i - 1).Cells(3).Value))
                t = total
            Next
            lblTotal.Text = Convert.ToString(total)

        ElseIf txtNombreCliente.Text <> String.Empty Then
            lblTotal.Text = Convert.ToString(Convert.ToString((npdprecio.Value * npdkilos.Value)))
            t = (npdprecio.Value * npdkilos.Value)
        End If

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtNombreCliente.Text <> String.Empty And tblventa.RowCount > 0 And npdCantidadPagada.Value > 0 Then
            CantidadMonetariaExplicitaInicio.totalpagar.Text = lblTotal.Text
            CantidadMonetariaExplicitaInicio.Show()




            If cbxEspera.Checked Then

                If cmbFormaPago.Text = "Credito" Then
                    mtdv.insertarVenta(savef.ToString, t.ToString, npdCantidadPagada.Value, txtNombreCliente.Text, user, cmbBodega.Text, "D", cmbFormaPago.Text, idCaja, idCliente)
                Else
                    mtdv.insertarVenta(savef.ToString, t.ToString, npdCantidadPagada.Value, txtNombreCliente.Text, user, cmbBodega.Text, "E", cmbFormaPago.Text, idCaja, idCliente)
                End If
                Dim i As Integer

                MsgBox(tblventa.RowCount)
                Try
                    For i = 1 To tblventa.RowCount

                        mtdv.insertarVentaDetalle(Convert.ToString(tblventa.Rows(i - 1).Cells(1).Value),
                                          Convert.ToString(tblventa.Rows(i - 1).Cells(2).Value),
                                          Convert.ToString(tblventa.Rows(i - 1).Cells(3).Value),
                                          Convert.ToString(tblventa.Rows(i - 1).Cells(7).Value))
                    Next
                Catch ex As Exception
                    MsgBox("Actualizar_Producto duplicado")
                End Try
            Else
                If cmbFormaPago.Text = "Credito" Then
                    mtdv.insertarVenta(savef.ToString, t.ToString, npdCantidadPagada.Value, txtNombreCliente.Text, user, cmbBodega.Text, "D", cmbFormaPago.Text, idCaja, idCliente)
                Else
                    mtdv.insertarVenta(savef.ToString, t.ToString, npdCantidadPagada.Value, txtNombreCliente.Text, user, cmbBodega.Text, "P", cmbFormaPago.Text, idCaja, idCliente)
                End If


                MsgBox(tblventa.RowCount)
                Try
                    For i = 1 To tblventa.RowCount

                        mtdv.insertarVentaDetalle(Convert.ToString(tblventa.Rows(i - 1).Cells(1).Value),
                                          Convert.ToString(tblventa.Rows(i - 1).Cells(2).Value),
                                          Convert.ToString(tblventa.Rows(i - 1).Cells(3).Value),
                                          Convert.ToString(tblventa.Rows(i - 1).Cells(7).Value))
                    Next
                Catch ex As Exception
                    MsgBox("Actualizar_Producto duplicado")
                End Try
            End If
        Else
            MsgBox("Completa los campos")
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
        Cancelar_Venta.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub npdprecio_ValueChanged(sender As Object, e As EventArgs) Handles npdprecio.ValueChanged

    End Sub


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txbFiltro.TextChanged
        mtdv.llenarComboProductofiltro(tblProductos, cmbBodega.Text, txbFiltro.Text)
    End Sub



    Private Sub lblTotal_TextChanged(sender As Object, e As EventArgs) Handles lblTotal.TextChanged
        If cmbFormaPago.Text = "Contado" Then
            npdCantidadPagada.Value = Convert.ToDecimal(lblTotal.Text)

            tblventa.Rows(tblventa.RowCount - 1).Cells(4).Value = npdCantidadPagada.Value

        End If

    End Sub



    Private Sub tblProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblProductos.CellClick
        npdprecio.Value = Convert.ToDecimal(Convert.ToString(tblProductos.CurrentRow.Cells(1).Value))

    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim clave As String = tblDetalleVenta.CurrentRow.Cells(0).Value
        If tblDetalleVenta.CurrentRow.Cells("estatus").Value = "E" Then
            For i = 1 To tblDetalleVenta.RowCount
                If clave = tblDetalleVenta.Rows(i - 1).Cells(0).Value Then
                    mtdv.updateExistencia(tblDetalleVenta.Rows(i - 1).Cells(2).Value, tblDetalleVenta.Rows(i - 1).Cells(3).Value, tblDetalleVenta.Rows(i - 1).Cells(4).Value, tblDetalleVenta.CurrentRow.Cells(0).Value)
                End If
            Next
        ElseIf tblDetalleVenta.CurrentRow.Cells("Estatus").Value = "D" Then
            MsgBox("Debe saldar la cuenta")
        Else
            MsgBox("La venta esta saldada")
        End If
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub tblDetalleVenta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblDetalleVenta.CellContentClick

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If tblventa.RowCount > 0 And txtNombreCliente.Text <> String.Empty Then
            tblventa.Rows.Remove(tblventa.CurrentRow)
            Dim i As Integer
            Dim total As Double
            For i = 1 To tblventa.RowCount
                total += Convert.ToDecimal(Convert.ToString(tblventa.Rows(i - 1).Cells(3).Value))
                t = total
            Next

            lblTotal.Text = Convert.ToString(total)

        Else

            lblTotal.Text = Convert.ToString(0)

        End If

    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim bc As New BuscaCliente
        AddOwnedForm(bc)
        bc.ShowDialog()
    End Sub
End Class