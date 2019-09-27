
Public Class Precios_por_defecto

    Public metPre As New Metodos_PreciosXdefecto
    Private datosPre(5) As String


    Public ver As String
    Public cla As String

    Private Sub Precios_por_defecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultaPrecios()


    End Sub

    Public Sub consultaPrecios()
        Dim precio As New Metodos_PreciosXdefecto
        tblPreciosDefecto.DataSource = precio.Consultar_Precios
    End Sub

    Private Sub btnBuscarPrecios_Click(sender As Object, e As EventArgs) Handles btnBuscarPrecios.Click
        Dim nom As String = txtPrecios.Text
        Dim cla As String = txtPrecios.Text
        Dim pre As New Metodos_PreciosXdefecto

        consultaPrecios()

        If txtPrecios.Text = "" Or txtPrecios.Text = Nothing Then
        ElseIf cboPrecios.SelectedIndex = 0 Then
            tblPreciosDefecto.DataSource = pre.Buscar_Precios(nom)
        ElseIf cboPrecios.SelectedIndex = 1 Then
            tblPreciosDefecto.DataSource = pre.Buscar_PreciosCla(cla)
        End If

    End Sub



    Private Sub txtPrecios_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecios.KeyDown
        Dim nom As String = txtPrecios.Text
        Dim cla As String = txtPrecios.Text
        Dim pre As New Metodos_PreciosXdefecto

        consultaPrecios()

        If txtPrecios.Text = "" Or txtPrecios.Text = Nothing Then
        ElseIf cboPrecios.SelectedIndex = 0 Then
            tblPreciosDefecto.DataSource = pre.Buscar_Precios(nom)
        ElseIf cboPrecios.SelectedIndex = 1 Then
            tblPreciosDefecto.DataSource = pre.Buscar_PreciosCla(cla)
        End If
    End Sub

    Private Sub tblPreciosDefecto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblPreciosDefecto.CellContentClick

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub btnModificarPrecio_Click(sender As Object, e As EventArgs) Handles btnModificarPrecio.Click
        Try
            Dim datosNew(5) As String

            datosNew(0) = ver
            datosNew(1) = cla
            datosNew(2) = txtPrecio.Text

            If MessageBox.Show("¿Desea Actualizar precio de Producto?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                metPre.ActualizarPrecio(datosNew)
                consultaPrecios()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub tblPreciosDefecto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblPreciosDefecto.CellClick
        Try
            Dim cont As Int16 = 0
            For Each cell As DataGridViewCell In tblPreciosDefecto.CurrentRow.Cells
                datosPre(cont) = cell.Value.ToString
                cont += 1
            Next
            ver = datosPre(0)
            cla = datosPre(1)
            txtPrecio.Text = datosPre(2)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub ValidarNumeros2(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If

    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        ValidarNumeros2(e)
        txtPrecio.MaxLength = 4

    End Sub
End Class