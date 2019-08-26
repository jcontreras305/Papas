<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Actualizar_Proveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Actualizar_Proveedor))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label6.Location = New System.Drawing.Point(81, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 19)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Registrar Proveedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label5.Location = New System.Drawing.Point(375, -4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "X"
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
        Me.Panel1.Location = New System.Drawing.Point(12, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 179)
        Me.Panel1.TabIndex = 16
        '
        'cboCiudadProve
        '
        Me.cboCiudadProve.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCiudadProve.FormattingEnabled = True
        Me.cboCiudadProve.Location = New System.Drawing.Point(104, 126)
        Me.cboCiudadProve.Name = "cboCiudadProve"
        Me.cboCiudadProve.Size = New System.Drawing.Size(173, 28)
        Me.cboCiudadProve.TabIndex = 15
        '
        'txtEmailProvee
        '
        Me.txtEmailProvee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailProvee.Location = New System.Drawing.Point(104, 87)
        Me.txtEmailProvee.Name = "txtEmailProvee"
        Me.txtEmailProvee.Size = New System.Drawing.Size(173, 26)
        Me.txtEmailProvee.TabIndex = 14
        '
        'txtTelefonoProvee
        '
        Me.txtTelefonoProvee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoProvee.Location = New System.Drawing.Point(104, 49)
        Me.txtTelefonoProvee.Name = "txtTelefonoProvee"
        Me.txtTelefonoProvee.Size = New System.Drawing.Size(173, 26)
        Me.txtTelefonoProvee.TabIndex = 13
        '
        'txtNombrePro
        '
        Me.txtNombrePro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrePro.Location = New System.Drawing.Point(104, 13)
        Me.txtNombrePro.Name = "txtNombrePro"
        Me.txtNombrePro.Size = New System.Drawing.Size(173, 26)
        Me.txtNombrePro.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Ciudad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Teléfono"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(251, 223)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 39)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnAceptarProvee
        '
        Me.btnAceptarProvee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarProvee.Image = CType(resources.GetObject("btnAceptarProvee.Image"), System.Drawing.Image)
        Me.btnAceptarProvee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptarProvee.Location = New System.Drawing.Point(133, 223)
        Me.btnAceptarProvee.Name = "btnAceptarProvee"
        Me.btnAceptarProvee.Size = New System.Drawing.Size(111, 39)
        Me.btnAceptarProvee.TabIndex = 14
        Me.btnAceptarProvee.Text = "Confirmar"
        Me.btnAceptarProvee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptarProvee.UseVisualStyleBackColor = True
        '
        'Actualizar_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 277)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAceptarProvee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Actualizar_Proveedor"
        Me.Text = "Actualizar_Proveedor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
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
End Class
