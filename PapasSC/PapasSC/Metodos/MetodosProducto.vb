﻿Imports System.Data.SqlClient
Public Class MetodosProducto
    Inherits conexionDB
    Public cn As New conexionDB
    Public adaptador As SqlDataAdapter
    Public dt As DataTable

    Public Sub llenarDatagridview(ByVal dgv As DataGridView)
        cn.conectar()
        Try
            'adaptador = New SqlDataAdapter(
            '"select idProducto as Clave_Producto, version as Version,
            'estado as Estatus, clave as Clave, precio as Precio
            'From producto where estado ='A'", cn.conn)

            adaptador = New SqlDataAdapter("
    Select pr.idProducto as  Clave_del_Producto,
    isnull(bo.nombre,'No asignada') as Nombre_Bodega,
    isnull(ep.cantidad,'0')  As  Cantidad,
    pr.version as Producto,
    pr.clave as Clave,
    pr.precio  as Precio
    From bodega bo right Join existenciaProductos ep on bo.idBodega   = ep.idBodega  
    right join producto pr on pr.idProducto = ep.idProducto  where pr.estado = 'A'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub llenarDatagridviewB(ByVal dgv As DataGridView)
        cn.conectar()
        Try
            'adaptador = New SqlDataAdapter(
            '"select idProducto as Clave_Producto, version as Version,
            'estado as Estatus, clave as Clave, precio as Precio
            'From producto where estado ='A'", cn.conn)

            adaptador = New SqlDataAdapter("
    Select pr.idProducto as  Clave_del_Producto,
    isnull(bo.nombre,'No asignada') as Nombre_Bodega,
    isnull(ep.cantidad,'0')  As  Cantidad,
    pr.version as Producto,
    pr.clave as Clave,
    pr.precio  as Precio
    From bodega bo right Join existenciaProductos ep on bo.idBodega   = ep.idBodega  
    right join producto pr on pr.idProducto = ep.idProducto  where pr.estado = 'B'", cn.conn)
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
            adaptador = New SqlDataAdapter(
    "
    Select pr.idProducto as  Clave_del_Producto,
    isnull(bo.nombre,'No asignada') as Nombre_Bodega,
    isnull(ep.cantidad,'0')  As  Cantidad,
    pr.version as Producto,
    pr.clave as Clave,
    pr.precio  as Precio
    From bodega bo right Join existenciaProductos ep on bo.idBodega   = ep.idBodega  
    right join producto pr on pr.idProducto = ep.idProducto  where pr.estado = 'A'
    and pr.version like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtroEstado(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter(
    "Select 
    pr.idProducto as  Clave_del_Producto,
    bo.nombre as Nombre_Bodega,
    ep.cantidad  As  Cantidad,
     pr.version as Producto,
      pr.clave as Clave,
    pr.precio  as Precio
    From bodega bo inner Join existenciaProductos ep on bo.idBodega   = ep.idBodega  
    inner Join producto pr on pr.idProducto = ep.idProducto  where pr.estado like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtroID(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter(
    "
    Select pr.idProducto as  Clave_del_Producto,
    isnull(bo.nombre,'No asignada') as Nombre_Bodega,
    isnull(ep.cantidad,'0')  As  Cantidad,
    pr.version as Producto,
      pr.clave as Clave,
    pr.precio  as Precio
    From bodega bo right Join existenciaProductos ep on bo.idBodega   = ep.idBodega  
    right join producto pr on pr.idProducto = ep.idProducto  where pr.estado = 'A'
    and pr.idProducto like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub
    Public Sub llenarDatagridview_filtroclave(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter(
    "
    Select pr.idProducto as  Clave_del_Producto,
    isnull(bo.nombre,'No asignada') as Nombre_Bodega,
    isnull(ep.cantidad,'0')  As  Cantidad,
    pr.version as Producto,
      pr.clave as Clave,
    pr.precio  as Precio
    From bodega bo right Join existenciaProductos ep on bo.idBodega   = ep.idBodega  
    right join producto pr on pr.idProducto = ep.idProducto  where pr.estado = 'A'
    and pr.clave like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub eliminaproducto(ByVal filtro As String)
        Try
            cn.conectar()
            Dim cadena As String = "update producto set estado = 'B' where idProducto = '" + filtro + "'"
            Dim comando = New SqlCommand(cadena, cn.conn)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("No se elimino debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub insertarProducto(ByVal Version As String, ByVal clave As String, ByVal precio As String)
        Try

            cn.conectar()
            Dim cadena As String = "INSERT INTO [dbo].[producto]
           ([idProducto]
           ,[version]
           ,[estado]
           ,[clave]
           ,[precio])
     VALUES
           (newid()
           ,'" + Version + "'
           ,'A'
           ,'" + clave + "'
           ," + precio + ")"
            Dim comando = New SqlCommand(cadena, cn.conn)
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("No se inserto debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub updateProducto(ByVal id As String, ByVal Version As String, ByVal clave As String, ByVal precio As String)
        Try

            cn.conectar()
            Dim cadena As String = "UPDATE [dbo].[producto]
      SET [version] = '" + Version + "'
      ,[clave] = '" + clave + "'
      ,[precio] = '" + precio + "'
      WHERE [idProducto] = '" + id + "'"
            Dim comando = New SqlCommand(cadena, cn.conn)
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("No se inserto debido a: " + ex.ToString)
        End Try
    End Sub


    Public Sub updateProducto(ByVal id As String)
        Try

            cn.conectar()
            Dim cadena As String = "UPDATE [dbo].[producto]
      SET [Estado] = 'B'
      WHERE [idProducto] = '" + id + "'"
            Dim comando = New SqlCommand(cadena, cn.conn)
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("No se inserto debido a: " + ex.ToString)
        End Try
    End Sub


    Public Sub llenarDatagridviewlistaprecio(ByVal dgv As DataGridView)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter(
    "select idProducto as Clave_Producto, version as Version,
    estado as Estatus, clave as Clave, precio as Precio
    from producto where estado ='A'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub


    Public Sub updateprecio(ByVal id As String, ByVal precio As String)
        Try

            cn.conectar()
            Dim cadena As String = "UPDATE [dbo].[producto]
      SET 
      [precio] = '" + precio + "'
      WHERE [idProducto] = '" + id + "'"
            Dim comando = New SqlCommand(cadena, cn.conn)
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("No se inserto debido a: " + ex.ToString)
        End Try
    End Sub

End Class
