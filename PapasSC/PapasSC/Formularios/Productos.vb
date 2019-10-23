Public Class Productos
    Dim mtdv As New MetodosVenta
    Public bodega As String
    Public version As String
    Public precio As String
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtdv.llenarComboProducto(tblProductos, bodega)
    End Sub

    Private Sub txbFiltro_TextChanged(sender As Object, e As EventArgs) Handles txbFiltro.TextChanged
        mtdv.llenarComboProductofiltro(tblProductos, bodega, txbFiltro.Text)
    End Sub

    Private Sub tblProductos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblProductos.CellDoubleClick
        Try
            Dim nv As Actualizar_Venta = CType(Owner, Actualizar_Venta)
            version = tblProductos.CurrentRow.Cells("Producto").Value.ToString
            precio = tblProductos.CurrentRow.Cells("Precio").Value.ToString
            nv.txtproducto.Text = version
            nv.npdprecio.Value = Convert.ToDecimal(precio)
            nv.agrega = True
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class