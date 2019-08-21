<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Perfiles
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
        Me.components = New System.ComponentModel.Container()
        Me.lblCerrar = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.pnlDatosUsuario = New System.Windows.Forms.Panel()
        Me.chbActivo = New System.Windows.Forms.CheckBox()
        Me.cmbEmpleado = New System.Windows.Forms.ComboBox()
        Me.txtContasenia = New System.Windows.Forms.TextBox()
        Me.cmbTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbNombreUsuario = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tblUsuarios = New System.Windows.Forms.DataGridView()
        Me.btnAgragar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.errorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCargarDatos = New System.Windows.Forms.Button()
        Me.pnlDatosUsuario.SuspendLayout()
        CType(Me.tblUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCerrar
        '
        Me.lblCerrar.AutoSize = True
        Me.lblCerrar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCerrar.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblCerrar.Location = New System.Drawing.Point(3, 3)
        Me.lblCerrar.Name = "lblCerrar"
        Me.lblCerrar.Size = New System.Drawing.Size(24, 24)
        Me.lblCerrar.TabIndex = 35
        Me.lblCerrar.Text = "X"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label16.Location = New System.Drawing.Point(192, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(174, 24)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Configurar Perfil"
        '
        'pnlDatosUsuario
        '
        Me.pnlDatosUsuario.Controls.Add(Me.btnCargarDatos)
        Me.pnlDatosUsuario.Controls.Add(Me.chbActivo)
        Me.pnlDatosUsuario.Controls.Add(Me.cmbEmpleado)
        Me.pnlDatosUsuario.Controls.Add(Me.txtContasenia)
        Me.pnlDatosUsuario.Controls.Add(Me.cmbTipoUsuario)
        Me.pnlDatosUsuario.Controls.Add(Me.txtUsuario)
        Me.pnlDatosUsuario.Controls.Add(Me.Label5)
        Me.pnlDatosUsuario.Controls.Add(Me.Label4)
        Me.pnlDatosUsuario.Controls.Add(Me.Label3)
        Me.pnlDatosUsuario.Controls.Add(Me.Label2)
        Me.pnlDatosUsuario.Controls.Add(Me.cmbNombreUsuario)
        Me.pnlDatosUsuario.Controls.Add(Me.Label1)
        Me.pnlDatosUsuario.Location = New System.Drawing.Point(7, 266)
        Me.pnlDatosUsuario.Name = "pnlDatosUsuario"
        Me.pnlDatosUsuario.Size = New System.Drawing.Size(545, 109)
        Me.pnlDatosUsuario.TabIndex = 36
        '
        'chbActivo
        '
        Me.chbActivo.AutoSize = True
        Me.chbActivo.Location = New System.Drawing.Point(459, 11)
        Me.chbActivo.Name = "chbActivo"
        Me.chbActivo.Size = New System.Drawing.Size(56, 17)
        Me.chbActivo.TabIndex = 14
        Me.chbActivo.Text = "Activo"
        Me.chbActivo.UseVisualStyleBackColor = True
        '
        'cmbEmpleado
        '
        Me.cmbEmpleado.FormattingEnabled = True
        Me.cmbEmpleado.Location = New System.Drawing.Point(67, 36)
        Me.cmbEmpleado.Name = "cmbEmpleado"
        Me.cmbEmpleado.Size = New System.Drawing.Size(178, 21)
        Me.cmbEmpleado.TabIndex = 10
        '
        'txtContasenia
        '
        Me.txtContasenia.Location = New System.Drawing.Point(337, 73)
        Me.txtContasenia.Name = "txtContasenia"
        Me.txtContasenia.Size = New System.Drawing.Size(178, 20)
        Me.txtContasenia.TabIndex = 9
        '
        'cmbTipoUsuario
        '
        Me.cmbTipoUsuario.FormattingEnabled = True
        Me.cmbTipoUsuario.Items.AddRange(New Object() {"Venta ", "Operacion ", "Administracion"})
        Me.cmbTipoUsuario.Location = New System.Drawing.Point(93, 71)
        Me.cmbTipoUsuario.Name = "cmbTipoUsuario"
        Me.cmbTipoUsuario.Size = New System.Drawing.Size(150, 21)
        Me.cmbTipoUsuario.TabIndex = 8
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(337, 44)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(178, 20)
        Me.txtUsuario.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Empleado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tipo de Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(277, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(277, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Usuario"
        '
        'cmbNombreUsuario
        '
        Me.cmbNombreUsuario.FormattingEnabled = True
        Me.cmbNombreUsuario.Location = New System.Drawing.Point(67, 7)
        Me.cmbNombreUsuario.Name = "cmbNombreUsuario"
        Me.cmbNombreUsuario.Size = New System.Drawing.Size(178, 21)
        Me.cmbNombreUsuario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'tblUsuarios
        '
        Me.tblUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblUsuarios.Location = New System.Drawing.Point(7, 56)
        Me.tblUsuarios.Name = "tblUsuarios"
        Me.tblUsuarios.Size = New System.Drawing.Size(545, 175)
        Me.tblUsuarios.TabIndex = 37
        '
        'btnAgragar
        '
        Me.btnAgragar.Location = New System.Drawing.Point(474, 237)
        Me.btnAgragar.Name = "btnAgragar"
        Me.btnAgragar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgragar.TabIndex = 11
        Me.btnAgragar.Text = "Agregar"
        Me.btnAgragar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(388, 237)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 38
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(301, 237)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 39
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(477, 384)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 15
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(384, 384)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 40
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'errorIcono
        '
        Me.errorIcono.ContainerControl = Me
        '
        'btnCargarDatos
        '
        Me.btnCargarDatos.Location = New System.Drawing.Point(263, 5)
        Me.btnCargarDatos.Name = "btnCargarDatos"
        Me.btnCargarDatos.Size = New System.Drawing.Size(75, 23)
        Me.btnCargarDatos.TabIndex = 41
        Me.btnCargarDatos.Text = "Cargar Datos"
        Me.btnCargarDatos.UseVisualStyleBackColor = True
        '
        'Perfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 421)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgragar)
        Me.Controls.Add(Me.tblUsuarios)
        Me.Controls.Add(Me.pnlDatosUsuario)
        Me.Controls.Add(Me.lblCerrar)
        Me.Controls.Add(Me.Label16)
        Me.Name = "Perfiles"
        Me.Text = "Perfiles"
        Me.pnlDatosUsuario.ResumeLayout(False)
        Me.pnlDatosUsuario.PerformLayout()
        CType(Me.tblUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCerrar As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents pnlDatosUsuario As Panel
    Friend WithEvents cmbNombreUsuario As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbEmpleado As ComboBox
    Friend WithEvents txtContasenia As TextBox
    Friend WithEvents cmbTipoUsuario As ComboBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tblUsuarios As DataGridView
    Friend WithEvents btnAgragar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents chbActivo As CheckBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents errorIcono As ErrorProvider
    Friend WithEvents btnCargarDatos As Button
End Class
