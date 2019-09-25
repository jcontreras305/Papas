Imports System.Drawing

Public Class AgregarEditarTicket
    Dim mtdTicket As New MetodosTicket

    Private Sub AgregarEditarTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mtdTicket.cargarBodega(cmbBodega)
            cmbFuente.Items.Clear()
            For Each tipo In FontFamily.Families
                cmbFuente.Items.Add(tipo.Name)
            Next
            cmbFuente.SelectedItem = "Arial"
            sprTamanio.Maximum = 12
            sprTamanio.Minimum = 5
            sprTamanio.Value = 10
            txtEncabezado.Text = "Produtoras de Papas" + vbCrLf + "   Santa Cruz"
            txtPie.Text = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim datos(6) As String
            datos(0) = cmbBodega.Text
            datos(1) = txtClave.Text
            datos(2) = txtNombre.Text
            datos(3) = cmbFuente.Text
            datos(4) = sprTamanio.Value
            datos(5) = txtEncabezado.Text
            datos(6) = txtPie.Text
            mtdTicket.insertarTipoTicket(datos)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function validar() As Boolean
        Try
            Dim flag As Boolean = True
            If txtClave.Text = String.Empty Then
                flag = False
            End If
            If txtNombre.Text = String.Empty Then
                flag = False
            End If


            Return flag



        Catch ex As Exception
            Return False
        End Try
    End Function
End Class