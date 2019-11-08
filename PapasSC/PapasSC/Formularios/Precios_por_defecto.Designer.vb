<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Precios_por_defecto
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPrecios = New System.Windows.Forms.ComboBox()
        Me.txtPrecios = New System.Windows.Forms.TextBox()
        Me.btnBuscarPrecios = New System.Windows.Forms.Button()
        Me.tblPreciosDefecto = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.btnModificarPrecio = New System.Windows.Forms.Button()
        CType(Me.tblPreciosDefecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto"
        '
        'cboPrecios
        '
        Me.cboPrecios.FormattingEnabled = True
        Me.cboPrecios.Items.AddRange(New Object() {"Version", "Tipo"})
        Me.cboPrecios.Location = New System.Drawing.Point(68, 25)
        Me.cboPrecios.Name = "cboPrecios"
        Me.cboPrecios.Size = New System.Drawing.Size(161, 21)
        Me.cboPrecios.TabIndex = 1
        '
        'txtPrecios
        '
        Me.txtPrecios.Location = New System.Drawing.Point(245, 24)
        Me.txtPrecios.Name = "txtPrecios"
        Me.txtPrecios.Size = New System.Drawing.Size(203, 20)
        Me.txtPrecios.TabIndex = 2
        '
        'btnBuscarPrecios
        '
        Me.btnBuscarPrecios.Location = New System.Drawing.Point(465, 22)
        Me.btnBuscarPrecios.Name = "btnBuscarPrecios"
        Me.btnBuscarPrecios.Size = New System.Drawing.Size(91, 23)
        Me.btnBuscarPrecios.TabIndex = 3
        Me.btnBuscarPrecios.Text = "Buscar"
        Me.btnBuscarPrecios.UseVisualStyleBackColor = True
        '
        'tblPreciosDefecto
        '
        Me.tblPreciosDefecto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblPreciosDefecto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblPreciosDefecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblPreciosDefecto.Location = New System.Drawing.Point(35, 69)
        Me.tblPreciosDefecto.Name = "tblPreciosDefecto"
        Me.tblPreciosDefecto.Size = New System.Drawing.Size(521, 232)
        Me.tblPreciosDefecto.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Location = New System.Drawing.Point(572, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "X"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(35, 308)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(128, 20)
        Me.txtPrecio.TabIndex = 7
        Me.txtPrecio.Text = "0.00"
        '
        'btnModificarPrecio
        '
        Me.btnModificarPrecio.Location = New System.Drawing.Point(169, 307)
        Me.btnModificarPrecio.Name = "btnModificarPrecio"
        Me.btnModificarPrecio.Size = New System.Drawing.Size(97, 23)
        Me.btnModificarPrecio.TabIndex = 8
        Me.btnModificarPrecio.Text = "Modificar precio"
        Me.btnModificarPrecio.UseVisualStyleBackColor = True
        '
        'Precios_por_defecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 340)
        Me.Controls.Add(Me.btnModificarPrecio)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tblPreciosDefecto)
        Me.Controls.Add(Me.btnBuscarPrecios)
        Me.Controls.Add(Me.txtPrecios)
        Me.Controls.Add(Me.cboPrecios)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Precios_por_defecto"
        Me.Text = " "
        CType(Me.tblPreciosDefecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboPrecios As ComboBox
    Friend WithEvents txtPrecios As TextBox
    Friend WithEvents btnBuscarPrecios As Button
    Friend WithEvents tblPreciosDefecto As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents btnModificarPrecio As Button
End Class
