Imports PapasSC.MetodosBodega

Public Class Registrar_Bodega
    Dim mtdBodega As New MetodosBodega

    Private Sub Registrar_Bodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtdBodega.llenarComboMatriz(cmbMatriz)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mtdBodega.insertarBodega(txtnombre.Text, cmbMatriz.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class