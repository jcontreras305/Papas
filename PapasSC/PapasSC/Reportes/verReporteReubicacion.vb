Public Class verReporteReubicacion
    Public idReubicacion As String

    Private Sub verReporteReubicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim objreport As New ReporteDeReubicaciones
            objreport.SetParameterValue("@idReubicacion", idReubicacion)

            CrystalReportViewer1.ReportSource = objreport
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class