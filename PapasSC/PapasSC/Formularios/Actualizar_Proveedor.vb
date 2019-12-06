Imports PapasSC.MetodosProveedor
Imports PapasSC.Consultar_Proveedores
Imports System.Text.RegularExpressions

Public Class Actualizar_Proveedor
    Private datosPro() As String
    Dim MetProveedor As New MetodosProveedor


    Private Sub Actualizar_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCamObli1.Visible = False
        lblCamObli2.Visible = False
        lblCamObli3.Visible = False
        lblCamObli4.Visible = False



        rdbMasculinoProvee.Checked = True
        datosPro = Consultar_Proveedores.datosProveedor


        Try

            txtNombreProvee.Text = datosPro(0).ToString
        Catch ex As Exception
            txtNombreProvee.Text = ""
        End Try

        txtAliasProvee.Text = datosPro(1).ToString



        Try

            txtRazonSocialProvee.Text = datosPro(3).ToString
        Catch ex As Exception
            txtRazonSocialProvee.Text = ""

        End Try

        txtRfcProvee.Text = datosPro(2)
        cboTipoPersonaPro.Text = datosPro(4)

        If datosPro(16) = "A" Then
            chbActivo.Checked = True
        Else
            chbActivo.Checked = False
        End If

        If datosPro(5).Equals("M") Then
            rdbMasculinoProvee.Checked = True
        ElseIf datosPro(5).Equals("F") Then
            rdbFemeninoProvee.Checked = True
        Else
            rdbNoApliPro.Checked = True
        End If

        txtDomicilioPro.Text = datosPro(6)
        txtTelefonoPro.Text = datosPro(7)
        txtEmailPro.Text = datosPro(8)

        cboEstadoProvee.SelectedText = datosPro(13)
        txtMunicipioPro.Text = datosPro(14)
        txtCodigoPostalPro.Text = datosPro(15)

        Try
            MetProveedor.SelecionarCiu(cboOrigenCiudad)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cboOrigenCiudad.SelectedIndex = cboOrigenCiudad.FindString(datosPro(12))


        If Not datosPro(9).Equals(String.Empty) Or Not datosPro(10).Equals(String.Empty) Or Not datosPro(11).Equals(String.Empty) Then
            txtDireccion2.Visible = True
            txtTelefono2.Visible = True
            txtEmail2.Enabled = True
            lblDireccion2.Visible = True
            lblTelefono2.Visible = True
            lblEmail2.Visible = True
            txtDireccion2.Text = datosPro(9)
            txtTelefono2.Text = datosPro(10)
            txtEmail2.Text = datosPro(11)
            chbExtras.Checked = True
        Else
            txtDireccion2.Visible = False
            txtTelefono2.Visible = False
            txtEmail2.Enabled = False
            lblDireccion2.Visible = False
            lblTelefono2.Visible = False
            lblEmail2.Visible = False
            chbExtras.Checked = False
        End If



    End Sub

    Private Sub chbExtras_CheckedChanged(sender As Object, e As EventArgs) Handles chbExtras.CheckedChanged
        If chbExtras.Checked Then
            lblDireccion2.Visible = True
            lblTelefono2.Visible = True
            lblEmail2.Visible = True
            txtDireccion2.Visible = True
            txtTelefono2.Visible = True
            txtEmail2.Visible = True
        Else
            lblDireccion2.Visible = False
            lblTelefono2.Visible = False
            lblEmail2.Visible = False
            txtDireccion2.Visible = False
            txtTelefono2.Visible = False
            txtEmail2.Visible = False

        End If
    End Sub


    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Me.Close()

    End Sub

    Private Sub bntActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            If ValidarCampos() = True Then
                Dim flag1 As Boolean = True


                Dim datosProNew As New List(Of String)

                Try

                    datosProNew.Add(txtNombreProvee.Text)
                    datosProNew.Add(txtRfcProvee.Text)
                    datosProNew.Add(txtRazonSocialProvee.Text)
                    datosProNew.Add(cboOrigenCiudad.Text)

                    If chbActivo.Checked Then
                        datosProNew.Add("A")
                    Else
                        datosProNew.Add("I")
                    End If


                    datosProNew.Add(cboTipoPersonaPro.Text)



                    datosProNew.Add(txtAliasProvee.Text)

                    If rdbNoApliPro.Checked Then
                        datosProNew.Add("R")
                    ElseIf rdbMasculinoProvee.Checked Then
                        datosProNew.Add("M")
                    Else
                        datosProNew.Add("F")
                    End If

                    datosProNew.Add(txtDomicilioPro.Text)
                    datosProNew.Add(txtTelefonoPro.Text)
                    datosProNew.Add(txtEmailPro.Text)
                    If chbExtras.Checked Then
                        datosProNew.Add(txtTelefono2.Text)
                        datosProNew.Add(txtEmail2.Text)
                        datosProNew.Add(txtDireccion2.Text)
                    Else
                        datosProNew.Add("")
                        datosProNew.Add("")
                        datosProNew.Add("")
                    End If
                    'datosPro.Add(txtDireccion2.Text)
                    'datosPro.Add(txtTelefono2.Text)
                    'datosPro.Add(txtEmail2.Text)
                    datosProNew.Add(cboEstadoProvee.Text)
                    datosProNew.Add(txtMunicipioPro.Text)
                    datosProNew.Add(txtCodigoPostalPro.Text)


                Catch ex As Exception
                    'MsgBox(ex.Message + "1")
                    flag1 = False
                End Try

                If flag1 = True Then
                    MetProveedor.Actualizar_Proveedor(datosProNew)
                End If

            Else
                MsgBox(mensaje)
                CamposObligatorios()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Function ValidarCorreo(ByVal email As String) As Boolean
        Return Regex.IsMatch(email, "^[_a-zA-Z0-9]+(\._a-zA-Z0-9+)*@[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

    Private Function ValidarTel(ByVal tel As String) As Boolean
        Return Regex.IsMatch(tel, "\d{3}-\d{3}-\d{4}")
    End Function

    Private mensaje As String

    Private Function ValidarCampos()
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

        If cboTipoPersonaPro.Text = "Moral" And txtRfcProvee.Text.Length <> 12 Then
            MsgBox("El RFC de una persona Moral debe contener 12 Caracteres")
            flag = False
        ElseIf cboTipoPersonaPro.Text = "Física" And txtRfcProvee.Text.Length <> 13 Then
            MsgBox("El RFC de una persona Física debe contener 13 Caracteres")
            flag = False
        End If

        If Not txtTelefonoPro.Text = String.Empty Then
            Dim arrayTel() As Char = txtTelefonoPro.Text.ToCharArray
            If arrayTel(3).Equals("-"c) And arrayTel(7).Equals("-"c) And arrayTel.Length = 12 And ValidarTel(txtTelefonoPro.Text) Then
            Else
                MsgBox("El número telefono debe tener el siguiente formato 355-000-0000")
                flag = False
            End If
        End If

        If ValidarCorreo(txtEmailPro.Text) <> True Then
            MsgBox("El correo no es valido")
            flag = False
        End If


        mensaje = resultado
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
            txtRazonSocialProvee.Enabled = False
            txtRazonSocialProvee.Text = ""
            txtNombreProvee.Enabled = True
            rdbNoApliPro.Checked = True
            rdbNoApliPro.Enabled = False
            rdbFemeninoProvee.Enabled = True
            rdbMasculinoProvee.Checked = True
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim metPro As New MetodosProveedor
        Dim metConPro As New Consultar_Proveedores

        metPro.ConsultarPro()
        Consultar_Proveedores.Show()
        Me.Close()
    End Sub


    Private Sub txtCodigoPostalPro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoPostalPro.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) Then
        ElseIf Not Char.IsControl(e.KeyChar) Then
        Else
            MsgBox("Solo puedes ingresar números y no exeder de 5 dígitos")
        End If
    End Sub


    Private Sub txtTelefonoPro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefonoPro.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If IsNumeric(e.KeyChar) Then
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

            Dim tel As String = txtTelefonoPro.Text
            If tel.Length > 12 Then
                tel = tel.Remove(tel.Length - 1)
                txtTelefonoPro.Text = tel
                'MsgBox("Solo se permiten como maximo 13 caracteres")
            End If
            txtTelefonoPro.Text = txtTelefonoPro.Text.ToUpper
            txtTelefonoPro.SelectionStart = tel.Length
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTelefono2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono2.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If IsNumeric(e.KeyChar) Then
        ElseIf Char.IsControl(e.KeyChar) Then
        Else
            MsgBox("Solo puedes ingresar números y no exeder de 12 dígitos")
        End If
    End Sub

    Private Sub txtTelefono2_KeyUp(sender As Object, e As KeyEventArgs) Handles txtTelefono2.KeyUp
        Try
            If txtTelefono2.Text.Length = 3 Or txtTelefono2.Text.Length = 7 Then
                txtTelefono2.Text = txtTelefono2.Text + "-"
            End If

            Dim tel As String = txtTelefono2.Text
            If tel.Length > 12 Then
                tel = tel.Remove(tel.Length - 1)
                txtTelefono2.Text = tel
                'MsgBox("Solo se permiten como maximo 13 caracteres")
            End If
            txtTelefono2.Text = txtTelefono2.Text.ToUpper
            txtTelefono2.SelectionStart = tel.Length
        Catch ex As Exception

        End Try
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



    Private Sub ValidarLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtNombreProvee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreProvee.KeyPress
        ValidarLetras(e)
        txtNombreProvee.MaxLength = 80
    End Sub

    Private Sub txtAliasProvee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAliasProvee.KeyPress
        ValidarLetras(e)
        txtAliasProvee.MaxLength = 80
    End Sub


    Private Sub txtMunicipioPro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMunicipioPro.KeyPress
        ValidarLetras(e)
        txtAliasProvee.MaxLength = 80
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

































    'Public nombre, telefono, ciudad, email As String
    'Public mtdProveedor As New MetodosProveedor

    'Private Sub Actualizar_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs)
    '    Me.Close()
    'End Sub

    'Private Sub btnAceptarProvee_Click(sender As Object, e As EventArgs)
    '    Dim datosNuevos(4), datosViejos(4) As String
    '    Dim nombre As String
    '    nombre = txtNombrePro.Text
    '    datosNuevos(0) = txtTelefonoProvee.Text
    '    datosNuevos(1) = txtEmailProvee.Text
    '    datosNuevos(2) = cboCiudadProve.SelectedValue.ToString
    '    datosViejos(0) = telefono
    '    datosViejos(1) = email
    '    datosViejos(2) = ciudad
    '    mtdProveedor.SelecionarCiu(cboCiudadProve)
    '    mtdProveedor.modificar_Proveedor(datosViejos, datosNuevos, nombre)

    'End Sub

    'Private Sub Label5_Click_1(sender As Object, e As EventArgs)
    '    Me.Close()
    'End Sub


End Class