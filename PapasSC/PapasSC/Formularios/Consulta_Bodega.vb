Public Class Consulta_Bodega



    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

        Dim MTCLI As New MetodosBodega
        If FiltroBodega.SelectedIndex = 0 Then
            MTCLI.llenarDatagridview_filtrobodega(tablabodega, TextBox1.Text)
        ElseIf FiltroBodega.SelectedIndex = 1 Then
            MTCLI.llenarDatagridview_filtroEstatus(tablabodega, TextBox1.Text)
        ElseIf FiltroBodega.SelectedIndex = 2 Then
            MTCLI.llenarDatagridview_filtroMatriz(tablabodega, TextBox1.Text)
        ElseIf FiltroBodega.SelectedIndex = 3 Then
            MTCLI.llenarDatagridview_filtroClave(tablabodega, TextBox1.Text)
        ElseIf FiltroBodega.SelectedIndex = 4 Then
            MTCLI.llenarDatagridview_filtroCiudad(tablabodega, TextBox1.Text)
        End If

    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim MTCLI As New MetodosBodega
        If TextBox1.Text = "" Or TextBox1.Text = Nothing Then
            MTCLI.llenarDatagridview(tablabodega)
            tablabodega.ReadOnly = True
        ElseIf FiltroBodega.SelectedIndex = 0 Then
            MTCLI.llenarDatagridview_filtrobodega(tablabodega, TextBox1.Text)
        ElseIf FiltroBodega.SelectedIndex = 1 Then
            MTCLI.llenarDatagridview_filtroEstatus(tablabodega, TextBox1.Text)
        ElseIf FiltroBodega.SelectedIndex = 2 Then
            MTCLI.llenarDatagridview_filtroMatriz(tablabodega, TextBox1.Text)
        ElseIf FiltroBodega.SelectedIndex = 3 Then
            MTCLI.llenarDatagridview_filtroClave(tablabodega, TextBox1.Text)
        ElseIf FiltroBodega.SelectedIndex = 4 Then
            MTCLI.llenarDatagridview_filtroCiudad(tablabodega, TextBox1.Text)
        End If
    End Sub

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Try
            Dim id As String = Convert.ToString(tablabodega.CurrentRow.Cells(0).Value)
            Dim MTCLI As New MetodosBodega

            If MessageBox.Show("¿Desea ELIMINAR Producto?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MTCLI.eliminaprobodega(id)
                MsgBox(id)
                MTCLI.llenarDatagridview(tablabodega)

            End If
        Catch
            MsgBox("Seleciona un renglos")
        End Try
    End Sub

    Private Sub registrar_Click(sender As Object, e As EventArgs) Handles registrar.Click
        Registrar_Bodega.Show()
    End Sub

    Private Sub actualizar_Click(sender As Object, e As EventArgs) Handles actualizar.Click
        Try


            Dim id As String = Convert.ToString(tablabodega.CurrentRow.Cells(0).Value)
            Dim version As String = Convert.ToString(tablabodega.CurrentRow.Cells(1).Value)
            Dim clave As String = Convert.ToString(tablabodega.CurrentRow.Cells(3).Value)
            Actualizar_bodega.id = id
            Actualizar_bodega.txtnombre.Text = version
            Actualizar_bodega.cmbMatriz.Text = clave
            Actualizar_bodega.Show()
        Catch
            MsgBox("Seleciona un renglos")
        End Try
    End Sub
End Class