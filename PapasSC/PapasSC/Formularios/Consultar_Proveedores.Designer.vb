<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultar_Proveedores
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
        Me.DataListado = New System.Windows.Forms.DataGridView()
        Me.cboFiltroProve = New System.Windows.Forms.ComboBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.BuscarProve = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnEliminarProvee = New System.Windows.Forms.Button()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filtro Proveedores"
        '
        'DataListado
        '
        Me.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListado.Location = New System.Drawing.Point(34, 63)
        Me.DataListado.Name = "DataListado"
        Me.DataListado.Size = New System.Drawing.Size(612, 260)
        Me.DataListado.TabIndex = 1
        '
        'cboFiltroProve
        '
        Me.cboFiltroProve.FormattingEnabled = True
        Me.cboFiltroProve.Items.AddRange(New Object() {"Nombre Proveedor", "Ciudad"})
        Me.cboFiltroProve.Location = New System.Drawing.Point(129, 17)
        Me.cboFiltroProve.Name = "cboFiltroProve"
        Me.cboFiltroProve.Size = New System.Drawing.Size(175, 21)
        Me.cboFiltroProve.TabIndex = 2
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(326, 19)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(192, 20)
        Me.txtFiltro.TabIndex = 3
        '
        'BuscarProve
        '
        Me.BuscarProve.Location = New System.Drawing.Point(534, 17)
        Me.BuscarProve.Name = "BuscarProve"
        Me.BuscarProve.Size = New System.Drawing.Size(112, 23)
        Me.BuscarProve.TabIndex = 4
        Me.BuscarProve.Text = "Buscar"
        Me.BuscarProve.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Location = New System.Drawing.Point(-1, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "X"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(127, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 36)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Registrar proveedor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(302, 338)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(169, 36)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Actualizar proveedor"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnEliminarProvee
        '
        Me.btnEliminarProvee.Location = New System.Drawing.Point(477, 338)
        Me.btnEliminarProvee.Name = "btnEliminarProvee"
        Me.btnEliminarProvee.Size = New System.Drawing.Size(169, 36)
        Me.btnEliminarProvee.TabIndex = 8
        Me.btnEliminarProvee.Text = "Eliminar Proveedor"
        Me.btnEliminarProvee.UseVisualStyleBackColor = True
        '
        'Consultar_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 386)
        Me.Controls.Add(Me.btnEliminarProvee)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BuscarProve)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.cboFiltroProve)
        Me.Controls.Add(Me.DataListado)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Consultar_Proveedores"
        Me.Text = "Consultar_Proveedores"
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataListado As DataGridView
    Friend WithEvents cboFiltroProve As ComboBox
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents BuscarProve As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnEliminarProvee As Button
End Class
