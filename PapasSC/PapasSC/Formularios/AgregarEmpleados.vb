Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class AgregarEmpleados

    Dim Emple As New MetodosEmpleado

    Private Sub AgregarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCam.Visible = False
        lblCam1.Visible = False
        lblCam2.Visible = False

        Try

            Emple.SelecionarBode(cboEmBodega)
            Emple.SelecionarHora(cboEmHorario)
            Emple.SelecionarPues(cboEmPuesto)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnEmAceptar_Click(sender As Object, e As EventArgs) Handles btnEmAceptar.Click

        Dim datosEM As New List(Of String)

        If ValidarCampos() Then
            Dim flag1 As Boolean = True

            Try

                datosEM.Add(txtEmNombre.Text)

                If rbuEmMasculino.Checked Then
                    datosEM.Add("M")
                ElseIf rbuEmFemenino.Checked Then
                    datosEM.Add("F")
                End If

                datosEM.Add(txtEmSalario.Text)
                datosEM.Add(txtEmTelefono.Text)
                datosEM.Add(txtEmDireccion.Text)

                If chbActivo.Checked Then
                    datosEM.Add("A")
                Else
                    datosEM.Add("I")
                End If

                datosEM.Add(cboEmBodega.Text)
                datosEM.Add(cboEmHorario.Text)
                datosEM.Add(cboEmPuesto.Text)


            Catch ex As Exception
                MsgBox(ex.Message + "1")
                flag1 = False
            End Try

            If flag1 = True Then
                Emple.InsertarEmple(datosEM)
            End If

        Else
            MsgBox(mensaje)
            CamposObligatorios()
        End If

    End Sub

    Private Function CamposObligatorios() As Boolean
        Try
            lblCam.Visible = True
            lblCam1.Visible = True
            lblCam2.Visible = True

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub txtEmSalario_TextChanged(sender As Object, e As EventArgs) Handles txtEmSalario.TextChanged
        Try
            txtEmSalario.Text = txtEmSalario.Text.Replace(".", ",")
            txtEmSalario.SelectionStart = txtEmSalario.Text.Length
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtEmSalario_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtEmSalario.KeyPress

        ValidarNumeros2(e)
        txtEmSalario.MaxLength = 10

        End Sub


    Private Function ValidarTel(ByVal tel As String) As Boolean
        Return Regex.IsMatch(tel, "\d{3}-\d{3}-\d{4}")
    End Function

    Private mensaje As String

    Private Function ValidarCampos() As Boolean
        Dim flag As Boolean = True
        Dim resultado As String = "Existen campos obligarios: "

        If txtEmNombre.Text.Length = 0 Or txtEmNombre.Text.Trim = String.Empty Then
            resultado = resultado + "Nombre "
            flag = False
        End If

        If Not txtEmTelefono.Text = String.Empty Then
            Dim arrayTel() As Char = txtEmTelefono.Text.ToCharArray

            If arrayTel(3).Equals("-"c) And arrayTel(7).Equals("-"c) And arrayTel.Length = 12 And ValidarTel(txtEmTelefono.Text) Then
            Else
                MsgBox("El número debe tener el siguiente formato 355-000-0000")
                flag = False
            End If
        End If
        Return flag
    End Function

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Close()
    End Sub

    Private Function activarSenialCamposObligatorios() As Boolean
        Try
            lblCam.Visible = True
            lblCam1.Visible = True
            lblCam2.Visible = True
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub txtEmTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmTelefono.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If IsNumeric(e.KeyChar) Then
        ElseIf e.KeyChar.Equals("-"c) Then
        ElseIf Char.IsControl(e.KeyChar) Then
        Else
            MsgBox("Solo puedes ingresar números y no exeder de 12 dígitos")
        End If
    End Sub

    Private Sub txtEmTelefono_KeyUp(sender As Object, e As KeyEventArgs) Handles txtEmTelefono.KeyUp
        Try
            If txtEmTelefono.Text.Length = 3 Or txtEmTelefono.Text.Length = 7 Then
                txtEmTelefono.Text = txtEmTelefono.Text + "-"
            End If


            Dim texttel As String = txtEmTelefono.Text
            If texttel.Length > 12 Then
                texttel = texttel.Remove(texttel.Length - 1)
                txtEmTelefono.Text = texttel
                'MsgBox("Solo se permiten como maximo 13 caracteres")
            End If
            txtEmTelefono.Text = txtEmTelefono.Text.ToUpper
            txtEmTelefono.SelectionStart = texttel.Length
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ValidarNumeros2(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If

    End Sub

    Private Sub ValidarLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub



    Private Sub txtEmNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmNombre.KeyPress
        ValidarLetras(e)
        txtEmNombre.MaxLength = 80
    End Sub



    Private Sub txtEmDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmDireccion.KeyPress
        txtEmDireccion.MaxLength = 50
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Horario.Show()

    End Sub


























    '    Private Sub AgregarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        Try

    '            Emple.SelecionarBode(cboEmBodega)
    '            Emple.SelecionarHora(cboEmHorario)
    '            Emple.SelecionarPues(cboEmPuesto)
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End Sub

    '    Private Sub btnEmAceptar_Click(sender As Object, e As EventArgs) Handles btnEmAceptar.Click
    '        Dim Rse As String = Nothing
    '        If rbuEmFemenino.Checked = True Then
    '            Rse = rbuEmFemenino.Text
    '        ElseIf rbuEmMasculino.Checked = True Then
    '            Rse = rbuEmMasculino.Text
    '        Else
    '            MsgBox("Seleciona el sexo del empleado", MsgBoxStyle.Exclamation, "Registro de empleado")
    '        End If

    '        Try
    '            If Me.ValidateChildren And txtEmNombre.Text <> String.Empty Then
    '                Emple.InsertarEmple(txtEmNombre.Text, Rse, txtEmSalario.Text, txtEmTelefono.Text, txtEmDireccion.Text,
    '                                    cboEmBodega.Text, cboEmHorario.Text, cboEmPuesto.Text)
    '                MessageBox.Show("Datos resgistrados correctamente", "Registro de empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                Me.Close()
    '            Else
    '                MessageBox.Show("Ingrese correctamente los datos", "Registro de empleados", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End If
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End Sub

    '    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
    '        Me.Close()
    '    End Sub

    '    Private Sub ValidarLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
    '        If Char.IsDigit(e.KeyChar) Then
    '            e.Handled = True
    '            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
    '        ElseIf Char.IsControl(e.KeyChar) Then
    '            e.Handled = False
    '        Else
    '            e.Handled = False
    '        End If
    '    End Sub

    '    Private Sub ValidarNumeros1(ByVal CajaTexto As Windows.Forms.TextBox, ByRef e As System.Windows.Forms.KeyPressEventArgs)
    '        If Char.IsDigit(e.KeyChar) Then
    '            e.Handled = False
    '        ElseIf Char.IsControl(e.KeyChar) Then
    '            e.Handled = False
    '        ElseIf e.KeyChar = "-" And Not CajaTexto.Text.IndexOf("-") Then
    '            e.Handled = True
    '        ElseIf e.KeyChar = "-" Then
    '            e.Handled = False
    '        Else
    '            e.Handled = True
    '            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
    '        End If

    '    End Sub

    '    Private Sub ValidarNumeros2(ByRef e As System.Windows.Forms.KeyPressEventArgs)
    '        If Char.IsDigit(e.KeyChar) Then
    '            e.Handled = False
    '        ElseIf Char.IsControl(e.KeyChar) Then
    '            e.Handled = False
    '        Else
    '            e.Handled = True
    '            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
    '        End If

    '    End Sub

    '    Private Sub txtEmNombre_Validating(sender As Object, e As CancelEventArgs)
    '        If DirectCast(sender, TextBox).Text.Length > 0 Then
    '            Me.ErrorIcono.SetError(sender, "")
    '        Else
    '            Me.ErrorIcono.SetError(sender, "Ingrese el nombre este dato es obligatorio")
    '        End If
    '    End Sub

    '    Private Sub txtEmNombre_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtEmNombre.KeyPress
    '        ValidarLetras(e)
    '        txtEmNombre.MaxLength = 80
    '    End Sub

    '    Private Sub txtEmSalario_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtEmSalario.KeyPress
    '        ValidarNumeros2(e)
    '        txtEmSalario.MaxLength = 10

    '    End Sub

    '    Private Sub txtEmTelefono_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtEmTelefono.KeyPress
    '        ValidarNumeros1(txtEmTelefono, e)
    '        txtEmTelefono.MaxLength = 12

    '    End Sub

    '    Private Sub txtEmDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmDireccion.KeyPress
    '        txtEmDireccion.MaxLength = 50
    '    End Sub
End Class