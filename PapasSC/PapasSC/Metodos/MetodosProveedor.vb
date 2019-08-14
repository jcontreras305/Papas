Imports System.Data.SqlClient

Public Class MetodosProveedor
    Inherits conexionDB
    Dim cmd As New SqlCommand
    Public adaptador As SqlDataAdapter
    Public dt As DataTable

    Public Function ConsultarPro() As DataTable
        Try
            conectar()
            cmd = New SqlCommand("sp_Consultar_Proveedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Function



    Public Function BuscarProveedorNom(no As String)
        Try
            conectar()
            cmd = New SqlCommand("sp_Bus_ProveedorNombre")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@nombrePro", no)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function BuscarProveedorCiu(noCiu As String)
        Try
            conectar()
            cmd = New SqlCommand("sp_Bus_ProveedorCiudad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@nombreCiu", noCiu)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
