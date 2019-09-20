Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports PapasSC.MetodosProveedor

Public Class Registrar_Proveedor

    Dim MetProveedor As New MetodosProveedor

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Me.Close()
    End Sub

    Private Sub Registrar_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRazonSocialProvee.Enabled = False
        txtDireccion2.Visible = False
        lblDireccion2.Visible = False
        txtEmail2.Visible = False
        lblEmail2.Visible = False
        txtTelefono2.Visible = False
        lblTelefono2.Visible = False
        rdbMasculinoProvee.Checked = True
        cboEstadoProvee.SelectedIndex = 14
        lblCamObli1.Visible = False
        lblCamObli2.Visible = False
        lblCamObli3.Visible = False
        lblCamObli4.Visible = False

        Try
            MetProveedor.SelecionarCiu(cboOrigenCiudad)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub chbExtras_CheckedChanged(sender As Object, e As EventArgs) Handles chbExtras.CheckedChanged
        If chbExtras.Checked = True Then
            txtDireccion2.Visible = True
            lblDireccion2.Visible = True
            txtEmail2.Visible = True
            lblEmail2.Visible = True
            txtTelefono2.Visible = True
            lblTelefono2.Visible = True
        ElseIf chbExtras.Checked = False Then
            txtDireccion2.Visible = False
            lblDireccion2.Visible = False
            txtEmail2.Visible = False
            lblEmail2.Visible = False
            txtTelefono2.Visible = False
            lblTelefono2.Visible = False
            txtDireccion2.Text = ""
            txtTelefono2.Text = ""
            txtEmail2.Text = ""

        End If
    End Sub



    Private Sub txtRazonSocialProvee_KeyUp(sender As Object, e As KeyEventArgs) Handles txtRazonSocialProvee.KeyUp
        Try
            txtAliasProvee.Text = txtRazonSocialProvee.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNombreProvee_TextChanged(sender As Object, e As EventArgs) Handles txtNombreProvee.TextChanged
        Try
            txtAliasProvee.Text = txtNombreProvee.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtRfcProvee_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRfcProvee.KeyDown
        Try
            Dim rfc As String = txtRfcProvee.Text

            If rfc.Length >= 13 Then
                rfc = rfc.Remove(rfc.Length - 1)
                txtRfcProvee.Text = rfc
            ElseIf rfc.Length > 13 Then
                MsgBox("Solo se permiten 13 caracteres")
            End If
            txtRfcProvee.Text = txtRfcProvee.Text.ToUpper
            txtRfcProvee.SelectionStart = rfc.Length
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bntConfirmar_Click(sender As Object, e As EventArgs) Handles bntConfirmar.Click

        Dim datosPro As New List(Of String)

        If ValidarCampos() = True Then

            Dim flag1 As Boolean = True
            Try
                datosPro.Add(txtNombreProvee.Text)
                datosPro.Add(txtRfcProvee.Text)
                datosPro.Add(txtRazonSocialProvee.Text)

                datosPro.Add(cboOrigenCiudad.Text)

                If chbActivo.Checked Then
                    datosPro.Add("A")
                Else
                    datosPro.Add("I")
                End If


                datosPro.Add(cboTipoPersonaPro.Text)



                datosPro.Add(txtAliasProvee.Text)

                If rdbNoApliPro.Checked Then
                    datosPro.Add("R")
                ElseIf rdbMasculinoProvee.Checked Then
                    datosPro.Add("M")
                Else
                    datosPro.Add("F")
                End If

                datosPro.Add(txtDomicilioPro.Text)
                datosPro.Add(txtTelefonoPro.Text)
                datosPro.Add(txtEmailPro.Text)
                If chbExtras.Checked Then
                    datosPro.Add(txtTelefono2.Text)
                    datosPro.Add(txtEmail2.Text)
                    datosPro.Add(txtDireccion2.Text)
                Else
                    datosPro.Add("")
                    datosPro.Add("")
                    datosPro.Add("")
                End If
                'datosPro.Add(txtDireccion2.Text)
                'datosPro.Add(txtTelefono2.Text)
                'datosPro.Add(txtEmail2.Text)
                datosPro.Add(cboEstadoProvee.Text)
                datosPro.Add(txtMunicipioPro.Text)
                datosPro.Add(txtCodigoPostalPro.Text)

            Catch ex As Exception
                MsgBox(ex.Message + "1")
                flag1 = False
            End Try

            If flag1 = True Then
                MetProveedor.InsertarProveedor(datosPro)
            End If

        Else
            MsgBox(mensaje)
            CamposObligatorios()
        End If

        'MetProveedor.InsertarProveedor(datosPro)


        '    If ValidarCampos() = True Then
        '        Dim flag1 As Boolean = True
        '        Try
        '            If Not cboTipoPersonaPro.SelectedItem = "Moral" Then
        '                datosPro.Add(txtNombreProvee.Text)
        '                If txtRfcProvee.Text.Length > 0 And Not txtRfcProvee.Text.Trim = String.Empty Then
        '                    datosPro.Add(txtRfcProvee.Text)
        '                Else
        '                    datosPro.Add("XAXX010101000")
        '                End If

        '                datosPro.Add("")
        '                datosPro.Add("Fisica")

        '            ElseIf cboTipoPersonaPro.SelectedItem = "Moral" Then
        '                datosPro.Add("") '
        '                If txtRfcProvee.Text.Length > 0 Or Not txtRfcProvee.Text.Trim = String.Empty Then
        '                    datosPro.Add(txtRfcProvee.Text)

        '                Else
        '                    datosPro.Add("XAXX010101000")

        '                End If
        '                datosPro.Add(txtRazonSocialProvee.Text)
        '                datosPro.Add("Moral")

        '            End If

        '            If chbActivo.Checked Then
        '                datosPro.Add("A")
        '            Else
        '                datosPro.Add("I")
        '            End If

        '            datosPro.Add(txtAliasProvee.Text)
        '            If rdbNoApliPro.Checked Then
        '                datosPro.Add("R")
        '            ElseIf rdbMasculinoProvee.Checked Then
        '                datosPro.Add("M")
        '            Else
        '                datosPro.Add("F")
        '            End If

        '            datosPro.Add(txtDomicilioPro.Text)
        '            datosPro.Add(txtTelefonoPro.Text)
        '            datosPro.Add(txtEmailPro.Text)
        '            datosPro.Add(CStr(cboEstadoProvee.SelectedItem.ToString()))
        '            datosPro.Add(txtMunicipioPro.Text)
        '            datosPro.Add(txtCodigoPostalPro.Text)
        '            datosPro.Add(CStr(cboOrigenCiudad.SelectedItem.ToString()))

        '            If chbExtras.Checked Then
        '                datosPro.Add(txtTelefono2.Text)
        '                datosPro.Add(txtEmail2.Text)
        '                datosPro.Add(txtDireccion2.Text)
        '            Else
        '                datosPro.Add("")
        '                datosPro.Add("")
        '                datosPro.Add("")
        '            End If
        '        Catch ex As Exception
        '            MsgBox(ex.Message + "1")
        '            flag1 = False
        '        End Try

        '        If flag1 = True Then
        '            MetProveedor.InsertarProveedor(datosPro)
        '        End If

        '    Else
        '        MsgBox(mensaje)
        '        CamposObligatorios()
        '    End If
    End Sub

    Private Sub cboTipoPersonaPro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoPersonaPro.SelectedIndexChanged
        If cboTipoPersonaPro.SelectedItem = "Moral" Then
            txtRfcProvee.Text = "XAX010101000"
            txtNombreProvee.Enabled = False
            txtNombreProvee.Text = ""
            txtRazonSocialProvee.Enabled = True
            rdbNoApliPro.Checked = True
            rdbFemeninoProvee.Enabled = False
            rdbMasculinoProvee.Enabled = False
        Else
            txtRfcProvee.Text = "XAXX010101000"
            txtNombreProvee.Enabled = True
            txtRazonSocialProvee.Enabled = False
            txtNombreProvee.Text = ""
            rdbNoApliPro.Enabled = True
            rdbNoApliPro.Checked = False
            rdbFemeninoProvee.Enabled = True
            rdbMasculinoProvee.Enabled = True
        End If

    End Sub

    Private Function validar_Correo(ByVal mail As String) As Boolean
        Return Regex.IsMatch(mail, "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]{2,4}$") '"^[_a-zA-B0-9]+(\._a-zA-B0-9+)*@[a-zA-B0-9-]+(\.[a-zA-B0-9-]+)*(\.[a-z]{2,4})$")
    End Function

    Private Function validar_Telefono(ByVal tel As String) As Boolean
        Return Regex.IsMatch(tel, "\d{3}-\d{3}-\d{4}")
    End Function

    Private mensaje As String

    Private Function ValidarCampos() As Boolean
        Dim flag As Boolean = True
        Dim resultado As String = "Existen campos obligarios: "

        If Not cboTipoPersonaPro.SelectedItem = "Moral" Then
            If txtNombreProvee.Text.Length = 0 Or txtNombreProvee.Text.Trim = String.Empty Then
                resultado = resultado + "Nombre "
                flag = False
            End If
        Else
            If txtRazonSocialProvee.Text.Length = 0 Or txtRazonSocialProvee.Text.Trim = String.Empty Then
                resultado = resultado + "Razon Social "
                flag = False
            End If
        End If


        If txtAliasProvee.Text.Length = 0 And Not txtAliasProvee.Text.Trim = String.Empty Then
            resultado = resultado + "Alias "
            flag = False
        ElseIf txtTelefonoPro.Text.Length = 0 And Not txtTelefonoPro.Text.Trim = String.Empty Then
            resultado = resultado + "Telefono "
            flag = False
        End If
        mensaje = resultado

        If cboTipoPersonaPro.Text = "Moral" And txtRfcProvee.Text.Length <> 12 Then
            MsgBox("El RFC de una persona Moral debe contener 12 Caracteres")
            flag = False
        ElseIf cboTipoPersonaPro.Text = "Física" And txtRfcProvee.Text.Length <> 13 Then
            MsgBox("El RFC de una persona Física debe contener 13 Caracteres")
            flag = False
        End If

        If Not txtTelefonoPro.Text = String.Empty Then
            Dim arrayTel() As Char = txtTelefonoPro.Text.ToCharArray

            If arrayTel(3).Equals("-"c) And arrayTel(7).Equals("-"c) And arrayTel.Length = 12 And validar_Telefono(txtTelefonoPro.Text) Then
            Else
                MsgBox("El número debe tener el siguiente formato 355-000-0000")
                flag = False
            End If
        End If

        If validar_Correo(txtEmailPro.Text) <> True Then
            MsgBox("El correo no es valido")
            flag = False
        End If
        Return flag
    End Function

    Private Function CamposObligatorios() As Boolean
        Try
            lblCamObli1.Visible = True
            lblCamObli2.Visible = True
            lblCamObli3.Visible = True
            lblCamObli4.Visible = True
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub txtCodigoPostalPro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoPostalPro.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) Then
        ElseIf Not Char.IsControl(e.KeyChar) Then
        Else
            MsgBox("Solo puedes ingresar números y no exeder de 5 dígitos")
        End If
    End Sub

    Private Sub txtCodigoPostalPro_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCodigoPostalPro.KeyUp
        Try
            Dim textocp As String = txtCodigoPostalPro.Text
            If textocp.Length > 5 Then
                textocp = textocp.Remove(textocp.Length - 1)
                txtCodigoPostalPro.Text = textocp
            End If
            txtCodigoPostalPro.Text = txtCodigoPostalPro.Text.ToUpper
            txtCodigoPostalPro.SelectionStart = textocp.Length
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTelefonoPro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefonoPro.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If IsNumeric(e.KeyChar) Then
        ElseIf e.KeyChar.Equals("-"c) Then
        ElseIf Char.IsControl(e.KeyChar) Then
        Else
            MsgBox("Solo puedes ingresar números y no exeder de 12 dígitos")
        End If
    End Sub

    Private Sub txtTelefonoPro_KeyUp(sender As Object, e As KeyEventArgs) Handles txtTelefonoPro.KeyUp
        Try
            If txtTelefonoPro.Text.Length = 3 Or txtTelefonoPro.Text.Length = 7 Then
                txtTelefonoPro.Text = txtTelefonoPro.Text + "-"
            End If


            Dim texttel As String = txtTelefonoPro.Text
            If texttel.Length > 12 Then
                texttel = texttel.Remove(texttel.Length - 1)
                txtTelefonoPro.Text = texttel
                'MsgBox("Solo se permiten como maximo 13 caracteres")
            End If
            txtTelefonoPro.Text = txtTelefonoPro.Text.ToUpper
            txtTelefonoPro.SelectionStart = texttel.Length
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTelefono2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono2.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If IsNumeric(e.KeyChar) Then
        ElseIf e.KeyChar.Equals("-"c) Then
        ElseIf Char.IsControl(e.KeyChar) Then
            'ElseIf txtTelefono.Text.Length <= 12 Then
        Else
            MsgBox("Solo puedes ingresar números y no exeder de 12 dígitos")
        End If
    End Sub

    Private Sub txtTelefono2_KeyUp(sender As Object, e As KeyEventArgs) Handles txtTelefono2.KeyUp
        Try
            If txtTelefono2.Text.Length = 3 Or txtTelefono2.Text.Length = 7 Then
                txtTelefono2.Text = txtTelefono2.Text + "-"
            End If


            Dim texttel As String = txtTelefono2.Text

            If texttel.Length > 12 Then
                texttel = texttel.Remove(texttel.Length - 1)
                txtTelefono2.Text = texttel
                'MsgBox("Solo se permiten como maximo 13 caracteres")
            End If
            txtTelefono2.Text = txtTelefono2.Text.ToUpper
            txtTelefono2.SelectionStart = texttel.Length
        Catch ex As Exception

        End Try
    End Sub



    'Dim Pro As New MetodosProveedor

    'Private Sub Label5_Click(sender As Object, e As EventArgs)
    '    Me.Close()
    '    Consultar_Proveedores.Show()
    'End Sub

    'Private Sub Registrar_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Try
    '        Pro.SelecionarCiu(cboCiudadProve)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub

    'Private Sub btnAceptarProvee_Click(sender As Object, e As EventArgs)
    '    Try
    '        If Me.ValidateChildren And txtNombrePro.Text <> String.Empty Then
    '            MessageBox.Show("Datos resgistrados correctamente", "Registro de empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Pro.InsertarProveedor(txtNombrePro.Text, txtTelefonoProvee.Text, txtEmailProvee.Text, cboCiudadProve.Text)
    '        Else
    '            MessageBox.Show("Ingrese correctamente los datos", "Registro de empleados", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub


    'Private Sub txtNombrePro_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    ValidarLetras(e)
    '    txtNombrePro.MaxLength = 80
    'End Sub

    'Private Sub ValidarLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = True
    '        MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = False
    '    End If
    'End Sub

    'Private Sub ValidarNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '        MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
    '    End If
    'End Sub

    'Private Sub txtTelefonoProvee_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    ValidarNumeros(e)
    '    txtTelefonoProvee.MaxLength = 12
    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs)
    '    Me.Close()
    'End Sub

    'Private Sub txtNombrePro_Validating(sender As Object, e As CancelEventArgs)
    '    If DirectCast(sender, TextBox).Text.Length > 0 Then
    '        Me.ErrorIcono.SetError(sender, "")
    '    Else
    '        Me.ErrorIcono.SetError(sender, "Ingrese el nombre este dato es obligatorio")
    '    End If
    'End Sub



    'Private Sub txtEmailProvee_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    txtEmailProvee.MaxLength = 50
    'End Sub


End Class