Public Class Horario
    Dim hora As New MetodoHorario

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Close()
    End Sub

    'Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
    '    Dim dataHora(2) As String
    '    Dim horaINi As Date
    '    Dim horafin As Date

    '    Try
    '        dataHora(0) = txtNombreHo.Text
    '        dataHora(1) = rtxDescripcion.Text
    '        horaINi = dtpHoraInicio.Value
    '        horafin = dtpHoraFin.Value

    '    Catch ex As Exception

    '    End Try
    '    hora.insertarHorario(dataHora, horaINi, horafin)
    'End Sub

    Private Sub Horario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombreHo.ReadOnly = True
        rtxDescripcion.ReadOnly = True
        lblEntrada.ReadOnly = True
        lblSalidad.ReadOnly = True

        Try
            hora.seleccionarHora(txtNombreHo, rtxDescripcion, lblEntrada, lblSalidad)

        Catch ex As Exception

        End Try

    End Sub
End Class
