Imports System.Text.RegularExpressions
Imports PapasSC.MetodosClientes
Public Class Registro_Clientes
    Dim mtdCli As New MetodosClientes
    Private Sub Registro_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtRazonSocial.Enabled = False
            lbl18.Visible = False
            lbl19.Visible = False
            lbl20.Visible = False
            lbl21.Visible = False
            lbl22.Visible = False
            lbl23.Visible = False
            rdbHombre.Checked = True
            cmbEstado.SelectedIndex = 14
        Catch ex As Exception

        End Try
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
        Dim datosCliente As New List(Of String)
        If validar_camposNoNulos() = True Then
            Dim flag1 As Boolean = True
            Try
                'datos de nombre o razon social


                If Not cmbTipoPersona.SelectedItem = "Moral" Then
                    datosCliente.Add(txtNombre.Text) 'nombre persona fisica
                    If txtrfc.Text.Length > 0 And Not txtrfc.Text.Trim = String.Empty Then
                        datosCliente.Add(txtrfc.Text)

                    Else
                        datosCliente.Add("XAXX010101000") 'se le asigna la de publico general

                    End If
                    datosCliente.Add("") 'si es persona fisica no hay persona moral
                    datosCliente.Add("Fisica") 'se agrega el tipo de persona

                ElseIf cmbTipoPersona.SelectedItem = "Moral" Then 'es lo contrario 
                    datosCliente.Add("") '
                    If txtrfc.Text.Length > 0 Or Not txtrfc.Text.Trim = String.Empty Then
                        datosCliente.Add(txtrfc.Text)

                    Else
                        datosCliente.Add("XAXX010101000")

                    End If
                    datosCliente.Add(txtRazonSocial.Text)
                    datosCliente.Add("Moral")

                End If

                'agregar de contacto 
                datosCliente.Add(txtAlias.Text)
                If rdbRazonSocial.Checked Then
                    datosCliente.Add("R")
                ElseIf rdbHombre.Checked Then
                    datosCliente.Add("M")
                Else
                    datosCliente.Add("F")
                End If

                datosCliente.Add(txtDireccion.Text)
                datosCliente.Add(txtTelefono.Text)
                datosCliente.Add(txtEmail.Text)
                datosCliente.Add(CStr(cmbEstado.SelectedItem.ToString()))
                datosCliente.Add(txtMunicipio.Text)
                datosCliente.Add(txtCodigoPostal.Text)

                'datos de credito
                If txtLimiteCredito.Text.Length > 0 And Not txtLimiteCredito.Text.Equals("") Then
                    Dim credito As Double = (CDbl(txtLimiteCredito.Text))
                    datosCliente.Add(txtLimiteCredito.Text) ' limite de credito
                    datosCliente.Add(CStr(spnDiasCredito.Value)) ' dias de credito
                Else
                    datosCliente.Add("10000")

                End If
            Catch ex As Exception
                MsgBox(ex.Message + "1")
                flag1 = False
            End Try

            If flag1 = True Then
                mtdCli.insertar_Cliente(datosCliente)
            End If
        Else
            MsgBox(mensaje)
            activarSenialCamposObligatorios()
        End If
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
            txtNombre.Text = ""
            txtRazonSocial.Enabled = True
            rdbRazonSocial.Checked = True
            rdbMujer.Enabled = False
            rdbHombre.Enabled = False
        Else
            txtNombre.Enabled = True
            txtRazonSocial.Enabled = False
            txtNombre.Text = ""
            rdbRazonSocial.Enabled = True
            rdbRazonSocial.Checked = False
            rdbMujer.Enabled = True
            rdbHombre.Enabled = True

        End If
    End Sub

    Private Function validar_Correo(ByVal mail As String) As Boolean
        Return Regex.IsMatch(mail, "^[_a-z0-9]+(\._a-z0-9+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

    Private Function validar_Telefono(ByVal tel As String) As Boolean
        Return Regex.IsMatch(tel, "\d{3}-\d{3}-\d{4}")
    End Function

    Private mensaje As String

    Private Function validar_camposNoNulos() As Boolean
        Dim flag As Boolean = True
        Dim resutado As String = "Existen campos obligarios: "
        If Not cmbTipoPersona.SelectedItem = "Moral" Then
            If txtNombre.Text.Length = 0 Or txtNombre.Text.Trim = String.Empty Then
                resutado = resutado + "Nombre "
                flag = False
            End If
        Else
            If txtRazonSocial.Text.Length = 0 Or txtRazonSocial.Text.Trim = String.Empty Then
                resutado = resutado + "Razon Social "
                flag = False
            End If
        End If

        If txtLimiteCredito.Text.Length = 0 And Not txtLimiteCredito.Text.Trim = String.Empty Then
            resutado = resutado + "Limite de credito "
            flag = False
        ElseIf txtAlias.Text.Length = 0 And Not txtAlias.Text.Trim = String.Empty Then
            resutado = resutado + "Alias "
            flag = False
        ElseIf txtTelefono.Text.Length = 0 And Not txtTelefono.Text.Trim = String.Empty Then
            resutado = resutado + "Telefono "
            flag = False
        End If
        mensaje = resutado
        Return flag
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Function activarSenialCamposObligatorios() As Boolean
        Try
            lbl18.Visible = True
            lbl19.Visible = True
            lbl20.Visible = True
            lbl21.Visible = True
            lbl22.Visible = True
            lbl23.Visible = True
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


End Class