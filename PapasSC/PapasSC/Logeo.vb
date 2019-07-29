
Public Class Logeo
    Dim metodos As New LogeoMetodos

    Private Sub Logeo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'metodos.conect()
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Dim usuario As String = txtUsuario.Text
        Dim contrasenia As String = txtContrasenia.Text

        If metodos.validarUsuario(usuario, contrasenia) = True Then


            With Form2
                .MinimizeBox = False
                .ShowInTaskbar = False
                .ShowIcon = False
                .Location = New Point(0, 50)
                .Text = "Paspas Santa Cruz"
                .Size = New System.Drawing.Size(1155, 761)
                .FormBorderStyle = FormBorderStyle.FixedDialog
                .StartPosition = FormStartPosition.Manual
            End With

            Form2.Show()
            Me.Close()


        Else
            MsgBox("Usuario o Contraseña incorrecta")
        End If
    End Sub
End Class
