Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Data.SqlClient
Public Class MetodosTicket
    Inherits conexionDB
    Dim listIdBodega As New List(Of String)
    Dim listNoBodega As New List(Of String)

    Public Sub ImprimirTicketPruba()
        Try

        Catch ex As Exception

        End Try
    End Sub

    Public Sub cargarBodega(ByVal cmbBodega As ComboBox)
        Try
            conectar()
            Dim cmd As New SqlCommand("selct nombre, idBodega from bodega", conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader

            If listIdBodega.Count > 0 Then
                listIdBodega.Clear()
            End If
            While reader.Read()
                Dim dato As String = reader(0)
                cmbBodega.Items.Add(dato)
                listNoBodega.Add(dato)
                Dim id As String = reader(1)
                listIdBodega.Add(id)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub insertarTipoTicket(ByVal datos() As String)
        Try
            conectar()
            Dim cont As Int16 = 0
            For Each item In listNoBodega
                If item = datos(0) Then
                    Exit For
                Else
                    cont += 1
                End If
            Next
            Dim cmd As New SqlCommand("insert into ticket values (NEWID(),@idBodega,@clave,@nombre,@tipoFuente,@tamañoFuente,@textoEncabezado,@textoPie)", conn)
            cmd.Parameters.Add("@idBodega", SqlDbType.VarChar, 36).Value = listIdBodega(cont)
            cmd.Parameters.Add("@clave", SqlDbType.VarChar, 20).Value = datos(1)
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = datos(2)
            cmd.Parameters.Add("@tipoFuente", SqlDbType.VarChar, 30).Value = datos(3)
            cmd.Parameters.Add("@tamañoFuente", SqlDbType.Int).Value = datos(4)
            cmd.Parameters.Add("@textoEncabezado", SqlDbType.VarChar, 50).Value = datos(5)
            cmd.Parameters.Add("@textoPie", SqlDbType.VarChar, 100).Value = datos(6)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub


    Public Sub cargarVenta(ByVal ds As DataSet, ByVal folio As String)
        Try
            conectar()
            Dim cmd As New SqlCommand("select  vd.cantidad, pd.version as producto , pd.precio
 from venta as vt inner join ventaDetalle as vd 
on vt.idVenta = vd.idVenta 
left join producto as pd 
on vd.idProducto = pd.idProducto where vt.folio = " + folio, conn)


        Catch ex As Exception

        End Try
        desconectar()
    End Sub

End Class
