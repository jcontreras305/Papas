<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Actualizar_Cliente
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Actualizar_Cliente))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chbActivarCredito = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.lbl21 = New System.Windows.Forms.Label()
        Me.lbl20 = New System.Windows.Forms.Label()
        Me.spnDiasCredito = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtLimiteCredito = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chbActivarAcomposExtras = New System.Windows.Forms.CheckBox()
        Me.lblDireccion2 = New System.Windows.Forms.Label()
        Me.txtDireccion2 = New System.Windows.Forms.TextBox()
        Me.txtTelefono2 = New System.Windows.Forms.TextBox()
        Me.lblTelefono2 = New System.Windows.Forms.Label()
        Me.btnElminar = New System.Windows.Forms.Button()
        Me.lbl23 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.bntActualizar = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtCodigoPostal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.lblEmail2 = New System.Windows.Forms.Label()
        Me.txtEmail2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbRazonSocial = New System.Windows.Forms.RadioButton()
        Me.rdbMujer = New System.Windows.Forms.RadioButton()
        Me.rdbHombre = New System.Windows.Forms.RadioButton()
        Me.lbl22 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAlias = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lbl19 = New System.Windows.Forms.Label()
        Me.lbl18 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbTipoPersona = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtrfc = New System.Windows.Forms.TextBox()
        Me.chbActivo = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel3.SuspendLayout()
        CType(Me.spnDiasCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label9.Location = New System.Drawing.Point(3, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 24)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "X"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label16.Location = New System.Drawing.Point(223, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(182, 24)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Acutalizar cliente"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.chbActivarCredito)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.txtSaldo)
        Me.Panel3.Controls.Add(Me.lbl21)
        Me.Panel3.Controls.Add(Me.lbl20)
        Me.Panel3.Controls.Add(Me.spnDiasCredito)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.txtLimiteCredito)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Location = New System.Drawing.Point(12, 161)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(602, 107)
        Me.Panel3.TabIndex = 31
        '
        'chbActivarCredito
        '
        Me.chbActivarCredito.AutoSize = True
        Me.chbActivarCredito.Location = New System.Drawing.Point(504, 3)
        Me.chbActivarCredito.Name = "chbActivarCredito"
        Me.chbActivarCredito.Size = New System.Drawing.Size(95, 17)
        Me.chbActivarCredito.TabIndex = 41
        Me.chbActivarCredito.Text = "Activar Credito"
        Me.chbActivarCredito.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(305, 33)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 13)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Saldo"
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(363, 30)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(131, 20)
        Me.txtSaldo.TabIndex = 39
        '
        'lbl21
        '
        Me.lbl21.AutoSize = True
        Me.lbl21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl21.ForeColor = System.Drawing.Color.Red
        Me.lbl21.Location = New System.Drawing.Point(259, 67)
        Me.lbl21.Name = "lbl21"
        Me.lbl21.Size = New System.Drawing.Size(15, 20)
        Me.lbl21.TabIndex = 31
        Me.lbl21.Text = "*"
        '
        'lbl20
        '
        Me.lbl20.AutoSize = True
        Me.lbl20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl20.ForeColor = System.Drawing.Color.Red
        Me.lbl20.Location = New System.Drawing.Point(259, 28)
        Me.lbl20.Name = "lbl20"
        Me.lbl20.Size = New System.Drawing.Size(15, 20)
        Me.lbl20.TabIndex = 30
        Me.lbl20.Text = "*"
        '
        'spnDiasCredito
        '
        Me.spnDiasCredito.Location = New System.Drawing.Point(97, 63)
        Me.spnDiasCredito.Name = "spnDiasCredito"
        Me.spnDiasCredito.Size = New System.Drawing.Size(156, 20)
        Me.spnDiasCredito.TabIndex = 29
        Me.spnDiasCredito.Tag = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Limite de Credito"
        '
        'txtLimiteCredito
        '
        Me.txtLimiteCredito.Location = New System.Drawing.Point(97, 28)
        Me.txtLimiteCredito.Name = "txtLimiteCredito"
        Me.txtLimiteCredito.Size = New System.Drawing.Size(156, 20)
        Me.txtLimiteCredito.TabIndex = 28
        Me.txtLimiteCredito.Text = "0,00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Días de credito"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chbActivarAcomposExtras)
        Me.Panel2.Controls.Add(Me.lblDireccion2)
        Me.Panel2.Controls.Add(Me.txtDireccion2)
        Me.Panel2.Controls.Add(Me.txtTelefono2)
        Me.Panel2.Controls.Add(Me.lblTelefono2)
        Me.Panel2.Controls.Add(Me.btnElminar)
        Me.Panel2.Controls.Add(Me.lbl23)
        Me.Panel2.Controls.Add(Me.cmbEstado)
        Me.Panel2.Controls.Add(Me.bntActualizar)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.btnCancelar)
        Me.Panel2.Controls.Add(Me.txtCodigoPostal)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txtMunicipio)
        Me.Panel2.Controls.Add(Me.lblEmail2)
        Me.Panel2.Controls.Add(Me.txtEmail2)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txtEmail)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txtTelefono)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtDireccion)
        Me.Panel2.Location = New System.Drawing.Point(12, 274)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(602, 207)
        Me.Panel2.TabIndex = 30
        '
        'chbActivarAcomposExtras
        '
        Me.chbActivarAcomposExtras.AutoSize = True
        Me.chbActivarAcomposExtras.Location = New System.Drawing.Point(29, 174)
        Me.chbActivarAcomposExtras.Name = "chbActivarAcomposExtras"
        Me.chbActivarAcomposExtras.Size = New System.Drawing.Size(126, 17)
        Me.chbActivarAcomposExtras.TabIndex = 43
        Me.chbActivarAcomposExtras.Text = "ActivarCamposExtras"
        Me.chbActivarAcomposExtras.UseVisualStyleBackColor = True
        '
        'lblDireccion2
        '
        Me.lblDireccion2.AutoSize = True
        Me.lblDireccion2.Location = New System.Drawing.Point(5, 92)
        Me.lblDireccion2.Name = "lblDireccion2"
        Me.lblDireccion2.Size = New System.Drawing.Size(58, 13)
        Me.lblDireccion2.TabIndex = 41
        Me.lblDireccion2.Text = "Direccion2"
        '
        'txtDireccion2
        '
        Me.txtDireccion2.Location = New System.Drawing.Point(80, 85)
        Me.txtDireccion2.Name = "txtDireccion2"
        Me.txtDireccion2.Size = New System.Drawing.Size(204, 20)
        Me.txtDireccion2.TabIndex = 42
        '
        'txtTelefono2
        '
        Me.txtTelefono2.Location = New System.Drawing.Point(81, 109)
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.Size = New System.Drawing.Size(138, 20)
        Me.txtTelefono2.TabIndex = 40
        '
        'lblTelefono2
        '
        Me.lblTelefono2.AutoSize = True
        Me.lblTelefono2.Location = New System.Drawing.Point(8, 116)
        Me.lblTelefono2.Name = "lblTelefono2"
        Me.lblTelefono2.Size = New System.Drawing.Size(55, 13)
        Me.lblTelefono2.TabIndex = 39
        Me.lblTelefono2.Text = "Telefono2"
        '
        'btnElminar
        '
        Me.btnElminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnElminar.Image = CType(resources.GetObject("btnElminar.Image"), System.Drawing.Image)
        Me.btnElminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnElminar.Location = New System.Drawing.Point(246, 161)
        Me.btnElminar.Name = "btnElminar"
        Me.btnElminar.Size = New System.Drawing.Size(111, 39)
        Me.btnElminar.TabIndex = 37
        Me.btnElminar.Text = "Eliminar"
        Me.btnElminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnElminar.UseVisualStyleBackColor = True
        '
        'lbl23
        '
        Me.lbl23.AutoSize = True
        Me.lbl23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl23.ForeColor = System.Drawing.Color.Red
        Me.lbl23.Location = New System.Drawing.Point(222, 42)
        Me.lbl23.Name = "lbl23"
        Me.lbl23.Size = New System.Drawing.Size(15, 20)
        Me.lbl23.TabIndex = 36
        Me.lbl23.Text = "*"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"AGUAS CUALIENTES", "BAJA CALIFORNIA NORTE", "BAJA CALIFORNIA SUR", "CAMPECHE", "CHIAPAS", "CHIHUAUA", "COAHUILA", "COLIMA", "DURANGO", "ESTADO DE MEXICO", "GUANAJUATO", "GUERRRERO", "HIDALGO", "JALISCO", "MICHOACAN", "MORELOS", "NAYARIT", "NUEVO LEON", "OAXACA", "PUEBLA", "QUERETARO", "QUINTANA ROO", "SAN LUIS POTOSI", "SINALOA", "SONORA", "TABASCO", "TAMAULIPAS", "TLAXCALA", "VERACRUZ", "YUCATAN ", "ZACATECAS", "ESTADO UNIDOS DE AMERICA"})
        Me.cmbEstado.Location = New System.Drawing.Point(397, 63)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(156, 21)
        Me.cmbEstado.TabIndex = 34
        '
        'bntActualizar
        '
        Me.bntActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntActualizar.Image = CType(resources.GetObject("bntActualizar.Image"), System.Drawing.Image)
        Me.bntActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntActualizar.Location = New System.Drawing.Point(480, 161)
        Me.bntActualizar.Name = "bntActualizar"
        Me.bntActualizar.Size = New System.Drawing.Size(111, 39)
        Me.bntActualizar.TabIndex = 16
        Me.bntActualizar.Text = "Actualizar"
        Me.bntActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bntActualizar.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(320, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Codigo postal"
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(363, 161)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(111, 39)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "     Salir"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.Location = New System.Drawing.Point(397, 14)
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(156, 20)
        Me.txtCodigoPostal.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(339, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Estado"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(339, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Municipio"
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(397, 39)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(156, 20)
        Me.txtMunicipio.TabIndex = 27
        '
        'lblEmail2
        '
        Me.lblEmail2.AutoSize = True
        Me.lblEmail2.Location = New System.Drawing.Point(25, 137)
        Me.lblEmail2.Name = "lblEmail2"
        Me.lblEmail2.Size = New System.Drawing.Size(38, 13)
        Me.lblEmail2.TabIndex = 26
        Me.lblEmail2.Text = "Email2"
        '
        'txtEmail2
        '
        Me.txtEmail2.Location = New System.Drawing.Point(81, 131)
        Me.txtEmail2.Name = "txtEmail2"
        Me.txtEmail2.Size = New System.Drawing.Size(138, 20)
        Me.txtEmail2.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(80, 62)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(138, 20)
        Me.txtEmail.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Telefono"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(81, 38)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(138, 20)
        Me.txtTelefono.TabIndex = 23
        Me.txtTelefono.Text = "355-000-0000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Direccion"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(81, 14)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(204, 20)
        Me.txtDireccion.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbRazonSocial)
        Me.GroupBox1.Controls.Add(Me.rdbMujer)
        Me.GroupBox1.Controls.Add(Me.rdbHombre)
        Me.GroupBox1.Location = New System.Drawing.Point(385, 66)
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
        'lbl22
        '
        Me.lbl22.AutoSize = True
        Me.lbl22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl22.ForeColor = System.Drawing.Color.Red
        Me.lbl22.Location = New System.Drawing.Point(584, 46)
        Me.lbl22.Name = "lbl22"
        Me.lbl22.Size = New System.Drawing.Size(15, 20)
        Me.lbl22.TabIndex = 35
        Me.lbl22.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(386, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Alias"
        '
        'txtAlias
        '
        Me.txtAlias.Location = New System.Drawing.Point(427, 42)
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(156, 20)
        Me.txtAlias.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl22)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.lbl19)
        Me.Panel1.Controls.Add(Me.lbl18)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cmbTipoPersona)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtRazonSocial)
        Me.Panel1.Controls.Add(Me.txtrfc)
        Me.Panel1.Controls.Add(Me.txtAlias)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(12, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(602, 120)
        Me.Panel1.TabIndex = 29
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(90, 14)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(204, 20)
        Me.txtNombre.TabIndex = 15
        '
        'lbl19
        '
        Me.lbl19.AutoSize = True
        Me.lbl19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl19.ForeColor = System.Drawing.Color.Red
        Me.lbl19.Location = New System.Drawing.Point(298, 76)
        Me.lbl19.Name = "lbl19"
        Me.lbl19.Size = New System.Drawing.Size(15, 20)
        Me.lbl19.TabIndex = 14
        Me.lbl19.Text = "*"
        '
        'lbl18
        '
        Me.lbl18.AutoSize = True
        Me.lbl18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl18.ForeColor = System.Drawing.Color.Red
        Me.lbl18.Location = New System.Drawing.Point(300, 17)
        Me.lbl18.Name = "lbl18"
        Me.lbl18.Size = New System.Drawing.Size(15, 20)
        Me.lbl18.TabIndex = 13
        Me.lbl18.Text = "*"
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
        Me.cmbTipoPersona.Size = New System.Drawing.Size(156, 21)
        Me.cmbTipoPersona.TabIndex = 11
        Me.cmbTipoPersona.Text = "Física"
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
        Me.txtrfc.Text = "XAXX010101000"
        '
        'chbActivo
        '
        Me.chbActivo.AutoSize = True
        Me.chbActivo.Location = New System.Drawing.Point(558, 9)
        Me.chbActivo.Name = "chbActivo"
        Me.chbActivo.Size = New System.Drawing.Size(56, 17)
        Me.chbActivo.TabIndex = 21
        Me.chbActivo.Text = "Activo"
        Me.chbActivo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(197, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 28
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Actualizar_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 493)
        Me.Controls.Add(Me.chbActivo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Actualizar_Cliente"
        Me.Text = "Actualizar Cliente"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.spnDiasCredito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl21 As Label
    Friend WithEvents lbl20 As Label
    Friend WithEvents spnDiasCredito As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents txtLimiteCredito As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl23 As Label
    Friend WithEvents lbl22 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbRazonSocial As RadioButton
    Friend WithEvents rdbMujer As RadioButton
    Friend WithEvents rdbHombre As RadioButton
    Friend WithEvents bntActualizar As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtCodigoPostal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtAlias As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl19 As Label
    Friend WithEvents lbl18 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbTipoPersona As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents txtrfc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnElminar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents chbActivo As CheckBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents chbActivarCredito As CheckBox
    Friend WithEvents lblDireccion2 As Label
    Friend WithEvents txtDireccion2 As TextBox
    Friend WithEvents txtTelefono2 As TextBox
    Friend WithEvents lblTelefono2 As Label
    Friend WithEvents lblEmail2 As Label
    Friend WithEvents txtEmail2 As TextBox
    Friend WithEvents chbActivarAcomposExtras As CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
