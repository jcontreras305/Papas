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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarEmpleados))
        Me.lblEmNombre = New System.Windows.Forms.Label()
        Me.lblEmSexo = New System.Windows.Forms.Label()
        Me.lblEmSalario = New System.Windows.Forms.Label()
        Me.lblEmTelefono = New System.Windows.Forms.Label()
        Me.lblEmDireccion = New System.Windows.Forms.Label()
        Me.lblEmEstatus = New System.Windows.Forms.Label()
        Me.lblEmBodega = New System.Windows.Forms.Label()
        Me.lblEmHorario = New System.Windows.Forms.Label()
        Me.lblEmPuesto = New System.Windows.Forms.Label()
        Me.txtEmNombre = New System.Windows.Forms.TextBox()
        Me.rbuEmFemenino = New System.Windows.Forms.RadioButton()
        Me.rbuEmMasculino = New System.Windows.Forms.RadioButton()
        Me.txtEmSalario = New System.Windows.Forms.TextBox()
        Me.txtEmTelefono = New System.Windows.Forms.TextBox()
        Me.txtEmDireccion = New System.Windows.Forms.TextBox()
        Me.cboEmEstatus = New System.Windows.Forms.ComboBox()
        Me.cboEmBodega = New System.Windows.Forms.ComboBox()
        Me.cboEmHorario = New System.Windows.Forms.ComboBox()
        Me.cboEmPuesto = New System.Windows.Forms.ComboBox()
        Me.btnEmAceptar = New System.Windows.Forms.Button()
        Me.btnEmCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEmNombre
        '
        Me.lblEmNombre.AutoSize = True
        Me.lblEmNombre.Location = New System.Drawing.Point(42, 34)
        Me.lblEmNombre.Name = "lblEmNombre"
        Me.lblEmNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblEmNombre.TabIndex = 0
        Me.lblEmNombre.Text = "Nombre"
        '
        'lblEmSexo
        '
        Me.lblEmSexo.AutoSize = True
        Me.lblEmSexo.Location = New System.Drawing.Point(42, 65)
        Me.lblEmSexo.Name = "lblEmSexo"
        Me.lblEmSexo.Size = New System.Drawing.Size(31, 13)
        Me.lblEmSexo.TabIndex = 1
        Me.lblEmSexo.Text = "Sexo"
        '
        'lblEmSalario
        '
        Me.lblEmSalario.AutoSize = True
        Me.lblEmSalario.Location = New System.Drawing.Point(42, 101)
        Me.lblEmSalario.Name = "lblEmSalario"
        Me.lblEmSalario.Size = New System.Drawing.Size(39, 13)
        Me.lblEmSalario.TabIndex = 2
        Me.lblEmSalario.Text = "Salario"
        '
        'lblEmTelefono
        '
        Me.lblEmTelefono.AutoSize = True
        Me.lblEmTelefono.Location = New System.Drawing.Point(37, 150)
        Me.lblEmTelefono.Name = "lblEmTelefono"
        Me.lblEmTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblEmTelefono.TabIndex = 3
        Me.lblEmTelefono.Text = "Teléfono"
        '
        'lblEmDireccion
        '
        Me.lblEmDireccion.AutoSize = True
        Me.lblEmDireccion.Location = New System.Drawing.Point(37, 190)
        Me.lblEmDireccion.Name = "lblEmDireccion"
        Me.lblEmDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblEmDireccion.TabIndex = 4
        Me.lblEmDireccion.Text = "Dirección"
        '
        'lblEmEstatus
        '
        Me.lblEmEstatus.AutoSize = True
        Me.lblEmEstatus.Location = New System.Drawing.Point(39, 228)
        Me.lblEmEstatus.Name = "lblEmEstatus"
        Me.lblEmEstatus.Size = New System.Drawing.Size(42, 13)
        Me.lblEmEstatus.TabIndex = 5
        Me.lblEmEstatus.Text = "Estatus"
        '
        'lblEmBodega
        '
        Me.lblEmBodega.AutoSize = True
        Me.lblEmBodega.Location = New System.Drawing.Point(383, 34)
        Me.lblEmBodega.Name = "lblEmBodega"
        Me.lblEmBodega.Size = New System.Drawing.Size(44, 13)
        Me.lblEmBodega.TabIndex = 6
        Me.lblEmBodega.Text = "Bodega"
        '
        'lblEmHorario
        '
        Me.lblEmHorario.AutoSize = True
        Me.lblEmHorario.Location = New System.Drawing.Point(383, 79)
        Me.lblEmHorario.Name = "lblEmHorario"
        Me.lblEmHorario.Size = New System.Drawing.Size(41, 13)
        Me.lblEmHorario.TabIndex = 7
        Me.lblEmHorario.Text = "Horario"
        '
        'lblEmPuesto
        '
        Me.lblEmPuesto.AutoSize = True
        Me.lblEmPuesto.Location = New System.Drawing.Point(383, 131)
        Me.lblEmPuesto.Name = "lblEmPuesto"
        Me.lblEmPuesto.Size = New System.Drawing.Size(40, 13)
        Me.lblEmPuesto.TabIndex = 8
        Me.lblEmPuesto.Text = "Puesto"
        '
        'txtEmNombre
        '
        Me.txtEmNombre.Location = New System.Drawing.Point(109, 34)
        Me.txtEmNombre.Name = "txtEmNombre"
        Me.txtEmNombre.Size = New System.Drawing.Size(168, 20)
        Me.txtEmNombre.TabIndex = 9
        '
        'rbuEmFemenino
        '
        Me.rbuEmFemenino.AutoSize = True
        Me.rbuEmFemenino.Location = New System.Drawing.Point(109, 65)
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
        Me.rbuEmMasculino.Location = New System.Drawing.Point(204, 65)
        Me.rbuEmMasculino.Name = "rbuEmMasculino"
        Me.rbuEmMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rbuEmMasculino.TabIndex = 11
        Me.rbuEmMasculino.TabStop = True
        Me.rbuEmMasculino.Text = "Masculino"
        Me.rbuEmMasculino.UseVisualStyleBackColor = True
        '
        'txtEmSalario
        '
        Me.txtEmSalario.Location = New System.Drawing.Point(109, 98)
        Me.txtEmSalario.Name = "txtEmSalario"
        Me.txtEmSalario.Size = New System.Drawing.Size(168, 20)
        Me.txtEmSalario.TabIndex = 12
        '
        'txtEmTelefono
        '
        Me.txtEmTelefono.Location = New System.Drawing.Point(109, 147)
        Me.txtEmTelefono.Name = "txtEmTelefono"
        Me.txtEmTelefono.Size = New System.Drawing.Size(168, 20)
        Me.txtEmTelefono.TabIndex = 13
        '
        'txtEmDireccion
        '
        Me.txtEmDireccion.Location = New System.Drawing.Point(109, 190)
        Me.txtEmDireccion.Name = "txtEmDireccion"
        Me.txtEmDireccion.Size = New System.Drawing.Size(168, 20)
        Me.txtEmDireccion.TabIndex = 14
        '
        'cboEmEstatus
        '
        Me.cboEmEstatus.FormattingEnabled = True
        Me.cboEmEstatus.Location = New System.Drawing.Point(109, 228)
        Me.cboEmEstatus.Name = "cboEmEstatus"
        Me.cboEmEstatus.Size = New System.Drawing.Size(71, 21)
        Me.cboEmEstatus.TabIndex = 15
        '
        'cboEmBodega
        '
        Me.cboEmBodega.FormattingEnabled = True
        Me.cboEmBodega.Location = New System.Drawing.Point(453, 34)
        Me.cboEmBodega.Name = "cboEmBodega"
        Me.cboEmBodega.Size = New System.Drawing.Size(169, 21)
        Me.cboEmBodega.TabIndex = 16
        '
        'cboEmHorario
        '
        Me.cboEmHorario.FormattingEnabled = True
        Me.cboEmHorario.Location = New System.Drawing.Point(453, 79)
        Me.cboEmHorario.Name = "cboEmHorario"
        Me.cboEmHorario.Size = New System.Drawing.Size(169, 21)
        Me.cboEmHorario.TabIndex = 17
        '
        'cboEmPuesto
        '
        Me.cboEmPuesto.FormattingEnabled = True
        Me.cboEmPuesto.Location = New System.Drawing.Point(453, 128)
        Me.cboEmPuesto.Name = "cboEmPuesto"
        Me.cboEmPuesto.Size = New System.Drawing.Size(169, 21)
        Me.cboEmPuesto.TabIndex = 18
        '
        'btnEmAceptar
        '
        Me.btnEmAceptar.Location = New System.Drawing.Point(453, 226)
        Me.btnEmAceptar.Name = "btnEmAceptar"
        Me.btnEmAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnEmAceptar.TabIndex = 19
        Me.btnEmAceptar.Text = "Aceptar"
        Me.btnEmAceptar.UseVisualStyleBackColor = True
        '
        'btnEmCancelar
        '
        Me.btnEmCancelar.Location = New System.Drawing.Point(547, 226)
        Me.btnEmCancelar.Name = "btnEmCancelar"
        Me.btnEmCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnEmCancelar.TabIndex = 20
        Me.btnEmCancelar.Text = "Cancelar"
        Me.btnEmCancelar.UseVisualStyleBackColor = True
        '
        'AgregarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 278)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AgregarEmpleados"
        Me.Text = "AgregarEmpleados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEmNombre As Label
    Friend WithEvents lblEmSexo As Label
    Friend WithEvents lblEmSalario As Label
    Friend WithEvents lblEmTelefono As Label
    Friend WithEvents lblEmDireccion As Label
    Friend WithEvents lblEmEstatus As Label
    Friend WithEvents lblEmBodega As Label
    Friend WithEvents lblEmHorario As Label
    Friend WithEvents lblEmPuesto As Label
    Friend WithEvents txtEmNombre As TextBox
    Friend WithEvents rbuEmFemenino As RadioButton
    Friend WithEvents rbuEmMasculino As RadioButton
    Friend WithEvents txtEmSalario As TextBox
    Friend WithEvents txtEmTelefono As TextBox
    Friend WithEvents txtEmDireccion As TextBox
    Friend WithEvents cboEmEstatus As ComboBox
    Friend WithEvents cboEmBodega As ComboBox
    Friend WithEvents cboEmHorario As ComboBox
    Friend WithEvents cboEmPuesto As ComboBox
    Friend WithEvents btnEmAceptar As Button
    Friend WithEvents btnEmCancelar As Button
End Class
