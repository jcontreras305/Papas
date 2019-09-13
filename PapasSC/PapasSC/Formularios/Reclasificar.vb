﻿Public Class Reclasificar
    Dim mtd As New MetodosReclasificacion
    Dim total As Double = 0
    Dim bodega As String
    Dim flag As Boolean = False

    Private Sub Reclasificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtd.llenar_ComoboBodega(cmbBodega)
        flag = True
        sprKilosMenos.DecimalPlaces = 2
        sprKilosMenos.Increment = 0.5
        sprKilosMenos.ThousandsSeparator = True

        sprKilosMas.DecimalPlaces = 2
        sprKilosMas.Increment = 0.5
        sprKilosMas.ThousandsSeparator = True
        lblCantidad.Text = "Existencia"
    End Sub

    Private Sub cmbBodega_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBodega.SelectedIndexChanged
        If flag = True Then
            If tblCambios.Rows(0).Cells(0).Value <> String.Empty Then
                If MessageBox.Show("Si acepta se borraran los cambios hechos", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = 1 Then
                    tblCambios.Rows.Clear()
                    txtProducto.Text = ""
                    sprKilosMas.Value = 0
                    sprKilosMenos.Value = 0
                    lblCantidad.Text = "Existencia"

                    mtd.llenar_TblBodega(tblProductosExistencias, cmbBodega.Text)
                    colorear_Filas(tblProductosExistencias)
                    mtd.cargar_prodcutos_Bodega(cmbBodega.Text, cmbProdcutos)
                End If
            Else
                mtd.llenar_TblBodega(tblProductosExistencias, cmbBodega.Text)
                colorear_Filas(tblProductosExistencias)
                mtd.cargar_prodcutos_Bodega(cmbBodega.Text, cmbProdcutos)
                bodega = cmbProdcutos.Text
            End If
        End If
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Try
            mtd.busqueda_producto(txtBusqueda.Text, cmbBodega.Text, tblProductosExistencias)
            colorear_Filas(tblProductosExistencias)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tblProductosExistencias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblProductosExistencias.CellDoubleClick
        Try
            Dim datos(3) As String
            Dim cont As Int16 = 0
            For Each item As DataGridViewCell In tblProductosExistencias.SelectedCells
                datos(cont) = item.Value
                cont += 1
            Next
            lblCantidad.Text = "Kg " + datos(3)
            txtProducto.Text = datos(1)
            sprKilosMenos.Maximum = CDbl(datos(3))
            sprKilosMas.Maximum = CDbl(datos(3))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function colorear_Filas(tabla As DataGridView) As Boolean
        For Each row As DataGridViewRow In tabla.Rows
            Dim cantidad As Integer = row.Cells(3).Value
            If cantidad >= 100 Then
                row.DefaultCellStyle.BackColor = Color.Green

            ElseIf cantidad < 100 And cantidad > 50 Then
                row.DefaultCellStyle.BackColor = Color.Yellow
            Else
                row.DefaultCellStyle.BackColor = Color.Red
            End If
        Next
        Return True
    End Function

    Private Function item_combo(ByVal nombreItem As String) As Boolean
        If nombreItem.Equals(txtProducto) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub cmbProdcutos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProdcutos.SelectedIndexChanged
        If cmbBodega.Text.Equals(txtProducto) Then
            MsgBox("No puedes escoger el mismo prodcuto")
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If (total + sprKilosMas.Value) <= sprKilosMenos.Value Then
                Dim cont As Int16 = tblCambios.Rows.Count - 1
                tblCambios.Rows.Add()
                tblCambios.Rows(cont).Cells(0).Value = txtProducto.Text
                tblCambios.Rows(cont).Cells(1).Value = cmbProdcutos.Text
                tblCambios.Rows(cont).Cells(2).Value = sprKilosMas.Value
                total = total + sprKilosMas.Value
            Else
                MsgBox("El límite especificado a ser reclasificado fué exedido")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            For Each row As DataGridViewRow In tblCambios.Rows
                If Convert.ToBoolean(row.Cells("Eliminar").Value) = True Then
                    tblCambios.Rows.Remove(row)
                End If
            Next
            total = 0
            For Each row As DataGridViewRow In tblCambios.Rows
                total = total + Convert.ToDouble(row.Cells("Cantidad").Value)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Try
            For Each row As DataGridViewRow In tblCambios.Rows
                Dim producto1 As String = row.Cells(0).Value
                Dim prodcuto2 As String = row.Cells(1).Value
                Dim cantidad As String = row.Cells(2).Value
                cantidad = cantidad.Replace(",", ".")
                mtd.insertar_reubicaciones(bodega, producto1, prodcuto2, cantidad)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class