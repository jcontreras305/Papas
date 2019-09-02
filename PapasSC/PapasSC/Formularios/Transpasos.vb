Public Class Transpasos
    Dim mdt As New MetodosTranspasos
    Private Sub Transpasos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdt.llenarComboBodega(bodega1)
        mdt.llenarComboBodega(bodega2)
        NumericUpDown1.Increment = 0.01
        NumericUpDown1.DecimalPlaces = 2
        NumericUpDown1.ThousandsSeparator = True

        NumericUpDown3.Increment = 0.01
        NumericUpDown3.DecimalPlaces = 2
        NumericUpDown3.ThousandsSeparator = True
    End Sub

    Private Sub bodega1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bodega1.SelectedIndexChanged
        mdt.llenarDatagridview_filtroBodega(tblpro1, bodega1.Text)
    End Sub

    Private Sub bodega2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bodega2.SelectedIndexChanged
        mdt.llenarDatagridview_filtroBodega(tblpro2, bodega2.Text)
    End Sub

    Private Sub cmbproducto1_Enter(sender As Object, e As EventArgs) Handles cmbproducto1.Enter
        mdt.llenarComboproductos(cmbproducto1, bodega1.Text)
    End Sub

    Private Sub cmbproducto2_Enter(sender As Object, e As EventArgs) Handles cmbproducto2.Enter
        mdt.llenarComboproductos(cmbproducto2, bodega2.Text)
    End Sub
End Class