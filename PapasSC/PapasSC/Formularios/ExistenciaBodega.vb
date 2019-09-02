Public Class ExistenciaBodega
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Reclasificacion.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Registrar_Bodega.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Registro_productos.Show()
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim MTCLI As New MetodoExistenciaProducto
        If TextBox1.Text = "" Or TextBox1.Text = Nothing Then
            MTCLI.llenarDatagridview(tblexistenciapro)
            tblexistenciapro.ReadOnly = True
        ElseIf filtroExistencia.SelectedIndex = 0 Then
            MTCLI.llenarDatagridview_filtroCantidad(tblexistenciapro, TextBox1.Text)
        ElseIf filtroExistencia.SelectedIndex = 1 Then
            MTCLI.llenarDatagridview_filtroBodega(tblexistenciapro, TextBox1.Text)
        ElseIf filtroExistencia.SelectedIndex = 2 Then
            MTCLI.llenarDatagridview_filtroPrecio(tblexistenciapro, TextBox1.Text)
        ElseIf filtroExistencia.SelectedIndex = 3 Then
            MTCLI.llenarDatagridview_filtroEstatus(tblexistenciapro, TextBox1.Text)
        ElseIf filtroExistencia.SelectedIndex = 4 Then
            MTCLI.llenarDatagridview_filtroVersion(tblexistenciapro, TextBox1.Text)
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Dim MTCLI As New MetodoExistenciaProducto
        If filtroExistencia.SelectedIndex = 0 Then
            MTCLI.llenarDatagridview_filtroCantidad(tblexistenciapro, TextBox1.Text)
        ElseIf filtroExistencia.SelectedIndex = 1 Then
            MTCLI.llenarDatagridview_filtroBodega(tblexistenciapro, TextBox1.Text)
        ElseIf filtroExistencia.SelectedIndex = 2 Then
            MTCLI.llenarDatagridview_filtroPrecio(tblexistenciapro, TextBox1.Text)
        ElseIf filtroExistencia.SelectedIndex = 3 Then
            MTCLI.llenarDatagridview_filtroEstatus(tblexistenciapro, TextBox1.Text)
        ElseIf filtroExistencia.SelectedIndex = 4 Then
            MTCLI.llenarDatagridview_filtroVersion(tblexistenciapro, TextBox1.Text)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim idbodega As String = Convert.ToString(tblexistenciapro.CurrentRow.Cells(0).Value)
            Dim idversion As String = Convert.ToString(tblexistenciapro.CurrentRow.Cells(2).Value)

            Dim MTCLI As New MetodoExistenciaProducto

            If MessageBox.Show("¿Desea ELIMINAR Bodega?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MTCLI.eliminaexistenciaproducto(idbodega, idversion)

                MTCLI.llenarDatagridview(tblexistenciapro)

            End If
        Catch
            MsgBox("Seleciona un renglos")
        End Try
    End Sub
End Class