Public Class Consulta_Producto
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Registro_productos.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try


            Dim id As String = Convert.ToString(TablaProductos.CurrentRow.Cells(0).Value)
            Dim version As String = Convert.ToString(TablaProductos.CurrentRow.Cells(1).Value)
            Dim clave As String = Convert.ToString(TablaProductos.CurrentRow.Cells(3).Value)
            Dim precio As String = Convert.ToString(TablaProductos.CurrentRow.Cells(4).Value)
            Actualizar_Producto.id = id
            Actualizar_Producto.txtversion.Text = version
            Actualizar_Producto.txtClave.Text = clave
            Actualizar_Producto.npd.Value=precio
            Actualizar_Producto.Show()
        Catch
            MsgBox("Seleciona un renglos")
        End Try


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try

            Dim id As String = Convert.ToString(TablaProductos.CurrentRow.Cells(0).Value)
            Dim MTCLI As New MetodosProducto

            If MessageBox.Show("¿Desea ELIMINAR Producto?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MTCLI.eliminaproducto(id)
                MsgBox(id)
                MTCLI.llenarDatagridview(TablaProductos
                                         )

            End If
        Catch
            MsgBox("Seleciona un renglos")
        End Try
    End Sub

    Private Sub Consulta_Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

        Dim MTCLI As New MetodosProducto
        If filtroproductos.SelectedIndex = 0 Then
            MTCLI.llenarDatagridview_filtroEstado(TablaProductos, TextBox1.Text)
        ElseIf filtroproductos.SelectedIndex = 1 Then
            MTCLI.llenarDatagridview_filtroVersion(TablaProductos, TextBox1.Text)
        ElseIf filtroproductos.SelectedIndex = 2 Then
            MTCLI.llenarDatagridview_filtroclave(TablaProductos, TextBox1.Text)
        ElseIf filtroproductos.SelectedIndex = 3 Then
            MTCLI.llenarDatagridview_filtroID(TablaProductos, TextBox1.Text)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MTCLI As New MetodosProducto
        If TextBox1.Text = "" Or TextBox1.Text = Nothing Then
            MTCLI.llenarDatagridview(TablaProductos)
            TablaProductos.ReadOnly = True
        ElseIf filtroproductos.SelectedIndex = 0 Then
            MTCLI.llenarDatagridview_filtroEstado(TablaProductos, TextBox1.Text)
        ElseIf filtroproductos.SelectedIndex = 1 Then
            MTCLI.llenarDatagridview_filtroVersion(TablaProductos, TextBox1.Text)
        ElseIf filtroproductos.SelectedIndex = 2 Then
            MTCLI.llenarDatagridview_filtroclave(TablaProductos, TextBox1.Text)
        ElseIf filtroproductos.SelectedIndex = 3 Then
            MTCLI.llenarDatagridview_filtroID(TablaProductos, TextBox1.Text)
        End If
    End Sub
End Class