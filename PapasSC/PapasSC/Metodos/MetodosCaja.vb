Imports System.Data.SqlClient
Public Class MetodosCaja
    Inherits conexionDB

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

    Public Sub cajasEstatus(ByVal cmbCaja As ComboBox, ByVal idsCaja As List(Of String), ByVal listEstatus As List(Of String))
        Try
            conectar()
            Dim cmd As New SqlCommand("select nombre, idCaja, estatus from caja where not estatus='B'", conn)
            Dim rd As SqlDataReader = cmd.ExecuteReader()
            idsCaja.Clear()
            listEstatus.Clear()
            While rd.Read
                cmbCaja.Items.Add(rd("nombre"))
                idsCaja.Add(rd("idCaja"))
                listEstatus.Add(rd("estatus"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub

    Public Function iniciar_Caja(ByVal caja As String, ByVal empleado As String, ByVal montoInicial As String) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("sp_Iniciar_Caja", conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@montoInicial", SqlDbType.Float).Value = montoInicial
            Dim fechaInc As String = DateTime.Now.ToString("YYYY/MM/DD HH:MM:SS")
            cmd.Parameters.Add("@fechaInicial", SqlDbType.SmallDateTime).Value = fechaInc
            cmd.Parameters.Add("@idCaja", SqlDbType.VarChar, 36).Value = caja
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

    Public Function cerrar_Caja(ByVal idCaja As String, ByVal idEmpleado As String, ByVal montoFinal As String) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("sp_Cerrar_Caja", conn)
            cmd.CommandType = CommandType.StoredProcedure


        Catch ex As Exception

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
End Class
