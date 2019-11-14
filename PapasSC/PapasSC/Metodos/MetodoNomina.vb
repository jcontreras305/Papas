Imports System.Data.SqlClient

Public Class MetodoNomina
    Inherits conexionDB
    Dim cmd As New SqlCommand
    Public adaptador As SqlDataAdapter
    Public dt As DataTable

    Public Sub selecccionaRPago(ByVal comPago As ComboBox)
        Try
            conectar()
            cmd = New SqlCommand("sp_seleccionar_FormaPago")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataSet
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)

                comPago.DataSource = dt.Tables(0)
                comPago.DisplayMember = "tipo"
                comPago.SelectedIndex = 0

            End If

            desconectar()
        Catch ex As Exception

        End Try
    End Sub

    Public Function InsertarNomina(ByVal fechapa As Date, ByVal dataNomina As List(Of String), ByVal feini As Date, ByVal fefin As Date, ByVal totalP As TextBox, ByVal totalD As TextBox,
                                   ByVal total As TextBox)
        Try
            conectar()
            cmd = New SqlCommand("sp_insertarNomina")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            'cmd.Parameters.Add("", SqlDbType.VarChar, 100).Value = fecha
            cmd.Parameters.AddWithValue("@fechaPago", fechapa)

            Dim diasTra As String = Replace(dataNomina.ElementAt(0), ",", ".")
            cmd.Parameters.AddWithValue("@diasTrabajados", diasTra)

            Dim horasTra As String = Replace(dataNomina.ElementAt(1), ",", ".")
            cmd.Parameters.AddWithValue("@sueldoDiario", horasTra)

            cmd.Parameters.AddWithValue("@formaPago", dataNomina.ElementAt(2))

            cmd.Parameters.AddWithValue("@NombreEm", dataNomina.ElementAt(3))

            Dim faltas As String = Replace(dataNomina.ElementAt(4), ",", ".")
            cmd.Parameters.AddWithValue("@faltas", faltas)

            cmd.Parameters.AddWithValue("@fechaInicio", feini)

            cmd.Parameters.AddWithValue("@fechaFin", fefin)

            Dim rd As SqlDataReader
            rd = cmd.ExecuteReader


            If rd.Read() Then
                totalD.Text = rd.Item("totalPer").ToString()
                totalP.Text = rd.Item("totalDedu").ToString()
                total.Text = rd.Item("total").ToString()
            End If

            MsgBox("Se calculo corretamente la nomina del empleado " + dataNomina(3))
            Return True

        Catch ex As Exception
            desconectar()
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function ConsultarEmpleados()
        Try
            conectar()
            cmd = New SqlCommand("sp_MostrarEmpleadosNomina")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub BuscarNombreNomina(ByVal busEm As String, ByVal table As DataGridView)
        Try
            conectar()
            cmd = New SqlCommand("sp_BuscarNombreEmpleadoNomina")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@nombre", busEm)
            cmd.Connection = conn
            If cmd.ExecuteNonQuery Then
                Dim da As New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                table.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


End Class
