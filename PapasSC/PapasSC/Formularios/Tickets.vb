Public Class tickets

    Dim mtdMetodosTicket As New MetodosTicket
    Dim ticket As New Ticket


    Private Sub btnPruebaTicket_Click(sender As Object, e As EventArgs) Handles btnPruebaTicket.Click
        'If tblFormatostTicket.Rows.Count > 0 Then
        '    Dim clave As String = tblFormatostTicket.SelectedCells().Item(0).Value
        '    Dim nombre As String = tblFormatostTicket.SelectedCells().Item(2).Value

        'End If

        VerTicket.Show()
    End Sub

    Private Sub tickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mtdMetodosTicket.verFormatosTickets(tblFormatostTicket)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'AgregarEditarTicket.Show()
        Try
            Dim aetick As New AgregarEditarTicket
            AddOwnedForm(aetick)
            aetick.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim aetick As New AgregarEditarTicket
            AddOwnedForm(aetick)
            Dim datos(8) As String
            Dim cont As Int16 = 0
            For Each item As DataGridViewCell In tblFormatostTicket.SelectedCells
                datos(cont) = item.Value
                cont += 1
            Next
            aetick.txtClave.Text = datos(0)
            aetick.cmbBodega.Text = datos(1)
            aetick.txtNombre.Text = datos(2)
            aetick.cmbFuente.Text = datos(3)
            aetick.sprTamanio.Value = CInt(datos(4))
            aetick.txtDireccion.Text = datos(7)
            aetick.txtEncabezado.Text = datos(5)
            aetick.txtPie.Text = datos(6)
            aetick.flagModificar = True
            aetick.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message + ", es problame que no seleccionaste la fila")
        End Try
    End Sub
End Class