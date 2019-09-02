Public Class ActualizarEmpleados
    Public nombre, sexo, sala, telefono, dire, bodega, horario, puesto As String

    Private Sub ActualizarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
    End Sub

    Private Sub btnEmCancelar_Click(sender As Object, e As EventArgs) Handles btnEmCancelar.Click
        Me.Close()
    End Sub

    Public mtdEmpleado As New MetodosEmpleado

    Private Sub btnEmAceptar_Click(sender As Object, e As EventArgs) Handles btnEmAceptar.Click
        Dim datosNu(8), datosVi(8) As String
        Dim nombre As String
        Dim sexo As String

        nombre = txtEmNombre.Text
        sexo = rbuEmFemenino.Checked
        datosNu(0) = txtEmSalario.Text
        datosNu(1) = txtEmTelefono.Text
        datosNu(2) = txtEmDireccion.Text
        datosNu(3) = cboEmBodega.Text
        datosNu(4) = cboEmHorario.Text
        datosNu(5) = cboEmPuesto.Text
        datosVi(0) = txtEmSalario.Text
        datosVi(1) = txtEmTelefono.Text
        datosVi(2) = txtEmDireccion.Text
        datosVi(3) = cboEmBodega.Text
        datosVi(4) = cboEmHorario.Text
        datosVi(5) = cboEmPuesto.Text

        mtdEmpleado.ActualizarEmpleado(datosVi, datosNu, nombre, sexo)
    End Sub

End Class