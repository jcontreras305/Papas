Imports System.Data.SqlClient
Imports PapasSC

Public Class MetodosCaja
    Inherits conexionDB

    Private busqueda As String = "select idCaja , cj.nombre as Caja,cj.clave as Referencia, cj.estatus as Estatus,cj.fase as Fase, cj.limiteEfectivo, bd.nombre as Bodega, cj.explicito as ValoresExplicitos from caja as  cj left join bodega as bd
on cj.idBodega = bd.idBodega "

    Private busquedaCuentaPorPagar As String = "select vt.folio as clave, cl.RFC, case 
							when cl.nombre= NULL then cl.razonSocial 
							when cl.razonSocial = null then cl.nombre
							else cl.RFC end as RazonSocial,
							cn.nombre as Contacto,
							case 
								when cn.telefono = null then telefono2
								when cn.telefono <> null then telefono
								else 'ND' end as Telefono,
							case 
								when cn.email = NULL then cn.email2
								when cn.email <> '' then cn.email
								else 'ND' end as Email,
							ct.limiteCredito as LimiteCredito,
							ct.diasCredito as Días ,
							ct.limiteCredito - ct.saldo as Cobraza
							
from 
venta as vt inner join caja as cj on vt.idCaja = cj.idCaja
left join  cliente as cl on vt.idCliente = cl.idCliente
left join contacto as cn on cn.idCliente = cl.idCliente
left join tipoCliente as tcl on cl.idTipoCliente = tcl.idTipoCliente 
left join credito as ct on ct.idCliente = cl.idCliente"

    Private busquedaVentasCaja As String = "select vt.folio as Clave, case 
							when cl.nombre= NULL then cl.razonSocial 
							when cl.razonSocial = null then cl.nombre
							else cl.RFC end as RazonSocial,
							tcl.tipo as Tipo,
							ct.limiteCredito as LimitaCrédito,
							ct.diasCredito as DíasCrédito,
							ct.saldo as Saldo,
							case when cl.estatus = 'A' then 'Activo'
								 when cl.estatus = 'I' then 'Inactivo'
								 when cl.estatus = 'B' then 'Bloqueado'
								 else '' end as Estatus
								  from 
venta vt inner join caja as cj on vt.idCaja = cj.idCaja
left join cliente as cl on vt.idCliente = cl.idCliente
left join tipoCliente as tcl on cl.idTipoCliente = tcl.idTipoCliente 
left join credito as ct on ct.idCliente = cl.idCliente "

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

    Public Sub cajasEstatus(ByVal cmbCaja As ComboBox, ByVal idsCaja As List(Of String), ByVal listEstatus As List(Of String))
        Try
            conectar()
            Dim cmd As New SqlCommand("select nombre, idCaja, fase from caja where not estatus='B'", conn)
            Dim rd As SqlDataReader = cmd.ExecuteReader()
            idsCaja.Clear()
            listEstatus.Clear()
            While rd.Read
                cmbCaja.Items.Add(rd("nombre"))
                idsCaja.Add(rd("idCaja"))
                listEstatus.Add(rd("fase"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub

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

    Public Sub select_ventasCajas(ByVal tblVentasCaja As DataGridView, ByVal filtro As String, ByVal nombreCaja As String, ByVal fecha1 As String, ByVal fecha2 As String)
        Try
            conectar()
            Dim cmd As New SqlCommand(busquedaVentasCaja + "where cl.nombre like '' 
or	cl.razonSocial like '" + filtro + "'
or cl.RFC like '" + filtro + "'
or limiteCredito like '" + filtro + "'
or saldo like '" + filtro + "'
or vt.fecha between " + fecha1 + " and " + fecha2 + "
and cj.nombre = '" + nombreCaja + "'", conn)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter
                da.Fill(dt)
                tblVentasCaja.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub

    Public Sub select_ventasCajas(ByVal tblVentasCaja As DataGridView, ByVal filtro As String, ByVal nombreCaja As String)
        Try
            conectar()
            Dim cmd As New SqlCommand(busquedaVentasCaja + "where cl.nombre like '' 
or	cl.razonSocial like '" + filtro + "'
or cl.RFC like '" + filtro + "'
or limiteCredito like '" + filtro + "'
or saldo like '" + filtro + "'
and cj.nombre =  '" + nombreCaja + "'", conn)
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

    Public Sub select_CuentaPorCobrar(ByVal tblCuentasPorPagar As DataGridView, ByVal caja As String)
        Try
            conectar()
            Dim cmd As New SqlCommand(busquedaCuentaPorPagar + " where cj.nombre = '" + caja + "' and vt.estatus = 'P'", conn)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                tblCuentasPorPagar.DataSource = dt
            Else
                MsgBox("Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim caja = TryCast(obj, MetodosCaja)
        Return caja IsNot Nothing AndAlso
               busquedaCuentaPorPagar = caja.busquedaCuentaPorPagar
    End Function
End Class
