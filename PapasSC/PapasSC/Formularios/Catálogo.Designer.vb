<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Catálogo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Catálogo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.productos = New System.Windows.Forms.Button()
        Me.clientes = New System.Windows.Forms.Button()
        Me.descuentos = New System.Windows.Forms.Button()
        Me.listadeprecios = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(392, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Catálogo"
        '
        'productos
        '
        Me.productos.AccessibleRole = System.Windows.Forms.AccessibleRole.Border
        Me.productos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.productos.FlatAppearance.BorderSize = 0
        Me.productos.Image = CType(resources.GetObject("productos.Image"), System.Drawing.Image)
        Me.productos.Location = New System.Drawing.Point(113, 123)
        Me.productos.Name = "productos"
        Me.productos.Size = New System.Drawing.Size(169, 169)
        Me.productos.TabIndex = 1
        Me.productos.UseVisualStyleBackColor = True
        '
        'clientes
        '
        Me.clientes.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.clientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clientes.FlatAppearance.BorderSize = 0
        Me.clientes.Image = CType(resources.GetObject("clientes.Image"), System.Drawing.Image)
        Me.clientes.Location = New System.Drawing.Point(396, 123)
        Me.clientes.Name = "clientes"
        Me.clientes.Size = New System.Drawing.Size(169, 169)
        Me.clientes.TabIndex = 2
        Me.clientes.UseVisualStyleBackColor = False
        '
        'descuentos
        '
        Me.descuentos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.descuentos.FlatAppearance.BorderSize = 0
        Me.descuentos.Image = CType(resources.GetObject("descuentos.Image"), System.Drawing.Image)
        Me.descuentos.Location = New System.Drawing.Point(247, 416)
        Me.descuentos.Name = "descuentos"
        Me.descuentos.Size = New System.Drawing.Size(169, 169)
        Me.descuentos.TabIndex = 3
        Me.descuentos.UseVisualStyleBackColor = True
        '
        'listadeprecios
        '
        Me.listadeprecios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.listadeprecios.FlatAppearance.BorderSize = 0
        Me.listadeprecios.Image = CType(resources.GetObject("listadeprecios.Image"), System.Drawing.Image)
        Me.listadeprecios.Location = New System.Drawing.Point(666, 123)
        Me.listadeprecios.Name = "listadeprecios"
        Me.listadeprecios.Size = New System.Drawing.Size(169, 169)
        Me.listadeprecios.TabIndex = 4
        Me.listadeprecios.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(536, 416)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(169, 169)
        Me.Button5.TabIndex = 5
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "X"
        '
        'Catálogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(875, 465)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.listadeprecios)
        Me.Controls.Add(Me.descuentos)
        Me.Controls.Add(Me.clientes)
        Me.Controls.Add(Me.productos)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Catálogo"
        Me.Text = "Catálogo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents productos As Button
    Friend WithEvents clientes As Button
    Friend WithEvents descuentos As Button
    Friend WithEvents listadeprecios As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
End Class
