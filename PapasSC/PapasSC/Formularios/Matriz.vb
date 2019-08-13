Imports PapasSC.MetodosMatrizCiudad
Public Class Matriz
    Dim mtdMatCD As New MetodosMatrizCiudad

    Private Sub Matriz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mtdMatCD.seleccionar_Matriz(tblMatriz)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCiudad_Click(sender As Object, e As EventArgs) Handles btnCiudad.Click
        Dim txtRespuesta As New TextBox
        If MessageBox.Show(String.Format("Escriba el nombre de la nueva Ciudad" & txtRespuesta.Text), "Nueva Ciudad", MessageBoxButtons.OKCancel) = DialogResult.OK Then

        End If

    End Sub
End Class