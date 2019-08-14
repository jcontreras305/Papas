Imports System.Data.SqlClient

Public Class MetodosMatrizCiudad
    Inherits conexionDB

    Public Sub seleccionar_Matriz(ByVal tablaMatriz As DataGridView)
        Try
            conectar()
            Dim cmd = New SqlCommand("sp_select_Matriz")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                tablaMatriz.DataSource = dt
            End If
            desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
            desconectar()
        End Try
    End Sub

    Public Sub seleccionar_Ciudad(ByVal comboCiudad As ComboBox)
        Try
            conectar()
            Dim cmd = New SqlCommand("sp_select_Ciudad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            If cmd.ExecuteNonQuery Then
                Dim ds As New DataSet 'es solo para lectura 
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(ds)

                comboCiudad.DataSource = ds.Tables(0) 'aqui se selecciona la comulna de la consulata de sql
                comboCiudad.DisplayMember = "nombre"  'este es el nombre de la comlumna de la consulta de sql
                comboCiudad.SelectedIndex = 0 'se selecciona el primer 
            End If
            desconectar()
        Catch ex As Exception

        End Try
    End Sub

    Public Function insertar_ciudad(ByVal ciudad As String) As Boolean
        Try
            conectar()
            Dim cmd = New SqlCommand("sp_insertar_ciudad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Nombre", ciudad)
            cmd.Connection = conn
            If cmd.ExecuteNonQuery Then
                MsgBox("Se ha agregado " + ciudad)
                Return True
            Else
                Return False

            End If
            desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function insertar_matriz(ByVal matriz As String, ByVal clave As String, ByVal ciudad As String) As Boolean
        Try
            conectar()
            Dim cmd = New SqlCommand("sp_insertar_Matriz")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@matriz", matriz)
            cmd.Parameters.AddWithValue("@clave", clave)
            cmd.Parameters.AddWithValue("@ciudad", ciudad)
            cmd.Connection = conn
            If cmd.ExecuteNonQuery Then
                MsgBox("Se ha agregado " + matriz)
                Return True
            Else
                Return False
            End If
            desconectar()
        Catch ex As Exception
            desconectar()
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub eliminar_matriz(ByVal datosMat() As String)
        Try
            conectar()
            Dim cmd = New SqlCommand("sp_eliminar_Matriz")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@matriz", datosMat(0))
            cmd.Parameters.AddWithValue("@clave", datosMat(1))
            cmd.Parameters.AddWithValue("@ciudad", datosMat(2))
            cmd.Connection = conn
            If cmd.ExecuteNonQuery Then
                MsgBox("Se ha eliminado " + datosMat(0))

            Else
                MsgBox("Se prudujo un error al eliminar: " + datosMat(0))
            End If
            desconectar()
        Catch ex As Exception
            desconectar()
            MsgBox(ex.Message)
        End Try
    End Sub


End Class

