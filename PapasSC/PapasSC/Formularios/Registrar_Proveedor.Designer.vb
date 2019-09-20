<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registrar_Proveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_Proveedor))
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCamObli3 = New System.Windows.Forms.Label()
        Me.lblCamObli2 = New System.Windows.Forms.Label()
        Me.lblCamObli1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdbNoApliPro = New System.Windows.Forms.RadioButton()
        Me.rdbMasculinoProvee = New System.Windows.Forms.RadioButton()
        Me.rdbFemeninoProvee = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAliasProvee = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTipoPersonaPro = New System.Windows.Forms.ComboBox()
        Me.txtRazonSocialProvee = New System.Windows.Forms.TextBox()
        Me.txtRfcProvee = New System.Windows.Forms.TextBox()
        Me.txtNombreProvee = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblOrigenMatriz = New System.Windows.Forms.Label()
        Me.cboOrigenCiudad = New System.Windows.Forms.ComboBox()
        Me.lblCamObli4 = New System.Windows.Forms.Label()
        Me.cboEstadoProvee = New System.Windows.Forms.ComboBox()
        Me.chbExtras = New System.Windows.Forms.CheckBox()
        Me.lblEmail2 = New System.Windows.Forms.Label()
        Me.lblTelefono2 = New System.Windows.Forms.Label()
        Me.lblDireccion2 = New System.Windows.Forms.Label()
        Me.txtEmail2 = New System.Windows.Forms.TextBox()
        Me.txtTelefono2 = New System.Windows.Forms.TextBox()
        Me.txtDireccion2 = New System.Windows.Forms.TextBox()
        Me.txtMunicipioPro = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCodigoPostalPro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelefonoPro = New System.Windows.Forms.TextBox()
        Me.txtEmailPro = New System.Windows.Forms.TextBox()
        Me.txtDomicilioPro = New System.Windows.Forms.TextBox()
        Me.bntConfirmar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chbActivo = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCamObli3)
        Me.GroupBox1.Controls.Add(Me.lblCamObli2)
        Me.GroupBox1.Controls.Add(Me.lblCamObli1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtAliasProvee)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboTipoPersonaPro)
        Me.GroupBox1.Controls.Add(Me.txtRazonSocialProvee)
        Me.GroupBox1.Controls.Add(Me.txtRfcProvee)
        Me.GroupBox1.Controls.Add(Me.txtNombreProvee)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(649, 155)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Principales"
        '
        'lblCamObli3
        '
        Me.lblCamObli3.AutoSize = True
        Me.lblCamObli3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCamObli3.ForeColor = System.Drawing.Color.Red
        Me.lblCamObli3.Location = New System.Drawing.Point(628, 53)
        Me.lblCamObli3.Name = "lblCamObli3"
        Me.lblCamObli3.Size = New System.Drawing.Size(15, 20)
        Me.lblCamObli3.TabIndex = 38
        Me.lblCamObli3.Text = "*"
        '
        'lblCamObli2
        '
        Me.lblCamObli2.AutoSize = True
        Me.lblCamObli2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCamObli2.ForeColor = System.Drawing.Color.Red
        Me.lblCamObli2.Location = New System.Drawing.Point(298, 82)
        Me.lblCamObli2.Name = "lblCamObli2"
        Me.lblCamObli2.Size = New System.Drawing.Size(15, 20)
        Me.lblCamObli2.TabIndex = 37
        Me.lblCamObli2.Text = "*"
        '
        'lblCamObli1
        '
        Me.lblCamObli1.AutoSize = True
        Me.lblCamObli1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCamObli1.ForeColor = System.Drawing.Color.Red
        Me.lblCamObli1.Location = New System.Drawing.Point(298, 26)
        Me.lblCamObli1.Name = "lblCamObli1"
        Me.lblCamObli1.Size = New System.Drawing.Size(15, 20)
        Me.lblCamObli1.TabIndex = 36
        Me.lblCamObli1.Text = "*"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdbNoApliPro)
        Me.GroupBox3.Controls.Add(Me.rdbMasculinoProvee)
        Me.GroupBox3.Controls.Add(Me.rdbFemeninoProvee)
        Me.GroupBox3.Location = New System.Drawing.Point(379, 82)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(243, 52)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sexo"
        '
        'rdbNoApliPro
        '
        Me.rdbNoApliPro.AutoSize = True
        Me.rdbNoApliPro.Location = New System.Drawing.Point(167, 19)
        Me.rdbNoApliPro.Name = "rdbNoApliPro"
        Me.rdbNoApliPro.Size = New System.Drawing.Size(70, 17)
        Me.rdbNoApliPro.TabIndex = 2
        Me.rdbNoApliPro.TabStop = True
        Me.rdbNoApliPro.Text = "No aplica"
        Me.rdbNoApliPro.UseVisualStyleBackColor = True
        '
        'rdbMasculinoProvee
        '
        Me.rdbMasculinoProvee.AutoSize = True
        Me.rdbMasculinoProvee.Location = New System.Drawing.Point(82, 19)
        Me.rdbMasculinoProvee.Name = "rdbMasculinoProvee"
        Me.rdbMasculinoProvee.Size = New System.Drawing.Size(62, 17)
        Me.rdbMasculinoProvee.TabIndex = 1
        Me.rdbMasculinoProvee.TabStop = True
        Me.rdbMasculinoProvee.Text = "Hombre"
        Me.rdbMasculinoProvee.UseVisualStyleBackColor = True
        '
        'rdbFemeninoProvee
        '
        Me.rdbFemeninoProvee.AutoSize = True
        Me.rdbFemeninoProvee.Location = New System.Drawing.Point(15, 19)
        Me.rdbFemeninoProvee.Name = "rdbFemeninoProvee"
        Me.rdbFemeninoProvee.Size = New System.Drawing.Size(51, 17)
        Me.rdbFemeninoProvee.TabIndex = 0
        Me.rdbFemeninoProvee.TabStop = True
        Me.rdbFemeninoProvee.Text = "Mujer"
        Me.rdbFemeninoProvee.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(387, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Alias"
        '
        'txtAliasProvee
        '
        Me.txtAliasProvee.Location = New System.Drawing.Point(434, 53)
        Me.txtAliasProvee.Name = "txtAliasProvee"
        Me.txtAliasProvee.Size = New System.Drawing.Size(188, 20)
        Me.txtAliasProvee.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "RFC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Razón Social"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(332, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tipo de persona"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre"
        '
        'cboTipoPersonaPro
        '
        Me.cboTipoPersonaPro.FormattingEnabled = True
        Me.cboTipoPersonaPro.Items.AddRange(New Object() {"Física ", "Moral"})
        Me.cboTipoPersonaPro.Location = New System.Drawing.Point(434, 26)
        Me.cboTipoPersonaPro.Name = "cboTipoPersonaPro"
        Me.cboTipoPersonaPro.Size = New System.Drawing.Size(188, 21)
        Me.cboTipoPersonaPro.TabIndex = 3
        Me.cboTipoPersonaPro.Text = "Fisica"
        '
        'txtRazonSocialProvee
        '
        Me.txtRazonSocialProvee.Location = New System.Drawing.Point(104, 79)
        Me.txtRazonSocialProvee.Name = "txtRazonSocialProvee"
        Me.txtRazonSocialProvee.Size = New System.Drawing.Size(188, 20)
        Me.txtRazonSocialProvee.TabIndex = 2
        '
        'txtRfcProvee
        '
        Me.txtRfcProvee.Location = New System.Drawing.Point(104, 53)
        Me.txtRfcProvee.Name = "txtRfcProvee"
        Me.txtRfcProvee.Size = New System.Drawing.Size(188, 20)
        Me.txtRfcProvee.TabIndex = 1
        Me.txtRfcProvee.Text = "XAXX010101000"
        '
        'txtNombreProvee
        '
        Me.txtNombreProvee.Location = New System.Drawing.Point(104, 27)
        Me.txtNombreProvee.Name = "txtNombreProvee"
        Me.txtNombreProvee.Size = New System.Drawing.Size(188, 20)
        Me.txtNombreProvee.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblOrigenMatriz)
        Me.GroupBox2.Controls.Add(Me.cboOrigenCiudad)
        Me.GroupBox2.Controls.Add(Me.lblCamObli4)
        Me.GroupBox2.Controls.Add(Me.cboEstadoProvee)
        Me.GroupBox2.Controls.Add(Me.chbExtras)
        Me.GroupBox2.Controls.Add(Me.lblEmail2)
        Me.GroupBox2.Controls.Add(Me.lblTelefono2)
        Me.GroupBox2.Controls.Add(Me.lblDireccion2)
        Me.GroupBox2.Controls.Add(Me.txtEmail2)
        Me.GroupBox2.Controls.Add(Me.txtTelefono2)
        Me.GroupBox2.Controls.Add(Me.txtDireccion2)
        Me.GroupBox2.Controls.Add(Me.txtMunicipioPro)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtCodigoPostalPro)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtTelefonoPro)
        Me.GroupBox2.Controls.Add(Me.txtEmailPro)
        Me.GroupBox2.Controls.Add(Me.txtDomicilioPro)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 209)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(649, 235)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dirección y contacto"
        '
        'lblOrigenMatriz
        '
        Me.lblOrigenMatriz.AutoSize = True
        Me.lblOrigenMatriz.Location = New System.Drawing.Point(359, 118)
        Me.lblOrigenMatriz.Name = "lblOrigenMatriz"
        Me.lblOrigenMatriz.Size = New System.Drawing.Size(69, 13)
        Me.lblOrigenMatriz.TabIndex = 37
        Me.lblOrigenMatriz.Text = "Origen Matriz"
        '
        'cboOrigenCiudad
        '
        Me.cboOrigenCiudad.FormattingEnabled = True
        Me.cboOrigenCiudad.Location = New System.Drawing.Point(444, 114)
        Me.cboOrigenCiudad.Name = "cboOrigenCiudad"
        Me.cboOrigenCiudad.Size = New System.Drawing.Size(178, 21)
        Me.cboOrigenCiudad.TabIndex = 36
        '
        'lblCamObli4
        '
        Me.lblCamObli4.AutoSize = True
        Me.lblCamObli4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCamObli4.ForeColor = System.Drawing.Color.Red
        Me.lblCamObli4.Location = New System.Drawing.Point(298, 85)
        Me.lblCamObli4.Name = "lblCamObli4"
        Me.lblCamObli4.Size = New System.Drawing.Size(15, 20)
        Me.lblCamObli4.TabIndex = 29
        Me.lblCamObli4.Text = "*"
        '
        'cboEstadoProvee
        '
        Me.cboEstadoProvee.FormattingEnabled = True
        Me.cboEstadoProvee.Items.AddRange(New Object() {"AGUAS CUALIENTES", "BAJA CALIFORNIA NORTE", "BAJA CALIFORNIA SUR", "CAMPECHE", "CHIAPAS", "CHIHUAUA", "COAHUILA", "COLIMA", "DURANGO", "ESTADO DE MEXICO", "GUANAJUATO", "GUERRRERO", "HIDALGO", "JALISCO", "MICHOACAN", "MORELOS", "NAYARIT", "NUEVO LEON", "OAXACA", "PUEBLA", "QUERETARO", "QUINTANA ROO", "SAN LUIS POTOSI", "SINALOA", "SONORA", "TABASCO", "TAMAULIPAS", "TLAXCALA", "VERACRUZ", "YUCATAN ", "ZACATECAS", "ESTADO UNIDOS DE AMERICA"})
        Me.cboEstadoProvee.Location = New System.Drawing.Point(444, 84)
        Me.cboEstadoProvee.Name = "cboEstadoProvee"
        Me.cboEstadoProvee.Size = New System.Drawing.Size(178, 21)
        Me.cboEstadoProvee.TabIndex = 35
        '
        'chbExtras
        '
        Me.chbExtras.AutoSize = True
        Me.chbExtras.Location = New System.Drawing.Point(21, 201)
        Me.chbExtras.Name = "chbExtras"
        Me.chbExtras.Size = New System.Drawing.Size(132, 17)
        Me.chbExtras.TabIndex = 20
        Me.chbExtras.Text = "Activar Campos Extras"
        Me.chbExtras.UseVisualStyleBackColor = True
        '
        'lblEmail2
        '
        Me.lblEmail2.AutoSize = True
        Me.lblEmail2.Location = New System.Drawing.Point(18, 166)
        Me.lblEmail2.Name = "lblEmail2"
        Me.lblEmail2.Size = New System.Drawing.Size(38, 13)
        Me.lblEmail2.TabIndex = 21
        Me.lblEmail2.Text = "Email2"
        '
        'lblTelefono2
        '
        Me.lblTelefono2.AutoSize = True
        Me.lblTelefono2.Location = New System.Drawing.Point(18, 140)
        Me.lblTelefono2.Name = "lblTelefono2"
        Me.lblTelefono2.Size = New System.Drawing.Size(55, 13)
        Me.lblTelefono2.TabIndex = 20
        Me.lblTelefono2.Text = "Teléfono2"
        '
        'lblDireccion2
        '
        Me.lblDireccion2.AutoSize = True
        Me.lblDireccion2.Location = New System.Drawing.Point(18, 114)
        Me.lblDireccion2.Name = "lblDireccion2"
        Me.lblDireccion2.Size = New System.Drawing.Size(58, 13)
        Me.lblDireccion2.TabIndex = 19
        Me.lblDireccion2.Text = "Dirección2"
        '
        'txtEmail2
        '
        Me.txtEmail2.Location = New System.Drawing.Point(104, 163)
        Me.txtEmail2.Name = "txtEmail2"
        Me.txtEmail2.Size = New System.Drawing.Size(188, 20)
        Me.txtEmail2.TabIndex = 18
        '
        'txtTelefono2
        '
        Me.txtTelefono2.Location = New System.Drawing.Point(104, 137)
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.Size = New System.Drawing.Size(188, 20)
        Me.txtTelefono2.TabIndex = 17
        Me.txtTelefono2.Text = "355-000-0000"
        '
        'txtDireccion2
        '
        Me.txtDireccion2.Location = New System.Drawing.Point(104, 111)
        Me.txtDireccion2.Name = "txtDireccion2"
        Me.txtDireccion2.Size = New System.Drawing.Size(242, 20)
        Me.txtDireccion2.TabIndex = 16
        '
        'txtMunicipioPro
        '
        Me.txtMunicipioPro.Location = New System.Drawing.Point(444, 59)
        Me.txtMunicipioPro.Name = "txtMunicipioPro"
        Me.txtMunicipioPro.Size = New System.Drawing.Size(178, 20)
        Me.txtMunicipioPro.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(387, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Estado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(376, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Municipio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Email"
        '
        'txtCodigoPostalPro
        '
        Me.txtCodigoPostalPro.Location = New System.Drawing.Point(444, 33)
        Me.txtCodigoPostalPro.Name = "txtCodigoPostalPro"
        Me.txtCodigoPostalPro.Size = New System.Drawing.Size(178, 20)
        Me.txtCodigoPostalPro.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Teléfono"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(357, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Código postal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Dirección"
        '
        'txtTelefonoPro
        '
        Me.txtTelefonoPro.Location = New System.Drawing.Point(104, 85)
        Me.txtTelefonoPro.Name = "txtTelefonoPro"
        Me.txtTelefonoPro.Size = New System.Drawing.Size(188, 20)
        Me.txtTelefonoPro.TabIndex = 7
        Me.txtTelefonoPro.Text = "355-000-0000"
        '
        'txtEmailPro
        '
        Me.txtEmailPro.Location = New System.Drawing.Point(104, 59)
        Me.txtEmailPro.Name = "txtEmailPro"
        Me.txtEmailPro.Size = New System.Drawing.Size(188, 20)
        Me.txtEmailPro.TabIndex = 6
        '
        'txtDomicilioPro
        '
        Me.txtDomicilioPro.Location = New System.Drawing.Point(104, 33)
        Me.txtDomicilioPro.Name = "txtDomicilioPro"
        Me.txtDomicilioPro.Size = New System.Drawing.Size(242, 20)
        Me.txtDomicilioPro.TabIndex = 5
        '
        'bntConfirmar
        '
        Me.bntConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntConfirmar.Image = CType(resources.GetObject("bntConfirmar.Image"), System.Drawing.Image)
        Me.bntConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntConfirmar.Location = New System.Drawing.Point(560, 450)
        Me.bntConfirmar.Name = "bntConfirmar"
        Me.bntConfirmar.Size = New System.Drawing.Size(111, 39)
        Me.bntConfirmar.TabIndex = 18
        Me.bntConfirmar.Text = "Confirmar"
        Me.bntConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bntConfirmar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(443, 450)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 39)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chbActivo
        '
        Me.chbActivo.AutoSize = True
        Me.chbActivo.Location = New System.Drawing.Point(615, 11)
        Me.chbActivo.Name = "chbActivo"
        Me.chbActivo.Size = New System.Drawing.Size(56, 17)
        Me.chbActivo.TabIndex = 19
        Me.chbActivo.Text = "Activo"
        Me.chbActivo.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label16.Location = New System.Drawing.Point(237, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(213, 24)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Registrar proveedor"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label15.Location = New System.Drawing.Point(1, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 24)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "X"
        '
        'Registrar_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 500)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.chbActivo)
        Me.Controls.Add(Me.bntConfirmar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registrar_Proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar_Proveedor"
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtRazonSocialProvee As TextBox
    Friend WithEvents txtRfcProvee As TextBox
    Friend WithEvents txtNombreProvee As TextBox
    Friend WithEvents txtTelefonoPro As TextBox
    Friend WithEvents txtEmailPro As TextBox
    Friend WithEvents txtDomicilioPro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboTipoPersonaPro As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents bntConfirmar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCodigoPostalPro As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMunicipioPro As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rdbFemeninoProvee As RadioButton
    Friend WithEvents rdbNoApliPro As RadioButton
    Friend WithEvents rdbMasculinoProvee As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAliasProvee As TextBox
    Friend WithEvents chbActivo As CheckBox
    Friend WithEvents chbExtras As CheckBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblEmail2 As Label
    Friend WithEvents lblTelefono2 As Label
    Friend WithEvents lblDireccion2 As Label
    Friend WithEvents txtEmail2 As TextBox
    Friend WithEvents txtTelefono2 As TextBox
    Friend WithEvents txtDireccion2 As TextBox
    Friend WithEvents cboEstadoProvee As ComboBox
    Friend WithEvents lblCamObli2 As Label
    Friend WithEvents lblCamObli1 As Label
    Friend WithEvents lblCamObli3 As Label
    Friend WithEvents lblCamObli4 As Label
    Friend WithEvents lblOrigenMatriz As Label
    Friend WithEvents cboOrigenCiudad As ComboBox
End Class
