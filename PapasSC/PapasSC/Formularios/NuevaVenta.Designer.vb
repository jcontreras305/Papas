<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaVenta
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
        Me.tblventa = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.npdprecio = New System.Windows.Forms.NumericUpDown()
        Me.npdkilos = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxRazon = New System.Windows.Forms.CheckBox()
        Me.cmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxEspera = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.npdCantidadPagada = New System.Windows.Forms.NumericUpDown()
        Me.txbFiltro = New System.Windows.Forms.TextBox()
        Me.tblProductos = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbBodega = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.cmbFiltroVenta = New System.Windows.Forms.ComboBox()
        Me.tbxBusquedaFiltrada = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.tblDetalleVenta = New System.Windows.Forms.DataGridView()
        CType(Me.tblventa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdprecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdkilos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.npdCantidadPagada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.tblDetalleVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblventa
        '
        Me.tblventa.AllowUserToAddRows = False
        Me.tblventa.AllowUserToDeleteRows = False
        Me.tblventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblventa.Location = New System.Drawing.Point(523, 49)
        Me.tblventa.Name = "tblventa"
        Me.tblventa.ReadOnly = True
        Me.tblventa.Size = New System.Drawing.Size(378, 398)
        Me.tblventa.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(281, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kilogramos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(281, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Precio de Venta"
        '
        'npdprecio
        '
        Me.npdprecio.Location = New System.Drawing.Point(364, 73)
        Me.npdprecio.Name = "npdprecio"
        Me.npdprecio.Size = New System.Drawing.Size(120, 20)
        Me.npdprecio.TabIndex = 7
        '
        'npdkilos
        '
        Me.npdkilos.Location = New System.Drawing.Point(364, 47)
        Me.npdkilos.Name = "npdkilos"
        Me.npdkilos.Size = New System.Drawing.Size(120, 20)
        Me.npdkilos.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(926, 401)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 46)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Guardar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1163, 565)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button8)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.txbFiltro)
        Me.TabPage1.Controls.Add(Me.tblProductos)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.cmbBodega)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.tblventa)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.npdprecio)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.npdkilos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1155, 539)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "PDV"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(298, 174)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(186, 44)
        Me.Button8.TabIndex = 34
        Me.Button8.Text = "<<"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNombreCliente)
        Me.GroupBox1.Controls.Add(Me.btnBuscarCliente)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbxRazon)
        Me.GroupBox1.Controls.Add(Me.cmbFormaPago)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbxEspera)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lbl)
        Me.GroupBox1.Controls.Add(Me.npdCantidadPagada)
        Me.GroupBox1.Location = New System.Drawing.Point(907, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 358)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(16, 33)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(147, 20)
        Me.txtNombreCliente.TabIndex = 31
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = Global.PapasSC.My.Resources.Resources.empleadosButton
        Me.btnBuscarCliente.Location = New System.Drawing.Point(169, 10)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(48, 53)
        Me.btnBuscarCliente.TabIndex = 30
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Blue
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Yellow
        Me.lblTotal.Location = New System.Drawing.Point(89, 264)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(84, 37)
        Me.lblTotal.TabIndex = 29
        Me.lblTotal.Text = "0,00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Cliente "
        '
        'cbxRazon
        '
        Me.cbxRazon.AutoSize = True
        Me.cbxRazon.Location = New System.Drawing.Point(16, 59)
        Me.cbxRazon.Name = "cbxRazon"
        Me.cbxRazon.Size = New System.Drawing.Size(147, 17)
        Me.cbxRazon.TabIndex = 28
        Me.cbxRazon.Text = "Clientes por Razon Social"
        Me.cbxRazon.UseVisualStyleBackColor = True
        '
        'cmbFormaPago
        '
        Me.cmbFormaPago.FormattingEnabled = True
        Me.cmbFormaPago.Items.AddRange(New Object() {"Credito", "Contado"})
        Me.cmbFormaPago.Location = New System.Drawing.Point(96, 84)
        Me.cmbFormaPago.Name = "cmbFormaPago"
        Me.cmbFormaPago.Size = New System.Drawing.Size(106, 21)
        Me.cmbFormaPago.TabIndex = 22
        Me.cmbFormaPago.Text = "Seleccione"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Forma de Pago "
        '
        'cbxEspera
        '
        Me.cbxEspera.AutoSize = True
        Me.cbxEspera.Location = New System.Drawing.Point(19, 341)
        Me.cbxEspera.Name = "cbxEspera"
        Me.cbxEspera.Size = New System.Drawing.Size(77, 17)
        Me.cbxEspera.TabIndex = 19
        Me.cbxEspera.Text = "En espera."
        Me.cbxEspera.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Cantidad Pagada"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(14, 264)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(79, 25)
        Me.lbl.TabIndex = 18
        Me.lbl.Text = "Total: "
        '
        'npdCantidadPagada
        '
        Me.npdCantidadPagada.Location = New System.Drawing.Point(108, 161)
        Me.npdCantidadPagada.Name = "npdCantidadPagada"
        Me.npdCantidadPagada.Size = New System.Drawing.Size(106, 20)
        Me.npdCantidadPagada.TabIndex = 24
        '
        'txbFiltro
        '
        Me.txbFiltro.Location = New System.Drawing.Point(6, 23)
        Me.txbFiltro.Name = "txbFiltro"
        Me.txbFiltro.Size = New System.Drawing.Size(248, 20)
        Me.txbFiltro.TabIndex = 32
        '
        'tblProductos
        '
        Me.tblProductos.AllowUserToAddRows = False
        Me.tblProductos.AllowUserToDeleteRows = False
        Me.tblProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblProductos.Location = New System.Drawing.Point(6, 49)
        Me.tblProductos.Name = "tblProductos"
        Me.tblProductos.ReadOnly = True
        Me.tblProductos.Size = New System.Drawing.Size(269, 398)
        Me.tblProductos.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(520, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Bodega"
        '
        'cmbBodega
        '
        Me.cmbBodega.FormattingEnabled = True
        Me.cmbBodega.Location = New System.Drawing.Point(570, 27)
        Me.cmbBodega.Name = "cmbBodega"
        Me.cmbBodega.Size = New System.Drawing.Size(151, 21)
        Me.cmbBodega.TabIndex = 26
        Me.cmbBodega.Text = "Selecciona"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1031, 401)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 46)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(298, 112)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(186, 44)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = ">>"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button9)
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.cmbFiltroVenta)
        Me.TabPage2.Controls.Add(Me.tbxBusquedaFiltrada)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.tblDetalleVenta)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1155, 539)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalles de Venta"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(898, 411)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(143, 50)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "Activar Venta en Espera"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(769, 412)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(127, 49)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Cambio o Devolucion"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(1015, 33)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(107, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Busqueda"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'cmbFiltroVenta
        '
        Me.cmbFiltroVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFiltroVenta.FormattingEnabled = True
        Me.cmbFiltroVenta.Items.AddRange(New Object() {"Cliente", "Clave Venta", "Empleado", "Fecha", "Total de Venta", "Producto", "Cantidad", "Bodega"})
        Me.cmbFiltroVenta.Location = New System.Drawing.Point(22, 36)
        Me.cmbFiltroVenta.Name = "cmbFiltroVenta"
        Me.cmbFiltroVenta.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltroVenta.TabIndex = 4
        '
        'tbxBusquedaFiltrada
        '
        Me.tbxBusquedaFiltrada.Location = New System.Drawing.Point(149, 36)
        Me.tbxBusquedaFiltrada.Name = "tbxBusquedaFiltrada"
        Me.tbxBusquedaFiltrada.Size = New System.Drawing.Size(860, 20)
        Me.tbxBusquedaFiltrada.TabIndex = 3
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1043, 412)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(79, 49)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Editar Venta"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'tblDetalleVenta
        '
        Me.tblDetalleVenta.AllowUserToAddRows = False
        Me.tblDetalleVenta.AllowUserToDeleteRows = False
        Me.tblDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblDetalleVenta.Location = New System.Drawing.Point(35, 80)
        Me.tblDetalleVenta.Name = "tblDetalleVenta"
        Me.tblDetalleVenta.ReadOnly = True
        Me.tblDetalleVenta.Size = New System.Drawing.Size(1087, 302)
        Me.tblDetalleVenta.TabIndex = 0
        '
        'NuevaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 505)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "NuevaVenta"
        Me.Text = "NuevaVenta"
        CType(Me.tblventa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdprecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdkilos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.npdCantidadPagada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.tblDetalleVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblventa As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents npdprecio As NumericUpDown
    Friend WithEvents npdkilos As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lbl As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents tblDetalleVenta As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents cbxEspera As CheckBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents cmbFiltroVenta As ComboBox
    Friend WithEvents tbxBusquedaFiltrada As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents cmbFormaPago As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents npdCantidadPagada As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbBodega As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents cbxRazon As CheckBox
    Friend WithEvents txbFiltro As TextBox
    Friend WithEvents tblProductos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnBuscarCliente As Button
    Public WithEvents txtNombreCliente As TextBox
    Friend WithEvents Button8 As Button
End Class
