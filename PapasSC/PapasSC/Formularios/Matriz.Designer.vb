﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matriz
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
        Me.txtNombreMatriz = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCalveCiudad = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCiudad = New System.Windows.Forms.Button()
        Me.btnGuardarCiudad = New System.Windows.Forms.Button()
        Me.cmbCiudad = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tblMatriz = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnEliminarMatriz = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.tblMatriz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombreMatriz
        '
        Me.txtNombreMatriz.Location = New System.Drawing.Point(70, 13)
        Me.txtNombreMatriz.Name = "txtNombreMatriz"
        Me.txtNombreMatriz.Size = New System.Drawing.Size(165, 20)
        Me.txtNombreMatriz.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Clave "
        '
        'txtCalveCiudad
        '
        Me.txtCalveCiudad.Location = New System.Drawing.Point(70, 58)
        Me.txtCalveCiudad.Name = "txtCalveCiudad"
        Me.txtCalveCiudad.Size = New System.Drawing.Size(165, 20)
        Me.txtCalveCiudad.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCiudad)
        Me.Panel1.Controls.Add(Me.btnGuardarCiudad)
        Me.Panel1.Controls.Add(Me.cmbCiudad)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtCalveCiudad)
        Me.Panel1.Controls.Add(Me.txtNombreMatriz)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(498, 96)
        Me.Panel1.TabIndex = 4
        '
        'btnCiudad
        '
        Me.btnCiudad.Location = New System.Drawing.Point(254, 56)
        Me.btnCiudad.Name = "btnCiudad"
        Me.btnCiudad.Size = New System.Drawing.Size(117, 23)
        Me.btnCiudad.TabIndex = 10
        Me.btnCiudad.Text = "Nueva Ciudad"
        Me.btnCiudad.UseVisualStyleBackColor = True
        '
        'btnGuardarCiudad
        '
        Me.btnGuardarCiudad.Location = New System.Drawing.Point(384, 56)
        Me.btnGuardarCiudad.Name = "btnGuardarCiudad"
        Me.btnGuardarCiudad.Size = New System.Drawing.Size(94, 22)
        Me.btnGuardarCiudad.TabIndex = 9
        Me.btnGuardarCiudad.Text = "Guardar"
        Me.btnGuardarCiudad.UseVisualStyleBackColor = True
        '
        'cmbCiudad
        '
        Me.cmbCiudad.FormattingEnabled = True
        Me.cmbCiudad.Location = New System.Drawing.Point(296, 14)
        Me.cmbCiudad.Name = "cmbCiudad"
        Me.cmbCiudad.Size = New System.Drawing.Size(182, 21)
        Me.cmbCiudad.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(251, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ciudad"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnRefrescar)
        Me.Panel2.Controls.Add(Me.btnActualizar)
        Me.Panel2.Controls.Add(Me.btnEliminarMatriz)
        Me.Panel2.Location = New System.Drawing.Point(378, 143)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(130, 181)
        Me.Panel2.TabIndex = 5
        '
        'tblMatriz
        '
        Me.tblMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblMatriz.Location = New System.Drawing.Point(12, 143)
        Me.tblMatriz.Name = "tblMatriz"
        Me.tblMatriz.Size = New System.Drawing.Size(360, 181)
        Me.tblMatriz.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label9.Location = New System.Drawing.Point(2, 1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 24)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "X"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label16.Location = New System.Drawing.Point(191, 4)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(182, 24)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Acutalizar cliente"
        '
        'btnEliminarMatriz
        '
        Me.btnEliminarMatriz.Location = New System.Drawing.Point(18, 15)
        Me.btnEliminarMatriz.Name = "btnEliminarMatriz"
        Me.btnEliminarMatriz.Size = New System.Drawing.Size(94, 23)
        Me.btnEliminarMatriz.TabIndex = 0
        Me.btnEliminarMatriz.Text = "Eliminar"
        Me.btnEliminarMatriz.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(18, 56)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(94, 23)
        Me.btnActualizar.TabIndex = 1
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Location = New System.Drawing.Point(18, 97)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(94, 23)
        Me.btnRefrescar.TabIndex = 2
        Me.btnRefrescar.Text = "Refrescar"
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'Matriz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 336)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.tblMatriz)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Matriz"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.tblMatriz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombreMatriz As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCalveCiudad As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCiudad As Button
    Friend WithEvents btnGuardarCiudad As Button
    Friend WithEvents cmbCiudad As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tblMatriz As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnRefrescar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminarMatriz As Button
End Class
