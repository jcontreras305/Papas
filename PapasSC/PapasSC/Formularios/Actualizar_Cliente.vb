Imports PapasSC.MetodosClientes
Imports PapasSC.MetodosCliente
Imports PapasSC.Consulta_Cliente
Imports System.Text.RegularExpressions

Public Class Actualizar_Cliente
    Public idCliente As String
    Private mtdCli As New MetodosClientes
    Private datosCli() As String
    Private Sub Actualizar_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl18.Visible = False
        lbl19.Visible = False
        lbl20.Visible = False
        lbl21.Visible = False
        lbl22.Visible = False
        lbl23.Visible = False

        rdbHombre.Checked = True
        datosCli = Consulta_Cliente.datosCliente
        idCliente = datosCli(0)
        Try
            'MsgBox(datosCli(1).ToString)
            txtNombre.Text = datosCli(1).ToString
        Catch ex As Exception
            txtNombre.Text = ""
        End Try
        Try
            'MsgBox(datosCli(3).ToString)
            txtRazonSocial.Text = datosCli(3).ToString
        Catch ex As Exception
            txtRazonSocial.Text = ""
        End Try
        txtrfc.Text = datosCli(2)
        cmbTipoPersona.Text = datosCli(5)
        If datosCli(6) = "A" Then
            chbActivo.Checked = True
        Else
            chbActivo.Checked = False
        End If
        If Not datosCli(7) = "" And Not datosCli(8) = "" Then
            txtLimiteCredito.Text = datosCli(7)
            txtSaldo.Text = datosCli(8)
            spnDiasCredito.Value = CInt(datosCli(9).ToString)
            chbActivarCredito.Checked = True
        Else
            txtLimiteCredito.Enabled = False
            txtSaldo.Enabled = False
            spnDiasCredito.Enabled = False
            chbActivarCredito.Checked = False

        End If

        spnDiasCredito.Value = CInt(datosCli(9).ToString)
        txtAlias.Text = datosCli(10)
        If datosCli(11).Equals("M") Then
            rdbHombre.Checked = True
        ElseIf datosCli(12).Equals("F") Then
            rdbMujer.Checked = True
        Else
            rdbRazonSocial.Checked = True
        End If
        txtDireccion.Text = datosCli(12)
        txtTelefono.Text = datosCli(13)
        txtEmail.Text = datosCli(14)
        'cmbEstado.Text = datosCli(14)
        cmbEstado.SelectedText = datosCli(15)
        txtMunicipio.Text = datosCli(16)
        txtCodigoPostal.Text = datosCli(17)
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
                    If chbActivo.Checked Then
                        datosActCli.Add("A")
                    Else
                        datosActCli.Add("I")
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

                    datosActCli.Add(CStr(cmbEstado.Text))
                    datosActCli.Add(txtMunicipio.Text)
                    datosActCli.Add(txtCodigoPostal.Text)

                    'datos de credito
                    If chbActivarCredito.Checked Then
                        If txtLimiteCredito.Text.Length > 0 And Not txtLimiteCredito.Text.Equals("") Then
                            Dim credito As Double = (CDbl(txtLimiteCredito.Text))
                            datosActCli.Add(txtLimiteCredito.Text) ' limite de credito
                            datosActCli.Add(CStr(spnDiasCredito.Value)) ' dias de credito
                        Else
                            datosActCli.Add("0")
                        End If
                    Else
                        datosActCli.Add("0")
                        datosActCli.Add("0")
                    End If
                Catch ex As Exception
                    'MsgBox(ex.Message + "1")
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

    Private Sub btnElminar_Click(sender As Object, e As EventArgs) Handles btnElminar.Click
        Try
            If txtNombre.Text.Length > 0 And Not txtNombre.Text.Trim = String.Empty Then
                mtdCli.eliminar_Cliente(idCliente, txtNombre.Text)
            Else
                mtdCli.eliminar_Cliente(idCliente, "")
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
        Else 'fisica
            txtRazonSocial.Enabled = False
            txtRazonSocial.Text = ""
            txtNombre.Enabled = True
            rdbRazonSocial.Checked = True
            rdbRazonSocial.Enabled = False
            rdbMujer.Enabled = True
            rdbHombre.Checked = True
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Dim mtdCliente As New MetodosCliente
        Dim mtdConsul As New Consulta_Cliente
        mtdCliente.llenarDatagridview(mtdConsul.TablaCLientes)
        Me.Close()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Close()
    End Sub

    Private Sub chbActivarCredito_CheckedChanged(sender As Object, e As EventArgs) Handles chbActivarCredito.CheckedChanged
        If chbActivarCredito.Checked = True Then
            txtSaldo.Enabled = True
            txtLimiteCredito.Enabled = True
            spnDiasCredito.Enabled = True
        Else
            txtSaldo.Enabled = False
            txtLimiteCredito.Enabled = False
            spnDiasCredito.Enabled = False
        End If
    End Sub


End Class