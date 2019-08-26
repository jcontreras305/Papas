<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Me.lblCerrar = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.pnlDatosUsuario = New System.Windows.Forms.Panel()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.chbActivo = New System.Windows.Forms.CheckBox()
        Me.cmbEmpleado = New System.Windows.Forms.ComboBox()
        Me.txtContasenia = New System.Windows.Forms.TextBox()
        Me.cmbTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCargarDatos = New System.Windows.Forms.Button()
        Me.cmbNombreUsuario = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tblUsuarios = New System.Windows.Forms.DataGridView()
        Me.errorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgragar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
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
        Me.pnlDatosUsuario.Controls.Add(Me.lbl3)
        Me.pnlDatosUsuario.Controls.Add(Me.lbl2)
        Me.pnlDatosUsuario.Controls.Add(Me.lbl1)
        Me.pnlDatosUsuario.Controls.Add(Me.chbActivo)
        Me.pnlDatosUsuario.Controls.Add(Me.cmbEmpleado)
        Me.pnlDatosUsuario.Controls.Add(Me.txtContasenia)
        Me.pnlDatosUsuario.Controls.Add(Me.cmbTipoUsuario)
        Me.pnlDatosUsuario.Controls.Add(Me.txtUsuario)
        Me.pnlDatosUsuario.Controls.Add(Me.Label5)
        Me.pnlDatosUsuario.Controls.Add(Me.Label4)
        Me.pnlDatosUsuario.Controls.Add(Me.Label3)
        Me.pnlDatosUsuario.Controls.Add(Me.Label2)
        Me.pnlDatosUsuario.Controls.Add(Me.btnCargarDatos)
        Me.pnlDatosUsuario.Controls.Add(Me.cmbNombreUsuario)
        Me.pnlDatosUsuario.Controls.Add(Me.Label1)
        Me.pnlDatosUsuario.Location = New System.Drawing.Point(7, 312)
        Me.pnlDatosUsuario.Name = "pnlDatosUsuario"
        Me.pnlDatosUsuario.Size = New System.Drawing.Size(545, 109)
        Me.pnlDatosUsuario.TabIndex = 36
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.Red
        Me.lbl3.Location = New System.Drawing.Point(521, 75)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(14, 18)
        Me.lbl3.TabIndex = 17
        Me.lbl3.Text = "*"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.Red
        Me.lbl2.Location = New System.Drawing.Point(521, 43)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(14, 18)
        Me.lbl2.TabIndex = 16
        Me.lbl2.Text = "*"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Red
        Me.lbl1.Location = New System.Drawing.Point(250, 8)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(14, 18)
        Me.lbl1.TabIndex = 15
        Me.lbl1.Text = "*"
        '
        'chbActivo
        '
        Me.chbActivo.AutoSize = True
        Me.chbActivo.Location = New System.Drawing.Point(362, 11)
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
        'btnCargarDatos
        '
        Me.btnCargarDatos.Location = New System.Drawing.Point(270, 5)
        Me.btnCargarDatos.Name = "btnCargarDatos"
        Me.btnCargarDatos.Size = New System.Drawing.Size(75, 23)
        Me.btnCargarDatos.TabIndex = 2
        Me.btnCargarDatos.Text = "Cargar datos"
        Me.btnCargarDatos.UseVisualStyleBackColor = True
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
        Me.tblUsuarios.Location = New System.Drawing.Point(7, 87)
        Me.tblUsuarios.Name = "tblUsuarios"
        Me.tblUsuarios.Size = New System.Drawing.Size(545, 175)
        Me.tblUsuarios.TabIndex = 37
        '
        'errorIcono
        '
        Me.errorIcono.ContainerControl = Me
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(151, 56)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(295, 20)
        Me.txtBusqueda.TabIndex = 41
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.PapasSC.My.Resources.Resources.CANCELAR
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(369, 427)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 41)
        Me.btnCancelar.TabIndex = 40
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = Global.PapasSC.My.Resources.Resources.ACEPTAR
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(469, 427)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(83, 39)
        Me.btnAceptar.TabIndex = 15
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.PapasSC.My.Resources.Resources.ACTUALIZAR
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(270, 268)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(93, 36)
        Me.btnModificar.TabIndex = 39
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.PapasSC.My.Resources.Resources.BORRAR
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(369, 266)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(90, 38)
        Me.btnEliminar.TabIndex = 38
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgragar
        '
        Me.btnAgragar.Image = CType(resources.GetObject("btnAgragar.Image"), System.Drawing.Image)
        Me.btnAgragar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgragar.Location = New System.Drawing.Point(469, 266)
        Me.btnAgragar.Name = "btnAgragar"
        Me.btnAgragar.Size = New System.Drawing.Size(80, 38)
        Me.btnAgragar.TabIndex = 11
        Me.btnAgragar.Text = "Agregar"
        Me.btnAgragar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgragar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(451, 53)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(91, 23)
        Me.btnBuscar.TabIndex = 42
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Perfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 480)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBusqueda)
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
    Friend WithEvents btnCargarDatos As Button
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
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents errorIcono As ErrorProvider
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents btnBuscar As Button
End Class
