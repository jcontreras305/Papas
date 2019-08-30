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
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

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
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function BuscarEmBo(bo As String)
        Try
            conectar()
            cmd = New SqlCommand("sp_Bus_Empleado1")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@nombreBo", bo)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function




    Public Function BuscarEmPu(pu As String)
        Try
            conectar()
            cmd = New SqlCommand("sp_Bus_Empleado2")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@nombrePu", pu)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
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


    Public Function InsertarEmple(ByVal nom As String, ByVal se As String,
        ByVal sa As Double, ByVal tel As String, ByVal dir As String,
        ByVal NoB As String, ByVal ho As String, ByVal Npu As String) As Boolean

        Try
            conectar()
            cmd = New SqlCommand("sp_Insertar_Empleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@nombre", nom)
            cmd.Parameters.AddWithValue("@sexo", se)
            Dim salari As String = CStr(sa)
            salari = salari.Replace(",", ".")
            cmd.Parameters.AddWithValue("@salario", salari)
            cmd.Parameters.AddWithValue("@telefono", tel)
            cmd.Parameters.AddWithValue("@direccion", dir)
            cmd.Parameters.AddWithValue("@NomBodega", NoB)
            cmd.Parameters.AddWithValue("@EnSaHorario", ho)
            cmd.Parameters.AddWithValue("@NomPuesto", Npu)

            If cmd.ExecuteNonQuery Then
                MsgBox("Se agrego correctamente " + nom)
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


    Public Sub EliminarEmple(ByVal datosEmple() As String)
        Try
            conectar()
            cmd = New SqlCommand("sp_EliminarEmple")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@nombre", datosEmple(0))
            cmd.Parameters.AddWithValue("@sexo", datosEmple(1))
            Dim sala As String = Replace(datosEmple.ElementAt(2), ",", ".")
            cmd.Parameters.AddWithValue("@salario", sala)
            cmd.Parameters.AddWithValue("@tel", datosEmple(3))
            cmd.Parameters.AddWithValue("@direccion", datosEmple(4))
            cmd.Parameters.AddWithValue("@NomBodega", datosEmple(5))
            cmd.Parameters.AddWithValue("@EnSaHorario", datosEmple(6))
            cmd.Parameters.AddWithValue("@NomPuesto", datosEmple(7))

            If cmd.ExecuteNonQuery Then
                MsgBox("Se ha eliminado el empleado llamado " + datosEmple(0))

            End If
            desconectar()

        Catch ex As Exception
            desconectar()
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Sub ActualizarEmpleado(ByVal datosV() As String, ByVal datosN() As String, ByVal nombre As String, ByVal se As String)
        Try
            conectar()
            cmd = New SqlCommand("sp_Actualizar_Empleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@sexo", se)
            Dim sala As String = Replace(datosN.ElementAt(0), ",", ".")
            cmd.Parameters.AddWithValue("@salarioN", sala)
            cmd.Parameters.AddWithValue("@telN", datosN(1))
            cmd.Parameters.AddWithValue("@direccionN", datosN(2))
            cmd.Parameters.AddWithValue("@NomBodegaN", datosN(3))
            cmd.Parameters.AddWithValue("@EnSaHorarioN", datosN(4))
            cmd.Parameters.AddWithValue("@NomPuestoN", datosN(5))
            Dim sala1 As String = Replace(datosV.ElementAt(0), ",", ".")
            cmd.Parameters.AddWithValue("@salario", sala1)
            cmd.Parameters.AddWithValue("@tel", datosV(1))
            cmd.Parameters.AddWithValue("@direccion", datosV(2))
            cmd.Parameters.AddWithValue("@NomBodega", datosV(3))
            cmd.Parameters.AddWithValue("@EnSaHorario", datosV(4))
            cmd.Parameters.AddWithValue("@NomPuesto", datosV(5))

            If cmd.ExecuteNonQuery Then
                MsgBox("Se actualizo correctamente los datos del empleado " + nombre)
            End If
            desconectar()
        Catch ex As Exception
            desconectar()
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
