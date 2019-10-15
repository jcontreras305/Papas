Public Class IniciarCaja
    Dim listIdsEmpleados, listIdsCajas, listEstatusCaja As New List(Of String)
    Dim mtdCaja As New MetodosCaja
    Dim mtdLogeo As New LogeoMetodos
    Public vn As Boolean = False
    Public user As String
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
                If MessageBox.Show("No se cuenta con empleados registrados o que esten Activos" + vbCrLf + "¿Desea agregar uno?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
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
        If listEstatusCaja(cmbCajas.FindString(cmbCajas.Text)).Equals("Abierta") Then
            cmbCajas.BackColor = Color.Green
            cmbCajas.ForeColor = Color.White
        Else
            cmbCajas.BackColor = Color.Orange
            cmbCajas.ForeColor = Color.Black
        End If
    End Sub

    Private Sub chbVer_CheckedChanged(sender As Object, e As EventArgs) Handles chbVer.CheckedChanged
        If chbVer.Checked = True Then
            txtContraseña.UseSystemPasswordChar = False
        Else
            txtContraseña.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnAbrirCaja_Click(sender As Object, e As EventArgs) Handles btnAbrirCaja.Click

        If mtdLogeo.validarUsuarioCaja(cmbEmpleados.Text, txtContraseña.Text) Then
            Dim caja As New Caja
            If cmbCajas.BackColor = Color.Green Then
                If MessageBox.Show("¿Dessea Realizar el corte de Caja?", "Apertura y Cierre de Caja", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    'REALIZAR CORTE DE CAJA 
                    caja.pnlEstatus.BackColor = Color.Orange
                    caja.txtCaja.Text = cmbCajas.Text
                    caja.txtEmpleado.Text = cmbEmpleados.Text
                    mtdCaja.cerrar_Caja(listIdsCajas(cmbCajas.FindString(cmbCajas.Text)))
                    mtdCaja.cajasEstatus(cmbCajas, listIdsCajas, listEstatusCaja)
                    caja.ShowDialog()
                ElseIf Windows.Forms.DialogResult.No Then
                    'SEGUIR SIN HACER CORTE
                    caja.pnlEstatus.BackColor = Color.Green
                    caja.txtCaja.Text = cmbCajas.Text
                    caja.txtEmpleado.Text = cmbEmpleados.Text
                    caja.ShowDialog()
                End If
            Else
                If MessageBox.Show("¿Dessea Iniciar la Caja " + cmbCajas.Text + "?", "Apertura y Cierre de Caja ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    'INICIAR LA CAJA
                    Dim idCaja As String = listIdsCajas(cmbCajas.FindString(cmbCajas.Text))
                    Dim idEmpleado As String = listIdsEmpleados(cmbEmpleados.FindString(cmbEmpleados.Text))
                    Dim dinero As Double = CDbl(InputBox("Ingresa la cantidad Inicial " + vbCrLf + "Solo numeros por favor"))
                    If mtdCaja.iniciar_Caja(idCaja, idEmpleado, dinero.ToString) Then
                        mtdCaja.cajasEstatus(cmbCajas, listIdsCajas, listEstatusCaja)
                        caja.pnlEstatus.BackColor = Color.Green
                        caja.txtCaja.Text = cmbCajas.Text
                        caja.txtEmpleado.Text = cmbEmpleados.Text
                        caja.ShowDialog()

                        If vn Then
                            NuevaVenta.user = user
                            NuevaVenta.idCaja = idCaja
                            NuevaVenta.Show()
                        Else
                            caja.pnlEstatus.BackColor = Color.Green
                            caja.txtCaja.Text = cmbCajas.Text
                            caja.txtEmpleado.Text = cmbEmpleados.Text
                            caja.ShowDialog()
                        End If
                    End If
                Else
                    'SEGUIR CON LA CAJA CERRADA
                    caja.pnlEstatus.BackColor = Color.Orange
                    caja.txtCaja.Text = cmbCajas.Text
                    caja.txtEmpleado.Text = cmbEmpleados.Text
                    caja.ShowDialog()
                End If
            End If
        Else
            MsgBox("Es necesario ingresar un usuario y contraseña correcto" + vbCrLf + "intenta de nuevo, la credenciales no son correctas.")
        End If



    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class