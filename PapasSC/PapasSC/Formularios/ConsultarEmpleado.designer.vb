<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultarEmpleado
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
        Me.DataListado = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNombreE = New System.Windows.Forms.Button()
        Me.filtro = New System.Windows.Forms.ComboBox()
        Me.txtNombreEm = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataListado
        '
        Me.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListado.Location = New System.Drawing.Point(31, 65)
        Me.DataListado.Name = "DataListado"
        Me.DataListado.Size = New System.Drawing.Size(739, 292)
        Me.DataListado.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Filtro Empleados"
        '
        'btnNombreE
        '
        Me.btnNombreE.Location = New System.Drawing.Point(519, 15)
        Me.btnNombreE.Name = "btnNombreE"
        Me.btnNombreE.Size = New System.Drawing.Size(112, 23)
        Me.btnNombreE.TabIndex = 4
        Me.btnNombreE.Text = "Buscar"
        Me.btnNombreE.UseVisualStyleBackColor = True
        '
        'filtro
        '
        Me.filtro.FormattingEnabled = True
        Me.filtro.Items.AddRange(New Object() {"Nombre del empleado", "Bodega", "Puesto", "Salario"})
        Me.filtro.Location = New System.Drawing.Point(118, 17)
        Me.filtro.Name = "filtro"
        Me.filtro.Size = New System.Drawing.Size(175, 21)
        Me.filtro.TabIndex = 7
        Me.filtro.Text = "Seleccion de filtro"
        '
        'txtNombreEm
        '
        Me.txtNombreEm.Location = New System.Drawing.Point(309, 17)
        Me.txtNombreEm.Name = "txtNombreEm"
        Me.txtNombreEm.Size = New System.Drawing.Size(192, 20)
        Me.txtNombreEm.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(651, 365)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 32)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Eliminar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(539, 365)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 32)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Actualizar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ConsultarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 405)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtNombreEm)
        Me.Controls.Add(Me.filtro)
        Me.Controls.Add(Me.btnNombreE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataListado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConsultarEmpleado"
        Me.Text = "ConsultarEmpleado"
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataListado As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNombreE As Button
    Friend WithEvents filtro As ComboBox
    Friend WithEvents txtNombreEm As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
