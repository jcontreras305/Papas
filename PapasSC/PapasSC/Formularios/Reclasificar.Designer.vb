<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reclasificar
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
        Me.tblProductosExistencias = New System.Windows.Forms.DataGridView()
        Me.cmbBodega = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Raclasificación = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sprKilosMas = New System.Windows.Forms.NumericUpDown()
        Me.sprKilosMenos = New System.Windows.Forms.NumericUpDown()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tblCambios = New System.Windows.Forms.DataGridView()
        Me.lblCambios = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.cmbProdcutos = New System.Windows.Forms.ComboBox()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.tblProductosExistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Raclasificación.SuspendLayout()
        CType(Me.sprKilosMas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sprKilosMenos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.tblCambios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblProductosExistencias
        '
        Me.tblProductosExistencias.AllowUserToAddRows = False
        Me.tblProductosExistencias.AllowUserToDeleteRows = False
        Me.tblProductosExistencias.AllowUserToOrderColumns = True
        Me.tblProductosExistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblProductosExistencias.Location = New System.Drawing.Point(19, 49)
        Me.tblProductosExistencias.Name = "tblProductosExistencias"
        Me.tblProductosExistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblProductosExistencias.Size = New System.Drawing.Size(487, 150)
        Me.tblProductosExistencias.TabIndex = 1
        '
        'cmbBodega
        '
        Me.cmbBodega.FormattingEnabled = True
        Me.cmbBodega.Location = New System.Drawing.Point(360, 18)
        Me.cmbBodega.Name = "cmbBodega"
        Me.cmbBodega.Size = New System.Drawing.Size(121, 21)
        Me.cmbBodega.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(315, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Bodega"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(91, 19)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(218, 20)
        Me.txtBusqueda.TabIndex = 4
        '
        'Raclasificación
        '
        Me.Raclasificación.Controls.Add(Me.Label3)
        Me.Raclasificación.Controls.Add(Me.sprKilosMas)
        Me.Raclasificación.Controls.Add(Me.sprKilosMenos)
        Me.Raclasificación.Controls.Add(Me.btnAgregar)
        Me.Raclasificación.Controls.Add(Me.GroupBox2)
        Me.Raclasificación.Controls.Add(Me.btnEliminar)
        Me.Raclasificación.Controls.Add(Me.btnConfirmar)
        Me.Raclasificación.Controls.Add(Me.cmbProdcutos)
        Me.Raclasificación.Controls.Add(Me.txtProducto)
        Me.Raclasificación.Controls.Add(Me.lblCantidad)
        Me.Raclasificación.Controls.Add(Me.txtBusqueda)
        Me.Raclasificación.Controls.Add(Me.Label2)
        Me.Raclasificación.Controls.Add(Me.cmbBodega)
        Me.Raclasificación.Controls.Add(Me.tblProductosExistencias)
        Me.Raclasificación.Controls.Add(Me.Label1)
        Me.Raclasificación.Location = New System.Drawing.Point(30, 45)
        Me.Raclasificación.Name = "Raclasificación"
        Me.Raclasificación.Size = New System.Drawing.Size(512, 427)
        Me.Raclasificación.TabIndex = 0
        Me.Raclasificación.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Kilos a Reclasificar"
        '
        'sprKilosMas
        '
        Me.sprKilosMas.Location = New System.Drawing.Point(158, 286)
        Me.sprKilosMas.Name = "sprKilosMas"
        Me.sprKilosMas.Size = New System.Drawing.Size(77, 20)
        Me.sprKilosMas.TabIndex = 18
        '
        'sprKilosMenos
        '
        Me.sprKilosMenos.Location = New System.Drawing.Point(131, 253)
        Me.sprKilosMenos.Name = "sprKilosMenos"
        Me.sprKilosMenos.Size = New System.Drawing.Size(104, 20)
        Me.sprKilosMenos.TabIndex = 17
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(31, 335)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 16
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tblCambios)
        Me.GroupBox2.Controls.Add(Me.lblCambios)
        Me.GroupBox2.Location = New System.Drawing.Point(253, 205)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 216)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'tblCambios
        '
        Me.tblCambios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblCambios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Cambio, Me.Cantidad, Me.Eliminar})
        Me.tblCambios.Location = New System.Drawing.Point(6, 37)
        Me.tblCambios.Name = "tblCambios"
        Me.tblCambios.Size = New System.Drawing.Size(238, 168)
        Me.tblCambios.TabIndex = 13
        '
        'lblCambios
        '
        Me.lblCambios.AutoSize = True
        Me.lblCambios.Location = New System.Drawing.Point(17, 18)
        Me.lblCambios.Name = "lblCambios"
        Me.lblCambios.Size = New System.Drawing.Size(47, 13)
        Me.lblCambios.TabIndex = 9
        Me.lblCambios.Text = "Cambios"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(149, 387)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(32, 387)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmar.TabIndex = 12
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'cmbProdcutos
        '
        Me.cmbProdcutos.FormattingEnabled = True
        Me.cmbProdcutos.Location = New System.Drawing.Point(31, 285)
        Me.cmbProdcutos.Name = "cmbProdcutos"
        Me.cmbProdcutos.Size = New System.Drawing.Size(121, 21)
        Me.cmbProdcutos.TabIndex = 10
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(35, 219)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(129, 20)
        Me.txtProducto.TabIndex = 7
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(185, 218)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(50, 20)
        Me.lblCantidad.TabIndex = 6
        Me.lblCantidad.Text = "Label3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Busqueda"
        '
        'Producto
        '
        Me.Producto.FillWeight = 80.0!
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        '
        'Cambio
        '
        Me.Cambio.HeaderText = "Cambio"
        Me.Cambio.Name = "Cambio"
        Me.Cambio.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.FillWeight = 80.0!
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Eliminar
        '
        Me.Eliminar.FillWeight = 30.0!
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        '
        'Reclasificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 494)
        Me.Controls.Add(Me.Raclasificación)
        Me.Name = "Reclasificar"
        Me.Text = "Reclasificar"
        CType(Me.tblProductosExistencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Raclasificación.ResumeLayout(False)
        Me.Raclasificación.PerformLayout()
        CType(Me.sprKilosMas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sprKilosMenos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.tblCambios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Raclasificación As GroupBox
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbBodega As ComboBox
    Friend WithEvents tblProductosExistencias As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents tblCambios As DataGridView
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents cmbProdcutos As ComboBox
    Friend WithEvents lblCambios As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents sprKilosMas As NumericUpDown
    Friend WithEvents sprKilosMenos As NumericUpDown
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Cambio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
End Class
