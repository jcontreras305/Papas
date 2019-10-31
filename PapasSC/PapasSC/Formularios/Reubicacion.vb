Public Class Reubicacion
    Dim mdt As New MetodosReubicacion
    Dim nombreBodega1, nombreBodega2, producto1, producto2 As String
    Dim datosRow1(3), datosRow2(3) As String
    Dim w As Integer = 740
    Dim h As Integer = 500
    Public usuario As String
    Dim cantidad1, cantidad2 As Double
    Dim verde, amarillo As Integer
    Dim flagsalir As Boolean = False

    Dim tablaReubicaciones As New DataTable

    Private Sub Transpasos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tablaReubicaciones.Columns.Add("Producto")
        tablaReubicaciones.Columns.Add("Bodega1")
        tablaReubicaciones.Columns.Add("Bodega2")
        tablaReubicaciones.Columns.Add("Usuario")
        tablaReubicaciones.Columns.Add("Cantidad")

        mdt.llenarComboBodega(cmbConsultaBodega1)
        mdt.llenarComboBodega(cmbConsultaBodega2)

        nombreBodega1 = cmbConsultaBodega1.Text
        nombreBodega2 = cmbConsultaBodega2.Text

        mdt.llenarComboproductos(cmbproducto1, nombreBodega1)
        mdt.llenarComboproductos(cmbproducto2, nombreBodega2)

        llenarTabla(tblExisitenciaBodega1, nombreBodega1)
        llenarTabla(tblExistenciaBodega2, nombreBodega2)

        sprKg1.Increment = 0.5
        sprKg1.DecimalPlaces = 2
        sprKg1.ThousandsSeparator = False

        sprKg2.Increment = 0.5
        sprKg2.DecimalPlaces = 2
        sprKg2.ThousandsSeparator = False

        verde = 100
        amarillo = 50

        Me.Size = New Drawing.Size(w, h)

    End Sub

    Private Sub cmbConsultaBodega1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbConsultaBodega1.SelectedIndexChanged
        tblExisitenciaBodega1.SelectAll()
        tblExisitenciaBodega1.ClearSelection()
        nombreBodega1 = cmbConsultaBodega1.Text
        If Not nombreBodega1.Equals("System.Data.DataRowView") Then
            mdt.llenarComboproductos(cmbproducto1, nombreBodega1)
            llenarTabla(tblExisitenciaBodega1, nombreBodega1)
        End If
    End Sub

    Private Sub cmbConsultaBodega2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbConsultaBodega2.SelectedIndexChanged
        tblExistenciaBodega2.SelectAll()
        tblExistenciaBodega2.ClearSelection()
        nombreBodega2 = cmbConsultaBodega2.Text
        If Not nombreBodega2.Equals("System.Data.DataRowView") Then
            mdt.llenarComboproductos(cmbproducto2, nombreBodega2)
            llenarTabla(tblExistenciaBodega2, nombreBodega2)
        End If
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
            colorearFilas(nombreTabla)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function colorearFilas(ByVal tabla As DataGridView) As Boolean
        Try
            Dim cont As Int16 = 0
            For Each row As DataGridViewRow In tabla.Rows

                Dim dato As Integer = CInt(row.Cells(1).Value)
                If dato < amarillo Then
                    row.DefaultCellStyle.BackColor = Color.Red
                ElseIf dato >= amarillo And dato < verde Then
                    row.DefaultCellStyle.BackColor = Color.Orange
                ElseIf dato >= verde Then
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
            sprKg1.Maximum = datosRow1(1)
            sprKg1.Value = datosRow1(1)
            cantidad1 = CDbl(datosRow1(1))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tblExistenciaBodega2_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles tblExistenciaBodega2.ColumnHeaderMouseClick
        Try
            colorearFilas(tblExistenciaBodega2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tblExisitenciaBodega1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles tblExisitenciaBodega1.ColumnHeaderMouseClick
        Try
            colorearFilas(tblExisitenciaBodega1)
        Catch ex As Exception

        End Try
    End Sub



    Private Sub sprAmarillo_ValueChanged(sender As Object, e As EventArgs) Handles sprAmarillo.ValueChanged
        If sprVerde.Value <= sprAmarillo.Value Then
            sprVerde.Value = sprAmarillo.Value + 1
            verde = sprVerde.Value
            amarillo = sprAmarillo.Value
        Else
            amarillo = sprAmarillo.Value
        End If
        If tblExisitenciaBodega1.Rows.Count > 0 And tblExistenciaBodega2.Rows.Count > 0 Then
            colorearFilas(tblExisitenciaBodega1)
            colorearFilas(tblExistenciaBodega2)
        End If
    End Sub

    Private Sub sprVerde_ValueChanged(sender As Object, e As EventArgs) Handles sprVerde.ValueChanged
        If sprVerde.Value <= sprAmarillo.Value Then
            sprAmarillo.Value = sprVerde.Value - 1
            verde = sprVerde.Value
            amarillo = sprAmarillo.Value
        Else
            verde = sprVerde.Value
        End If
        If tblExisitenciaBodega1.Rows.Count > 0 And tblExistenciaBodega2.Rows.Count > 0 Then
            colorearFilas(tblExisitenciaBodega1)
            colorearFilas(tblExistenciaBodega2)
        End If
    End Sub

    Private Sub cmbproducto2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbproducto2.SelectedIndexChanged
        Try
            Dim nombreProducto As String = cmbproducto2.Text
            Dim cantidad As String = "0"
            For Each fila As DataGridViewRow In tblExistenciaBodega2.Rows
                If fila.Cells(0).Value = nombreProducto Then
                    cantidad = fila.Cells(1).Value
                    Exit For
                End If
            Next
            sprKg2.Maximum = cantidad
            sprKg2.Value = cantidad
            cantidad2 = cantidad
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub cmbproducto1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbproducto1.SelectedIndexChanged
        Try
            Dim nombreProducto As String = cmbproducto1.Text
            Dim cantidad As String = "0"
            For Each fila As DataGridViewRow In tblExisitenciaBodega1.Rows
                If fila.Cells(0).Value = nombreProducto Then
                    cantidad = fila.Cells(1).Value
                    Exit For
                End If
            Next

            sprKg1.Maximum = cantidad
            sprKg1.Value = cantidad
            cantidad1 = cantidad
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
            sprKg2.Maximum = datosRow2(1)
            sprKg2.Value = datosRow2(1)
            cantidad2 = CDbl(datosRow2(1))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chbVerCambios_CheckedChanged(sender As Object, e As EventArgs) Handles chbVerCambios.CheckedChanged
        If chbVerCambios.Checked = True Then
            unirDatatableYDatagrid()
            agrandarFrom()
        Else
            tamanioNormal()
        End If
    End Sub

    Private Function unirDatatableYDatagrid() As Boolean
        Try
            tblListaCambios.Rows.Clear()
            For Each row As DataRow In tablaReubicaciones.Rows
                tblListaCambios.Rows.Add(row.Item(0).ToString, row.Item(1).ToString, row.Item(2).ToString, row.Item(4).ToString)
            Next
        Catch ex As Exception

        End Try
        Return Nothing
    End Function

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Try
            For Each row As DataGridViewRow In tblListaCambios.Rows
                Dim index As Int32 = row.Index
                If Convert.ToBoolean(row.Cells("Eliminar").Value) = True Then
                    Dim cantidad As Double = Convert.ToDouble(row.Cells("Kilogramos").Value)
                    Dim bodega1 As String = row.Cells("Envia").Value
                    Dim bodega2 As String = row.Cells("Recibe").Value
                    Dim producto As String = row.Cells("Producto").Value
                    If bodega1.Equals(cmbConsultaBodega1.Text) Then
                        If regresarValores(cantidad, tblExisitenciaBodega1, tblExistenciaBodega2, producto) Then
                            tblListaCambios.Rows.Remove(row)
                            tablaReubicaciones.Rows.RemoveAt(index)
                        End If
                    Else
                        If regresarValores(cantidad, tblExistenciaBodega2, tblExisitenciaBodega1, producto) Then
                            tblListaCambios.Rows.Remove(row)
                            tablaReubicaciones.Rows.RemoveAt(index)
                        End If
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Function regresarValores(ByVal cantidad As Double, ByVal bodega1 As DataGridView, ByVal bodega2 As DataGridView, ByVal producto As String) As Boolean
        Try
            Dim cont As Int16 = 0
            Dim flag As Boolean = False
            For Each row As DataGridViewRow In bodega1.Rows
                If row.Cells("version").Value.Equals(producto) Then
                    bodega1.Rows(cont).Cells("cantidad").Value = CStr(CDbl(bodega1.Rows(cont).Cells("cantidad").Value) + cantidad)
                    flag = True
                    Exit For
                Else
                    cont += 1
                End If
            Next
            If flag Then
                cont = 0
                For Each row As DataGridViewRow In bodega2.Rows
                    If row.Cells("version").Value.Equals(producto) Then
                        bodega2.Rows(cont).Cells("cantidad").Value = CStr(CDbl(bodega2.Rows(cont).Cells("cantidad").Value) - cantidad)
                        flag = True
                        Exit For
                    Else
                        cont += 1
                    End If
                Next
            End If
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Try
            If MessageBox.Show("Se borraran todos los cambios hechos." + vbCrLf + "¿Desea continuar?", "Adventencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                For Each row As DataGridViewRow In tblListaCambios.Rows
                    Dim index As Int32 = row.Index
                    Dim cantidad As Double = Convert.ToDouble(row.Cells("Kilogramos").Value)
                    Dim bodega1 As String = row.Cells("Envia").Value
                    Dim bodega2 As String = row.Cells("Recibe").Value
                    Dim producto As String = row.Cells("Producto").Value
                    If bodega1.Equals(cmbConsultaBodega1.Text) Then
                        If regresarValores(cantidad, tblExisitenciaBodega1, tblExistenciaBodega2, producto) Then

                        End If
                    Else
                        If regresarValores(cantidad, tblExistenciaBodega2, tblExisitenciaBodega1, producto) Then

                        End If
                    End If
                Next
                tblListaCambios.Rows.Clear()
                tablaReubicaciones.Rows.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function agrandarFrom() As Boolean
        Me.Size = New Drawing.Size(w, h + 164)
        Return True
    End Function



    Private Function tamanioNormal() As Boolean
        Me.Size = New Drawing.Size(w, h)
        Return True
    End Function

    Private Sub btnTraspasoDer_Click(sender As Object, e As EventArgs) Handles btnTraspasoDer.Click
        Try
            If CDbl(sprKg1.Value) > cantidad1 Then
                MsgBox("No puede mover esta cantidad ya que exede las existencias del invetario")
            ElseIf cmbConsultaBodega1.Text.Equals(cmbConsultaBodega2.Text) Then
                MsgBox("No puede hacer la un movimiento de este tipo a la misma Bodega")
            Else
                If cmbConsultaBodega1.Enabled = True Or cmbConsultaBodega2.Enabled = True Then
                    cmbConsultaBodega1.Enabled = False
                    cmbConsultaBodega2.Enabled = False
                End If
                If validarCampos(1, sprKg1.Maximum) Then
                    Dim cont As Int16 = 0
                    Dim flag1 As Boolean = True
                    For Each row As DataGridViewRow In tblExistenciaBodega2.Rows
                        If row.Cells(0).Value.Equals(cmbproducto1.Text) Then
                            tblExistenciaBodega2.Rows(cont).Cells(1).Value = CStr(CDbl(row.Cells(1).Value) + CDbl(sprKg1.Value))
                            cont = 0
                            For Each row1 As DataGridViewRow In tblExisitenciaBodega1.Rows
                                If row1.Cells(0).Value.Equals(cmbproducto1.Text) Then
                                    tblExisitenciaBodega1.Rows(cont).Cells(1).Value = CStr(CDbl(row1.Cells(1).Value) - CDbl(sprKg1.Value))
                                    flag1 = False ' si no entra entonces no existe el producto en la otra bodega. 
                                    Exit For
                                Else
                                    cont += 1
                                End If
                            Next
                            Exit For
                        Else
                            cont += 1
                        End If
                    Next

                    If flag1 Then ' NO se encontro el producto la en la tabla 2
                        MsgBox("No existe el producto en la Bodega " + cmbConsultaBodega2.Text + ", debe ser agregado entes.")
                    Else ' si entro solo se agrega a la tabla de cambios
                        Dim renglon As DataRow = tablaReubicaciones.NewRow()
                        renglon("Producto") = cmbproducto1.Text
                        'renglon("Descripcion") = txtDescripcion.Text
                        renglon("Bodega1") = cmbConsultaBodega1.Text
                        renglon("Bodega2") = cmbConsultaBodega2.Text
                        renglon("Usuario") = usuario
                        renglon("Cantidad") = CStr(sprKg1.Value)
                        tablaReubicaciones.Rows.Add(renglon)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        unirDatatableYDatagrid()
    End Sub

    Private Sub btnTraspasoIzq_Click(sender As Object, e As EventArgs) Handles btnTraspasoIzq.Click
        Try
            If CDbl(sprKg2.Value) > cantidad2 Then
                MsgBox("No puede mover esta cantidad ya que exede las existencias del invetario")
            ElseIf cmbConsultaBodega1.Text.Equals(cmbConsultaBodega2.Text) Then
                MsgBox("No puede hacer la un movimiento de este tipo a la misma Bodega")
            Else
                'If MessageBox.Show("¿Desea enviar " + CStr(sprKg2.Value) + " Kg de la bodega " + nombreBodega2 + " a la bodega " + nombreBodega1 + "? ", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = 1 Then
                If cmbConsultaBodega1.Enabled = True Or cmbConsultaBodega2.Enabled = True Then
                    cmbConsultaBodega1.Enabled = False
                    cmbConsultaBodega2.Enabled = False
                End If
                If validarCampos(2, sprKg2.Maximum) Then
                    Dim cont As Int16 = 0
                    Dim flag2 As Boolean = True
                    For Each row As DataGridViewRow In tblExisitenciaBodega1.Rows
                        If row.Cells(0).Value.Equals(cmbproducto2.Text) Then
                            tblExisitenciaBodega1.Rows(cont).Cells(1).Value = CStr(CDbl(row.Cells(1).Value) + CDbl(sprKg2.Value))
                            cont = 0
                            For Each row1 As DataGridViewRow In tblExistenciaBodega2.Rows
                                If row1.Cells(0).Value.Equals(cmbproducto2.Text) Then
                                    tblExistenciaBodega2.Rows(cont).Cells(1).Value = CStr(CDbl(row1.Cells(1).Value) - CDbl(sprKg2.Value))
                                    flag2 = False ' si no entra entonces no existe el producto en la otra bodega. 
                                    Exit For
                                Else
                                    cont += 1
                                End If
                            Next
                            Exit For
                        Else
                            cont += 1
                        End If
                    Next
                    If flag2 Then ' NO se encontro el producto la en la tabla 1
                        MsgBox("No existe el producto en la Bodega " + cmbConsultaBodega1.Text + ", debe ser agregado entes.")
                    Else ' si entro solo se agrega a la tabla de cambios
                        Dim renglon As DataRow = tablaReubicaciones.NewRow()
                        renglon("Producto") = cmbproducto2.Text
                        'renglon("Descripcion") = txtDescripcion.Text
                        renglon("Bodega1") = cmbConsultaBodega2.Text
                        renglon("Bodega2") = cmbConsultaBodega1.Text
                        renglon("Usuario") = usuario
                        renglon("Cantidad") = CStr(sprKg2.Value)
                        tablaReubicaciones.Rows.Add(renglon)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        unirDatatableYDatagrid()
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
            Return flag
        Catch ex As Exception
            Return False
            MsgBox("Ha ocurrido un error al intenar leer los datos que ingresaste")
        End Try
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If txtDescripcion.Text = String.Empty Then
                MsgBox("Por favor describa la razón de hacer la reubicación")
            Else
                Dim idReubicacion As String = mdt.insertar_reubicacion(tablaReubicaciones, txtDescripcion.Text)
                If Not idReubicacion.Equals(Nothing) Then
                    Dim reportReubicacion As New verReporteReubicacion
                    reportReubicacion.idReubicacion = idReubicacion
                    reportReubicacion.ShowDialog()
                    flagsalir = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If flagsalir = False Then
            If MessageBox.Show("Si desea continuar, se perderan los cambios realizados.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                Me.Close()
            End If
        Else

        End If
    End Sub
End Class