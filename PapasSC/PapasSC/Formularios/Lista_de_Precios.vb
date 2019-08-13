Public Class Lista_de_Precios

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        tablaprecios.ReadOnly = True
        Dim MTCLI As New MetodosProducto
        If filtroproductos.SelectedIndex = 0 Then
            MTCLI.llenarDatagridview_filtroEstado(tablaprecios, TextBox1.Text)
        ElseIf filtroproductos.SelectedIndex = 1 Then
            MTCLI.llenarDatagridview_filtroVersion(tablaprecios, TextBox1.Text)
        ElseIf filtroproductos.SelectedIndex = 2 Then
            MTCLI.llenarDatagridview_filtroclave(tablaprecios, TextBox1.Text)
        ElseIf filtroproductos.SelectedIndex = 3 Then
            MTCLI.llenarDatagridview_filtroID(tablaprecios, TextBox1.Text)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tablaprecios.ReadOnly = True
        Dim MTCLI As New MetodosProducto
        If TextBox1.Text = "" Or TextBox1.Text = Nothing Then
            MTCLI.llenarDatagridviewlistaprecio(tablaprecios)

        ElseIf filtroproductos.SelectedIndex = 0 Then
            MTCLI.llenarDatagridview_filtroEstado(tablaprecios, TextBox1.Text)
        ElseIf filtroproductos.SelectedIndex = 1 Then
            MTCLI.llenarDatagridview_filtroVersion(tablaprecios, TextBox1.Text)
        ElseIf filtroproductos.SelectedIndex = 2 Then
            MTCLI.llenarDatagridview_filtroclave(tablaprecios, TextBox1.Text)
        ElseIf filtroproductos.SelectedIndex = 3 Then
            MTCLI.llenarDatagridview_filtroID(tablaprecios, TextBox1.Text)
        End If
    End Sub

    Private Sub Actualizar_precio_Click(sender As Object, e As EventArgs) Handles Actualizar_precio.Click
        Try

            Dim id As String = Convert.ToString(tablaprecios.CurrentRow.Cells(0).Value)
            Dim MTCLI As New MetodosProducto

            If MessageBox.Show("¿Desea Actualizar precio de Producto?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


                MTCLI.updateprecio(id, npd.Value)
                MTCLI.llenarDatagridviewlistaprecio(tablaprecios)
            End If
        Catch
            MsgBox("Seleciona un renglos")
        End Try
    End Sub
End Class