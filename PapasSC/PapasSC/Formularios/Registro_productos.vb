Public Class Registro_productos

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtClave.Text <> "" And txtVersion.Text <> "" Then
            Dim MTDPR As New MetodosProducto
            MsgBox("Datos ingresados correctamente")
            MTDPR.insertarProducto(txtVersion.Text, txtClave.Text, npd.Value)
        Else
            MsgBox("Ingrese correctamente los campos")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Registro_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        npd.DecimalPlaces = 2
        npd.ThousandsSeparator = True
    End Sub

    Private Sub txtVersion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtVersion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese el nombre del usuario, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtClave_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtClave.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese el campo, este dato es obligatorio")
        End If
    End Sub

    Private Sub npd_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles npd.Validating
        If DirectCast(sender, NumericUpDown).Value > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese el campo, este dato es obligatorio")
        End If
    End Sub
End Class