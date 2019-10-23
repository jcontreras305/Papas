Public Class Actualizar_Venta

    Public id As String
    Dim mtdv As New MetodosVenta
    Public Precio, Producto As String
    Public agrega As Boolean = False
    Public user As String
    Public idCliente As String
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

        btnProducto.Enabled = False
        npdkilos.Maximum = 9999999999
        npdprecio.Maximum = 999999999
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

    End Sub

    Private Sub tblventaActualizar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblventaActualizar.CellContentClick

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

    End Sub



    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim bc As New BuscaCliente
        AddOwnedForm(bc)
        bc.ShowDialog()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btnProducto.Click
        If agrega Then

            Dim totalneto As Double = 0

            If txtNombreCliente.Text <> String.Empty Then
                tblProductosNuevos.Rows.Add(txtNombreCliente.Text, txtproducto.Text, npdkilos.Value, (npdprecio.Value * npdkilos.Value), npdCantidadPagada.Value, user, cmbFormaPago.Text, cmbBodega.Text)
            Else
                MsgBox("Seleccione un Cliente")
            End If

            If tblProductosNuevos.RowCount > 1 And txtNombreCliente.Text <> String.Empty Then

                Dim i As Integer
                Dim total As Double

                For i = 1 To tblProductosNuevos.RowCount
                    total += Convert.ToDecimal(Convert.ToString(tblProductosNuevos.Rows(i - 1).Cells(3).Value))
                    totalneto = total
                Next
                t = totalneto
                For i = 1 To tblventaActualizar.RowCount
                    total += Convert.ToDecimal(Convert.ToString(tblventaActualizar.Rows(i - 1).Cells(3).Value))
                    totalneto = total
                Next
                t = t + totalneto

                lbltotal.Text = Convert.ToString(t)


            End If


        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If agrega Then
                For i = 1 To tblventaActualizar.RowCount

                    ' mtdv.updateVentas()

                    mtdv.insertarVentaDetalle(
                                      Convert.ToString(tblventaActualizar.Rows(i - 1).Cells(1).Value),
                                      Convert.ToString(tblventaActualizar.Rows(i - 1).Cells(2).Value),
                                      Convert.ToString(tblventaActualizar.Rows(i - 1).Cells(3).Value),
                                      Convert.ToString(tblventaActualizar.Rows(i - 1).Cells(7).Value)
                                      )
                Next
            Else

            End If

        Catch ex As Exception
            MsgBox("Actualizar_Producto duplicado")
        End Try

    End Sub

    Private Sub cmbBodega_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBodega.SelectedIndexChanged

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

    Private Sub tblventaActualizar_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblventaActualizar.CellDoubleClick

    End Sub
End Class