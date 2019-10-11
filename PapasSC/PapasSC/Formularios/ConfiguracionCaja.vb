Public Class ConfiguracionCaja
    Dim mtdCaja As New MetodosCaja
    Dim idCaja As New List(Of String)

    Private Sub ConfiguracionCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mtdCaja.seleccioarCajas(tblCaja)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim aeCaja As New AgregarEditarCaja
            aeCaja.Text = "Agregar"
            aeCaja.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFiltro_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyUp
        Try
            mtdCaja.seleccioarCajas(tblCaja, txtFiltro.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tblCaja_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblCaja.CellDoubleClick
        Try
            Dim aeCaja As New AgregarEditarCaja
            aeCaja.txtNombre.Text = tblCaja.CurrentRow.Cells("Caja").Value.ToString()
            aeCaja.txtReferencia.Text = tblCaja.CurrentRow.Cells("Referencia").Value.ToString()
            aeCaja.cmbBodega.SelectedText = tblCaja.CurrentRow.Cells("Bodega").Value.ToString()
            aeCaja.cmbFase.SelectedText = tblCaja.CurrentRow.Cells("Fase").Value.ToString()
            If tblCaja.CurrentRow.Cells("Estatus").Value.Equals("A") Then
                aeCaja.chbActivo.Checked = True
            Else
                aeCaja.chbActivo.Checked = False
            End If
            aeCaja.sprEfectivo.Value = tblCaja.CurrentRow.Cells("limiteEfectivo").Value.ToString()
            aeCaja.Text = "Actualizar"
            aeCaja.idCajaActualizar = tblCaja.CurrentRow.Cells("idCaja").Value.ToString()
            If tblCaja.CurrentRow.Cells("ValoresExplicitos").Value.Equals("A") Then
                aeCaja.chbExplicito.Checked = True
            Else
                aeCaja.chbExplicito.Checked = False
            End If
            aeCaja.ShowDialog()
            mtdCaja.seleccioarCajas(tblCaja)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            Dim aeCaja As New AgregarEditarCaja
            aeCaja.txtNombre.Text = tblCaja.CurrentRow.Cells("Caja").Value.ToString()
            aeCaja.txtReferencia.Text = tblCaja.CurrentRow.Cells("Referencia").Value.ToString()
            aeCaja.cmbBodega.SelectedText = tblCaja.CurrentRow.Cells("Bodega").Value.ToString()
            aeCaja.cmbFase.SelectedText = tblCaja.CurrentRow.Cells("Fase").Value.ToString()
            If tblCaja.CurrentRow.Cells("Estatus").Value.Equals("A") Then
                aeCaja.chbActivo.Checked = True
            Else
                aeCaja.chbActivo.Checked = False
            End If
            aeCaja.sprEfectivo.Value = tblCaja.CurrentRow.Cells("limiteEfectivo").Value.ToString()
            aeCaja.Text = "Actualizar"
            If tblCaja.CurrentRow.Cells("ValoresExplicitos").Value.Equals("A") Then
                aeCaja.chbExplicito.Checked = True
            Else
                aeCaja.chbExplicito.Checked = False
            End If
            aeCaja.idCajaActualizar = tblCaja.CurrentRow.Cells("idCaja").Value.ToString()
            aeCaja.ShowDialog()
            mtdCaja.seleccioarCajas(tblCaja)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim idCajaB As String = tblCaja.CurrentRow.Cells("idCaja").Value.ToString
            mtdCaja.eliminarCaja(idCajaB)
            mtdCaja.seleccioarCajas(tblCaja)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class