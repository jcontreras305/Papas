<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_Cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consulta_Cliente))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FiltroClientes = New System.Windows.Forms.ComboBox()
        Me.TablaCLientes = New System.Windows.Forms.DataGridView()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.TablaCLientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filtro Clientes"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(243, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(333, 20)
        Me.TextBox1.TabIndex = 3
        '
        'FiltroClientes
        '
        Me.FiltroClientes.FormattingEnabled = True
        Me.FiltroClientes.Items.AddRange(New Object() {"Nombre Cliente", "Tipo de Cliente", "Razon Social", "Alias contacto", "RFC", "Limite de credito", "Dias de credito", "Clave Cliente"})
        Me.FiltroClientes.Location = New System.Drawing.Point(87, 6)
        Me.FiltroClientes.Name = "FiltroClientes"
        Me.FiltroClientes.Size = New System.Drawing.Size(150, 21)
        Me.FiltroClientes.TabIndex = 4
        Me.FiltroClientes.Text = "Selecion de filtro"
        '
        'TablaCLientes
        '
        Me.TablaCLientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaCLientes.Location = New System.Drawing.Point(50, 61)
        Me.TablaCLientes.Name = "TablaCLientes"
        Me.TablaCLientes.Size = New System.Drawing.Size(682, 323)
        Me.TablaCLientes.TabIndex = 5
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(582, 4)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(191, 23)
        Me.Buscar.TabIndex = 6
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(243, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 36)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Registrar Cliente"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(418, 402)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(169, 36)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Actualizar Cliente"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(593, 402)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(169, 36)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Eliminar Cliente"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Consulta_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.TablaCLientes)
        Me.Controls.Add(Me.FiltroClientes)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Consulta_Cliente"
        Me.Text = "Clientes"
        CType(Me.TablaCLientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents FiltroClientes As ComboBox
    Friend WithEvents TablaCLientes As DataGridView
    Friend WithEvents Buscar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
