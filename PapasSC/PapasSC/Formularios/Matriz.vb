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

    Private Sub btnGuardarCiudad_Click(sender As Object, e As EventArgs) Handles btnGuardarCiudad.Click
        Try
            mtdMatCD.insertar_matriz(txtNombreMatriz.Text, txtCalveMatriz.Text, cmbCiudad.Text)
            mtdMatCD.seleccionar_Matriz(tblMatriz)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
            'cmbCiudad.SelectedValue = datosMatriz(2)
            cont = 0
            'For Each ciu In cmbCiudad.
            '    If ciu.ToString = datosMatriz(2) Then
            '        cmbCiudad.SelectedIndex = cont
            '    End If
            cont += 1
            Next
            'cmbCiudad.SelectedText = datosMatriz(2)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class