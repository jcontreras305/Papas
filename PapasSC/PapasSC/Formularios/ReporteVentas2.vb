Public Class ReporteVentas2
    Public nomCaja As String

    Private Sub ReporteVentas2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreport As New ReporteVenta
        objreport.SetParameterValue("@NombreCaja", nomCaja)

        CrystalReportViewer1.ReportSource = objreport
    End Sub
End Class