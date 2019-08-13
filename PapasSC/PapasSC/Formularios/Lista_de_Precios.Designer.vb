<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lista_de_Precios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista_de_Precios))
        Me.tablaprecios = New System.Windows.Forms.DataGridView()
        Me.Actualizar_precio = New System.Windows.Forms.Button()
        Me.npd = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.filtroproductos = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.tablaprecios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tablaprecios
        '
        Me.tablaprecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaprecios.Location = New System.Drawing.Point(12, 71)
        Me.tablaprecios.Name = "tablaprecios"
        Me.tablaprecios.Size = New System.Drawing.Size(776, 230)
        Me.tablaprecios.TabIndex = 0
        '
        'Actualizar_precio
        '
        Me.Actualizar_precio.Location = New System.Drawing.Point(177, 310)
        Me.Actualizar_precio.Name = "Actualizar_precio"
        Me.Actualizar_precio.Size = New System.Drawing.Size(145, 32)
        Me.Actualizar_precio.TabIndex = 1
        Me.Actualizar_precio.Text = "Actualizar precio"
        Me.Actualizar_precio.UseVisualStyleBackColor = True
        '
        'npd
        '
        Me.npd.Location = New System.Drawing.Point(12, 318)
        Me.npd.Name = "npd"
        Me.npd.Size = New System.Drawing.Size(159, 20)
        Me.npd.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(602, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'filtroproductos
        '
        Me.filtroproductos.FormattingEnabled = True
        Me.filtroproductos.Items.AddRange(New Object() {"Estatus", "Nombre", "Clave", "ID del producto."})
        Me.filtroproductos.Location = New System.Drawing.Point(106, 27)
        Me.filtroproductos.Name = "filtroproductos"
        Me.filtroproductos.Size = New System.Drawing.Size(121, 21)
        Me.filtroproductos.TabIndex = 7
        Me.filtroproductos.Text = "Filtro Producto"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(233, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(363, 20)
        Me.TextBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tipo de producto"
        '
        'Lista_de_Precios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 365)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.filtroproductos)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.npd)
        Me.Controls.Add(Me.Actualizar_precio)
        Me.Controls.Add(Me.tablaprecios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Lista_de_Precios"
        Me.Text = "Lista_de_Precios"
        CType(Me.tablaprecios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tablaprecios As DataGridView
    Friend WithEvents Actualizar_precio As Button
    Friend WithEvents npd As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents filtroproductos As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
