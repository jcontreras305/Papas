<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarEmpleados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblEmNombre = New System.Windows.Forms.Label()
        Me.lblEmSalario = New System.Windows.Forms.Label()
        Me.lblEmTelefono = New System.Windows.Forms.Label()
        Me.lblEmDireccion = New System.Windows.Forms.Label()
        Me.lblEmBodega = New System.Windows.Forms.Label()
        Me.lblEmHorario = New System.Windows.Forms.Label()
        Me.lblEmPuesto = New System.Windows.Forms.Label()
        Me.txtEmNombre = New System.Windows.Forms.TextBox()
        Me.rbuEmFemenino = New System.Windows.Forms.RadioButton()
        Me.rbuEmMasculino = New System.Windows.Forms.RadioButton()
        Me.txtEmSalario = New System.Windows.Forms.TextBox()
        Me.txtEmTelefono = New System.Windows.Forms.TextBox()
        Me.txtEmDireccion = New System.Windows.Forms.TextBox()
        Me.cboEmBodega = New System.Windows.Forms.ComboBox()
        Me.cboEmHorario = New System.Windows.Forms.ComboBox()
        Me.cboEmPuesto = New System.Windows.Forms.ComboBox()
        Me.btnEmAceptar = New System.Windows.Forms.Button()
        Me.btnEmCancelar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEmNombre
        '
        Me.lblEmNombre.AutoSize = True
        Me.lblEmNombre.Location = New System.Drawing.Point(47, 75)
        Me.lblEmNombre.Name = "lblEmNombre"
        Me.lblEmNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblEmNombre.TabIndex = 0
        Me.lblEmNombre.Text = "Nombre"
        '
        'lblEmSalario
        '
        Me.lblEmSalario.AutoSize = True
        Me.lblEmSalario.Location = New System.Drawing.Point(47, 127)
        Me.lblEmSalario.Name = "lblEmSalario"
        Me.lblEmSalario.Size = New System.Drawing.Size(39, 13)
        Me.lblEmSalario.TabIndex = 2
        Me.lblEmSalario.Text = "Salario"
        '
        'lblEmTelefono
        '
        Me.lblEmTelefono.AutoSize = True
        Me.lblEmTelefono.Location = New System.Drawing.Point(42, 173)
        Me.lblEmTelefono.Name = "lblEmTelefono"
        Me.lblEmTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblEmTelefono.TabIndex = 3
        Me.lblEmTelefono.Text = "Teléfono"
        '
        'lblEmDireccion
        '
        Me.lblEmDireccion.AutoSize = True
        Me.lblEmDireccion.Location = New System.Drawing.Point(42, 220)
        Me.lblEmDireccion.Name = "lblEmDireccion"
        Me.lblEmDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblEmDireccion.TabIndex = 4
        Me.lblEmDireccion.Text = "Dirección"
        '
        'lblEmBodega
        '
        Me.lblEmBodega.AutoSize = True
        Me.lblEmBodega.Location = New System.Drawing.Point(342, 75)
        Me.lblEmBodega.Name = "lblEmBodega"
        Me.lblEmBodega.Size = New System.Drawing.Size(44, 13)
        Me.lblEmBodega.TabIndex = 6
        Me.lblEmBodega.Text = "Bodega"
        '
        'lblEmHorario
        '
        Me.lblEmHorario.AutoSize = True
        Me.lblEmHorario.Location = New System.Drawing.Point(345, 127)
        Me.lblEmHorario.Name = "lblEmHorario"
        Me.lblEmHorario.Size = New System.Drawing.Size(41, 13)
        Me.lblEmHorario.TabIndex = 7
        Me.lblEmHorario.Text = "Horario"
        '
        'lblEmPuesto
        '
        Me.lblEmPuesto.AutoSize = True
        Me.lblEmPuesto.Location = New System.Drawing.Point(342, 173)
        Me.lblEmPuesto.Name = "lblEmPuesto"
        Me.lblEmPuesto.Size = New System.Drawing.Size(40, 13)
        Me.lblEmPuesto.TabIndex = 8
        Me.lblEmPuesto.Text = "Puesto"
        '
        'txtEmNombre
        '
        Me.txtEmNombre.Location = New System.Drawing.Point(109, 72)
        Me.txtEmNombre.Name = "txtEmNombre"
        Me.txtEmNombre.Size = New System.Drawing.Size(168, 20)
        Me.txtEmNombre.TabIndex = 9
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
        'txtEmSalario
        '
        Me.txtEmSalario.Location = New System.Drawing.Point(109, 124)
        Me.txtEmSalario.Name = "txtEmSalario"
        Me.txtEmSalario.Size = New System.Drawing.Size(168, 20)
        Me.txtEmSalario.TabIndex = 12
        '
        'txtEmTelefono
        '
        Me.txtEmTelefono.Location = New System.Drawing.Point(109, 170)
        Me.txtEmTelefono.Name = "txtEmTelefono"
        Me.txtEmTelefono.Size = New System.Drawing.Size(168, 20)
        Me.txtEmTelefono.TabIndex = 13
        '
        'txtEmDireccion
        '
        Me.txtEmDireccion.Location = New System.Drawing.Point(109, 213)
        Me.txtEmDireccion.Name = "txtEmDireccion"
        Me.txtEmDireccion.Size = New System.Drawing.Size(168, 20)
        Me.txtEmDireccion.TabIndex = 14
        '
        'cboEmBodega
        '
        Me.cboEmBodega.FormattingEnabled = True
        Me.cboEmBodega.Location = New System.Drawing.Point(404, 72)
        Me.cboEmBodega.Name = "cboEmBodega"
        Me.cboEmBodega.Size = New System.Drawing.Size(169, 21)
        Me.cboEmBodega.TabIndex = 16
        '
        'cboEmHorario
        '
        Me.cboEmHorario.FormattingEnabled = True
        Me.cboEmHorario.Location = New System.Drawing.Point(404, 124)
        Me.cboEmHorario.Name = "cboEmHorario"
        Me.cboEmHorario.Size = New System.Drawing.Size(169, 21)
        Me.cboEmHorario.TabIndex = 17
        '
        'cboEmPuesto
        '
        Me.cboEmPuesto.FormattingEnabled = True
        Me.cboEmPuesto.Location = New System.Drawing.Point(404, 170)
        Me.cboEmPuesto.Name = "cboEmPuesto"
        Me.cboEmPuesto.Size = New System.Drawing.Size(169, 21)
        Me.cboEmPuesto.TabIndex = 18
        '
        'btnEmAceptar
        '
        Me.btnEmAceptar.Location = New System.Drawing.Point(345, 302)
        Me.btnEmAceptar.Name = "btnEmAceptar"
        Me.btnEmAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnEmAceptar.TabIndex = 19
        Me.btnEmAceptar.Text = "Aceptar"
        Me.btnEmAceptar.UseVisualStyleBackColor = True
        '
        'btnEmCancelar
        '
        Me.btnEmCancelar.Location = New System.Drawing.Point(461, 302)
        Me.btnEmCancelar.Name = "btnEmCancelar"
        Me.btnEmCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnEmCancelar.TabIndex = 20
        Me.btnEmCancelar.Text = "Cancelar"
        Me.btnEmCancelar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label9.Location = New System.Drawing.Point(0, -1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 24)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "X"
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label6.Location = New System.Drawing.Point(211, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(193, 22)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Registrar Empleado"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbuEmMasculino)
        Me.GroupBox1.Controls.Add(Me.rbuEmFemenino)
        Me.GroupBox1.Location = New System.Drawing.Point(345, 213)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 63)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexo"
        '
        'AgregarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 337)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
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
        Me.Name = "AgregarEmpleados"
        Me.Text = "AgregarEmpleados"
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEmNombre As Label
    Friend WithEvents lblEmSalario As Label
    Friend WithEvents lblEmTelefono As Label
    Friend WithEvents lblEmDireccion As Label
    Friend WithEvents lblEmBodega As Label
    Friend WithEvents lblEmHorario As Label
    Friend WithEvents lblEmPuesto As Label
    Friend WithEvents txtEmNombre As TextBox
    Friend WithEvents rbuEmFemenino As RadioButton
    Friend WithEvents rbuEmMasculino As RadioButton
    Friend WithEvents txtEmSalario As TextBox
    Friend WithEvents txtEmTelefono As TextBox
    Friend WithEvents txtEmDireccion As TextBox
    Friend WithEvents cboEmBodega As ComboBox
    Friend WithEvents cboEmHorario As ComboBox
    Friend WithEvents cboEmPuesto As ComboBox
    Friend WithEvents btnEmAceptar As Button
    Friend WithEvents btnEmCancelar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
End Class
