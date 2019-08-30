Public Class ConsultarEmpleado
    Dim dv As New DataView
    Public datosEmple(8) As String
    Public nombreV, sexoV, salarioV, telV, direccionV, BodegaV, horarioV, PuestoV As String

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
                    datosEmple(con) = cell.Value.ToString
                    con += 1
                Next
                eliEm.EliminarEmple(datosEmple)
            Else
                MsgBox("No se ha seleccionado un empleado")
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnActualizarEmple_Click(sender As Object, e As EventArgs) Handles btnActualizarEmple.Click
        Try

            Dim nombre As String = Convert.ToString(tblEmple.CurrentRow.Cells(0).Value)
            Dim sexo As String = Convert.ToString(tblEmple.CurrentRow.Cells(1).Value)
            Dim sala As String = Convert.ToString(tblEmple.CurrentRow.Cells(2).Value)
            Dim tel As String = Convert.ToString(tblEmple.CurrentRow.Cells(3).Value)
            Dim dire As String = Convert.ToString(tblEmple.CurrentRow.Cells(4).Value)
            Dim bodega As String = Convert.ToString(tblEmple.CurrentRow.Cells(5).Value)
            Dim horario As String = Convert.ToString(tblEmple.CurrentRow.Cells(6).Value)
            Dim puesto As String = Convert.ToString(tblEmple.CurrentRow.Cells(7).Value)
            nombreV = nombre
            sexoV = sexo
            salarioV = sala
            telV = tel
            direccionV = dire
            BodegaV = bodega
            horarioV = horario
            PuestoV = puesto

            ActualizarEmpleados.txtEmNombre.Text = nombre
            If ActualizarEmpleados.rbuEmFemenino.Equals(sexo) = True Then
                ActualizarEmpleados.rbuEmFemenino.Select()
            ElseIf ActualizarEmpleados.rbuEmMasculino.Equals(sexo) = True Then
                ActualizarEmpleados.rbuEmMasculino.Select()
            End If
            ActualizarEmpleados.txtEmSalario.Text = sala
            ActualizarEmpleados.txtEmTelefono.Text = tel
            ActualizarEmpleados.txtEmDireccion.Text = dire
            ActualizarEmpleados.cboEmBodega.Text = bodega
            ActualizarEmpleados.cboEmHorario.Text = horario
            ActualizarEmpleados.cboEmPuesto.Text = puesto
            ActualizarEmpleados.nombre = nombreV
            ActualizarEmpleados.sexo = sexoV
            ActualizarEmpleados.sala = salarioV
            ActualizarEmpleados.telefono = telV
            ActualizarEmpleados.dire = direccionV
            ActualizarEmpleados.bodega = BodegaV
            ActualizarEmpleados.horario = horarioV
            ActualizarEmpleados.puesto = PuestoV
            ActualizarEmpleados.Show()

        Catch ex As Exception
            MsgBox("No seleccionaste un reglon")
        End Try

    End Sub
End Class