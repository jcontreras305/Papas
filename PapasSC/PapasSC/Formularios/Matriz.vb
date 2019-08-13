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
End Class