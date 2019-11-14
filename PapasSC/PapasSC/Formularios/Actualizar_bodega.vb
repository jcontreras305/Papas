Public Class Actualizar_bodega
    Public id As String
    Private Sub Actualizar_bodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbMatriz_Enter(sender As Object, e As EventArgs) Handles cmbMatriz.Enter
        Dim mtbo As New MetodosBodega
        mtbo.llenarComboMatriz(cmbMatriz)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mtbo As New MetodosBodega
        Try
            If txtnombre.Text <> "" Then
                mtbo.updatebodega(txtnombre.Text, cmbMatriz.Text, id)
            Else
                MsgBox("Ingrese correctamente los datos")
            End If
        Catch
        End Try
    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese campo, este dato es obligatorio")
        End If
    End Sub
End Class