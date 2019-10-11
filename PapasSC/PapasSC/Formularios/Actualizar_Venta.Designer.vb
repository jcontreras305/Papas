<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actualizar_Venta
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbBodega = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.tblventaActualizar = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.l = New System.Windows.Forms.Label()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.npdprecio = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.npdkilos = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.npdCantidadPagada = New System.Windows.Forms.NumericUpDown()
        Me.cmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.tblventaActualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdprecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdkilos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdCantidadPagada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Bodega"
        '
        'cmbBodega
        '
        Me.cmbBodega.FormattingEnabled = True
        Me.cmbBodega.Location = New System.Drawing.Point(36, 170)
        Me.cmbBodega.Name = "cmbBodega"
        Me.cmbBodega.Size = New System.Drawing.Size(193, 21)
        Me.cmbBodega.TabIndex = 47
        Me.cmbBodega.Text = "Selecciona"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(133, 306)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 46)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(249, 178)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(82, 13)
        Me.lblTotal.TabIndex = 39
        Me.lblTotal.Text = "Cantidad Total: "
        '
        'tblventaActualizar
        '
        Me.tblventaActualizar.AllowUserToAddRows = False
        Me.tblventaActualizar.AllowUserToDeleteRows = False
        Me.tblventaActualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblventaActualizar.Location = New System.Drawing.Point(458, 31)
        Me.tblventaActualizar.Name = "tblventaActualizar"
        Me.tblventaActualizar.ReadOnly = True
        Me.tblventaActualizar.Size = New System.Drawing.Size(469, 398)
        Me.tblventaActualizar.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Kilogramos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'l
        '
        Me.l.AutoSize = True
        Me.l.Location = New System.Drawing.Point(32, 101)
        Me.l.Name = "l"
        Me.l.Size = New System.Drawing.Size(50, 13)
        Me.l.TabIndex = 38
        Me.l.Text = "Producto"
        '
        'cmbCliente
        '
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(34, 68)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(193, 21)
        Me.cmbCliente.TabIndex = 31
        Me.cmbCliente.Text = "Selecciona"
        '
        'cmbProducto
        '
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(34, 117)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(193, 21)
        Me.cmbProducto.TabIndex = 32
        Me.cmbProducto.Text = "Selecciona"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Precio de Venta"
        '
        'npdprecio
        '
        Me.npdprecio.Location = New System.Drawing.Point(123, 251)
        Me.npdprecio.Name = "npdprecio"
        Me.npdprecio.Size = New System.Drawing.Size(120, 20)
        Me.npdprecio.TabIndex = 34
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 306)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 46)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Guardar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = True
        '
        'npdkilos
        '
        Me.npdkilos.Location = New System.Drawing.Point(92, 210)
        Me.npdkilos.Name = "npdkilos"
        Me.npdkilos.Size = New System.Drawing.Size(120, 20)
        Me.npdkilos.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Cliente "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(249, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Cantidad Pagada"
        '
        'npdCantidadPagada
        '
        Me.npdCantidadPagada.Location = New System.Drawing.Point(252, 133)
        Me.npdCantidadPagada.Name = "npdCantidadPagada"
        Me.npdCantidadPagada.Size = New System.Drawing.Size(106, 20)
        Me.npdCantidadPagada.TabIndex = 52
        '
        'cmbFormaPago
        '
        Me.cmbFormaPago.FormattingEnabled = True
        Me.cmbFormaPago.Items.AddRange(New Object() {"Credito", "Contado"})
        Me.cmbFormaPago.Location = New System.Drawing.Point(252, 68)
        Me.cmbFormaPago.Name = "cmbFormaPago"
        Me.cmbFormaPago.Size = New System.Drawing.Size(106, 21)
        Me.cmbFormaPago.TabIndex = 50
        Me.cmbFormaPago.Text = "Seleccione"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(249, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Forma de Pago "
        '
        'Actualizar_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 458)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.npdCantidadPagada)
        Me.Controls.Add(Me.cmbFormaPago)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbBodega)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.tblventaActualizar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.l)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.cmbProducto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.npdprecio)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.npdkilos)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Actualizar_Venta"
        Me.Text = "Actualizar_Venta"
        CType(Me.tblventaActualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdprecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdkilos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdCantidadPagada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbBodega As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents tblventaActualizar As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents l As Label
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents cmbProducto As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents npdprecio As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents npdkilos As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents npdCantidadPagada As NumericUpDown
    Friend WithEvents cmbFormaPago As ComboBox
    Friend WithEvents Label7 As Label
End Class
