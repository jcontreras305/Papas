<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ActualizarEmpleados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbuEmMasculino = New System.Windows.Forms.RadioButton()
        Me.rbuEmFemenino = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnEmCancelar = New System.Windows.Forms.Button()
        Me.btnEmAceptar = New System.Windows.Forms.Button()
        Me.cboEmPuesto = New System.Windows.Forms.ComboBox()
        Me.cboEmHorario = New System.Windows.Forms.ComboBox()
        Me.cboEmBodega = New System.Windows.Forms.ComboBox()
        Me.txtEmDireccion = New System.Windows.Forms.TextBox()
        Me.txtEmTelefono = New System.Windows.Forms.TextBox()
        Me.txtEmSalario = New System.Windows.Forms.TextBox()
        Me.txtEmNombre = New System.Windows.Forms.TextBox()
        Me.lblEmPuesto = New System.Windows.Forms.Label()
        Me.lblEmHorario = New System.Windows.Forms.Label()
        Me.lblEmBodega = New System.Windows.Forms.Label()
        Me.lblEmDireccion = New System.Windows.Forms.Label()
        Me.lblEmTelefono = New System.Windows.Forms.Label()
        Me.lblEmSalario = New System.Windows.Forms.Label()
        Me.lblEmNombre = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbuEmMasculino)
        Me.GroupBox1.Controls.Add(Me.rbuEmFemenino)
        Me.GroupBox1.Location = New System.Drawing.Point(352, 211)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 63)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexo"
        '
        'rbuEmMasculino
        '
        Me.rbuEmMasculino.AutoSize = True
        Me.rbuEmMasculino.Location = New System.Drawing.Point(20, 31)
        Me.rbuEmMasculino.Name = "rbuEmMasculino"
        Me.rbuEmMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rbuEmMasculino.TabIndex = 11
        Me.rbuEmMasculino.TabStop = True
        Me.rbuEmMasculino.Text = "Masculino"
        Me.rbuEmMasculino.UseVisualStyleBackColor = True
        '
        'rbuEmFemenino
        '
        Me.rbuEmFemenino.AutoSize = True
        Me.rbuEmFemenino.Location = New System.Drawing.Point(144, 31)
        Me.rbuEmFemenino.Name = "rbuEmFemenino"
        Me.rbuEmFemenino.Size = New System.Drawing.Size(71, 17)
        Me.rbuEmFemenino.TabIndex = 10
        Me.rbuEmFemenino.TabStop = True
        Me.rbuEmFemenino.Text = "Femenino"
        Me.rbuEmFemenino.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label6.Location = New System.Drawing.Point(228, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(193, 22)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Registrar Empleado"
        '
        'btnEmCancelar
        '
        Me.btnEmCancelar.Location = New System.Drawing.Point(505, 300)
        Me.btnEmCancelar.Name = "btnEmCancelar"
        Me.btnEmCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnEmCancelar.TabIndex = 46
        Me.btnEmCancelar.Text = "Cancelar"
        Me.btnEmCancelar.UseVisualStyleBackColor = True
        '
        'btnEmAceptar
        '
        Me.btnEmAceptar.Location = New System.Drawing.Point(370, 300)
        Me.btnEmAceptar.Name = "btnEmAceptar"
        Me.btnEmAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnEmAceptar.TabIndex = 45
        Me.btnEmAceptar.Text = "Aceptar"
        Me.btnEmAceptar.UseVisualStyleBackColor = True
        '
        'cboEmPuesto
        '
        Me.cboEmPuesto.FormattingEnabled = True
        Me.cboEmPuesto.Location = New System.Drawing.Point(411, 168)
        Me.cboEmPuesto.Name = "cboEmPuesto"
        Me.cboEmPuesto.Size = New System.Drawing.Size(169, 21)
        Me.cboEmPuesto.TabIndex = 44
        '
        'cboEmHorario
        '
        Me.cboEmHorario.FormattingEnabled = True
        Me.cboEmHorario.Location = New System.Drawing.Point(411, 122)
        Me.cboEmHorario.Name = "cboEmHorario"
        Me.cboEmHorario.Size = New System.Drawing.Size(169, 21)
        Me.cboEmHorario.TabIndex = 43
        '
        'cboEmBodega
        '
        Me.cboEmBodega.FormattingEnabled = True
        Me.cboEmBodega.Location = New System.Drawing.Point(411, 70)
        Me.cboEmBodega.Name = "cboEmBodega"
        Me.cboEmBodega.Size = New System.Drawing.Size(169, 21)
        Me.cboEmBodega.TabIndex = 42
        '
        'txtEmDireccion
        '
        Me.txtEmDireccion.Location = New System.Drawing.Point(116, 211)
        Me.txtEmDireccion.Name = "txtEmDireccion"
        Me.txtEmDireccion.Size = New System.Drawing.Size(168, 20)
        Me.txtEmDireccion.TabIndex = 41
        '
        'txtEmTelefono
        '
        Me.txtEmTelefono.Location = New System.Drawing.Point(116, 168)
        Me.txtEmTelefono.Name = "txtEmTelefono"
        Me.txtEmTelefono.Size = New System.Drawing.Size(168, 20)
        Me.txtEmTelefono.TabIndex = 40
        '
        'txtEmSalario
        '
        Me.txtEmSalario.Location = New System.Drawing.Point(116, 122)
        Me.txtEmSalario.Name = "txtEmSalario"
        Me.txtEmSalario.Size = New System.Drawing.Size(168, 20)
        Me.txtEmSalario.TabIndex = 39
        '
        'txtEmNombre
        '
        Me.txtEmNombre.Location = New System.Drawing.Point(116, 70)
        Me.txtEmNombre.Name = "txtEmNombre"
        Me.txtEmNombre.Size = New System.Drawing.Size(168, 20)
        Me.txtEmNombre.TabIndex = 38
        '
        'lblEmPuesto
        '
        Me.lblEmPuesto.AutoSize = True
        Me.lblEmPuesto.Location = New System.Drawing.Point(349, 171)
        Me.lblEmPuesto.Name = "lblEmPuesto"
        Me.lblEmPuesto.Size = New System.Drawing.Size(40, 13)
        Me.lblEmPuesto.TabIndex = 37
        Me.lblEmPuesto.Text = "Puesto"
        '
        'lblEmHorario
        '
        Me.lblEmHorario.AutoSize = True
        Me.lblEmHorario.Location = New System.Drawing.Point(352, 125)
        Me.lblEmHorario.Name = "lblEmHorario"
        Me.lblEmHorario.Size = New System.Drawing.Size(41, 13)
        Me.lblEmHorario.TabIndex = 36
        Me.lblEmHorario.Text = "Horario"
        '
        'lblEmBodega
        '
        Me.lblEmBodega.AutoSize = True
        Me.lblEmBodega.Location = New System.Drawing.Point(349, 73)
        Me.lblEmBodega.Name = "lblEmBodega"
        Me.lblEmBodega.Size = New System.Drawing.Size(44, 13)
        Me.lblEmBodega.TabIndex = 35
        Me.lblEmBodega.Text = "Bodega"
        '
        'lblEmDireccion
        '
        Me.lblEmDireccion.AutoSize = True
        Me.lblEmDireccion.Location = New System.Drawing.Point(49, 218)
        Me.lblEmDireccion.Name = "lblEmDireccion"
        Me.lblEmDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblEmDireccion.TabIndex = 34
        Me.lblEmDireccion.Text = "Dirección"
        '
        'lblEmTelefono
        '
        Me.lblEmTelefono.AutoSize = True
        Me.lblEmTelefono.Location = New System.Drawing.Point(49, 171)
        Me.lblEmTelefono.Name = "lblEmTelefono"
        Me.lblEmTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblEmTelefono.TabIndex = 33
        Me.lblEmTelefono.Text = "Teléfono"
        '
        'lblEmSalario
        '
        Me.lblEmSalario.AutoSize = True
        Me.lblEmSalario.Location = New System.Drawing.Point(54, 125)
        Me.lblEmSalario.Name = "lblEmSalario"
        Me.lblEmSalario.Size = New System.Drawing.Size(39, 13)
        Me.lblEmSalario.TabIndex = 32
        Me.lblEmSalario.Text = "Salario"
        '
        'lblEmNombre
        '
        Me.lblEmNombre.AutoSize = True
        Me.lblEmNombre.Location = New System.Drawing.Point(54, 73)
        Me.lblEmNombre.Name = "lblEmNombre"
        Me.lblEmNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblEmNombre.TabIndex = 31
        Me.lblEmNombre.Text = "Nombre"
        '
        'ActualizarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 339)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnEmCancelar)
        Me.Controls.Add(Me.btnEmAceptar)
        Me.Controls.Add(Me.cboEmPuesto)
        Me.Controls.Add(Me.cboEmHorario)
        Me.Controls.Add(Me.cboEmBodega)
        Me.Controls.Add(Me.txtEmDireccion)
        Me.Controls.Add(Me.txtEmTelefono)
        Me.Controls.Add(Me.txtEmSalario)
        Me.Controls.Add(Me.txtEmNombre)
        Me.Controls.Add(Me.lblEmPuesto)
        Me.Controls.Add(Me.lblEmHorario)
        Me.Controls.Add(Me.lblEmBodega)
        Me.Controls.Add(Me.lblEmDireccion)
        Me.Controls.Add(Me.lblEmTelefono)
        Me.Controls.Add(Me.lblEmSalario)
        Me.Controls.Add(Me.lblEmNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ActualizarEmpleados"
        Me.Text = "ActualizarEmpleados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbuEmMasculino As RadioButton
    Friend WithEvents rbuEmFemenino As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents btnEmCancelar As Button
    Friend WithEvents btnEmAceptar As Button
    Friend WithEvents cboEmPuesto As ComboBox
    Friend WithEvents cboEmHorario As ComboBox
    Friend WithEvents cboEmBodega As ComboBox
    Friend WithEvents txtEmDireccion As TextBox
    Friend WithEvents txtEmTelefono As TextBox
    Friend WithEvents txtEmSalario As TextBox
    Friend WithEvents txtEmNombre As TextBox
    Friend WithEvents lblEmPuesto As Label
    Friend WithEvents lblEmHorario As Label
    Friend WithEvents lblEmBodega As Label
    Friend WithEvents lblEmDireccion As Label
    Friend WithEvents lblEmTelefono As Label
    Friend WithEvents lblEmSalario As Label
    Friend WithEvents lblEmNombre As Label
End Class
