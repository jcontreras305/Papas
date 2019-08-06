Imports System.Data.SqlClient

Public Class MetodosClientes
    Inherits conexionDB
    Dim cmd As New SqlCommand
    Public adaptador As SqlDataAdapter
    Public dt As DataTable

    Public Sub insertar_Cliente(ByVal datosCliente As List(Of String))
        Try
            conectar()
            Dim cmd = New SqlCommand("sp_insertar_nuevoCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            cmd.Parameters.AddWithValue("@nombreCliente", datosCliente.ElementAt(0))
            cmd.Parameters.AddWithValue("@RFC", datosCliente.ElementAt(1))
            cmd.Parameters.AddWithValue("@razonSocial", datosCliente.ElementAt(2))
            cmd.Parameters.AddWithValue("@tipoPersona", datosCliente.ElementAt(3))
            cmd.Parameters.AddWithValue("@nombreContacto", datosCliente.ElementAt(4))
            cmd.Parameters.AddWithValue("@genero", datosCliente.ElementAt(5))
            cmd.Parameters.AddWithValue("@direccion", datosCliente.ElementAt(6))
            cmd.Parameters.AddWithValue("@telefono", datosCliente.ElementAt(7))
            cmd.Parameters.AddWithValue("@email", datosCliente.ElementAt(8))
            cmd.Parameters.AddWithValue("@estado", datosCliente.ElementAt(9))
            cmd.Parameters.AddWithValue("@municipio", datosCliente.ElementAt(10))
            cmd.Parameters.AddWithValue("@codigoPostal", datosCliente.ElementAt(11))
            Dim limcredi As String = Replace(datosCliente.ElementAt(12), ",", ".")
            cmd.Parameters.AddWithValue("@limiteCredito", limcredi)
            cmd.Parameters.AddWithValue("@diasCredito", datosCliente.ElementAt(13))
            MsgBox("El cliente " + datosCliente.ElementAt(0) + " con rfc " + datosCliente.ElementAt(1) + " o razon social " + datosCliente.ElementAt(2))
            If cmd.ExecuteNonQuery Then
                MsgBox("Guardado Con exito")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
