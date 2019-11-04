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

    Public Function insertar_reubicacion(ByVal datosReubicacion As DataTable, ByVal descripcion As String) As String
        Try
            conectar()
            Dim tran As SqlTransaction = conn.BeginTransaction("Transaction1")
            Dim cmd1 As New SqlCommand("sp_insertar_reubicar", conn)
            cmd1.Transaction = tran
            cmd1.CommandType = CommandType.StoredProcedure
            Dim flag As Boolean = False
            Dim bodega1 As String = datosReubicacion.Rows(0).Item(1).ToString
            Dim bodega2 As String = datosReubicacion.Rows(0).Item(2).ToString
            Dim usuario As String = datosReubicacion.Rows(0).Item(3).ToString
            cmd1.Parameters.Add("@descripcion", SqlDbType.VarChar, 200).Value = descripcion
            cmd1.Parameters.Add("@bodega1", SqlDbType.VarChar, 50).Value = bodega1
            cmd1.Parameters.Add("@bodega2", SqlDbType.VarChar, 50).Value = bodega2
            cmd1.Parameters.Add("@nombreUsuario", SqlDbType.VarChar, 20).Value = usuario
            Dim fechaInc As String = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")
            cmd1.Parameters.Add("@fecha", SqlDbType.SmallDateTime).Value = fechaInc
            cmd1.Parameters.Add("@idReubicacion", SqlDbType.VarChar, 36).Direction = ParameterDirection.Output
            cmd1.Parameters.Add("@msg", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            cmd1.ExecuteNonQuery()
            Dim idreubicaion As String = cmd1.Parameters("@idReubicacion").Value
            Dim msg1 As String = cmd1.Parameters("@msg").Value
            If idreubicaion <> String.Empty And Not msg1.Equals("false") Then

                For Each row As DataRow In datosReubicacion.Rows
                    Dim cmd2 As New SqlCommand("sp_insert_detalleReubicacion", conn)
                    cmd2.Transaction = tran
                    cmd2.CommandType = CommandType.StoredProcedure
                    cmd2.Parameters.Add("@idReubicacion", SqlDbType.VarChar, 36).Value = idreubicaion
                    cmd2.Parameters.Add("@producto", SqlDbType.VarChar, 100).Value = row.Item(0).ToString
                    cmd2.Parameters.Add("@cantidad", SqlDbType.Float).Value = row.Item(4).ToString
                    cmd2.Parameters.Add("@bodega1", SqlDbType.VarChar, 50).Value = bodega1
                    cmd2.Parameters.Add("@bodega2", SqlDbType.VarChar, 50).Value = bodega2
                    cmd2.Parameters.Add("@msg", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output
                    cmd2.ExecuteNonQuery()
                    Dim msg As String = cmd2.Parameters("@msg").Value
                    If Not msg.Equals("true") Then
                        flag = True
                        Exit For
                    End If
                Next
                If Not flag Then
                    tran.Commit()
                    MsgBox("Los cambios se realizarion correctamente")
                    Return idreubicaion
                Else
                    tran.Rollback()
                    MsgBox("Ocurrio un problema ")
                    Return Nothing
                End If
            Else
                tran.Rollback()
                MsgBox("Ocurrio un problema ")
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un problema " = ex.Message)
            Return Nothing
            'MsgBox("Ocurrio un problema ")
        End Try
        desconectar()
    End Function
End Class
