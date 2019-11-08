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
        Me.tblEmple = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNombreE = New System.Windows.Forms.Button()
        Me.filtro = New System.Windows.Forms.ComboBox()
        Me.txtNombreEm = New System.Windows.Forms.TextBox()
        Me.btnEliminarEm = New System.Windows.Forms.Button()
        Me.btnActualizarEmple = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.tblEmple, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblEmple
        '
        Me.tblEmple.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblEmple.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblEmple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblEmple.Location = New System.Drawing.Point(31, 54)
        Me.tblEmple.Name = "tblEmple"
        Me.tblEmple.Size = New System.Drawing.Size(739, 292)
        Me.tblEmple.TabIndex = 0
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
        Me.btnNombreE.Location = New System.Drawing.Point(561, 15)
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
        Me.txtNombreEm.Size = New System.Drawing.Size(234, 20)
        Me.txtNombreEm.TabIndex = 8
        '
        'btnEliminarEm
        '
        Me.btnEliminarEm.Location = New System.Drawing.Point(651, 365)
        Me.btnEliminarEm.Name = "btnEliminarEm"
        Me.btnEliminarEm.Size = New System.Drawing.Size(119, 32)
        Me.btnEliminarEm.TabIndex = 9
        Me.btnEliminarEm.Text = "Eliminar"
        Me.btnEliminarEm.UseVisualStyleBackColor = True
        '
        'btnActualizarEmple
        '
        Me.btnActualizarEmple.Location = New System.Drawing.Point(539, 365)
        Me.btnActualizarEmple.Name = "btnActualizarEmple"
        Me.btnActualizarEmple.Size = New System.Drawing.Size(106, 32)
        Me.btnActualizarEmple.TabIndex = 10
        Me.btnActualizarEmple.Text = "Actualizar"
        Me.btnActualizarEmple.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Location = New System.Drawing.Point(1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "X"
        '
        'ConsultarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 405)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnActualizarEmple)
        Me.Controls.Add(Me.btnEliminarEm)
        Me.Controls.Add(Me.txtNombreEm)
        Me.Controls.Add(Me.filtro)
        Me.Controls.Add(Me.btnNombreE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tblEmple)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConsultarEmpleado"
        Me.Text = "ConsultarEmpleado"
        CType(Me.tblEmple, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tblEmple As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNombreE As Button
    Friend WithEvents filtro As ComboBox
    Friend WithEvents txtNombreEm As TextBox
    Friend WithEvents btnEliminarEm As Button
    Friend WithEvents btnActualizarEmple As Button
    Friend WithEvents Label2 As Label
End Class
