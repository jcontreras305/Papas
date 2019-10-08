Public Class AgregarEditarCaja
    Dim mtdCaja As New MetodosCaja
    Dim idsBodega As New List(Of String)
    Public idCajaActualizar As String

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub AgregarEditarCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mtdCaja.nombreBodegas(cmbBodega, idsBodega)
            cmbBodega.SelectedIndex = 0
            chbActivo.Checked = True
            cmbFase.SelectedIndex = 0
            sprEfectivo.Maximum = 99999
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim datos(5) As String

            datos(0) = txtNombre.Text
            datos(1) = txtReferencia.Text
            If chbActivo.Checked Then
                datos(2) = "A"
            Else
                datos(2) = "I"
            End If
            datos(3) = cmbFase.Text
            datos(4) = CStr(sprEfectivo.Value)
            Dim index As Int32 = cmbBodega.FindString(cmbBodega.Text)
            datos(5) = idsBodega(index)
            If Me.Text.Equals("Agregar") Then
                mtdCaja.insertarCaja(datos)
            ElseIf Me.Text.Equals("Actualizar") Then
                mtdCaja.actualizarcaja(datos, idCajaActualizar)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtReferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReferencia.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Or txtNombre.Text.Length > 5
    End Sub
End Class