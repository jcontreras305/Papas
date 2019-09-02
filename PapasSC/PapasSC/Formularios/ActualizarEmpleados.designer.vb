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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbuEmMasculino = New System.Windows.Forms.RadioButton()
        Me.rbuEmFemenino = New System.Windows.Forms.RadioButton()
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnEmCancelar = New System.Windows.Forms.Button()
        Me.btnEmAceptar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cboEmPuesto)
        Me.GroupBox1.Controls.Add(Me.cboEmHorario)
        Me.GroupBox1.Controls.Add(Me.cboEmBodega)
        Me.GroupBox1.Controls.Add(Me.txtEmDireccion)
        Me.GroupBox1.Controls.Add(Me.txtEmTelefono)
        Me.GroupBox1.Controls.Add(Me.txtEmSalario)
        Me.GroupBox1.Controls.Add(Me.txtEmNombre)
        Me.GroupBox1.Controls.Add(Me.lblEmPuesto)
        Me.GroupBox1.Controls.Add(Me.lblEmHorario)
        Me.GroupBox1.Controls.Add(Me.lblEmBodega)
        Me.GroupBox1.Controls.Add(Me.lblEmDireccion)
        Me.GroupBox1.Controls.Add(Me.lblEmTelefono)
        Me.GroupBox1.Controls.Add(Me.lblEmSalario)
        Me.GroupBox1.Controls.Add(Me.lblEmNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 251)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbuEmMasculino)
        Me.GroupBox2.Controls.Add(Me.rbuEmFemenino)
        Me.GroupBox2.Location = New System.Drawing.Point(315, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(236, 63)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sexo"
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
        'cboEmPuesto
        '
        Me.cboEmPuesto.FormattingEnabled = True
        Me.cboEmPuesto.Location = New System.Drawing.Point(374, 121)
        Me.cboEmPuesto.Name = "cboEmPuesto"
        Me.cboEmPuesto.Size = New System.Drawing.Size(169, 21)
        Me.cboEmPuesto.TabIndex = 44
        '
        'cboEmHorario
        '
        Me.cboEmHorario.FormattingEnabled = True
        Me.cboEmHorario.Location = New System.Drawing.Point(374, 75)
        Me.cboEmHorario.Name = "cboEmHorario"
        Me.cboEmHorario.Size = New System.Drawing.Size(169, 21)
        Me.cboEmHorario.TabIndex = 43
        '
        'cboEmBodega
        '
        Me.cboEmBodega.FormattingEnabled = True
        Me.cboEmBodega.Location = New System.Drawing.Point(374, 23)
        Me.cboEmBodega.Name = "cboEmBodega"
        Me.cboEmBodega.Size = New System.Drawing.Size(169, 21)
        Me.cboEmBodega.TabIndex = 42
        '
        'txtEmDireccion
        '
        Me.txtEmDireccion.Location = New System.Drawing.Point(79, 164)
        Me.txtEmDireccion.Name = "txtEmDireccion"
        Me.txtEmDireccion.Size = New System.Drawing.Size(168, 20)
        Me.txtEmDireccion.TabIndex = 41
        '
        'txtEmTelefono
        '
        Me.txtEmTelefono.Location = New System.Drawing.Point(79, 121)
        Me.txtEmTelefono.Name = "txtEmTelefono"
        Me.txtEmTelefono.Size = New System.Drawing.Size(168, 20)
        Me.txtEmTelefono.TabIndex = 40
        '
        'txtEmSalario
        '
        Me.txtEmSalario.Location = New System.Drawing.Point(79, 75)
        Me.txtEmSalario.Name = "txtEmSalario"
        Me.txtEmSalario.Size = New System.Drawing.Size(168, 20)
        Me.txtEmSalario.TabIndex = 39
        '
        'txtEmNombre
        '
        Me.txtEmNombre.Location = New System.Drawing.Point(79, 23)
        Me.txtEmNombre.Name = "txtEmNombre"
        Me.txtEmNombre.Size = New System.Drawing.Size(168, 20)
        Me.txtEmNombre.TabIndex = 38
        '
        'lblEmPuesto
        '
        Me.lblEmPuesto.AutoSize = True
        Me.lblEmPuesto.Location = New System.Drawing.Point(312, 124)
        Me.lblEmPuesto.Name = "lblEmPuesto"
        Me.lblEmPuesto.Size = New System.Drawing.Size(40, 13)
        Me.lblEmPuesto.TabIndex = 37
        Me.lblEmPuesto.Text = "Puesto"
        '
        'lblEmHorario
        '
        Me.lblEmHorario.AutoSize = True
        Me.lblEmHorario.Location = New System.Drawing.Point(315, 78)
        Me.lblEmHorario.Name = "lblEmHorario"
        Me.lblEmHorario.Size = New System.Drawing.Size(41, 13)
        Me.lblEmHorario.TabIndex = 36
        Me.lblEmHorario.Text = "Horario"
        '
        'lblEmBodega
        '
        Me.lblEmBodega.AutoSize = True
        Me.lblEmBodega.Location = New System.Drawing.Point(312, 26)
        Me.lblEmBodega.Name = "lblEmBodega"
        Me.lblEmBodega.Size = New System.Drawing.Size(44, 13)
        Me.lblEmBodega.TabIndex = 35
        Me.lblEmBodega.Text = "Bodega"
        '
        'lblEmDireccion
        '
        Me.lblEmDireccion.AutoSize = True
        Me.lblEmDireccion.Location = New System.Drawing.Point(12, 171)
        Me.lblEmDireccion.Name = "lblEmDireccion"
        Me.lblEmDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblEmDireccion.TabIndex = 34
        Me.lblEmDireccion.Text = "Dirección"
        '
        'lblEmTelefono
        '
        Me.lblEmTelefono.AutoSize = True
        Me.lblEmTelefono.Location = New System.Drawing.Point(12, 124)
        Me.lblEmTelefono.Name = "lblEmTelefono"
        Me.lblEmTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblEmTelefono.TabIndex = 33
        Me.lblEmTelefono.Text = "Teléfono"
        '
        'lblEmSalario
        '
        Me.lblEmSalario.AutoSize = True
        Me.lblEmSalario.Location = New System.Drawing.Point(17, 78)
        Me.lblEmSalario.Name = "lblEmSalario"
        Me.lblEmSalario.Size = New System.Drawing.Size(39, 13)
        Me.lblEmSalario.TabIndex = 32
        Me.lblEmSalario.Text = "Salario"
        '
        'lblEmNombre
        '
        Me.lblEmNombre.AutoSize = True
        Me.lblEmNombre.Location = New System.Drawing.Point(17, 26)
        Me.lblEmNombre.Name = "lblEmNombre"
        Me.lblEmNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblEmNombre.TabIndex = 31
        Me.lblEmNombre.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label6.Location = New System.Drawing.Point(227, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 22)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Actualizar Empleado"
        '
        'btnEmCancelar
        '
        Me.btnEmCancelar.Location = New System.Drawing.Point(496, 297)
        Me.btnEmCancelar.Name = "btnEmCancelar"
        Me.btnEmCancelar.Size = New System.Drawing.Size(108, 37)
        Me.btnEmCancelar.TabIndex = 32
        Me.btnEmCancelar.Text = "Cancelar"
        Me.btnEmCancelar.UseVisualStyleBackColor = True
        '
        'btnEmAceptar
        '
        Me.btnEmAceptar.Location = New System.Drawing.Point(377, 297)
        Me.btnEmAceptar.Name = "btnEmAceptar"
        Me.btnEmAceptar.Size = New System.Drawing.Size(108, 37)
        Me.btnEmAceptar.TabIndex = 31
        Me.btnEmAceptar.Text = "Aceptar"
        Me.btnEmAceptar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label5.Location = New System.Drawing.Point(635, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 20)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "X"
        '
        'ActualizarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 339)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnEmCancelar)
        Me.Controls.Add(Me.btnEmAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ActualizarEmpleados"
        Me.Text = "ActualizarEmpleados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbuEmMasculino As RadioButton
    Friend WithEvents rbuEmFemenino As RadioButton
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
    Friend WithEvents Label6 As Label
    Friend WithEvents btnEmCancelar As Button
    Friend WithEvents btnEmAceptar As Button
    Friend WithEvents Label5 As Label
End Class
