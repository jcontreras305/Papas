Imports System.Data.SqlClient
Public Class LogeoMetodos
    Inherits conexionDB

    Public Function conect() As Boolean
        conectar()
        Return True
    End Function

    Public Function validarUsuario(user As String, pass As String) As Boolean
        conectar()
        Dim comando = New SqlCommand("sp_licencias_usuarios")
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@nombre", user)
        comando.Parameters.AddWithValue("@contrasenia", pass)

        If comando.ExecuteNonQuery Then

        End If

        Return True
    End Function
End Class
