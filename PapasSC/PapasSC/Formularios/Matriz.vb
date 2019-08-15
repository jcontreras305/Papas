Imports PapasSC.MetodosMatrizCiudad
Public Class Matriz
    Dim mtdMatCD As New MetodosMatrizCiudad
    Public datosMatriz(3) As String

    Private Sub Matriz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mtdMatCD.seleccionar_Matriz(tblMatriz)
            mtdMatCD.seleccionar_Ciudad(cmbCiudad)
            lbl1.Visible = False
            lbl2.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Close()
    End Sub

    Private Sub btnCiudad_Click(sender As Object, e As EventArgs) Handles btnCiudad.Click
        Dim nomCiudad As String = Nothing
        nomCiudad = InputBox("¿Cuál es el NOMBRE de la Ciudad?", "Agregar Ciudad",,,)
        If nomCiudad.Length <> 0 And Not nomCiudad.Trim = String.Empty Then
            If mtdMatCD.insertar_ciudad(nomCiudad) Then
                mtdMatCD.seleccionar_Ciudad(cmbCiudad)
            End If
        End If
    End Sub

    Private Sub btnGuardarMatriz_Click(sender As Object, e As EventArgs) Handles btnGuardarMatriz.Click
        If validarCampos() Then
            Try
                mtdMatCD.insertar_matriz(txtNombreMatriz.Text, txtCalveMatriz.Text, cmbCiudad.Text)
                mtdMatCD.seleccionar_Matriz(tblMatriz)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            lbl1.Visible = True
            lbl2.Visible = True
        End If
    End Sub

    Private Sub txtNombreMatriz_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNombreMatriz.KeyUp
        Try
            txtCalveMatriz.Text = txtNombreMatriz.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEliminarMatriz_Click(sender As Object, e As EventArgs) Handles btnEliminarMatriz.Click
        Try

            If tblMatriz.CurrentRow IsNot Nothing Then
                Dim cont As Int16 = 0
                For Each cell As DataGridViewCell In tblMatriz.CurrentRow.Cells
                    datosMatriz(cont) = cell.Value.ToString
                    cont += 1
                Next
                mtdMatCD.eliminar_matriz(datosMatriz)
            Else
                MsgBox("No se ha seleccionado una Matriz")
            End If

        Catch ex As Exception

        End Try
        mtdMatCD.seleccionar_Matriz(tblMatriz)
    End Sub

    Private Sub tblMatriz_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblMatriz.CellClick
        Try
            Dim cont As Int16 = 0
            For Each cell As DataGridViewCell In tblMatriz.CurrentRow.Cells
                datosMatriz(cont) = cell.Value.ToString
                cont += 1
            Next
            txtNombreMatriz.Text = datosMatriz(0)
            txtCalveMatriz.Text = datosMatriz(1)
            cmbCiudad.SelectedIndex = cmbCiudad.FindString(datosMatriz(2))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If validarCampos() Then
            Try
                Dim datosActMat(7) As String
                Dim cont As Integer = 0
                For Each cell As DataGridViewCell In tblMatriz.CurrentRow.Cells
                    datosActMat(cont) = cell.Value.ToString
                    cont += 1
                Next
                datosActMat(3) = txtNombreMatriz.Text
                datosActMat(4) = txtCalveMatriz.Text
                datosActMat(5) = cmbCiudad.SelectedValue.ToString
                mtdMatCD.actualizar_Matriz(datosActMat)
                mtdMatCD.seleccionar_Matriz(tblMatriz)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            lbl1.Visible = True
            lbl2.Visible = True
            lbl3.Visible = True
        End If
    End Sub

    Private Function validarCampos() As Boolean
        Dim flag As Boolean = False
        Try

            If txtNombreMatriz.Text.Length <> 0 And Not txtNombreMatriz.Text.Trim = String.Empty Then
                flag = True
                If txtCalveMatriz.Text.Length <> 0 And Not txtCalveMatriz.Text.Trim = String.Empty Then
                    flag = True
                    If cmbCiudad.Items.Count > 0 And cmbCiudad.Text <> Nothing Then
                        flag = True
                    Else
                        flag = False
                    End If
                Else
                    flag = False
                End If
            Else
                flag = False
            End If


        Catch ex As Exception
            flag = False
            MsgBox("Estos Campos son obligatorios")
        End Try
        Return flag
    End Function

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        Try
            mtdMatCD.seleccionar_Matriz(tblMatriz)
            mtdMatCD.seleccionar_Ciudad(cmbCiudad)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class