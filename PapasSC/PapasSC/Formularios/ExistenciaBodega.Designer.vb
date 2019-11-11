<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExistenciaBodega
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
        Me.tblexistenciapro = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ActulizarExistencia = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.filtroExistencia = New System.Windows.Forms.ComboBox()
        Me.Reclasificacion = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnAvanzado = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnactivar = New System.Windows.Forms.Button()
        CType(Me.tblexistenciapro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblexistenciapro
        '
        Me.tblexistenciapro.AllowUserToAddRows = False
        Me.tblexistenciapro.AllowUserToDeleteRows = False
        Me.tblexistenciapro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblexistenciapro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblexistenciapro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblexistenciapro.Location = New System.Drawing.Point(25, 81)
        Me.tblexistenciapro.Name = "tblexistenciapro"
        Me.tblexistenciapro.ReadOnly = True
        Me.tblexistenciapro.Size = New System.Drawing.Size(726, 251)
        Me.tblexistenciapro.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(407, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 50)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Agregar Existencias "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(504, 358)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 50)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Agregar bodega"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ActulizarExistencia
        '
        Me.ActulizarExistencia.Location = New System.Drawing.Point(323, 358)
        Me.ActulizarExistencia.Name = "ActulizarExistencia"
        Me.ActulizarExistencia.Size = New System.Drawing.Size(78, 50)
        Me.ActulizarExistencia.TabIndex = 3
        Me.ActulizarExistencia.Text = "Actualizar Existencia"
        Me.ActulizarExistencia.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(676, 356)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 50)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Eliminar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(165, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(434, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(612, 29)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(139, 23)
        Me.Buscar.TabIndex = 6
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'filtroExistencia
        '
        Me.filtroExistencia.FormattingEnabled = True
        Me.filtroExistencia.Items.AddRange(New Object() {"Cantidad", "Bodega", "Precio", "Estatus", "Producto"})
        Me.filtroExistencia.Location = New System.Drawing.Point(38, 28)
        Me.filtroExistencia.Name = "filtroExistencia"
        Me.filtroExistencia.Size = New System.Drawing.Size(121, 21)
        Me.filtroExistencia.TabIndex = 7
        Me.filtroExistencia.Text = "Seleccione filtro"
        '
        'Reclasificacion
        '
        Me.Reclasificacion.Location = New System.Drawing.Point(228, 359)
        Me.Reclasificacion.Name = "Reclasificacion"
        Me.Reclasificacion.Size = New System.Drawing.Size(89, 48)
        Me.Reclasificacion.TabIndex = 8
        Me.Reclasificacion.Text = "Reclaficacion"
        Me.Reclasificacion.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(590, 357)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 50)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Agregar Producto"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnAvanzado
        '
        Me.btnAvanzado.Location = New System.Drawing.Point(134, 359)
        Me.btnAvanzado.Name = "btnAvanzado"
        Me.btnAvanzado.Size = New System.Drawing.Size(88, 48)
        Me.btnAvanzado.TabIndex = 10
        Me.btnAvanzado.Text = "Funciones avanzadas"
        Me.btnAvanzado.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(38, 58)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(205, 17)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Productos Dados de Baja en Bodega "
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnactivar
        '
        Me.btnactivar.Location = New System.Drawing.Point(245, 54)
        Me.btnactivar.Name = "btnactivar"
        Me.btnactivar.Size = New System.Drawing.Size(115, 23)
        Me.btnactivar.TabIndex = 12
        Me.btnactivar.Text = "Activar"
        Me.btnactivar.UseVisualStyleBackColor = True
        '
        'ExistenciaBodega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 427)
        Me.Controls.Add(Me.btnactivar)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnAvanzado)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Reclasificacion)
        Me.Controls.Add(Me.filtroExistencia)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ActulizarExistencia)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tblexistenciapro)
        Me.Name = "ExistenciaBodega"
        Me.Text = "ExistenciaBodega"
        CType(Me.tblexistenciapro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tblexistenciapro As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ActulizarExistencia As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Buscar As Button
    Friend WithEvents filtroExistencia As ComboBox
    Friend WithEvents Reclasificacion As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnAvanzado As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnactivar As Button
End Class
