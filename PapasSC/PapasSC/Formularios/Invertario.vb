Imports PapasSC.MetodosInventario
Public Class Invertario
    Dim mtdInv As New MetodosInventario

    Private Sub Invertario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mtdInv.buscarBodegas(cmbBodega)
            mtdInv.buscarProducto(cmbProducto)
            Me.Location = New Point(300, 200)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbBodega_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBodega.SelectedIndexChanged
        Dim bodega As String
        Dim producto As String
        Try
            producto = cmbProducto.SelectedItem.ToString
        Catch ex As Exception
            producto = "--"
        End Try

        Try
            bodega = cmbBodega.SelectedItem.ToString
        Catch ex As Exception
            bodega = "--"
        End Try

        If Not bodega.Equals("--") And Not producto.Equals("--") And chbExistencia.Checked Then
            mtdInv.buscarProductoPorNombreBodegaSinExistencia(bodega, producto, tblInventario)
        ElseIf Not bodega.Equals("--") And Not producto.Equals("--") And Not chbExistencia.Checked Then
            mtdInv.buscarProductoPorNombreBodegaConExistencia(bodega, producto, tblInventario)
        ElseIf Not bodega.Equals("--") And producto.Equals("--") And chbExistencia.Checked Then
            mtdInv.buscarProductoPorBodegaConExistencia(bodega, tblInventario)
        ElseIf bodega.Equals("--") And Not producto.Equals("--") And chbExistencia.Checked Then
            mtdInv.buscarProductoPorProductoConExistencia(producto, tblInventario)
        ElseIf Not bodega.Equals("--") And producto.Equals("--") And Not chbExistencia.Checked Then
            mtdInv.buscarProductoPorBodegaSinExistencia(bodega, tblInventario)
        ElseIf bodega.Equals("--") And Not producto.Equals("--") And Not chbExistencia.Checked Then
            mtdInv.buscarProductoPorProductoSinExistencia(producto, tblInventario)
        ElseIf bodega.Equals("--") And producto.Equals("--") Then
            'MsgBox(bodega + producto)
        End If

        tablaDisenio(tblInventario)

    End Sub

    Private Sub cmbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProducto.SelectedIndexChanged
        Dim bodega As String
        Dim producto As String
        Try
            producto = cmbProducto.SelectedItem.ToString
        Catch ex As Exception
            producto = "--"
        End Try
        Try
            bodega = cmbBodega.SelectedItem.ToString
        Catch ex As Exception
            bodega = "--"
        End Try

        If Not bodega.Equals("--") And Not producto.Equals("--") And chbExistencia.Checked Then
            mtdInv.buscarProductoPorNombreBodegaSinExistencia(bodega, producto, tblInventario)
        ElseIf Not bodega.Equals("--") And Not producto.Equals("--") And Not chbExistencia.Checked Then
            mtdInv.buscarProductoPorNombreBodegaConExistencia(bodega, producto, tblInventario)
        ElseIf Not bodega.Equals("--") And producto.Equals("--") And chbExistencia.Checked Then
            mtdInv.buscarProductoPorBodegaConExistencia(bodega, tblInventario)
        ElseIf bodega.Equals("--") And Not producto.Equals("--") And chbExistencia.Checked Then
            mtdInv.buscarProductoPorProductoConExistencia(producto, tblInventario)
        ElseIf Not bodega.Equals("--") And producto.Equals("--") And Not chbExistencia.Checked Then
            mtdInv.buscarProductoPorBodegaSinExistencia(bodega, tblInventario)
        ElseIf bodega.Equals("--") And Not producto.Equals("--") And Not chbExistencia.Checked Then
            mtdInv.buscarProductoPorProductoSinExistencia(producto, tblInventario)
        Else

        End If
        tablaDisenio(tblInventario)
    End Sub

    Private Function tablaDisenio(ByVal tabla As DataGridView) As Boolean
        Try
            tabla.Columns(0).Width = 210
            tabla.Columns(1).Width = 210
            tabla.Columns(2).Width = 210
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Invertario_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            Dim bodega As String
            Dim producto As String
            Try
                producto = cmbProducto.SelectedItem.ToString
            Catch ex As Exception
                producto = "--"
            End Try
            Try
                bodega = cmbBodega.SelectedItem.ToString
            Catch ex As Exception
                bodega = "--"
            End Try

            If Not bodega.Equals("--") And Not producto.Equals("--") And chbExistencia.Checked Then
                mtdInv.buscarProductoPorNombreBodegaSinExistencia(bodega, producto, tblInventario)
            ElseIf Not bodega.Equals("--") And Not producto.Equals("--") And Not chbExistencia.Checked Then
                mtdInv.buscarProductoPorNombreBodegaConExistencia(bodega, producto, tblInventario)
            ElseIf Not bodega.Equals("--") And producto.Equals("--") And chbExistencia.Checked Then
                mtdInv.buscarProductoPorBodegaConExistencia(bodega, tblInventario)
            ElseIf bodega.Equals("--") And Not producto.Equals("--") And chbExistencia.Checked Then
                mtdInv.buscarProductoPorProductoConExistencia(producto, tblInventario)
            ElseIf Not bodega.Equals("--") And producto.Equals("--") And Not chbExistencia.Checked Then
                mtdInv.buscarProductoPorBodegaSinExistencia(bodega, tblInventario)
            ElseIf bodega.Equals("--") And Not producto.Equals("--") And Not chbExistencia.Checked Then
                mtdInv.buscarProductoPorProductoSinExistencia(producto, tblInventario)
            Else

            End If
            tablaDisenio(tblInventario)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim bodega As String
            Dim producto As String
            Try
                producto = cmbProducto.SelectedItem.ToString
            Catch ex As Exception
                producto = "--"
            End Try
            Try
                bodega = cmbBodega.SelectedItem.ToString
            Catch ex As Exception
                bodega = "--"
            End Try

            If Not bodega.Equals("--") And Not producto.Equals("--") And chbExistencia.Checked Then
                mtdInv.buscarProductoPorNombreBodegaSinExistencia(bodega, producto, tblInventario)
            ElseIf Not bodega.Equals("--") And Not producto.Equals("--") And Not chbExistencia.Checked Then
                mtdInv.buscarProductoPorNombreBodegaConExistencia(bodega, producto, tblInventario)
            ElseIf Not bodega.Equals("--") And producto.Equals("--") And chbExistencia.Checked Then
                mtdInv.buscarProductoPorBodegaConExistencia(bodega, tblInventario)
            ElseIf bodega.Equals("--") And Not producto.Equals("--") And chbExistencia.Checked Then
                mtdInv.buscarProductoPorProductoConExistencia(producto, tblInventario)
            ElseIf Not bodega.Equals("--") And producto.Equals("--") And Not chbExistencia.Checked Then
                mtdInv.buscarProductoPorBodegaSinExistencia(bodega, tblInventario)
            ElseIf bodega.Equals("--") And Not producto.Equals("--") And Not chbExistencia.Checked Then
                mtdInv.buscarProductoPorProductoSinExistencia(producto, tblInventario)
            Else

            End If
            tablaDisenio(tblInventario)
        Catch ex As Exception

        End Try
    End Sub
End Class