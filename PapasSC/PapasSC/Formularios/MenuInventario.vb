Public Class MenuInventario
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Invertario.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ExistenciaBodega.Show()
    End Sub

    Private Sub btnTranspasos_Click(sender As Object, e As EventArgs) Handles btnTranspasos.Click
        Reubicacion.Show()
        Reubicacion.lblNombreUsuario.Text = PapasSC.Form2.NombreUsuario.Text
        Reubicacion.usuario = PapasSC.Form2.login
    End Sub
End Class