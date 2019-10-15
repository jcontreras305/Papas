Imports System.Drawing

Public Class AgregarEditarTicket
    Public mtdTicket As New MetodosTicket
    Public flagModificar As Boolean

    Private Sub AgregarEditarTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If flagModificar = True Then
                cmbBodega.Enabled = False
                txtClave.Enabled = False
                txtNombre.Enabled = False
                sprTamanio.Maximum = 12
                sprTamanio.Minimum = 5
            Else
                cmbFuente.SelectedItem = "Arial"
                sprTamanio.Maximum = 12
                sprTamanio.Minimum = 5
                sprTamanio.Value = 10
                txtEncabezado.Text = "Produtoras de Papas" + vbCrLf + "   Santa Cruz"
                txtPie.Text = "Prodctora de Papas Santa Cruz agradece su compra"
            End If
            mtdTicket.cargarBodega(cmbBodega)
            cmbFuente.Items.Clear()
            For Each tipo In FontFamily.Families
                cmbFuente.Items.Add(tipo.Name)
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim tckt As tickets = CType(Owner, tickets)
        mtdTicket.verFormatosTickets(tckt.tblFormatostTicket)
        Me.Close()
    End Sub

    Public Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            Dim datos(7) As String
            datos(0) = cmbBodega.Text
            datos(1) = txtClave.Text
            datos(2) = txtNombre.Text
            datos(3) = cmbFuente.Text
            datos(4) = sprTamanio.Value
            datos(5) = txtEncabezado.Text
            datos(6) = txtPie.Text
            datos(7) = txtDireccion.Text
            If flagModificar = True Then
                mtdTicket.actualizarTicket(datos)
                Dim tckt As tickets = CType(Owner, tickets)
                mtdTicket.verFormatosTickets(tckt.tblFormatostTicket)
                Me.Close()
            Else
                mtdTicket.insertarTipoTicket(datos)
                Dim tckt As tickets = CType(Owner, tickets)
                mtdTicket.verFormatosTickets(tckt.tblFormatostTicket)
            End If
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