Imports System.Data.SqlClient
Public Class MetodosVenta

    Inherits conexionDB
        Public cn As New conexionDB
        Public adaptador As SqlDataAdapter
        Public dt As DataTable

    Public Sub llenarDatagridview(ByVal dgv As DataGridView)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select vn.idVenta,vn.tipoPago as 'Forma Pago' , bo.nombre, pr.version, vd.cantidad as Kilogramos, ex.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre as Empleado, case when cl.nombre ='' then cl.razonSocial else cl.nombre end as Cliente, vd.idventadetalle, vn.estatus  from  bodega bo  inner join venta vn on vn.idBodega = bo.idBodega inner join ventaDetalle  vd on vd.idVenta = vn.idVenta inner join producto 
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
            adaptador = New SqlDataAdapter("select vn.idVenta,vn.tipoPago as 'Forma Pago' , bo.nombre, pr.version, vd.cantidad as Kilogramos, ex.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre as Empleado, case when cl.nombre ='' then cl.razonSocial else cl.nombre end as Cliente, vd.idventadetalle, vn.estatus  from  bodega bo  inner join venta vn on vn.idBodega = bo.idBodega inner join ventaDetalle  vd on vd.idVenta = vn.idVenta inner join producto 
pr on pr.idProducto = vd.idProducto inner join existenciaProductos ex on  ex.idProducto = pr.idProducto and ex.idBodega = bo.idBodega inner join empleado as em on em.idEmpleado = vn.idEmpleado
inner join cliente as cl on cl.idCliente = vn.idCliente where vn.idVenta='" + id + "' and vd.estatus= 'A'", cn.conn)
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
            adaptador = New SqlDataAdapter("select vn.idVenta,vn.tipoPago as 'Forma Pago' , bo.nombre, pr.version, vd.cantidad as Kilogramos, ex.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre as Empleado, case when cl.nombre ='' then cl.razonSocial else cl.nombre end as Cliente, vd.idventadetalle, vn.estatus  from  bodega bo  inner join venta vn on vn.idBodega = bo.idBodega inner join ventaDetalle  vd on vd.idVenta = vn.idVenta inner join producto 
pr on pr.idProducto = vd.idProducto inner join existenciaProductos ex on  ex.idProducto = pr.idProducto and ex.idBodega = bo.idBodega inner join empleado as em on em.idEmpleado = vn.idEmpleado
inner join cliente as cl on cl.idCliente = vn.idCliente where
           bo.nombre like '" + filtro + "%' and vd.estatus= 'A'", cn.conn)
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
            adaptador = New SqlDataAdapter("select vn.idVenta,vn.tipoPago as 'Forma Pago' , bo.nombre, pr.version, vd.cantidad as Kilogramos, ex.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre as Empleado, case when cl.nombre ='' then cl.razonSocial else cl.nombre end as Cliente, vd.idventadetalle, vn.estatus  from  bodega bo  inner join venta vn on vn.idBodega = bo.idBodega inner join ventaDetalle  vd on vd.idVenta = vn.idVenta inner join producto 
pr on pr.idProducto = vd.idProducto inner join existenciaProductos ex on  ex.idProducto = pr.idProducto and ex.idBodega = bo.idBodega inner join empleado as em on em.idEmpleado = vn.idEmpleado
inner join cliente as cl on cl.idCliente = vn.idCliente
            where vn.fecha like '" + filtro + "%' and vd.estatus= 'A'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Friend Sub actualizar_credito()
        Throw New NotImplementedException()
    End Sub

    Public Sub llenarDatagridview_filtroCantidad(ByVal dgv As DataGridView, ByVal filtro As String)
            cn.conectar()
            Try
            adaptador = New SqlDataAdapter("select vn.idVenta,vn.tipoPago as 'Forma Pago' , bo.nombre, pr.version, vd.cantidad as Kilogramos, ex.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre as Empleado, case when cl.nombre ='' then cl.razonSocial else cl.nombre end as Cliente, vd.idventadetalle, vn.estatus  from  bodega bo  inner join venta vn on vn.idBodega = bo.idBodega inner join ventaDetalle  vd on vd.idVenta = vn.idVenta inner join producto 
pr on pr.idProducto = vd.idProducto inner join existenciaProductos ex on  ex.idProducto = pr.idProducto and ex.idBodega = bo.idBodega inner join empleado as em on em.idEmpleado = vn.idEmpleado
inner join cliente as cl on cl.idCliente = vn.idCliente
 where ex.cantidad like '" + filtro + "%' and vd.estatus= 'A'", cn.conn)
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
            adaptador = New SqlDataAdapter("select vn.idVenta,vn.tipoPago as 'Forma Pago' , bo.nombre, pr.version, vd.cantidad as Kilogramos, ex.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre as Empleado, case when cl.nombre ='' then cl.razonSocial else cl.nombre end as Cliente, vd.idventadetalle, vn.estatus  from  bodega bo  inner join venta vn on vn.idBodega = bo.idBodega inner join ventaDetalle  vd on vd.idVenta = vn.idVenta inner join producto 
pr on pr.idProducto = vd.idProducto inner join existenciaProductos ex on  ex.idProducto = pr.idProducto and ex.idBodega = bo.idBodega inner join empleado as em on em.idEmpleado = vn.idEmpleado
inner join cliente as cl on cl.idCliente = vn.idCliente
  where pr.version like '" + filtro + "%' and vd.estatus= 'A'", cn.conn)
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
            adaptador = New SqlDataAdapter("select vn.idVenta,vn.tipoPago as 'Forma Pago' , bo.nombre, pr.version, vd.cantidad as Kilogramos, ex.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre as Empleado, case when cl.nombre ='' then cl.razonSocial else cl.nombre end as Cliente, vd.idventadetalle, vn.estatus  from  bodega bo  inner join venta vn on vn.idBodega = bo.idBodega inner join ventaDetalle  vd on vd.idVenta = vn.idVenta inner join producto 
pr on pr.idProducto = vd.idProducto inner join existenciaProductos ex on  ex.idProducto = pr.idProducto and ex.idBodega = bo.idBodega inner join empleado as em on em.idEmpleado = vn.idEmpleado
inner join cliente as cl on cl.idCliente = vn.idCliente
 where pr.precio like '" + filtro + "%' and vd.estatus= 'A'", cn.conn)
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
            adaptador = New SqlDataAdapter("select vn.idVenta,vn.tipoPago as 'Forma Pago' , bo.nombre, pr.version, vd.cantidad as Kilogramos, ex.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre as Empleado, case when cl.nombre ='' then cl.razonSocial else cl.nombre end as Cliente, vd.idventadetalle, vn.estatus  from  bodega bo  inner join venta vn on vn.idBodega = bo.idBodega inner join ventaDetalle  vd on vd.idVenta = vn.idVenta inner join producto 
pr on pr.idProducto = vd.idProducto inner join existenciaProductos ex on  ex.idProducto = pr.idProducto and ex.idBodega = bo.idBodega inner join empleado as em on em.idEmpleado = vn.idEmpleado
inner join cliente as cl on cl.idCliente = vn.idCliente
 where em.nombre like '" + filtro + "% and vd.estatus= 'A''", cn.conn)
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
            adaptador = New SqlDataAdapter("select vn.idVenta,vn.tipoPago as 'Forma Pago' , bo.nombre, pr.version, vd.cantidad as Kilogramos, ex.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre as Empleado, case when  cl.nombre is null then cl.razonSocial else cl.nombre end as Cliente, vd.idventadetalle, vn.estatus  from  bodega bo  inner join venta vn on vn.idBodega = bo.idBodega inner join ventaDetalle  vd on vd.idVenta = vn.idVenta inner join producto 
pr on pr.idProducto = vd.idProducto inner join existenciaProductos ex on  ex.idProducto = pr.idProducto and ex.idBodega = bo.idBodega inner join empleado as em on em.idEmpleado = vn.idEmpleado
inner join cliente as cl on cl.idCliente = vn.idCliente
 where cl.nombre like '" + filtro + "%' and vd.estatus= 'A'", cn.conn)
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
            adaptador = New SqlDataAdapter("select vn.idVenta,vn.tipoPago as 'Forma Pago' , bo.nombre, pr.version, vd.cantidad as Kilogramos, ex.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre as Empleado, case when cl.nombre ='' then cl.razonSocial else cl.nombre end as Cliente, vd.idventadetalle, vn.estatus  from  bodega bo  inner join venta vn on vn.idBodega = bo.idBodega inner join ventaDetalle  vd on vd.idVenta = vn.idVenta inner join producto 
pr on pr.idProducto = vd.idProducto inner join existenciaProductos ex on  ex.idProducto = pr.idProducto and ex.idBodega = bo.idBodega inner join empleado as em on em.idEmpleado = vn.idEmpleado
inner join cliente as cl on cl.idCliente = vn.idCliente
 where vn. like '" + filtro + "%' and vd.estatus= 'A'", cn.conn)
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
            adaptador = New SqlDataAdapter("select vn.idVenta,vn.tipoPago as 'Forma Pago' , bo.nombre, pr.version, vd.cantidad as Kilogramos, ex.cantidad, pr.precio, vn.cantidadPagada, vn.totalPagar, vd.total, vd.totalNeto, vn.fecha, em.nombre as Empleado, case when cl.nombre ='' then cl.razonSocial else cl.nombre end as Cliente, vd.idventadetalle, vn.estatus  from  bodega bo  inner join venta vn on vn.idBodega = bo.idBodega inner join ventaDetalle  vd on vd.idVenta = vn.idVenta inner join producto 
pr on pr.idProducto = vd.idProducto inner join existenciaProductos ex on  ex.idProducto = pr.idProducto and ex.idBodega = bo.idBodega inner join empleado as em on em.idEmpleado = vn.idEmpleado
inner join cliente as cl on cl.idCliente = vn.idCliente
 where vn.idVenta like '" + filtro + "%' and vd.estatus= 'A'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub







    Public Sub llenarComboBodega(ByVal dgv As ComboBox, ByVal listIdBodega As List(Of String))
        cn.conectar()
        Try
            Dim cmd As New SqlCommand("select bo.nombre as Bodega , bo.idBodega from empleado em inner join  bodega bo on em.idBodega = bo.idBodega where bo.estatus = 'A'", cn.conn)
            listIdBodega.Clear()
            Dim rd As SqlDataReader = cmd.ExecuteReader()
            dgv.Items.Clear()
            While rd.Read
                dgv.Items.Add(rd("Bodega"))
                listIdBodega.Add(rd("idBodega"))
            End While
            dgv.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.Message)
        End Try
    End Sub





    Public Sub llenarComboProducto(ByVal dgv As DataGridView, ByVal t As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select  
    pr.idProducto,
    pr.version as Producto,
    pr.Precio as Precio,
    ep.cantidad as Existencia
    from bodega bo inner join existenciaProductos ep on bo.idBodega   = ep.idBodega  
    inner join producto pr on pr.idProducto = ep.idProducto  where ep.estatus = 'A'
    and bo.nombre='" + t + "'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
            dgv.Columns("idProducto").Visible = False
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.Message)
        End Try
    End Sub

    Public Sub llenarComboProductofiltro(ByVal dgv As DataGridView, ByVal bodega As String, ByVal pr As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select  
    pr.idProducto,
    pr.version as Producto,
    pr.Precio as Precio,
    ep.cantidad as Existencia
    from bodega bo inner join existenciaProductos ep on bo.idBodega   = ep.idBodega  
    inner join producto pr on pr.idProducto = ep.idProducto  where ep.estatus = 'A'
    and bo.nombre='" + bodega + "' and pr.version like '" + pr + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
            dgv.Columns("idProducto").Visible = False
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

            Dim idbodega As String


            Dim Rs As SqlDataReader
            Dim Com As New SqlCommand

            Com = New SqlCommand("Select newid()", cn.conn)
            Rs = Com.ExecuteReader
            Rs.Read()
            clave = Rs(0).ToString
            Rs.Close()




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
           ," + Convert.ToString(Replace(totalpagar.ToString(), ",", ".")) + "
           ," + Convert.ToString(Replace(cantidadPagada.ToString(), ",", ".")) + "
           ,'" + Convert.ToString(estatus) + "'
           ,'" + Convert.ToString(idCliente) + "'
           ,'" + Convert.ToString(Empleado) + "'
           ,'" + Convert.ToString(idbodega) + "'
           ,'" + Convert.ToString(formapago) + "'
           ,'" + Convert.ToString(idCaja) + "'
           ," + Convert.ToString(Folio) + "
           ,'" + Convert.ToString(idticket) + "')", cn.conn)
            Com.ExecuteNonQuery()
            cn.desconectar()


        Catch ex As Exception
            MessageBox.Show("No se inserto debido a: " + ex.ToString)

        End Try
    End Sub


    Public Sub insertarVentaDetalle(ByVal producto As String, ByVal cantidad As String, ByVal totalneto As String, ByVal Bodega As String, ByVal pagado As Boolean)
        Try

            cn.conectar()


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
           ,[totalNeto]
           ,[estatus])
           VALUES
           (newid()
           ,'" + clave + "'
           ,'" + idProducto + "'
           ," + Replace(cantidad.ToString(), ",", ".") + "
           ," + Replace(total.ToString(), ",", ".") + "
           ," + Replace(totalneto.ToString(), ",", ".") + "
           ,'A')"
            MsgBox(cadena)
            Com = New SqlCommand(cadena, cn.conn)
            Com.ExecuteNonQuery()
            cn.desconectar()

            If pagado Then
                updateExistencia(Bodega, producto, cantidad)
            End If

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
             SET [cantidad] =  (cantidad - " + Replace(kilosvendidos, ",", ".") + ") 
             WHERE [idBodega] = '" + idbodega + "' 
             and [idProducto] = '" + idproducto + "'"
            MsgBox(cadena)
            Rs.Close()
            cn.desconectar()
            cn.conectar()
            Com = New SqlCommand(cadena, cn.conn)
            Com.ExecuteNonQuery()
            Rs.Close()
            cn.desconectar()
        Catch ex As Exception
            MessageBox.Show("No se actualizo debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub updateExistencia(ByVal bodega As String, ByVal producto As String, ByVal kilosvendidos As String, ByVal venta As String)
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

            Com.ExecuteNonQuery()
            cn.desconectar()

            Dim cadena2 As String = "
             UPDATE [dbo].[venta]
             SET [estatus] = 'P'
             WHERE [idventa] = '" + venta + "'"

            Rs.Close()
            cn.desconectar()
            cn.conectar()
            Com = New SqlCommand(cadena2, cn.conn)

            Com.ExecuteNonQuery()
            cn.desconectar()


        Catch ex As Exception
            MessageBox.Show("No se actualizo debido a: " + ex.ToString)
        End Try
    End Sub


    Public Sub updateVentas(ByVal id As String, ByVal fecha As String, ByVal totalPagar As String, ByVal cantidadPagada As String, ByVal idcliente As String, ByVal empleado As String, ByVal bodega As String, ByVal tipoPago As String)
        Try
            clave = ""
            cn.conectar()
            Dim idbodega As String
            Dim Rs As SqlDataReader
            Dim Com As New SqlCommand
            Com = New SqlCommand("Select newid()", cn.conn)
            Rs = Com.ExecuteReader
            Rs.Read()
            clave = Rs(0).ToString
            Rs.Close()
            cn.conectar()
            Dim Sql3 As String = "select top 1 idBodega from bodega where nombre ='" + bodega + "' and estatus = 'A'"
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
            Dim cadena As String =
      "UPDATE [dbo].[venta]
      set
       [totalPagar] = " + totalPagar + "
      ,[cantidadPagada] = " + cantidadPagada + "
      ,[idEmpleado] = '" + empleado + "'
      ,[idBodega] = '" + idbodega + "'
      ,[tipoPago] = '" + tipoPago + "'
	  ,[idTicket] = '" + idticket + "' where idventa = '" + id + "'"
            Com = New SqlCommand(cadena, cn.conn)
            Com.ExecuteNonQuery()
            cn.desconectar()

        Catch ex As Exception
            MessageBox.Show("No se inserto debido a: " + ex.ToString)

        End Try
    End Sub





    Public Sub insertarVentaDetalleUpdate(ByVal claveu As String, ByVal producto As String, ByVal cantidad As String, ByVal totalneto As String, ByVal Bodega As String)
        Try

            cn.conectar()

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
           ,[totalNeto]
           ,[estatus])
           VALUES
           (newid()
           ,'" + claveu + "'
           ,'" + idProducto + "'
           ," + cantidad + "
           ," + total + "
           ," + totalneto + "
           ,'A')"
            MsgBox(cadena)
            Com = New SqlCommand(cadena, cn.conn)
            Com.ExecuteNonQuery()
            cn.desconectar()

        Catch ex As Exception
            MessageBox.Show("No se inserto debido a: " + ex.ToString)

        End Try
    End Sub


    Public Sub VentaDetalleUpdate(ByVal clavev As String, ByVal clavevd As String, ByVal producto As String, ByVal cantidad As String, ByVal totalneto As String, ByVal Bodega As String, ByVal flag As Boolean, ByVal act As Boolean)
        Try

            cn.conectar()


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

            If flag Then
                Com = New SqlCommand("UPDATE [dbo].[ventaDetalle]
            SET 
            [estatus] =  'B'
            WHERE [idventa] = '" + clavev + "'", cn.conn)
                Com.ExecuteNonQuery()
                cn.desconectar()

                cn.conectar()
            End If

            Dim cadena As String = "UPDATE [dbo].[ventaDetalle]
       SET 
       [cantidad] = " + cantidad + "
      ,[total] = " + total + "
      ,[totalNeto] =  " + totalneto + "
      , [estatus] =  'A'
        WHERE [idVentaDetalle] = '" + clavevd + "'"

            MsgBox(cadena)
            Com = New SqlCommand(cadena, cn.conn)
            Com.ExecuteNonQuery()
            cn.desconectar()

        Catch ex As Exception
            MessageBox.Show("No se inserto debido a: " + ex.ToString)

        End Try
    End Sub

    Public Sub actualizar_credito(ByVal idcliente As String, ByVal saldo As String)
        Try

            Dim Rs As SqlDataReader
            Dim Com As New SqlCommand

            cn.conectar()

            Dim cadena As String = "
UPDATE [dbo].[credito]
   SET saldo = saldo + (" + saldo + ")  WHERE [idCliente] = '" + idcliente + "'"

            MsgBox(cadena)
            Com = New SqlCommand(cadena, cn.conn)
            Com.ExecuteNonQuery()
            cn.desconectar()
        Catch ex As Exception
            MessageBox.Show("No se inserto debido a: " + ex.ToString)

        End Try
    End Sub

    Public Sub actualizar_totalpagado(ByVal saldo As String)
        Try

            Dim Com As New SqlCommand
            cn.conectar()
            Dim cadena As String = "UPDATE [dbo].[venta] SET cantidadPagada = cantidadPagada + (" + saldo + ")  WHERE [idCliente] = '" + clave + "'"

            MsgBox(cadena)
            Com = New SqlCommand(cadena, cn.conn)
            Com.ExecuteNonQuery()
            cn.desconectar()
        Catch ex As Exception
            MessageBox.Show("No se inserto debido a: " + ex.ToString)

        End Try
    End Sub



    Public Sub actualizar_totalpagado(ByVal saldo As String, ByVal idv As String)
        Try

            Dim Com As New SqlCommand
            cn.conectar()
            Dim cadena As String = "UPDATE [dbo].[venta] SET cantidadPagada = cantidadPagada + (" + saldo + ")  WHERE [idCliente] = '" + idv + "'"

            MsgBox(cadena)
            Com = New SqlCommand(cadena, cn.conn)
            Com.ExecuteNonQuery()
            cn.desconectar()
        Catch ex As Exception
            MessageBox.Show("No se inserto debido a: " + ex.ToString)

        End Try
    End Sub

    Public Function infcliente(ByVal nombre As String) As String()
        Dim Rs As SqlDataReader
        Dim Com As New SqlCommand
        Dim datos(3) As String

        cn.conectar()
        Dim sql2 As String = "select  idCliente from cliente where nombre ='" + nombre + "' or razonSocial = '" + nombre + "'"
        Com = New SqlCommand(sql2, cn.conn)
        Rs = Com.ExecuteReader()
        Rs.Read()
        datos(0) = Rs(0).ToString
        Rs.Close()
        cn.desconectar()

        cn.conectar()
        Dim sql As String = "select cr.limiteCredito from cliente cl inner join credito cr on cr.idCliente = cl.idCliente where nombre ='" + nombre + "' or razonSocial = '" + nombre + "'"
        Com = New SqlCommand(sql, cn.conn)
        Rs = Com.ExecuteReader()
        Rs.Read()
        datos(1) = Rs(0).ToString
        Rs.Close()
        cn.desconectar()

        cn.conectar()
        Dim sq As String = "select cr.saldo from cliente cl inner join credito cr on cr.idCliente = cl.idCliente where nombre ='" + nombre + "' or razonSocial = '" + nombre + "'"
        Com = New SqlCommand(sq, cn.conn)
        Rs = Com.ExecuteReader()
        Rs.Read()
        datos(2) = Rs(0).ToString
        Rs.Close()
        cn.desconectar()

        Return datos
    End Function


    Public Sub actualizar_ventasa(ByVal venta As String)
        Try

            Dim Rs As SqlDataReader
            Dim Com As New SqlCommand
            Dim cadena2 As String = "
             UPDATE [dbo].[venta]
             SET [estatus] = 'P'
             WHERE [idventa] = '" + venta + "'"

            Rs.Close()
            cn.desconectar()
            cn.conectar()
            Com = New SqlCommand(cadena2, cn.conn)

            Com.ExecuteNonQuery()
            cn.desconectar()
        Catch
        End Try
    End Sub


    Public Function existenciaAlmacen(ByVal producto As String, ByVal bodega As String) As Double
        Dim Rs As SqlDataReader
        Dim Com As New SqlCommand
        Dim datos As Double

        cn.conectar()
        Dim sql2 As String =
    "select ep.cantidad from bodega bo inner join existenciaProductos ep on bo.idBodega   = ep.idBodega  
    inner join producto pr on pr.idProducto = ep.idProducto  where ep.estatus = 'A' and pr.version like '" + producto + "' 
    and bo.nombre like '" + bodega + "'"
        Com = New SqlCommand(sql2, cn.conn)
        Rs = Com.ExecuteReader()
        Rs.Read()
        datos = Rs(0).ToString
        Rs.Close()
        cn.desconectar()

        Return datos
    End Function


    Public Sub insertarVentaYVentaDetalle(ByVal tblVentaDetalle As DataGridView, ByVal formaPago As String, ByVal totalPagar As Double, ByVal cantidadPagada As Double, idCaja As String, ByVal idCliente As String, ByVal idEmpleado As String, ByVal idbodega As String, ByVal espera As Boolean)
        Try
            conectar()
            Dim cmd As New SqlCommand("")
            Dim transac As SqlTransaction = conn.BeginTransaction("tran")
            cmd.Connection = conn
            cmd.Transaction = transac
            Try
                'ByVal fecha As String, ByVal totalpagar As String, ByVal cantidadPagada As String, ByVal cliente As String, ByVal Empleado As String, ByVal Bodega As String, ByVal estatus As String, ByVal formapago As String, ByVal idCaja As String, ByVal idCliente As String
                Dim estatus As String = If(espera, "E", If(cantidadPagada = totalPagar, "P", "D"))

                Dim Com = New SqlCommand("Select newid()", cn.conn)
                Dim idVenta As String = ""
                Dim Rs As SqlDataReader
                Rs = Com.ExecuteReader
                Rs.Read()
                idVenta = Rs(0).ToString
                Rs.Close()

                cmd = New SqlCommand("
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
           ('" + idVenta + "'
           , getdate()
           ," + Convert.ToString(Replace(totalPagar.ToString(), ",", ".")) + "
           ," + Convert.ToString(Replace(cantidadPagada.ToString(), ",", ".")) + "
           ,'" + Convert.ToString(estatus) + "'
           ,'" + Convert.ToString(idCliente) + "'
           ,'" + Convert.ToString(idEmpleado) + "'
           ,'" + Convert.ToString(idbodega) + "'
           ,'" + Convert.ToString(formaPago) + "'
           ,'" + Convert.ToString(idCaja) + "'
           ," + "(select max(folio)+1 from venta)" + "
           ," + "(select top 1 idTicket from ticket where nombre = 'Venta')" + ")", cn.conn)
                If cmd.ExecuteNonQuery() Then ' ASTA AQUI SE HA REALIZADO LA VENTA
                    Dim cmd2 As New SqlCommand("", conn)
                    cmd2.Transaction = transac
                    Dim insertDV As String = "insert into ventaDetalle values "
                    Dim cont As Int16 = 0
                    For Each row As DataGridViewRow In tblVentaDetalle.Rows
                        Dim kilos As String = Replace(row.Cells(2).Value.ToString, ".", "")
                        kilos = Replace(kilos, ",", ".")
                        Dim precio As String = Replace(row.Cells(3).Value.ToString, ".", "")
                        precio = Replace(precio, ",", ".")
                        Dim neto As String = Replace(row.Cells(4).Value.ToString, ".", "")
                        neto = Replace(neto, ",", ".")
                        insertDV = insertDV + "(newid(),'" + idVenta + "','" + row.Cells(0).Value.ToString + "'," + kilos + "," + precio + "," + neto + ",'A')"
                        cont += 1
                        If cont = tblVentaDetalle.Rows.Count Then
                        Else
                            insertDV = insertDV + ","
                        End If
                    Next
                    cmd2.CommandText = insertDV
                    If cmd2.ExecuteNonQuery Then 'asta qui ya esta lo detalle de venta
                        'actualizar exitencias de produtos
                        Dim cmd3 As New SqlCommand("", conn)
                        cmd3.Transaction = transac
                        Dim updateExistencias As String = ""
                        For Each row As DataGridViewRow In tblVentaDetalle.Rows
                            Dim kilos As String = Replace(row.Cells(2).Value.ToString, ".", "")
                            kilos = Replace(kilos, ",", ".")
                            Dim idProducto As String = row.Cells(0).Value.ToString
                            updateExistencias = updateExistencias + " update existenciaProductos set cantidad = cantidad - " + kilos + " where idProducto = '" + idProducto + "'"
                        Next
                        cmd3.CommandText = updateExistencias
                        If cmd3.ExecuteNonQuery Then 'asta aqui esta la actualizacion de existencias
                            Dim cmd4 As New SqlCommand("", conn)
                            cmd4.Transaction = transac
                            Dim cantpagada1 As String = Replace(cantidadPagada.ToString, ".", "")
                            cantpagada1 = Replace(cantidadPagada, ",", ".")
                            cmd4.CommandText = "update contabilidadCaja set total = total + " + cantpagada1.ToString() + " where idCaja = '" + idCaja + "'"
                            If cmd4.ExecuteNonQuery Then
                                If formaPago = "Credito" Then
                                    Dim cmd5 As New SqlCommand("", conn)
                                    cmd5.Transaction = transac

                                    Dim credito As Double = totalPagar - cantidadPagada
                                    Dim credit As String = Replace(credito.ToString, ".", "")
                                    credit = Replace(credit, ",", ".")
                                    cmd5.CommandText = "update credito set saldo = saldo + " + credit + " where idCliente = '" + idCliente + "'"
                                    If cmd5.ExecuteNonQuery() Then
                                        transac.Commit()
                                        MsgBox("Exito")
                                    Else
                                        transac.Rollback()
                                    End If
                                Else
                                    transac.Commit()
                                    MsgBox("Exito")
                                End If
                            Else
                                transac.Rollback()
                            End If
                        Else
                            transac.Rollback()
                        End If
                    Else
                        transac.Rollback()
                    End If
                Else
                    transac.Rollback()
                End If

            Catch ex As Exception
                MsgBox("No se pudo realizar la venta. Intente de nuevo." + ex.Message)
                transac.Rollback()
            End Try

        Catch ex As Exception
            MsgBox("Error al iniciar la Transaccion: " + ex.Message)
        End Try
    End Sub

End Class

