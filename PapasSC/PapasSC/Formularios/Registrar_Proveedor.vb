Imports System.ComponentModel

Public Class Registrar_Proveedor
    Dim Pro As New MetodosProveedor

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
    End Sub

    Private Sub Registrar_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Pro.SelecionarCiu(cboCiudadProve)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnAceptarProvee_Click(sender As Object, e As EventArgs) Handles btnAceptarProvee.Click
        Try
            If Me.ValidateChildren And txtNombrePro.Text <> String.Empty Then
                MessageBox.Show("Datos resgistrados correctamente", "Registro de empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Pro.InsertarProveedor(txtNombrePro.Text, txtTelefonoProvee.Text, txtEmailProvee.Text, cboCiudadProve.Text)
            Else
                MessageBox.Show("Ingrese correctamente los datos", "Registro de empleados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtNombrePro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombrePro.KeyPress
        ValidarLetras(e)
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

    Private Sub ValidarNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Private Sub txtTelefonoProvee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefonoProvee.KeyPress
        ValidarNumeros(e)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtNombrePro_Validating(sender As Object, e As CancelEventArgs) Handles txtNombrePro.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el nombre este dato es obligatorio")
        End If
    End Sub


End Class