Imports System.Data.SqlClient

Public Class MetodosProductos
    Inherits conexionDB
    Dim cmd As New SqlCommand
    Public adaptador As SqlDataAdapter

    Public Function InsertarProducto(ver As String, cla As String)
        Try
            conectar()
            cmd = New SqlCommand("sp_Insertar_Producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@version", ver)
            cmd.Parameters.AddWithValue("@clave", cla)
            If cmd.ExecuteNonQuery Then
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Return Nothing
        End Try

    End Function

End Class
