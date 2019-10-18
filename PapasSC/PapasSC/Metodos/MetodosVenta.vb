Imports System.Data.SqlClient
Public Class MetodosVenta

    Inherits conexionDB
        Public cn As New conexionDB
        Public adaptador As SqlDataAdapter
        Public dt As DataTable

    Public Sub llenarDatagridview(ByVal dgv As DataGridView)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select vn.idVenta,vn.tipoPago , bo.nombre, pr.version, vd.cantidad as Kilogramos, ex.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre as Empleado, cl.nombre as Cliente   from  bodega bo  inner join venta vn on vn.idBodega = bo.idBodega inner join ventaDetalle  vd on vd.idVenta = vn.idVenta inner join producto 
pr on pr.idProducto = vd.idProducto inner join existenciaProductos ex on  ex.idProducto = pr.idProducto and ex.idBodega = bo.idBodega inner join empleado as em on em.idEmpleado = vn.idEmpleado
inner join cliente as cl on cl.idCliente = vn.idCliente", cn.conn)
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
            adaptador = New SqlDataAdapter("select vn.idVenta,vn.tipoPago , bo.nombre, pr.version, vd.cantidad as Kilogramos, ex.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre as Empleado, cl.nombre as Cliente   from  bodega bo  inner join venta vn on vn.idBodega = bo.idBodega inner join ventaDetalle  vd on vd.idVenta = vn.idVenta inner join producto 
pr on pr.idProducto = vd.idProducto inner join existenciaProductos ex on  ex.idProducto = pr.idProducto and ex.idBodega = bo.idBodega inner join empleado as em on em.idEmpleado = vn.idEmpleado
inner join cliente as cl on cl.idCliente = vn.idCliente where vn.idVenta='" + id + "'", cn.conn)
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
            adaptador = New SqlDataAdapter("select vn.idVenta,vn.tipoPago , bo.nombre, pr.version, vd.cantidad as Kilogramos, ex.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre as Empleado, cl.nombre as Cliente   from  bodega bo  inner join venta vn on vn.idBodega = bo.idBodega inner join ventaDetalle  vd on vd.idVenta = vn.idVenta inner join producto 
pr on pr.idProducto = vd.idProducto inner join existenciaProductos ex on  ex.idProducto = pr.idProducto and ex.idBodega = bo.idBodega inner join empleado as em on em.idEmpleado = vn.idEmpleado
inner join cliente as cl on cl.idCliente = vn.idCliente where vn.estatus='A'
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
            adaptador = New SqlDataAdapter("select vn.idVenta,vn.tipoPago , bo.nombre, pr.version, vd.cantidad as Kilogramos, ex.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre as Empleado, cl.nombre as Cliente   from  bodega bo  inner join venta vn on vn.idBodega = bo.idBodega inner join ventaDetalle  vd on vd.idVenta = vn.idVenta inner join producto 
pr on pr.idProducto = vd.idProducto inner join existenciaProductos ex on  ex.idProducto = pr.idProducto and ex.idBodega = bo.idBodega inner join empleado as em on em.idEmpleado = vn.idEmpleado
inner join cliente as cl on cl.idCliente = vn.idCliente where
            and bo.nombre like '" + filtro + "%'", cn.conn)
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
            adaptador = New SqlDataAdapter("select vn.idVenta,vn.tipoPago , bo.nombre, pr.version, vd.cantidad as Kilogramos, ex.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre as Empleado, cl.nombre as Cliente   from  bodega bo  inner join venta vn on vn.idBodega = bo.idBodega inner join ventaDetalle  vd on vd.idVenta = vn.idVenta inner join producto 
pr on pr.idProducto = vd.idProducto inner join existenciaProductos ex on  ex.idProducto = pr.idProducto and ex.idBodega = bo.idBodega inner join empleado as em on em.idEmpleado = vn.idEmpleado
inner join cliente as cl on cl.idCliente = vn.idCliente
            where vn.fecha like '" + filtro + "%'", cn.conn)
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
            adaptador = New SqlDataAdapter("select vn.idVenta,vn.tipoPago as Forma_Pago, bo.nombre, pr.version, vd.cantidad as Kilogramos, ex.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre as Empleado, cl.nombre as Cliente   from  bodega bo  inner join venta vn on vn.idBodega = bo.idBodega inner join ventaDetalle  vd on vd.idVenta = vn.idVenta inner join producto 
pr on pr.idProducto = vd.idProducto inner join existenciaProductos ex on  ex.idProducto = pr.idProducto and ex.idBodega = bo.idBodega inner join empleado as em on em.idEmpleado = vn.idEmpleado
inner join cliente as cl on cl.idCliente = vn.idCliente
 where ex.cantidad like '" + filtro + "%'", cn.conn)
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
            adaptador = New SqlDataAdapter("select vn.idVenta,vn.tipoPago as Forma_Pago, bo.nombre, pr.version, vd.cantidad as Kilogramos, ex.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre as Empleado, cl.nombre as Cliente   from  bodega bo  inner join venta vn on vn.idBodega = bo.idBodega inner join ventaDetalle  vd on vd.idVenta = vn.idVenta inner join producto 
pr on pr.idProducto = vd.idProducto inner join existenciaProductos ex on  ex.idProducto = pr.idProducto and ex.idBodega = bo.idBodega inner join empleado as em on em.idEmpleado = vn.idEmpleado
inner join cliente as cl on cl.idCliente = vn.idCliente
  where pr.version like '" + filtro + "%'", cn.conn)
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
            adaptador = New SqlDataAdapter("select vn.idVenta,vn.tipoPago as Forma_Pago, bo.nombre, pr.version, vd.cantidad as Kilogramos, ex.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre as Empleado, cl.nombre as Cliente   from  bodega bo  inner join venta vn on vn.idBodega = bo.idBodega inner join ventaDetalle  vd on vd.idVenta = vn.idVenta inner join producto 
pr on pr.idProducto = vd.idProducto inner join existenciaProductos ex on  ex.idProducto = pr.idProducto and ex.idBodega = bo.idBodega inner join empleado as em on em.idEmpleado = vn.idEmpleado
inner join cliente as cl on cl.idCliente = vn.idCliente
 where pr.precio like '" + filtro + "%'", cn.conn)
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
            adaptador = New SqlDataAdapter("select vn.idVenta,vn.tipoPago as Forma_Pago, bo.nombre, pr.version, vd.cantidad as Kilogramos, ex.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre as Empleado, cl.nombre as Cliente   from  bodega bo  inner join venta vn on vn.idBodega = bo.idBodega inner join ventaDetalle  vd on vd.idVenta = vn.idVenta inner join producto 
pr on pr.idProducto = vd.idProducto inner join existenciaProductos ex on  ex.idProducto = pr.idProducto and ex.idBodega = bo.idBodega inner join empleado as em on em.idEmpleado = vn.idEmpleado
inner join cliente as cl on cl.idCliente = vn.idCliente
 where em.nombre like '" + filtro + "%'", cn.conn)
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
            adaptador = New SqlDataAdapter("select vn.idVenta,vn.tipoPago as Forma_Pago, bo.nombre, pr.version, vd.cantidad as Kilogramos, ex.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre as Empleado, cl.nombre as Cliente   from  bodega bo  inner join venta vn on vn.idBodega = bo.idBodega inner join ventaDetalle  vd on vd.idVenta = vn.idVenta inner join producto 
pr on pr.idProducto = vd.idProducto inner join existenciaProductos ex on  ex.idProducto = pr.idProducto and ex.idBodega = bo.idBodega inner join empleado as em on em.idEmpleado = vn.idEmpleado
inner join cliente as cl on cl.idCliente = vn.idCliente
 where cl.nombre like '" + filtro + "%'", cn.conn)
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
            adaptador = New SqlDataAdapter("select vn.idVenta,vn.tipoPago as Forma_Pago, bo.nombre, pr.version, vd.cantidad as Kilogramos, ex.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre as Empleado, cl.nombre as Cliente   from  bodega bo  inner join venta vn on vn.idBodega = bo.idBodega inner join ventaDetalle  vd on vd.idVenta = vn.idVenta inner join producto 
pr on pr.idProducto = vd.idProducto inner join existenciaProductos ex on  ex.idProducto = pr.idProducto and ex.idBodega = bo.idBodega inner join empleado as em on em.idEmpleado = vn.idEmpleado
inner join cliente as cl on cl.idCliente = vn.idCliente
 where vn. like '" + filtro + "%'", cn.conn)
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
            adaptador = New SqlDataAdapter("select vn.idVenta,vn.tipoPago as Forma_Pago, bo.nombre, pr.version, vd.cantidad as Kilogramos, ex.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre as Empleado, cl.nombre as Cliente   from  bodega bo  inner join venta vn on vn.idBodega = bo.idBodega inner join ventaDetalle  vd on vd.idVenta = vn.idVenta inner join producto 
pr on pr.idProducto = vd.idProducto inner join existenciaProductos ex on  ex.idProducto = pr.idProducto and ex.idBodega = bo.idBodega inner join empleado as em on em.idEmpleado = vn.idEmpleado
inner join cliente as cl on cl.idCliente = vn.idCliente
 where vn.idVenta like '" + filtro + "%'", cn.conn)
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

    Public Sub insertarVenta(ByVal fecha As String, ByVal totalpagar As String, ByVal cantidadPagada As String, ByVal cliente As String, ByVal Empleado As String, ByVal Bodega As String, ByVal estatus As String, ByVal formapago As String, ByVal idCaja As String, ByVal idCliente As String)
        Try
            clave = ""
            cn.conectar()
            MsgBox("entro")


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
            Dim Sql5 As String = "select idTicket from ticket where nombre like 'Venta'"
            Com = New SqlCommand(Sql5, cn.conn)
            Rs = Com.ExecuteReader()
            Rs.Read()
            Dim idticket As String
            idticket = Rs(0).ToString
            Rs.Close()
            cn.desconectar()

            cn.conectar()
            Dim Sql6 As String = "select Max(folio) from Venta"
            Com = New SqlCommand(Sql6, cn.conn)
            Rs = Com.ExecuteReader()
            Rs.Read()
            Dim Folio As Int64

            If Rs(0).ToString <> String.Empty Then
                Folio = Convert.ToString(Convert.ToInt64(Convert.ToString(Rs(0).ToString)) + 1)
            Else
                Folio = Convert.ToString(1)
            End If


            Rs.Close()
            cn.desconectar()

            cn.conectar()

            Com = New SqlCommand("
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
           ('" + Convert.ToString(clave) + "'
           , getdate()
           ," + Convert.ToString(totalpagar) + "
           ," + Convert.ToString(cantidadPagada) + "
           ,'" + Convert.ToString(estatus) + "'
           ,'" + Convert.ToString(idCliente) + "'
           ,'" + Convert.ToString(idempleado) + "'
           ,'" + Convert.ToString(idbodega) + "'
           ,'" + Convert.ToString(formapago) + "'
           ,'" + Convert.ToString(idCaja) + "'
           ," + Convert.ToString(Folio) + "
           ,'" + Convert.ToString(idticket) + "')", cn.conn)
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






End Class

