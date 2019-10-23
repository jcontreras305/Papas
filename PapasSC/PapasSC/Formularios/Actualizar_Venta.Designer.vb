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
        Me.npdkilos = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.npdprecio = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tblventaActualizar = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmbBodega = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.npdCantidadPagada = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxRazon = New System.Windows.Forms.CheckBox()
        Me.txtproducto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnProducto = New System.Windows.Forms.Button()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.btnseleccionP = New System.Windows.Forms.Button()
        Me.tblProductosNuevos = New System.Windows.Forms.DataGridView()
        Me.btnQuitarproducto = New System.Windows.Forms.Button()
        Me.btnRealizarCambios = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.npdkilos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdprecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblventaActualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdCantidadPagada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblProductosNuevos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'npdkilos
        '
        Me.npdkilos.Location = New System.Drawing.Point(120, 215)
        Me.npdkilos.Name = "npdkilos"
        Me.npdkilos.Size = New System.Drawing.Size(120, 20)
        Me.npdkilos.TabIndex = 35
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 46)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Guardar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = True
        '
        'npdprecio
        '
        Me.npdprecio.Location = New System.Drawing.Point(120, 252)
        Me.npdprecio.Name = "npdprecio"
        Me.npdprecio.Size = New System.Drawing.Size(120, 20)
        Me.npdprecio.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Precio de Venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Kilogramos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tblventaActualizar
        '
        Me.tblventaActualizar.AllowUserToAddRows = False
        Me.tblventaActualizar.AllowUserToDeleteRows = False
        Me.tblventaActualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblventaActualizar.Location = New System.Drawing.Point(469, 215)
        Me.tblventaActualizar.Name = "tblventaActualizar"
        Me.tblventaActualizar.ReadOnly = True
        Me.tblventaActualizar.Size = New System.Drawing.Size(398, 177)
        Me.tblventaActualizar.TabIndex = 29
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(133, 378)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 46)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Bodega"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Forma de Pago "
        '
        'cmbFormaPago
        '
        Me.cmbFormaPago.FormattingEnabled = True
        Me.cmbFormaPago.Items.AddRange(New Object() {"Credito", "Contado"})
        Me.cmbFormaPago.Location = New System.Drawing.Point(120, 279)
        Me.cmbFormaPago.Name = "cmbFormaPago"
        Me.cmbFormaPago.Size = New System.Drawing.Size(106, 21)
        Me.cmbFormaPago.TabIndex = 50
        Me.cmbFormaPago.Text = "Seleccione"
        '
        'npdCantidadPagada
        '
        Me.npdCantidadPagada.Location = New System.Drawing.Point(120, 311)
        Me.npdCantidadPagada.Name = "npdCantidadPagada"
        Me.npdCantidadPagada.Size = New System.Drawing.Size(106, 20)
        Me.npdCantidadPagada.TabIndex = 52
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 313)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Cantidad Pagada"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.BackColor = System.Drawing.Color.Blue
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.Yellow
        Me.lbltotal.Location = New System.Drawing.Point(362, 387)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(84, 37)
        Me.lbltotal.TabIndex = 54
        Me.lbltotal.Text = "0,00"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(282, 393)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(79, 25)
        Me.lbl.TabIndex = 55
        Me.lbl.Text = "Total: "
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(34, 45)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(147, 20)
        Me.txtNombreCliente.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Cliente "
        '
        'cbxRazon
        '
        Me.cbxRazon.AutoSize = True
        Me.cbxRazon.Location = New System.Drawing.Point(34, 71)
        Me.cbxRazon.Name = "cbxRazon"
        Me.cbxRazon.Size = New System.Drawing.Size(147, 17)
        Me.cbxRazon.TabIndex = 57
        Me.cbxRazon.Text = "Clientes por Razon Social"
        Me.cbxRazon.UseVisualStyleBackColor = True
        '
        'txtproducto
        '
        Me.txtproducto.Location = New System.Drawing.Point(34, 115)
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(147, 20)
        Me.txtproducto.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Producto"
        '
        'btnProducto
        '
        Me.btnProducto.Location = New System.Drawing.Point(351, 59)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(112, 38)
        Me.btnProducto.TabIndex = 61
        Me.btnProducto.Text = "Agregar Producto"
        Me.btnProducto.UseVisualStyleBackColor = True
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = Global.PapasSC.My.Resources.Resources.empleadosButton
        Me.btnBuscarCliente.Location = New System.Drawing.Point(187, 22)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(59, 53)
        Me.btnBuscarCliente.TabIndex = 58
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'btnseleccionP
        '
        Me.btnseleccionP.Location = New System.Drawing.Point(186, 104)
        Me.btnseleccionP.Name = "btnseleccionP"
        Me.btnseleccionP.Size = New System.Drawing.Size(125, 38)
        Me.btnseleccionP.TabIndex = 63
        Me.btnseleccionP.Text = "Seleccionar otro producto"
        Me.btnseleccionP.UseVisualStyleBackColor = True
        '
        'tblProductosNuevos
        '
        Me.tblProductosNuevos.AllowUserToAddRows = False
        Me.tblProductosNuevos.AllowUserToDeleteRows = False
        Me.tblProductosNuevos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblProductosNuevos.Location = New System.Drawing.Point(469, 22)
        Me.tblProductosNuevos.Name = "tblProductosNuevos"
        Me.tblProductosNuevos.ReadOnly = True
        Me.tblProductosNuevos.Size = New System.Drawing.Size(398, 165)
        Me.tblProductosNuevos.TabIndex = 64
        '
        'btnQuitarproducto
        '
        Me.btnQuitarproducto.Location = New System.Drawing.Point(351, 313)
        Me.btnQuitarproducto.Name = "btnQuitarproducto"
        Me.btnQuitarproducto.Size = New System.Drawing.Size(112, 38)
        Me.btnQuitarproducto.TabIndex = 65
        Me.btnQuitarproducto.Text = "Quitar Producto"
        Me.btnQuitarproducto.UseVisualStyleBackColor = True
        '
        'btnRealizarCambios
        '
        Me.btnRealizarCambios.Location = New System.Drawing.Point(351, 269)
        Me.btnRealizarCambios.Name = "btnRealizarCambios"
        Me.btnRealizarCambios.Size = New System.Drawing.Size(112, 38)
        Me.btnRealizarCambios.TabIndex = 66
        Me.btnRealizarCambios.Text = "Realizar Cambios"
        Me.btnRealizarCambios.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(351, 103)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 38)
        Me.Button4.TabIndex = 67
        Me.Button4.Text = "Quitar Producto"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Actualizar_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 526)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnRealizarCambios)
        Me.Controls.Add(Me.btnQuitarproducto)
        Me.Controls.Add(Me.tblProductosNuevos)
        Me.Controls.Add(Me.btnseleccionP)
        Me.Controls.Add(Me.txtproducto)
        Me.Controls.Add(Me.btnProducto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbxRazon)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.npdCantidadPagada)
        Me.Controls.Add(Me.cmbFormaPago)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbBodega)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.tblventaActualizar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.npdprecio)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.npdkilos)
        Me.Name = "Actualizar_Venta"
        Me.Text = "v"
        CType(Me.npdkilos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdprecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblventaActualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdCantidadPagada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblProductosNuevos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents npdkilos As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents npdprecio As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tblventaActualizar As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents cmbBodega As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbFormaPago As ComboBox
    Friend WithEvents npdCantidadPagada As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents lbl As Label
    Public WithEvents txtNombreCliente As TextBox
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxRazon As CheckBox
    Public WithEvents txtproducto As TextBox
    Friend WithEvents btnProducto As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnseleccionP As Button
    Friend WithEvents tblProductosNuevos As DataGridView
    Friend WithEvents btnQuitarproducto As Button
    Friend WithEvents btnRealizarCambios As Button
    Friend WithEvents Button4 As Button
End Class
