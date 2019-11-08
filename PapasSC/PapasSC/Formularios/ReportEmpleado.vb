Public Class ReportEmpleado
    Public nomEm As String

    Private Sub ReportEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreport As New ReporteEmpleado
        objreport.SetParameterValue("@NombreEmpleado", nomEm)

        CrystalReportViewer1.ReportSource = objreport
    End Sub
End Class