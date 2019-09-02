Imports System.Data.SqlClient

Public Class MetodosPerfiles
    Inherits conexionDB
    Public privielgios(7) As String
    Dim adaptador As New SqlDataAdapter
    Public privilegiosAsinados, privilegiosSinAsignar As New List(Of String)

    Public Sub consultaTipoUsuario(ByVal cmbTipoUsuario As ComboBox)
        Try
            conectar()
            Dim cmd As New SqlCommand("select tipo from tipoUsuario ", conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader
            While reader.Read()
                Dim dato As String = reader(0)
                cmbTipoUsuario.Items.Add(dato)
            End While
            cmbTipoUsuario.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub

    Public Sub consulaPriVilegios(ByVal lstDisponibles As ListView)
        Try
            conectar()
            Dim comando As New SqlCommand("select nombre from privilegio", conn)
            Dim reader As SqlDataReader = comando.ExecuteReader
            lstDisponibles.Columns.Add("PRIVILEGIO")
            Dim cont As Int16 = 0
            While reader.Read()
                Dim dato As String = reader(0)
                privielgios(cont) = dato
                Dim item As New ListViewItem(dato)
                lstDisponibles.Items.Add(item)
                cont += 1
            End While

            desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub consultaPrivlegioTipoUsuario(nombreUsuario As String, ByVal lstAsignados As ListView, ByVal lstSinAsignar As ListView)
        lstAsignados.Clear()
        lstSinAsignar.Clear()
        privilegiosSinAsignar.Clear()
        privilegiosAsinados.Clear()
        Try
            conectar()
            Dim comando As New SqlCommand("select p.nombre as Actividad from privilegio as p left join usuarioPrivilegio as up
                on p.idPrivilegio = up.idPrivilegio left join tipoUsuario as tu 
                on up.idTipoUsario = tu.idTipoUsuario where tu.tipo like  '" + nombreUsuario + "'", conn)
            Dim reader As SqlDataReader = comando.ExecuteReader
            Dim asignados As New List(Of String)
            While reader.Read()
                Dim dato As String = reader(0)
                Dim item As New ListViewItem(dato)
                lstAsignados.Items.Add(item)
                asignados.Add(dato)
            End While

            privilegiosAsinados = asignados


            desconectar()
            Dim sinAsignar As New List(Of String)

            For Each item1 In privielgios
                Dim flag As Boolean = True
                For Each item2 In asignados
                    If item1.Equals(item2) Then
                        flag = False
                        Exit For
                    End If
                Next
                If flag = True Then
                    Dim dato As String = item1
                    Dim item As New ListViewItem(dato)
                    lstSinAsignar.Items.Add(item)
                    sinAsignar.Add(item.Text)
                End If
            Next

            privilegiosSinAsignar = sinAsignar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub actualizarPrivilegio(ByVal privilegio As String, ByVal tipoUsuario As String)
        Try
            conectar()
            Dim cmd As New SqlCommand("sp_actualizar_Privilegios")
            cmd.Connection = conn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@nombreTipoUsuario", tipoUsuario)
            cmd.Parameters.AddWithValue("@nombrePrivilegio", privilegio)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub

    Public Sub eliminarPrivilegio(ByVal privilegio As String, ByVal tipoUsuario As String)
        Try
            conectar()
            Dim cmd As New SqlCommand("sp_Elimina_Privilegios")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@nombreTipoUsuario", tipoUsuario)
            cmd.Parameters.AddWithValue("@nombrePrivilegio", privilegio)
            cmd.Connection = conn
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub

    Public Sub insertarTipoUsuario(ByVal nombreTipoUsuario As String, ByVal privilegios As List(Of String))
        Try
            conectar()
            For Each priv In privilegios
                Dim cmd As New SqlCommand("sp_insertarTipoUsuarioYPrivilegios")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = conn
                cmd.Parameters.AddWithValue("@nombreTipoUsuario", nombreTipoUsuario)
                cmd.Parameters.AddWithValue("@privilegio", priv)
                cmd.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class