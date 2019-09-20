Public Class ConsultarEmpleado
    Dim dv As New DataView
    Public datosEm(10) As String


    Public Sub Consul()
        Dim fun As New MetodosEmpleado
        tblEmple.DataSource = fun.Consultar
    End Sub

    Private Sub ConsultarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tblEmple.ReadOnly = True
        Consul()
    End Sub

    Private Sub btnNombreE_Click(sender As Object, e As EventArgs) Handles btnNombreE.Click
        Dim no As String = txtNombreEm.Text
        Dim bo As String = txtNombreEm.Text
        Dim pu As String = txtNombreEm.Text
        Dim sa As String = txtNombreEm.Text
        Dim fu As New MetodosEmpleado
        Consul()

        If txtNombreEm.Text = "" Or txtNombreEm.Text = Nothing Then
        ElseIf filtro.SelectedIndex = 0 Then
            tblEmple.DataSource = fu.BuscarEm(no)
        ElseIf filtro.SelectedIndex = 1 Then
            tblEmple.DataSource = fu.BuscarEmBo(bo)
        ElseIf filtro.SelectedIndex = 2 Then
            tblEmple.DataSource = fu.BuscarEmPu(pu)
        ElseIf filtro.SelectedIndex = 3 Then
            tblEmple.DataSource = fu.BuscarEmSa(sa)
        End If
    End Sub



    Private Sub txtNombreEm_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombreEm.KeyDown
        Dim no As String = txtNombreEm.Text
        Dim bo As String = txtNombreEm.Text
        Dim pu As String = txtNombreEm.Text
        Dim sa As String = txtNombreEm.Text
        Dim fu As New MetodosEmpleado

        Try
            If filtro.SelectedIndex = 0 Then
                tblEmple.DataSource = fu.BuscarEm(no)
            ElseIf filtro.SelectedIndex = 1 Then
                tblEmple.DataSource = fu.BuscarEmBo(bo)
            ElseIf filtro.SelectedIndex = 2 Then
                tblEmple.DataSource = fu.BuscarEmPu(pu)
            ElseIf filtro.SelectedIndex = 3 Then
                tblEmple.DataSource = fu.BuscarEmSa(sa)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub btnEliminarEm_Click(sender As Object, e As EventArgs) Handles btnEliminarEm.Click
        Dim eliEm As New MetodosEmpleado

        Try
            If tblEmple.CurrentRow IsNot Nothing Then
                Dim con As Int16 = 0
                For Each cell As DataGridViewCell In tblEmple.CurrentRow.Cells
                    datosEm(con) = cell.Value.ToString
                    con += 1
                Next
                eliEm.EliminarEmple(datosEm)
            Else
                MsgBox("No se ha seleccionado un empleado")
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnActualizarEmple_Click(sender As Object, e As EventArgs) Handles btnActualizarEmple.Click
        Try
            If tblEmple.CurrentRow IsNot Nothing Then
                Dim cont As Int16 = 0
                For Each cell As DataGridViewCell In tblEmple.CurrentRow.Cells
                    datosEm(cont) = cell.Value.ToString
                    cont += 1
                Next
            Else
                MsgBox("No se ha seleccionado un proveedor")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ActualizarEmpleados.Show()
    End Sub

    Private Sub tblEmple_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblEmple.CellClick
        If tblEmple.CurrentRow IsNot Nothing Then
            Dim p As Integer = 0
            For Each cell As DataGridViewCell In tblEmple.CurrentRow.Cells
                datosEm(p) = CStr(cell.Value.ToString)
                p += 1
            Next
        Else
            MsgBox("No se ha seleccionado un proveedor")
        End If
    End Sub
End Class