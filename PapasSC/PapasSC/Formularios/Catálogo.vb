Public Class Catálogo
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles clientes.Click
        Consulta_Cliente.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles productos.Click
        Consulta_Producto.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles listadeprecios.Click
        Lista_de_Precios.Show()
    End Sub
End Class