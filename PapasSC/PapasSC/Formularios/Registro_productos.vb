Public Class Registro_productos

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtClave.Text <> "" And txtVersion.Text <> "" Then
            Dim MTDPR As New MetodosProducto

            MTDPR.insertarProducto(txtVersion.Text, txtClave.Text, npd.Value)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class