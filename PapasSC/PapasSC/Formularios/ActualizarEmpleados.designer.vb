<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizarEmpleados
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
        Me.btnEmCancelar = New System.Windows.Forms.Button()
        Me.btnEmAceptar = New System.Windows.Forms.Button()
        Me.cboEmPuesto = New System.Windows.Forms.ComboBox()
        Me.cboEmHorario = New System.Windows.Forms.ComboBox()
        Me.cboEmBodega = New System.Windows.Forms.ComboBox()
        Me.cboEmEstatus = New System.Windows.Forms.ComboBox()
        Me.txtEmDireccion = New System.Windows.Forms.TextBox()
        Me.txtEmTelefono = New System.Windows.Forms.TextBox()
        Me.txtEmSalario = New System.Windows.Forms.TextBox()
        Me.rbuEmMasculino = New System.Windows.Forms.RadioButton()
        Me.rbuEmFemenino = New System.Windows.Forms.RadioButton()
        Me.txtEmNombre = New System.Windows.Forms.TextBox()
        Me.lblEmPuesto = New System.Windows.Forms.Label()
        Me.lblEmHorario = New System.Windows.Forms.Label()
        Me.lblEmBodega = New System.Windows.Forms.Label()
        Me.lblEmEstatus = New System.Windows.Forms.Label()
        Me.lblEmDireccion = New System.Windows.Forms.Label()
        Me.lblEmTelefono = New System.Windows.Forms.Label()
        Me.lblEmSalario = New System.Windows.Forms.Label()
        Me.lblEmSexo = New System.Windows.Forms.Label()
        Me.lblEmNombre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEmCancelar
        '
        Me.btnEmCancelar.Location = New System.Drawing.Point(546, 224)
        Me.btnEmCancelar.Name = "btnEmCancelar"
        Me.btnEmCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnEmCancelar.TabIndex = 41
        Me.btnEmCancelar.Text = "Cancelar"
        Me.btnEmCancelar.UseVisualStyleBackColor = True
        '
        'btnEmAceptar
        '
        Me.btnEmAceptar.Location = New System.Drawing.Point(452, 224)
        Me.btnEmAceptar.Name = "btnEmAceptar"
        Me.btnEmAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnEmAceptar.TabIndex = 40
        Me.btnEmAceptar.Text = "Aceptar"
        Me.btnEmAceptar.UseVisualStyleBackColor = True
        '
        'cboEmPuesto
        '
        Me.cboEmPuesto.FormattingEnabled = True
        Me.cboEmPuesto.Location = New System.Drawing.Point(452, 126)
        Me.cboEmPuesto.Name = "cboEmPuesto"
        Me.cboEmPuesto.Size = New System.Drawing.Size(169, 21)
        Me.cboEmPuesto.TabIndex = 39
        '
        'cboEmHorario
        '
        Me.cboEmHorario.FormattingEnabled = True
        Me.cboEmHorario.Location = New System.Drawing.Point(452, 77)
        Me.cboEmHorario.Name = "cboEmHorario"
        Me.cboEmHorario.Size = New System.Drawing.Size(169, 21)
        Me.cboEmHorario.TabIndex = 38
        '
        'cboEmBodega
        '
        Me.cboEmBodega.FormattingEnabled = True
        Me.cboEmBodega.Location = New System.Drawing.Point(452, 32)
        Me.cboEmBodega.Name = "cboEmBodega"
        Me.cboEmBodega.Size = New System.Drawing.Size(169, 21)
        Me.cboEmBodega.TabIndex = 37
        '
        'cboEmEstatus
        '
        Me.cboEmEstatus.FormattingEnabled = True
        Me.cboEmEstatus.Location = New System.Drawing.Point(108, 226)
        Me.cboEmEstatus.Name = "cboEmEstatus"
        Me.cboEmEstatus.Size = New System.Drawing.Size(71, 21)
        Me.cboEmEstatus.TabIndex = 36
        '
        'txtEmDireccion
        '
        Me.txtEmDireccion.Location = New System.Drawing.Point(108, 188)
        Me.txtEmDireccion.Name = "txtEmDireccion"
        Me.txtEmDireccion.Size = New System.Drawing.Size(168, 20)
        Me.txtEmDireccion.TabIndex = 35
        '
        'txtEmTelefono
        '
        Me.txtEmTelefono.Location = New System.Drawing.Point(108, 145)
        Me.txtEmTelefono.Name = "txtEmTelefono"
        Me.txtEmTelefono.Size = New System.Drawing.Size(168, 20)
        Me.txtEmTelefono.TabIndex = 34
        '
        'txtEmSalario
        '
        Me.txtEmSalario.Location = New System.Drawing.Point(108, 96)
        Me.txtEmSalario.Name = "txtEmSalario"
        Me.txtEmSalario.Size = New System.Drawing.Size(168, 20)
        Me.txtEmSalario.TabIndex = 33
        '
        'rbuEmMasculino
        '
        Me.rbuEmMasculino.AutoSize = True
        Me.rbuEmMasculino.Location = New System.Drawing.Point(203, 63)
        Me.rbuEmMasculino.Name = "rbuEmMasculino"
        Me.rbuEmMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rbuEmMasculino.TabIndex = 32
        Me.rbuEmMasculino.TabStop = True
        Me.rbuEmMasculino.Text = "Masculino"
        Me.rbuEmMasculino.UseVisualStyleBackColor = True
        '
        'rbuEmFemenino
        '
        Me.rbuEmFemenino.AutoSize = True
        Me.rbuEmFemenino.Location = New System.Drawing.Point(108, 63)
        Me.rbuEmFemenino.Name = "rbuEmFemenino"
        Me.rbuEmFemenino.Size = New System.Drawing.Size(71, 17)
        Me.rbuEmFemenino.TabIndex = 31
        Me.rbuEmFemenino.TabStop = True
        Me.rbuEmFemenino.Text = "Femenino"
        Me.rbuEmFemenino.UseVisualStyleBackColor = True
        '
        'txtEmNombre
        '
        Me.txtEmNombre.Location = New System.Drawing.Point(108, 32)
        Me.txtEmNombre.Name = "txtEmNombre"
        Me.txtEmNombre.Size = New System.Drawing.Size(168, 20)
        Me.txtEmNombre.TabIndex = 30
        '
        'lblEmPuesto
        '
        Me.lblEmPuesto.AutoSize = True
        Me.lblEmPuesto.Location = New System.Drawing.Point(382, 129)
        Me.lblEmPuesto.Name = "lblEmPuesto"
        Me.lblEmPuesto.Size = New System.Drawing.Size(40, 13)
        Me.lblEmPuesto.TabIndex = 29
        Me.lblEmPuesto.Text = "Puesto"
        '
        'lblEmHorario
        '
        Me.lblEmHorario.AutoSize = True
        Me.lblEmHorario.Location = New System.Drawing.Point(382, 77)
        Me.lblEmHorario.Name = "lblEmHorario"
        Me.lblEmHorario.Size = New System.Drawing.Size(41, 13)
        Me.lblEmHorario.TabIndex = 28
        Me.lblEmHorario.Text = "Horario"
        '
        'lblEmBodega
        '
        Me.lblEmBodega.AutoSize = True
        Me.lblEmBodega.Location = New System.Drawing.Point(382, 32)
        Me.lblEmBodega.Name = "lblEmBodega"
        Me.lblEmBodega.Size = New System.Drawing.Size(44, 13)
        Me.lblEmBodega.TabIndex = 27
        Me.lblEmBodega.Text = "Bodega"
        '
        'lblEmEstatus
        '
        Me.lblEmEstatus.AutoSize = True
        Me.lblEmEstatus.Location = New System.Drawing.Point(38, 226)
        Me.lblEmEstatus.Name = "lblEmEstatus"
        Me.lblEmEstatus.Size = New System.Drawing.Size(42, 13)
        Me.lblEmEstatus.TabIndex = 26
        Me.lblEmEstatus.Text = "Estatus"
        '
        'lblEmDireccion
        '
        Me.lblEmDireccion.AutoSize = True
        Me.lblEmDireccion.Location = New System.Drawing.Point(36, 188)
        Me.lblEmDireccion.Name = "lblEmDireccion"
        Me.lblEmDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblEmDireccion.TabIndex = 25
        Me.lblEmDireccion.Text = "Dirección"
        '
        'lblEmTelefono
        '
        Me.lblEmTelefono.AutoSize = True
        Me.lblEmTelefono.Location = New System.Drawing.Point(36, 148)
        Me.lblEmTelefono.Name = "lblEmTelefono"
        Me.lblEmTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblEmTelefono.TabIndex = 24
        Me.lblEmTelefono.Text = "Teléfono"
        '
        'lblEmSalario
        '
        Me.lblEmSalario.AutoSize = True
        Me.lblEmSalario.Location = New System.Drawing.Point(41, 99)
        Me.lblEmSalario.Name = "lblEmSalario"
        Me.lblEmSalario.Size = New System.Drawing.Size(39, 13)
        Me.lblEmSalario.TabIndex = 23
        Me.lblEmSalario.Text = "Salario"
        '
        'lblEmSexo
        '
        Me.lblEmSexo.AutoSize = True
        Me.lblEmSexo.Location = New System.Drawing.Point(41, 63)
        Me.lblEmSexo.Name = "lblEmSexo"
        Me.lblEmSexo.Size = New System.Drawing.Size(31, 13)
        Me.lblEmSexo.TabIndex = 22
        Me.lblEmSexo.Text = "Sexo"
        '
        'lblEmNombre
        '
        Me.lblEmNombre.AutoSize = True
        Me.lblEmNombre.Location = New System.Drawing.Point(41, 32)
        Me.lblEmNombre.Name = "lblEmNombre"
        Me.lblEmNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblEmNombre.TabIndex = 21
        Me.lblEmNombre.Text = "Nombre"
        '
        'ActualizarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 287)
        Me.Controls.Add(Me.btnEmCancelar)
        Me.Controls.Add(Me.btnEmAceptar)
        Me.Controls.Add(Me.cboEmPuesto)
        Me.Controls.Add(Me.cboEmHorario)
        Me.Controls.Add(Me.cboEmBodega)
        Me.Controls.Add(Me.cboEmEstatus)
        Me.Controls.Add(Me.txtEmDireccion)
        Me.Controls.Add(Me.txtEmTelefono)
        Me.Controls.Add(Me.txtEmSalario)
        Me.Controls.Add(Me.rbuEmMasculino)
        Me.Controls.Add(Me.rbuEmFemenino)
        Me.Controls.Add(Me.txtEmNombre)
        Me.Controls.Add(Me.lblEmPuesto)
        Me.Controls.Add(Me.lblEmHorario)
        Me.Controls.Add(Me.lblEmBodega)
        Me.Controls.Add(Me.lblEmEstatus)
        Me.Controls.Add(Me.lblEmDireccion)
        Me.Controls.Add(Me.lblEmTelefono)
        Me.Controls.Add(Me.lblEmSalario)
        Me.Controls.Add(Me.lblEmSexo)
        Me.Controls.Add(Me.lblEmNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ActualizarEmpleados"
        Me.Text = "ActualizarEmpleados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEmCancelar As Button
    Friend WithEvents btnEmAceptar As Button
    Friend WithEvents cboEmPuesto As ComboBox
    Friend WithEvents cboEmHorario As ComboBox
    Friend WithEvents cboEmBodega As ComboBox
    Friend WithEvents cboEmEstatus As ComboBox
    Friend WithEvents txtEmDireccion As TextBox
    Friend WithEvents txtEmTelefono As TextBox
    Friend WithEvents txtEmSalario As TextBox
    Friend WithEvents rbuEmMasculino As RadioButton
    Friend WithEvents rbuEmFemenino As RadioButton
    Friend WithEvents txtEmNombre As TextBox
    Friend WithEvents lblEmPuesto As Label
    Friend WithEvents lblEmHorario As Label
    Friend WithEvents lblEmBodega As Label
    Friend WithEvents lblEmEstatus As Label
    Friend WithEvents lblEmDireccion As Label
    Friend WithEvents lblEmTelefono As Label
    Friend WithEvents lblEmSalario As Label
    Friend WithEvents lblEmSexo As Label
    Friend WithEvents lblEmNombre As Label
End Class
