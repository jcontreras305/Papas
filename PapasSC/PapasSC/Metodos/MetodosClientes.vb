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
            cmd.Parameters.AddWithValue("@idCliente", datosNuevosClientes.ElementAt(0))
            cmd.Parameters.AddWithValue("@nombreCliente", datosNuevosClientes.ElementAt(1))
            cmd.Parameters.AddWithValue("@RFC", datosNuevosClientes.ElementAt(2))
            cmd.Parameters.AddWithValue("@razonSocial", datosNuevosClientes.ElementAt(3))
            cmd.Parameters.AddWithValue("@tipoPersona", datosNuevosClientes.ElementAt(4))
            cmd.Parameters.AddWithValue("@nombreContacto", datosNuevosClientes.ElementAt(5))
            cmd.Parameters.AddWithValue("@genero", datosNuevosClientes.ElementAt(6))
            cmd.Parameters.AddWithValue("@direccion", datosNuevosClientes.ElementAt(7))
            cmd.Parameters.AddWithValue("@telefono", datosNuevosClientes.ElementAt(8))
            cmd.Parameters.AddWithValue("@email", datosNuevosClientes.ElementAt(9))
            cmd.Parameters.AddWithValue("@estado", datosNuevosClientes.ElementAt(10))
            cmd.Parameters.AddWithValue("@municipio", datosNuevosClientes.ElementAt(11))
            cmd.Parameters.AddWithValue("@codigoPostal", datosNuevosClientes.ElementAt(12))
            Dim limcredi As String = Replace(datosNuevosClientes.ElementAt(13), ",", ".")
            cmd.Parameters.AddWithValue("@limiteCredito", limcredi)
            cmd.Parameters.AddWithValue("@diasCredito", datosNuevosClientes.ElementAt(14))
            MsgBox("El cliente " + datosNuevosClientes.ElementAt(0) + " con rfc " + datosNuevosClientes.ElementAt(1) + " o razon social " + datosNuevosClientes.ElementAt(2))
            If cmd.ExecuteNonQuery Then
                MsgBox("Guardado Con exito")
            End If
            desconectar()
        Catch ex As Exception

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
