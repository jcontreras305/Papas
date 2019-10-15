

Public Class GenerarNomina

    Dim nomina As New MetodoNomina

    Private Sub GenerarNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datosNomina As New List(Of String)

        Try
            datosNomina.Add(dtpFechaPago.Value)
            datosNomina.Add(txtTotal.Text)
            datosNomina.Add(nudDias.Value)
            datosNomina.Add(nudHoras.Value)
            datosNomina.Add(cboFormaPago.SelectedItem)
            datosNomina.Add(txtNombre.Text)
            datosNomina.Add(txtPercepciones.Text)
            datosNomina.Add(txtDeduciones.Text)
            datosNomina.Add(dtpFeInicio.Value)
            datosNomina.Add(dtpFeFin.Value)
            datosNomina.Add(nudFaltas.Value)
        Catch ex As Exception

        End Try

        nomina.InsertarNomina(datosNomina)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Close()
    End Sub
End Class