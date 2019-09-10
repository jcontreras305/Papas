Public Class Reubicacion
    Dim mdt As New MetodosReubicacion
    Dim nombreBodega1, nombreBodega2, producto1, producto2 As String
    Dim datosRow1(3), datosRow2(3) As String

    Private Sub Transpasos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mdt.llenarComboBodega(cmbBodega1)
        'mdt.llenarComboBodega(cmbBodega2)


        mdt.llenarComboBodega(cmbConsultaBodega1)
        mdt.llenarComboBodega(cmbConsultaBodega2)
        nombreBodega1 = cmbConsultaBodega1.Text
        nombreBodega2 = cmbConsultaBodega2.Text

        mdt.llenarComboproductos(cmbproducto1, nombreBodega1)
        mdt.llenarComboproductos(cmbproducto2, nombreBodega2)

        llenarTabla(tblExisitenciaBodega1, nombreBodega1)
        llenarTabla(tblExistenciaBodega2, nombreBodega2)
        sprKg1.Increment = 0.1
        sprKg1.DecimalPlaces = 2
        sprKg1.ThousandsSeparator = True

        sprKg2.Increment = 0.1
        sprKg2.DecimalPlaces = 2
        sprKg2.ThousandsSeparator = True
    End Sub

    Private Sub cmbConsultaBodega1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbConsultaBodega1.SelectionChangeCommitted
        tblExisitenciaBodega1.SelectAll()
        tblExisitenciaBodega1.ClearSelection()
        nombreBodega1 = cmbConsultaBodega1.Text
        mdt.llenarComboproductos(cmbproducto1, nombreBodega1)
        llenarTabla(tblExisitenciaBodega1, nombreBodega1)
    End Sub

    Private Sub cmbConsultaBodega2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbConsultaBodega2.SelectedIndexChanged
        tblExistenciaBodega2.SelectAll()
        tblExistenciaBodega2.ClearSelection()
        nombreBodega2 = cmbConsultaBodega2.Text
        mdt.llenarComboproductos(cmbproducto2, nombreBodega2)
        llenarTabla(tblExistenciaBodega2, nombreBodega2)
    End Sub

    Private Sub cmbproducto1_Enter(sender As Object, e As EventArgs) Handles cmbproducto1.Enter
        mdt.llenarComboproductos(cmbproducto1, cmbConsultaBodega1.Text)
    End Sub



    Private Sub cmbproducto2_Enter(sender As Object, e As EventArgs) Handles cmbproducto2.Enter
        mdt.llenarComboproductos(cmbproducto2, cmbConsultaBodega2.Text)
    End Sub



    Private Function llenarTabla(nombreTabla As DataGridView, nombreBodega As String) As Boolean
        Try
            mdt.llenarTabla(nombreTabla, nombreBodega)
            coloreasFilas(nombreTabla)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function



    Private Function coloreasFilas(ByVal tabla As DataGridView) As Boolean
        Try
            Dim cont As Int16 = 0
            For Each row As DataGridViewRow In tabla.Rows

                Dim dato As Integer = CInt(row.Cells(1).Value)
                If dato < 50 Then
                    row.DefaultCellStyle.BackColor = Color.Red
                ElseIf dato >= 50 And dato < 100 Then
                    row.DefaultCellStyle.BackColor = Color.Orange
                Else
                    row.DefaultCellStyle.BackColor = Color.Green
                End If
                cont += 1
            Next
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub tblExisitenciaBodega1_DoubleClick(sender As Object, e As EventArgs) Handles tblExisitenciaBodega1.DoubleClick
        Try

            Dim cont As Int16 = 0
            For Each item As DataGridViewCell In tblExisitenciaBodega1.SelectedCells
                datosRow1(cont) = item.Value
                cont += 1
            Next
            cmbproducto1.Text = ""
            cmbproducto1.SelectedText = datosRow1(0)
            sprKg1.Value = datosRow1(1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tblExistenciaBodega2_DoubleClick(sender As Object, e As EventArgs) Handles tblExistenciaBodega2.DoubleClick
        Try

            Dim cont As Int16 = 0
            For Each item As DataGridViewCell In tblExistenciaBodega2.SelectedCells
                datosRow2(cont) = item.Value
                cont += 1
            Next
            cmbproducto2.Text = ""
            cmbproducto2.SelectedText = datosRow2(0)
            sprKg2.Value = datosRow2(1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnTraspasoIzq_Click(sender As Object, e As EventArgs) Handles btnTraspasoIzq.Click
        Try
            If MessageBox.Show("¿Desea enviar " + sprKg2.Value + " de la bodega " + nombreBodega2 + " a la bodega " + nombreBodega1 + "? ", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = 1 Then
                If validarCampos(2, datosRow2(1)) Then
                    Dim datos(5) As String
                    datos(0) = nombreBodega2
                    datos(1) = nombreBodega1
                    datos(2) = cmbproducto2.Text
                    datos(3) = CStr(sprKg2.Value)
                    datos(4) = lblNombreUsuario.Text
                Else

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function validarCampos(lado As Int16, maximo As Integer) As Boolean
        Try
            Dim flag As Boolean = True
            If lado = 1 Then
                If sprKg1.Value = 0 Or sprKg1.Value > maximo Then
                    flag = False
                End If
            ElseIf lado = 2 Then
                If sprKg2.Value = 0 Or sprKg2.Value > maximo Then
                    flag = False
                End If
            End If

            If txtDescripcion.Text = String.Empty Then
                flag = False
            End If
            Return flag
        Catch ex As Exception
            Return False
            MsgBox("Ha ocurrido un error al intenar leer los datos que ingrsaste")
        End Try
    End Function
End Class