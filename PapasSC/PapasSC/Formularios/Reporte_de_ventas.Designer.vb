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
        Me.lbl = New System.Windows.Forms.Label()
        Me.cboCaja = New System.Windows.Forms.ComboBox()
        Me.txtGenerar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(27, 55)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(28, 13)
        Me.lbl.TabIndex = 0
        Me.lbl.Text = "Caja"
        '
        'cboCaja
        '
        Me.cboCaja.FormattingEnabled = True
        Me.cboCaja.Location = New System.Drawing.Point(72, 52)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.Size = New System.Drawing.Size(151, 21)
        Me.cboCaja.TabIndex = 1
        '
        'txtGenerar
        '
        Me.txtGenerar.Location = New System.Drawing.Point(250, 50)
        Me.txtGenerar.Name = "txtGenerar"
        Me.txtGenerar.Size = New System.Drawing.Size(105, 34)
        Me.txtGenerar.TabIndex = 2
        Me.txtGenerar.Text = "Generar"
        Me.txtGenerar.UseVisualStyleBackColor = True
        '
        'Reporte_de_ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 138)
        Me.Controls.Add(Me.txtGenerar)
        Me.Controls.Add(Me.cboCaja)
        Me.Controls.Add(Me.lbl)
        Me.Name = "Reporte_de_ventas"
        Me.Text = "Reporte_de_ventas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl As Label
    Friend WithEvents cboCaja As ComboBox
    Friend WithEvents txtGenerar As Button
End Class
