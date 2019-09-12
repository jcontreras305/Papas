
Public Class Logeo
    Dim metodos As New LogeoMetodos

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Dim usuario As String = txtUsuario.Text
        Dim contrasenia As String = txtContrasenia.Text

        If metodos.validarUsuario(usuario, contrasenia) = True Then
            If txtUsuario.Equals("") Or txtUsuario.Text = String.Empty Then
                MsgBox("No se ingreso un Usuario")
            Else
                If txtContrasenia.Equals("") Or txtContrasenia.Text = String.Empty Then
                    MsgBox("No se ingreso una Contraseña")
                Else
                    With Form2
                        Dim a(100) As Point
                        a(0) = .VentasMenuPrincipal.Location
                        a(1) = .InventarioMenuPrincipal.Location
                        a(2) = .ReporteMenuPrincipal.Location
                        a(3) = .CatalogoMenuPrincipal.Location
                        a(4) = .NominaMenuPrincipal.Location
                        a(5) = .UtileriasMenuPrincipal.Location
                        a(6) = .ControlMenuPrincipal.Location
                        a(7) = .ConfiguracionMenuPrincipal.Location


                        .ShowIcon = True
                        .FormBorderStyle = FormBorderStyle.None
                        .StartPosition = FormStartPosition.Manual
                        .NombreUsuario.Text = metodos.nombre
                        .login = txtUsuario.Text

                        If metodos.tipoUsuario = "Venta" Then
                            .NominaMenuPrincipal.Visible = False
                            .UtileriasMenuPrincipal.Visible = False
                            .ControlMenuPrincipal.Visible = False
                            .ConfiguracionMenuPrincipal.Location = .NominaMenuPrincipal.Location
                            .usuario = metodos.tipoUsuario

                        ElseIf metodos.tipoUsuario = "Operador" Then
                            .NominaMenuPrincipal.Visible = False
                            .UtileriasMenuPrincipal.Visible = False
                            .ControlMenuPrincipal.Visible = False
                            .ConfiguracionMenuPrincipal.Location = .NominaMenuPrincipal.Location
                            .usuario = metodos.tipoUsuario
                        ElseIf metodos.tipoUsuario = "Contador" Then
                            .VentasMenuPrincipal.Visible = False
                            .CatalogoMenuPrincipal.Visible = False
                            .NominaMenuPrincipal.Visible = False
                            .ConfiguracionMenuPrincipal.Location = .NominaMenuPrincipal.Location
                            .usuario = metodos.tipoUsuario

                        End If

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
