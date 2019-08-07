Imports PapasSC.MetodosClientes
Imports PapasSC.Consulta_Cliente
Imports System.Text.RegularExpressions

Public Class Actualizar_Cliente
    Public idCliente As String
    Private mtdCli As New MetodosClientes
    Private datosCli As New List(Of String)
    Private Sub Actualizar_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl18.Visible = False
        lbl19.Visible = False
        lbl20.Visible = False
        lbl21.Visible = False
        lbl22.Visible = False
        lbl23.Visible = False
        rdbHombre.Checked = True
        datosCli = Consulta_Cliente.datosCliente
        idCliente = datosCli.ElementAt(0)
        txtNombre.Text = datosCli.ElementAt(1)
        txtrfc.Text = datosCli.ElementAt(2)
        txtRazonSocial.Text = datosCli.ElementAt(3)
        cmbTipoPersona.Text = datosCli.ElementAt(5)
        txtLimiteCredito.Text = datosCli.ElementAt(7)
        spnDiasCredito.Value = CInt(datosCli.ElementAt(8).ToString)
        txtAlias.Text = datosCli.ElementAt(9)
        If datosCli.ElementAt(10).Equals("M") Then
            rdbHombre.Checked = True
        ElseIf datosCli.ElementAt(10).Equals("F") Then
            rdbMujer.Checked = True
        Else
            rdbRazonSocial.Checked = True
        End If
        txtDireccion.Text = datosCli.ElementAt(11)
        txtTelefono.Text = datosCli.ElementAt(12)
        txtEmail.Text = datosCli.ElementAt(13)
        cmbEstado.Text = datosCli.ElementAt(14)
        txtMunicipio.Text = datosCli.ElementAt(15)
        txtCodigoPostal.Text = datosCli.ElementAt(16)
    End Sub

    Private Sub bntActualizar_Click(sender As Object, e As EventArgs) Handles bntActualizar.Click
        Try
            Dim datosActCli As New List(Of String)
            If validar_camposNoNulos() = True Then
                Dim flag1 As Boolean = True
                Try
                    'id Cliente
                    datosActCli.Add(idCliente)
                    'datos de nombre o razon social
                    If Not cmbTipoPersona.SelectedItem = "Moral" Then
                        datosActCli.Add(txtNombre.Text) 'nombre persona fisica
                        If txtrfc.Text.Length > 0 And Not txtrfc.Text.Trim = String.Empty Then
                            datosActCli.Add(txtrfc.Text)
                        Else
                            datosActCli.Add("XAXX010101000") 'se le asigna la de publico general
                        End If
                        datosActCli.Add("") 'si es persona fisica no hay persona moral
                        datosActCli.Add("Fisica") 'se agrega el tipo de persona

                    ElseIf cmbTipoPersona.SelectedItem = "Moral" Then 'es lo contrario 
                        datosActCli.Add("") '
                        If txtrfc.Text.Length > 0 Or Not txtrfc.Text.Trim = String.Empty Then
                            datosActCli.Add(txtrfc.Text)

                        Else
                            datosActCli.Add("XAXX010101000")

                        End If
                        datosActCli.Add(txtRazonSocial.Text)
                        datosActCli.Add("Moral")

                    End If

                    'agregar de contacto 
                    datosActCli.Add(txtAlias.Text)
                    If rdbRazonSocial.Checked Then
                        datosActCli.Add("R")
                    ElseIf rdbHombre.Checked Then
                        datosActCli.Add("M")
                    Else
                        datosActCli.Add("F")
                    End If

                    datosActCli.Add(txtDireccion.Text)
                    datosActCli.Add(txtTelefono.Text)
                    datosActCli.Add(txtEmail.Text)
                    datosActCli.Add(CStr(cmbEstado.SelectedItem.ToString()))
                    datosActCli.Add(txtMunicipio.Text)
                    datosActCli.Add(txtCodigoPostal.Text)

                    'datos de credito
                    If txtLimiteCredito.Text.Length > 0 And Not txtLimiteCredito.Text.Equals("") Then
                        Dim credito As Double = (CDbl(txtLimiteCredito.Text))
                        datosActCli.Add(txtLimiteCredito.Text) ' limite de credito
                        datosActCli.Add(CStr(spnDiasCredito.Value)) ' dias de credito
                    Else
                        datosActCli.Add("10000")

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message + "1")
                    flag1 = False
                End Try

                If flag1 = True Then
                    mtdCli.actualizar_cliente(datosActCli)
                End If
            Else
                MsgBox(mensaje)
                activarSenialCamposObligatorios()
            End If

        Catch ex As Exception

        End Try
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
End Class