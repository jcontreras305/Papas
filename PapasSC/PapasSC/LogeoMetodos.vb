Imports System.Data.SqlClient
Public Class LogeoMetodos
    Inherits conexionDB
    Public usuario As String
    Public nombre As String
    Public tipoUsuario As String

    Public Function conect() As Boolean
        conectar()
        Return True
    End Function

    Public Function validarUsuario(user As String, pass As String) As Boolean

        conectar()

        Dim comando = New SqlCommand("sp_licencias_usuarios")
        comando.Connection = conn
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@nombre", user)
        comando.Parameters.AddWithValue("@contrasenia", pass)

        If comando.ExecuteNonQuery Then
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(comando)
            da.Fill(dt)
            If dt.Rows.Count() = 1 Then
                tipoUsuario = dt.Rows(0).Item(0).ToString
                usuario = dt.Rows(0).Item(1).ToString
                nombre = dt.Rows(0).Item(2).ToString
                MsgBox("Hola " + nombre + " inicio de sesion con " + usuario)
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
End Class
