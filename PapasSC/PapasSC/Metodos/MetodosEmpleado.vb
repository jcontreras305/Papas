Imports System.Data.SqlClient

Public Class MetodosEmpleado
    Inherits conexionDB
    Dim cmd As New SqlCommand
    Public adaptador As SqlDataAdapter
    Public dt As DataTable

    Public Function Consultar() As DataTable
        Try
            conectar()
            cmd = New SqlCommand("sp_Consultar_Empleado")
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

    Public Function BuscarEm(no As String)
        Try
            conectar()
            cmd = New SqlCommand("sp_Bus_Empleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@nombreEm", no)
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

    Public Function BuscarEmBo(bo As String)
        Try
            conectar()
            cmd = New SqlCommand("sp_BuscarBodega_Empleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@nombreBo", bo)
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




    Public Function BuscarEmPu(pu As String)
        Try
            conectar()
            cmd = New SqlCommand("sp_BuscarPuesto_Empleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@nombrePu", pu)
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

    Public Function BuscarEmSa(sa As Double)
        Try
            conectar()
            cmd = New SqlCommand("sp_Bus_Empleado4")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            Dim salari As String = CStr(sa)
            salari = salari.Replace(",", ".")
            cmd.Parameters.AddWithValue("@Salario", salari)
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

    Public Sub SelecionarBode(ByVal comBode As ComboBox)
        Try
            conectar()
            cmd = New SqlCommand("sp_Sele_Bodega")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataSet
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)

                comBode.DataSource = dt.Tables(0)
                comBode.DisplayMember = "nombre"
                comBode.SelectedIndex = 0

            End If

            desconectar()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub SelecionarHora(ByVal comHor As ComboBox)
        Try
            conectar()
            cmd = New SqlCommand("sp_Sele_Horario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataSet
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)

                comHor.DataSource = dt.Tables(0)
                comHor.DisplayMember = "nombre"
                comHor.SelectedIndex = 0

            End If

            desconectar()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub SelecionarPues(ByVal comPus As ComboBox)
        Try
            conectar()
            cmd = New SqlCommand("sp_select_Puesto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataSet
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)

                comPus.DataSource = dt.Tables(0)
                comPus.DisplayMember = "nombre"
                comPus.SelectedIndex = 0

            End If

            desconectar()
        Catch ex As Exception

        End Try
    End Sub


    Public Function InsertarEmple(ByVal datosEmple As List(Of String))

        Try
            conectar()
            cmd = New SqlCommand("sp_Insertar_Empleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@nombre", datosEmple.ElementAt(0))
            cmd.Parameters.AddWithValue("@sexo", datosEmple.ElementAt(1))
            Dim sala As String = Replace(datosEmple.ElementAt(2), ",", ".")
            cmd.Parameters.AddWithValue("@salario", sala)
            cmd.Parameters.AddWithValue("@telefono", datosEmple.ElementAt(3))
            cmd.Parameters.AddWithValue("@direccion", datosEmple.ElementAt(4))
            cmd.Parameters.AddWithValue("@estatus", datosEmple.ElementAt(5))
            cmd.Parameters.AddWithValue("@NomBodega", datosEmple.ElementAt(6))
            cmd.Parameters.AddWithValue("@EnSaHorario", datosEmple.ElementAt(7))
            cmd.Parameters.AddWithValue("@NomPuesto", datosEmple.ElementAt(8))

            If cmd.ExecuteNonQuery Then
                MsgBox("Se agrego correctamente " + datosEmple(0))
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            desconectar()
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Public Sub EliminarEmple(ByVal datosEmpleEli() As String)
        Try
            conectar()
            cmd = New SqlCommand("sp_EliminarEmple")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@nombre", datosEmpleEli(0))
            cmd.Parameters.AddWithValue("@sexo", datosEmpleEli(1))
            Dim sala As String = Replace(datosEmpleEli.ElementAt(2), ",", ".")
            cmd.Parameters.AddWithValue("@salario", sala)
            cmd.Parameters.AddWithValue("@tel", datosEmpleEli(3))
            cmd.Parameters.AddWithValue("@direccion", datosEmpleEli(4))
            cmd.Parameters.AddWithValue("@NomBodega", datosEmpleEli(5))
            cmd.Parameters.AddWithValue("@EnSaHorario", datosEmpleEli(6))
            cmd.Parameters.AddWithValue("@NomPuesto", datosEmpleEli(7))

            If cmd.ExecuteNonQuery Then
                MsgBox("Se ha eliminado el empleado llamado " + datosEmpleEli(0))

            End If
            desconectar()

        Catch ex As Exception
            desconectar()
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Sub ActualizarEmpleado(ByVal datosEmpleAct As List(Of String))
        Try
            conectar()
            cmd = New SqlCommand("sp_Actualizar_EmpleadoNuevo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 80).Value = datosEmpleAct.ElementAt(0)
            cmd.Parameters.Add("@sexo", SqlDbType.Char, 1).Value = datosEmpleAct.ElementAt(1)
            Dim salario As String = Replace(datosEmpleAct.ElementAt(2), ",", ".")
            cmd.Parameters.Add("@salario", SqlDbType.Float).Value = salario
            cmd.Parameters.Add("@tel", SqlDbType.Char, 12).Value = datosEmpleAct.ElementAt(3)
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = datosEmpleAct.ElementAt(4)
            cmd.Parameters.Add("@estatus", SqlDbType.Char, 1).Value = datosEmpleAct.ElementAt(5)
            cmd.Parameters.Add("@NomBodega", SqlDbType.VarChar, 30).Value = datosEmpleAct.ElementAt(6)
            cmd.Parameters.Add("@EnSaHorario", SqlDbType.VarChar, 30).Value = datosEmpleAct.ElementAt(7)
            cmd.Parameters.Add("@NomPuesto", SqlDbType.VarChar, 80).Value = datosEmpleAct.ElementAt(8)
            cmd.Parameters.Add("@NomBodegaN", SqlDbType.VarChar, 30).Value = datosEmpleAct.ElementAt(6)
            cmd.Parameters.Add("@EnSaHorarioN", SqlDbType.VarChar, 30).Value = datosEmpleAct.ElementAt(7)
            cmd.Parameters.Add("@NomPuestoN", SqlDbType.VarChar, 80).Value = datosEmpleAct.ElementAt(8)

            If cmd.ExecuteNonQuery Then
                MsgBox("Se actualizo correctamente los datos del empleado " + datosEmpleAct(0))
            End If
            desconectar()
        Catch ex As Exception
            desconectar()
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
