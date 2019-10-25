Imports System.Data.SqlClient

Public Class Configuracion
    Inherits conexionDB

    Dim conn1 As New SqlConnection("data source=localhost; initial catalog=PapaSC; integrated security=true")

    Public Sub Respaldo()

        Dim Nom_Copia As String = (Date.Today.Day.ToString & "-" & Date.Today.Month.ToString & "-" & Date.Today.Year.ToString & "-" & Date.Now.Hour.ToString &
       "-" & Date.Now.Minute.ToString & "-" & Date.Now.Second.ToString & " [Copia de seguridad] [PapasSC].bak")

        Dim comando As String = "BACKUP DATABASE [PapaSC] TO DISK = N'C:\CopiaPapas\" & Nom_Copia & "' WITH NOFORMAT, NOINIT,  NAME = N'PapaSC-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"

        Dim cmd As SqlCommand = New SqlCommand(comando, conn1)

        Try
            conn1.Open()
            cmd.ExecuteNonQuery()
            MsgBox("La copia de seguridad de la Base de Datos papas Santa Cruz (PapaSC) se realizo correctamente: ")

        Catch ex As Exception
            MsgBox("Se desea realizar otra copia se seguridad, vuelva a intentarlo")
        Finally
            conn1.Close()
            conn1.Dispose()
        End Try
    End Sub

    Public Sub IndexBd()

        Try
            conn1.Open()

            Dim cmd As SqlCommand = New SqlCommand("sp_Reindexar")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output

            If cmd.ExecuteNonQuery Then
                Dim resultado As String = cmd.Parameters("@msg").Value
                MsgBox(resultado)

                MsgBox("Se realizo correctamente la indexacion de Papas Santa Cruz")

            End If

        Catch ex As Exception
            conn1.Close()
            MsgBox(ex.Message)
        End Try



    End Sub

    Public Sub Restaurar()
        conectar()
        Dim cmd2 As New SqlCommand("alter database [PapaSC] set offline with rollback immediate", conn)
        cmd2.ExecuteNonQuery()
        desconectar()
        conn1.Close()

        Dim ruta As String
        Dim conRest As New SqlConnection("data source=localhost; initial catalog=master; integrated security=true")


        Try

            Dim archivo As New OpenFileDialog

            archivo.Filter = "BAK|*.bak"
            If archivo.ShowDialog = Windows.Forms.DialogResult.OK Then
                ruta = archivo.FileName()

                Dim comando1 As String = "RESTORE DATABASE [PapaSC] FROM  DISK = N'" & ruta & "' WITH  FILE = 1,  NOUNLOAD,  STATS = 5"


                Dim cmd1 As SqlCommand = New SqlCommand(comando1, conRest)

                conRest.Open()
                cmd1.ExecuteNonQuery()
                MsgBox("Se restauro correctamente la base de datos 'Papas Santa Cruz (PapaSC) '")
            End If
            conectar()
            Dim cmd3 As New SqlCommand("alter database [PapaSC] set online", conn)
            cmd3.ExecuteNonQuery()
            desconectar()

        Catch ex As Exception
            MsgBox("No se restauro la base de datos 'Papas Santa Cruz (PapaSC) ', vuelva intentarlo" + ex.Message)
        Finally
            conRest.Close()
            conRest.Dispose()
        End Try

    End Sub



End Class
