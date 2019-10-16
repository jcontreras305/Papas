Public Class BuscaCliente
    Public nombreCliente, idCliente As String

    Private Sub BuscaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim mtd As New MetodosCliente
            mtd.buscarCliente(tblCliente, "")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtBusqueda_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBusqueda.KeyUp
        Try
            Dim mtd As New MetodosCliente
            mtd.buscarCliente(tblCliente, txtBusqueda.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub tblCliente_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles tblCliente.CellMouseDoubleClick
        Try
            Dim nv As NuevaVenta = CType(Owner, NuevaVenta)
            nombreCliente = tblCliente.CurrentRow.Cells("Nombre").Value.ToString
            idCliente = tblCliente.CurrentRow.Cells("idCliente").Value.ToString
            nv.nombreCliente = nombreCliente
            nv.idCliente = idCliente
            nv.txtNombreCliente.Text = nombreCliente
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class