

Public Class ConfiguracionBD1
    Private Sub ConfiguracionBD1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim ho As New Int16
        'txtTimeIni.Text = Format(ho, "  :  : ")
        'txtTimeFin.Text = Format(ho, "  :  : ")

        cboTipoMan.Items.Add("Respaldo")
        cboTipoMan.Items.Add("Auditoria")
        cboTipoMan.Items.Add("Reindexar BD")
        jpanel.Visible = False

    End Sub

    Private Sub cboTipoMan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoMan.SelectedIndexChanged

        If cboTipoMan.Text = "Respaldo" Then
            cboTipo.Items.Clear()
            cboTipo.Items.Add("Completo")
            cboTipo.Items.Add("Diferencial")
            jpanel.Visible = True
        ElseIf cboTipoMan.Text = "Auditoria" Then
            cboTipo.Items.Clear()
            cboTipo.Items.Add("1")
            cboTipo.Items.Add("2")
            jpanel.Visible = False
        ElseIf cboTipoMan.Text = "Reindexar BD" Then
            cboTipo.Items.Clear()
            cboTipo.Items.Add("Tablas")
            cboTipo.Items.Add("Datos")
            jpanel.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


End Class