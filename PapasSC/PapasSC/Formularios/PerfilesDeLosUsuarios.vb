Imports PapasSC.MetodosPerfiles
Public Class PerfilesDeLosUsuarios
    Dim mtdPerfiles As New MetodosPerfiles
    Dim tiposUsuario As New List(Of String)

    Private Sub lblCerrar_Click(sender As Object, e As EventArgs) Handles lblCerrar.Click
        Me.Close()
    End Sub

    Private Sub PerfilesDeLosUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mtdPerfiles.consulaPriVilegios(ltsAsignados)
            cmbTipoUsuario.Items.Clear()
            mtdPerfiles.consultaTipoUsuario(cmbTipoUsuario)
            For Each cmbItem In cmbTipoUsuario.Items
                tiposUsuario.Add(cmbItem)
            Next
            txtNombreNuevo.Visible = False
            btnSalirCancelar.Visible = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbTipoUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoUsuario.SelectedIndexChanged
        Try
            Dim tipoUsuario As String = cmbTipoUsuario.Text
            mtdPerfiles.consultaPrivlegioTipoUsuario(tipoUsuario, ltsAsignados, lstDisponibles)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If lstDisponibles.SelectedItems.Count > 0 Then
                Dim cont As Int16 = 0
                For Each item In lstDisponibles.SelectedItems
                    Dim aux As ListViewItem = lstDisponibles.SelectedItems(cont)
                    Dim dato As String = aux.Text
                    Dim nuevoItem As New ListViewItem(dato)
                    lstDisponibles.Items.Remove(item)
                    ltsAsignados.Items.Add(nuevoItem)
                Next
            Else
                MsgBox("No se selecciono ningun elemento")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgergarTodos_Click(sender As Object, e As EventArgs) Handles btnAgergarTodos.Click
        Try

            Dim cont As Int16 = 0
            For Each item In lstDisponibles.Items
                Dim aux As ListViewItem = lstDisponibles.Items(cont)
                Dim dato As String = aux.Text
                Dim nuevoItem As New ListViewItem(dato)
                lstDisponibles.Items.Remove(item)
                ltsAsignados.Items.Add(nuevoItem)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnQuitarTodos_Click(sender As Object, e As EventArgs) Handles btnQuitarTodos.Click
        Try
            Dim cont As Int16 = 0
            For Each item In ltsAsignados.Items
                Dim aux As ListViewItem = ltsAsignados.Items(cont)
                Dim dato As String = aux.Text
                Dim nuevoItem As New ListViewItem(dato)
                lstDisponibles.Items.Add(nuevoItem)
                ltsAsignados.Items.Remove(item)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Try
            If ltsAsignados.SelectedItems.Count > 0 Then
                Dim cont As Int16 = 0
                For Each item In ltsAsignados.SelectedItems
                    Dim aux As ListViewItem = ltsAsignados.SelectedItems(cont)
                    Dim dato As String = aux.Text
                    Dim nuevoItem As New ListViewItem(dato)
                    ltsAsignados.Items.Remove(item)
                    lstDisponibles.Items.Add(nuevoItem)
                Next
            Else
                MsgBox("No se selecciono ningun elemento")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Dim lista As New List(Of String)
            Dim tipoUsuario As String = ""
            Dim privilegiosAsignado As List(Of String) = mtdPerfiles.privilegiosAsinados
            Dim privilegiosSinAsignar As List(Of String) = mtdPerfiles.privilegiosSinAsignar

            If MessageBox.Show("Esta seguro de atualziar los privilegios del usuario", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = 1 Then
                tipoUsuario = cmbTipoUsuario.Text
                Dim flag As Boolean = True
                Dim cont As Int16 = 0
                For Each item In ltsAsignados.Items 'agrego todos los que esta en la lista de asignados
                    Dim aux As ListViewItem = ltsAsignados.Items(cont)
                    Dim nombre As String = aux.Text
                    lista.Add(nombre)
                    cont += 1
                Next

                For Each nodo In privilegiosAsignado
                    lista.Remove(nodo)
                Next

                tipoUsuario = cmbTipoUsuario.Text
                If lista.Count > 0 Then
                    For Each nodo In lista
                        Dim priv As String = nodo
                        mtdPerfiles.actualizarPrivilegio(priv, tipoUsuario) 'inserto la lista actualizada 
                    Next
                End If

                'aqui empiza la eliminacion de los privilegios 
                cont = 0
                lista.Clear()

                For Each item In lstDisponibles.Items 'tomo todos los privielgios que no son utiles
                    Dim aux As ListViewItem = lstDisponibles.Items(cont)
                    Dim nombre As String = aux.Text
                    lista.Add(nombre)
                    cont += 1
                Next

                For Each nodo In privilegiosSinAsignar 'elimino lo que no se modificaron
                    lista.Remove(nodo)
                Next

                If lista.Count > 0 Then
                    For Each nodo In lista  ' elimino los que se quitaron de la lista de asignados
                        Dim priv As String = nodo
                        mtdPerfiles.eliminarPrivilegio(priv, tipoUsuario)
                    Next
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            lstDisponibles.Clear()
            ltsAsignados.Clear()
            Dim lista As List(Of String) = mtdPerfiles.privilegiosAsinados
            For Each nodo In lista
                Dim item As New ListViewItem(nodo)
                ltsAsignados.Items.Add(item)
            Next

            lista.Clear()
            lista = mtdPerfiles.privilegiosSinAsignar
            For Each nodo In lista
                Dim item As New ListViewItem(nodo)
                lstDisponibles.Items.Add(nodo)
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNuevoGuardar_Click(sender As Object, e As EventArgs) Handles btnNuevoGuardar.Click
        Try
            If btnNuevoGuardar.Text = "Nuevo" Then
                btnSalirCancelar.Visible = True
                cmbTipoUsuario.Visible = False
                txtNombreNuevo.Visible = True
                btnNuevoGuardar.Text = "Guardar"
                txtNombreNuevo.Location = New Point(118, 37)
                lstDisponibles.Clear()
                ltsAsignados.Clear()
                For Each nodo In mtdPerfiles.privielgios
                    Dim item As New ListViewItem(nodo)
                    lstDisponibles.Items.Add(item)
                Next
                btnAceptar.Enabled = False
                btnCancelar.Enabled = False
            Else
                Dim flag As Boolean = True
                For Each tipo In tiposUsuario
                    If txtNombreNuevo.Text = tipo Then
                        flag = False
                    End If
                Next
                If flag Then

                    Dim datos As New List(Of String)
                    For Each item In ltsAsignados.Items
                        Dim aux As ListViewItem = item
                        Dim nombre As String = aux.Text
                        datos.Add(nombre)
                    Next
                    mtdPerfiles.insertarTipoUsuario(txtNombreNuevo.Text, datos)
                    btnNuevoGuardar.Text = "Nuevo"
                    cmbTipoUsuario.Visible = True
                    txtNombreNuevo.Visible = False
                    btnSalirCancelar.Visible = False
                    cmbTipoUsuario.Items.Clear()
                    mtdPerfiles.consultaTipoUsuario(cmbTipoUsuario)
                    cmbTipoUsuario.SelectedIndex = 0
                    mtdPerfiles.consultaPrivlegioTipoUsuario(cmbTipoUsuario.Text, ltsAsignados, lstDisponibles)
                    btnAceptar.Enabled = True
                    btnCancelar.Enabled = True
                Else
                    MsgBox("Ya existe un Tipo de usario con ese nombre")
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSalirCancelar_Click(sender As Object, e As EventArgs) Handles btnSalirCancelar.Click
        btnNuevoGuardar.Text = "Nuevo"
        cmbTipoUsuario.Visible = True
        txtNombreNuevo.Visible = False
        btnSalirCancelar.Visible = False
        cmbTipoUsuario.Items.Clear()
        mtdPerfiles.consultaTipoUsuario(cmbTipoUsuario)
        cmbTipoUsuario.SelectedIndex = 0
        mtdPerfiles.consultaPrivlegioTipoUsuario(cmbTipoUsuario.Text, ltsAsignados, lstDisponibles)
        btnAceptar.Enabled = True
        btnCancelar.Enabled = True
    End Sub
End Class