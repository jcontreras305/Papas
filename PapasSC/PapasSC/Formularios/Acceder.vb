Public Class Acceder
    Public user, pass As String
    Public flag As Boolean


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        caja.acceso = False
        Me.Close()
    End Sub

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        Try
            Dim mtdLogin As New LogeoMetodos
            If mtdLogin.validarUsuarioCaja(cmbUsuario.Text, txtPasword.Text) Then
                flag = True
                Dim caja As Caja = CType(Owner, Caja)
                caja.acceso = True
                Me.Close()
            Else
                flag = False
                MsgBox("Verifique su usuario o contraseña")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chbVer_CheckedChanged(sender As Object, e As EventArgs) Handles chbVer.CheckedChanged
        txtPasword.UseSystemPasswordChar = If(chbVer.Checked, False, True)

    End Sub

    Private Sub Acceder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim lstIdEmpleado As New List(Of String)
            Dim mtdEmpleado As New MetodosEmpleado
            mtdEmpleado.seleccionarNombreEmpleado(cmbUsuario, lstIdEmpleado)
            cmbUsuario.SelectedIndex = cmbUsuario.FindString(user)
            cmbUsuario.Text = user
            txtPasword.UseSystemPasswordChar = True
        Catch ex As Exception
        End Try
    End Sub
End Class