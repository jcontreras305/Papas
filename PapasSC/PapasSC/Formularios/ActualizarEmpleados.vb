Imports System.ComponentModel
Imports System.Text.RegularExpressions


Public Class ActualizarEmpleados

    Dim EmpleadoAct As New MetodosEmpleado
    Private datosEmpleados2() As String

    Private Sub ActualizarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCam.Visible = False
        lblCam1.Visible = False
        lblCam2.Visible = False

        rbuEmMasculino.Checked = True
        datosEmpleados2 = ConsultarEmpleado.datosEm


        Try
            txtEmNombre.Text = datosEmpleados2(0).ToString
        Catch ex As Exception
            txtEmNombre.Text = ""
        End Try



        If datosEmpleados2(1).Equals("M") Then
            rbuEmMasculino.Checked = True
        ElseIf datosEmpleados2(1).Equals("F") Then
            rbuEmFemenino.Checked = True
        End If

        txtEmSalario.Text = datosEmpleados2(2)
        txtEmTelefono.Text = datosEmpleados2(3)
        txtEmDireccion.Text = datosEmpleados2(4)



        Try

            EmpleadoAct.SelecionarBode(cboEmBodega)
            EmpleadoAct.SelecionarHora(cboEmHorario)
            EmpleadoAct.SelecionarPues(cboEmPuesto)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cboEmBodega.SelectedIndex = cboEmBodega.FindString(datosEmpleados2(5))
        cboEmHorario.SelectedIndex = cboEmHorario.FindString(datosEmpleados2(7))
        cboEmPuesto.SelectedIndex = cboEmPuesto.FindString(datosEmpleados2(6))



    End Sub

    Private Sub btnEmAceptar_Click(sender As Object, e As EventArgs) Handles btnEmAceptar.Click
        Try
            If ValidarCampos() Then
                Dim flag1 As Boolean = True

                Dim datosEmpleNew As New List(Of String)

                Try
                    datosEmpleNew.Add(txtEmNombre.Text)

                    If rbuEmMasculino.Checked Then
                        datosEmpleNew.Add("M")
                    ElseIf rbuEmFemenino.Checked Then
                        datosEmpleNew.Add("F")
                    End If

                    datosEmpleNew.Add(txtEmSalario.Text)
                    datosEmpleNew.Add(txtEmTelefono.Text)
                    datosEmpleNew.Add(txtEmDireccion.Text)

                    If chbActivo.Checked Then
                        datosEmpleNew.Add("A")
                    Else
                        datosEmpleNew.Add("I")
                    End If

                    datosEmpleNew.Add(cboEmBodega.Text)
                    datosEmpleNew.Add(cboEmHorario.Text)
                    datosEmpleNew.Add(cboEmPuesto.Text)

                Catch ex As Exception

                    flag1 = False
                End Try

                If flag1 = True Then
                    EmpleadoAct.ActualizarEmpleado(datosEmpleNew)
                End If

            Else
                MsgBox(mensaje)
                CamposObligatorios()
            End If

        Catch ex As Exception

        End Try

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

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
    End Sub






















    'Public nombre, sexo, sala, telefono, dire, bodega, horario, puesto As String

    'Private Sub ActualizarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

    'Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
    '    Me.Close()
    'End Sub

    'Private Sub btnEmCancelar_Click(sender As Object, e As EventArgs)
    '    Me.Close()
    'End Sub

    'Public mtdEmpleado As New MetodosEmpleado

    'Private Sub btnEmAceptar_Click(sender As Object, e As EventArgs)
    '    Dim datosNu(8), datosVi(8) As String
    '    Dim nombre As String
    '    Dim sexo As String

    '    nombre = txtEmNombre.Text
    '    sexo = rbuEmFemenino.Checked
    '    datosNu(0) = txtEmSalario.Text
    '    datosNu(1) = txtEmTelefono.Text
    '    datosNu(2) = txtEmDireccion.Text
    '    datosNu(3) = cboEmBodega.Text
    '    datosNu(4) = cboEmHorario.Text
    '    datosNu(5) = cboEmPuesto.Text
    '    datosVi(0) = txtEmSalario.Text
    '    datosVi(1) = txtEmTelefono.Text
    '    datosVi(2) = txtEmDireccion.Text
    '    datosVi(3) = cboEmBodega.Text
    '    datosVi(4) = cboEmHorario.Text
    '    datosVi(5) = cboEmPuesto.Text

    '    mtdEmpleado.ActualizarEmpleado(datosVi, datosNu, nombre, sexo)
    'End Sub

End Class