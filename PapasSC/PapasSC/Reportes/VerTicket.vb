Public Class VerTicket
    Public clave, nombre, idVenta As String

    Private Sub VerTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim objreport As New Ticket
            objreport.SetParameterValue("@clave", clave)
            objreport.SetParameterValue("@nombre", nombre)
            CrystalReportViewer1.ReportSource = objreport
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class