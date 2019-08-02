<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_Clientes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtrfc = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bntConfirmar = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtAlias = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbTipoPersona = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbRazonSocial = New System.Windows.Forms.RadioButton()
        Me.rdbMujer = New System.Windows.Forms.RadioButton()
        Me.rdbHombre = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCodigoPostal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.spnDiasCredito = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtLimiteCredito = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.spnDiasCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "RFC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Razon Social"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(197, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(90, 14)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(204, 20)
        Me.txtNombre.TabIndex = 8
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(90, 74)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(204, 20)
        Me.txtRazonSocial.TabIndex = 9
        '
        'txtrfc
        '
        Me.txtrfc.Location = New System.Drawing.Point(90, 42)
        Me.txtrfc.Name = "txtrfc"
        Me.txtrfc.Size = New System.Drawing.Size(204, 20)
        Me.txtrfc.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(413, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bntConfirmar
        '
        Me.bntConfirmar.Location = New System.Drawing.Point(504, 162)
        Me.bntConfirmar.Name = "bntConfirmar"
        Me.bntConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.bntConfirmar.TabIndex = 16
        Me.bntConfirmar.Text = "Confirmar"
        Me.bntConfirmar.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(80, 36)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(204, 20)
        Me.txtDireccion.TabIndex = 21
        '
        'txtAlias
        '
        Me.txtAlias.Location = New System.Drawing.Point(80, 7)
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(156, 20)
        Me.txtAlias.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Direccion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Alias"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cmbTipoPersona)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.txtRazonSocial)
        Me.Panel1.Controls.Add(Me.txtrfc)
        Me.Panel1.Location = New System.Drawing.Point(12, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(602, 120)
        Me.Panel1.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(332, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Tipo de Persona"
        '
        'cmbTipoPersona
        '
        Me.cmbTipoPersona.FormattingEnabled = True
        Me.cmbTipoPersona.Items.AddRange(New Object() {"Fisica", "Moral"})
        Me.cmbTipoPersona.Location = New System.Drawing.Point(427, 12)
        Me.cmbTipoPersona.Name = "cmbTipoPersona"
        Me.cmbTipoPersona.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoPersona.TabIndex = 11
        Me.cmbTipoPersona.Text = "Física"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmbEstado)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.bntConfirmar)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.txtCodigoPostal)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txtMunicipio)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txtEmail)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txtTelefono)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtDireccion)
        Me.Panel2.Controls.Add(Me.txtAlias)
        Me.Panel2.Location = New System.Drawing.Point(12, 274)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(602, 205)
        Me.Panel2.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbRazonSocial)
        Me.GroupBox1.Controls.Add(Me.rdbMujer)
        Me.GroupBox1.Controls.Add(Me.rdbHombre)
        Me.GroupBox1.Location = New System.Drawing.Point(342, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(198, 51)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexo"
        '
        'rdbRazonSocial
        '
        Me.rdbRazonSocial.AutoSize = True
        Me.rdbRazonSocial.Location = New System.Drawing.Point(122, 19)
        Me.rdbRazonSocial.Name = "rdbRazonSocial"
        Me.rdbRazonSocial.Size = New System.Drawing.Size(70, 17)
        Me.rdbRazonSocial.TabIndex = 32
        Me.rdbRazonSocial.TabStop = True
        Me.rdbRazonSocial.Text = "No aplica"
        Me.rdbRazonSocial.UseVisualStyleBackColor = True
        '
        'rdbMujer
        '
        Me.rdbMujer.AutoSize = True
        Me.rdbMujer.Location = New System.Drawing.Point(6, 19)
        Me.rdbMujer.Name = "rdbMujer"
        Me.rdbMujer.Size = New System.Drawing.Size(51, 17)
        Me.rdbMujer.TabIndex = 31
        Me.rdbMujer.TabStop = True
        Me.rdbMujer.Text = "Mujer"
        Me.rdbMujer.UseVisualStyleBackColor = True
        '
        'rdbHombre
        '
        Me.rdbHombre.AutoSize = True
        Me.rdbHombre.Location = New System.Drawing.Point(59, 19)
        Me.rdbHombre.Name = "rdbHombre"
        Me.rdbHombre.Size = New System.Drawing.Size(62, 17)
        Me.rdbHombre.TabIndex = 32
        Me.rdbHombre.TabStop = True
        Me.rdbHombre.Text = "Hombre"
        Me.rdbHombre.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 66)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Codigo postal"
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.Location = New System.Drawing.Point(80, 66)
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(204, 20)
        Me.txtCodigoPostal.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(339, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Estado"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(339, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Municipio"
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(397, 36)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(138, 20)
        Me.txtMunicipio.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(339, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(397, 10)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(138, 20)
        Me.txtEmail.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 98)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Telefono"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(80, 98)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(138, 20)
        Me.txtTelefono.TabIndex = 23
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.spnDiasCredito)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.txtLimiteCredito)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Location = New System.Drawing.Point(12, 161)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(602, 107)
        Me.Panel3.TabIndex = 25
        '
        'spnDiasCredito
        '
        Me.spnDiasCredito.Location = New System.Drawing.Point(97, 48)
        Me.spnDiasCredito.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.spnDiasCredito.Name = "spnDiasCredito"
        Me.spnDiasCredito.Size = New System.Drawing.Size(156, 20)
        Me.spnDiasCredito.TabIndex = 29
        Me.spnDiasCredito.Tag = ""
        Me.spnDiasCredito.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Limite de Credito"
        '
        'txtLimiteCredito
        '
        Me.txtLimiteCredito.Location = New System.Drawing.Point(97, 13)
        Me.txtLimiteCredito.Name = "txtLimiteCredito"
        Me.txtLimiteCredito.Size = New System.Drawing.Size(156, 20)
        Me.txtLimiteCredito.TabIndex = 28
        Me.txtLimiteCredito.Text = "10000,00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "DIas de credito"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label9.Location = New System.Drawing.Point(3, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 24)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "X"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label16.Location = New System.Drawing.Point(291, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(147, 24)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Nuevo cliente"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"AGUAS CUALIENTES", "BAJA CALIFORNIA NORTE", "BAJA CALIFORNIA SUR", "CAMPECHE", "CHIAPAS", "CHIHUAUA", "COAHUILA", "COLIMA", "DURANGO", "ESTADO DE MEXICO", "GUANAJUATO", "GUERRRERO", "HIDALGO", "JALISCO", "MICHOACAN", "MORELOS", "NAYARIT", "NUEVO LEON", "OAXACA", "PUEBLA", "QUERETARO", "QUINTANA ROO", "SAN LUIS POTOSI", "SINALOA", "SONORA", "TABASCO", "TAMAULIPAS", "TLAXCALA", "VERACRUZ", "YUCATAN ", "ZACATECAS", "ESTADO UNIDOS DE AMERICA"})
        Me.cmbEstado.Location = New System.Drawing.Point(397, 63)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(142, 21)
        Me.cmbEstado.TabIndex = 34
        '
        'Registro_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 490)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Registro_Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.spnDiasCredito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents txtrfc As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents bntConfirmar As Button
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtAlias As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents txtLimiteCredito As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCodigoPostal As TextBox
    Friend WithEvents rdbRazonSocial As RadioButton
    Friend WithEvents rdbHombre As RadioButton
    Friend WithEvents rdbMujer As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents spnDiasCredito As NumericUpDown
    Friend WithEvents cmbTipoPersona As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbEstado As ComboBox
End Class
