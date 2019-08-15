Imports System.Data.SqlClient

Public Class MetodosProveedor
    Inherits conexionDB
    Dim cmd As New SqlCommand
    Public adaptador As SqlDataAdapter
    Public dt As DataTable


    'Metodo para consultar los proveedores
    Public Function ConsultarPro() As DataTable
        Try
            conectar()
            cmd = New SqlCommand("sp_Consultar_Proveedor")
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

    'Metodo para buscar un proveedor por el nombre

    Public Function BuscarProveedorNom(no As String)
        Try
            conectar()
            cmd = New SqlCommand("sp_Bus_ProveedorNombre")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@nombrePro", no)
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

    'Metodo para bucar el nombre de la ciudad donde se encuentra el proveedor
    Public Function BuscarProveedorCiu(ByVal noCiu As String)
        Try
            conectar()
            cmd = New SqlCommand("sp_Bus_ProveedorCiudad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@nombreCiu", noCiu)
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

    Public Sub SelecionarCiu(ByVal comboCiuPro As ComboBox)
        Try
            conectar()
            cmd = New SqlCommand("sp_select_Ciudad1")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataSet
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)

                comboCiuPro.DataSource = dt.Tables(0)
                comboCiuPro.DisplayMember = "nombreCiu"
                comboCiuPro.SelectedIndex = 0

            End If

            desconectar()
        Catch ex As Exception

        End Try
    End Sub






End Class
