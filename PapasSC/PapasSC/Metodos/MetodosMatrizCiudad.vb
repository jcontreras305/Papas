Imports System.Data.SqlClient

Public Class MetodosMatrizCiudad
    Inherits conexionDB

    Public Sub seleccionar_Matriz(ByVal tablaMatriz As DataGridView)
        Try
            conectar()
            Dim cmd = New SqlCommand("sp_select_Matriz")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                tablaMatriz.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
