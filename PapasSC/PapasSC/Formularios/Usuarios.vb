Imports PapasSC.MetodosUsuarios
Public Class Usuarios
    Dim mtdUsuario As New MetodosUsuarios
    Dim w As Integer = 580
    Dim h As Integer = 308
    Dim flag As Int16 = 1
    Dim nombreUsuario, nombreEmpleado, tipoEmpleado, contrasenia, estatus As String

    Private Sub Perfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtdUsuario.cargarUsuarioCombo(cmbNombreUsuario)
        desactiarCampo()
        mtdUsuario.todosLosUsuarios(tblUsuarios)
        Me.Size = New Drawing.Size(w, h)
        Me.MaximizeBox = False
    End Sub

    Private Sub btnCargarDatos_Click(sender As Object, e As EventArgs) Handles btnCargarDatos.Click
        Try
            actiarCampo(1)
            mtdUsuario.cargarNombreEmpleadp(cmbEmpleado)
            mtdUsuario.cargarTiposUsuario(cmbTipoUsuario)
            Dim datos() As String = mtdUsuario.cargardatosUsuario(cmbNombreUsuario.Text)
            txtUsuario.Text = datos(1)
            txtContasenia.Text = datos(2)
            Dim tu As Integer = cmbTipoUsuario.FindString(datos(3))
            Dim em As Integer = cmbEmpleado.FindString(datos(4))
            cmbTipoUsuario.SelectedIndex = tu
            cmbEmpleado.SelectedIndex = em
            If datos(5).Equals("A") Then
                chbActivo.Checked = True
            Else
                chbActivo.Checked = False
            End If
            'cargo los datos que son para actualizar
            nombreUsuario = datos(1)
            contrasenia = datos(2)
            tipoEmpleado = datos(3)
            nombreEmpleado = datos(4)
            estatus = chbActivo.Checked
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
        actiarCampo(3)
        cmbNombreUsuario.Enabled = False
        btnCargarDatos.Enabled = False
        mtdUsuario.cargarNombreEmpleadp(cmbEmpleado)
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
                        If chbActivo.Checked Then
                            datos(4) = "A"
                        Else
                            datos(4) = "B"
                        End If

                        mtdUsuario.insertar(datos)
                        limpiarCampos()
                        tamanioNormal()
                    End If
                End If
            ElseIf flag = 2 Then
                If valoresObligatorios() And datosIguales() = True Then

                    If MessageBox.Show("Esta seguro de Modificar el usuario " + cmbNombreUsuario.Text, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = 1 Then
                        'estos son los datos nuevos
                        Dim datos(5) As String
                        datos(0) = txtUsuario.Text
                        datos(1) = txtContasenia.Text
                        datos(2) = cmbTipoUsuario.Text
                        datos(3) = cmbEmpleado.Text
                        If chbActivo.Checked Then
                            datos(4) = "A"
                        Else
                            datos(4) = "B"
                        End If
                        'estos son los datos viejos
                        Dim datosV(5) As String
                        datosV(0) = nombreUsuario
                        datosV(1) = contrasenia
                        datosV(2) = tipoEmpleado
                        datosV(3) = nombreEmpleado
                        If estatus = True Then
                            datosV(4) = "A"
                        Else
                            datosV(4) = "B"
                        End If
                        mtdUsuario.modificar(datos, datosV)
                        limpiarCampos()
                        tamanioNormal()
                    End If
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        tamanioNormal()
        limpiarCampos()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim busqueda As String = txtBusqueda.Text
            mtdUsuario.busquedaDeUsuarios(busqueda, tblUsuarios)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBusqueda.KeyDown
        Try
            Dim busqueda As String = txtBusqueda.Text
            mtdUsuario.busquedaDeUsuarios(busqueda, tblUsuarios)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        pnlDatosUsuario.Visible = True
        agrandarFrom()
        actiarCampo(2)
        mtdUsuario.cargarNombreEmpleadp(cmbEmpleado)
        flag = 2
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try

            Dim empleado, usuario As String
            usuario = tblUsuarios.CurrentRow.Cells(0).Value
            empleado = tblUsuarios.CurrentRow.Cells(3).Value
            If MessageBox.Show("Esta seguro de ELIMINAR el usuario: " + usuario + " que pertenece" + vbCrLf + "a al empleado: " + empleado, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = 1 Then
                mtdUsuario.eliminar(usuario, empleado)
            End If
        Catch ex As Exception

        End Try
    End Sub

    '##################################################################################################

    Private Function desactiarCampo() As Boolean
        pnlDatosUsuario.Visible = False
        txtContasenia.Enabled = False
        txtUsuario.Enabled = False
        cmbTipoUsuario.Enabled = False
        cmbEmpleado.Enabled = False
        Return True
    End Function

    Private Function actiarCampo(ByVal actionMoI As Int16) As Boolean
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
            If tblUsuarios.CurrentRow.Cells(4).Value = "Activo" Then
                chbActivo.Checked = True
            Else
                chbActivo.Checked = False
            End If
            Return True
        ElseIf actionMoI = 3 Then
            pnlDatosUsuario.Visible = True
            btnCargarDatos.Enabled = False
            cmbNombreUsuario.Enabled = False
            cmbTipoUsuario.Enabled = True
            cmbEmpleado.Enabled = True
            txtContasenia.Enabled = True
            txtUsuario.Enabled = True
            If tblUsuarios.CurrentRow.Cells(4).Value = "Activo" Then
                chbActivo.Checked = True
            Else
                chbActivo.Checked = False
            End If
            Return True
        End If
    End Function


    Private Function agrandarFrom() As Boolean
        Me.Size = New Drawing.Size(w, h + 164)
        Return True
    End Function

    Private Function tamanioNormal() As Boolean
        Me.Size = New Drawing.Size(w, h)
        Return True
    End Function

    Private Sub lblCerrar_Click(sender As Object, e As EventArgs) Handles lblCerrar.Click
        Me.Close()
    End Sub

    Private Sub chbActivo_CheckedChanged(sender As Object, e As EventArgs) Handles chbActivo.CheckedChanged
        'estatus = chbActivo.Checked
    End Sub

    Private Function valoresObligatorios() As Boolean
        If Me.ValidateChildren And txtUsuario.Text <> String.Empty And txtContasenia.Text <> String.Empty Then
            'MessageBox.Show("Datos registrados correctamente", "Varificacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Else
            MessageBox.Show("Exisiten datos obliglatorios", "Varificacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        AgregarEmpleados.Show()
    End Sub

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

    Private Function datosIguales() As Boolean
        Dim cont As Int16 = 0
        If txtUsuario.Text.Equals(nombreUsuario) Then
            cont += 1
        End If
        If txtContasenia.Text.Equals(contrasenia) Then
            cont += 1
        End If
        If cmbTipoUsuario.Text.Equals(tipoEmpleado) Then
            cont += 1
        End If
        If cmbEmpleado.Text.Equals(nombreEmpleado) Then
            cont += 1
        End If
        If chbActivo.Checked = estatus Then
            cont += 1
        End If
        If cont = 5 Then 'si la suma de todos los campos son iguales envia falso si no verdero
            MessageBox.Show("Los campos que ingresaste soy iguales. " + vbCrLf + "Debes cambiar los datos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True 'si por lo menos 1 valor es diferente entra aqui y retorna verdadero
        End If
    End Function

End Class