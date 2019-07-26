Public Class Form2
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles VentasMenuPrincipal.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles InventarioMenuPrincipal.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub


    Private Sub VentasMenuPrincipal_MouseEnter(sender As Object, e As EventArgs) Handles VentasMenuPrincipal.MouseEnter
        VentasMenuPrincipal.BackColor = Color.Coral

    End Sub

    Private Sub VentasMenuPrincipal_MouseLeave(sender As Object, e As EventArgs) Handles VentasMenuPrincipal.MouseLeave
        VentasMenuPrincipal.BackColor = Color.Aqua
    End Sub
End Class