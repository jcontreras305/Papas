Imports PapasSC.MetodosUsuarios
Public Class Perfiles
    Dim mtdUsuario As New MetodosUsuarios
    Dim h As Integer = 580
    Dim w As Integer = 300

    Private Sub Perfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtdUsuario.cargarUsuarioCombo(cmbNombreUsuario)
        desactiarCampo()
        mtdUsuario.todosLosUsuarios(tblUsuarios)
        Me.Size = New Drawing.Size(h, w)
        lbl1.Visible = False
        lbl2.Visible = False
        lbl3.Visible = False
    End Sub

    Private Sub btnCargarDatos_Click(sender As Object, e As EventArgs) Handles btnCargarDatos.Click
        Try
            actiarCampo()
            mtdUsuario.cargarNombreEmpleadp(cmbEmpleado)
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
        actiarCampo()
        cmbNombreUsuario.Enabled = False
        btnCargarDatos.Enabled = False
        'chbActivo.value = 1
        mtdUsuario.cargarNombreEmpleadp(cmbEmpleado)
        cmbEmpleado.SelectedIndex = 0
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
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

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        tamanioNormal()
        limpiarCampos()
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

    Private Function actiarCampo() As Boolean
        pnlDatosUsuario.Visible = True
        txtContasenia.Enabled = True
        txtUsuario.Enabled = True
        cmbTipoUsuario.Enabled = True
        cmbEmpleado.Enabled = True
        Return True
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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim empleado, usuario As String
            usuario = tblUsuarios.CurrentRow.Cells(0).Value
            empleado = tblUsuarios.CurrentRow.Cells(3).Value
            mtdUsuario.eliminar(usuario, empleado)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtContasenia_TextChanged(sender As Object, e As EventArgs) Handles txtContasenia.TextChanged

    End Sub
End Class