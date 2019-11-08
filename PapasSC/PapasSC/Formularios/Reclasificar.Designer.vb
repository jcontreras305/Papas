<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reclasificar
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
        Me.tblProductosExistencias = New System.Windows.Forms.DataGridView()
        Me.cmbBodega = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Raclasificación = New System.Windows.Forms.GroupBox()
        Me.Cambios = New System.Windows.Forms.GroupBox()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbProdcutos = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.sprKilosMas = New System.Windows.Forms.NumericUpDown()
        Me.sprKilosMenos = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tblCambios = New System.Windows.Forms.DataGridView()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.tblProductosExistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Raclasificación.SuspendLayout()
        Me.Cambios.SuspendLayout()
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
        Me.tblProductosExistencias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblProductosExistencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblProductosExistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblProductosExistencias.Location = New System.Drawing.Point(19, 49)
        Me.tblProductosExistencias.Name = "tblProductosExistencias"
        Me.tblProductosExistencias.ReadOnly = True
        Me.tblProductosExistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblProductosExistencias.Size = New System.Drawing.Size(516, 150)
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
        Me.Raclasificación.Controls.Add(Me.Cambios)
        Me.Raclasificación.Controls.Add(Me.GroupBox2)
        Me.Raclasificación.Controls.Add(Me.btnEliminar)
        Me.Raclasificación.Controls.Add(Me.btnConfirmar)
        Me.Raclasificación.Controls.Add(Me.txtBusqueda)
        Me.Raclasificación.Controls.Add(Me.Label2)
        Me.Raclasificación.Controls.Add(Me.cmbBodega)
        Me.Raclasificación.Controls.Add(Me.tblProductosExistencias)
        Me.Raclasificación.Controls.Add(Me.Label1)
        Me.Raclasificación.Location = New System.Drawing.Point(31, 12)
        Me.Raclasificación.Name = "Raclasificación"
        Me.Raclasificación.Size = New System.Drawing.Size(554, 437)
        Me.Raclasificación.TabIndex = 0
        Me.Raclasificación.TabStop = False
        '
        'Cambios
        '
        Me.Cambios.Controls.Add(Me.txtProducto)
        Me.Cambios.Controls.Add(Me.Label5)
        Me.Cambios.Controls.Add(Me.lblCantidad)
        Me.Cambios.Controls.Add(Me.Label4)
        Me.Cambios.Controls.Add(Me.cmbProdcutos)
        Me.Cambios.Controls.Add(Me.Label3)
        Me.Cambios.Controls.Add(Me.btnAgregar)
        Me.Cambios.Controls.Add(Me.sprKilosMas)
        Me.Cambios.Controls.Add(Me.sprKilosMenos)
        Me.Cambios.Location = New System.Drawing.Point(19, 205)
        Me.Cambios.Name = "Cambios"
        Me.Cambios.Size = New System.Drawing.Size(257, 184)
        Me.Cambios.TabIndex = 22
        Me.Cambios.TabStop = False
        Me.Cambios.Text = "Datos"
        '
        'txtProducto
        '
        Me.txtProducto.Enabled = False
        Me.txtProducto.Location = New System.Drawing.Point(28, 22)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(129, 20)
        Me.txtProducto.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Kilos a Asignar"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(178, 21)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(50, 20)
        Me.lblCantidad.TabIndex = 6
        Me.lblCantidad.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Producto"
        '
        'cmbProdcutos
        '
        Me.cmbProdcutos.FormattingEnabled = True
        Me.cmbProdcutos.Location = New System.Drawing.Point(95, 86)
        Me.cmbProdcutos.Name = "cmbProdcutos"
        Me.cmbProdcutos.Size = New System.Drawing.Size(133, 21)
        Me.cmbProdcutos.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Kilos a Reclasificar"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(139, 139)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(89, 34)
        Me.btnAgregar.TabIndex = 16
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'sprKilosMas
        '
        Me.sprKilosMas.Location = New System.Drawing.Point(124, 113)
        Me.sprKilosMas.Name = "sprKilosMas"
        Me.sprKilosMas.Size = New System.Drawing.Size(104, 20)
        Me.sprKilosMas.TabIndex = 18
        '
        'sprKilosMenos
        '
        Me.sprKilosMenos.Location = New System.Drawing.Point(124, 56)
        Me.sprKilosMenos.Name = "sprKilosMenos"
        Me.sprKilosMenos.Size = New System.Drawing.Size(104, 20)
        Me.sprKilosMenos.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tblCambios)
        Me.GroupBox2.Location = New System.Drawing.Point(282, 205)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 216)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cambios a realizar"
        '
        'tblCambios
        '
        Me.tblCambios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblCambios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Cambio, Me.Cantidad, Me.Eliminar})
        Me.tblCambios.Location = New System.Drawing.Point(6, 37)
        Me.tblCambios.Name = "tblCambios"
        Me.tblCambios.ReadOnly = True
        Me.tblCambios.Size = New System.Drawing.Size(247, 168)
        Me.tblCambios.TabIndex = 13
        '
        'Producto
        '
        Me.Producto.FillWeight = 80.0!
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Width = 54
        '
        'Cambio
        '
        Me.Cambio.HeaderText = "Cambio"
        Me.Cambio.Name = "Cambio"
        Me.Cambio.ReadOnly = True
        Me.Cambio.Width = 67
        '
        'Cantidad
        '
        Me.Cantidad.FillWeight = 80.0!
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 54
        '
        'Eliminar
        '
        Me.Eliminar.FillWeight = 30.0!
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 30
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.PapasSC.My.Resources.Resources.BORRAR
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(158, 395)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(89, 34)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Image = Global.PapasSC.My.Resources.Resources.ACEPTAR
        Me.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmar.Location = New System.Drawing.Point(54, 395)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(86, 34)
        Me.btnConfirmar.TabIndex = 12
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirmar.UseVisualStyleBackColor = True
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
        'Reclasificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 456)
        Me.Controls.Add(Me.Raclasificación)
        Me.Name = "Reclasificar"
        Me.Text = "Reclasificar"
        CType(Me.tblProductosExistencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Raclasificación.ResumeLayout(False)
        Me.Raclasificación.PerformLayout()
        Me.Cambios.ResumeLayout(False)
        Me.Cambios.PerformLayout()
        CType(Me.sprKilosMas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sprKilosMenos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
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
    Friend WithEvents Cambios As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
