Imports System.Data.SqlClient

Public Class MetodosInventario
    Inherits conexionDB

    Public Sub buscarBodegas(ByVal cmbBodega As ComboBox)
        Try
            conectar()
            Dim lista As New List(Of String)
            lista.Add("--")
            Dim comando = New SqlCommand("sp_selectBodega")
            comando.Connection = conn
            comando.CommandType = CommandType.StoredProcedure
            Dim reader = comando.ExecuteReader()
            While reader.Read
                lista.Add(CStr(reader("bodega")))
            End While
            cmbBodega.DataSource = lista
        Catch ex As Exception

        End Try

    End Sub

    Public Sub buscarProducto(ByVal cmbProducto As ComboBox)
        Try
            conectar()
            Dim lista As New List(Of String)
            lista.Add("--")
            Dim comando = New SqlCommand("sp_selectTipoPapa")
            comando.Connection = conn
            comando.CommandType = CommandType.StoredProcedure
            Dim reader = comando.ExecuteReader()
            While reader.Read
                lista.Add(CStr(reader("producto")))
            End While
            cmbProducto.DataSource = lista
        Catch ex As Exception
        End Try
    End Sub
    'Este metodo es para buscar por producto, bodega y con existencia
    Public Sub buscarProductoPorNombreBodegaConExistencia(bodega As String, producto As String, ByVal tabla As DataGridView)
        Try
            conectar()
            Dim comando = New SqlCommand("sp_invetario_bodega_clave_CExistencias")
            comando.Connection = conn
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@bodega", bodega)
            comando.Parameters.AddWithValue("@clave", producto)
            If comando.ExecuteNonQuery Then


                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(comando)
                da.Fill(dt)
                tabla.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Este metodo es para buscar por producto, bodega y sin existencia
    Public Sub buscarProductoPorNombreBodegaSinExistencia(bodega As String, producto As String, ByVal tabla As DataGridView)
        Try
            conectar()
            Dim comando = New SqlCommand("sp_invetario_bodega_clave_SExistencias")
            comando.Connection = conn
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@bodega", bodega)
            comando.Parameters.AddWithValue("@clave", producto)
            If comando.ExecuteNonQuery Then

                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(comando)
                da.Fill(dt)
                tabla.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Este metodo es para buscar por bodega con existencia
    Public Sub buscarProductoPorBodegaConExistencia(bodega As String, ByVal tabla As DataGridView)
        Try
            conectar()
            Dim comando = New SqlCommand("sp_invetario_bodega_CExisitencia")
            comando.Connection = conn
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@bodega", bodega)
            If comando.ExecuteNonQuery Then

                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(comando)
                da.Fill(dt)
                tabla.DataSource = dt
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Este metodo es para buscar por bodega sin existencia
    Public Sub buscarProductoPorBodegaSinExistencia(bodega As String, ByVal tabla As DataGridView)
        Try
            conectar()
            Dim comando = New SqlCommand("sp_invetario_bodega_SExisitencia")
            comando.Connection = conn
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@bodega", bodega)
            If comando.ExecuteNonQuery Then

                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(comando)
                da.Fill(dt)
                tabla.DataSource = dt
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Este metodo es para buscar por producto con existencia
    Public Sub buscarProductoPorProductoConExistencia(producto As String, ByVal tabla As DataGridView)
        Try
            conectar()
            Dim comando = New SqlCommand("sp_invetario_clave_CExistencias")
            comando.Connection = conn
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@clave", producto)
            If comando.ExecuteNonQuery Then

                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(comando)
                da.Fill(dt)
                tabla.DataSource = dt
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Este metodo es para buscar por producto sin existencia
    Public Sub buscarProductoPorProductoSinExistencia(producto As String, ByVal tabla As DataGridView)
        Try
            conectar()
            Dim comando = New SqlCommand("sp_invetario_clave_sExistencias")
            comando.Connection = conn
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@clave", producto)
            If comando.ExecuteNonQuery Then

                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(comando)
                da.Fill(dt)
                tabla.DataSource = dt
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
