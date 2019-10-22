

Public Class GenerarNomina

    Dim nomina As New MetodoNomina

    Private Sub GenerarNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            nomina.selecccionaRPago(cboFormaPago)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Close()
    End Sub

    Private Sub validarLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub validarNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub



    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        validarLetras(e)
        txtNombre.MaxLength = 80
    End Sub


    Private Sub txtPercepciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPercepciones.KeyPress
        validarNumeros(e)
        txtPercepciones.MaxLength = 5
    End Sub



    Private Sub txtDeduciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDeduciones.KeyPress
        validarNumeros(e)
        txtDeduciones.MaxLength = 5
    End Sub



    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotal.KeyPress
        validarNumeros(e)
        txtTotal.MaxLength = 6
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim datosNomina As New List(Of String)
        Dim fechaPago As Date
        Dim fechaIni As Date
        Dim fechaFin As Date
        txtTotal.ReadOnly = True
        txtDeduciones.ReadOnly = True
        txtDeduciones.ReadOnly = True

        Try
            fechaPago = dtpFechaPago.Value
            datosNomina.Add(nudDias.Value)
            datosNomina.Add(txtSalarioDiario.Text)
            datosNomina.Add(cboFormaPago.Text)
            datosNomina.Add(txtNombre.Text)
            datosNomina.Add(nudFaltas.Value)
            fechaIni = dtpFeInicio.Value
            fechaFin = dtpFeFin.Value
            nomina.InsertarNomina(fechaPago, datosNomina, fechaIni, fechaFin, txtDeduciones, txtPercepciones, txtTotal)
        Catch ex As Exception

        End Try

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EmpleadosNomina.Show()
    End Sub
End Class