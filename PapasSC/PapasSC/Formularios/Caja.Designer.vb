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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.pnlGeneral = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFechaFinal = New System.Windows.Forms.TextBox()
        Me.cldFechaFinal = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFechainicial = New System.Windows.Forms.TextBox()
        Me.cldFechaInicial = New System.Windows.Forms.MonthCalendar()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.chbCobrados = New System.Windows.Forms.CheckBox()
        Me.chbTodos = New System.Windows.Forms.CheckBox()
        Me.pnlAbonosyAnticipos = New System.Windows.Forms.TabPage()
        Me.pnlCuentasPorCobrar = New System.Windows.Forms.TabPage()
        Me.pnlComplementoPago = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.pnlGeneral.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(40, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(40, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
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
        Me.pnlGeneral.Controls.Add(Me.DataGridView1)
        Me.pnlGeneral.Controls.Add(Me.Label3)
        Me.pnlGeneral.Controls.Add(Me.txtFechaFinal)
        Me.pnlGeneral.Controls.Add(Me.cldFechaFinal)
        Me.pnlGeneral.Controls.Add(Me.Label1)
        Me.pnlGeneral.Controls.Add(Me.txtFechainicial)
        Me.pnlGeneral.Controls.Add(Me.cldFechaInicial)
        Me.pnlGeneral.Controls.Add(Me.btnActualizar)
        Me.pnlGeneral.Controls.Add(Me.TextBox4)
        Me.pnlGeneral.Controls.Add(Me.TextBox3)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(406, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Fecha Final"
        '
        'txtFechaFinal
        '
        Me.txtFechaFinal.Location = New System.Drawing.Point(474, 40)
        Me.txtFechaFinal.Name = "txtFechaFinal"
        Me.txtFechaFinal.Size = New System.Drawing.Size(192, 20)
        Me.txtFechaFinal.TabIndex = 11
        '
        'cldFechaFinal
        '
        Me.cldFechaFinal.Location = New System.Drawing.Point(474, 38)
        Me.cldFechaFinal.Name = "cldFechaFinal"
        Me.cldFechaFinal.TabIndex = 10
        Me.cldFechaFinal.Visible = False
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
        'txtFechainicial
        '
        Me.txtFechainicial.Location = New System.Drawing.Point(474, 14)
        Me.txtFechainicial.Name = "txtFechainicial"
        Me.txtFechainicial.Size = New System.Drawing.Size(192, 20)
        Me.txtFechainicial.TabIndex = 8
        '
        'cldFechaInicial
        '
        Me.cldFechaInicial.Location = New System.Drawing.Point(474, 12)
        Me.cldFechaInicial.Name = "cldFechaInicial"
        Me.cldFechaInicial.TabIndex = 7
        Me.cldFechaInicial.Visible = False
        '
        'btnActualizar
        '
        Me.btnActualizar.Image = Global.PapasSC.My.Resources.Resources.ACTUALIZAR
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(691, 6)
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
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(158, 15)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 4
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
        Me.pnlAbonosyAnticipos.Size = New System.Drawing.Size(788, 486)
        Me.pnlAbonosyAnticipos.TabIndex = 1
        Me.pnlAbonosyAnticipos.Text = "Abonos y Anticipos"
        Me.pnlAbonosyAnticipos.UseVisualStyleBackColor = True
        '
        'pnlCuentasPorCobrar
        '
        Me.pnlCuentasPorCobrar.Location = New System.Drawing.Point(4, 22)
        Me.pnlCuentasPorCobrar.Name = "pnlCuentasPorCobrar"
        Me.pnlCuentasPorCobrar.Padding = New System.Windows.Forms.Padding(3)
        Me.pnlCuentasPorCobrar.Size = New System.Drawing.Size(788, 486)
        Me.pnlCuentasPorCobrar.TabIndex = 2
        Me.pnlCuentasPorCobrar.Text = "Cuentas por Cobrar"
        Me.pnlCuentasPorCobrar.UseVisualStyleBackColor = True
        '
        'pnlComplementoPago
        '
        Me.pnlComplementoPago.Location = New System.Drawing.Point(4, 22)
        Me.pnlComplementoPago.Name = "pnlComplementoPago"
        Me.pnlComplementoPago.Padding = New System.Windows.Forms.Padding(3)
        Me.pnlComplementoPago.Size = New System.Drawing.Size(788, 486)
        Me.pnlComplementoPago.TabIndex = 3
        Me.pnlComplementoPago.Text = "Complemento de Pago"
        Me.pnlComplementoPago.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 99)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(764, 381)
        Me.DataGridView1.TabIndex = 13
        '
        'Caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 626)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Caja"
        Me.Text = "Caja"
        Me.TabControl1.ResumeLayout(False)
        Me.pnlGeneral.ResumeLayout(False)
        Me.pnlGeneral.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents pnlGeneral As TabPage
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents chbCobrados As CheckBox
    Friend WithEvents chbTodos As CheckBox
    Friend WithEvents pnlAbonosyAnticipos As TabPage
    Friend WithEvents pnlCuentasPorCobrar As TabPage
    Friend WithEvents pnlComplementoPago As TabPage
    Friend WithEvents cldFechaInicial As MonthCalendar
    Friend WithEvents btnActualizar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFechaFinal As TextBox
    Friend WithEvents cldFechaFinal As MonthCalendar
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFechainicial As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
