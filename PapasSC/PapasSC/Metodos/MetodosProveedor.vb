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
            cmd = New SqlCommand("sp_select_CiudadPro")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataSet
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)

                comboCiuPro.DataSource = dt.Tables(0)
                comboCiuPro.DisplayMember = "nombre"
                comboCiuPro.SelectedIndex = 0

            End If

            desconectar()
        Catch ex As Exception

        End Try
    End Sub

    Public Function InsertarProveedor(ByVal nom As String, ByVal tel As String, ByVal ema As String, ByVal nombreCi As String) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("sp_Insertar_Proveedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@nombre", nom)
            cmd.Parameters.AddWithValue("@telefono", tel)
            cmd.Parameters.AddWithValue("@Email", ema)
            cmd.Parameters.AddWithValue("nombreCiu", nombreCi)

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

    Public Sub EliminarProveedor(ByVal datosPro() As String)
        Try
            conectar()
            cmd = New SqlCommand("sp_Eliminar_Proveedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@nombre", datosPro(0))
            cmd.Parameters.AddWithValue("@telefono", datosPro(1))
            cmd.Parameters.AddWithValue("@email", datosPro(2))
            cmd.Parameters.AddWithValue("@NomCiu", datosPro(3))

            If cmd.ExecuteNonQuery Then
                MsgBox("Se ha eliminado el proveedor " + datosPro(0))

            End If
            desconectar()
        Catch ex As Exception
            desconectar()
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub modificar_Proveedor(ByVal datosV() As String, ByVal datosN() As String, ByVal nombre As String)
        Try
            conectar()
            Dim comando As New SqlCommand("sp_Actualizar_Proveedor")
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@nombre", nombre)
            comando.Parameters.AddWithValue("@telefonoN", datosN(0))
            comando.Parameters.AddWithValue("@emailN", datosN(1))
            comando.Parameters.AddWithValue("@nombreCiuN", datosN(2))
            comando.Parameters.AddWithValue("@telefonoV", datosV(0))
            comando.Parameters.AddWithValue("@emailV", datosV(1))
            comando.Parameters.AddWithValue("@nombreCiuV", datosV(2))
            comando.Connection = conn
            If comando.ExecuteNonQuery Then
                MsgBox("Se actualizo correctamente los datos del proveedor " + nombre)
            End If
            desconectar()
        Catch ex As Exception
            desconectar()
            MsgBox(ex.Message)
        End Try
    End Sub



End Class
