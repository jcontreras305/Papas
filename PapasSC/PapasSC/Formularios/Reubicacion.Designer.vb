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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        CType(Me.sprKg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sprKg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tblExisitenciaBodega1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblExistenciaBodega2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cmbproducto2.Location = New System.Drawing.Point(479, 24)
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
        Me.Label8.Location = New System.Drawing.Point(408, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Producto"
        '
        'sprKg2
        '
        Me.sprKg2.Location = New System.Drawing.Point(480, 66)
        Me.sprKg2.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.sprKg2.Name = "sprKg2"
        Me.sprKg2.Size = New System.Drawing.Size(148, 20)
        Me.sprKg2.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(398, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Kilogramos"
        '
        'btnTraspasoIzq
        '
        Me.btnTraspasoIzq.Location = New System.Drawing.Point(287, 16)
        Me.btnTraspasoIzq.Name = "btnTraspasoIzq"
        Me.btnTraspasoIzq.Size = New System.Drawing.Size(75, 37)
        Me.btnTraspasoIzq.TabIndex = 6
        Me.btnTraspasoIzq.Text = "<<"
        Me.btnTraspasoIzq.UseVisualStyleBackColor = True
        '
        'btnTraspasoDer
        '
        Me.btnTraspasoDer.Location = New System.Drawing.Point(287, 59)
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
        Me.GroupBox1.Location = New System.Drawing.Point(37, 259)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(653, 153)
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
        Me.txtDescripcion.Size = New System.Drawing.Size(539, 20)
        Me.txtDescripcion.TabIndex = 14
        '
        'tblExisitenciaBodega1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.NullValue = "ND"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblExisitenciaBodega1.DefaultCellStyle = DataGridViewCellStyle1
        Me.tblExisitenciaBodega1.Location = New System.Drawing.Point(23, 99)
        Me.tblExisitenciaBodega1.Name = "tblExisitenciaBodega1"
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.NullValue = "ND"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblExistenciaBodega2.DefaultCellStyle = DataGridViewCellStyle2
        Me.tblExistenciaBodega2.Location = New System.Drawing.Point(379, 99)
        Me.tblExistenciaBodega2.Name = "tblExistenciaBodega2"
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
        'Transpasos
        '
        Me.AcceptButton = Me.btnTraspasoIzq
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 445)
        Me.Controls.Add(Me.lblNombreUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tblExistenciaBodega2)
        Me.Controls.Add(Me.cmbConsultaBodega2)
        Me.Controls.Add(Me.cmbConsultaBodega1)
        Me.Controls.Add(Me.tblExisitenciaBodega1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Name = "Transpasos"
        Me.Text = "Reubicación "
        CType(Me.sprKg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sprKg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tblExisitenciaBodega1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblExistenciaBodega2, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
