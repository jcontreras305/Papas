Imports System.Data.SqlClient
Public Class MetodosCliente
    Inherits conexionDB
    Public cn As New conexionDB
    Public adaptador As SqlDataAdapter
    Public dt As DataTable
    Const consulta As String = "select cl.idCliente as Clave_Cliente, cl.nombre 
    as Nombre,
    cl.RFC,
    cl.razonSocial as Razon_Social,
    cl.fechaRegistro as Fecha_Registro,
    tcl.tipo as Tipo,
    cl.estatus as Estatus,
    cr.limiteCredito as Limite_Credito,
    cr.saldo,
    cr.diasCredito as Dias_de_Credito,
    con.nombre as Nombre_Contacto,
    con.genero as Genero,
    con.direccion as Direccion,
    con.telefono as Telefono,
    con.email as Email,
    con.estado as Estado,
    con.municipio as municipio,
    con.codigoPostal as Codigo_Postal,
    con.direccion2 as Direccion2,
    con.telefono2 as Telefono2,
    con.email2 as Email2
    from cliente cl inner join tipoCliente tcl on tcl.idTipoCliente = cl.idTipoCliente 
    inner join credito cr on cr.idCliente=cl.idCliente
    inner join contacto con on con.idCliente=cl.idCliente"


    Public Sub llenarDatagridviewTodos(ByVal dgv As DataGridView)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter(consulta, cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.Message)
        End Try
    End Sub

    Public Sub llenarDatagridview(ByVal dgv As DataGridView)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter(consulta + " where cl.estatus like 'A'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.Message)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtro(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter(consulta + " cl.nombre like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.Message)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtroTipo(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter(consulta + " where tcl.tipo like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.Message)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtroRazonSocial(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter(consulta + " where cl.razonSocial like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.Message)
        End Try
    End Sub
    Public Sub llenarDatagridview_filtroalias(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter(consulta + " where  con.nombre like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.Message)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtroRFC(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter(consulta + " where cl.RFC like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.Message)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtroLimiteCredito(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter(consulta + " where cr.limiteCredito like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.Message)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtroDiasCredito(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter(consulta + " where cr.diasCredito like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.Message)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtroID(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter(consulta + " where cl.idCliente like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a:  " + ex.Message)
        End Try
    End Sub


    Public Sub eliminaCliente(ByVal idCliente As String, ByVal nombreCliente As String)
        Try
            conectar()
            Dim cmd = New SqlCommand("sp_Eliminar_Cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            cmd.Parameters.AddWithValue("@idCliente", idCliente)
            If cmd.ExecuteNonQuery Then
                MsgBox("Se ha eliminado el cliente " + nombreCliente)
            End If
            desconectar()
        Catch ex As Exception
            MessageBox.Show("No se elimino debido a: " + ex.Message)
        End Try
    End Sub
End Class
