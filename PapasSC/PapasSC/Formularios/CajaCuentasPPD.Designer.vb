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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnImprimirVPPC = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.sprAbono = New System.Windows.Forms.NumericUpDown()
        Me.txtDebeVenta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.tblVentasPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sprAbono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblVentasPendientes
        '
        Me.tblVentasPendientes.AllowUserToAddRows = False
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
        Me.tbnSalir.Location = New System.Drawing.Point(711, 314)
        Me.tbnSalir.Name = "tbnSalir"
        Me.tbnSalir.Size = New System.Drawing.Size(82, 43)
        Me.tbnSalir.TabIndex = 1
        Me.tbnSalir.Text = "Salir"
        Me.tbnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbnSalir.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = Global.PapasSC.My.Resources.Resources.ACEPTAR
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(776, 159)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(88, 43)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnImprimirVPPC
        '
        Me.btnImprimirVPPC.Image = Global.PapasSC.My.Resources.Resources.IMPRIMIR
        Me.btnImprimirVPPC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimirVPPC.Location = New System.Drawing.Point(799, 314)
        Me.btnImprimirVPPC.Name = "btnImprimirVPPC"
        Me.btnImprimirVPPC.Size = New System.Drawing.Size(84, 43)
        Me.btnImprimirVPPC.TabIndex = 4
        Me.btnImprimirVPPC.Text = "Imprimir"
        Me.btnImprimirVPPC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimirVPPC.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(695, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Total Saldado"
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
        Me.txtSaldo.Location = New System.Drawing.Point(766, 23)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(98, 24)
        Me.txtSaldo.TabIndex = 8
        '
        'sprAbono
        '
        Me.sprAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sprAbono.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.sprAbono.Location = New System.Drawing.Point(766, 116)
        Me.sprAbono.Name = "sprAbono"
        Me.sprAbono.Size = New System.Drawing.Size(98, 24)
        Me.sprAbono.TabIndex = 9
        '
        'txtDebeVenta
        '
        Me.txtDebeVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebeVenta.Location = New System.Drawing.Point(766, 72)
        Me.txtDebeVenta.Name = "txtDebeVenta"
        Me.txtDebeVenta.ReadOnly = True
        Me.txtDebeVenta.Size = New System.Drawing.Size(98, 24)
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
        'Button1
        '
        Me.Button1.Image = Global.PapasSC.My.Resources.Resources.IMPRIMIR
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(69, 314)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 43)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Imprimir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Historial"
        '
        'CajaCuentasPPD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 369)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDebeVenta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.sprAbono)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnImprimirVPPC)
        Me.Controls.Add(Me.btnAceptar)
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
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnImprimirVPPC As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents sprAbono As NumericUpDown
    Friend WithEvents txtDebeVenta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
End Class
