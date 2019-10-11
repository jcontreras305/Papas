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
        mtdv.llenarDatagridview_filtroIdVenta(tblventaActualizar, id)
    End Sub
End Class