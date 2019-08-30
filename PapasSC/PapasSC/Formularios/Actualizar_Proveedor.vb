
Public Class Actualizar_Proveedor
    Public nombre, telefono, ciudad, email As String
    Public mtdProveedor As New MetodosProveedor

    Private Sub Actualizar_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnAceptarProvee_Click(sender As Object, e As EventArgs) Handles btnAceptarProvee.Click
        Dim datosNuevos(4), datosViejos(4) As String
        Dim nombre As String
        nombre = txtNombrePro.Text
        datosNuevos(0) = txtTelefonoProvee.Text
        datosNuevos(1) = txtEmailProvee.Text
        datosNuevos(2) = cboCiudadProve.SelectedValue.ToString
        datosViejos(0) = telefono
        datosViejos(1) = email
        datosViejos(2) = ciudad
        mtdProveedor.SelecionarCiu(cboCiudadProve)
        mtdProveedor.modificar_Proveedor(datosViejos, datosNuevos, nombre)

    End Sub

    Private Sub Label5_Click_1(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
    End Sub







End Class