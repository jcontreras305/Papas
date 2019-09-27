
Imports System.Data.SqlClient

Public Class Metodos_PreciosXdefecto
    Inherits conexionDB
    Dim cmd As New SqlCommand
    Public adaptador As SqlDataAdapter
    Public dt As DataTable

    Public Function Consultar_Precios()
        Try
            conectar()
            cmd = New SqlCommand("sp_consultar_PreciosPorDefecto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Buscar_Precios(nom As String)
        Try
            conectar()
            cmd = New SqlCommand("sp_Buscar_PreciosXdefecto_version")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@nombre", nom)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Buscar_PreciosCla(cla As String)
        Try
            conectar()
            cmd = New SqlCommand("sp_Buscar_PreciosXdefecto_clave")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@clave", cla)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub ActualizarPrecio(ByVal precio() As String)
        Try
            conectar()
            cmd = New SqlCommand("sp_insertarPre")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.Add("@version", SqlDbType.VarChar, 15).Value = precio.ElementAt(0)
            cmd.Parameters.Add("@clave", SqlDbType.VarChar, 10).Value = precio.ElementAt(1)
            Dim prePro As String = Replace(precio.ElementAt(2), ",", ".")
            cmd.Parameters.Add("@precio", SqlDbType.Float).Value = prePro

            If cmd.ExecuteNonQuery Then
                MsgBox("Se actualizo correctamente el precio")
            End If
            desconectar()
        Catch ex As Exception
            desconectar()
            MsgBox(ex.Message)
        End Try

    End Sub


End Class
