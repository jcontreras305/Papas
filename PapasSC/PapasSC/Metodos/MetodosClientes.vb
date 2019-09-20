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
            cmd.Parameters.AddWithValue("@estatus", datosCliente.ElementAt(4))
            cmd.Parameters.AddWithValue("@nombreContacto", datosCliente.ElementAt(5))
            cmd.Parameters.AddWithValue("@genero", datosCliente.ElementAt(6))
            cmd.Parameters.AddWithValue("@direccion", datosCliente.ElementAt(7))
            cmd.Parameters.AddWithValue("@telefono", datosCliente.ElementAt(8))
            cmd.Parameters.AddWithValue("@email", datosCliente.ElementAt(9))
            cmd.Parameters.AddWithValue("@estado", datosCliente.ElementAt(10))
            cmd.Parameters.AddWithValue("@municipio", datosCliente.ElementAt(11))
            cmd.Parameters.AddWithValue("@codigoPostal", datosCliente.ElementAt(12))
            Dim limcredi As String = Replace(datosCliente.ElementAt(13), ",", ".")
            cmd.Parameters.AddWithValue("@limiteCredito", limcredi)
            cmd.Parameters.AddWithValue("@diasCredito", datosCliente.ElementAt(14))
            cmd.Parameters.AddWithValue("@tel2", datosCliente.ElementAt(15))
            cmd.Parameters.AddWithValue("@email2", datosCliente.ElementAt(16))
            cmd.Parameters.AddWithValue("@dir2", datosCliente.ElementAt(17))
            MsgBox("El cliente " + datosCliente.ElementAt(0) + " con rfc " + datosCliente.ElementAt(1) + " o razon social " + datosCliente.ElementAt(2))
            If cmd.ExecuteNonQuery Then
                MsgBox("Guardado Con exito")
            End If
            desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub actualizar_cliente(ByVal datosNuevosClientes As List(Of String))
        Try
            conectar()
            Dim cmd = New SqlCommand("sp_actualizar_nuevoCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            cmd.Parameters.Add("@idCliente", SqlDbType.VarChar, 36).Value = datosNuevosClientes.ElementAt(0)
            cmd.Parameters.Add("@nombreCliente", SqlDbType.VarChar, 80).Value = datosNuevosClientes.ElementAt(1)
            cmd.Parameters.Add("@RFC", SqlDbType.VarChar, 13).Value = datosNuevosClientes.ElementAt(2)
            cmd.Parameters.Add("@razonSocial", SqlDbType.VarChar, 100).Value = datosNuevosClientes.ElementAt(3)
            cmd.Parameters.Add("@tipoPersona", SqlDbType.VarChar, 10).Value = datosNuevosClientes.ElementAt(4)
            cmd.Parameters.Add("@estatus", SqlDbType.Char, 1).Value = datosNuevosClientes.ElementAt(5)
            cmd.Parameters.Add("@nombreContacto", SqlDbType.VarChar, 100).Value = datosNuevosClientes.ElementAt(6)
            cmd.Parameters.Add("@genero", SqlDbType.Char, 1).Value = datosNuevosClientes.ElementAt(7)
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = datosNuevosClientes.ElementAt(8)
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 12).Value = datosNuevosClientes.ElementAt(9)
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = datosNuevosClientes.ElementAt(10)
            cmd.Parameters.Add("@estado", SqlDbType.VarChar, 50).Value = datosNuevosClientes.ElementAt(11)
            cmd.Parameters.Add("@municipio", SqlDbType.VarChar, 50).Value = datosNuevosClientes.ElementAt(12)
            cmd.Parameters.Add("@codigoPostal", SqlDbType.VarChar, 5).Value = datosNuevosClientes.ElementAt(13)
            Dim limcredi As String = Replace(datosNuevosClientes.ElementAt(14), ",", ".")
            cmd.Parameters.Add("@limiteCredito", SqlDbType.Float).Value = limcredi
            cmd.Parameters.Add("@diasCredito", SqlDbType.Int).Value = datosNuevosClientes.ElementAt(15)
            cmd.Parameters.Add("@tel2", SqlDbType.VarChar, 12).Value = datosNuevosClientes.ElementAt(16)
            cmd.Parameters.Add("@email2", SqlDbType.VarChar, 100).Value = datosNuevosClientes.ElementAt(17)
            cmd.Parameters.Add("@dir2", SqlDbType.VarChar, 100).Value = datosNuevosClientes.ElementAt(18)
            cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output
            'MsgBox("El cliente " + datosNuevosClientes.ElementAt(1) + " con rfc " + datosNuevosClientes.ElementAt(2) + " o razon social " + datosNuevosClientes.ElementAt(3))
            If cmd.ExecuteNonQuery Then
                Dim resultado As String = cmd.Parameters("@msg").Value
                MsgBox(resultado)
            End If
            desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub eliminar_Cliente(ByVal idCliente As String, ByVal nombreCliente As String)
        Try
            conectar()
            Dim cmd = New SqlCommand("sp_Eliminar_Cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            cmd.Parameters.AddWithValue("@idCliente", idCliente)
            If cmd.ExecuteNonQuery Then
                MsgBox("Se ha eliminado el cliente " + nombreCliente)
            End If
            desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
