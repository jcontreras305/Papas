<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transpasos
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
        Me.bodega1 = New System.Windows.Forms.ComboBox()
        Me.cmbproducto1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bodega2 = New System.Windows.Forms.ComboBox()
        Me.cmbproducto2 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tblpro1 = New System.Windows.Forms.DataGridView()
        Me.tblpro2 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblpro1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblpro2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bodega1
        '
        Me.bodega1.FormattingEnabled = True
        Me.bodega1.Location = New System.Drawing.Point(107, 37)
        Me.bodega1.Name = "bodega1"
        Me.bodega1.Size = New System.Drawing.Size(121, 21)
        Me.bodega1.TabIndex = 0
        '
        'cmbproducto1
        '
        Me.cmbproducto1.FormattingEnabled = True
        Me.cmbproducto1.Location = New System.Drawing.Point(107, 73)
        Me.cmbproducto1.Name = "cmbproducto1"
        Me.cmbproducto1.Size = New System.Drawing.Size(121, 21)
        Me.cmbproducto1.TabIndex = 1
        Me.cmbproducto1.Text = "Selecione producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bodegas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Producto"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(158, 112)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cantidad en Kilogramos"
        '
        'bodega2
        '
        Me.bodega2.FormattingEnabled = True
        Me.bodega2.Location = New System.Drawing.Point(475, 36)
        Me.bodega2.Name = "bodega2"
        Me.bodega2.Size = New System.Drawing.Size(121, 21)
        Me.bodega2.TabIndex = 0
        '
        'cmbproducto2
        '
        Me.cmbproducto2.FormattingEnabled = True
        Me.cmbproducto2.Location = New System.Drawing.Point(475, 76)
        Me.cmbproducto2.Name = "cmbproducto2"
        Me.cmbproducto2.Size = New System.Drawing.Size(121, 21)
        Me.cmbproducto2.TabIndex = 1
        Me.cmbproducto2.Text = "Seleccione producto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(403, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Bodegas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(402, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Producto"
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(526, 114)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown3.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(402, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Cantidad en Kilogramos"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(304, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "<<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tblpro1
        '
        Me.tblpro1.AllowUserToAddRows = False
        Me.tblpro1.AllowUserToDeleteRows = False
        Me.tblpro1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblpro1.Location = New System.Drawing.Point(37, 187)
        Me.tblpro1.Name = "tblpro1"
        Me.tblpro1.ReadOnly = True
        Me.tblpro1.Size = New System.Drawing.Size(240, 279)
        Me.tblpro1.TabIndex = 7
        '
        'tblpro2
        '
        Me.tblpro2.AllowUserToAddRows = False
        Me.tblpro2.AllowUserToDeleteRows = False
        Me.tblpro2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblpro2.Location = New System.Drawing.Point(405, 190)
        Me.tblpro2.Name = "tblpro2"
        Me.tblpro2.ReadOnly = True
        Me.tblpro2.Size = New System.Drawing.Size(240, 276)
        Me.tblpro2.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(445, 156)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(80, 154)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(402, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Buscar"
        '
        'Label5
        '
        Me.Label5.AllowDrop = True
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Buscar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(308, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = ">>"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Transpasos
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 478)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.tblpro2)
        Me.Controls.Add(Me.tblpro1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NumericUpDown3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbproducto2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bodega2)
        Me.Controls.Add(Me.cmbproducto1)
        Me.Controls.Add(Me.bodega1)
        Me.Name = "Transpasos"
        Me.Text = "Transpasos"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblpro1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblpro2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bodega1 As ComboBox
    Friend WithEvents cmbproducto1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents bodega2 As ComboBox
    Friend WithEvents cmbproducto2 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents tblpro1 As DataGridView
    Friend WithEvents tblpro2 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
End Class
