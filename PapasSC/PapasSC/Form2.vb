Public Class Form2
    Private Sub VentasMenuPrincipal_MouseEnter(sender As Object, e As EventArgs) Handles VentasMenuPrincipal.MouseEnter
        VentasMenuPrincipal.BackColor = Color.Coral

    End Sub
    Private Sub VentasMenuPrincipal_Mouseleave(sender As Object, e As EventArgs) Handles VentasMenuPrincipal.MouseLeave
        VentasMenuPrincipal.BackColor = Color.FromArgb(35, 63, 107)

    End Sub
    Private Sub ControlMenuPrincipal_MouseLeave(sender As Object, e As EventArgs) Handles ControlMenuPrincipal.MouseEnter

        ControlMenuPrincipal.BackColor = Color.Coral
    End Sub

    Private Sub ControlMenuPrincipal_MouseEnter(sender As Object, e As EventArgs) Handles ControlMenuPrincipal.MouseLeave
        ControlMenuPrincipal.BackColor = Color.FromArgb(35, 63, 107)

    End Sub



    Private Sub ConfiguracionMenuPrincipal_MouseEnter(sender As Object, e As EventArgs) Handles ConfiguracionMenuPrincipal.MouseEnter
        ConfiguracionMenuPrincipal.BackColor = Color.Coral

    End Sub

    Private Sub ConfiguracionMenuPrincipal_MouseLeave(sender As Object, e As EventArgs) Handles ConfiguracionMenuPrincipal.MouseLeave
        ConfiguracionMenuPrincipal.BackColor = Color.FromArgb(35, 63, 107)
    End Sub

    Private Sub InventarioMenuPrincipal_MouseEnter(sender As Object, e As EventArgs) Handles InventarioMenuPrincipal.MouseEnter
        InventarioMenuPrincipal.BackColor = Color.Coral

    End Sub

    Private Sub InventarioMenuPrincipal_MouseLeave(sender As Object, e As EventArgs) Handles InventarioMenuPrincipal.MouseLeave
        InventarioMenuPrincipal.BackColor = Color.FromArgb(35, 63, 107)
    End Sub

    Private Sub ReporteMenuPrincipal_MouseEnter(sender As Object, e As EventArgs) Handles ReporteMenuPrincipal.MouseEnter
        ReporteMenuPrincipal.BackColor = Color.Coral

    End Sub

    Private Sub ReporteMenuPrincipal_MouseLeave(sender As Object, e As EventArgs) Handles ReporteMenuPrincipal.MouseLeave
        ReporteMenuPrincipal.BackColor = Color.FromArgb(35, 63, 107)
    End Sub

    Private Sub CatalogMenuPrincipal_MouseEnter(sender As Object, e As EventArgs) Handles CatalogoMenuPrincipal.MouseEnter
        CatalogoMenuPrincipal.BackColor = Color.Coral

    End Sub

    Private Sub CatalogoMenuPrincipal_MouseLeave(sender As Object, e As EventArgs) Handles CatalogoMenuPrincipal.MouseLeave
        CatalogoMenuPrincipal.BackColor = Color.FromArgb(35, 63, 107)
    End Sub

    Private Sub NominaMenuPrincipal_MouseEnter(sender As Object, e As EventArgs) Handles NominaMenuPrincipal.MouseEnter
        NominaMenuPrincipal.BackColor = Color.Coral

    End Sub

    Private Sub NominaaMenuPrincipal_MouseLeave(sender As Object, e As EventArgs) Handles NominaMenuPrincipal.MouseLeave
        NominaMenuPrincipal.BackColor = Color.FromArgb(35, 63, 107)
    End Sub

    Private Sub UtileriaMenuPrincipal_MouseEnter(sender As Object, e As EventArgs) Handles UtileriasMenuPrincipal.MouseEnter
        UtileriasMenuPrincipal.BackColor = Color.Coral

    End Sub

    Private Sub UtileriasMenuPrincipal_MouseLeave(sender As Object, e As EventArgs) Handles UtileriasMenuPrincipal.MouseLeave
        UtileriasMenuPrincipal.BackColor = Color.FromArgb(35, 63, 107)
    End Sub

    Private Sub Minimizar_Click(sender As Object, e As EventArgs) Handles Minimizar.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Me.Close()
    End Sub
End Class