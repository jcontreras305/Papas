<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Horario
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rtxDescripcion = New System.Windows.Forms.RichTextBox()
        Me.txtNombreHo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEntrada = New System.Windows.Forms.TextBox()
        Me.lblSalidad = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripcion"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSalidad)
        Me.GroupBox1.Controls.Add(Me.lblEntrada)
        Me.GroupBox1.Controls.Add(Me.rtxDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtNombreHo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 196)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Horario"
        '
        'rtxDescripcion
        '
        Me.rtxDescripcion.Location = New System.Drawing.Point(88, 51)
        Me.rtxDescripcion.Name = "rtxDescripcion"
        Me.rtxDescripcion.Size = New System.Drawing.Size(160, 68)
        Me.rtxDescripcion.TabIndex = 12
        Me.rtxDescripcion.Text = ""
        '
        'txtNombreHo
        '
        Me.txtNombreHo.Location = New System.Drawing.Point(88, 25)
        Me.txtNombreHo.Name = "txtNombreHo"
        Me.txtNombreHo.Size = New System.Drawing.Size(160, 20)
        Me.txtNombreHo.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label9.Location = New System.Drawing.Point(321, -1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 24)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "X"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Salidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Entrada"
        '
        'lblEntrada
        '
        Me.lblEntrada.Location = New System.Drawing.Point(88, 131)
        Me.lblEntrada.Name = "lblEntrada"
        Me.lblEntrada.Size = New System.Drawing.Size(160, 20)
        Me.lblEntrada.TabIndex = 13
        '
        'lblSalidad
        '
        Me.lblSalidad.Location = New System.Drawing.Point(88, 158)
        Me.lblSalidad.Name = "lblSalidad"
        Me.lblSalidad.Size = New System.Drawing.Size(160, 20)
        Me.lblSalidad.TabIndex = 14
        '
        'Horario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 260)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Horario"
        Me.Text = "Horario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNombreHo As TextBox
    Friend WithEvents rtxDescripcion As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblSalidad As TextBox
    Friend WithEvents lblEntrada As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
