Imports System.Data.SqlClient

Public Class Configuracion


    Dim conn As New SqlConnection("data source=localhost; initial catalog=PapaSC; integrated security=true")

    Public Sub Respaldo()

        Dim Nom_Copia As String = (Date.Today.Day.ToString & "-" & Date.Today.Month.ToString & "-" & Date.Today.Year.ToString & "-" & Date.Now.Hour.ToString &
       "-" & Date.Now.Minute.ToString & "-" & Date.Now.Second.ToString & " [Copia de seguridad] [PapasSC].bak")

        Dim comando As String = "BACKUP DATABASE [PapaSC] TO DISK = N'C:\CopiaPapas\" & Nom_Copia & "' WITH NOFORMAT, NOINIT,  NAME = N'PapaSC-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"

        Dim cmd As SqlCommand = New SqlCommand(comando, conn)

        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("La copia de seguridad de la Base de Datos papas Santa Cruz (PapaSC) se realizo correctamente")

        Catch ex As Exception
            MsgBox("Se desea realizar otra copia se seguridad, vuelva a intentarlo")
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Sub

    Public Sub IndexBd()

        Try
            conn.Open()

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
            conn.Close()
            MsgBox(ex.Message)
        End Try



    End Sub

    Public Sub Restaurar()

        Dim ruta As String
        Dim conRest As New SqlConnection("data source=localhost; initial catalog=master; integrated security=true")


        Try

            Dim archivo As New OpenFileDialog

            archivo.Filter = "BAK|*.bak"
            If archivo.ShowDialog = Windows.Forms.DialogResult.OK Then
                ruta = archivo.FileName()
                Dim comando As String = "RESTORE DATABASE [PapaSC] FROM  DISK = N'" & ruta & "' WITH  FILE = 1,  NOUNLOAD,  STATS = 5"

                Dim cmd As SqlCommand = New SqlCommand(comando, conRest)

                conRest.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Se restauro correctamente la base de datos 'Papas Santa Cruz (PapaSC) '")
            End If


        Catch ex As Exception
            MsgBox("No se restauro la base de datos 'Papas Santa Cruz (PapaSC) ', vuelva intentarlo")
        Finally
            conRest.Close()
            conRest.Dispose()
        End Try

    End Sub



End Class
