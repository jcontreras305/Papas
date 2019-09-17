Imports System.Data.SqlClient

Public Class MetodosReclasificacion
    Inherits conexionDB

    Public Sub llenar_ComoboBodega(ByVal combo As ComboBox)
        Try
            conectar()
            Dim cmd = New SqlDataAdapter("select nombre from bodega", conn)
            Dim ds = New DataSet
            cmd.Fill(ds)
            combo.DataSource = ds.Tables(0)
            combo.DisplayMember = "nombre"
            combo.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub

    Public Sub llenar_TblBodega(ByVal tbl As DataGridView, ByVal bodega As String)
        Try
            conectar()
            Dim cmd = New SqlDataAdapter("select bg.nombre,  pd.version, pd.clave, ep.cantidad 
from producto as pd right join existenciaProductos as ep 
on pd.idProducto = ep.idProducto 
left join bodega as bg on ep.idBodega = bg.idBodega where bg.nombre = '" + bodega + "'", conn)
            Dim dt = New DataTable
            cmd.Fill(dt)
            tbl.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub

    Public Sub busqueda_producto(ByVal busqueda As String, ByVal bodega As String, ByVal tbl As DataGridView)
        Try
            conectar()
            Dim cmd = New SqlDataAdapter("select bg.nombre,  pd.version, pd.clave, ep.cantidad 
from producto as pd right join existenciaProductos as ep 
on pd.idProducto = ep.idProducto 
left join bodega as bg on ep.idBodega = bg.idBodega where bg.nombre = '" + bodega + "'
and (pd.version like '%" + busqueda + "%' or pd.clave like '%" + busqueda + "%')", conn)
            Dim dt = New DataTable
            cmd.Fill(dt)
            tbl.DataSource = dt

        Catch ex As Exception

        End Try
        desconectar()
    End Sub

    Public Sub cargar_prodcutos_Bodega(ByVal bodega As String, ByVal combo As ComboBox)
        Try
            conectar()
            Dim cmd = New SqlDataAdapter("select pd.version from producto as pd right join existenciaProductos as ep 
on pd.idProducto = ep.idProducto left join bodega as bg on ep.idBodega = bg.idBodega where bg.nombre = '" + bodega + "' order by pd.version", conn)
            Dim ds = New DataSet
            cmd.Fill(ds)
            combo.DataSource = ds.Tables(0)
            combo.DisplayMember = "version"
            combo.SelectedIndex = 0
        Catch ex As Exception

        End Try
        desconectar()
    End Sub

    Public Sub insertar_reubicaciones(ByVal bodega As String, ByVal producto1 As String, ByVal producto2 As String, ByVal cantidad As String)
        Try
            conectar()
            Dim cmd As New SqlCommand("sp_insertReclasificacion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@nombreBodega", SqlDbType.VarChar, 30).Value = bodega
            cmd.Parameters.Add("@nombreProducto1", SqlDbType.VarChar, 15).Value = producto1
            cmd.Parameters.Add("@nombreProducto2", SqlDbType.VarChar, 15).Value = producto2
            cmd.Parameters.Add("@cantidad", SqlDbType.Float).Value = cantidad
            'cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output
            cmd.Connection = conn
            If cmd.ExecuteNonQuery Then
                'Dim resultado As String = cmd.Parameters("@msg").Value
                'MsgBox(resultado)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub

End Class
