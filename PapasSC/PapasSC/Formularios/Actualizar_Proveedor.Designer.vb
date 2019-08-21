<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actualizar_Proveedor
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboCiudadProve = New System.Windows.Forms.ComboBox()
        Me.txtEmailProvee = New System.Windows.Forms.TextBox()
        Me.txtTelefonoProvee = New System.Windows.Forms.TextBox()
        Me.txtNombrePro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAceptarProvee = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cboCiudadProve)
        Me.Panel1.Controls.Add(Me.txtEmailProvee)
        Me.Panel1.Controls.Add(Me.txtTelefonoProvee)
        Me.Panel1.Controls.Add(Me.txtNombrePro)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(15, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 161)
        Me.Panel1.TabIndex = 11
        '
        'cboCiudadProve
        '
        Me.cboCiudadProve.FormattingEnabled = True
        Me.cboCiudadProve.Location = New System.Drawing.Point(125, 126)
        Me.cboCiudadProve.Name = "cboCiudadProve"
        Me.cboCiudadProve.Size = New System.Drawing.Size(173, 21)
        Me.cboCiudadProve.TabIndex = 15
        '
        'txtEmailProvee
        '
        Me.txtEmailProvee.Location = New System.Drawing.Point(125, 87)
        Me.txtEmailProvee.Name = "txtEmailProvee"
        Me.txtEmailProvee.Size = New System.Drawing.Size(173, 20)
        Me.txtEmailProvee.TabIndex = 14
        '
        'txtTelefonoProvee
        '
        Me.txtTelefonoProvee.Location = New System.Drawing.Point(125, 49)
        Me.txtTelefonoProvee.Name = "txtTelefonoProvee"
        Me.txtTelefonoProvee.Size = New System.Drawing.Size(173, 20)
        Me.txtTelefonoProvee.TabIndex = 13
        '
        'txtNombrePro
        '
        Me.txtNombrePro.Location = New System.Drawing.Point(125, 13)
        Me.txtNombrePro.Name = "txtNombrePro"
        Me.txtNombrePro.Size = New System.Drawing.Size(173, 20)
        Me.txtNombrePro.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Ciudad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Teléfono"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(290, 210)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnAceptarProvee
        '
        Me.btnAceptarProvee.Location = New System.Drawing.Point(200, 210)
        Me.btnAceptarProvee.Name = "btnAceptarProvee"
        Me.btnAceptarProvee.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarProvee.TabIndex = 12
        Me.btnAceptarProvee.Text = "Aceptar"
        Me.btnAceptarProvee.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label5.Location = New System.Drawing.Point(367, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "X"
        '
        'Actualizar_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 259)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAceptarProvee)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Actualizar_Proveedor"
        Me.Text = "Actualizar_Proveedor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cboCiudadProve As ComboBox
    Friend WithEvents txtEmailProvee As TextBox
    Friend WithEvents txtTelefonoProvee As TextBox
    Friend WithEvents txtNombrePro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnAceptarProvee As Button
    Friend WithEvents Label5 As Label
End Class
