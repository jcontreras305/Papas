Imports System.Data.SqlClient

Public Class MetodosProveedor
    Inherits conexionDB
    Dim cmd As New SqlCommand
    Public adaptador As SqlDataAdapter
    Public dt As DataTable


    'Metodo para consultar los proveedores

    Public Function ConsultarProTodos() As DataTable
        Try
            conectar()
            cmd = New SqlCommand("sp_Consultar_ProveedoresTodos")
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
            MessageBox.Show(ex.Message, "Error al mostrar los proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function ConsultarPro() As DataTable
        Try
            conectar()
            cmd = New SqlCommand("sp_Consultar_Proveedores")
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
            MessageBox.Show(ex.Message, "Error al mostrar los proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    'Metodo para buscar un proveedor por el nombre

    Public Function BuscarProveedorNom(no As String)
        Try
            conectar()
            cmd = New SqlCommand("sp_BucarProveedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@nombrePro", no)
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
        Finally
            desconectar()
        End Try
    End Function


    'Metodo para buscar por zona
    Public Function BuscarProveedorCiu(ByVal noCiu As String)
        Try
            conectar()
            cmd = New SqlCommand("sp_BuscarOrigenCiudad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@nombreCiu", noCiu)
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
        Finally
            desconectar()

        End Try
    End Function

    Public Function BuscarTipoPersona(ByVal tipoPer As String)
        Try
            conectar()
            cmd = New SqlCommand("Buscar_TipoCliente_Empleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@TipoPersona", tipoPer)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
            desconectar()
        Catch ex As Exception
            Return Nothing

        End Try

    End Function

    Public Function BuscarRazon(ByVal razon As String)
        Try
            conectar()
            cmd = New SqlCommand("Buscar_RazonSocial_Empleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@Rasocial", razon)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
            desconectar()
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function AliasPro(ByVal al As String)
        Try
            conectar()
            cmd = New SqlCommand("Buscar_AliasContacto_Empleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@AliasCont", al)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
            desconectar()
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function BuscarRfcPro(ByVal rfc As String)
        Try
            conectar()
            cmd = New SqlCommand("Buscar_RFC_Empleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@rfc", rfc)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

            desconectar()
        Catch ex As Exception
            Return Nothing
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

    Public Sub InsertarProveedor(ByVal datosPro As List(Of String))
        Try
            conectar()
            cmd = New SqlCommand("sp_Insertar_ProveedorNuevo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@nombre", datosPro.ElementAt(0))
            cmd.Parameters.AddWithValue("@rfc", datosPro.ElementAt(1))
            cmd.Parameters.AddWithValue("@razonSocial", datosPro.ElementAt(2))
            cmd.Parameters.AddWithValue("@nombreCiu", datosPro.ElementAt(3))
            cmd.Parameters.AddWithValue("@estatus", datosPro.ElementAt(4))
            cmd.Parameters.AddWithValue("@TipoPer", datosPro.ElementAt(5))
            cmd.Parameters.AddWithValue("@NomContacto", datosPro.ElementAt(6))
            cmd.Parameters.AddWithValue("@genero", datosPro.ElementAt(7))
            cmd.Parameters.AddWithValue("@direccion", datosPro.ElementAt(8))
            cmd.Parameters.AddWithValue("@telefono", datosPro.ElementAt(9))
            cmd.Parameters.AddWithValue("@email", datosPro.ElementAt(10))
            cmd.Parameters.AddWithValue("@direccion2", datosPro.ElementAt(11))
            cmd.Parameters.AddWithValue("@telefono2", datosPro.ElementAt(12))
            cmd.Parameters.AddWithValue("@email2", datosPro.ElementAt(13))
            cmd.Parameters.AddWithValue("@estado", datosPro.ElementAt(14))
            cmd.Parameters.AddWithValue("@municipio", datosPro.ElementAt(15))
            cmd.Parameters.AddWithValue("@codigoPostal", datosPro.ElementAt(16))

            If cmd.ExecuteNonQuery Then
                MsgBox("Se agrego correctamente los datos " + datosPro.ElementAt(0))

            End If
        Catch ex As Exception
            desconectar()
            MsgBox(ex.Message)

        End Try
    End Sub

    Public Sub EliminarProveedor(ByVal datosProEli() As String)
        Try
            conectar()
            cmd = New SqlCommand("sp_Eliminar_Proveedor3")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@nombre", datosProEli.ElementAt(0))
            cmd.Parameters.AddWithValue("@rfc", datosProEli.ElementAt(1))
            cmd.Parameters.AddWithValue("@razonSocial", datosProEli.ElementAt(2))
            cmd.Parameters.AddWithValue("@nombreCiu", datosProEli.ElementAt(3))
            cmd.Parameters.AddWithValue("@TipoPer", datosProEli.ElementAt(4))
            cmd.Parameters.AddWithValue("@NomContacto", datosProEli.ElementAt(5))
            cmd.Parameters.AddWithValue("@genero", datosProEli.ElementAt(6))
            cmd.Parameters.AddWithValue("@direccion", datosProEli.ElementAt(7))
            cmd.Parameters.AddWithValue("@telefono", datosProEli.ElementAt(8))
            cmd.Parameters.AddWithValue("@email", datosProEli.ElementAt(9))
            cmd.Parameters.AddWithValue("@direccion2", datosProEli.ElementAt(10))
            cmd.Parameters.AddWithValue("@telefono2", datosProEli.ElementAt(11))
            cmd.Parameters.AddWithValue("@email2", datosProEli.ElementAt(12))
            cmd.Parameters.AddWithValue("@estado", datosProEli.ElementAt(13))
            cmd.Parameters.AddWithValue("@municipio", datosProEli.ElementAt(14))
            cmd.Parameters.AddWithValue("@codigoPostal", datosProEli.ElementAt(15))

            If cmd.ExecuteNonQuery Then
                MsgBox("Se ha eliminado el proveedor " + datosProEli.ElementAt(0))

            End If
            desconectar()
        Catch ex As Exception
            desconectar()
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub Actualizar_Proveedor(ByVal datosProveedorNuevo As List(Of String))
        Try
            conectar()
            cmd = New SqlCommand("sp_Actualizar_ProveedorNuevo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 80).Value = datosProveedorNuevo.ElementAt(0)
            cmd.Parameters.Add("@rfc", SqlDbType.VarChar, 13).Value = datosProveedorNuevo.ElementAt(1)
            cmd.Parameters.Add("@razonSocial", SqlDbType.VarChar, 100).Value = datosProveedorNuevo.ElementAt(2)
            cmd.Parameters.Add("@nombreCiu", SqlDbType.VarChar, 30).Value = datosProveedorNuevo.ElementAt(3)
            cmd.Parameters.Add("@estatus", SqlDbType.Char, 1).Value = datosProveedorNuevo.ElementAt(4)
            cmd.Parameters.Add("@TipoPer", SqlDbType.VarChar, 10).Value = datosProveedorNuevo.ElementAt(5)
            cmd.Parameters.Add("@NomContacto", SqlDbType.VarChar, 100).Value = datosProveedorNuevo.ElementAt(6)
            cmd.Parameters.Add("@genero", SqlDbType.Char, 1).Value = datosProveedorNuevo.ElementAt(7)
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = datosProveedorNuevo.ElementAt(8)
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 12).Value = datosProveedorNuevo.ElementAt(9)
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = datosProveedorNuevo.ElementAt(10)
            cmd.Parameters.Add("@direccion2", SqlDbType.VarChar, 100).Value = datosProveedorNuevo.ElementAt(13)
            cmd.Parameters.Add("@telefono2", SqlDbType.VarChar, 12).Value = datosProveedorNuevo.ElementAt(11)
            cmd.Parameters.Add("@email2", SqlDbType.VarChar, 100).Value = datosProveedorNuevo.ElementAt(12)
            cmd.Parameters.Add("@estado", SqlDbType.VarChar, 50).Value = datosProveedorNuevo.ElementAt(14)
            cmd.Parameters.Add("@municipio", SqlDbType.VarChar, 50).Value = datosProveedorNuevo.ElementAt(15)
            cmd.Parameters.Add("@codigoPostal", SqlDbType.Char, 5).Value = datosProveedorNuevo.ElementAt(16)
            cmd.Parameters.Add("@nombreCiuN", SqlDbType.VarChar, 30).Value = datosProveedorNuevo.ElementAt(3)


            If cmd.ExecuteNonQuery Then
                MsgBox("Se actualizo correctamente los datos del proveedor " + datosProveedorNuevo(0))
            End If
            desconectar()
        Catch ex As Exception
            desconectar()
            MsgBox(ex.Message)
        End Try
    End Sub



End Class
