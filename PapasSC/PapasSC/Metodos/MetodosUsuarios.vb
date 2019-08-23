Imports PapasSC.conexionDB
Imports System.Data.SqlClient
Public Class MetodosUsuarios
    Inherits conexionDB
    Dim cmd As New SqlCommand
    Dim adaptador As New SqlDataAdapter

    Public Sub todosLosUsuarios(ByVal tblDatos As DataGridView)
        Try
            conectar()
            Dim cmd As New SqlCommand("sp_selectUsuarios")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                tblDatos.DataSource = dt
                'Else
                '    MsgBox("Hubo un problema al consultar a la base de datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'desconectar()
    End Sub

    Public Sub cargarUsuarioCombo(ByVal comboboxEmlp As ComboBox)
        Try
            conectar()
            adaptador = New SqlDataAdapter("select nombreUsuario from usuarios ", conn)
            Dim ds As New DataSet
            adaptador.Fill(ds)
            comboboxEmlp.DataSource = ds.Tables(0)
            comboboxEmlp.DisplayMember = "nombreUsuario"
            comboboxEmlp.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub

    Public Sub cargarTiposUsuario(ByVal cmbTipoEmpl As ComboBox)
        Try
            conectar()
            adaptador = New SqlDataAdapter("select tipo from tipoUsuario", conn)
            Dim ds As New DataSet
            adaptador.Fill(ds)
            cmbTipoEmpl.DataSource = ds.Tables(0)
            cmbTipoEmpl.DisplayMember = "tipo"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub

    Public Sub cargarNombreEmpleadp(ByVal cmbEmpleado As ComboBox)
        Try
            conectar()
            adaptador = New SqlDataAdapter("select nombre from empleado where estatus = 'A'", conn)
            Dim ds As New DataSet
            adaptador.Fill(ds)
            cmbEmpleado.DataSource = ds.Tables(0)
            cmbEmpleado.DisplayMember = "nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub

    Public Function cargardatosUsuario(ByVal nombreUsuario As String) As String()
        Try
            conectar()
            Dim datosUsuario(6) As String
            Dim cmd = New SqlCommand("sp_selectDatosUsuario", conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario)
            'cmd.Connection = conn
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader
            While reader.Read()
                datosUsuario(0) = CStr(reader(0))
                datosUsuario(1) = CStr(reader(1))
                datosUsuario(2) = CStr(reader(2))
                datosUsuario(3) = CStr(reader(3))
                datosUsuario(4) = CStr(reader(4))
            End While
            Return datosUsuario
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
        desconectar()
    End Function

    Public Sub insertar(ByVal datos() As String)
        Try
            conectar()
            Dim data() As String = datos
            Dim cmd As New SqlCommand("sp_insertar_Usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@login", data(0))
            cmd.Parameters.AddWithValue("@pass", data(1))
            cmd.Parameters.AddWithValue("@tipoUsuario", data(2))
            cmd.Parameters.AddWithValue("@empleado", data(3))
            cmd.Connection = conn
            If cmd.ExecuteNonQuery Then
                MsgBox("Se ha insertado el Usuario " + data(0))
            Else
                MsgBox("Error al insertar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub eliminar(ByVal usuario As String, ByVal empleado As String)
        Try
            conectar()

            Dim cmd As New SqlCommand("sp_eliminar_Usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@nombreUsuario", usuario)
            cmd.Parameters.AddWithValue("@nombreEmpleado", empleado)
            cmd.Connection = conn
            If cmd.ExecuteNonQuery Then
                MsgBox("Se ha eliminado el Usuario " + usuario + " que conrrespondia a " + empleado)
            Else
                MsgBox("Hubo un ERROR al eliminar el usuario" + usuario)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
