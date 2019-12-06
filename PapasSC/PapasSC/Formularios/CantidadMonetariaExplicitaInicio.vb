Public Class CantidadMonetariaExplicitaInicio
    Dim mtdCaja As New MetodosCaja
    Public idEmpleado, idCaja As String
    Public DineroTotal As Double
    Public formaPago As String
    Public vn As Boolean
    Public arrayMonedas() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Public flag, flagCancelar As Boolean

    Private Sub CantidadMonetariaExplicitaInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            DineroTotal = CDbl(txtTotal.Text)

            flag = True
            btnQuitar.Text = "Agregar"
            txtCambio.ReadOnly = True
            txtTotal.ReadOnly = True
            txtTotalPagar.ReadOnly = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnB1000_Click(sender As Object, e As EventArgs) Handles btnB1000.Click
        agregarQuitar(1000, btnB1000, 0)
        If Convert.ToDecimal(txtTotal.Text) > Convert.ToDecimal(txtTotalPagar.Text) Then
            txtCambio.Text = Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtTotalPagar.Text)
        Else
            txtCambio.Text = 0
        End If
    End Sub

    Private Sub btnB500_Click(sender As Object, e As EventArgs) Handles btnB500.Click
        agregarQuitar(500, btnB500, 1)
        If Convert.ToDecimal(txtTotal.Text) > Convert.ToDecimal(txtTotalPagar.Text) Then
            txtCambio.Text = Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtTotalPagar.Text)
        Else
            txtCambio.Text = 0
        End If
    End Sub

    Private Sub btnB200_Click(sender As Object, e As EventArgs) Handles btnB200.Click
        agregarQuitar(200, btnB200, 2)
        If CDbl(txtTotal.Text) > CDbl(txtTotalPagar.Text) Then
            txtCambio.Text = Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtTotalPagar.Text)
        Else
            txtCambio.Text = 0
        End If
    End Sub

    Private Sub btnB100_Click(sender As Object, e As EventArgs) Handles btnB100.Click
        agregarQuitar(100, btnB100, 3)
        If Convert.ToDecimal(txtTotal.Text) > Convert.ToDecimal(txtTotalPagar.Text) Then
            txtCambio.Text = Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtTotalPagar.Text)
        Else
            txtCambio.Text = 0
        End If
    End Sub

    Private Sub btnB50_Click(sender As Object, e As EventArgs) Handles btnB50.Click
        agregarQuitar(50, btnB50, 4)
        If Convert.ToDecimal(txtTotal.Text) > Convert.ToDecimal(txtTotalPagar.Text) Then
            txtCambio.Text = Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtTotalPagar.Text)
        Else
            txtCambio.Text = 0
        End If
    End Sub

    Private Sub btnB20_Click(sender As Object, e As EventArgs) Handles btnB20.Click
        agregarQuitar(20, btnB20, 5)
        If Convert.ToDecimal(txtTotal.Text) > Convert.ToDecimal(txtTotalPagar.Text) Then
            txtCambio.Text = Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtTotalPagar.Text)
        Else
            txtCambio.Text = 0
        End If
    End Sub

    Private Sub btnM20_Click(sender As Object, e As EventArgs) Handles btnM20.Click
        agregarQuitar(20, btnM20, 6)
        If Convert.ToDecimal(txtTotal.Text) > Convert.ToDecimal(txtTotalPagar.Text) Then
            txtCambio.Text = Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtTotalPagar.Text)
        Else
            txtCambio.Text = 0
        End If
    End Sub

    Private Sub btnM10_Click(sender As Object, e As EventArgs) Handles btnM10.Click
        agregarQuitar(10, btnM10, 7)
        If Convert.ToDecimal(txtTotal.Text) > Convert.ToDecimal(txtTotalPagar.Text) Then
            txtCambio.Text = Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtTotalPagar.Text)
        Else
            txtCambio.Text = 0
        End If
    End Sub

    Private Sub btnM5_Click(sender As Object, e As EventArgs) Handles btnM5.Click
        agregarQuitar(5, btnM5, 8)
        If Convert.ToDecimal(txtTotal.Text) > Convert.ToDecimal(txtTotalPagar.Text) Then
            txtCambio.Text = Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtTotalPagar.Text)
        Else
            txtCambio.Text = 0
        End If
    End Sub

    Private Sub btnM2_Click(sender As Object, e As EventArgs) Handles btnM2.Click
        agregarQuitar(2, btnM2, 9)
        If Convert.ToDecimal(txtTotal.Text) > Convert.ToDecimal(txtTotalPagar.Text) Then
            txtCambio.Text = Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtTotalPagar.Text)
        Else
            txtCambio.Text = 0
        End If
    End Sub

    Private Sub btnM1_Click(sender As Object, e As EventArgs) Handles btnM1.Click
        agregarQuitar(1, btnM1, 10)
        If Convert.ToDecimal(txtTotal.Text) > Convert.ToDecimal(txtTotalPagar.Text) Then
            txtCambio.Text = Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtTotalPagar.Text)
        Else
            txtCambio.Text = 0
        End If
    End Sub

    Private Sub btnM05_Click(sender As Object, e As EventArgs) Handles btnM05.Click
        agregarQuitar(0.5, btnM05, 11)
        If Convert.ToDecimal(txtTotal.Text) > Convert.ToDecimal(txtTotalPagar.Text) Then
            txtCambio.Text = Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtTotalPagar.Text)
        Else
            txtCambio.Text = 0
        End If
    End Sub

    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Try
            If flag Then
                flag = False
                btnQuitar.Text = "Quitar"
                btnQuitar.Image = PapasSC.My.Resources.SALIR
            Else
                flag = True
                btnQuitar.Text = "Agregar"
                btnQuitar.Image = PapasSC.My.Resources.agregar
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function agregarQuitar(cantidad As Double, ByVal boton As Button, ByVal posicion As Int16) As Boolean
        If flag = True Then
            Dim cont As Int16 = CInt(boton.Text)
            cont += 1
            boton.Text = cont
            DineroTotal = DineroTotal + CDbl(cantidad)
            txtTotal.Text = DineroTotal.ToString("N")
            arrayMonedas(posicion) = cont
            Return True
        Else
            Dim cont As Int16 = CInt(boton.Text)
            If cont > 0 Then
                cont -= 1
                boton.Text = cont
                DineroTotal = DineroTotal - CDbl(cantidad)
                txtTotal.Text = DineroTotal.ToString("N")
                arrayMonedas(posicion) = cont
            End If
            Return True
        End If
    End Function

    Private Function btnDineros_KeyUp(sender As Object, e As KeyPressEventArgs) Handles btnB1000.KeyPress, btnB500.KeyPress, btnB200.KeyPress, btnB100.KeyPress, btnB50.KeyPress, btnB20.KeyPress, btnM20.KeyPress, btnM10.KeyPress, btnM5.KeyPress, btnM2.KeyPress, btnM1.KeyPress, btnM05.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If IsNumeric(e.KeyChar) Then
            If sender Is btnB1000 Then
                btnB1000.Text = e.KeyChar.ToString()

            ElseIf sender Is btnB500 Then
                btnB500.Text = e.KeyChar.ToString()

            ElseIf sender Is btnB200 Then
                btnB200.Text = e.KeyChar.ToString()

            ElseIf sender Is btnB100 Then
                btnB100.Text = e.KeyChar.ToString()

            ElseIf sender Is btnB50 Then
                btnB50.Text = e.KeyChar.ToString()

            ElseIf sender Is btnB20 Then
                btnB20.Text = e.KeyChar.ToString()

            ElseIf sender Is btnM20 Then
                btnM20.Text = e.KeyChar.ToString()

            ElseIf sender Is btnM10 Then
                btnM10.Text = e.KeyChar.ToString()

            ElseIf sender Is btnM5 Then
                btnM5.Text = e.KeyChar.ToString()

            ElseIf sender Is btnM2 Then
                btnM2.Text = e.KeyChar.ToString()

            ElseIf sender Is btnM1 Then
                btnM1.Text = e.KeyChar.ToString()

            ElseIf sender Is btnM05 Then
                btnM05.Text = e.KeyChar.ToString()

            End If

        End If
        If Convert.ToDecimal(txtTotal.Text) > Convert.ToDecimal(txtTotalPagar.Text) Then
            txtCambio.Text = Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtTotalPagar.Text)
        Else
            txtCambio.Text = 0
        End If
        calcular()
    End Function

    Private Function calcular() As Boolean
        Dim arraybotones As Object = {btnB1000, btnB500, btnB200, btnB100, btnB50, btnB20, btnM20, btnM10, btnM5, btnM2, btnM1, btnM05}
        Dim arrayValores() As Double = {1000, 500, 200, 100, 50, 20, 20, 10, 5, 2, 1, 0.5}
        Dim cont As Int16 = 0
        Dim total As Double = 0
        For Each btn As Button In arraybotones
            Dim cant As Int16 = CInt(btn.Text)
            Dim mul = arrayValores(cont)
            total = total + CDbl((mul * cant))
            cont += 1
        Next
        DineroTotal = total
        txtTotal.Text = DineroTotal.ToString("N")
        Return Nothing
    End Function

    Private Sub btns_KeyUp(sender As Object, e As KeyPressEventArgs) Handles btnM5.KeyPress, btnM20.KeyPress, btnM2.KeyPress, btnM10.KeyPress, btnM1.KeyPress, btnM05.KeyPress, btnB500.KeyPress, btnB50.KeyPress, btnB200.KeyPress, btnB20.KeyPress, btnB1000.KeyPress, btnB100.KeyPress

    End Sub

    Private Sub txtCambio_TextChanged(sender As Object, e As EventArgs) Handles txtCambio.TextChanged
        'txtCambio.Text.ToString("N")
        'txtCambio.Text = Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtTotalPagar.Text)
    End Sub

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        If vn Then
            'esto es cuando esta en ventas
            Dim nv As NuevaVenta = CType(Owner, NuevaVenta)
            If formaPago.Equals("Contado") And CDbl(txtTotal.Text) >= CDbl(txtTotalPagar.Text) Then
                nv.cancelaventa = False
                Me.Close()
            ElseIf formaPago.Equals("Credito") Then
                nv.cantidadPagadaCredito = CDbl(txtTotal.Text.ToString())
                nv.cancelaventa = False
                Me.Close()
            Else
                MsgBox("Debe ser mayor o igual el monto a pagar")
            End If

        Else 'aqui es para iniciar caja desda boton de venta y caja
            If Not DineroTotal > 0.0 Then
                MessageBox.Show("Debes introducir dinero para iniciar la caja.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.None)
            Else
                If mtdCaja.iniciar_Caja_Explicito(idCaja, idEmpleado, CStr(DineroTotal), arrayMonedas) Then
                    Dim ic As IniciarCaja = CType(Owner, IniciarCaja)
                    ic.flagCanelar = True
                Else
                    Dim ic As IniciarCaja = CType(Owner, IniciarCaja)
                    ic.flagCanelar = False
                End If
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnCanelar_Click(sender As Object, e As EventArgs) Handles btnCanelar.Click
        If MessageBox.Show("Si desea continuar no se guardaran los cambios.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
            If vn Then
                Dim nv As NuevaVenta = CType(Owner, NuevaVenta)
                nv.explicita = False
                nv.cancelaventa = True
            Else
                Dim ic As IniciarCaja = CType(Owner, IniciarCaja)
                ic.flagCanelar = False
            End If
        End If
        Me.Close()
    End Sub

End Class