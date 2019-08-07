
Public Class Logeo
    Dim metodos As New LogeoMetodos


    Private Sub Logeo_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Dim usuario As String = txtUsuario.Text
        Dim contrasenia As String = txtContrasenia.Text

        If metodos.validarUsuario(usuario, contrasenia) = True Then
            If txtUsuario.Equals("") Then
                MsgBox("No se ingreso un Usuario")
            Else
                If txtContrasenia.Equals("") Then
                    MsgBox("No se ingreso una Contraseña")
                Else
                    With Form2
                        .ShowIcon = True
                        .FormBorderStyle = FormBorderStyle.None
                        .StartPosition = FormStartPosition.Manual
                        .NombreUsuario.Text = metodos.nombre
                    End With

                    Form2.Show()
                    Me.Close()
                End If
            End If
        Else
            MsgBox("Usuario o Contraseña incorrecta")
        End If
    End Sub

    Private Sub txtContrasenia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContrasenia.KeyPress


        txtContrasenia.PasswordChar = "*"



    End Sub
End Class
