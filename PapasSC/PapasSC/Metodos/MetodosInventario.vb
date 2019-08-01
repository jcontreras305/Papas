Imports System.Data.SqlClient

Public Class MetodosInventario
    Inherits conexionDB

    Public Sub buscarBodegas(ByVal cmbBodega As ComboBox)
        Try
            conectar()
            Dim lista As New List(Of String)
            Dim comando = New SqlCommand("sp_selectBodega")
            comando.Connection = conn
            comando.CommandType = CommandType.StoredProcedure
            Dim reader = comando.ExecuteReader()
            While reader.Read
                lista.Add(CStr(reader("bodega")))
            End While
            cmbBodega.DataSource = lista
        Catch ex As Exception

        End Try

    End Sub

End Class
