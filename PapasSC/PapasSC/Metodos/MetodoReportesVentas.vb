Imports System.Data.SqlClient

Public Class MetodoReportesVentas
    Inherits conexionDB
    Dim cmd As New SqlCommand
    Public adaptador As SqlDataAdapter
    Public dt As DataTable

    Public Sub Caja(ByVal nom As ComboBox)
        Try
            conectar()
            cmd = New SqlCommand("sp_MostrarCaja")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataSet
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)

                nom.DataSource = dt.Tables(0)
                nom.DisplayMember = "nombre"
                nom.SelectedIndex = 0

            End If

            desconectar()
        Catch ex As Exception

        End Try
    End Sub


End Class
