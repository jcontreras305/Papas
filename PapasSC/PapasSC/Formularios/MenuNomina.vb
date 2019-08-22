Public Class MenuNominas
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ConsultaEmpleados_Click(sender As Object, e As EventArgs) Handles ConsultaEmpleados.Click
        ConsultarEmpleado.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AgregarEmpleados.Show()
    End Sub
End Class