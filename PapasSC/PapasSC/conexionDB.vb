Imports System.Data.SqlClient

Public Class conexionDB

    Public conn As SqlConnection

    Public Function conectar() 'metodo que hace la conexion a la base de datos
        Try
            conn = New SqlConnection("data source=localhost; initial catalog=PapaSC; integrated security=true")
            'conn = New SqlConnection("data source=localhost; initial catalog=PapaSC; integrated security=true") 'aqui cambia el nombre de su servidor Larigza
            'conn = New SqlConnection("data source=localhost; initial catalog=PapaSC; integrated security=true") 'aqui cambia el nombre de su servidor Chuy
            conn.Open() 'se abre la conexion
            If conn.State Then 'comprueba si la conexion esta habilitada 

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return True
    End Function

    Public Function desconectar()
            Try
                If (conn.State = ConnectionState.Open) Then
                    conn.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return False
        End Function

    End Class
