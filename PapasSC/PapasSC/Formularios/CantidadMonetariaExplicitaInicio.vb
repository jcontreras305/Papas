Public Class CantidadMonetariaExplicitaInicio
    Dim mtdCaja As New MetodosCaja
    Public idEmpleado, idCaja As String
    Public DineroTotal As Double
    Public vn As Boolean
    Public arrayMonedas() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Public flag, flagCancelar As Boolean

    Private Sub CantidadMonetariaExplicitaInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DineroTotal = CDbl(txtTotal.Text)
            txtTotal.ReadOnly = True
            flag = True
            btnQuitar.Text = "Agregar"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnB1000_Click(sender As Object, e As EventArgs) Handles btnB1000.Click
        agregarQuitar(1000, btnB1000, 0)
    End Sub

    Private Sub btnB500_Click(sender As Object, e As EventArgs) Handles btnB500.Click
        agregarQuitar(500, btnB500, 1)
    End Sub

    Private Sub btnB200_Click(sender As Object, e As EventArgs) Handles btnB200.Click
        agregarQuitar(200, btnB200, 2)
    End Sub

    Private Sub btnB100_Click(sender As Object, e As EventArgs) Handles btnB100.Click
        agregarQuitar(100, btnB100, 3)
    End Sub

    Private Sub btnB50_Click(sender As Object, e As EventArgs) Handles btnB50.Click
        agregarQuitar(50, btnB50, 4)
    End Sub

    Private Sub btnB20_Click(sender As Object, e As EventArgs) Handles btnB20.Click
        agregarQuitar(20, btnB20, 5)
    End Sub

    Private Sub btnM20_Click(sender As Object, e As EventArgs) Handles btnM20.Click
        agregarQuitar(20, btnM20, 6)
    End Sub

    Private Sub btnM10_Click(sender As Object, e As EventArgs) Handles btnM10.Click
        agregarQuitar(10, btnM10, 7)
    End Sub

    Private Sub btnM5_Click(sender As Object, e As EventArgs) Handles btnM5.Click
        agregarQuitar(5, btnM5, 8)
    End Sub

    Private Sub btnM2_Click(sender As Object, e As EventArgs) Handles btnM2.Click
        agregarQuitar(2, btnM2, 9)
    End Sub

    Private Sub btnM1_Click(sender As Object, e As EventArgs) Handles btnM1.Click
        agregarQuitar(1, btnM1, 10)
    End Sub

    Private Sub btnM05_Click(sender As Object, e As EventArgs) Handles btnM05.Click
        agregarQuitar(0.5, btnM05, 11)
    End Sub

    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Try
            If flag Then
                flag = False
                btnQuitar.Text = "Quitar"
            Else
                flag = True
                btnQuitar.Text = "Agregar"
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

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        If Not DineroTotal > 0.0 Then
            MessageBox.Show("Debes introducir dinero para iniciar la caja.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.None)
        Else
            If vn Then
                'esto es cuando esta en ventas

            Else 'aqui es para iniciar caja desda boton de venta y caja
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
        Dim ic As IniciarCaja = CType(Owner, IniciarCaja)
        If Not DineroTotal > 0.0 Then
            ic.flagCanelar = False
        Else
            ic.flagCanelar = True
        End If
        Me.Close()
    End Sub

End Class