﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reubicacion
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmbproducto1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sprKg1 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbproducto2 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.sprKg2 = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnTraspasoIzq = New System.Windows.Forms.Button()
        Me.btnTraspasoDer = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.tblExisitenciaBodega1 = New System.Windows.Forms.DataGridView()
        Me.cmbConsultaBodega1 = New System.Windows.Forms.ComboBox()
        Me.cmbConsultaBodega2 = New System.Windows.Forms.ComboBox()
        Me.tblExistenciaBodega2 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.lblColorRojo = New System.Windows.Forms.Label()
        Me.lblAmarillo = New System.Windows.Forms.Label()
        Me.sprAmarillo = New System.Windows.Forms.NumericUpDown()
        Me.sprVerde = New System.Windows.Forms.NumericUpDown()
        Me.ValoresMinimos = New System.Windows.Forms.GroupBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.chbVerCambios = New System.Windows.Forms.CheckBox()
        Me.tblListaCambios = New System.Windows.Forms.DataGridView()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Envia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Recibe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kilogramos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.sprKg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sprKg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tblExisitenciaBodega1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblExistenciaBodega2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sprAmarillo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sprVerde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ValoresMinimos.SuspendLayout()
        CType(Me.tblListaCambios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbproducto1
        '
        Me.cmbproducto1.FormattingEnabled = True
        Me.cmbproducto1.Location = New System.Drawing.Point(78, 24)
        Me.cmbproducto1.Name = "cmbproducto1"
        Me.cmbproducto1.Size = New System.Drawing.Size(159, 21)
        Me.cmbproducto1.TabIndex = 1
        Me.cmbproducto1.Text = "Selecione producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Producto"
        '
        'sprKg1
        '
        Me.sprKg1.Location = New System.Drawing.Point(79, 63)
        Me.sprKg1.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.sprKg1.Name = "sprKg1"
        Me.sprKg1.Size = New System.Drawing.Size(158, 20)
        Me.sprKg1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Kilogramos"
        '
        'cmbproducto2
        '
        Me.cmbproducto2.FormattingEnabled = True
        Me.cmbproducto2.Location = New System.Drawing.Point(486, 24)
        Me.cmbproducto2.Name = "cmbproducto2"
        Me.cmbproducto2.Size = New System.Drawing.Size(149, 21)
        Me.cmbproducto2.TabIndex = 1
        Me.cmbproducto2.Text = "Seleccione producto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(500, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Bodegas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(415, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Producto"
        '
        'sprKg2
        '
        Me.sprKg2.Location = New System.Drawing.Point(487, 66)
        Me.sprKg2.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.sprKg2.Name = "sprKg2"
        Me.sprKg2.Size = New System.Drawing.Size(148, 20)
        Me.sprKg2.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(405, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Kilogramos"
        '
        'btnTraspasoIzq
        '
        Me.btnTraspasoIzq.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTraspasoIzq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnTraspasoIzq.Location = New System.Drawing.Point(291, 61)
        Me.btnTraspasoIzq.Name = "btnTraspasoIzq"
        Me.btnTraspasoIzq.Size = New System.Drawing.Size(75, 37)
        Me.btnTraspasoIzq.TabIndex = 6
        Me.btnTraspasoIzq.Text = "<<"
        Me.btnTraspasoIzq.UseVisualStyleBackColor = True
        '
        'btnTraspasoDer
        '
        Me.btnTraspasoDer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTraspasoDer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnTraspasoDer.Location = New System.Drawing.Point(291, 14)
        Me.btnTraspasoDer.Name = "btnTraspasoDer"
        Me.btnTraspasoDer.Size = New System.Drawing.Size(75, 41)
        Me.btnTraspasoDer.TabIndex = 13
        Me.btnTraspasoDer.Text = ">>"
        Me.btnTraspasoDer.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnTraspasoDer)
        Me.GroupBox1.Controls.Add(Me.sprKg2)
        Me.GroupBox1.Controls.Add(Me.btnTraspasoIzq)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmbproducto1)
        Me.GroupBox1.Controls.Add(Me.cmbproducto2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.sprKg1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 259)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(683, 153)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cambios"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(89, 108)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(559, 20)
        Me.txtDescripcion.TabIndex = 14
        '
        'tblExisitenciaBodega1
        '
        Me.tblExisitenciaBodega1.AllowUserToAddRows = False
        Me.tblExisitenciaBodega1.AllowUserToDeleteRows = False
        Me.tblExisitenciaBodega1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.NullValue = "ND"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblExisitenciaBodega1.DefaultCellStyle = DataGridViewCellStyle3
        Me.tblExisitenciaBodega1.Location = New System.Drawing.Point(23, 99)
        Me.tblExisitenciaBodega1.Name = "tblExisitenciaBodega1"
        Me.tblExisitenciaBodega1.ReadOnly = True
        Me.tblExisitenciaBodega1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblExisitenciaBodega1.Size = New System.Drawing.Size(327, 154)
        Me.tblExisitenciaBodega1.TabIndex = 15
        '
        'cmbConsultaBodega1
        '
        Me.cmbConsultaBodega1.FormattingEnabled = True
        Me.cmbConsultaBodega1.Location = New System.Drawing.Point(76, 59)
        Me.cmbConsultaBodega1.Name = "cmbConsultaBodega1"
        Me.cmbConsultaBodega1.Size = New System.Drawing.Size(125, 21)
        Me.cmbConsultaBodega1.TabIndex = 16
        '
        'cmbConsultaBodega2
        '
        Me.cmbConsultaBodega2.FormattingEnabled = True
        Me.cmbConsultaBodega2.Location = New System.Drawing.Point(565, 59)
        Me.cmbConsultaBodega2.Name = "cmbConsultaBodega2"
        Me.cmbConsultaBodega2.Size = New System.Drawing.Size(125, 21)
        Me.cmbConsultaBodega2.TabIndex = 17
        '
        'tblExistenciaBodega2
        '
        Me.tblExistenciaBodega2.AllowUserToAddRows = False
        Me.tblExistenciaBodega2.AllowUserToDeleteRows = False
        Me.tblExistenciaBodega2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.NullValue = "ND"
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblExistenciaBodega2.DefaultCellStyle = DataGridViewCellStyle4
        Me.tblExistenciaBodega2.Location = New System.Drawing.Point(379, 99)
        Me.tblExistenciaBodega2.Name = "tblExistenciaBodega2"
        Me.tblExistenciaBodega2.ReadOnly = True
        Me.tblExistenciaBodega2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblExistenciaBodega2.Size = New System.Drawing.Size(327, 154)
        Me.tblExistenciaBodega2.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Bodegas"
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Location = New System.Drawing.Point(21, 21)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(39, 13)
        Me.lblNombreUsuario.TabIndex = 20
        Me.lblNombreUsuario.Text = "Label4"
        '
        'lblColorRojo
        '
        Me.lblColorRojo.AutoSize = True
        Me.lblColorRojo.Location = New System.Drawing.Point(14, 21)
        Me.lblColorRojo.Name = "lblColorRojo"
        Me.lblColorRojo.Size = New System.Drawing.Size(43, 13)
        Me.lblColorRojo.TabIndex = 21
        Me.lblColorRojo.Text = "Amarillo"
        '
        'lblAmarillo
        '
        Me.lblAmarillo.AutoSize = True
        Me.lblAmarillo.Location = New System.Drawing.Point(152, 21)
        Me.lblAmarillo.Name = "lblAmarillo"
        Me.lblAmarillo.Size = New System.Drawing.Size(35, 13)
        Me.lblAmarillo.TabIndex = 23
        Me.lblAmarillo.Text = "Verde"
        '
        'sprAmarillo
        '
        Me.sprAmarillo.Location = New System.Drawing.Point(76, 17)
        Me.sprAmarillo.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.sprAmarillo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.sprAmarillo.Name = "sprAmarillo"
        Me.sprAmarillo.Size = New System.Drawing.Size(55, 20)
        Me.sprAmarillo.TabIndex = 27
        Me.sprAmarillo.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'sprVerde
        '
        Me.sprVerde.Location = New System.Drawing.Point(192, 17)
        Me.sprVerde.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.sprVerde.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.sprVerde.Name = "sprVerde"
        Me.sprVerde.Size = New System.Drawing.Size(55, 20)
        Me.sprVerde.TabIndex = 28
        Me.sprVerde.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'ValoresMinimos
        '
        Me.ValoresMinimos.Controls.Add(Me.lblColorRojo)
        Me.ValoresMinimos.Controls.Add(Me.sprVerde)
        Me.ValoresMinimos.Controls.Add(Me.lblAmarillo)
        Me.ValoresMinimos.Controls.Add(Me.sprAmarillo)
        Me.ValoresMinimos.Location = New System.Drawing.Point(438, 5)
        Me.ValoresMinimos.Name = "ValoresMinimos"
        Me.ValoresMinimos.Size = New System.Drawing.Size(260, 48)
        Me.ValoresMinimos.TabIndex = 29
        Me.ValoresMinimos.TabStop = False
        Me.ValoresMinimos.Text = "Valores minimos"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.PapasSC.My.Resources.Resources.GUARDAR
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnGuardar.Location = New System.Drawing.Point(615, 418)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(91, 37)
        Me.btnGuardar.TabIndex = 30
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.PapasSC.My.Resources.Resources.CANCELAR
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(523, 418)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 37)
        Me.btnSalir.TabIndex = 31
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'chbVerCambios
        '
        Me.chbVerCambios.AutoSize = True
        Me.chbVerCambios.Location = New System.Drawing.Point(23, 429)
        Me.chbVerCambios.Name = "chbVerCambios"
        Me.chbVerCambios.Size = New System.Drawing.Size(85, 17)
        Me.chbVerCambios.TabIndex = 32
        Me.chbVerCambios.Text = "Ver Cambios"
        Me.chbVerCambios.UseVisualStyleBackColor = True
        '
        'tblListaCambios
        '
        Me.tblListaCambios.AllowUserToAddRows = False
        Me.tblListaCambios.AllowUserToDeleteRows = False
        Me.tblListaCambios.AllowUserToResizeRows = False
        Me.tblListaCambios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblListaCambios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Envia, Me.Recibe, Me.Kilogramos, Me.Eliminar})
        Me.tblListaCambios.Location = New System.Drawing.Point(13, 18)
        Me.tblListaCambios.Name = "tblListaCambios"
        Me.tblListaCambios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblListaCambios.Size = New System.Drawing.Size(493, 136)
        Me.tblListaCambios.TabIndex = 33
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        '
        'Envia
        '
        Me.Envia.HeaderText = "Envia"
        Me.Envia.Name = "Envia"
        Me.Envia.ReadOnly = True
        '
        'Recibe
        '
        Me.Recibe.HeaderText = "Recibe"
        Me.Recibe.Name = "Recibe"
        Me.Recibe.ReadOnly = True
        '
        'Kilogramos
        '
        Me.Kilogramos.HeaderText = "Kilogramos"
        Me.Kilogramos.Name = "Kilogramos"
        Me.Kilogramos.ReadOnly = True
        '
        'Eliminar
        '
        Me.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Eliminar.Width = 68
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = Global.PapasSC.My.Resources.Resources.BORRAR
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(551, 96)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(97, 41)
        Me.btnLimpiar.TabIndex = 34
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Image = Global.PapasSC.My.Resources.Resources.SALIR
        Me.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuitar.Location = New System.Drawing.Point(551, 37)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(97, 41)
        Me.btnQuitar.TabIndex = 35
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tblListaCambios)
        Me.GroupBox2.Controls.Add(Me.btnQuitar)
        Me.GroupBox2.Controls.Add(Me.btnLimpiar)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 459)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(682, 166)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Elminar Cambios"
        '
        'Reubicacion
        '
        Me.AcceptButton = Me.btnTraspasoIzq
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 625)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.chbVerCambios)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.ValoresMinimos)
        Me.Controls.Add(Me.lblNombreUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tblExistenciaBodega2)
        Me.Controls.Add(Me.cmbConsultaBodega2)
        Me.Controls.Add(Me.cmbConsultaBodega1)
        Me.Controls.Add(Me.tblExisitenciaBodega1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Name = "Reubicacion"
        Me.Text = "Reubicación "
        CType(Me.sprKg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sprKg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tblExisitenciaBodega1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblExistenciaBodega2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sprAmarillo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sprVerde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ValoresMinimos.ResumeLayout(False)
        Me.ValoresMinimos.PerformLayout()
        CType(Me.tblListaCambios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbproducto1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents sprKg1 As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbproducto2 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents sprKg2 As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents btnTraspasoIzq As Button
    Friend WithEvents btnTraspasoDer As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tblExisitenciaBodega1 As DataGridView
    Friend WithEvents cmbConsultaBodega1 As ComboBox
    Friend WithEvents cmbConsultaBodega2 As ComboBox
    Friend WithEvents tblExistenciaBodega2 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblColorRojo As Label
    Friend WithEvents lblAmarillo As Label
    Friend WithEvents sprAmarillo As NumericUpDown
    Friend WithEvents sprVerde As NumericUpDown
    Friend WithEvents ValoresMinimos As GroupBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents chbVerCambios As CheckBox
    Friend WithEvents tblListaCambios As DataGridView
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Envia As DataGridViewTextBoxColumn
    Friend WithEvents Recibe As DataGridViewTextBoxColumn
    Friend WithEvents Kilogramos As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
End Class
