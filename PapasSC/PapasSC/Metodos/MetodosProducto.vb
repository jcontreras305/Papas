﻿Imports System.Data.SqlClient
Public Class MetodosProducto
    Inherits conexionDB
    Public cn As New conexionDB
    Public adaptador As SqlDataAdapter
    Public dt As DataTable

    Public Sub llenarDatagridview(ByVal dgv As DataGridView)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter(
    "select idProducto as Clave_Producto, version as Version,
    estado as Estatus, clave as Clave
    from producto where estado ='A'", cn.conn)
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
    "select idProducto as Clave_Producto, version as Version,
    estado as Estatus, clave as Clave
    from producto pl where pl.estado ='A' and pl.version like '" + filtro + "%'", cn.conn)
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
    "select idProducto as Clave_Producto, version as Version,
    estado as Estatus, clave as Clave
    from producto pl where  pl.estado like '" + filtro + "%'", cn.conn)
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
    "select idProducto as Clave_Producto, version as Version,
    estado as Estatus, clave as Clave
    from producto pl where pl.estado ='A' and pl.idProducto like '" + filtro + "%'", cn.conn)
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
    "select idProducto as Clave_Producto, version as Version,
    estado as Estatus, clave as Clave
    from producto pl where pl.estado ='A' and pl.clave like '" + filtro + "%'", cn.conn)
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

    Public Sub insertarProducto(ByVal Version As String, ByVal clave As String)
        Try
            MsgBox("pus si entro carnal")
            cn.conectar()
            Dim cadena As String = "INSERT INTO [dbo].[producto]
           ([idProducto]
           ,[version]
           ,[estado]
           ,[clave])
     VALUES
           (newid()
           ,'" + Version + "'
           ,'A'
           ,'" + clave + "')"
            Dim comando = New SqlCommand(cadena, cn.conn)
            comando.ExecuteNonQuery()
            MsgBox("pus si salio carnal")
        Catch ex As Exception
            MessageBox.Show("No se inserto debido a: " + ex.ToString)
        End Try
    End Sub
    Public Sub updateProducto(ByVal id As String, ByVal Version As String, ByVal clave As String)
        Try
            MsgBox("pus si entro carnal")
            cn.conectar()
            Dim cadena As String = "UPDATE [dbo].[producto]
      SET [version] = '" + Version + "'
      ,[clave] = '" + clave + "'
      WHERE [idProducto] = '" + id + "'"
            Dim comando = New SqlCommand(cadena, cn.conn)
            comando.ExecuteNonQuery()
            MsgBox("pus si salio carnal")
        Catch ex As Exception
            MessageBox.Show("No se inserto debido a: " + ex.ToString)
        End Try
    End Sub
End Class
