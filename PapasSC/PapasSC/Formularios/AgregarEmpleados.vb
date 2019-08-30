Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class AgregarEmpleados

    Dim Emple As New MetodosEmpleado
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub AgregarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Emple.SelecionarBode(cboEmBodega)
            Emple.SelecionarHora(cboEmHorario)
            Emple.SelecionarPues(cboEmPuesto)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEmAceptar_Click(sender As Object, e As EventArgs) Handles btnEmAceptar.Click
        Dim Rse As String = Nothing
        If rbuEmFemenino.Checked = True Then
            Rse = rbuEmFemenino.Text
        ElseIf rbuEmMasculino.Checked = True Then
            Rse = rbuEmMasculino.Text
        Else
            MsgBox("Seleciona el sexo del empleado", MsgBoxStyle.Exclamation, "Registro de empleado")
        End If

        Try
            If Me.ValidateChildren And txtEmNombre.Text <> String.Empty Then
                Emple.InsertarEmple(txtEmNombre.Text, Rse, txtEmSalario.Text, txtEmTelefono.Text, txtEmDireccion.Text,
                                    cboEmBodega.Text, cboEmHorario.Text, cboEmPuesto.Text)
                MessageBox.Show("Datos resgistrados correctamente", "Registro de empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Ingrese correctamente los datos", "Registro de empleados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Close()
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

    Private Sub ValidarNumeros1(ByVal CajaTexto As Windows.Forms.TextBox, ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "-" And Not CajaTexto.Text.IndexOf("-") Then
            e.Handled = True
        ElseIf e.KeyChar = "-" Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If

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

    Private Sub txtEmNombre_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el nombre este dato es obligatorio")
        End If
    End Sub

    Private Sub txtEmNombre_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtEmNombre.KeyPress
        ValidarLetras(e)
        txtEmNombre.MaxLength = 80
    End Sub

    Private Sub txtEmSalario_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtEmSalario.KeyPress
        ValidarNumeros2(e)
        txtEmSalario.MaxLength = 10

    End Sub

    Private Sub txtEmTelefono_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtEmTelefono.KeyPress
        ValidarNumeros1(txtEmTelefono, e)
        txtEmTelefono.MaxLength = 12

    End Sub

    Private Sub txtEmDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtEmDireccion.TextChanged
        txtEmDireccion.MaxLength = 50
    End Sub
End Class