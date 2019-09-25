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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.tblVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblVentas
        '
        Me.tblVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblVentas.Location = New System.Drawing.Point(19, 75)
        Me.tblVentas.Name = "tblVentas"
        Me.tblVentas.Size = New System.Drawing.Size(769, 198)
        Me.tblVentas.TabIndex = 0
        '
        'btnPruebaTicket
        '
        Me.btnPruebaTicket.Location = New System.Drawing.Point(713, 29)
        Me.btnPruebaTicket.Name = "btnPruebaTicket"
        Me.btnPruebaTicket.Size = New System.Drawing.Size(75, 23)
        Me.btnPruebaTicket.TabIndex = 1
        Me.btnPruebaTicket.Text = "Prueba "
        Me.btnPruebaTicket.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.PapasSC.My.Resources.Resources.CANCELAR
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(540, 279)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(71, 38)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.PapasSC.My.Resources.Resources.NUEVO
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(617, 279)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 38)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Nuevo"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.PapasSC.My.Resources.Resources.ACTUALIZAR
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(698, 279)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 38)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Modificar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'tickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 323)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnPruebaTicket)
        Me.Controls.Add(Me.tblVentas)
        Me.Name = "tickets"
        Me.Text = "tickets"
        CType(Me.tblVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblVentas As DataGridView
    Friend WithEvents btnPruebaTicket As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Button3 As Button
End Class
