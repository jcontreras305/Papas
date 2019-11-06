<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Montocredito
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
        Me.npdCredito = New System.Windows.Forms.NumericUpDown()
        Me.btnAceptar = New System.Windows.Forms.Button()
        CType(Me.npdCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'npdCredito
        '
        Me.npdCredito.Location = New System.Drawing.Point(12, 12)
        Me.npdCredito.Name = "npdCredito"
        Me.npdCredito.Size = New System.Drawing.Size(186, 20)
        Me.npdCredito.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(204, 11)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Montocredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 46)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.npdCredito)
        Me.Name = "Montocredito"
        Me.Text = "Aceptar"
        CType(Me.npdCredito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents npdCredito As NumericUpDown
    Friend WithEvents btnAceptar As Button
End Class
