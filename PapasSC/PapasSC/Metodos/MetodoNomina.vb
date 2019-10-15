Imports System.Data.SqlClient

Public Class MetodoNomina
    Inherits conexionDB
    Dim cmd As New SqlCommand
    Public adaptador As SqlDataAdapter
    Public dt As DataTable

    Public Function InsertarNomina(ByVal dataNomina As List(Of String))
        Try
            conectar()
            cmd = New SqlCommand("sp_insertarNomina")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@fechaPago", dataNomina.ElementAt(0))
            cmd.Parameters.AddWithValue("@total", dataNomina.ElementAt(1))
            cmd.Parameters.AddWithValue("@diasTrabajados", dataNomina.ElementAt(2))
            cmd.Parameters.AddWithValue("@horasTrabajados", dataNomina.ElementAt(3))
            cmd.Parameters.AddWithValue("@formaPago", dataNomina.ElementAt(4))
            cmd.Parameters.AddWithValue("@NombreEm", dataNomina.ElementAt(5))
            cmd.Parameters.AddWithValue("@totalPer", dataNomina.ElementAt(6))
            cmd.Parameters.AddWithValue("@totalDedu", dataNomina.ElementAt(7))
            cmd.Parameters.AddWithValue("@fechaInicio", dataNomina.ElementAt(8))
            cmd.Parameters.AddWithValue("@fechaFin", dataNomina.ElementAt(9))
            cmd.Parameters.AddWithValue("@faltas", dataNomina.ElementAt(10))

            If cmd.ExecuteNonQuery Then
                MsgBox("Se agrego corrtamente la nomina del empleado" + dataNomina(5))
                Return True
            End If

        Catch ex As Exception

        End Try

    End Function

End Class
