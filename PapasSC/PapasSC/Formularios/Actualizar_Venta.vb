Public Class Actualizar_Venta
    Public id As String
    Dim mtdv As New MetodosVenta
    Public Precio, Producto As String
    Public agrega As Boolean = False
    Public user As String
    Public idCliente As String
    Public estatus As String
    Dim tbl As DataGridView
    Dim t As Double = 0

    Private Sub Actualizar_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombreCliente.Enabled = False
        txtproducto.Enabled = False
        If tblProductosNuevos.RowCount < 1 Then
            tblProductosNuevos.Columns.Add("Cliente", "Cliente")
            tblProductosNuevos.Columns.Add("Producto", "Producto")
            tblProductosNuevos.Columns.Add("Kilogramos", "Kilogramos")
            tblProductosNuevos.Columns.Add("Precio", "Precio")
            tblProductosNuevos.Columns.Add("Pago", "Pago")
            tblProductosNuevos.Columns.Add("Empleado", "Empleado")
            tblProductosNuevos.Columns.Add("Tipo de pago", "Tipo de pago")
            tblProductosNuevos.Columns.Add("Bodega", "Bodega")
        End If
        npdCantidadPagada.Maximum = 99999999999999
        btnProducto.Enabled = False
        npdkilos.Maximum = 9999999999
        npdprecio.Maximum = 9999999999
        npdkilos.DecimalPlaces = 2
        npdkilos.ThousandsSeparator = 2
        npdprecio.DecimalPlaces = 2
        npdprecio.ThousandsSeparator = 2
        npdkilos.Increment = 0.5
        npdprecio.Increment = 0.5
        npdCantidadPagada.DecimalPlaces = 2
        npdCantidadPagada.ThousandsSeparator = 2
        npdCantidadPagada.Increment = 0.5
        mtdv.llenarDatagridview_filtroIdVenta(tblventaActualizar, id)
        Dim formapago As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(1).Value)
        Dim bodega As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(2).Value)
        Dim version As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(3).Value)
        Dim kilos As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(4).Value)
        Dim cantidad As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(5).Value)
        Dim precio As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(6).Value)
        Dim cantidadpagada As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(7).Value)
        Dim totalPagar As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(8).Value)
        Dim total As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(9).Value)
        Dim totalneto As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(10).Value)
        Dim Fecha As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(11).Value)
        Dim empleado As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(12).Value)
        Dim cliente As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(13).Value)
        cmbBodega.Text = bodega
        txtproducto.Text = version
        txtNombreCliente.Text = cliente
        npdkilos.Value = Convert.ToDecimal(kilos)
        npdprecio.Value = Convert.ToDecimal(precio)
        cmbFormaPago.Text = formapago
        npdCantidadPagada.Value = Convert.ToDecimal(cantidadpagada)
        lbltotal.Text = totalPagar
        tblventaActualizar.Columns.Item("idventadetalle").Visible = False
        tbl = tblventaActualizar
    End Sub


    Private Sub tblventaActualizar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblventaActualizar.CellClick
        Dim formapago As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(1).Value)
        Dim bodega As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(2).Value)
        Dim version As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(3).Value)
        Dim kilos As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(4).Value)
        Dim cantidad As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(5).Value)
        Dim precio As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(6).Value)
        Dim cantidadpagada As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(7).Value)
        Dim totalPagar As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(8).Value)
        Dim total As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(9).Value)
        Dim totalneto As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(10).Value)
        Dim Fecha As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(11).Value)
        Dim empleado As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(12).Value)
        Dim cliente As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(13).Value)
        cmbBodega.Text = bodega
        txtproducto.Text = version
        txtNombreCliente.Text = cliente
        npdkilos.Value = Convert.ToDecimal(kilos)
        npdprecio.Value = Convert.ToDecimal(precio)
        cmbFormaPago.Text = formapago
        npdCantidadPagada.Value = Convert.ToDecimal(cantidadpagada)
        tblventaActualizar.Columns.Item("idventadetalle").Visible = False
    End Sub



    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) 
        Dim bc As New BuscaCliente
        AddOwnedForm(bc)
        bc.ShowDialog()
    End Sub
    Dim totalneto As Double = 0
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btnProducto.Click
        If agrega Then
            If txtNombreCliente.Text <> String.Empty Then
                tblProductosNuevos.Rows.Add(txtNombreCliente.Text, txtproducto.Text, npdkilos.Value, (npdprecio.Value * npdkilos.Value), npdCantidadPagada.Value, user, cmbFormaPago.Text, cmbBodega.Text)
                lbltotal.Text = (npdprecio.Value * npdkilos.Value) + Convert.ToDecimal(lbltotal.Text)
            Else
                MsgBox("Seleccione un Cliente")
            End If
            If tblProductosNuevos.RowCount > 1 And txtNombreCliente.Text <> String.Empty Then
                Dim i As Integer
                Dim total As Double
                For i = 1 To tblProductosNuevos.RowCount
                    total += Convert.ToDecimal(Convert.ToString(tblProductosNuevos.Rows(i - 1).Cells(3).Value))
                    t = total
                Next
                t = totalneto + Convert.ToDecimal(lbltotal.Text)
                lbltotal.Text = Convert.ToString(t)
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If agrega Then

                For i = 1 To tblventaActualizar.RowCount
                    mtdv.VentaDetalleUpdate(Convert.ToString(tblventaActualizar.Rows(0).Cells(0).Value),
                                            Convert.ToString(tblventaActualizar.Rows(i - 1).Cells("idventadetalle").Value),
                                            Convert.ToString(tblventaActualizar.Rows(i - 1).Cells(3).Value),
                                            Convert.ToString(tblventaActualizar.Rows(i - 1).Cells(4).Value),
                                            Convert.ToString(tblventaActualizar.Rows(i - 1).Cells(10).Value),
                                            Convert.ToString(tblventaActualizar.Rows(i - 1).Cells(2).Value), If(i = 1, True, False), If(tblventaActualizar.Rows(i - 1).Cells(4).Value = tbl.Rows(i - 1).Cells(4).Value, False, True))
                Next
                Dim cade As String = tblventaActualizar.Rows(0).Cells(0).Value
                For i = 1 To tblProductosNuevos.RowCount
                    mtdv.insertarVentaDetalleUpdate(
                                      cade,
                                      Convert.ToString(tblProductosNuevos.Rows(i - 1).Cells(1).Value),
                                      Convert.ToString(tblProductosNuevos.Rows(i - 1).Cells(2).Value),
                                      Convert.ToString(tblProductosNuevos.Rows(i - 1).Cells(3).Value),
                                      Convert.ToString(tblProductosNuevos.Rows(i - 1).Cells(7).Value)
                                      )
                Next
                mtdv.updateVentas(tblventaActualizar.Rows(0).Cells(0).Value.ToString, DateTime.Now.ToString("dd/MM/yyyy"), lbltotal.Text, npdCantidadPagada.Value.ToString, txtNombreCliente.Text, user, cmbBodega.Text, cmbFormaPago.Text)
            Else
                For i = 1 To tblventaActualizar.RowCount
                    mtdv.VentaDetalleUpdate(Convert.ToString(tblventaActualizar.Rows(0).Cells(0).Value),
                                            Convert.ToString(tblventaActualizar.Rows(i - 1).Cells("idventadetalle").Value),
                                            Convert.ToString(tblventaActualizar.Rows(i - 1).Cells(3).Value),
                                            Convert.ToString(tblventaActualizar.Rows(i - 1).Cells(4).Value),
                                            Convert.ToString(tblventaActualizar.Rows(i - 1).Cells(10).Value),
                                            Convert.ToString(tblventaActualizar.Rows(i - 1).Cells(2).Value), If(i = 1, True, False), If(tblventaActualizar.Rows(i - 1).Cells(4).Value = tbl.Rows(i - 1).Cells(4).Value, False, True))
                Next
                mtdv.updateVentas(tblventaActualizar.Rows(0).Cells(0).Value.ToString, DateTime.Now.ToString("dd/MM/yyyy"), lbltotal.Text, npdCantidadPagada.Value.ToString, txtNombreCliente.Text, user, cmbBodega.Text, cmbFormaPago.Text)
            End If
        Catch ex As Exception
            MsgBox("Actualizar_Producto duplicado")
        End Try
    End Sub

    Private Sub cmbBodega_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbBodega.MouseClick
        mtdv.llenarComboBodega(cmbBodega)
    End Sub

    Private Sub btnseleccionP_Click(sender As Object, e As EventArgs) Handles btnseleccionP.Click
        Dim bc As New Productos
        btnProducto.Enabled = True
        bc.bodega = cmbBodega.Text
        AddOwnedForm(bc)
        bc.ShowDialog()
    End Sub

    Private Sub btnQuitarproducto_Click(sender As Object, e As EventArgs) Handles btnQuitarproducto.Click
        If tblventaActualizar.RowCount > 0 And txtNombreCliente.Text <> String.Empty Then
            tblventaActualizar.Rows.Remove(tblventaActualizar.CurrentRow)
            Dim i As Integer
            Dim total As Double
            For i = 1 To tblventaActualizar.RowCount
                total += Convert.ToDecimal(Convert.ToString(tblventaActualizar.Rows(i - 1).Cells(10).Value))
                t = total
            Next
            If tblventaActualizar.RowCount < 1 Then
                lbltotal.Text = "0"
                txtproducto.Text = ""
                npdkilos.Value = 1.0
                npdprecio.Value = 0.00
                cmbFormaPago.SelectedIndex = 1
                npdCantidadPagada.Value = Convert.ToDecimal(0)
            Else
                lbltotal.Text = Convert.ToString(t)
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If tblventaActualizar.RowCount > 0 And txtNombreCliente.Text <> String.Empty Then
            tblProductosNuevos.Rows.Remove(tblProductosNuevos.CurrentRow)
            Dim i As Integer
            Dim total As Double
            For i = 1 To tblventaActualizar.RowCount
                total += Convert.ToDecimal(Convert.ToString(tblventaActualizar.Rows(i - 1).Cells(10).Value))
                t = total
            Next
            Dim total2 As Double
            For i = 1 To tblProductosNuevos.RowCount
                total2 += Convert.ToDecimal(Convert.ToString(tblProductosNuevos.Rows(i - 1).Cells(3).Value))
                t = total + total2
            Next
            If tblventaActualizar.RowCount < 1 Then
                lbltotal.Text = "0"
                txtproducto.Text = ""
                npdkilos.Value = 1.0
                npdprecio.Value = 0.00
                cmbFormaPago.SelectedIndex = 1
                npdCantidadPagada.Value = Convert.ToDecimal(0)
            Else
                lbltotal.Text = Convert.ToString(t)
            End If
        End If

    End Sub

    Private Sub btnRealizarCambios_Click(sender As Object, e As EventArgs) Handles btnRealizarCambios.Click
        Dim total As Double
        For i = 1 To tblventaActualizar.RowCount
            If tblventaActualizar.Rows(i - 1).Cells(3).Value.ToString = txtproducto.Text.ToString Then

                tblventaActualizar.Rows(i - 1).Cells(6).Value = npdprecio.Value
                tblventaActualizar.Rows(i - 1).Cells(4).Value = npdkilos.Value
                tblventaActualizar.Rows(i - 1).Cells(10).Value = Convert.ToDecimal(tblventaActualizar.Rows(i - 1).Cells(4).Value) * Convert.ToDecimal(tblventaActualizar.Rows(i - 1).Cells(6).Value)

            End If
            total += Convert.ToDecimal(Convert.ToString(tblventaActualizar.Rows(i - 1).Cells(10).Value))
            t = total
        Next

        lbltotal.Text = Convert.ToString(total)


    End Sub

    Private Sub cmbFormaPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFormaPago.SelectedIndexChanged
        If cmbFormaPago.SelectedIndex = 1 Then
            npdCantidadPagada.Enabled = False

        Else
            npdCantidadPagada.Enabled = True
        End If
    End Sub

    Private Sub lbltotal_Click(sender As Object, e As EventArgs) Handles lbltotal.Click

    End Sub

    Private Sub lbltotal_TextChanged(sender As Object, e As EventArgs) Handles lbltotal.TextChanged
        If cmbFormaPago.SelectedIndex = 1 Then
            npdCantidadPagada.Value = Convert.ToDecimal(lbltotal.Text)

        Else
            npdCantidadPagada.Enabled = True
        End If
    End Sub

    Private Sub tblventaActualizar_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles tblventaActualizar.CellEnter
        Dim formapago As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(1).Value)
        Dim bodega As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(2).Value)
        Dim version As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(3).Value)
        Dim kilos As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(4).Value)
        Dim cantidad As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(5).Value)
        Dim precio As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(6).Value)
        Dim cantidadpagada As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(7).Value)
        Dim totalPagar As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(8).Value)
        Dim total As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(9).Value)
        Dim totalneto As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(10).Value)
        Dim Fecha As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(11).Value)
        Dim empleado As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(12).Value)
        Dim cliente As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(13).Value)
        cmbBodega.Text = bodega
        txtproducto.Text = version
        txtNombreCliente.Text = cliente
        npdkilos.Value = Convert.ToDecimal(kilos)
        npdprecio.Value = Convert.ToDecimal(precio)
        cmbFormaPago.Text = formapago
        npdCantidadPagada.Value = Convert.ToDecimal(cantidadpagada)
    End Sub


End Class