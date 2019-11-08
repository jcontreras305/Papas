<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte_de_ventas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chbSucursal = New System.Windows.Forms.CheckBox()
        Me.chbCaja = New System.Windows.Forms.CheckBox()
        Me.cboDatos = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtNombreCleintes = New System.Windows.Forms.TextBox()
        Me.chbCliente = New System.Windows.Forms.CheckBox()
        Me.chbEmpleado = New System.Windows.Forms.CheckBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.jtableNombres = New System.Windows.Forms.DataGridView()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblfeInicial = New System.Windows.Forms.Label()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicial = New System.Windows.Forms.DateTimePicker()
        Me.chbFechas = New System.Windows.Forms.CheckBox()
        Me.lblFechaFinal = New System.Windows.Forms.Label()
        Me.btnGenerar1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.jtableNombres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chbSucursal)
        Me.GroupBox1.Controls.Add(Me.chbCaja)
        Me.GroupBox1.Controls.Add(Me.cboDatos)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 81)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reportes"
        '
        'chbSucursal
        '
        Me.chbSucursal.AutoSize = True
        Me.chbSucursal.Location = New System.Drawing.Point(23, 49)
        Me.chbSucursal.Name = "chbSucursal"
        Me.chbSucursal.Size = New System.Drawing.Size(67, 17)
        Me.chbSucursal.TabIndex = 18
        Me.chbSucursal.Text = "Sucursal"
        Me.chbSucursal.UseVisualStyleBackColor = True
        '
        'chbCaja
        '
        Me.chbCaja.AutoSize = True
        Me.chbCaja.Location = New System.Drawing.Point(23, 26)
        Me.chbCaja.Name = "chbCaja"
        Me.chbCaja.Size = New System.Drawing.Size(47, 17)
        Me.chbCaja.TabIndex = 17
        Me.chbCaja.Text = "Caja"
        Me.chbCaja.UseVisualStyleBackColor = True
        '
        'cboDatos
        '
        Me.cboDatos.FormattingEnabled = True
        Me.cboDatos.Location = New System.Drawing.Point(179, 35)
        Me.cboDatos.Name = "cboDatos"
        Me.cboDatos.Size = New System.Drawing.Size(167, 21)
        Me.cboDatos.TabIndex = 16
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtNombreCleintes)
        Me.GroupBox3.Controls.Add(Me.chbCliente)
        Me.GroupBox3.Controls.Add(Me.chbEmpleado)
        Me.GroupBox3.Controls.Add(Me.lblNombre)
        Me.GroupBox3.Controls.Add(Me.jtableNombres)
        Me.GroupBox3.Controls.Add(Me.txtNombre)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 182)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(444, 149)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Reportes"
        '
        'txtNombreCleintes
        '
        Me.txtNombreCleintes.Location = New System.Drawing.Point(181, 19)
        Me.txtNombreCleintes.Name = "txtNombreCleintes"
        Me.txtNombreCleintes.Size = New System.Drawing.Size(167, 20)
        Me.txtNombreCleintes.TabIndex = 30
        '
        'chbCliente
        '
        Me.chbCliente.AutoSize = True
        Me.chbCliente.Location = New System.Drawing.Point(22, 74)
        Me.chbCliente.Name = "chbCliente"
        Me.chbCliente.Size = New System.Drawing.Size(58, 17)
        Me.chbCliente.TabIndex = 19
        Me.chbCliente.Text = "Cliente"
        Me.chbCliente.UseVisualStyleBackColor = True
        '
        'chbEmpleado
        '
        Me.chbEmpleado.AutoSize = True
        Me.chbEmpleado.Location = New System.Drawing.Point(23, 38)
        Me.chbEmpleado.Name = "chbEmpleado"
        Me.chbEmpleado.Size = New System.Drawing.Size(73, 17)
        Me.chbEmpleado.TabIndex = 20
        Me.chbEmpleado.Text = "Empleado"
        Me.chbEmpleado.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(131, 19)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 29
        Me.lblNombre.Text = "Nombre"
        '
        'jtableNombres
        '
        Me.jtableNombres.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.jtableNombres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.jtableNombres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.jtableNombres.Location = New System.Drawing.Point(179, 47)
        Me.jtableNombres.Name = "jtableNombres"
        Me.jtableNombres.ShowCellErrors = False
        Me.jtableNombres.Size = New System.Drawing.Size(167, 96)
        Me.jtableNombres.TabIndex = 27
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(181, 19)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(167, 20)
        Me.txtNombre.TabIndex = 28
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblfeInicial)
        Me.GroupBox2.Controls.Add(Me.lblHasta)
        Me.GroupBox2.Controls.Add(Me.dtpFinal)
        Me.GroupBox2.Controls.Add(Me.dtpInicial)
        Me.GroupBox2.Controls.Add(Me.chbFechas)
        Me.GroupBox2.Controls.Add(Me.lblFechaFinal)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(444, 77)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reportes"
        '
        'lblfeInicial
        '
        Me.lblfeInicial.AutoSize = True
        Me.lblfeInicial.Location = New System.Drawing.Point(164, 16)
        Me.lblfeInicial.Name = "lblfeInicial"
        Me.lblfeInicial.Size = New System.Drawing.Size(66, 13)
        Me.lblfeInicial.TabIndex = 25
        Me.lblfeInicial.Text = "Fecha inicial"
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(256, 37)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(35, 13)
        Me.lblHasta.TabIndex = 24
        Me.lblHasta.Text = "Hasta"
        '
        'dtpFinal
        '
        Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFinal.Location = New System.Drawing.Point(298, 33)
        Me.dtpFinal.Name = "dtpFinal"
        Me.dtpFinal.Size = New System.Drawing.Size(105, 20)
        Me.dtpFinal.TabIndex = 23
        '
        'dtpInicial
        '
        Me.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicial.Location = New System.Drawing.Point(147, 33)
        Me.dtpInicial.Name = "dtpInicial"
        Me.dtpInicial.Size = New System.Drawing.Size(102, 20)
        Me.dtpInicial.TabIndex = 22
        '
        'chbFechas
        '
        Me.chbFechas.AutoSize = True
        Me.chbFechas.Location = New System.Drawing.Point(23, 33)
        Me.chbFechas.Name = "chbFechas"
        Me.chbFechas.Size = New System.Drawing.Size(61, 17)
        Me.chbFechas.TabIndex = 21
        Me.chbFechas.Text = "Fechas"
        Me.chbFechas.UseVisualStyleBackColor = True
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.AutoSize = True
        Me.lblFechaFinal.Location = New System.Drawing.Point(316, 16)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(59, 13)
        Me.lblFechaFinal.TabIndex = 26
        Me.lblFechaFinal.Text = "Fecha final"
        '
        'btnGenerar1
        '
        Me.btnGenerar1.Location = New System.Drawing.Point(363, 337)
        Me.btnGenerar1.Name = "btnGenerar1"
        Me.btnGenerar1.Size = New System.Drawing.Size(93, 36)
        Me.btnGenerar1.TabIndex = 32
        Me.btnGenerar1.Text = "Generar Reporte"
        Me.btnGenerar1.UseVisualStyleBackColor = True
        '
        'Reporte_de_ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 391)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnGenerar1)
        Me.Name = "Reporte_de_ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte_de_ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.jtableNombres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFechaFinal As Label
    Friend WithEvents lblfeInicial As Label
    Friend WithEvents lblHasta As Label
    Friend WithEvents dtpFinal As DateTimePicker
    Friend WithEvents dtpInicial As DateTimePicker
    Friend WithEvents chbFechas As CheckBox
    Friend WithEvents chbEmpleado As CheckBox
    Friend WithEvents chbCliente As CheckBox
    Friend WithEvents chbSucursal As CheckBox
    Friend WithEvents chbCaja As CheckBox
    Friend WithEvents cboDatos As ComboBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtNombreCleintes As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents jtableNombres As DataGridView
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnGenerar1 As Button
End Class
