﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_Existencias
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
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxregistraspro = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.cmbBodega = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Alturacamasarpilla = New System.Windows.Forms.NumericUpDown()
        Me.tblpesoarpilla = New System.Windows.Forms.DataGridView()
        Me.numero1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.kgUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.npd = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Alturacamasarpilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblpesoarpilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(482, 423)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(88, 48)
        Me.Cancelar.TabIndex = 5
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxregistraspro)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbProducto)
        Me.GroupBox1.Controls.Add(Me.cmbBodega)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 90)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Existencias"
        '
        'cbxregistraspro
        '
        Me.cbxregistraspro.AutoSize = True
        Me.cbxregistraspro.Location = New System.Drawing.Point(31, 46)
        Me.cbxregistraspro.Name = "cbxregistraspro"
        Me.cbxregistraspro.Size = New System.Drawing.Size(136, 17)
        Me.cbxregistraspro.TabIndex = 28
        Me.cbxregistraspro.Text = "Registrar solo Producto"
        Me.cbxregistraspro.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(258, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(28, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Bodega"
        '
        'cmbProducto
        '
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(314, 20)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(161, 21)
        Me.cmbProducto.TabIndex = 10
        '
        'cmbBodega
        '
        Me.cmbBodega.FormattingEnabled = True
        Me.cmbBodega.Location = New System.Drawing.Point(88, 19)
        Me.cmbBodega.Name = "cmbBodega"
        Me.cmbBodega.Size = New System.Drawing.Size(162, 21)
        Me.cmbBodega.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Altura en Arpillas de Cama"
        '
        'Alturacamasarpilla
        '
        Me.Alturacamasarpilla.Location = New System.Drawing.Point(188, 56)
        Me.Alturacamasarpilla.Name = "Alturacamasarpilla"
        Me.Alturacamasarpilla.Size = New System.Drawing.Size(120, 20)
        Me.Alturacamasarpilla.TabIndex = 26
        '
        'tblpesoarpilla
        '
        Me.tblpesoarpilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblpesoarpilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero1})
        Me.tblpesoarpilla.Location = New System.Drawing.Point(242, 19)
        Me.tblpesoarpilla.Name = "tblpesoarpilla"
        Me.tblpesoarpilla.Size = New System.Drawing.Size(144, 138)
        Me.tblpesoarpilla.TabIndex = 25
        '
        'numero1
        '
        Me.numero1.HeaderText = "Peso por Kilogramo"
        Me.numero1.Name = "numero1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(397, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 48)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Carcular Total Kg."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(170, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 34)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Peso en Kg."
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbltotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.Black
        Me.lbltotal.Location = New System.Drawing.Point(512, 102)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(0, 19)
        Me.lbltotal.TabIndex = 18
        '
        'kgUpDown
        '
        Me.kgUpDown.Location = New System.Drawing.Point(26, 62)
        Me.kgUpDown.Name = "kgUpDown"
        Me.kgUpDown.Size = New System.Drawing.Size(120, 20)
        Me.kgUpDown.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Cantidad de Arpillas en Cama"
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(388, 423)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(88, 48)
        Me.Aceptar.TabIndex = 12
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'npd
        '
        Me.npd.Location = New System.Drawing.Point(188, 30)
        Me.npd.Name = "npd"
        Me.npd.Size = New System.Drawing.Size(120, 20)
        Me.npd.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tblpesoarpilla)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lbltotal)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.kgUpDown)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(558, 182)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Calcular estimado del peso promedio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(373, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "KG. Totales:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.npd)
        Me.GroupBox3.Controls.Add(Me.Alturacamasarpilla)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 296)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(558, 121)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Calculo del Total en Kilos"
        '
        'Registrar_Existencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 484)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Registrar_Existencias"
        Me.Text = "Registrar_Existencias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Alturacamasarpilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblpesoarpilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kgUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Cancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Aceptar As Button
    Friend WithEvents npd As NumericUpDown
    Friend WithEvents cmbProducto As ComboBox
    Friend WithEvents cmbBodega As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents kgUpDown As NumericUpDown
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents tblpesoarpilla As DataGridView
    Friend WithEvents numero1 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Alturacamasarpilla As NumericUpDown
    Friend WithEvents cbxregistraspro As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
End Class
