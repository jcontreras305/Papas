<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caja
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtCaja = New System.Windows.Forms.TextBox()
        Me.txtEmpleado = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.pnlGeneral = New System.Windows.Forms.TabPage()
        Me.cmbTipoPersona = New System.Windows.Forms.ComboBox()
        Me.stpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.stpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.tblVentas = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.chbCobrados = New System.Windows.Forms.CheckBox()
        Me.chbTodos = New System.Windows.Forms.CheckBox()
        Me.pnlAbonosyAnticipos = New System.Windows.Forms.TabPage()
        Me.pnlCuentasPorCobrar = New System.Windows.Forms.TabPage()
        Me.tblCuentasPorPagar = New System.Windows.Forms.DataGridView()
        Me.pnlComplementoPago = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlEstatus = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.pnlGeneral.SuspendLayout()
        CType(Me.tblVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCuentasPorCobrar.SuspendLayout()
        CType(Me.tblCuentasPorPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEstatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCaja
        '
        Me.txtCaja.Location = New System.Drawing.Point(65, 9)
        Me.txtCaja.Name = "txtCaja"
        Me.txtCaja.Size = New System.Drawing.Size(100, 20)
        Me.txtCaja.TabIndex = 0
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Location = New System.Drawing.Point(65, 35)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.txtEmpleado.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.pnlGeneral)
        Me.TabControl1.Controls.Add(Me.pnlAbonosyAnticipos)
        Me.TabControl1.Controls.Add(Me.pnlCuentasPorCobrar)
        Me.TabControl1.Controls.Add(Me.pnlComplementoPago)
        Me.TabControl1.Location = New System.Drawing.Point(25, 76)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(811, 512)
        Me.TabControl1.TabIndex = 2
        '
        'pnlGeneral
        '
        Me.pnlGeneral.Controls.Add(Me.cmbTipoPersona)
        Me.pnlGeneral.Controls.Add(Me.stpFechaFin)
        Me.pnlGeneral.Controls.Add(Me.stpFechaInicio)
        Me.pnlGeneral.Controls.Add(Me.tblVentas)
        Me.pnlGeneral.Controls.Add(Me.Label3)
        Me.pnlGeneral.Controls.Add(Me.Label1)
        Me.pnlGeneral.Controls.Add(Me.btnActualizar)
        Me.pnlGeneral.Controls.Add(Me.TextBox4)
        Me.pnlGeneral.Controls.Add(Me.Label2)
        Me.pnlGeneral.Controls.Add(Me.lblTipo)
        Me.pnlGeneral.Controls.Add(Me.chbCobrados)
        Me.pnlGeneral.Controls.Add(Me.chbTodos)
        Me.pnlGeneral.Location = New System.Drawing.Point(4, 22)
        Me.pnlGeneral.Name = "pnlGeneral"
        Me.pnlGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.pnlGeneral.Size = New System.Drawing.Size(803, 486)
        Me.pnlGeneral.TabIndex = 0
        Me.pnlGeneral.Text = "General"
        Me.pnlGeneral.UseVisualStyleBackColor = True
        '
        'cmbTipoPersona
        '
        Me.cmbTipoPersona.FormattingEnabled = True
        Me.cmbTipoPersona.Items.AddRange(New Object() {"Física", "Moral"})
        Me.cmbTipoPersona.Location = New System.Drawing.Point(159, 13)
        Me.cmbTipoPersona.Name = "cmbTipoPersona"
        Me.cmbTipoPersona.Size = New System.Drawing.Size(100, 21)
        Me.cmbTipoPersona.TabIndex = 16
        '
        'stpFechaFin
        '
        Me.stpFechaFin.Location = New System.Drawing.Point(479, 44)
        Me.stpFechaFin.Name = "stpFechaFin"
        Me.stpFechaFin.Size = New System.Drawing.Size(206, 20)
        Me.stpFechaFin.TabIndex = 15
        '
        'stpFechaInicio
        '
        Me.stpFechaInicio.Location = New System.Drawing.Point(479, 14)
        Me.stpFechaInicio.Name = "stpFechaInicio"
        Me.stpFechaInicio.Size = New System.Drawing.Size(206, 20)
        Me.stpFechaInicio.TabIndex = 14
        '
        'tblVentas
        '
        Me.tblVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblVentas.Location = New System.Drawing.Point(18, 99)
        Me.tblVentas.Name = "tblVentas"
        Me.tblVentas.Size = New System.Drawing.Size(764, 381)
        Me.tblVentas.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(406, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Fecha Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(406, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Fecha Inicial"
        '
        'btnActualizar
        '
        Me.btnActualizar.Image = Global.PapasSC.My.Resources.Resources.ACTUALIZAR
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(691, 12)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(91, 43)
        Me.btnActualizar.TabIndex = 6
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(300, 14)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(265, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Folio"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(124, 18)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(28, 13)
        Me.lblTipo.TabIndex = 2
        Me.lblTipo.Text = "Tipo"
        '
        'chbCobrados
        '
        Me.chbCobrados.AutoSize = True
        Me.chbCobrados.Location = New System.Drawing.Point(15, 40)
        Me.chbCobrados.Name = "chbCobrados"
        Me.chbCobrados.Size = New System.Drawing.Size(102, 17)
        Me.chbCobrados.TabIndex = 1
        Me.chbCobrados.Text = "Incluir Cobrados"
        Me.chbCobrados.UseVisualStyleBackColor = True
        '
        'chbTodos
        '
        Me.chbTodos.AutoSize = True
        Me.chbTodos.Location = New System.Drawing.Point(15, 17)
        Me.chbTodos.Name = "chbTodos"
        Me.chbTodos.Size = New System.Drawing.Size(56, 17)
        Me.chbTodos.TabIndex = 0
        Me.chbTodos.Text = "Todos"
        Me.chbTodos.UseVisualStyleBackColor = True
        '
        'pnlAbonosyAnticipos
        '
        Me.pnlAbonosyAnticipos.Location = New System.Drawing.Point(4, 22)
        Me.pnlAbonosyAnticipos.Name = "pnlAbonosyAnticipos"
        Me.pnlAbonosyAnticipos.Padding = New System.Windows.Forms.Padding(3)
        Me.pnlAbonosyAnticipos.Size = New System.Drawing.Size(803, 486)
        Me.pnlAbonosyAnticipos.TabIndex = 1
        Me.pnlAbonosyAnticipos.Text = "Abonos y Anticipos"
        Me.pnlAbonosyAnticipos.UseVisualStyleBackColor = True
        '
        'pnlCuentasPorCobrar
        '
        Me.pnlCuentasPorCobrar.Controls.Add(Me.tblCuentasPorPagar)
        Me.pnlCuentasPorCobrar.Location = New System.Drawing.Point(4, 22)
        Me.pnlCuentasPorCobrar.Name = "pnlCuentasPorCobrar"
        Me.pnlCuentasPorCobrar.Padding = New System.Windows.Forms.Padding(3)
        Me.pnlCuentasPorCobrar.Size = New System.Drawing.Size(803, 486)
        Me.pnlCuentasPorCobrar.TabIndex = 2
        Me.pnlCuentasPorCobrar.Text = "Cuentas por Cobrar"
        Me.pnlCuentasPorCobrar.UseVisualStyleBackColor = True
        '
        'tblCuentasPorPagar
        '
        Me.tblCuentasPorPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblCuentasPorPagar.Location = New System.Drawing.Point(9, 58)
        Me.tblCuentasPorPagar.Name = "tblCuentasPorPagar"
        Me.tblCuentasPorPagar.Size = New System.Drawing.Size(779, 409)
        Me.tblCuentasPorPagar.TabIndex = 0
        '
        'pnlComplementoPago
        '
        Me.pnlComplementoPago.Location = New System.Drawing.Point(4, 22)
        Me.pnlComplementoPago.Name = "pnlComplementoPago"
        Me.pnlComplementoPago.Padding = New System.Windows.Forms.Padding(3)
        Me.pnlComplementoPago.Size = New System.Drawing.Size(803, 486)
        Me.pnlComplementoPago.TabIndex = 3
        Me.pnlComplementoPago.Text = "Complemento de Pago"
        Me.pnlComplementoPago.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Caja"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Atiende"
        '
        'pnlEstatus
        '
        Me.pnlEstatus.Controls.Add(Me.Label4)
        Me.pnlEstatus.Controls.Add(Me.Label5)
        Me.pnlEstatus.Controls.Add(Me.txtCaja)
        Me.pnlEstatus.Controls.Add(Me.txtEmpleado)
        Me.pnlEstatus.Location = New System.Drawing.Point(25, 10)
        Me.pnlEstatus.Name = "pnlEstatus"
        Me.pnlEstatus.Size = New System.Drawing.Size(807, 60)
        Me.pnlEstatus.TabIndex = 5
        '
        'Caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 626)
        Me.Controls.Add(Me.pnlEstatus)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Caja"
        Me.Text = "Caja"
        Me.TabControl1.ResumeLayout(False)
        Me.pnlGeneral.ResumeLayout(False)
        Me.pnlGeneral.PerformLayout()
        CType(Me.tblVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCuentasPorCobrar.ResumeLayout(False)
        CType(Me.tblCuentasPorPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEstatus.ResumeLayout(False)
        Me.pnlEstatus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtCaja As TextBox
    Friend WithEvents txtEmpleado As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents pnlGeneral As TabPage
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents chbCobrados As CheckBox
    Friend WithEvents chbTodos As CheckBox
    Friend WithEvents pnlAbonosyAnticipos As TabPage
    Friend WithEvents pnlCuentasPorCobrar As TabPage
    Friend WithEvents pnlComplementoPago As TabPage
    Friend WithEvents btnActualizar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tblVentas As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlEstatus As Panel
    Friend WithEvents stpFechaFin As DateTimePicker
    Friend WithEvents stpFechaInicio As DateTimePicker
    Friend WithEvents cmbTipoPersona As ComboBox
    Friend WithEvents tblCuentasPorPagar As DataGridView
End Class
