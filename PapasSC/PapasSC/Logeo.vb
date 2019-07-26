
Public Class Logeo
    Dim metodos As New LogeoMetodos

    Private Sub Logeo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'metodos.conect()
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Dim usuario As String = txtUsuario.Text
        Dim contrasenia As String = txtContrasenia.Text


    End Sub
End Class
