Public Class Montocredito

    Public maximo As String
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim nv As NuevaVenta = CType(Owner, NuevaVenta)

        nv.descuentoC = npdCredito.Value

        Me.Close()
    End Sub

    Private Sub Montocredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        npdCredito.DecimalPlaces = 2
        npdCredito.ThousandsSeparator = True
        npdCredito.Increment = 0.5

    End Sub
End Class