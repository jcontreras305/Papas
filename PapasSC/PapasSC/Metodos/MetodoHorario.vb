Imports System.Data.SqlClient

Public Class MetodoHorario
    Inherits conexionDB
    Dim cmd As New SqlCommand
    Public adaptador As SqlDataAdapter
    Public dt As DataTable


    'Public Function insertarHorario(ByVal dataHorario() As String, horaInicio As Date, horafin As Date)
    '    Try
    '        conectar()
    '        cmd = New SqlCommand("sp_insertarHorario")
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Connection = conn

    '        cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 30).Value = dataHorario.ElementAt(0)
    '        cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 200).Value = dataHorario.ElementAt(1)
    '        cmd.Parameters.AddWithValue("@HoraInicio", horaInicio)
    '        cmd.Parameters.AddWithValue("@HoraFin", horafin)


    '        If cmd.ExecuteNonQuery Then
    '            MsgBox("Se agrego correctamente el horario")
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        desconectar()
    '        MsgBox(ex.Message)
    '        Return False
    '    End Try
    'End Function

    Public Sub seleccionarHora(ByVal textonom As TextBox, ByVal des As RichTextBox, ByVal hoi As TextBox, ByVal hofi As TextBox)
        Try
            conectar()
            cmd = New SqlCommand("sp_SeleccionarHorario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            'cmd.Parameters.AddWithValue("@nombre", AgregarEmpleados.cboEmHorario.SelectedItem)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataSet
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Dim nom As SqlDataReader = cmd.ExecuteReader()

                If nom.Read() Then
                    textonom.Text = nom.Item("nombre").ToString()
                    des.Text = nom.Item("descripcion").ToString()
                    hoi.Text = nom.Item("horaInicio").ToString()
                    hofi.Text = nom.Item("horaFin").ToString()


                End If
            End If
            desconectar()
        Catch ex As Exception

        End Try
    End Sub

End Class
