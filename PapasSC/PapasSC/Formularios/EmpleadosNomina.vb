Public Class EmpleadosNomina

    Dim metNomi As New MetodoNomina
    Private dv As New DataView



    Private Sub EmpleadosNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mos As New MetodoNomina
        tblEmpleados.DataSource = mos.ConsultarEmpleados
    End Sub

    Private Sub txtBusNombre_TextChanged(sender As Object, e As EventArgs) Handles txtBusNombre.TextChanged
        If metNomi.BuscarNombre(txtBusNombre.Text).rows.count > 0 Then
            tblEmpleados.DataSource = metNomi.BuscarNombre(txtBusNombre.Text)
        End If
    End Sub



    Private Sub tblEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblEmpleados.CellClick
        Dim data(1) As String
        Try
            Dim cont As Int16 = 0
            For Each cell As DataGridViewCell In tblEmpleados.CurrentRow.Cells
                data(cont) = cell.Value.ToString
                cont += 1
            Next

            GenerarNomina.txtNombre.Text = data(0)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)


        End Try
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Close()
    End Sub
End Class