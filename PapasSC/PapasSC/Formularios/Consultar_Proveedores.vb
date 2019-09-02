Public Class Consultar_Proveedores
    Dim dv As New DataView
    Public datosProveedor(4) As String
    Public nombreV, telefonoV, emailV, ciudadV As String
    Public Sub ConsulProv()
        Dim fu As New MetodosProveedor
        DataListado.DataSource = fu.ConsultarPro
    End Sub

    Private Sub Consultar_Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsulProv()
    End Sub

    Private Sub BuscarProve_Click(sender As Object, e As EventArgs) Handles BuscarProve.Click
        Dim no As String = txtFiltro.Text
        Dim noCiu As String = txtFiltro.Text
        Dim fu As New MetodosProveedor
        ConsulProv()

        Try
            If txtFiltro.Text = "" Or txtFiltro.Text = Nothing Then
            ElseIf cboFiltroProve.SelectedIndex = 0 Then
                DataListado.DataSource = fu.BuscarProveedorNom(no)
            ElseIf cboFiltroProve.SelectedIndex = 1 Then
                DataListado.DataSource = fu.BuscarProveedorCiu(noCiu)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
        Dim no As String = txtFiltro.Text
        Dim noCiu As String = txtFiltro.Text
        Dim fu As New MetodosProveedor

        Try
            If cboFiltroProve.SelectedIndex = 0 Then
                DataListado.DataSource = fu.BuscarProveedorNom(no)
            ElseIf cboFiltroProve.SelectedIndex = 1 Then
                DataListado.DataSource = fu.BuscarProveedorCiu(noCiu)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Registrar_Proveedor.Show()
    End Sub

    Private Sub btnEliminarProvee_Click(sender As Object, e As EventArgs) Handles btnEliminarProvee.Click
        Dim fu As New MetodosProveedor
        Try
            If DataListado.CurrentRow IsNot Nothing Then
                Dim con As Int16 = 0
                For Each cell As DataGridViewCell In DataListado.CurrentRow.Cells
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

    Private Sub btnActualizarPro_Click(sender As Object, e As EventArgs) Handles btnActualizarPro.Click
        Try
            Dim nombre As String = Convert.ToString(DataListado.CurrentRow.Cells(0).Value)
            Dim tel As String = Convert.ToString(DataListado.CurrentRow.Cells(1).Value)
            Dim email As String = Convert.ToString(DataListado.CurrentRow.Cells(2).Value)
            Dim ciudad As String = Convert.ToString(DataListado.CurrentRow.Cells(3).Value)
            nombreV = nombre
            telefonoV = tel
            emailV = email
            ciudadV = ciudad
            Actualizar_Proveedor.txtNombrePro.Text = nombre
            Actualizar_Proveedor.txtTelefonoProvee.Text = tel
            Actualizar_Proveedor.txtEmailProvee.Text = email
            Actualizar_Proveedor.cboCiudadProve.Text = ciudad
            Actualizar_Proveedor.nombre = nombreV
            Actualizar_Proveedor.ciudad = ciudadV
            Actualizar_Proveedor.telefono = telefonoV
            Actualizar_Proveedor.email = emailV
            Actualizar_Proveedor.Show()

        Catch ex As Exception
            MsgBox("No seleccionaste un reglon")
        End Try
    End Sub
End Class