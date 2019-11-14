Imports PapasSC.MetodosBodega

Public Class Registrar_Bodega
    Dim mtdBodega As New MetodosBodega

    Private Sub Registrar_Bodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtdBodega.llenarComboMatriz(cmbMatriz)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtnombre.Text <> "" Then
            mtdBodega.insertarBodega(txtnombre.Text, cmbMatriz.Text)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese campo, este dato es obligatorio")
        End If
    End Sub
End Class