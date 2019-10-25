Public Class IniciarCaja
    Dim listIdsEmpleados, listIdsCajas, listEstatusCaja, listCajasExplicito As New List(Of String)
    Dim mtdCaja As New MetodosCaja
    Dim mtdLogeo As New LogeoMetodos
    Public vn As Boolean = False
    Public user As String
    Private Sub IniciarCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim mtdCaja As New MetodosCaja
            Dim mtdEmpleados As New MetodosEmpleado
            mtdCaja.cajasEstatus(cmbCajas, listIdsCajas, listEstatusCaja, listCajasExplicito)
            If listIdsCajas.Count = 0 Then
                If MessageBox.Show("No se cuenta con cajas registradas o en servicio" + vbCrLf + "¿Desea agregar uno?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    AgregarEditarCaja.Text = "Agregar"
                    AgregarEditarCaja.ShowDialog()
                    mtdCaja.cajasEstatus(cmbCajas, listIdsCajas, listEstatusCaja, listCajasExplicito)
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

    Private Sub btnLiberar_Click(sender As Object, e As EventArgs) Handles btnLiberar.Click
        Try
            mtdCaja.cerrar_Caja(listIdsCajas(cmbCajas.FindString(cmbCajas.Text)))
            mtdCaja.cajasEstatus(cmbCajas, listIdsCajas, listEstatusCaja, listCajasExplicito)
            mtdCaja.TotalEfectivoCajaDeducido(listIdsCajas(cmbCajas.FindString(cmbCajas.Text)))

        Catch ex As Exception

        End Try
    End Sub

    Private Function cortecajaIniciar() As Boolean
        If MessageBox.Show("¿Dessea iniciar caja?", "Apertura y Cierre de Caja", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If listCajasExplicito(cmbCajas.FindString(cmbCajas.Text)).Equals("A") Then ' DE FORMA EXPLICITA
                Dim cme As New CantidadMonetariaExplicitaInicio
                Me.AddOwnedForm(cme)
                cme.ShowDialog()
                mtdCaja.iniciar_Caja_Explicito(listIdsCajas(cmbCajas.FindString(cmbCajas.Text)), listIdsEmpleados(cmbEmpleados.FindString(cmbEmpleados.Text)), CStr(cme.DineroTotal), cme.arrayMonedas)
                mtdCaja.cajasEstatus(cmbCajas, listIdsCajas, listEstatusCaja, listCajasExplicito)
                coloresCombo()
                Return True
            Else ' DE FORMA NORMAL
                Dim montoInicial As Double = 0.0
                Do
                    montoInicial = CDbl(InputBox("Ingresa la cantidad Inicial. " + vbCrLf + "Solo numeros por favor."))
                Loop While (montoInicial - montoInicial) <> 0 And Not montoInicial > 0
                mtdCaja.iniciar_Caja(listIdsCajas(cmbCajas.FindString(cmbCajas.Text)), listIdsEmpleados(cmbEmpleados.FindString(cmbEmpleados.Text)), montoInicial)
                coloresCombo()
                mtdCaja.cajasEstatus(cmbCajas, listIdsCajas, listEstatusCaja, listCajasExplicito)
                Return True
            End If
        ElseIf Windows.Forms.DialogResult.No Then
            Return False
        ElseIf Windows.Forms.DialogResult.Cancel Then
            Return False
        End If
    End Function


    Private Sub btnAbrirCaja_Click(sender As Object, e As EventArgs) Handles btnAbrirCaja.Click
        If listEstatusCaja(cmbCajas.FindString(cmbCajas.Text)).Equals("Cerrada") Then ' LA CAJA ESTA CERRADA
            If mtdLogeo.validarUsuarioCaja(cmbEmpleados.Text, txtContraseña.Text) Then ' COMPARO LA CAJA Y EL USARIO
                If vn Then ' venta: si vn = true entonces inicio el form desde el boton de venta
                    cortecajaIniciar()
                    Dim nv As New NuevaVenta
                    Me.AddOwnedForm(nv)
                    nv.idEmpleado = listIdsEmpleados(cmbEmpleados.FindString(cmbEmpleados.Text))
                    Me.Visible = False
                    nv.ShowDialog()
                    Me.Visible = True
                Else ' caja: si vn es falso se inicia el from desde el boton de caja
                    Dim caja As New Caja
                    Me.AddOwnedForm(caja)
                    If cortecajaIniciar() Then
                        caja.pnlEstatus.BackColor = Color.Green
                    Else
                        caja.pnlEstatus.BackColor = Color.Orange
                    End If
                    caja.txtCaja.Text = cmbCajas.Text
                    caja.txtEmpleado.Text = cmbEmpleados.Text
                    Me.Visible = False
                    caja.ShowDialog()
                    Me.Visible = True
                End If
            Else
                MsgBox("Es necesario ingresar un usuario y contraseña correcto" + vbCrLf + "intenta de nuevo, la credenciales no son correctas.")
            End If
        Else ' LA CAJA ESTA ABIERTA O EN USO 
            If mtdCaja.validarUsuarioCorteCaja(listIdsEmpleados(cmbEmpleados.FindString(cmbEmpleados.Text)).ToString, listIdsCajas(cmbCajas.FindString(cmbCajas.Text)).ToString) Then
                If vn Then ' venta: si vn = true entonces inicio el form desde el boton de venta
                    Dim vt As New NuevaVenta
                    Me.AddOwnedForm(vt)
                    vt.idEmpleado = listCajasExplicito(cmbEmpleados.FindString(cmbEmpleados.Text))
                    Me.Visible = False
                    vt.ShowDialog()
                    Me.Visible = True
                Else ' caja: si vn es falso se inicia el from desde el boton de caja
                    Dim Caja As New Caja
                    Me.AddOwnedForm(Caja)
                    Caja.pnlEstatus.BackColor = Color.Green
                    Caja.txtCaja.Text = cmbCajas.Text
                    Caja.txtEmpleado.Text = cmbEmpleados.Text
                    Me.Visible = False
                    Caja.ShowDialog()
                    Me.Visible = True
                End If
            Else
                MsgBox("La Caja " + cmbCajas.Text + " esta en uso solo el usuario que la abrio puede liberarla.") ' EL USUARIO QUE INTENTO ACCEDER NO ES QUIEN LA ABRIO
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Function coloresCombo() As Boolean
        If listEstatusCaja(cmbCajas.FindString(cmbCajas.Text)).Equals("Abierta") Then
            cmbCajas.BackColor = Color.Green
            cmbCajas.ForeColor = Color.White
        Else
            cmbCajas.BackColor = Color.Orange
            cmbCajas.ForeColor = Color.Black
        End If
        Return True
    End Function
End Class