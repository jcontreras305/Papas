Public Class NuevaVenta
    Public user As String
    Dim savef As String
    Dim flag As Boolean = False
    Dim mtdv As New MetodosVenta
    Private Sub NuevaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        npdCantidadPagada.Increment = 0.01
        npdCantidadPagada.DecimalPlaces = 2
        npdCantidadPagada.ThousandsSeparator = True
        npdkilos.Increment = 0.01
        npdkilos.DecimalPlaces = 2
        npdkilos.ThousandsSeparator = True
        npdprecio.Increment = 0.01
        npdprecio.DecimalPlaces = 2
        npdprecio.ThousandsSeparator = True
        mtdv.llenarComboBodega(cmbBodega)
        mtdv.llenarComboProducto(cmbProducto, cmbBodega.Text)
        mtdv.llenarComboCliente(cmbCliente)
        savef = DateTime.Now.ToString("dd/MM/yyyy")
        flag = True
        npdkilos.Value = 1.0
        cmbBodega.Text = "Selecciona"
        cmbProducto.Text = "Selecciona"
        cmbCliente.Text = "Selecciona"
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCliente.SelectedIndexChanged

    End Sub

    Private Sub cbxRealizaventa_CheckedChanged(sender As Object, e As EventArgs) Handles cbxRealizaventa.CheckedChanged
        If cbxRealizaventa.Checked Then
            cmbCliente.Enabled = False
        Else
            cmbCliente.Enabled = True
        End If
    End Sub

    Private Sub cmbFormaPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFormaPago.SelectedIndexChanged
        If cmbFormaPago.SelectedIndex = 0 Then
            npdCantidadPagada.Enabled = True
        Else
            npdCantidadPagada.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cbxRealizaventa.Checked Then
            cmbCliente.Enabled = False
            tblventa.Columns.Add("Cliente", "Cliente")
            tblventa.Columns.Add("Kilogramos", "Kilogramos")
            tblventa.Columns.Add("Precio", "Precio")
            tblventa.Columns.Add("Pago", "Pago")
            tblventa.Columns.Add("Empleado", "Empleado")
            tblventa.Columns.Add("Tipo de pago", "Tipo de pago")
            tblventa.Columns.Add("Descuento", "Descuento")
            tblventa.Rows.Add("Cliente en General", npdkilos.Value, (npdprecio.Value * npdkilos.Value), npdCantidadPagada.Value, user, cmbFormaPago.Text)
            Dim i As Integer
            Dim total As Integer
            For i = 0 To tblventa.RowCount
                total += Convert.ToDecimal(tblventa.Rows(i - 1).Cells(0).Value)

            Next
            lblTotal.Text = lblTotal.Text + " " + total

        Else
            cmbCliente.Enabled = True
            tblventa.Columns.Add("Cliente", "Cliente")
            tblventa.Columns.Add("Kilogramos", "Kilogramos")
            tblventa.Columns.Add("Precio", "Precio")
            tblventa.Columns.Add("Pago", "Pago")
            tblventa.Columns.Add("Empleado", "Empleado")
            tblventa.Columns.Add("Tipo de pago", "Tipo de pago")
            tblventa.Columns.Add("Descuento", "Descuento")
            tblventa.Rows.Add(cmbCliente.Text, npdkilos.Value, (npdprecio.Value * npdkilos.Value), npdCantidadPagada.Value, user, cmbFormaPago.Text)
            Dim i As Integer
            Dim total As Integer
            For i = 0 To tblventa.RowCount
                total += Convert.ToDecimal(tblventa.Rows(i - 1).Cells(0).Value)
            Next
            lblTotal.Text = lblTotal.Text + " " + total
        End If

    End Sub

    Private Sub cmbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProducto.SelectedIndexChanged
        If flag Then
            npdprecio.Value = Convert.ToDouble(mtdv.PrecioProductos(cmbProducto.Text))
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class