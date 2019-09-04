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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Registrar_Existencias.Show()

    End Sub

    Private Sub ActulizarExistencia_Click(sender As Object, e As EventArgs) Handles ActulizarExistencia.Click
        Try
            Dim id As String = Convert.ToString(tblexistenciapro.CurrentRow.Cells(0).Value)
            Dim version As String = Convert.ToString(tblexistenciapro.CurrentRow.Cells(1).Value)
            Dim clave As String = Convert.ToString(tblexistenciapro.CurrentRow.Cells(2).Value)
            Actualizar_Existencia.cmbBodega.Text = id
            Actualizar_Existencia.npd.Value = version
            Actualizar_Existencia.claveb = id
            Actualizar_Existencia.clavep = clave
            Actualizar_Existencia.cmbProducto.Text = clave
            Actualizar_Existencia.Show()
        Catch
            MsgBox("Seleciona un renglos")
        End Try
    End Sub

    Private Sub ExistenciaBodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnAvanzado_Click(sender As Object, e As EventArgs) Handles btnAvanzado.Click
        Opciones_Avanzadas.Show()
    End Sub
End Class