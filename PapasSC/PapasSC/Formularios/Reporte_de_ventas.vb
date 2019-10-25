Public Class Reporte_de_ventas

    Dim caj As New MetodoReportesVentas
    Private Sub Reporte_de_ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            caj.caja(cboCaja)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub txtGenerar_Click(sender As Object, e As EventArgs) Handles txtGenerar.Click
        Dim emple As String = (cboCaja.Text)

        Dim reporteemple As New ReporteVentas2

        reporteemple.nomCaja = emple

        reporteemple.ShowDialog()


    End Sub
End Class