﻿Public Class MenuVentas
    Public nombre As String
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub
    Dim abierta As Boolean = True
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If abierta Then
            IniciarCaja.user = nombre
            IniciarCaja.vn = True
            IniciarCaja.Show()
        Else
            NuevaVenta.Show()
            NuevaVenta.user = nombre
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Precios_por_defecto.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim logCaja As New IniciarCaja
        IniciarCaja.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Reporte_de_ventas.Show()
    End Sub

    Private Sub MenuVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nombre = Form2.NombreUsuario.Text
    End Sub
End Class