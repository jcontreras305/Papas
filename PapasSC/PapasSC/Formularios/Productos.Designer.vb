<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Me.txbFiltro = New System.Windows.Forms.TextBox()
        Me.tblProductos = New System.Windows.Forms.DataGridView()
        CType(Me.tblProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txbFiltro
        '
        Me.txbFiltro.Location = New System.Drawing.Point(43, 33)
        Me.txbFiltro.Name = "txbFiltro"
        Me.txbFiltro.Size = New System.Drawing.Size(248, 20)
        Me.txbFiltro.TabIndex = 34
        '
        'tblProductos
        '
        Me.tblProductos.AllowUserToAddRows = False
        Me.tblProductos.AllowUserToDeleteRows = False
        Me.tblProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblProductos.Location = New System.Drawing.Point(43, 59)
        Me.tblProductos.Name = "tblProductos"
        Me.tblProductos.ReadOnly = True
        Me.tblProductos.Size = New System.Drawing.Size(269, 398)
        Me.tblProductos.TabIndex = 33
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 491)
        Me.Controls.Add(Me.txbFiltro)
        Me.Controls.Add(Me.tblProductos)
        Me.Name = "Productos"
        Me.Text = "Productos"
        CType(Me.tblProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txbFiltro As TextBox
    Friend WithEvents tblProductos As DataGridView
End Class
