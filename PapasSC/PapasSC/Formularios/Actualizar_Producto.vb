Public Class Actualizar_Producto
    Public id As String
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Actualizar_Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        npd.DecimalPlaces = 2
        npd.ThousandsSeparator = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MTDPR As New MetodosProducto
        MTDPR.updateProducto(id, txtversion.Text, txtClave.Text, npd.Value)
    End Sub

    Private Sub txtversion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtversion.Validating, txtClave.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese campo, este dato es obligatorio")
        End If
    End Sub
End Class