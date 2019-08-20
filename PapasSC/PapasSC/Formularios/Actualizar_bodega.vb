Public Class Actualizar_bodega
    Public id As String
    Private Sub Actualizar_bodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbMatriz_Enter(sender As Object, e As EventArgs) Handles cmbMatriz.Enter
        Dim mtbo As New MetodosBodega
        mtbo.llenarComboMatriz(cmbMatriz)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mtbo As New MetodosBodega
        Try
            mtbo.updatebodega(txtnombre.Text, cmbMatriz.Text, id)
        Catch
        End Try
    End Sub
End Class