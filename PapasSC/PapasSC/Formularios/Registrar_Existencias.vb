Public Class Registrar_Existencias
    Dim mtde As New MetodoExistenciaProducto
    Dim media As Double = 0
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBodega.SelectedIndexChanged

    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        mtde.insertarExitemcia(cmbBodega.Text, cmbProducto.Text, lbltotal.Text)
    End Sub

    Private Sub Registrar_Existencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtde.llenarComboBodega(cmbBodega)
        mtde.llenarComboProducto(cmbProducto)
        kgUpDown.Increment = 0.01
        kgUpDown.DecimalPlaces = 2
        kgUpDown.ThousandsSeparator = True
    End Sub

    Private Sub npd_ValueChanged(sender As Object, e As EventArgs) Handles npd.ValueChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

    Private Sub cmbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProducto.SelectedIndexChanged

    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblpesoarpilla.CellContentClick

    End Sub
    Dim cont As Int64 = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tblpesoarpilla.Rows.Add(kgUpDown.Value)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim recorrer As Double = 0
        Dim media As Double = 0
        Dim suma As Double = 0
        MsgBox(tblpesoarpilla.RowCount)
        For recorrer = 1 To tblpesoarpilla.RowCount
            suma = Convert.ToDecimal(tblpesoarpilla.Rows(recorrer - 1).Cells(0).Value)
            media += suma
        Next
        media = media / ((recorrer) - 2)
        MsgBox("media entra" + media.ToString)
        If npd.Value.ToString = "0" Then
            lbltotal.Text = media * (recorrer - 2)
            media = 0
        Else

            MsgBox("valor defecto" + ((recorrer + npd.Value) - 2).ToString)

            media = ((npd.Value + recorrer) - 2) * media
            lbltotal.Text = media
            media = 0
        End If
    End Sub
End Class