Imports System.Data.SqlClient

Public Class MetodoReportesVentas
    Inherits conexionDB
    Dim cmd As New SqlCommand
    Public adaptador As SqlDataAdapter
    Public dt As DataTable

    Public Sub Caja(ByVal nom As ComboBox)
        Try
            conectar()
            cmd = New SqlCommand("sp_MostrarCaja")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataSet
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)

                nom.DataSource = dt.Tables(0)
                nom.DisplayMember = "nombre"
                nom.SelectedIndex = 0

            End If

            desconectar()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Sucursal(ByVal nom As ComboBox)
        Try
            conectar()
            cmd = New SqlCommand("sp_Sucursal")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataSet
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)

                nom.DataSource = dt.Tables(0)
                nom.DisplayMember = "nombre"
                nom.SelectedIndex = 0

            End If

            desconectar()
        Catch ex As Exception

        End Try
    End Sub

    Public Function Empleados()


        Try
            conectar()
            cmd = New SqlCommand("sp_Empleados")
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

    Public Function Cliente()
        Try
            conectar()
            cmd = New SqlCommand("sp_Clientes")
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

    Public Sub BuscarNombre(ByVal busEm As String, ByVal table As DataGridView)
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

    Public Sub BuscarNombreClientes(ByVal busCli As String, ByVal tableCli As DataGridView)
        Try
            conectar()
            cmd = New SqlCommand("sp_buscarNombreCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@nombre", busCli)
            cmd.Connection = conn
            If cmd.ExecuteNonQuery Then
                Dim da As New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                tableCli.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




End Class
