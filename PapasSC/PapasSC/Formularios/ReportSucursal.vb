Public Class ReportSucursal
    Public nomSu As String

    Private Sub ReportSucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim objreport As New ReporteSucursal
        objreport.SetParameterValue("@nombreSucursal", nomSu)

        CrystalReportViewer1.ReportSource = objreport


    End Sub
End Class