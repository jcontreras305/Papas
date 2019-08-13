Imports PapasSC.MetodosCliente
Public Class Consulta_Cliente
    Public datosCliente(17) As String

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim MTCLI As New MetodosCliente

        If TextBox1.Text = "" Or TextBox1.Text = Nothing Then
            MTCLI.llenarDatagridview(TablaCLientes)
            TablaCLientes.ReadOnly = True
        ElseIf FiltroClientes.SelectedIndex = 0 Then
            MTCLI.llenarDatagridview_filtro(TablaCLientes, TextBox1.Text)
        ElseIf FiltroClientes.SelectedIndex = 1 Then
            MTCLI.llenarDatagridview_filtroTipo(TablaCLientes, TextBox1.Text)
        ElseIf FiltroClientes.SelectedIndex = 2 Then
            MTCLI.llenarDatagridview_filtroRazonSocial(TablaCLientes, TextBox1.Text)
        ElseIf FiltroClientes.SelectedIndex = 3 Then
            MTCLI.llenarDatagridview_filtroalias(TablaCLientes, TextBox1.Text)
        ElseIf FiltroClientes.SelectedIndex = 4 Then
            MTCLI.llenarDatagridview_filtroRFC(TablaCLientes, TextBox1.Text)
        ElseIf FiltroClientes.SelectedIndex = 5 Then
            MTCLI.llenarDatagridview_filtroLimiteCredito(TablaCLientes, TextBox1.Text)
        ElseIf FiltroClientes.SelectedIndex = 6 Then
            MTCLI.llenarDatagridview_filtroDiasCredito(TablaCLientes, TextBox1.Text)
        ElseIf FiltroClientes.SelectedIndex = 7 Then
            MTCLI.llenarDatagridview_filtroID(TablaCLientes, TextBox1.Text)

        End If


    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress



    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Dim MTCLI As New MetodosCliente
        TablaCLientes.ReadOnly = True
        Try
            If FiltroClientes.SelectedIndex = 0 Then
                MTCLI.llenarDatagridview_filtro(TablaCLientes, TextBox1.Text)
            ElseIf FiltroClientes.SelectedIndex = 1 Then
                MTCLI.llenarDatagridview_filtroTipo(TablaCLientes, TextBox1.Text)
            ElseIf FiltroClientes.SelectedIndex = 2 Then
                MTCLI.llenarDatagridview_filtroRazonSocial(TablaCLientes, TextBox1.Text)
            ElseIf FiltroClientes.SelectedIndex = 3 Then
                MTCLI.llenarDatagridview_filtroalias(TablaCLientes, TextBox1.Text)
            ElseIf FiltroClientes.SelectedIndex = 4 Then
                MTCLI.llenarDatagridview_filtroRFC(TablaCLientes, TextBox1.Text)
            ElseIf FiltroClientes.SelectedIndex = 5 Then
                MTCLI.llenarDatagridview_filtroLimiteCredito(TablaCLientes, TextBox1.Text)
            ElseIf FiltroClientes.SelectedIndex = 6 Then
                MTCLI.llenarDatagridview_filtroDiasCredito(TablaCLientes, TextBox1.Text)
            ElseIf FiltroClientes.SelectedIndex = 7 Then
                MTCLI.llenarDatagridview_filtroID(TablaCLientes, TextBox1.Text)

            End If

        Catch

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Registro_Clientes.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If TablaCLientes.CurrentRow IsNot Nothing Then
                Dim cont As Int16 = 0
                For Each cell As DataGridViewCell In TablaCLientes.CurrentRow.Cells
                    datosCliente(cont) = cell.Value.ToString
                    cont += 1
                    MsgBox("contador " + cont)
                Next
            Else
                MsgBox("No se ha seleccionado un cliente")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If Convert.ToString(TablaCLientes.CurrentRow.Cells(5).Value) = "Fisica" Then
            Actualizar_Cliente.txtNombre.Text = Convert.ToString(TablaCLientes.CurrentRow.Cells(1).Value)
        End If
        Actualizar_Cliente.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim nombre As String = Convert.ToString(TablaCLientes.CurrentRow.Cells(1).Value)
        Dim id As String = Convert.ToString(TablaCLientes.CurrentRow.Cells(0).Value)
        Dim MTCLI As New MetodosCliente

        If MessageBox.Show("¿Desea ELIMINAR Cliente", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            MTCLI.eliminaCliente(id, nombre)
            MessageBox.Show(nombre)
        End If



    End Sub

    Private Sub Consulta_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MTCLI As New MetodosCliente
        MTCLI.llenarDatagridview(TablaCLientes)
        TablaCLientes.ReadOnly = True
    End Sub

    Private Sub TablaCLientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaCLientes.CellClick
        If TablaCLientes.CurrentRow IsNot Nothing Then
            Dim c As Integer = 0
            For Each cell As DataGridViewCell In TablaCLientes.CurrentRow.Cells
                datosCliente(c) = cell.Value.ToString
                c += 1
            Next
        Else
            MsgBox("No se ha seleccionado un cliente")
        End If
    End Sub
End Class