Public Class ReporteCliente
    Public nomCli As String

    Private Sub ReporteCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreportCli As New ReportCliente
        objreportCli.SetParameterValue("@nombreCliente", nomCli)


        CrystalReportViewer1.ReportSource = objreportCli
    End Sub
End Class