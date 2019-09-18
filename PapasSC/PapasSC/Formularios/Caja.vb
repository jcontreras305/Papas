Public Class Caja
    Private Sub txtFechainicial_MouseClick(sender As Object, e As MouseEventArgs) Handles txtFechainicial.MouseClick
        txtFechainicial.Visible = False
        txtFechaFinal.Visible = False
        cldFechaInicial.Visible = True
    End Sub

    Private Sub cldFechaInicial_DateSelected(sender As Object, e As DateRangeEventArgs) Handles cldFechaInicial.DateSelected
        txtFechainicial.Text = cldFechaInicial.SelectionEnd.Date
        cldFechaInicial.Visible = False
        txtFechainicial.Visible = True
        txtFechaFinal.Visible = True
    End Sub

    Private Sub txtFechaFinal_MouseClick(sender As Object, e As MouseEventArgs) Handles txtFechaFinal.MouseClick
        txtFechaFinal.Visible = False
        cldFechaFinal.Visible = True
    End Sub

    Private Sub cldFechaFinal_DateSelected(sender As Object, e As DateRangeEventArgs) Handles cldFechaFinal.DateSelected
        txtFechaFinal.Text = cldFechaFinal.SelectionEnd.Date
        cldFechaFinal.Visible = False
        txtFechaFinal.Visible = True
    End Sub


End Class