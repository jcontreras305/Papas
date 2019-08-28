Public Class PerfilesDeLosUsuarios
    Dim privilegios() As String = {"Venta", "Inventario", "Reportes", "Catálogo", "Empleados", "Utilerias", "Control", "Configuración"}

    Private Sub PerfilesDeLosUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblCerrar_Click(sender As Object, e As EventArgs) Handles lblCerrar.Click
        Me.Close()
    End Sub



End Class