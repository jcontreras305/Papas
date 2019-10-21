Public Class Productos
    Dim mtdv As New MetodosVenta
    Public bodega As String
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtdv.llenarComboProducto(tblProductos, bodega)
    End Sub

    Private Sub txbFiltro_TextChanged(sender As Object, e As EventArgs) Handles txbFiltro.TextChanged
        mtdv.llenarComboProductofiltro(tblProductos, bodega, txbFiltro.Text)
    End Sub
End Class