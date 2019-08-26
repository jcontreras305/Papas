Imports System.Data.SqlClient

Public Class MetodoExistenciaProducto
    Inherits conexionDB
    Public cn As New conexionDB
    Public adaptador As SqlDataAdapter
    Public dt As DataTable

    Public Sub llenarDatagridview(ByVal dgv As DataGridView)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select  
    bo.nombre as Nombre_Bodega,
    ep.cantidad  as  Cantidad,
     pr.version as Producto,
    pr.precio  as Precio
    from bodega bo inner join existenciaProductos ep on bo.idBodega   = ep.idBodega  
    inner join producto pr on pr.idProducto = ep.idProducto  where ep.estatus = 'A'
", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub



    Public Sub llenarComboMatriz(ByVal dgv As ComboBox)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select nombre as Matriz from matriz where estatus = 'A'", cn.conn)

            Dim ds As New DataSet

            adaptador.Fill(ds)


            dgv.DataSource = ds.Tables(0)
            dgv.DisplayMember = "Matriz"
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
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub


    Public Sub llenarDatagridview_filtroCantidad(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select  
    bo.nombre as Nombre_Bodega,
    ep.cantidad  as  Cantidad,
     pr.version as Producto,
    pr.precio  as Precio
    from bodega bo inner join existenciaProductos ep on bo.idBodega   = ep.idBodega  
    inner join producto pr on pr.idProducto = ep.idProducto  where ep.estatus = 'A'
    and ep.cantidad like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtroVersion(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select  
    bo.nombre as Nombre_Bodega,
    ep.cantidad  as  Cantidad,
     pr.version as Producto,
    pr.precio  as Precio
    from bodega bo inner join existenciaProductos ep on bo.idBodega   = ep.idBodega  
    inner join producto pr on pr.idProducto = ep.idProducto  where ep.estatus = 'A'
     and pr.version like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtroEstatus(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select  
    bo.nombre as Nombre_Bodega,
    ep.cantidad  as  Cantidad,
     pr.version as Producto,
    pr.precio  as Precio
    from bodega bo inner join existenciaProductos ep on bo.idBodega   = ep.idBodega  
    inner join producto pr on pr.idProducto = ep.idProducto  where ep.estatus = 
 '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtroPrecio(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select  
    bo.nombre as Nombre_Bodega,
    ep.cantidad  as  Cantidad,
     pr.version as Producto,
    pr.precio  as Precio
    from bodega bo inner join existenciaProductos ep on bo.idBodega   = ep.idBodega  
    inner join producto pr on pr.idProducto = ep.idProducto  where ep.estatus = 'A'
    and pr.precio like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub





    Public Sub eliminaexistenciaproducto(ByVal filtro As String, ByVal Filtro2 As String)
        Try
            cn.conectar()
            MsgBox("entro")
            Dim Rs As SqlDataReader
            Dim Com As New SqlCommand



            Dim Sql As String = "select  
    bo.idBodega,
    pr.idProducto
    from bodega bo inner join existenciaProductos ep on bo.idBodega   = ep.idBodega  
    inner join producto pr on pr.idProducto = ep.idProducto  where ep.estatus = 'A'
    and bo.nombre like '" + filtro + "' and pr.version='" + Filtro2 + "'"

            Com = New SqlCommand(Sql, cn.conn)

            Rs = Com.ExecuteReader()

            Rs.Read()
            MsgBox(Rs(0))
            Dim cadena As String = "update existenciaProductos set estatus = 'B' where idBodega = '" + Rs(0).ToString + "'
            and idProducto = '" + Rs(1).ToString + "'"
            Rs.Close()
            cn.desconectar()
            cn.conectar()
            Com = New SqlCommand(cadena, cn.conn)

            MsgBox("cade")
            Com.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show("No se elimino debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub insertarBodega(ByVal nombre As String, ByVal clave As String)
        Try
            cn.conectar()
            MsgBox("entro")
            Dim Rs As SqlDataReader
            Dim Com As New SqlCommand



            Dim Sql As String = "select bodega from matriz where nombre ='" + clave + "' and estatus = 'A'"
            MsgBox(clave)

            Com = New SqlCommand(Sql, cn.conn)

            Rs = Com.ExecuteReader()

            Rs.Read()
            MsgBox(Rs(0))
            Dim cadena As String = "INSERT INTO [dbo].[bodega]
            ([idBodega]
            ,[nombre]
            ,[estatus]
            ,[idMatriz])
            VALUES
            (newid()
            ,'" + nombre + "'
            ,'A'
            ,'" + Rs(0).ToString + "')"
            MsgBox(cadena)
            Rs.Close()
            cn.desconectar()
            cn.conectar()
            Com = New SqlCommand(cadena, cn.conn)
            MsgBox("cade")
            Com.ExecuteNonQuery()
            MsgBox("pus si salio carnal")
        Catch ex As Exception
            MessageBox.Show("No se inserto debido a: " + ex.ToString)
        End Try
    End Sub


    Public Sub updatebodega(ByVal nombre As String, ByVal clave As String, ByVal id As String)
        Try
            cn.conectar()
            MsgBox("entro")
            Dim Rs As SqlDataReader
            Dim Com As New SqlCommand



            Dim Sql As String = "select idMatriz from matriz where nombre ='" + clave + "' and estatus = 'A'"
            MsgBox(clave)

            Com = New SqlCommand(Sql, cn.conn)

            Rs = Com.ExecuteReader()

            Rs.Read()
            MsgBox(Rs(0))
            Dim cadena As String = "UPDATE [dbo].[bodega]
       SET 
       [nombre] = '" + nombre + "'
      ,[idMatriz] = '" + Rs(0).ToString + "'
       WHERE idBodega = '" + id + "'"


            MsgBox(cadena)
            Rs.Close()
            cn.desconectar()
            cn.conectar()
            Com = New SqlCommand(cadena, cn.conn)
            MsgBox("cade")
            Com.ExecuteNonQuery()
            MsgBox("pus si salio carnal")
        Catch ex As Exception
            MessageBox.Show("No se inserto debido a: " + ex.ToString)
        End Try
    End Sub

End Class
