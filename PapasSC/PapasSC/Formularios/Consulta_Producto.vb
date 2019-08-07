﻿Public Class Consulta_Producto
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Registro_productos.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Actualizar_Producto.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim nombre As String = Convert.ToString(TablaProductos.CurrentRow.Cells(1).Value)
            Dim id As String = Convert.ToString(TablaProductos.CurrentRow.Cells(0).Value)
            Dim MTCLI As New MetodosCliente

            If MessageBox.Show("¿Desea ELIMINAR Producto", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MTCLI.eliminaCliente(id, nombre)
            End If
        Catch

        End Try
    End Sub

    Private Sub Consulta_Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MTPR As New MetodosProducto
        MTPR.llenarDatagridview(TablaProductos)

    End Sub
End Class