<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tickets
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
        Me.tblVentas = New System.Windows.Forms.DataGridView()
        Me.btnPruebaTicket = New System.Windows.Forms.Button()
        CType(Me.tblVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblVentas
        '
        Me.tblVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblVentas.Location = New System.Drawing.Point(19, 195)
        Me.tblVentas.Name = "tblVentas"
        Me.tblVentas.Size = New System.Drawing.Size(769, 212)
        Me.tblVentas.TabIndex = 0
        '
        'btnPruebaTicket
        '
        Me.btnPruebaTicket.Location = New System.Drawing.Point(713, 166)
        Me.btnPruebaTicket.Name = "btnPruebaTicket"
        Me.btnPruebaTicket.Size = New System.Drawing.Size(75, 23)
        Me.btnPruebaTicket.TabIndex = 1
        Me.btnPruebaTicket.Text = "Prueba "
        Me.btnPruebaTicket.UseVisualStyleBackColor = True
        '
        'tickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPruebaTicket)
        Me.Controls.Add(Me.tblVentas)
        Me.Name = "tickets"
        Me.Text = "tickets"
        CType(Me.tblVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblVentas As DataGridView
    Friend WithEvents btnPruebaTicket As Button
End Class
