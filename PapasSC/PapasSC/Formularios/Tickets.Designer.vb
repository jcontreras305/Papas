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
        Me.tblFormatostTicket = New System.Windows.Forms.DataGridView()
        Me.btnPruebaTicket = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        CType(Me.tblFormatostTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblFormatostTicket
        '
        Me.tblFormatostTicket.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblFormatostTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblFormatostTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblFormatostTicket.Location = New System.Drawing.Point(19, 75)
        Me.tblFormatostTicket.Name = "tblFormatostTicket"
        Me.tblFormatostTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblFormatostTicket.Size = New System.Drawing.Size(570, 198)
        Me.tblFormatostTicket.TabIndex = 0
        '
        'btnPruebaTicket
        '
        Me.btnPruebaTicket.Location = New System.Drawing.Point(514, 46)
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
        Me.btnSalir.Location = New System.Drawing.Point(341, 279)
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
        Me.btnAgregar.Location = New System.Drawing.Point(418, 279)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 38)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Nuevo"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.PapasSC.My.Resources.Resources.ACTUALIZAR
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(499, 279)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(90, 38)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'tickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 323)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnPruebaTicket)
        Me.Controls.Add(Me.tblFormatostTicket)
        Me.Name = "tickets"
        Me.Text = "tickets"
        CType(Me.tblFormatostTicket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPruebaTicket As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Public WithEvents tblFormatostTicket As DataGridView
End Class
