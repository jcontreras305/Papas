Imports System.Data.SqlClient
Imports PapasSC

Public Class MetodosCaja
    Inherits conexionDB

    '##########################################################################################################
    '####################################### METODOS PARA CAJA ################################################
    '##########################################################################################################
    Private busqueda As String = "select idCaja , cj.nombre as Caja,cj.clave as Referencia, cj.estatus as Estatus,cj.fase as Fase, cj.limiteEfectivo, bd.nombre as Bodega, cj.explicito as ValoresExplicitos from caja as  cj left join bodega as bd
on cj.idBodega = bd.idBodega "


    Public Sub seleccioarCajas(ByVal tblCaja As DataGridView)
        Try
            conectar()
            Dim cmd As New SqlCommand(busqueda + "where not cj.estatus = 'B'", conn)
            If cmd.ExecuteNonQuery Then
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                tblCaja.DataSource = dt
            Else
                MsgBox("Error")
            End If
        Catch exc As Exception
            MsgBox("Error")
        End Try
        desconectar()
    End Sub

    Public Sub seleccioarCajas(ByVal tblCaja As DataGridView, ByVal filtro As String)
        Try
            conectar()
            Dim cmd As New SqlCommand(busqueda & " where bd.nombre like '%" & filtro & "%' or cj.nombre like '%" & filtro & "%' or cj.fase like '%" & filtro & "%' and NOT cj.estatus = 'B'", conn)
            If cmd.ExecuteNonQuery Then
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                tblCaja.DataSource = dt
            Else
                MsgBox("Error")
            End If
        Catch exc As Exception
            MsgBox(exc.Message)
        End Try
        desconectar()
    End Sub

    Public Sub insertarCaja(ByVal datos() As String)
        Try
            conectar()
            Dim cmd As New SqlCommand("sp_Insertar_Caja", conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 20).Value = datos(0)
            cmd.Parameters.Add("@clave", SqlDbType.VarChar, 5).Value = datos(1)
            cmd.Parameters.Add("@estatus", SqlDbType.Char, 1).Value = datos(2)
            cmd.Parameters.Add("@fase", SqlDbType.VarChar, 20).Value = datos(3)
            cmd.Parameters.Add("@limiteEfectivo", SqlDbType.Float).Value = datos(4)
            cmd.Parameters.Add("@explicito", SqlDbType.Char, 1).Value = datos(6)
            cmd.Parameters.Add("@idBodega ", SqlDbType.VarChar, 36).Value = datos(5)
            If cmd.ExecuteNonQuery Then
                MsgBox("Se agrego la caja " + datos(0))
            Else
                MsgBox("Error al agregar la caja")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub

    Public Sub actualizarcaja(ByVal datos() As String, ByVal idCaja As String)
        Try
            conectar()
            Dim cmd As New SqlCommand("sp_Actualizar_Caja", conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idCaja", SqlDbType.VarChar, 36).Value = idCaja
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 20).Value = datos(0)
            cmd.Parameters.Add("@clave", SqlDbType.VarChar, 5).Value = datos(1)
            cmd.Parameters.Add("@estatus", SqlDbType.Char, 1).Value = datos(2)
            cmd.Parameters.Add("@fase", SqlDbType.VarChar, 20).Value = datos(3)
            cmd.Parameters.Add("@limiteEfectivo", SqlDbType.Float).Value = datos(4)
            cmd.Parameters.Add("@explicito", SqlDbType.Char, 1).Value = datos(6)
            cmd.Parameters.Add("@idBodega ", SqlDbType.VarChar, 36).Value = datos(5)
            If cmd.ExecuteNonQuery Then
                MsgBox("Se actualizo la caja " + datos(0))
            Else
                MsgBox("Error al agregar la caja")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub

    Public Sub eliminarCaja(ByVal idCaja As String)
        Try
            conectar()
            Dim cmd As New SqlCommand("update caja set estatus = 'B' where idCaja = '" + idCaja + "'", conn)
            If cmd.ExecuteNonQuery Then
                MsgBox("Se ha eliminado dla Caja")
            Else
                MsgBox("Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub

    Public Sub nombreBodegas(ByVal cmdBodega As ComboBox, ByVal idsBodega As List(Of String))
        Try
            conectar()
            Dim cmd As New SqlCommand("select idBodega , nombre, estatus from bodega ", conn)
            Dim rd As SqlDataReader = cmd.ExecuteReader
            idsBodega.Clear()
            While rd.Read()
                cmdBodega.Items.Add(rd("nombre"))
                idsBodega.Add(rd("idBodega"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub

    Public Sub cajasEstatus(ByVal cmbCaja As ComboBox, ByVal idsCaja As List(Of String), ByVal listEstatus As List(Of String), ByVal listCajaExplicito As List(Of String))
        Try
            conectar()
            Dim cmd As New SqlCommand("select nombre, idCaja, fase , explicito from caja where not estatus='B'", conn)
            Dim rd As SqlDataReader = cmd.ExecuteReader()
            idsCaja.Clear()
            listEstatus.Clear()
            cmbCaja.Items.Clear()
            While rd.Read
                cmbCaja.Items.Add(rd("nombre"))
                idsCaja.Add(rd("idCaja"))
                listEstatus.Add(rd("fase"))
                listCajaExplicito.Add(rd("explicito"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub



    Public Sub seleccionarNombreCajas(ByVal cmbCaja As ComboBox, ByVal listIds As List(Of String))
        Try
            conectar()
            Dim cmd As New SqlCommand("select nombre, idCaja from caja where not estatus='B'", conn)
            Dim rd As SqlDataReader = cmd.ExecuteReader()
            listIds.Clear()
            While rd.Read
                cmbCaja.Items.Add(rd("nombre"))
                listIds.Add(rd("idCaja"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '##########################################################################################################
    '################################### METODOS PARA CORTE CAJA ##############################################
    '##########################################################################################################
    Public Function validarUsuarioCorteCaja(ByVal idEmpleado As String, ByVal idCaja As String) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("select top 1 idEmpleado from corteCaja where fechaInicio = (select  top 1 MAX(fechaInicio) from corteCaja where idCaja = '" + idCaja + "')", conn)
            Dim idemp As String = ""
            Using rd = cmd.ExecuteReader
                If rd.HasRows Then
                    While rd.Read
                        idemp = rd.Item("idEmpleado").ToString
                    End While
                    If idEmpleado.Equals(idemp) Then
                        desconectar()
                        Return True
                    Else
                        desconectar()
                        Return False
                    End If
                Else
                    Return False
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            desconectar()
            Return False
        End Try
    End Function

    Public Function iniciar_Caja_Explicito(ByVal idCaja As String, ByVal idEmpleado As String, ByVal montoInicial As String, ByVal arrayMonedas() As Integer) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("sp_abrirCaja_Explicito", conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idCaja", SqlDbType.VarChar, 36).Value = idCaja
            cmd.Parameters.Add("@idEmpleado", SqlDbType.VarChar, 36).Value = idEmpleado
            cmd.Parameters.Add("@monotoInicial", SqlDbType.Float).Value = montoInicial
            Dim fechaInc As String = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")
            cmd.Parameters.Add("@fechaInicio", SqlDbType.SmallDateTime).Value = fechaInc
            cmd.Parameters.Add("@b1000", SqlDbType.Int).Value = arrayMonedas(0)
            cmd.Parameters.Add("@b500", SqlDbType.Int).Value = arrayMonedas(1)
            cmd.Parameters.Add("@b200", SqlDbType.Int).Value = arrayMonedas(2)
            cmd.Parameters.Add("@b100", SqlDbType.Int).Value = arrayMonedas(3)
            cmd.Parameters.Add("@b50", SqlDbType.Int).Value = arrayMonedas(4)
            cmd.Parameters.Add("@b20", SqlDbType.Int).Value = arrayMonedas(5)
            cmd.Parameters.Add("@m20", SqlDbType.Int).Value = arrayMonedas(6)
            cmd.Parameters.Add("@m10", SqlDbType.Int).Value = arrayMonedas(7)
            cmd.Parameters.Add("@m5", SqlDbType.Int).Value = arrayMonedas(8)
            cmd.Parameters.Add("@m2", SqlDbType.Int).Value = arrayMonedas(9)
            cmd.Parameters.Add("@m1", SqlDbType.Int).Value = arrayMonedas(10)
            cmd.Parameters.Add("@m05", SqlDbType.Int).Value = arrayMonedas(11)
            If cmd.ExecuteNonQuery Then
                MsgBox("Listo")
                Return True
            Else
                MsgBox("Error")
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Public Function iniciar_Caja(ByVal idCaja As String, ByVal empleado As String, ByVal montoInicial As String) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("sp_Iniciar_Caja", conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@montoInicial", SqlDbType.Float).Value = montoInicial
            Dim fechaInc As String = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")
            cmd.Parameters.Add("@fechaInicio", SqlDbType.SmallDateTime).Value = fechaInc
            cmd.Parameters.Add("@idCaja", SqlDbType.VarChar, 36).Value = idCaja
            cmd.Parameters.Add("@idEmpleado", SqlDbType.VarChar, 36).Value = empleado
            If cmd.ExecuteNonQuery Then
                MsgBox("Listo")
                Return True
            Else
                MsgBox("Error")
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        desconectar()
    End Function

    Public Function cerrar_Caja(ByVal idCaja As String) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("sp_Cerrar_Caja", conn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim fechaFin As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            cmd.Parameters.Add("@fechaFin", SqlDbType.SmallDateTime).Value = fechaFin
            cmd.Parameters.Add("@idCaja", SqlDbType.VarChar, 36).Value = idCaja
            If cmd.ExecuteNonQuery Then
                MsgBox("Se ha cerrado la caja")
            Else
                MsgBox("Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
        Return Nothing
    End Function

    '##########################################################################################################
    '################################### METODOS PARA CAJA/GENERAL ############################################
    '##########################################################################################################

    Private busquedaVentasCaja As String = "
select folio ,  case when vt.estatus = 'D' then 'Deuda' when vt.estatus = 'P' then 'Pagada' else 'Espera' end as estatus ,  case when  cl.nombre = '' then cl.razonSocial else cl.nombre end as Nombre , fecha ,vt.cantidadPagada , vt.totalPagar
from venta as vt left join cliente as cl on cl.idCliente = vt.idCliente 
left join caja as cj on cj.idCaja = vt.idCaja
left join credito as cr on cr.idCliente = cl.idCliente
left join empleado as emp on emp.idEmpleado = vt.idEmpleado "

    Public Sub select_ventasCajas(ByVal tblVentasCaja As DataGridView, ByVal busqueda As String, ByVal filtro As String, ByVal nombreCaja As String, ByVal fecha1 As String, ByVal fecha2 As String, ByVal todos As Boolean)
        Try
            conectar()
            Dim cmd As New SqlCommand("")
            Dim consulta As String = busquedaVentasCaja
            Select Case busqueda
                Case "Folio"
                    consulta = consulta + If(filtro = String.Empty, " where vt.fecha between '" + fecha2 + "' and '" + fecha1 + "'",
                        " where vt.folio = " + filtro + " and vt.fecha between '" + fecha1 + "' and '" + fecha2 + "'")
                    Exit Select
                Case "Empleado"
                    consulta = consulta + " where  emp.nombre like '%" + filtro + "%'
                    and vt.fecha between '" + fecha1 + "' and '" + fecha2 + "'"
                    Exit Select
                Case "Cliente"
                    consulta = consulta + " where cl.nombre = '%" + filtro + "'
                    and vt.fecha between '" + fecha2 + "' and '" + fecha1 + "'"
                    Exit Select
                Case "Razon Social"
                    consulta = consulta + " where cl.razonSocial = '%" + filtro + "'
                    and vt.fecha between '" + fecha2 + "' and '" + fecha1 + "'"
                    Exit Select
                Case Else
                    consulta = consulta + "where vt.fecha between '" + fecha2 + "' and '" + fecha1 + "'"
                    Exit Select
            End Select

            consulta = consulta + If(todos = False, " and vt.estatus = 'D'", " and vt.estatus like '%'") + "and cj.nombre = '" + nombreCaja + "'"
            cmd.CommandText = consulta
            cmd.Connection = conn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                tblVentasCaja.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub


    '##########################################################################################################
    '############################# METODOS PARA CAJA/CUENTAS POR PAGAR ########################################
    '##########################################################################################################

    Private busquedaCuentaPorPagar As String = "select 
	cl.RFC, case 
	when cl.nombre <> '' then cl.nombre 
	when cl.razonSocial <> '' then cl.razonSocial
	else cl.RFC end as Cliente,
    cl.idCliente,
	cr.limiteCredito as LimiteCredito,
	cr.saldo as Saldo,
	cr.diasCredito as 'Días de credito' ,
	ISNULL( datediff(day ,(select top 1 fecha from venta where idCliente = cl.idCliente and venta.estatus = 'D' order by fecha desc) , convert(date,GETDATE())), 0) as 'Días',
	ISNULL((select top 1 fecha from venta where idCliente = cl.idCliente and venta.estatus = 'D' order by fecha desc), convert( date , GETDATE()) )as 'Fecha Inicial',
	cn.nombre as Contacto,
	case 
		when cn.telefono <> '' then telefono
		when cn.telefono IS null then telefono2
		else 'ND' end as Telefono,
	case 
		when cn.email = NULL then cn.email2
		when cn.email <> '' then cn.email
		else 'ND' end as Email
from cliente as cl 
inner join contacto as cn on cl.idCliente = cn.idCliente
left join credito as cr on cr.idCliente = cl.idCliente "


    Public Sub select_CuentaPorCobrar(ByVal tblVentasCaja As DataGridView, ByVal busqueda As String, ByVal filtro As String, ByVal fecha1 As String, ByVal fecha2 As String, ByVal todos As Boolean)
        Try
            conectar()
            Dim cmd As New SqlCommand("")
            Dim consulta As String = If(todos = False, busquedaCuentaPorPagar + " where saldo > 0 ", busquedaCuentaPorPagar + " where ")
            If filtro = String.Empty Then
                filtro = "%"
            End If
            Select Case busqueda
                Case "Cliente"
                    consulta = consulta + " and ( cl.nombre like '%" + filtro + "%' or cl.razonSocial like '%" + filtro + "%' )   "
                    Exit Select
                Case "Contacto"
                    consulta = consulta + " and (cn.nombre like '%" + filtro + "%') "
                    Exit Select
                Case Else
                    consulta = consulta + " and ((saldo*100)/limiteCredito) > " + filtro
                    Exit Select
            End Select
            consulta = consulta + "and (select top 1 fecha from venta where idCliente = cl.idCliente and venta.estatus = 'D' order by fecha desc) between '" + fecha2 + "'  and '" + fecha1 + "' "
            cmd.CommandText = consulta
            cmd.Connection = conn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                tblVentasCaja.DataSource = dt
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub



    Dim consultaCPP As String = "select cl.nombre , vt.folio , vt.cantidadPagada, vt.totalPagar , vt.fecha, cj.nombre from 
venta as vt inner join cliente cl on vt.idCliente = cl.idCliente
left join caja as cj on vt.idCaja = cj.idCaja "

    Public Sub buscarCuentasPorPagar(ByVal tablas As DataGridView, fecha1 As String, fecha2 As String, cliente As String, caja As String, ByVal folio As String, ByVal todos As Boolean)
        Try
            conectar()
            Dim consulta As String = consultaCPP + "  where "
            Dim cont As Int16 = 0
            If todos = False Then
                If fecha1 <> String.Empty And fecha2 <> String.Empty Then
                    consulta = consulta + " (vt.fecha between '" + fecha1 + "' and '" + fecha2 + "') "
                    cont += 1
                End If
                If caja <> String.Empty Then
                    If cont <> 0 Then
                        consulta = consulta + " and cj.nombre like '%" + caja + "' "
                        cont += 1
                    Else
                        consulta = consulta + " cj.nombre like '%" + caja + "' "
                        cont += 1
                    End If
                End If
                If cliente <> String.Empty Then
                    If cont <> 0 Then
                        consulta = consulta + " and cl.nombre = '%" + cliente + "' "
                        cont += 1
                    Else
                        consulta = consulta + " cl.nombre = '%" + cliente + "' "
                        cont += 1
                    End If
                End If
                If folio <> String.Empty Then
                    If cont <> 0 Then
                        consulta = consulta + " vt.folio = " + folio + " "
                        cont += 1
                    Else
                        consulta = consulta + " and vt.folio = " + folio + " "
                        cont += 1
                    End If
                End If
            Else
                consulta = consulta + " vt.cantidadPagada <> vt.totalPagar and vt.estatus <> 'A' "
            End If
            Dim cmd As New SqlCommand(consulta, conn)
            If cmd.ExecuteNonQuery Then
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                tablas.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function TotalEfectivoCajaDeducido(ByVal idcaja As String) As Double
        Try
            conectar()
            Dim cmd As New SqlCommand("select isnull( SUM(cantidadPagada) - (select montoInicial from corteCaja where fechaInicio = (select  MAX(fechaInicio) from corteCaja where idCaja = '" + idcaja + "' )), 0.0) as Total 
from venta as vt left join caja as cj on vt.idCaja = cj.idCaja 
left join corteCaja as ctj on cj.idCaja = ctj.idCaja
where vt.fecha between  (select  MAX(fechaInicio) from corteCaja where idCaja = '" + idcaja + "' ) and (select  MAX(fechaFin) from corteCaja where idCaja = '" + idcaja + "' )", conn)
            Dim total As String = ""
            Using rd = cmd.ExecuteReader
                If rd.HasRows Then
                    While rd.Read
                        total = rd.Item("Total").ToString
                    End While
                End If
            End Using
            Return CDbl(total)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
        Return Nothing
    End Function



    '#########################################################################################################################
    '######################################### METODOS PARA CUENTAS POR PAGAR ################################################
    '#########################################################################################################################

    Dim ventas_sin_pagar As String = "select 
	vt.folio  as Folio,
	vt.fecha as Fecha,
	case when  cl.nombre = '' then cl.razonSocial else cl.nombre end as Cliente,
	vt.totalPagar as Total,
	vt.cantidadPagada as Saldado, 
	(vt.totalPagar - vt.cantidadPagada) as Debe,
	dateadd(DAY, cr.diasCredito ,vt.fecha)as 'Día límite' ,
	ISNULL( datediff(day ,(select top 1 fecha from venta where idVenta = vt.idVenta order by fecha desc) , convert(date,GETDATE())), 0) as 'Días',
	case when  vt.estatus = 'P' then 'Pagado' when vt.estatus = 'D' then 'Deuda' else 'Espera' end as Estado
from venta as vt 
left join cliente as cl on cl.idCliente = vt.idCliente  
left join credito as cr on cr.idCliente = cl.idCliente 
where vt.estatus = 'D' "

    Public Sub selectVentasPendientesCliente(ByVal tblCPPCliente As DataGridView, ByVal idCliente As String)
        Try
            conectar()
            Dim cmd As New SqlCommand("")
            cmd.CommandText = ventas_sin_pagar + " and cl.idCliente = '" + idCliente + "'"

            cmd.Connection = conn
            If cmd.ExecuteNonQuery Then
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                tblCPPCliente.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
