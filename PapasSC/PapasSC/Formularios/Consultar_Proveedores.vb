Public Class Consultar_Proveedores
    Dim dv As New DataView
    Public datosProveedor(20) As String


    Public Sub ConsulProv()
        Dim fu As New MetodosProveedor
        tblProveedores.DataSource = fu.ConsultarPro
    End Sub

    Public Sub ConsulProvTodos()
        Dim fu As New MetodosProveedor
        tblProveedores.DataSource = fu.ConsultarProTodos
    End Sub



    Private Sub Consultar_Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsulProv()
    End Sub

    Private Sub BuscarProve_Click(sender As Object, e As EventArgs) Handles BuscarProve.Click
        Dim no As String = txtFiltro.Text
        Dim noCiu As String = txtFiltro.Text
        Dim tipo As String = txtFiltro.Text
        Dim razon As String = txtFiltro.Text
        Dim ali As String = txtFiltro.Text
        Dim rfc As String = txtFiltro.Text

        Dim fu As New MetodosProveedor
        ConsulProv()

        Try
            If txtFiltro.Text = "" Or txtFiltro.Text = Nothing Then
            ElseIf cboFiltroProve.SelectedIndex = 0 Then
                tblProveedores.DataSource = fu.BuscarProveedorNom(no)
            ElseIf cboFiltroProve.SelectedIndex = 1 Then
                tblProveedores.DataSource = fu.BuscarTipoPersona(tipo)
            ElseIf cboFiltroProve.SelectedIndex = 2 Then
                tblProveedores.DataSource = fu.BuscarRazon(razon)
            ElseIf cboFiltroProve.SelectedIndex = 3 Then
                tblProveedores.DataSource = fu.AliasPro(ali)
            ElseIf cboFiltroProve.SelectedIndex = 4 Then
                tblProveedores.DataSource = fu.BuscarRfcPro(rfc)
            ElseIf cboFiltroProve.SelectedIndex = 5 Then
                tblProveedores.DataSource = fu.BuscarProveedorCiu(noCiu)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
        Dim no As String = txtFiltro.Text
        Dim noCiu As String = txtFiltro.Text
        Dim tipo As String = txtFiltro.Text
        Dim razon As String = txtFiltro.Text
        Dim ali As String = txtFiltro.Text
        Dim rfc As String = txtFiltro.Text

        Dim fu As New MetodosProveedor
        ConsulProv()

        Try
            If txtFiltro.Text = "" Or txtFiltro.Text = Nothing Then
            ElseIf cboFiltroProve.SelectedIndex = 0 Then
                tblProveedores.DataSource = fu.BuscarProveedorNom(no)
            ElseIf cboFiltroProve.SelectedIndex = 1 Then
                tblProveedores.DataSource = fu.BuscarTipoPersona(tipo)
            ElseIf cboFiltroProve.SelectedIndex = 2 Then
                tblProveedores.DataSource = fu.BuscarRazon(razon)
            ElseIf cboFiltroProve.SelectedIndex = 3 Then
                tblProveedores.DataSource = fu.AliasPro(ali)
            ElseIf cboFiltroProve.SelectedIndex = 4 Then
                tblProveedores.DataSource = fu.BuscarRfcPro(rfc)
            ElseIf cboFiltroProve.SelectedIndex = 5 Then
                tblProveedores.DataSource = fu.BuscarProveedorCiu(noCiu)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnActualizarPro_Click(sender As Object, e As EventArgs) Handles btnActualizarPro.Click
        Try
            If tblProveedores.CurrentRow IsNot Nothing Then
                Dim cont As Int16 = 0
                For Each cell As DataGridViewCell In tblProveedores.CurrentRow.Cells
                    datosProveedor(cont) = cell.Value.ToString
                    cont += 1
                Next
            Else
                MsgBox("No se ha seleccionado un proveedor")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Actualizar_Proveedor.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Registrar_Proveedor.Show()
    End Sub

    Private Sub tblProveedores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblProveedores.CellClick
        If tblProveedores.CurrentRow IsNot Nothing Then
            Dim p As Integer = 0
            For Each cell As DataGridViewCell In tblProveedores.CurrentRow.Cells
                datosProveedor(p) = CStr(cell.Value.ToString)
                p += 1
            Next
        Else
            MsgBox("No se ha seleccionado un proveedor")
        End If
    End Sub

    Private Sub btnEliminarProvee_Click(sender As Object, e As EventArgs) Handles btnEliminarProvee.Click
        Dim fu As New MetodosProveedor
        Try
            If tblProveedores.CurrentRow IsNot Nothing Then
                Dim con As Int16 = 0
                For Each cell As DataGridViewCell In tblProveedores.CurrentRow.Cells
                    datosProveedor(con) = cell.Value.ToString
                    con += 1
                Next
                fu.EliminarProveedor(datosProveedor)
            Else
                MsgBox("No se ha seleccionado el proveedor")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub chbMostrarTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chbMostrarTodos.CheckedChanged
        If chbMostrarTodos.Checked Then
            ConsulProvTodos()
        Else
            ConsulProv()
        End If
    End Sub



    'Private Sub btnActualizarPro_Click(sender As Object, e As EventArgs) Handles btnActualizarPro.Click
    '    Try
    '        Dim nombre As String = Convert.ToString(DataListado.CurrentRow.Cells(0).Value)
    '        Dim tel As String = Convert.ToString(DataListado.CurrentRow.Cells(1).Value)
    '        Dim email As String = Convert.ToString(DataListado.CurrentRow.Cells(2).Value)
    '        Dim ciudad As String = Convert.ToString(DataListado.CurrentRow.Cells(3).Value)
    '        nombreV = nombre
    '        telefonoV = tel
    '        emailV = email
    '        ciudadV = ciudad
    '        Actualizar_Proveedor.txtNombrePro.Text = nombre
    '        Actualizar_Proveedor.txtTelefonoProvee.Text = tel
    '        Actualizar_Proveedor.txtEmailProvee.Text = email
    '        Actualizar_Proveedor.cboCiudadProve.Text = ciudad
    '        Actualizar_Proveedor.nombre = nombreV
    '        Actualizar_Proveedor.ciudad = ciudadV
    '        Actualizar_Proveedor.telefono = telefonoV
    '        Actualizar_Proveedor.email = emailV
    '        Actualizar_Proveedor.Show()

    '    Catch ex As Exception
    '        MsgBox("No seleccionaste un reglon")
    '    End Try
    'End Sub
End Class