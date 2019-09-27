Public Class tickets

    Dim mtdMetodosTicket As MetodosTicket

    Private Sub btnPruebaTicket_Click(sender As Object, e As EventArgs) Handles btnPruebaTicket.Click
        VerTicket.Show()
    End Sub

    Private Sub tickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mtdMetodosTicket.verFormatosTickets(tblFormatostTicket)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        AgregarEditarTicket.Show()
    End Sub
End Class