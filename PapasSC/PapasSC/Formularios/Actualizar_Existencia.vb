Public Class Actualizar_Existencia
    Dim mtbo As New MetodoExistenciaProducto
    Public claveb As String
    Public clavep As String
    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click

        mtbo.updatebodega(cmbBodega.Text, cmbProducto.Text, npd.Value, claveb, clavep)

    End Sub

    Private Sub cmbBodega_Enter(sender As Object, e As EventArgs) Handles cmbBodega.Enter

        mtbo.llenarComboBodega(cmbBodega)
    End Sub

    Private Sub cmbProducto_Enter(sender As Object, e As EventArgs) Handles cmbProducto.Enter
        mtbo.llenarComboProducto(cmbProducto)
    End Sub
End Class