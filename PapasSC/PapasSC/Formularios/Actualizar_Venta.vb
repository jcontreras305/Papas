Public Class Actualizar_Venta

    Public id As String
    Dim mtdv As New MetodosVenta
    Private Sub cbxBodega_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbFormaPago_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbxEspera_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbProducto_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Actualizar_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        npdkilos.Maximum = 99999999
        npdprecio.Maximum = 9999999
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
        Dim cliente As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(13).Value) '

        cmbBodega.Text = bodega
        txtproducto.Text = version
        txtNombreCliente.Text = cliente
        npdkilos.Value = Convert.ToDecimal(kilos)
        npdprecio.Value = Convert.ToDecimal(precio)
        cmbFormaPago.Text = formapago
        npdCantidadPagada.Value = Convert.ToDecimal(cantidadpagada)

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
        Dim cliente As String = Convert.ToString(tblventaActualizar.CurrentRow.Cells(13).Value) '

        cmbBodega.Text = bodega
        txtproducto.Text = version
        txtNombreCliente.Text = cliente
        npdkilos.Value = Convert.ToDecimal(kilos)
        npdprecio.Value = Convert.ToDecimal(precio)
        cmbFormaPago.Text = formapago
        npdCantidadPagada.Value = Convert.ToDecimal(cantidadpagada)



    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim bc As New BuscaCliente
        AddOwnedForm(bc)
        bc.ShowDialog()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btnProducto.Click
        Dim bc As New Productos
        bc.bodega = cmbBodega.Text
        AddOwnedForm(bc)
        bc.ShowDialog()
    End Sub
End Class