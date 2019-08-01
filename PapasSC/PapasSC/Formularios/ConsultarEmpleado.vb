Public Class ConsultarEmpleado

    Public Sub Consul()
        Dim fun As New MetodosEmpleado
        DataListado.DataSource = fun.Consultar
    End Sub

    Private Sub ConsultarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Consul()
    End Sub
End Class