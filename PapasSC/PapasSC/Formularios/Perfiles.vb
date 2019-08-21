Imports PapasSC.MetodosUsuarios
Public Class Perfiles
    Dim mtdUsuario As New MetodosUsuarios
    Dim h As Integer = 580
    Dim w As Integer = 300
    Dim flag As Int16 = 0
    Dim nombreEmpleado, nombreUsuario, tipoUsuario, Contrasenia As String


    Private Sub Perfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtdUsuario.cargarUsuarioCombo(cmbNombreUsuario)
        desactiarCampo()
        mtdUsuario.todosLosUsuarios(tblUsuarios)
        Me.Size = New Drawing.Size(h, w)

    End Sub

    Private Sub btnCargarDatos_Click(sender As Object, e As EventArgs)
        Try
            activarCampo(2)
            mtdUsuario.cargarNombreEmpleado(cmbEmpleado)
            mtdUsuario.cargarTiposUsuario(cmbTipoUsuario)
            Dim datos() As String = mtdUsuario.cargardatosUsuario(cmbNombreUsuario.Text)
            txtUsuario.Text = datos(1)
            txtContasenia.Text = datos(2)
            Dim tu As Integer = cmbTipoUsuario.FindString(datos(3))
            Dim em As Integer = cmbEmpleado.FindString(datos(4))
            cmbTipoUsuario.SelectedIndex = tu
            cmbEmpleado.SelectedIndex = em
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tblUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblUsuarios.CellContentClick
        Try
            Dim usuario As String = Convert.ToString(tblUsuarios.CurrentRow.Cells(0).Value)
            Dim index As Int32 = cmbNombreUsuario.FindString(usuario)
            cmbNombreUsuario.SelectedIndex = index
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgragar_Click(sender As Object, e As EventArgs) Handles btnAgragar.Click
        pnlDatosUsuario.Visible = True
        agrandarFrom()
        activarCampo(1)
        cmbNombreUsuario.Enabled = False
        chbActivo.Checked = True
        mtdUsuario.cargarNombreEmpleado(cmbEmpleado)
        cmbEmpleado.SelectedIndex = 0
        flag = 1
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If flag = 1 Then
                If valoresObligatorios() Then
                    If MessageBox.Show("Esta seguro de agregar el usuario " + txtUsuario.Text, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = 1 Then
                        Dim datos(5) As String
                        datos(0) = txtUsuario.Text
                        datos(1) = txtContasenia.Text
                        datos(2) = cmbTipoUsuario.Text
                        datos(3) = cmbEmpleado.Text
                        mtdUsuario.insertar(datos)
                        limpiarCampos()
                    End If
                End If
            ElseIf flag = 2 Then
                If valoresObligatorios() Then
                    If MessageBox.Show("Esta seguro de realizar los cambios", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = 1 Then
                        Dim datos()
                    End If
                End If

            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        tamanioNormal()
        limpiarCampos()
        desactiarCampo()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim empleado, usuario As String
            usuario = tblUsuarios.CurrentRow.Cells(0).Value
            empleado = tblUsuarios.CurrentRow.Cells(3).Value
            mtdUsuario.eliminar(usuario, empleado)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            agrandarFrom()
            activarCampo(2)
            btnCargarDatos.Enabled = True
            cmbNombreUsuario.Enabled = True
            mtdUsuario.cargarUsuarioCombo(cmbNombreUsuario)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCargarDatos_Click_1(sender As Object, e As EventArgs) Handles btnCargarDatos.Click
        Try
            Dim datos(6) As String
            Dim cont As Int16 = 0
            For Each cell In tblUsuarios.CurrentRow.Cells
                datos(cont) = tblUsuarios.CurrentRow.Cells(cont).Value
                cont += 1
            Next
            agrandarFrom()
            activarCampo(3)
            'Campos
            mtdUsuario.cargarNombreEmpleado(cmbEmpleado)
            mtdUsuario.cargarTiposUsuario(cmbTipoUsuario)
            cmbNombreUsuario.SelectedIndex = cmbNombreUsuario.FindString(datos(0))
            txtUsuario.Text = datos(0)
            cmbEmpleado.SelectedIndex = cmbEmpleado.FindString(datos(3))
            txtContasenia.Text = datos(1)
            cmbTipoUsuario.SelectedIndex = cmbTipoUsuario.FindString(datos(2))
            'Variables
            nombreEmpleado = cmbEmpleado.Text
            nombreUsuario = txtUsuario.Text
            tipoUsuario = cmbTipoUsuario.Text
            Contrasenia = txtContasenia.Text
            flag = 2
        Catch ex As Exception

        End Try
    End Sub

    '##################################################################################################3

    Private Function desactiarCampo() As Boolean
        pnlDatosUsuario.Visible = False
        txtContasenia.Enabled = False
        txtUsuario.Enabled = False
        cmbTipoUsuario.Enabled = False
        cmbEmpleado.Enabled = False
        Return True
    End Function

    Private Function activarCampo(ByRef actionMoI As Int16) As Boolean
        If actionMoI = 1 Then
            pnlDatosUsuario.Visible = True
            txtContasenia.Enabled = True
            txtUsuario.Enabled = True
            cmbTipoUsuario.Enabled = True
            cmbEmpleado.Enabled = True
            chbActivo.Checked = True
            Return True
        ElseIf actionMoI = 2 Then
            pnlDatosUsuario.Visible = True
            btnCargarDatos.Enabled = True
            cmbNombreUsuario.Enabled = True
            cmbTipoUsuario.Enabled = False
            cmbEmpleado.Enabled = False
            txtContasenia.Enabled = False
            txtUsuario.Enabled = False
            chbActivo.Checked = False
            Return True
        ElseIf actionMoI = 3 Then
            pnlDatosUsuario.Visible = True
            btnCargarDatos.Enabled = False
            cmbNombreUsuario.Enabled = False
            cmbTipoUsuario.Enabled = True
            cmbEmpleado.Enabled = True
            txtContasenia.Enabled = True
            txtUsuario.Enabled = True
            chbActivo.Checked = True
            Return True
        End If

    End Function


    Private Function agrandarFrom() As Boolean
        Me.Size = New Drawing.Size(h, w + 160)
        Return True
    End Function

    Private Function tamanioNormal() As Boolean
        Me.Size = New Drawing.Size(h, w)
        Return True
    End Function

    Private Sub lblCerrar_Click(sender As Object, e As EventArgs) Handles lblCerrar.Click
        Me.Close()
    End Sub

    Private Function valoresObligatorios() As Boolean
        If Me.ValidateChildren And txtUsuario.Text <> String.Empty And txtContasenia.Text <> String.Empty Then
            MessageBox.Show("Datos registrados correctamente", "Varificacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Else
            MessageBox.Show("Exisiten datos obliglatorios", "Varificacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function



    Private Sub txtUsuario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtUsuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Es Necesario incluir un NOMBRE DE USUARIO")
        End If
    End Sub

    Private Sub txtContasenia_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtContasenia.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Es Necesario agregar una CONTRASEÑA")
        End If
    End Sub

    Private Function limpiarCampos() As Boolean
        txtUsuario.Clear()
        txtContasenia.Clear()
        cmbEmpleado.SelectedIndex = 0
        cmbNombreUsuario.SelectedIndex = 0
        cmbTipoUsuario.SelectedIndex = 0
        mtdUsuario.todosLosUsuarios(tblUsuarios)
        Return True
    End Function




End Class