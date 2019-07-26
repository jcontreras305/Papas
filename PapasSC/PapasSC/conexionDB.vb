Imports System.Data.SqlClient

Public Class conexionDB

    Public conn As SqlConnection
        Public Function conectar()
            Try
            conn = New SqlConnection("data source=localhost; initial catalog=PapaSC; integrated security=true")
            'conn = New SqlConnection("data source=localhost; initial catalog=PapaSC; integrated security=true") 'aqui cambia el nombre de su servidor Larigza
            'conn = New SqlConnection("data source=localhost; initial catalog=PapaSC; integrated security=true") 'aqui cambia el nombre de su servidor Chuy
            conn.Open()
                If conn.State Then
                    MsgBox("la conexion esta abierta")
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
