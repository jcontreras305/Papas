Imports System.Data.SqlClient
Public Class MetodosCaja
    Inherits conexionDB

    Private busqueda As String = "select idCaja , cj.nombre as Caja,cj.clave as Referencia, cj.estatus as Estatus,cj.fase as Fase, cj.limiteEfectivo, bd.nombre as Bodega  from caja as  cj left join bodega as bd
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
            cmd.Parameters.Add("@idBodega ", SqlDbType.VarChar, 36).Value = datos(5)
            If cmd.ExecuteNonQuery Then
                MsgBox("Se agrego la caja " + datos(0))
            Else
                MsgBox("Error al agregar la caja")
            End If
        Catch ex As Exception

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
            Dim cmd As New SqlCommand("select idBodega , nombre from bodega ", conn)
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
End Class
