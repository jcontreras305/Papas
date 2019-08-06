Imports System.Data.SqlClient
Public Class MetodosProducto
    Inherits conexionDB
    Public cn As New conexionDB
    Public adaptador As SqlDataAdapter
    Public dt As DataTable

    Public Sub llenarDatagridview(ByVal dgv As DataGridView)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter(
    "select idProducto as Clave_Producto, version as Version,
    estado as Estatus
    from producto", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtro(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select cl.idCliente as Clave_Cliente, cl.nombre 
    as Nombre,
    cl.RFC,
    cl.razonSocial as Razon_Social,
    cl.fechaRegistro as Fecha_Registro,
    tcl.tipo as Tipo,
    tcl.estatus as Estatus,
    cr.limiteCredito as Limite_Credito,
    cr.diasCredito as Dias_de_Credito,
    con.nombre as Nombre_Contacto,
    con.genero as Genero,
    con.direccion as Direccion,
    con.telefono as Telefono,
    con.email as Email,
    con.estado as Estado,
    con.municipio as municipio,
    con.codigoPostal as Codigo_Postal
    from cliente cl inner join tipoCliente tcl on tcl.idTipoCliente = cl.idTipoCliente 
    inner join credito cr on cr.idCredito=cl.idCredito 
    inner join contacto con on con.idContacto=cl.idContacto where cl.nombre like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtroTipo(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select cl.idCliente as Clave_Cliente, cl.nombre 
    as Nombre,
    cl.RFC,
    cl.razonSocial as Razon_Social,
    cl.fechaRegistro as Fecha_Registro,
    tcl.tipo as Tipo,
    tcl.estatus as Estatus,
    cr.limiteCredito as Limite_Credito,
    cr.diasCredito as Dias_de_Credito,
    con.nombre as Nombre_Contacto,
    con.genero as Genero,
    con.direccion as Direccion,
    con.telefono as Telefono,
    con.email as Email,
    con.estado as Estado,
    con.municipio as municipio,
    con.codigoPostal as Codigo_Postal
    from cliente cl inner join tipoCliente tcl on tcl.idTipoCliente = cl.idTipoCliente 
    inner join credito cr on cr.idCredito=cl.idCredito 
    inner join contacto con on con.idContacto=cl.idContacto where tcl.tipo like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtroRazonSocial(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select cl.idCliente as Clave_Cliente, cl.nombre 
    as Nombre,
    cl.RFC,
    cl.razonSocial as Razon_Social,
    cl.fechaRegistro as Fecha_Registro,
    tcl.tipo as Tipo,
    tcl.estatus as Estatus,
    cr.limiteCredito as Limite_Credito,
    cr.diasCredito as Dias_de_Credito,
    con.nombre as Nombre_Contacto,
    con.genero as Genero,
    con.direccion as Direccion,
    con.telefono as Telefono,
    con.email as Email,
    con.estado as Estado,
    con.municipio as municipio,
    con.codigoPostal as Codigo_Postal
    from cliente cl inner join tipoCliente tcl on tcl.idTipoCliente = cl.idTipoCliente 
    inner join credito cr on cr.idCredito=cl.idCredito 
    inner join contacto con on con.idContacto=cl.idContacto where cl.razonSocial like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub
    Public Sub llenarDatagridview_filtroalias(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select cl.idCliente as Clave_Cliente, cl.nombre 
    as Nombre,
    cl.RFC,
    cl.razonSocial as Razon_Social,
    cl.fechaRegistro as Fecha_Registro,
    tcl.tipo as Tipo,
    tcl.estatus as Estatus,
    cr.limiteCredito as Limite_Credito,
    cr.diasCredito as Dias_de_Credito,
    con.nombre as Nombre_Contacto,
    con.genero as Genero,
    con.direccion as Direccion,
    con.telefono as Telefono,
    con.email as Email,
    con.estado as Estado,
    con.municipio as municipio,
    con.codigoPostal as Codigo_Postal
    from cliente cl inner join tipoCliente tcl on tcl.idTipoCliente = cl.idTipoCliente 
    inner join credito cr on cr.idCredito=cl.idCredito 
    inner join contacto con on con.idContacto=cl.idContacto where con.nombre like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtroRFC(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select cl.idCliente as Clave_Cliente, cl.nombre 
    as Nombre,
    cl.RFC,
    cl.razonSocial as Razon_Social,
    cl.fechaRegistro as Fecha_Registro,
    tcl.tipo as Tipo,
    tcl.estatus as Estatus,
    cr.limiteCredito as Limite_Credito,
    cr.diasCredito as Dias_de_Credito,
    con.nombre as Nombre_Contacto,
    con.genero as Genero,
    con.direccion as Direccion,
    con.telefono as Telefono,
    con.email as Email,
    con.estado as Estado,
    con.municipio as municipio,
    con.codigoPostal as Codigo_Postal
    from cliente cl inner join tipoCliente tcl on tcl.idTipoCliente = cl.idTipoCliente 
    inner join credito cr on cr.idCredito=cl.idCredito 
    inner join contacto con on con.idContacto=cl.idContacto where cl.RFC like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtroLimiteCredito(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select cl.idCliente as Clave_Cliente, cl.nombre 
    as Nombre,
    cl.RFC,
    cl.razonSocial as Razon_Social,
    cl.fechaRegistro as Fecha_Registro,
    tcl.tipo as Tipo,
    tcl.estatus as Estatus,
    cr.limiteCredito as Limite_Credito,
    cr.diasCredito as Dias_de_Credito,
    con.nombre as Nombre_Contacto,
    con.genero as Genero,
    con.direccion as Direccion,
    con.telefono as Telefono,
    con.email as Email,
    con.estado as Estado,
    con.municipio as municipio,
    con.codigoPostal as Codigo_Postal
    from cliente cl inner join tipoCliente tcl on tcl.idTipoCliente = cl.idTipoCliente 
    inner join credito cr on cr.idCredito=cl.idCredito 
    inner join contacto con on con.idContacto=cl.idContacto where cr.limiteCredito like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtroDiasCredito(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select cl.idCliente as Clave_Cliente, cl.nombre 
    as Nombre,
    cl.RFC,
    cl.razonSocial as Razon_Social,
    cl.fechaRegistro as Fecha_Registro,
    tcl.tipo as Tipo,
    tcl.estatus as Estatus,
    cr.limiteCredito as Limite_Credito,
    cr.diasCredito as Dias_de_Credito,
    con.nombre as Nombre_Contacto,
    con.genero as Genero,
    con.direccion as Direccion,
    con.telefono as Telefono,
    con.email as Email,
    con.estado as Estado,
    con.municipio as municipio,
    con.codigoPostal as Codigo_Postal
    from cliente cl inner join tipoCliente tcl on tcl.idTipoCliente = cl.idTipoCliente 
    inner join credito cr on cr.idCredito=cl.idCredito 
    inner join contacto con on con.idContacto=cl.idContacto where cr.diasCredito like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtroID(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select cl.idCliente as Clave_Cliente, cl.nombre 
    as Nombre,
    cl.RFC,
    cl.razonSocial as Razon_Social,
    cl.fechaRegistro as Fecha_Registro,
    tcl.tipo as Tipo,
    tcl.estatus as Estatus,
    cr.limiteCredito as Limite_Credito,
    cr.diasCredito as Dias_de_Credito,
    con.nombre as Nombre_Contacto,
    con.genero as Genero,
    con.direccion as Direccion,
    con.telefono as Telefono,
    con.email as Email,
    con.estado as Estado,
    con.municipio as municipio,
    con.codigoPostal as Codigo_Postal
    from cliente cl inner join tipoCliente tcl on tcl.idTipoCliente = cl.idTipoCliente 
    inner join credito cr on cr.idCredito=cl.idCredito 
    inner join contacto con on con.idContacto=cl.idContacto where cl.idCliente like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub


    Public Sub eliminaCliente(ByVal filtro As String)
        cn.conectar()

        Try
            Dim command As New SqlCommand("DELETE FROM cliente WHERE idCliente = @id", cn.conn)

            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = filtro
            command.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("No se elimino debido a: " + ex.ToString)
        End Try
    End Sub
End Class
