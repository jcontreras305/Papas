Public Class Actualizar_Producto
    Public id As String
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Actualizar_Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MTDPR As New MetodosProducto
        MTDPR.updateProducto(id, txtversion.Text, txtClave.Text, npd.Value)
    End Sub
End Class