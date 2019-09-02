<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PerfilesDeLosUsuarios
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstDisponibles = New System.Windows.Forms.ListView()
        Me.clmActividad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblCerrar = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreNuevo = New System.Windows.Forms.TextBox()
        Me.cmbTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ltsAsignados = New System.Windows.Forms.ListView()
        Me.clmActividadAgregada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnAgergarTodos = New System.Windows.Forms.Button()
        Me.btnQuitarTodos = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnSalirCancelar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnNuevoGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstDisponibles)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 305)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Actividades Disponibles"
        '
        'lstDisponibles
        '
        Me.lstDisponibles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmActividad})
        Me.lstDisponibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDisponibles.FullRowSelect = True
        Me.lstDisponibles.GridLines = True
        Me.lstDisponibles.Location = New System.Drawing.Point(6, 19)
        Me.lstDisponibles.Name = "lstDisponibles"
        Me.lstDisponibles.Size = New System.Drawing.Size(172, 280)
        Me.lstDisponibles.TabIndex = 0
        Me.lstDisponibles.UseCompatibleStateImageBehavior = False
        Me.lstDisponibles.View = System.Windows.Forms.View.List
        '
        'clmActividad
        '
        Me.clmActividad.Text = "Actividad"
        '
        'lblCerrar
        '
        Me.lblCerrar.AutoSize = True
        Me.lblCerrar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCerrar.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblCerrar.Location = New System.Drawing.Point(3, 3)
        Me.lblCerrar.Name = "lblCerrar"
        Me.lblCerrar.Size = New System.Drawing.Size(24, 24)
        Me.lblCerrar.TabIndex = 40
        Me.lblCerrar.Text = "X"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label16.Location = New System.Drawing.Point(117, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(198, 24)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Configurar Perfiles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(68, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Nombre"
        '
        'txtNombreNuevo
        '
        Me.txtNombreNuevo.Location = New System.Drawing.Point(118, 64)
        Me.txtNombreNuevo.Name = "txtNombreNuevo"
        Me.txtNombreNuevo.Size = New System.Drawing.Size(193, 20)
        Me.txtNombreNuevo.TabIndex = 42
        '
        'cmbTipoUsuario
        '
        Me.cmbTipoUsuario.FormattingEnabled = True
        Me.cmbTipoUsuario.Location = New System.Drawing.Point(118, 37)
        Me.cmbTipoUsuario.Name = "cmbTipoUsuario"
        Me.cmbTipoUsuario.Size = New System.Drawing.Size(193, 21)
        Me.cmbTipoUsuario.TabIndex = 43
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ltsAsignados)
        Me.GroupBox2.Location = New System.Drawing.Point(307, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 305)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actividades Asignadas"
        '
        'ltsAsignados
        '
        Me.ltsAsignados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmActividadAgregada})
        Me.ltsAsignados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltsAsignados.FullRowSelect = True
        Me.ltsAsignados.GridLines = True
        Me.ltsAsignados.Location = New System.Drawing.Point(6, 19)
        Me.ltsAsignados.Name = "ltsAsignados"
        Me.ltsAsignados.Size = New System.Drawing.Size(172, 280)
        Me.ltsAsignados.TabIndex = 1
        Me.ltsAsignados.UseCompatibleStateImageBehavior = False
        Me.ltsAsignados.View = System.Windows.Forms.View.List
        '
        'clmActividadAgregada
        '
        Me.clmActividadAgregada.Text = "ActividadAgregada"
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnAgregar.Location = New System.Drawing.Point(235, 151)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(53, 36)
        Me.btnAgregar.TabIndex = 44
        Me.btnAgregar.Text = ">"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnAgergarTodos
        '
        Me.btnAgergarTodos.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgergarTodos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnAgergarTodos.Location = New System.Drawing.Point(235, 193)
        Me.btnAgergarTodos.Name = "btnAgergarTodos"
        Me.btnAgergarTodos.Size = New System.Drawing.Size(53, 36)
        Me.btnAgergarTodos.TabIndex = 45
        Me.btnAgergarTodos.Text = ">>"
        Me.btnAgergarTodos.UseVisualStyleBackColor = True
        '
        'btnQuitarTodos
        '
        Me.btnQuitarTodos.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarTodos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnQuitarTodos.Location = New System.Drawing.Point(235, 235)
        Me.btnQuitarTodos.Name = "btnQuitarTodos"
        Me.btnQuitarTodos.Size = New System.Drawing.Size(53, 36)
        Me.btnQuitarTodos.TabIndex = 46
        Me.btnQuitarTodos.Text = "<<"
        Me.btnQuitarTodos.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnQuitar.Location = New System.Drawing.Point(235, 277)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(53, 36)
        Me.btnQuitar.TabIndex = 47
        Me.btnQuitar.Text = "<"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnSalirCancelar
        '
        Me.btnSalirCancelar.Image = Global.PapasSC.My.Resources.Resources.CANCELAR
        Me.btnSalirCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalirCancelar.Location = New System.Drawing.Point(421, 35)
        Me.btnSalirCancelar.Name = "btnSalirCancelar"
        Me.btnSalirCancelar.Size = New System.Drawing.Size(65, 40)
        Me.btnSalirCancelar.TabIndex = 51
        Me.btnSalirCancelar.Text = "Salir"
        Me.btnSalirCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalirCancelar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.PapasSC.My.Resources.Resources.CANCELAR
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(306, 404)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(85, 40)
        Me.btnCancelar.TabIndex = 50
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = Global.PapasSC.My.Resources.Resources.ACEPTAR
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(397, 404)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(88, 40)
        Me.btnAceptar.TabIndex = 49
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnNuevoGuardar
        '
        Me.btnNuevoGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnNuevoGuardar.Image = Global.PapasSC.My.Resources.Resources.NUEVO
        Me.btnNuevoGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevoGuardar.Location = New System.Drawing.Point(340, 37)
        Me.btnNuevoGuardar.Name = "btnNuevoGuardar"
        Me.btnNuevoGuardar.Size = New System.Drawing.Size(75, 38)
        Me.btnNuevoGuardar.TabIndex = 48
        Me.btnNuevoGuardar.Text = "Nuevo"
        Me.btnNuevoGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevoGuardar.UseVisualStyleBackColor = True
        '
        'PerfilesDeLosUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 450)
        Me.Controls.Add(Me.btnSalirCancelar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnNuevoGuardar)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnQuitarTodos)
        Me.Controls.Add(Me.btnAgergarTodos)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmbTipoUsuario)
        Me.Controls.Add(Me.txtNombreNuevo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCerrar)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Name = "PerfilesDeLosUsuarios"
        Me.Text = "PerfilesDeLosUsuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblCerrar As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lstDisponibles As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreNuevo As TextBox
    Friend WithEvents cmbTipoUsuario As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ltsAsignados As ListView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnAgergarTodos As Button
    Friend WithEvents btnQuitarTodos As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents btnNuevoGuardar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSalirCancelar As Button
    Friend WithEvents clmActividad As ColumnHeader
    Friend WithEvents clmActividadAgregada As ColumnHeader
End Class
