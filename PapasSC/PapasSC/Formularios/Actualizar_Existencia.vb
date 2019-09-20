Public Class Actualizar_Existencia
    Dim mtbo As New MetodoExistenciaProducto
    Public claveb As String
    Public clavep As String
    Public kac As String
    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        mtbo.updatebodega(cmbBodega.Text, cmbProducto.Text, lbltotal.Text, claveb, clavep)
    End Sub

    Private Sub Actualizar_Existencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kgUpDown.Increment = 0.01
        kgUpDown.DecimalPlaces = 2
        kgUpDown.ThousandsSeparator = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        kgUpDown.Increment = 0.01
        kgUpDown.DecimalPlaces = 2
        kgUpDown.ThousandsSeparator = True
        tblpesoarpilla.Rows.Add(Convert.ToDouble(kgUpDown.Value))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
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
            Dim totalKilos As Double = 0
            totalKilos = npd.Value * Alturacamasarpilla.Value
            media = ((npd.Value + recorrer) - 2) * media
            media = media * totalKilos
            lbltotal.Text = media
            media = 0
        End If


    End Sub



    Private Sub cmbBodega_MouseEnter(sender As Object, e As EventArgs) Handles cmbBodega.Enter
        mtbo.llenarComboBodega(cmbBodega)
    End Sub

    Private Sub cmbBodega_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbBodega.SelectionChangeCommitted
    End Sub

    'Private Sub cmbProducto_SelectionChangeCommitted_1(sender As Object, e As EventArgs) Handles cmbProducto.SelectionChangeCommitted
    '    kgUpDown.Value = Convert.ToDouble(mtbo.cantidadkgProductos(cmbProducto.SelectedText, cmbBodega.Text))
    'End Sub


    Dim flags As Boolean = True
    Private Sub cmbProducto_enter(sender As Object, e As EventArgs) Handles cmbProducto.Enter
        If flags Then
            mtbo.llenarComboProducto(cmbProducto, cmbBodega.Text)
            flags = False
        End If

    End Sub

    Private Sub cmbProducto_TextChanged(sender As Object, e As EventArgs) Handles cmbProducto.SelectedIndexChanged

        If flags = False Then
            kgUpDown.Value = mtbo.cantidadkgProductos(cmbProducto.Text, cmbBodega.Text)
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        kgUpDown.Increment = 0.01
        kgUpDown.DecimalPlaces = 2
        kgUpDown.ThousandsSeparator = True
        tblpesoarpilla.Rows.Add(Convert.ToDouble(kgUpDown.Value))
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
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
            Dim totalKilos As Double = 0
            totalKilos = npd.Value * Alturacamasarpilla.Value
            media = media * totalKilos
            lbltotal.Text = media
            media = 0
        End If
    End Sub

    Private Sub cmbBodega_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBodega.SelectedIndexChanged
        mtbo.llenarComboProducto(cmbProducto, cmbBodega.Text)
    End Sub
End Class