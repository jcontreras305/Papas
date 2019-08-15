Public Class Registrar_Proveedor
    Dim Pro As New MetodosProveedor

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
    End Sub

    Private Sub Registrar_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Pro.SelecionarCiu(cboCiudadProve)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub


End Class