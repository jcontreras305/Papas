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
    Public Sub llenarComboProducto(ByVal dgv As ComboBox)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select version as Producto from producto where estado = 'A'", cn.conn)

            Dim ds As New DataSet

            adaptador.Fill(ds)


            dgv.DataSource = ds.Tables(0)
            dgv.DisplayMember = "Producto"
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

    Public Sub insertarExitemcia(ByVal bodega As String, ByVal producto As String, ByVal version As String)
        Try
            cn.conectar()
            MsgBox("entro")
            Dim idbodega As String
            Dim idproducto As String
            Dim Rs As SqlDataReader
            Dim Com As New SqlCommand



            Dim Sql As String = "select idBodega from bodega where nombre ='" + bodega + "' and estatus = 'A'"

            Com = New SqlCommand(Sql, cn.conn)

            Rs = Com.ExecuteReader()

            Rs.Read()
            idbodega = Rs(0).ToString


            Rs.Close()
            cn.desconectar()
            cn.conectar()





            Dim Sql2 As String = "select idproducto from producto where version ='" + producto + "' and estado= 'A'"

            Com = New SqlCommand(Sql2, cn.conn)

            Rs = Com.ExecuteReader()

            Rs.Read()
            idproducto = Rs(0).ToString

            Rs.Close()
            cn.desconectar()
            Dim cadena As String = "INSERT INTO [dbo].[existenciaProductos]
           ([idBodega]
           ,[idProducto]
           ,[cantidad]
           ,[estatus])
            VALUES
            ('" + idbodega + "'
            ,'" + idproducto + "'
          
            ," + version + ",'A')"
            MsgBox(cadena)
            cn.conectar()
            Com = New SqlCommand(cadena, cn.conn)
            MsgBox("cade")
            Com.ExecuteNonQuery()
            MsgBox("pus si salio carnal")
        Catch ex As Exception
            MessageBox.Show("No se inserto debido a: " + ex.ToString)
        End Try
    End Sub


    Public Sub updatebodega(ByVal bodega As String, ByVal producto As String, ByVal version As String, ByVal claveb As String, ByVal clavep As String)
        Try

            Dim Rs As SqlDataReader
            Dim Com As New SqlCommand

            cn.conectar()

            Dim idbodega As String
            Dim idproducto As String
            Dim Sql As String = "select idBodega from bodega where nombre ='" + claveb + "' and estatus = 'A'"

            Com = New SqlCommand(Sql, cn.conn)
            Rs = Com.ExecuteReader()
            Rs.Read()
            idbodega = Rs(0).ToString
            MsgBox(idbodega)
            Rs.Close()
            cn.desconectar()

            cn.conectar()
            Dim Sql2 As String = "select idproducto from producto where version ='" + clavep + "' and estado= 'A'"
            Com = New SqlCommand(Sql2, cn.conn)
            Rs = Com.ExecuteReader()
            Rs.Read()
            idproducto = Rs(0).ToString
            MsgBox(idproducto)
            Rs.Close()
            cn.desconectar()

            Dim idbodegan As String
            Dim idproducton As String
            Dim Rsn As SqlDataReader
            Dim Comn As New SqlCommand
            cn.conectar()
            Dim Sql3 As String = "select idBodega from bodega where nombre ='" + bodega + "' and estatus = 'A'"
            Comn = New SqlCommand(Sql3, cn.conn)
            Rsn = Comn.ExecuteReader()
            Rsn.Read()
            idbodegan = Rsn(0).ToString
            MsgBox(idbodegan)
            Rsn.Close()
            cn.desconectar()

            cn.conectar()
            Dim Sql4 As String = "select idproducto from producto where version ='" + producto + "' and estado= 'A'"
            Comn = New SqlCommand(Sql4, cn.conn)
            Rsn = Comn.ExecuteReader()
            Rsn.Read()
            idproducton = Rsn(0).ToString
            MsgBox(idproducton)
            Rsn.Close()
            cn.desconectar()

            Dim cadena As String = "
       UPDATE [dbo].[existenciaProductos]
       SET [idBodega] = '" + idbodegan + "'
      ,[idProducto] = '" + idproducton + "'
      ,[cantidad] =" + version + " 
      ,[estatus] = 'A'
       WHERE [idBodega] = '" + idbodega + "' and [idProducto] = '" + idproducto + "'"
            MsgBox(cadena)
            cn.conectar()
            Com = New SqlCommand(cadena, cn.conn)
            MsgBox("cade")
            Com.ExecuteNonQuery()
            MsgBox("pus si salio carnal")
        Catch ex As Exception
            MessageBox.Show("No se actualizo debido a: " + ex.ToString)
        End Try
    End Sub

End Class