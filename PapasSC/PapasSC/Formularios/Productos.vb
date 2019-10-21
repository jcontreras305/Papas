Public Class Productos
    Dim mtdv As New MetodosVenta
    Public bodega As String
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtdv.llenarComboProducto(tblProductos, bodega)
    End Sub
End Class