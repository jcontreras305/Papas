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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActualizarEmpleados))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCam2 = New System.Windows.Forms.Label()
        Me.lblCam1 = New System.Windows.Forms.Label()
        Me.lblCam = New System.Windows.Forms.Label()
        Me.chbActivo = New System.Windows.Forms.CheckBox()
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
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label5.Location = New System.Drawing.Point(591, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 20)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "X"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCam2)
        Me.GroupBox1.Controls.Add(Me.lblCam1)
        Me.GroupBox1.Controls.Add(Me.lblCam)
        Me.GroupBox1.Controls.Add(Me.chbActivo)
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
        Me.GroupBox1.Location = New System.Drawing.Point(22, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(562, 225)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Principales"
        '
        'lblCam2
        '
        Me.lblCam2.AutoSize = True
        Me.lblCam2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCam2.ForeColor = System.Drawing.Color.Red
        Me.lblCam2.Location = New System.Drawing.Point(250, 178)
        Me.lblCam2.Name = "lblCam2"
        Me.lblCam2.Size = New System.Drawing.Size(15, 20)
        Me.lblCam2.TabIndex = 49
        Me.lblCam2.Text = "*"
        '
        'lblCam1
        '
        Me.lblCam1.AutoSize = True
        Me.lblCam1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCam1.ForeColor = System.Drawing.Color.Red
        Me.lblCam1.Location = New System.Drawing.Point(250, 154)
        Me.lblCam1.Name = "lblCam1"
        Me.lblCam1.Size = New System.Drawing.Size(15, 20)
        Me.lblCam1.TabIndex = 48
        Me.lblCam1.Text = "*"
        '
        'lblCam
        '
        Me.lblCam.AutoSize = True
        Me.lblCam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCam.ForeColor = System.Drawing.Color.Red
        Me.lblCam.Location = New System.Drawing.Point(250, 49)
        Me.lblCam.Name = "lblCam"
        Me.lblCam.Size = New System.Drawing.Size(15, 20)
        Me.lblCam.TabIndex = 47
        Me.lblCam.Text = "*"
        '
        'chbActivo
        '
        Me.chbActivo.AutoSize = True
        Me.chbActivo.Location = New System.Drawing.Point(484, 19)
        Me.chbActivo.Name = "chbActivo"
        Me.chbActivo.Size = New System.Drawing.Size(56, 17)
        Me.chbActivo.TabIndex = 46
        Me.chbActivo.Text = "Activo"
        Me.chbActivo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbuEmMasculino)
        Me.GroupBox2.Controls.Add(Me.rbuEmFemenino)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(227, 47)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sexo"
        '
        'rbuEmMasculino
        '
        Me.rbuEmMasculino.AutoSize = True
        Me.rbuEmMasculino.Location = New System.Drawing.Point(19, 19)
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
        Me.rbuEmFemenino.Location = New System.Drawing.Point(141, 19)
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
        Me.cboEmPuesto.Location = New System.Drawing.Point(371, 101)
        Me.cboEmPuesto.Name = "cboEmPuesto"
        Me.cboEmPuesto.Size = New System.Drawing.Size(169, 21)
        Me.cboEmPuesto.TabIndex = 44
        '
        'cboEmHorario
        '
        Me.cboEmHorario.FormattingEnabled = True
        Me.cboEmHorario.Location = New System.Drawing.Point(371, 75)
        Me.cboEmHorario.Name = "cboEmHorario"
        Me.cboEmHorario.Size = New System.Drawing.Size(169, 21)
        Me.cboEmHorario.TabIndex = 43
        '
        'cboEmBodega
        '
        Me.cboEmBodega.FormattingEnabled = True
        Me.cboEmBodega.Location = New System.Drawing.Point(371, 49)
        Me.cboEmBodega.Name = "cboEmBodega"
        Me.cboEmBodega.Size = New System.Drawing.Size(169, 21)
        Me.cboEmBodega.TabIndex = 42
        '
        'txtEmDireccion
        '
        Me.txtEmDireccion.Location = New System.Drawing.Point(76, 128)
        Me.txtEmDireccion.Name = "txtEmDireccion"
        Me.txtEmDireccion.Size = New System.Drawing.Size(168, 20)
        Me.txtEmDireccion.TabIndex = 41
        '
        'txtEmTelefono
        '
        Me.txtEmTelefono.Location = New System.Drawing.Point(76, 154)
        Me.txtEmTelefono.Name = "txtEmTelefono"
        Me.txtEmTelefono.Size = New System.Drawing.Size(168, 20)
        Me.txtEmTelefono.TabIndex = 40
        Me.txtEmTelefono.Text = "355-000-000"
        '
        'txtEmSalario
        '
        Me.txtEmSalario.Location = New System.Drawing.Point(76, 180)
        Me.txtEmSalario.Name = "txtEmSalario"
        Me.txtEmSalario.Size = New System.Drawing.Size(168, 20)
        Me.txtEmSalario.TabIndex = 39
        Me.txtEmSalario.Text = "0.00"
        '
        'txtEmNombre
        '
        Me.txtEmNombre.Location = New System.Drawing.Point(76, 49)
        Me.txtEmNombre.Name = "txtEmNombre"
        Me.txtEmNombre.Size = New System.Drawing.Size(168, 20)
        Me.txtEmNombre.TabIndex = 38
        '
        'lblEmPuesto
        '
        Me.lblEmPuesto.AutoSize = True
        Me.lblEmPuesto.Location = New System.Drawing.Point(312, 104)
        Me.lblEmPuesto.Name = "lblEmPuesto"
        Me.lblEmPuesto.Size = New System.Drawing.Size(40, 13)
        Me.lblEmPuesto.TabIndex = 37
        Me.lblEmPuesto.Text = "Puesto"
        '
        'lblEmHorario
        '
        Me.lblEmHorario.AutoSize = True
        Me.lblEmHorario.Location = New System.Drawing.Point(312, 78)
        Me.lblEmHorario.Name = "lblEmHorario"
        Me.lblEmHorario.Size = New System.Drawing.Size(41, 13)
        Me.lblEmHorario.TabIndex = 36
        Me.lblEmHorario.Text = "Horario"
        '
        'lblEmBodega
        '
        Me.lblEmBodega.AutoSize = True
        Me.lblEmBodega.Location = New System.Drawing.Point(309, 52)
        Me.lblEmBodega.Name = "lblEmBodega"
        Me.lblEmBodega.Size = New System.Drawing.Size(44, 13)
        Me.lblEmBodega.TabIndex = 35
        Me.lblEmBodega.Text = "Bodega"
        '
        'lblEmDireccion
        '
        Me.lblEmDireccion.AutoSize = True
        Me.lblEmDireccion.Location = New System.Drawing.Point(14, 131)
        Me.lblEmDireccion.Name = "lblEmDireccion"
        Me.lblEmDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblEmDireccion.TabIndex = 34
        Me.lblEmDireccion.Text = "Dirección"
        '
        'lblEmTelefono
        '
        Me.lblEmTelefono.AutoSize = True
        Me.lblEmTelefono.Location = New System.Drawing.Point(14, 157)
        Me.lblEmTelefono.Name = "lblEmTelefono"
        Me.lblEmTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblEmTelefono.TabIndex = 33
        Me.lblEmTelefono.Text = "Teléfono"
        '
        'lblEmSalario
        '
        Me.lblEmSalario.AutoSize = True
        Me.lblEmSalario.Location = New System.Drawing.Point(14, 180)
        Me.lblEmSalario.Name = "lblEmSalario"
        Me.lblEmSalario.Size = New System.Drawing.Size(39, 13)
        Me.lblEmSalario.TabIndex = 32
        Me.lblEmSalario.Text = "Salario"
        '
        'lblEmNombre
        '
        Me.lblEmNombre.AutoSize = True
        Me.lblEmNombre.Location = New System.Drawing.Point(14, 52)
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
        Me.Label6.Location = New System.Drawing.Point(207, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 22)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Actualizar Empleado"
        '
        'btnEmCancelar
        '
        Me.btnEmCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmCancelar.Image = CType(resources.GetObject("btnEmCancelar.Image"), System.Drawing.Image)
        Me.btnEmCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmCancelar.Location = New System.Drawing.Point(476, 290)
        Me.btnEmCancelar.Name = "btnEmCancelar"
        Me.btnEmCancelar.Size = New System.Drawing.Size(108, 37)
        Me.btnEmCancelar.TabIndex = 37
        Me.btnEmCancelar.Text = "Cancelar"
        Me.btnEmCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmCancelar.UseVisualStyleBackColor = True
        '
        'btnEmAceptar
        '
        Me.btnEmAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmAceptar.Image = CType(resources.GetObject("btnEmAceptar.Image"), System.Drawing.Image)
        Me.btnEmAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmAceptar.Location = New System.Drawing.Point(362, 290)
        Me.btnEmAceptar.Name = "btnEmAceptar"
        Me.btnEmAceptar.Size = New System.Drawing.Size(108, 37)
        Me.btnEmAceptar.TabIndex = 36
        Me.btnEmAceptar.Text = "Aceptar"
        Me.btnEmAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmAceptar.UseVisualStyleBackColor = True
        '
        'ActualizarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 332)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnEmCancelar)
        Me.Controls.Add(Me.btnEmAceptar)
        Me.Controls.Add(Me.Label5)
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
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblCam2 As Label
    Friend WithEvents lblCam1 As Label
    Friend WithEvents lblCam As Label
    Friend WithEvents chbActivo As CheckBox
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
End Class
