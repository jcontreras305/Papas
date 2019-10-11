Public Class IniciarCaja
    Dim listIdsEmpleados, listIdsCajas, listEstatusCaja As New List(Of String)
    Dim mtdCaja As New MetodosCaja

    Private Sub IniciarCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim mtdCaja As New MetodosCaja
            Dim mtdEmpleados As New MetodosEmpleado
            mtdCaja.cajasEstatus(cmbCajas, listIdsCajas, listEstatusCaja)
            If listIdsCajas.Count = 0 Then
                If MessageBox.Show("No se cuenta con cajas registradas o en servicio" + vbCrLf + "¿Desea agregar uno?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    AgregarEditarCaja.Text = "Agregar"
                    AgregarEditarCaja.ShowDialog()
                    mtdCaja.cajasEstatus(cmbCajas, listIdsCajas, listEstatusCaja)
                End If
            End If
            cmbCajas.SelectedIndex = 0

            mtdEmpleados.seleccionarNombreEmpleado(cmbEmpleados, listIdsEmpleados)
            If listIdsCajas.Count = 0 Then
                If MessageBox.Show("No se con empleados registrados o Activos" + vbCrLf + "¿Desea agregar uno?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    AgregarEmpleados.ShowDialog()
                    mtdEmpleados.seleccionarNombreEmpleado(cmbCajas, listIdsEmpleados)
                End If
            End If
            cmbEmpleados.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbCajas_TextChanged(sender As Object, e As EventArgs) Handles cmbCajas.TextChanged
        If listEstatusCaja(cmbCajas.FindString(cmbCajas.Text)) = "A" Then
            cmbCajas.BackColor = Color.Green
        End If
    End Sub

    Private Sub btnAbrirCaja_Click(sender As Object, e As EventArgs) Handles btnAbrirCaja.Click


        Dim caja As New Caja


        If cmbCajas.BackColor = Color.Green Then
            If MessageBox.Show("¿Dessea Realizar el corte de Caja?", "Apertura y Cierre de Caja", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                'REALIZAR CORTE DE CAJA 
                caja.pnlEstatus.BackColor = Color.Green
                caja.txtCaja.Text = cmbCajas.Text
                caja.txtEmpleado.Text = cmbEmpleados.Text
                caja.ShowDialog()
            ElseIf Windows.Forms.DialogResult.No Then
                'SEGUIR SIN HACER CORTE

            End If
        Else
            If MessageBox.Show("¿Dessea Iniciar la Caja" + cmbCajas.Text + "?", "Apertura y Cierre de Caja", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                'INICIAR LA CAJA
                Dim idCaja As String = listIdsCajas(cmbCajas.FindString(cmbCajas.Text))
                Dim idEmpleado As String = listIdsEmpleados(cmbEmpleados.FindString(cmbEmpleados.Text))
                Dim dinero As Double = CDbl(InputBox("Ingresa la cantidad Inicial" + vbCrLf + "Solo numeros por favor"))
                If mtdCaja.iniciar_Caja(idCaja, idEmpleado, dinero.ToString) Then
                    caja.pnlEstatus.BackColor = Color.Green
                    caja.txtCaja.Text = cmbCajas.Text
                    caja.txtEmpleado.Text = cmbEmpleados.Text
                    caja.ShowDialog()
                End If
            Else
                'SEGUIR CON LA CAJA CERRADA
                caja.pnlEstatus.BackColor = Color.Orange
                caja.txtCaja.Text = cmbCajas.Text
                caja.txtEmpleado.Text = cmbEmpleados.Text
                caja.ShowDialog()
            End If
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class