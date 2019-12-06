Public Class AbonosCliente
    Public idCliente As String
    Private Sub AbonosCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim objreport As New ReporteHistorialAbonos
            objreport.SetParameterValue("@idCliente", idCliente)
            CrystalReportViewer1.ReportSource = objreport
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class