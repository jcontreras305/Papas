Public Class ReportFechas
    Public feIni As Date
    Public feFin As Date

    Private Sub ReportFechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreport As New ReporteFechas
        objreport.SetParameterValue("@fechaInicial", feIni)
        objreport.SetParameterValue("@fechaFinal", feFin)

        CrystalReportViewer1.ReportSource = objreport

    End Sub
End Class