Imports System.Data.SqlClient
Public Class MetodosVenta

    Inherits conexionDB
        Public cn As New conexionDB
        Public adaptador As SqlDataAdapter
        Public dt As DataTable

    Public Sub llenarDatagridview(ByVal dgv As DataGridView)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select vn.idVenta, bo.nombre, pr.version, expr.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre, cl.nombre  from venta vn inner join ventaDetalle vd on vn.idVenta = vd.idVenta inner join producto pr on vd.idProducto = pr.idProducto 
inner join bodega bo on bo.idBodega =vn.idBodega  inner join cliente cl on cl.idCliente = vn.idCliente inner join empleado em
on em.idEmpleado = vn.idEmpleado inner join existenciaProductos expr on expr.idBodega =bo.idBodega where vn.estatus='A'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub


    Public Sub llenarDatagridview(ByVal dgv As DataGridView, ByVal id As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select  bo.nombre, pr.version, expr.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre, cl.nombre  from venta vn inner join ventaDetalle vd on vn.idVenta = vd.idVenta inner join producto pr on vd.idProducto = pr.idProducto 
inner join bodega bo on bo.idBodega =vn.idBodega  inner join cliente cl on cl.idCliente = vn.idCliente inner join empleado em
on em.idEmpleado = vn.idEmpleado inner join existenciaProductos expr on expr.idBodega =bo.idBodega where vn.estatus='A' and vn.idVenta='" + id + "'", cn.conn)
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
            adaptador = New SqlDataAdapter("select vn.idVenta, bo.nombre, pr.version, expr.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre, cl.nombre  from venta vn inner join ventaDetalle vd on vn.idVenta = vd.idVenta inner join producto pr on vd.idProducto = pr.idProducto 
inner join bodega bo on bo.idBodega =vn.idBodega  inner join cliente cl on cl.idCliente = vn.idCliente inner join empleado em
on em.idEmpleado = vn.idEmpleado inner join existenciaProductos expr on expr.idBodega =bo.idBodega where ep.estatus = 'B'
", cn.conn)
            dt = New DataTable
                adaptador.Fill(dt)
                dgv.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
            End Try
        End Sub




    Public Sub llenarDatagridview_filtroBodega(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select vn.idVenta, bo.nombre, pr.version, expr.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre, cl.nombre  from venta vn inner join ventaDetalle vd on vn.idVenta = vd.idVenta inner join producto pr on vd.idProducto = pr.idProducto 
            inner join bodega bo on bo.idBodega =vn.idBodega  inner join cliente cl on cl.idCliente = vn.idCliente inner join empleado em
            on em.idEmpleado = vn.idEmpleado inner join existenciaProductos expr on expr.idBodega =bo.idBodega
            and bo.nombre like '" + filtro + "%' and vn.estatus='A'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtroFecha(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select vn.idVenta, bo.nombre, pr.version, expr.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre, cl.nombre  from venta vn inner join ventaDetalle vd on vn.idVenta = vd.idVenta inner join producto pr on vd.idProducto = pr.idProducto 
            inner join bodega bo on bo.idBodega =vn.idBodega  inner join cliente cl on cl.idCliente = vn.idCliente inner join empleado em
            on em.idEmpleado = vn.idEmpleado inner join existenciaProductos expr on expr.idBodega =bo.idBodega
            where vn.fecha like '" + filtro + "%' and vn.estatus='A'", cn.conn)
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
            adaptador = New SqlDataAdapter("select vn.idVenta, bo.nombre, pr.version, expr.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre, cl.nombre  from venta vn inner join ventaDetalle vd on vn.idVenta = vd.idVenta inner join producto pr on vd.idProducto = pr.idProducto 
inner join bodega bo on bo.idBodega =vn.idBodega  inner join cliente cl on cl.idCliente = vn.idCliente inner join empleado em
on em.idEmpleado = vn.idEmpleado inner join existenciaProductos expr on expr.idBodega =bo.idBodega  where 
     expr.cantidad like '" + filtro + "%' and vn.estatus='A'", cn.conn)
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
            adaptador = New SqlDataAdapter("select vn.idVenta, bo.nombre, pr.version, expr.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre, cl.nombre  from venta vn inner join ventaDetalle vd on vn.idVenta = vd.idVenta inner join producto pr on vd.idProducto = pr.idProducto 
inner join bodega bo on bo.idBodega =vn.idBodega  inner join cliente cl on cl.idCliente = vn.idCliente inner join empleado em
on em.idEmpleado = vn.idEmpleado inner join existenciaProductos expr on expr.idBodega =bo.idBodega  where 
     pr.version like '" + filtro + "%' and vn.estatus='A'", cn.conn)
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
            adaptador = New SqlDataAdapter("select vn.idVenta, bo.nombre, pr.version, expr.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre, cl.nombre  from venta vn inner join ventaDetalle vd on vn.idVenta = vd.idVenta inner join producto pr on vd.idProducto = pr.idProducto 
inner join bodega bo on bo.idBodega =vn.idBodega  inner join cliente cl on cl.idCliente = vn.idCliente inner join empleado em
on em.idEmpleado = vn.idEmpleado inner join existenciaProductos expr on expr.idBodega =bo.idBodega  where pr.precio like '" + filtro + "%'
and vn.estatus='A'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtroEmpleado(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select vn.idVenta, bo.nombre, pr.version, expr.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre, cl.nombre  from venta vn inner join ventaDetalle vd on vn.idVenta = vd.idVenta inner join producto pr on vd.idProducto = pr.idProducto 
inner join bodega bo on bo.idBodega =vn.idBodega  inner join cliente cl on cl.idCliente = vn.idCliente inner join empleado em
on em.idEmpleado = vn.idEmpleado inner join existenciaProductos expr on expr.idBodega =bo.idBodega  where em.nombre like '" + filtro + "%' and vn.estatus='A'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub
    Public Sub llenarDatagridview_filtroCliente(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select vn.idVenta, bo.nombre, pr.version, expr.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre, cl.nombre  from venta vn inner join ventaDetalle vd on vn.idVenta = vd.idVenta inner join producto pr on vd.idProducto = pr.idProducto 
inner join bodega bo on bo.idBodega =vn.idBodega  inner join cliente cl on cl.idCliente = vn.idCliente inner join empleado em
on em.idEmpleado = vn.idEmpleado inner join existenciaProductos expr on expr.idBodega =bo.idBodega  where cl.nombre like '" + filtro + "%' and vn.estatus='A'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub
    Public Sub llenarDatagridview_filtroTotal(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select , bo.nombre, pr.version, expr.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre, cl.nombre  from venta vn inner join ventaDetalle vd on vn.idVenta = vd.idVenta inner join producto pr on vd.idProducto = pr.idProducto 
inner join bodega bo on bo.idBodega =vn.idBodega  inner join cliente cl on cl.idCliente = vn.idCliente inner join empleado em
on em.idEmpleado = vn.idEmpleado inner join existenciaProductos expr on expr.idBodega =bo.idBodega  where vn. like '" + filtro + "%' and vn.estatus='A'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub
    Public Sub llenarDatagridview_filtroIdVenta(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select vn.idVenta, bo.nombre, pr.version, expr.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre, cl.nombre  from venta vn inner join ventaDetalle vd on vn.idVenta = vd.idVenta inner join producto pr on vd.idProducto = pr.idProducto 
inner join bodega bo on bo.idBodega =vn.idBodega  inner join cliente cl on cl.idCliente = vn.idCliente inner join empleado em
on em.idEmpleado = vn.idEmpleado inner join existenciaProductos expr on expr.idBodega =bo.idBodega  where vn.idVenta like '" + filtro + "%' and vn.estatus='A'", cn.conn)
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


    Public Sub llenarComboBodega(ByVal dgv As ComboBox)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select bo.nombre as Bodega from empleado em inner join  bodega bo on em.idBodega = bo.idBodega where bo.estatus = 'A'", cn.conn)
            Dim ds As New DataSet
            adaptador.Fill(ds)
            dgv.DataSource = ds.Tables(0)
            dgv.DisplayMember = "Bodega"
            dgv.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.Message)
        End Try
    End Sub




    Public Sub llenarComboCliente(ByVal dgv As ComboBox, ByVal rs As Boolean)
        cn.conectar()
        Try
            If rs Then
                adaptador = New SqlDataAdapter("select razonSocial from cliente where estatus = 'A'", cn.conn)
                Dim ds As New DataSet
                adaptador.Fill(ds)
                dgv.DataSource = ds.Tables(0)
                dgv.DisplayMember = "razonSocial"
                dgv.SelectedIndex = 0
            Else

                adaptador = New SqlDataAdapter("select nombre from cliente where estatus = 'A'", cn.conn)
                Dim ds As New DataSet
                adaptador.Fill(ds)
                dgv.DataSource = ds.Tables(0)
                dgv.DisplayMember = "nombre"
                dgv.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.Message)
        End Try
    End Sub





    'Public Sub llenarComboProducto(ByVal dgv As ComboBox, ByVal t As String)
    '    cn.conectar()
    '    Try
    '        adaptador = New SqlDataAdapter("select  
    'pr.version as producto
    'from bodega bo inner join existenciaProductos ep on bo.idBodega   = ep.idBodega  
    'inner join producto pr on pr.idProducto = ep.idProducto  where ep.estatus = 'A'
    'and bo.nombre='" + t + "'", cn.conn)
    '        Dim ds As New DataSet
    '        adaptador.Fill(ds)
    '        dgv.DataSource = ds.Tables(0)
    '        dgv.DisplayMember = "producto"
    '        dgv.SelectedIndex = 0
    '    Catch ex As Exception
    '        MessageBox.Show("No se lleno el Datagridview debido a: " + ex.Message)
    '    End Try
    'End Sub

    Public Sub llenarComboProducto(ByVal dgv As DataGridView, ByVal t As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select  
    pr.version as Producto,
  pr.Precio as Precio
    from bodega bo inner join existenciaProductos ep on bo.idBodega   = ep.idBodega  
    inner join producto pr on pr.idProducto = ep.idProducto  where ep.estatus = 'A'
    and bo.nombre='" + t + "'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.Message)
        End Try
    End Sub

    Public Sub llenarComboProductofiltro(ByVal dgv As DataGridView, ByVal t As String, ByVal pr As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select  
    pr.version as Producto,
    pr.Precio as Precio
    from bodega bo inner join existenciaProductos ep on bo.idBodega   = ep.idBodega  
    inner join producto pr on pr.idProducto = ep.idProducto  where ep.estatus = 'A'
    and bo.nombre='" + t + "' and pr.version like '" + pr + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.Message)
        End Try
    End Sub

    Public Function PrecioProductos(ByVal filtro As String) As String
        cn.conectar()
        Try

            Dim idproducto As String
            Dim Rs As SqlDataReader
            Dim Com As New SqlCommand


            Dim Sql As String = "select
            precio
            From producto  where estado = 'A' 
            and version like '" + filtro + "'"

            Com = New SqlCommand(Sql, cn.conn)


            Rs = Com.ExecuteReader()

            Rs.Read()
            idproducto = Rs(0).ToString

            Return idproducto
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.Message)
        End Try
    End Function




    Public Sub llenarComboProducto(ByVal dgv As ComboBox)
            cn.conectar()
            Try
            adaptador = New SqlDataAdapter("select version as Producto from producto where estado = 'A'", cn.conn)
            Dim ds As New DataSet
                adaptador.Fill(ds)
                dgv.DataSource = ds.Tables(0)
                dgv.DisplayMember = "Producto"
            dgv.SelectedIndex = 0
            dgv.ValueMember = "idProducto"
        Catch ex As Exception
                MessageBox.Show("No se lleno el Datagridview debido a: " + ex.Message)
            End Try
        End Sub






    Dim clave As String

    Public Sub insertarVenta(ByVal fecha As String, ByVal totalpagar As String, ByVal cantidadPagada As String, ByVal cliente As String, ByVal Empleado As String, ByVal Bodega As String, ByVal estatus As String, ByVal formapago As String, ByVal idCaja As String)
        Try
            clave = ""
            cn.conectar()
            MsgBox("entro")

            Dim idCliente As String
            Dim idempleado As String
            Dim idbodega As String


            Dim Rs As SqlDataReader
            Dim Com As New SqlCommand

            Com = New SqlCommand("Select newid()", cn.conn)
            Rs = Com.ExecuteReader
            Rs.Read()
            clave = Rs(0).ToString
            Rs.Close()

            cn.conectar()
            Dim Sql1 As String = "select idcliente from cliente where nombre ='" + cliente + "' and estatus = 'A'"
            Com = New SqlCommand(Sql1, cn.conn)
            Rs = Com.ExecuteReader()
            Rs.Read()
            idCliente = Rs(0).ToString
            Rs.Close()
            cn.desconectar()





            cn.conectar()
            Dim Sql2 As String = "select top 1 idempleado from empleado where nombre ='" + Empleado + "' and estatus= 'A'"
            Com = New SqlCommand(Sql2, cn.conn)
            Rs = Com.ExecuteReader()
            Rs.Read()
            idempleado = Rs(0).ToString
            Rs.Close()
            cn.desconectar()


            cn.conectar()
            Dim Sql3 As String = "select top 1 idBodega from bodega where nombre ='" + Bodega + "' and estatus = 'A'"
            Com = New SqlCommand(Sql3, cn.conn)
            Rs = Com.ExecuteReader()
            Rs.Read()
            idbodega = Rs(0).ToString
            Rs.Close()
            cn.desconectar()


            cn.conectar()
            Dim Sql5 As String = "select idTicket from cliente where idBodega='" + idbodega + "' and  nombre like 'Venta' and estatus = 'A'"
            Com = New SqlCommand(Sql1, cn.conn)
            Rs = Com.ExecuteReader()
            Rs.Read()
            Dim idticket As String
            idticket = Rs(0).ToString
            Rs.Close()
            cn.desconectar()

            cn.conectar()
            Dim Sql6 As String = "select Max(folio) from Venta"
            Com = New SqlCommand(Sql1, cn.conn)
            Rs = Com.ExecuteReader()
            Rs.Read()
            Dim Folio As Int64

            Folio = Convert.ToInt64(If(Rs(0).ToString Is Nothing, 0, Rs(0).ToString)) + 1

            Rs.Close()
            cn.desconectar()

            cn.conectar()
            Dim cadena As String = "
INSERT INTO [dbo].[venta]
           ([idVenta]
           ,[fecha]
           ,[totalPagar]
           ,[cantidadPagada]
           ,[estatus]
           ,[idCliente]
           ,[idEmpleado]
           ,[idBodega]
           ,[tipoPago]
           ,[idCaja]
           ,[folio]
           ,[idTicket])
     VALUES
           ('" + clave + "'
           , getdate()
              ," + totalpagar + "
           ," + cantidadPagada + "
                 ,'" + estatus + "'
            ,'" + idCliente + "'
           ,'" + idempleado + "'
           ,'" + idbodega + "'
           ,'" + formapago + "'
           ,'" + idCaja + "'
           ," + Folio + "
           ,'" + idticket + "')"
            MsgBox(cadena)
            Com = New SqlCommand(cadena, cn.conn)
            Com.ExecuteNonQuery()
            cn.desconectar()

            MsgBox("cade")
        Catch ex As Exception
            MessageBox.Show("No se inserto debido a: " + ex.ToString)

        End Try
    End Sub


    Public Sub insertarVentaDetalle(ByVal producto As String, ByVal cantidad As String, ByVal totalneto As String, ByVal Bodega As String)
        Try

            cn.conectar()
            MsgBox("entro")

            Dim idProducto As String


            Dim Rs As SqlDataReader
            Dim Com As New SqlCommand




            Dim Sql1 As String = "select idProducto from producto where version ='" + producto + "' and estado = 'A'"

            Com = New SqlCommand(Sql1, cn.conn)
            Rs = Com.ExecuteReader()
            Rs.Read()
            idProducto = Rs(0).ToString
            Rs.Close()
            cn.desconectar()
            cn.conectar()
            Dim total As String
            Dim sql2 As String = "select precio from producto where version ='" + producto + "' and estado = 'A'"

            Com = New SqlCommand(sql2, cn.conn)
            Rs = Com.ExecuteReader()
            Rs.Read()
            total = Rs(0).ToString
            Rs.Close()
            cn.desconectar()

            Convert.ToDouble(total)


            cn.conectar()
            Dim cadena As String = "INSERT INTO [dbo].[ventaDetalle]
           ([idVentaDetalle]
           ,[idVenta]
           ,[idProducto]
           ,[cantidad]
           ,[total]
           ,[totalNeto])
           VALUES
           (newid()
           ,'" + clave + "'
           ,'" + idProducto + "'
           ," + cantidad + "
           ," + total + "
           ," + totalneto + ")"
            MsgBox(cadena)
            Com = New SqlCommand(cadena, cn.conn)
            Com.ExecuteNonQuery()
            cn.desconectar()
            updateExistencia(Bodega, producto, cantidad)

            MsgBox("cade")
        Catch ex As Exception
            MessageBox.Show("No se inserto debido a: " + ex.ToString)

        End Try
    End Sub


    Public Sub updateExistencia(ByVal bodega As String, ByVal producto As String, ByVal kilosvendidos As String)
        Try


            Dim Rs As SqlDataReader
            Dim Com As New SqlCommand
            cn.conectar()
            Dim idbodega As String
            Dim idproducto As String
            Dim Sql As String = "select idBodega from bodega where nombre ='" + bodega + "' and estatus = 'A'"

            Com = New SqlCommand(Sql, cn.conn)

            Rs = Com.ExecuteReader()
            Rs.Read()
            idbodega = Rs(0).ToString
            MsgBox(idbodega)
            Rs.Close()
            cn.desconectar()

            cn.conectar()
            Dim Sql2 As String = "select idproducto from producto where version ='" + producto + "' and estado= 'A'"
            Com = New SqlCommand(Sql2, cn.conn)
            Rs = Com.ExecuteReader()
            Rs.Read()
            idproducto = Rs(0).ToString
            MsgBox(idproducto)
            Rs.Close()
            cn.desconectar()


            Dim cadena As String = "
             UPDATE [dbo].[existenciaProductos]
             SET [cantidad] =  (cantidad - " + kilosvendidos + ") 
             WHERE [idBodega] = '" + idbodega + "' 
             and [idProducto] = '" + idproducto + "'"
            MsgBox(cadena)
            Rs.Close()
            cn.desconectar()
            cn.conectar()
            Com = New SqlCommand(cadena, cn.conn)
            MsgBox("cade")
            Com.ExecuteNonQuery()
            MsgBox("pus si salio carnal")
        Catch ex As Exception
            MessageBox.Show("No se actualizo debido a: " + ex.ToString)
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
             WHERE [idBodega] = '" + idbodega + "' 
             and [idProducto] = '" + idproducto + "'"
                MsgBox(cadena)
                Rs.Close()
                cn.desconectar()
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

