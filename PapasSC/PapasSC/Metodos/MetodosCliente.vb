Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.OleDb
Public Class MetodosCliente
    Inherits conexionDB

    Public Sub consulta_general()
        conectar()
        Dim comando = New SqlCommand("Select * from cliente")
        comando.Connection = conn
        Dim reader As IDataReader = comando.ExecuteReader()
        While 


    End Sub

End Class
