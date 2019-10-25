<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IniciarCaja
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCajas = New System.Windows.Forms.ComboBox()
        Me.cmbEmpleados = New System.Windows.Forms.ComboBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.chbVer = New System.Windows.Forms.CheckBox()
        Me.btnLiberar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAbrirCaja = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Caja"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Empleado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña"
        '
        'cmbCajas
        '
        Me.cmbCajas.ForeColor = System.Drawing.Color.Black
        Me.cmbCajas.FormattingEnabled = True
        Me.cmbCajas.Location = New System.Drawing.Point(96, 22)
        Me.cmbCajas.Name = "cmbCajas"
        Me.cmbCajas.Size = New System.Drawing.Size(144, 21)
        Me.cmbCajas.TabIndex = 5
        '
        'cmbEmpleados
        '
        Me.cmbEmpleados.FormattingEnabled = True
        Me.cmbEmpleados.Location = New System.Drawing.Point(96, 61)
        Me.cmbEmpleados.Name = "cmbEmpleados"
        Me.cmbEmpleados.Size = New System.Drawing.Size(144, 21)
        Me.cmbEmpleados.TabIndex = 6
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(96, 101)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(144, 20)
        Me.txtContraseña.TabIndex = 7
        Me.txtContraseña.UseSystemPasswordChar = True
        '
        'chbVer
        '
        Me.chbVer.AutoSize = True
        Me.chbVer.Location = New System.Drawing.Point(247, 105)
        Me.chbVer.Name = "chbVer"
        Me.chbVer.Size = New System.Drawing.Size(42, 17)
        Me.chbVer.TabIndex = 10
        Me.chbVer.Text = "Ver"
        Me.chbVer.UseVisualStyleBackColor = True
        '
        'btnLiberar
        '
        Me.btnLiberar.Image = Global.PapasSC.My.Resources.Resources.LIBERAR
        Me.btnLiberar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLiberar.Location = New System.Drawing.Point(236, 151)
        Me.btnLiberar.Name = "btnLiberar"
        Me.btnLiberar.Size = New System.Drawing.Size(75, 41)
        Me.btnLiberar.TabIndex = 11
        Me.btnLiberar.Text = "Liberar"
        Me.btnLiberar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLiberar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.PapasSC.My.Resources.Resources.CANCELAR
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(141, 151)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 41)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAbrirCaja
        '
        Me.btnAbrirCaja.Image = Global.PapasSC.My.Resources.Resources.ACEPTAR
        Me.btnAbrirCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbrirCaja.Location = New System.Drawing.Point(49, 151)
        Me.btnAbrirCaja.Name = "btnAbrirCaja"
        Me.btnAbrirCaja.Size = New System.Drawing.Size(75, 41)
        Me.btnAbrirCaja.TabIndex = 8
        Me.btnAbrirCaja.Text = "Abrir"
        Me.btnAbrirCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAbrirCaja.UseVisualStyleBackColor = True
        '
        'IniciarCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 217)
        Me.Controls.Add(Me.btnLiberar)
        Me.Controls.Add(Me.chbVer)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAbrirCaja)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.cmbEmpleados)
        Me.Controls.Add(Me.cmbCajas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "IniciarCaja"
        Me.Text = "IniciarCaja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbCajas As ComboBox
    Friend WithEvents cmbEmpleados As ComboBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents btnAbrirCaja As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents chbVer As CheckBox
    Friend WithEvents btnLiberar As Button
End Class
