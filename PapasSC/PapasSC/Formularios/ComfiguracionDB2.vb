Imports PapasSC.Configuracion

Imports System.IO

Public Class ComfiguracionDB2
    Dim metConf As New Configuracion


    Private Sub btnRespaldo_Click(sender As Object, e As EventArgs) Handles btnRespaldo.Click
        metConf.Respaldo()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Me.Close()
    End Sub

    Private Sub ComfiguracionDB2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim create As Object
        Dim creada As String
        create = CreateObject("Scripting.FileSystemObject")
        creada = "C:\CopiaPapas"



        If Directory.Exists(creada) Then
            'MsgBox("La carpeta existe")
        Else
            create.createFolder("C:\CopiaPapas")
            'MsgBox("No existe")
        End If

    End Sub

    Private Sub btnIndexacion_Click(sender As Object, e As EventArgs) Handles btnIndexacion.Click
        Dim index As New Configuracion

        index.IndexBd()
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Dim res As New Configuracion

        res.Restaurar()

    End Sub
End Class