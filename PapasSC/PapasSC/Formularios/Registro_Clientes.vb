Public Class Registro_Clientes
    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub txtrfc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtrfc.KeyUp
        Try
            Dim textoRFC As String = txtrfc.Text

            If textoRFC.Length >= 13 Then
                textoRFC = textoRFC.Remove(textoRFC.Length - 1)
                txtrfc.Text = textoRFC
                'MsgBox("Solo se permiten como maximo 13 caracteres")
            End If
            txtrfc.Text = txtrfc.Text.ToUpper
            txtrfc.SelectionStart = textoRFC.Length

        Catch ex As Exception

        End Try
    End Sub

    Private Sub bntConfirmar_Click(sender As Object, e As EventArgs) Handles bntConfirmar.Click
        Try
            'datos de nombre o razon social
            Dim datosCliente As New List(Of String)
            If txtNombre.Text.Length = 0 Or txtNombre.Text.Trim = String.Empty Then
                datosCliente.Add(txtRazonSocial.Text)
                rdbRazonSocial.Checked = True
            ElseIf txtRazonSocial.Text.Length = 0 Or txtRazonSocial.Text.Trim = String.Empty Then
                datosCliente.Add(txtNombre.Text)
            ElseIf txtNombre.Text.Trim = String.Empty And txtRazonSocial.Text.Trim = String.Empty Then
                MsgBox("Tines que agregar el Nombre o la Razon socuial")
            End If
            'datos de rfc
            If txtrfc.Text.Length > 0 And Not txtrfc.Text.Trim = String.Empty Then
                datosCliente.Add(txtrfc.Text)
            Else
                datosCliente.Add("XAXX010101000") 'se le asigna la de publico general
            End If
            'datos de credito
            If txtLimiteCredito.Text.Length > 0 And Not txtLimiteCredito.Text.Equals("") Then
                Dim credito As Double = (CDbl(txtLimiteCredito.Text))
                datosCliente.Add(txtLimiteCredito.Text) ' limite de credito
                datosCliente.Add(CStr(spnDiasCredito.Value)) ' dias de credito
            Else
                datosCliente.Add("10000")
            End If
            'agregar de contacto 
            datosCliente.Add(txtAlias.Text)
            datosCliente.Add(txtDireccion.Text)
            datosCliente.Add(txtCodigoPostal.Text)
            datosCliente.Add(txtTelefono.Text)
            datosCliente.Add(txtEmail.Text)
            datosCliente.Add(txtMunicipio.Text)
            datosCliente.Add(cmbEstado.SelectedItem.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtLimiteCredito_KeyUp(sender As Object, e As KeyEventArgs) Handles txtLimiteCredito.KeyUp
        Try
            txtLimiteCredito.Text = txtLimiteCredito.Text.Replace(".", ",")
            txtLimiteCredito.SelectionStart = txtLimiteCredito.Text.Length
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Label9_Click_1(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Close()
    End Sub

    Private Sub txtRazonSocial_KeyUp(sender As Object, e As KeyEventArgs) Handles txtRazonSocial.KeyUp
        Try
            txtAlias.Text = txtRazonSocial.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNombre_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyUp
        Try
            txtAlias.Text = txtNombre.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbTipoPersona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoPersona.SelectedIndexChanged
        If cmbTipoPersona.SelectedItem = "Moral" Then
            txtNombre.Enabled = False
            txtRazonSocial.Enabled = True
            rdbRazonSocial.Checked = True
            rdbMujer.Enabled = False
            rdbHombre.Enabled = False
        Else
            txtNombre.Enabled = True
            txtRazonSocial.Enabled = False
            rdbRazonSocial.Enabled = True
            rdbRazonSocial.Checked = False
            rdbMujer.Enabled = True
            rdbHombre.Enabled = True

        End If
    End Sub

    Private Sub Registro_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtRazonSocial.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
End Class