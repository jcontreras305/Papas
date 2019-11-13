<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CajaCuentasPPD
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
        Me.tblVentasPendientes = New System.Windows.Forms.DataGridView()
        Me.tbnSalir = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.sprAbono = New System.Windows.Forms.NumericUpDown()
        Me.txtDebeVenta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.tblVentasPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sprAbono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblVentasPendientes
        '
        Me.tblVentasPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblVentasPendientes.Location = New System.Drawing.Point(22, 12)
        Me.tblVentasPendientes.Name = "tblVentasPendientes"
        Me.tblVentasPendientes.ReadOnly = True
        Me.tblVentasPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblVentasPendientes.Size = New System.Drawing.Size(671, 274)
        Me.tblVentasPendientes.TabIndex = 0
        '
        'tbnSalir
        '
        Me.tbnSalir.Image = Global.PapasSC.My.Resources.Resources.CANCELAR
        Me.tbnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbnSalir.Location = New System.Drawing.Point(576, 314)
        Me.tbnSalir.Name = "tbnSalir"
        Me.tbnSalir.Size = New System.Drawing.Size(82, 43)
        Me.tbnSalir.TabIndex = 1
        Me.tbnSalir.Text = "Salir"
        Me.tbnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbnSalir.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.PapasSC.My.Resources.Resources.ACEPTAR
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(688, 314)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 43)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Aceptar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.PapasSC.My.Resources.Resources.IMPRIMIR
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(799, 314)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(84, 43)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Imprimir"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(699, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Total Saldo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(711, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Abono"
        '
        'txtSaldo
        '
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(764, 23)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(100, 24)
        Me.txtSaldo.TabIndex = 8
        '
        'sprAbono
        '
        Me.sprAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sprAbono.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.sprAbono.Location = New System.Drawing.Point(764, 116)
        Me.sprAbono.Name = "sprAbono"
        Me.sprAbono.Size = New System.Drawing.Size(100, 24)
        Me.sprAbono.TabIndex = 9
        '
        'txtDebeVenta
        '
        Me.txtDebeVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebeVenta.Location = New System.Drawing.Point(764, 72)
        Me.txtDebeVenta.Name = "txtDebeVenta"
        Me.txtDebeVenta.ReadOnly = True
        Me.txtDebeVenta.Size = New System.Drawing.Size(100, 24)
        Me.txtDebeVenta.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(708, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Debe"
        '
        'CajaCuentasPPD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 369)
        Me.Controls.Add(Me.txtDebeVenta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.sprAbono)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.tbnSalir)
        Me.Controls.Add(Me.tblVentasPendientes)
        Me.Name = "CajaCuentasPPD"
        Me.Text = "Cuentas Por Pagar Detallado"
        CType(Me.tblVentasPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sprAbono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tblVentasPendientes As DataGridView
    Friend WithEvents tbnSalir As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents sprAbono As NumericUpDown
    Friend WithEvents txtDebeVenta As TextBox
    Friend WithEvents Label3 As Label
End Class
