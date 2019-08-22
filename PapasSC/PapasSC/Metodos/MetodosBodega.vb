Imports System.Data.SqlClient
Public Class MetodosBodega
    Inherits conexionDB
    Public cn As New conexionDB
    Public adaptador As SqlDataAdapter
    Public dt As DataTable

    Public Sub llenarDatagridview(ByVal dgv As DataGridView)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select  
    bo.idBodega as ID_Bodega, 
    bo.nombre as Nombre_Bodega,
    bo.estatus as Estatus,
    ma.nombre as Nombre_Matriz,
    ma.clave as Clave_Matriz,
    ci.nombre as nombre_Ciudad
    from bodega bo inner join matriz  ma on bo.idMatriz  = ma.idMatriz  
    inner join ciudad  ci on ci.idCiudad=ma.idCiudad  where bo.estatus = 'A'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub



    Public Sub llenarComboMatriz(ByVal dgv As ComboBox)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select nombre as Matriz from matriz where estatus = 'A'", cn.conn)

            Dim ds As New DataSet

            adaptador.Fill(ds)


            dgv.DataSource = ds.Tables(0)
            dgv.DisplayMember = "Matriz"
            dgv.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.Message)
        End Try
    End Sub


    Public Sub llenarDatagridview_filtroMatriz(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select  
    bo.idBodega as ID_Bodega, 
    bo.nombre as Nombre_Bodega,
    bo.estatus as Estatus,
    ma.nombre as Nombre_Matriz,
    ma.clave as Clave_Matriz,
    ci.nombre as nombre_Ciudad
    from bodega bo inner join matriz  ma on bo.idMatriz  = ma.idMatriz  
    inner join ciudad  ci on ci.idCiudad=ma.idCiudad  where bo.estatus = 'A' and ma.nombre like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtroCiudad(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select  
    bo.idBodega as ID_Bodega, 
    bo.nombre as Nombre_Bodega,
    bo.estatus as Estatus,
    ma.nombre as Nombre_Matriz,
    ma.clave as Clave_Matriz,
    ci.nombre as nombre_Ciudad
    from bodega bo inner join matriz  ma on bo.idMatriz  = ma.idMatriz  
    inner join ciudad  ci on ci.idCiudad=ma.idCiudad  where bo.estatus = 'A' and ci.nombre like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtroEstatus(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select  
    bo.idBodega as ID_Bodega, 
    bo.nombre as Nombre_Bodega,
    bo.estatus as Estatus,
    ma.nombre as Nombre_Matriz,
    ma.clave as Clave_Matriz,
    ci.nombre as nombre_Ciudad
    from bodega bo inner join matriz  ma on bo.idMatriz  = ma.idMatriz  
    inner join ciudad  ci on ci.idCiudad=ma.idCiudad  where  bo.estatus like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtroClave(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select  
    bo.idBodega as ID_Bodega, 
    bo.nombre as Nombre_Bodega,
    bo.estatus as Estatus,
    ma.nombre as Nombre_Matriz,
    ma.clave as Clave_Matriz,
    ci.nombre as nombre_Ciudad
    from bodega bo inner join matriz  ma on bo.idMatriz  = ma.idMatriz  
    inner join ciudad  ci on ci.idCiudad=ma.idCiudad  where bo.estatus = 'A' and ma.clave like '" + filtro + "%'", cn.conn)
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
            adaptador = New SqlDataAdapter("select  
    bo.idBodega as ID_Bodega, 
    bo.nombre as Nombre_Bodega,
    bo.estatus as Estatus,
    ma.nombre as Nombre_Matriz,
    ma.clave as Clave_Matriz,
    ci.nombre as nombre_Ciudad
    from bodega bo inner join matriz  ma on bo.idMatriz  = ma.idMatriz  
    inner join ciudad  ci on ci.idCiudad=ma.idCiudad  where bo.estatus = 'A' and bo.idBodega like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a:  " + ex.ToString)
        End Try
    End Sub

    Public Sub llenarDatagridview_filtrobodega(ByVal dgv As DataGridView, ByVal filtro As String)
        cn.conectar()
        Try
            adaptador = New SqlDataAdapter("select  
    bo.idBodega as ID_Bodega, 
    bo.nombre as Nombre_Bodega,
    bo.estatus as Estatus,
    ma.nombre as Nombre_Matriz,
    ma.clave as Clave_Matriz,
    ci.nombre as nombre_Ciudad
    from bodega bo inner join matriz  ma on bo.idMatriz  = ma.idMatriz  
    inner join ciudad  ci on ci.idCiudad=ma.idCiudad  where bo.estatus = 'A' and bo.nombre like '" + filtro + "%'", cn.conn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a:  " + ex.ToString)
        End Try
    End Sub








    Public Sub eliminaprobodega(ByVal filtro As String)
        Try
            cn.conectar()
            Dim cadena As String = "update bodega set estatus = 'B' where idBodega = '" + filtro + "'"
            Dim comando = New SqlCommand(cadena, cn.conn)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("No se elimino debido a: " + ex.ToString)
        End Try
    End Sub

    Public Sub insertarBodega(ByVal nombre As String, ByVal clave As String)
        Try
            cn.conectar()
            MsgBox("entro")
            Dim Rs As SqlDataReader
            Dim Com As New SqlCommand



            Dim Sql As String = "select idMatriz from matriz where nombre ='" + clave + "' and estatus = 'A'"
            MsgBox(clave)

            Com = New SqlCommand(Sql, cn.conn)

            Rs = Com.ExecuteReader()

            Rs.Read()
            MsgBox(Rs(0))
            Dim cadena As String = "INSERT INTO [dbo].[bodega]
            ([idBodega]
            ,[nombre]
            ,[estatus]
            ,[idMatriz])
            VALUES
            (newid()
            ,'" + nombre + "'
            ,'A'
            ,'" + Rs(0).ToString + "')"
            MsgBox(cadena)
            Rs.Close()
            cn.desconectar()
            cn.conectar()
            Com = New SqlCommand(cadena, cn.conn)
            MsgBox("cade")
            Com.ExecuteNonQuery()
            MsgBox("pus si salio carnal")
        Catch ex As Exception
            MessageBox.Show("No se inserto debido a: " + ex.ToString)
        End Try
    End Sub


    Public Sub updatebodega(ByVal nombre As String, ByVal clave As String, ByVal id As String)
        Try
            cn.conectar()
            MsgBox("entro")
            Dim Rs As SqlDataReader
            Dim Com As New SqlCommand



            Dim Sql As String = "select idMatriz from matriz where nombre ='" + clave + "' and estatus = 'A'"
            MsgBox(clave)

            Com = New SqlCommand(Sql, cn.conn)

            Rs = Com.ExecuteReader()

            Rs.Read()
            MsgBox(Rs(0))
            Dim cadena As String = "UPDATE [dbo].[bodega]
       SET 
       [nombre] = '" + nombre + "'
      ,[idMatriz] = '" + Rs(0).ToString + "'
       WHERE idBodega = '" + id + "'"


            MsgBox(cadena)
            Rs.Close()
            cn.desconectar()
            cn.conectar()
            Com = New SqlCommand(cadena, cn.conn)
            MsgBox("cade")
            Com.ExecuteNonQuery()
            MsgBox("pus si salio carnal")
        Catch ex As Exception
            MessageBox.Show("No se inserto debido a: " + ex.ToString)
        End Try
    End Sub



End Class

