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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlEstatus = New System.Windows.Forms.Panel()
        Me.pnlCuentasPorCobrar = New System.Windows.Forms.TabPage()
        Me.btnActualizaCPC = New System.Windows.Forms.Button()
        Me.txtFechaFin = New System.Windows.Forms.TextBox()
        Me.txtFechaInicio = New System.Windows.Forms.TextBox()
        Me.mtcFechaInicio = New System.Windows.Forms.MonthCalendar()
        Me.mtcFechaFin = New System.Windows.Forms.MonthCalendar()
        Me.chbTodosCPP = New System.Windows.Forms.CheckBox()
        Me.cmbFiltar = New System.Windows.Forms.ComboBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tblCuentasPorPagar = New System.Windows.Forms.DataGridView()
        Me.pnlAbonosyAnticipos = New System.Windows.Forms.TabPage()
        Me.pnlGeneral = New System.Windows.Forms.TabPage()
        Me.txtFecha2 = New System.Windows.Forms.TextBox()
        Me.txtFecha1 = New System.Windows.Forms.TextBox()
        Me.mtcFecha1 = New System.Windows.Forms.MonthCalendar()
        Me.mtcFecha2 = New System.Windows.Forms.MonthCalendar()
        Me.cmbTipoPersona = New System.Windows.Forms.ComboBox()
        Me.tblVentas = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.txtFiltro1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.chbTodos = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.pnlPrecorte = New System.Windows.Forms.TabPage()
        Me.tblPrecorte = New System.Windows.Forms.DataGridView()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.pnlEstatus.SuspendLayout()
        Me.pnlCuentasPorCobrar.SuspendLayout()
        CType(Me.tblCuentasPorPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGeneral.SuspendLayout()
        CType(Me.tblVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.pnlPrecorte.SuspendLayout()
        CType(Me.tblPrecorte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCaja
        '
        Me.txtCaja.Location = New System.Drawing.Point(65, 9)
        Me.txtCaja.Name = "txtCaja"
        Me.txtCaja.ReadOnly = True
        Me.txtCaja.Size = New System.Drawing.Size(100, 20)
        Me.txtCaja.TabIndex = 0
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Location = New System.Drawing.Point(65, 35)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.ReadOnly = True
        Me.txtEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.txtEmpleado.TabIndex = 1
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
        Me.pnlEstatus.Size = New System.Drawing.Size(811, 60)
        Me.pnlEstatus.TabIndex = 5
        '
        'pnlCuentasPorCobrar
        '
        Me.pnlCuentasPorCobrar.Controls.Add(Me.btnActualizaCPC)
        Me.pnlCuentasPorCobrar.Controls.Add(Me.txtFechaFin)
        Me.pnlCuentasPorCobrar.Controls.Add(Me.txtFechaInicio)
        Me.pnlCuentasPorCobrar.Controls.Add(Me.mtcFechaInicio)
        Me.pnlCuentasPorCobrar.Controls.Add(Me.mtcFechaFin)
        Me.pnlCuentasPorCobrar.Controls.Add(Me.chbTodosCPP)
        Me.pnlCuentasPorCobrar.Controls.Add(Me.cmbFiltar)
        Me.pnlCuentasPorCobrar.Controls.Add(Me.txtFiltro)
        Me.pnlCuentasPorCobrar.Controls.Add(Me.Label8)
        Me.pnlCuentasPorCobrar.Controls.Add(Me.Label7)
        Me.pnlCuentasPorCobrar.Controls.Add(Me.Label6)
        Me.pnlCuentasPorCobrar.Controls.Add(Me.tblCuentasPorPagar)
        Me.pnlCuentasPorCobrar.Location = New System.Drawing.Point(4, 22)
        Me.pnlCuentasPorCobrar.Name = "pnlCuentasPorCobrar"
        Me.pnlCuentasPorCobrar.Padding = New System.Windows.Forms.Padding(3)
        Me.pnlCuentasPorCobrar.Size = New System.Drawing.Size(803, 486)
        Me.pnlCuentasPorCobrar.TabIndex = 2
        Me.pnlCuentasPorCobrar.Text = "Cuentas por Cobrar"
        Me.pnlCuentasPorCobrar.UseVisualStyleBackColor = True
        '
        'btnActualizaCPC
        '
        Me.btnActualizaCPC.Image = Global.PapasSC.My.Resources.Resources.ACTUALIZAR
        Me.btnActualizaCPC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizaCPC.Location = New System.Drawing.Point(691, 12)
        Me.btnActualizaCPC.Name = "btnActualizaCPC"
        Me.btnActualizaCPC.Size = New System.Drawing.Size(91, 43)
        Me.btnActualizaCPC.TabIndex = 14
        Me.btnActualizaCPC.Text = "Actualizar"
        Me.btnActualizaCPC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActualizaCPC.UseVisualStyleBackColor = True
        '
        'txtFechaFin
        '
        Me.txtFechaFin.Location = New System.Drawing.Point(456, 37)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(192, 20)
        Me.txtFechaFin.TabIndex = 13
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.Location = New System.Drawing.Point(456, 10)
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.Size = New System.Drawing.Size(192, 20)
        Me.txtFechaInicio.TabIndex = 12
        '
        'mtcFechaInicio
        '
        Me.mtcFechaInicio.Location = New System.Drawing.Point(456, 9)
        Me.mtcFechaInicio.Name = "mtcFechaInicio"
        Me.mtcFechaInicio.TabIndex = 11
        Me.mtcFechaInicio.Visible = False
        '
        'mtcFechaFin
        '
        Me.mtcFechaFin.Location = New System.Drawing.Point(456, 40)
        Me.mtcFechaFin.Name = "mtcFechaFin"
        Me.mtcFechaFin.TabIndex = 10
        Me.mtcFechaFin.Visible = False
        '
        'chbTodosCPP
        '
        Me.chbTodosCPP.AutoSize = True
        Me.chbTodosCPP.Location = New System.Drawing.Point(19, 41)
        Me.chbTodosCPP.Name = "chbTodosCPP"
        Me.chbTodosCPP.Size = New System.Drawing.Size(56, 17)
        Me.chbTodosCPP.TabIndex = 9
        Me.chbTodosCPP.Text = "Todos"
        Me.chbTodosCPP.UseVisualStyleBackColor = True
        '
        'cmbFiltar
        '
        Me.cmbFiltar.FormattingEnabled = True
        Me.cmbFiltar.Items.AddRange(New Object() {"Cliente", "Contacto", "% Credito"})
        Me.cmbFiltar.Location = New System.Drawing.Point(54, 13)
        Me.cmbFiltar.Name = "cmbFiltar"
        Me.cmbFiltar.Size = New System.Drawing.Size(107, 21)
        Me.cmbFiltar.TabIndex = 8
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(167, 13)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(151, 20)
        Me.txtFiltro.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Filtrar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(382, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Fecha  Fin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(379, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Fecha Inicio"
        '
        'tblCuentasPorPagar
        '
        Me.tblCuentasPorPagar.AllowUserToAddRows = False
        Me.tblCuentasPorPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblCuentasPorPagar.Location = New System.Drawing.Point(9, 74)
        Me.tblCuentasPorPagar.Name = "tblCuentasPorPagar"
        Me.tblCuentasPorPagar.ReadOnly = True
        Me.tblCuentasPorPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblCuentasPorPagar.Size = New System.Drawing.Size(779, 393)
        Me.tblCuentasPorPagar.TabIndex = 0
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
        'pnlGeneral
        '
        Me.pnlGeneral.Controls.Add(Me.txtFecha2)
        Me.pnlGeneral.Controls.Add(Me.txtFecha1)
        Me.pnlGeneral.Controls.Add(Me.mtcFecha1)
        Me.pnlGeneral.Controls.Add(Me.mtcFecha2)
        Me.pnlGeneral.Controls.Add(Me.cmbTipoPersona)
        Me.pnlGeneral.Controls.Add(Me.tblVentas)
        Me.pnlGeneral.Controls.Add(Me.Label3)
        Me.pnlGeneral.Controls.Add(Me.Label1)
        Me.pnlGeneral.Controls.Add(Me.btnActualizar)
        Me.pnlGeneral.Controls.Add(Me.txtFiltro1)
        Me.pnlGeneral.Controls.Add(Me.Label2)
        Me.pnlGeneral.Controls.Add(Me.lblTipo)
        Me.pnlGeneral.Controls.Add(Me.chbTodos)
        Me.pnlGeneral.Location = New System.Drawing.Point(4, 22)
        Me.pnlGeneral.Name = "pnlGeneral"
        Me.pnlGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.pnlGeneral.Size = New System.Drawing.Size(803, 486)
        Me.pnlGeneral.TabIndex = 0
        Me.pnlGeneral.Text = "General"
        Me.pnlGeneral.UseVisualStyleBackColor = True
        '
        'txtFecha2
        '
        Me.txtFecha2.Location = New System.Drawing.Point(485, 42)
        Me.txtFecha2.Name = "txtFecha2"
        Me.txtFecha2.Size = New System.Drawing.Size(192, 20)
        Me.txtFecha2.TabIndex = 19
        '
        'txtFecha1
        '
        Me.txtFecha1.Location = New System.Drawing.Point(485, 16)
        Me.txtFecha1.Name = "txtFecha1"
        Me.txtFecha1.Size = New System.Drawing.Size(192, 20)
        Me.txtFecha1.TabIndex = 18
        '
        'mtcFecha1
        '
        Me.mtcFecha1.Location = New System.Drawing.Point(485, 12)
        Me.mtcFecha1.MaxSelectionCount = 1
        Me.mtcFecha1.Name = "mtcFecha1"
        Me.mtcFecha1.ShowToday = False
        Me.mtcFecha1.TabIndex = 17
        Me.mtcFecha1.Visible = False
        '
        'mtcFecha2
        '
        Me.mtcFecha2.Location = New System.Drawing.Point(485, 43)
        Me.mtcFecha2.MaxSelectionCount = 1
        Me.mtcFecha2.Name = "mtcFecha2"
        Me.mtcFecha2.ShowToday = False
        Me.mtcFecha2.TabIndex = 7
        Me.mtcFecha2.Visible = False
        '
        'cmbTipoPersona
        '
        Me.cmbTipoPersona.FormattingEnabled = True
        Me.cmbTipoPersona.Items.AddRange(New Object() {"Empleado", "Folio", "Cliente", "Razon Social"})
        Me.cmbTipoPersona.Location = New System.Drawing.Point(159, 13)
        Me.cmbTipoPersona.Name = "cmbTipoPersona"
        Me.cmbTipoPersona.Size = New System.Drawing.Size(100, 21)
        Me.cmbTipoPersona.TabIndex = 16
        '
        'tblVentas
        '
        Me.tblVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblVentas.Location = New System.Drawing.Point(9, 74)
        Me.tblVentas.Name = "tblVentas"
        Me.tblVentas.ReadOnly = True
        Me.tblVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblVentas.ShowCellErrors = False
        Me.tblVentas.Size = New System.Drawing.Size(764, 393)
        Me.tblVentas.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(411, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Fecha Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(406, 45)
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
        'txtFiltro1
        '
        Me.txtFiltro1.Location = New System.Drawing.Point(300, 14)
        Me.txtFiltro1.Name = "txtFiltro1"
        Me.txtFiltro1.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltro1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(265, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Filtro"
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.pnlGeneral)
        Me.TabControl1.Controls.Add(Me.pnlAbonosyAnticipos)
        Me.TabControl1.Controls.Add(Me.pnlCuentasPorCobrar)
        Me.TabControl1.Controls.Add(Me.pnlPrecorte)
        Me.TabControl1.Location = New System.Drawing.Point(25, 76)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(811, 512)
        Me.TabControl1.TabIndex = 2
        '
        'pnlPrecorte
        '
        Me.pnlPrecorte.Controls.Add(Me.tblPrecorte)
        Me.pnlPrecorte.Location = New System.Drawing.Point(4, 22)
        Me.pnlPrecorte.Name = "pnlPrecorte"
        Me.pnlPrecorte.Size = New System.Drawing.Size(803, 486)
        Me.pnlPrecorte.TabIndex = 3
        Me.pnlPrecorte.Text = "Pre-Corte "
        Me.pnlPrecorte.UseVisualStyleBackColor = True
        '
        'tblPrecorte
        '
        Me.tblPrecorte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblPrecorte.Location = New System.Drawing.Point(9, 74)
        Me.tblPrecorte.Name = "tblPrecorte"
        Me.tblPrecorte.Size = New System.Drawing.Size(779, 393)
        Me.tblPrecorte.TabIndex = 0
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.PapasSC.My.Resources.Resources.IMPRIMIR1
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(733, 595)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(78, 37)
        Me.btnImprimir.TabIndex = 6
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'Caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 644)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.pnlEstatus)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Caja"
        Me.Text = "Caja"
        Me.pnlEstatus.ResumeLayout(False)
        Me.pnlEstatus.PerformLayout()
        Me.pnlCuentasPorCobrar.ResumeLayout(False)
        Me.pnlCuentasPorCobrar.PerformLayout()
        CType(Me.tblCuentasPorPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGeneral.ResumeLayout(False)
        Me.pnlGeneral.PerformLayout()
        CType(Me.tblVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.pnlPrecorte.ResumeLayout(False)
        CType(Me.tblPrecorte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtCaja As TextBox
    Friend WithEvents txtEmpleado As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlEstatus As Panel
    Friend WithEvents pnlCuentasPorCobrar As TabPage
    Friend WithEvents tblCuentasPorPagar As DataGridView
    Friend WithEvents pnlAbonosyAnticipos As TabPage
    Friend WithEvents pnlGeneral As TabPage
    Friend WithEvents cmbTipoPersona As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents txtFiltro1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents chbTodos As CheckBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents chbTodosCPP As CheckBox
    Friend WithEvents cmbFiltar As ComboBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents pnlPrecorte As TabPage
    Friend WithEvents tblPrecorte As DataGridView
    Friend WithEvents txtFecha2 As TextBox
    Friend WithEvents txtFecha1 As TextBox
    Friend WithEvents mtcFecha1 As MonthCalendar
    Friend WithEvents mtcFecha2 As MonthCalendar
    Protected Friend WithEvents tblVentas As DataGridView
    Friend WithEvents txtFechaFin As TextBox
    Friend WithEvents txtFechaInicio As TextBox
    Friend WithEvents mtcFechaInicio As MonthCalendar
    Friend WithEvents mtcFechaFin As MonthCalendar
    Friend WithEvents btnActualizaCPC As Button
End Class
