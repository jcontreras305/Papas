Public Class Reubicacion
    Dim mdt As New MetodosReubicacion
    Dim nombreBodega1, nombreBodega2, producto1, producto2 As String
    Dim datosRow1(3), datosRow2(3) As String
    Public usuario As String
    Dim cantidad1, cantidad2 As Double
    Dim verde, amarillo As Integer
    Dim tablaReubicaciones As New DataTable

    Private Sub Transpasos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mdt.llenarComboBodega(cmbBodega1)
        'mdt.llenarComboBodega(cmbBodega2)
        tablaReubicaciones.Columns.Add("Producto")
        tablaReubicaciones.Columns.Add("Descripcion")
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
        actualizarTablas()
        sprKg1.Increment = 0.5
        sprKg1.DecimalPlaces = 2
        sprKg1.ThousandsSeparator = False

        sprKg2.Increment = 0.5
        sprKg2.DecimalPlaces = 2
        sprKg2.ThousandsSeparator = False

        verde = 100
        amarillo = 50

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

    Private Sub btnTraspasoDer_Click(sender As Object, e As EventArgs) Handles btnTraspasoDer.Click
        Try
            If CDbl(sprKg1.Value) > cantidad1 Then
                MsgBox("No puede mover esta cantidad ya que exede las existencias del invetario")
            ElseIf cmbConsultaBodega1.Text.Equals(cmbConsultaBodega2.Text) Then
                MsgBox("No puede hacer la un movimiento de este tipo a la misma Bodega")
            Else
                'If MessageBox.Show("¿Desea enviar " + CStr(sprKg1.Value) + " Kg de la bodega " + nombreBodega1 + " a la bodega " + nombreBodega2 + "? ", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = 1 Then
                If validarCampos(1, datosRow1(1)) Then

                    Dim cont As Int16 = 0
                    Dim flag1 As Boolean = True
                    For Each row As DataGridViewRow In tblExistenciaBodega2.Rows
                        If row.Cells(0).Value.Equals(cmbproducto1.Text) Then
                            tblExistenciaBodega2.Rows(cont).Cells(1).Value = CStr(CDbl(row.Cells(1).Value) + CDbl(sprKg1.Value))
                            tblExisitenciaBodega1.Rows(cont).Cells(1).Value = CStr(CDbl(row.Cells(1).Value) - CDbl(sprKg1.Value))
                            flag1 = False ' si no entra entonces no existe el producto en la otra bodega. 
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
                        renglon("Descripcion") = txtDescripcion.Text
                        renglon("Bodega1") = cmbConsultaBodega1.Text
                        renglon("Bodega2") = cmbConsultaBodega2.Text
                        renglon("Usuario") = usuario
                        renglon("Cantidad") = CStr(sprKg1.Value)
                    End If

                    'Dim datos(5) As String
                    'datos(0) = cmbproducto1.Text
                    'datos(1) = txtDescripcion.Text
                    'datos(2) = cmbConsultaBodega1.Text
                    'datos(3) = cmbConsultaBodega2.Text
                    'datos(4) = usuario
                    'datos(5) = CStr(sprKg1.Value)
                    'mdt.insertar_reubicacion(datos)
                End If
                    'End If
                End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'actualizarTablas()
        'sprKg2.Value = 0
        'sprKg1.Value = 0
    End Sub

    Private Sub btnTraspasoIzq_Click(sender As Object, e As EventArgs) Handles btnTraspasoIzq.Click
        Try
            If CDbl(sprKg2.Value) > cantidad2 Then
                MsgBox("No puede mover esta cantidad ya que exede las existencias del invetario")
            ElseIf cmbConsultaBodega1.Text.Equals(cmbConsultaBodega2.Text) Then
                MsgBox("No puede hacer la un movimiento de este tipo a la misma Bodega")
            Else
                'If MessageBox.Show("¿Desea enviar " + CStr(sprKg2.Value) + " Kg de la bodega " + nombreBodega2 + " a la bodega " + nombreBodega1 + "? ", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = 1 Then
                If validarCampos(2, datosRow2(1)) Then
                    Dim cont As Int16 = 0
                    Dim flag2 As Boolean = True
                    For Each row As DataGridViewRow In tblExisitenciaBodega1.Rows
                        If row.Cells(0).Value.Equals(cmbproducto2.Text) Then
                            tblExisitenciaBodega1.Rows(cont).Cells(1).Value = CStr(CDbl(row.Cells(1).Value) + CDbl(sprKg2.Value))
                            tblExistenciaBodega2.Rows(cont).Cells(1).Value = CStr(CDbl(row.Cells(1).Value) - CDbl(sprKg2.Value))
                            flag2 = False ' si no entra entonces no existe el producto en la otra bodega. 
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
                        renglon("Descripcion") = txtDescripcion.Text
                        renglon("Bodega1") = cmbConsultaBodega2.Text
                        renglon("Bodega2") = cmbConsultaBodega1.Text
                        renglon("Usuario") = usuario
                        renglon("Cantidad") = CStr(sprKg2.Value)
                    End If

                    'datos(0) = cmbproducto2.Text
                    'datos(1) = txtDescripcion.Text
                    'datos(2) = cmbConsultaBodega2.Text
                    'datos(3) = cmbConsultaBodega1.Text
                    'datos(4) = usuario
                    'datos(5) = CStr(sprKg2.Value)
                    'mdt.insertar_reubicacion(datos)
                End If
                'End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        actualizarTablas()
        'sprKg1.Value = 0
        'sprKg2.Value = 0
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
                MsgBox("Por favor describa la razón de hacer la reubicación")
            End If
            Return flag
        Catch ex As Exception
            Return False
            MsgBox("Ha ocurrido un error al intenar leer los datos que ingresaste")
        End Try
    End Function

    Private Function actualizarTablas() As Boolean




        'llenarTabla(tblExisitenciaBodega1, nombreBodega1)
        'Dim cont As Int16 = tblExisitenciaBodega1.Rows.Count
        'Dim row As DataGridViewRow = tblExisitenciaBodega1.Rows(cont - 1)
        'tblExisitenciaBodega1.Rows.Remove(row)
        'llenarTabla(tblExistenciaBodega2, nombreBodega2)
        'cont = tblExistenciaBodega2.Rows.Count
        'row = tblExistenciaBodega2.Rows(cont - 1)
        'tblExistenciaBodega2.Rows.Remove(row)
        Return True
    End Function

End Class