Imports System.Data.SqlClient
Public Class MetodosReubicacion
    Inherits conexionDB
    Public cn As New conexionDB
    Public adaptador As SqlDataAdapter
    Public dt As DataTable
    Public Sub llenarComboBodega(ByVal dgv As ComboBox)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select nombre as Bodega from bodega where estatus = 'A'", cn.conn)

            Dim ds As New DataSet
            adaptador.Fill(ds)
            dgv.DataSource = ds.Tables(0)
            dgv.DisplayMember = "Bodega"
            dgv.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.Message)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtroBodega(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select  
    bo.nombre as Nombre_Bodega,
    ep.cantidad  as  Cantidad,
     pr.version as Producto,
    pr.precio  as Precio
    from bodega bo inner join existenciaProductos ep on bo.idBodega   = ep.idBodega  
    inner join producto pr on pr.idProducto = ep.idProducto  where ep.estatus = 'A'
    and bo.nombre like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.Message)
        End Try
    End Sub

    Public Sub llenarComboproductos(ByVal dgv As ComboBox, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select pd.version from producto as pd right join existenciaProductos as ep on pd.idProducto = ep.idProducto 
					left join bodega as bd on bd.idBodega = ep.idBodega where bd.nombre like '" + filtro + "' order by pd.version", cn.conn)

            Dim ds As New DataSet

            adaptador.Fill(ds)


            dgv.DataSource = ds.Tables(0)
            dgv.DisplayMember = "version"
            dgv.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.Message)
        End Try
    End Sub

    Public Sub llenarTabla(ByVal tabla As DataGridView, ByVal bodega1 As String)
        Try
            conectar()
            Dim adapt As New SqlDataAdapter("select pd.version, ep.cantidad , pd.clave from producto as pd right join existenciaProductos as ep on pd.idProducto = ep.idProducto 
					left join bodega as bd on bd.idBodega = ep.idBodega where bd.nombre = '" + bodega1 + "' order by pd.version ", conn)
            Dim dt As New DataTable
            adapt.Fill(dt)
            tabla.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message + "1")
        End Try
        desconectar()
    End Sub

    Public Sub insertar_reubicacion(ByVal datosReubicacion() As String)
        Try
            conectar()
            Dim cmd As New SqlCommand("sp_insertar_reubicacion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@producto", SqlDbType.VarChar, 100).Value = datosReubicacion(0)
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 200).Value = datosReubicacion(1)
            cmd.Parameters.Add("@bodega1", SqlDbType.VarChar, 50).Value = datosReubicacion(2)
            cmd.Parameters.Add("@bodega2", SqlDbType.VarChar, 50).Value = datosReubicacion(3)
            cmd.Parameters.Add("@nombreUsuario", SqlDbType.VarChar, 20).Value = datosReubicacion(4)
            'Dim kilos As String = Replace(datosReubicacion(5), ",", ".")
            cmd.Parameters.Add("@cantidad", SqlDbType.Float).Value = datosReubicacion(5)
            cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output
            cmd.Connection = conn
            If cmd.ExecuteNonQuery Then
                Dim resultado As String = cmd.Parameters("@msg").Value
                MsgBox(resultado)
            End If
            desconectar()
        Catch ex As Exception
            MsgBox(ex.Message + "2")
        End Try
    End Sub
End Class
