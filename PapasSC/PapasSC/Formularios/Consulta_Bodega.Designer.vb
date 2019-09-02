<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Consulta_Bodega
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consulta_Bodega))
        Me.eliminar = New System.Windows.Forms.Button()
        Me.actualizar = New System.Windows.Forms.Button()
        Me.registrar = New System.Windows.Forms.Button()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.tablabodega = New System.Windows.Forms.DataGridView()
        Me.FiltroBodega = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.tablabodega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'eliminar
        '
        Me.eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminar.Image = CType(resources.GetObject("eliminar.Image"), System.Drawing.Image)
        Me.eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.eliminar.Location = New System.Drawing.Point(601, 406)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(169, 36)
        Me.eliminar.TabIndex = 17
        Me.eliminar.Text = "Eliminar Bodega"
        Me.eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'actualizar
        '
        Me.actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.actualizar.Image = CType(resources.GetObject("actualizar.Image"), System.Drawing.Image)
        Me.actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.actualizar.Location = New System.Drawing.Point(426, 406)
        Me.actualizar.Name = "actualizar"
        Me.actualizar.Size = New System.Drawing.Size(169, 36)
        Me.actualizar.TabIndex = 16
        Me.actualizar.Text = "Actualizar Bodega"
        Me.actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.actualizar.UseVisualStyleBackColor = True
        '
        'registrar
        '
        Me.registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registrar.Image = CType(resources.GetObject("registrar.Image"), System.Drawing.Image)
        Me.registrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.registrar.Location = New System.Drawing.Point(251, 406)
        Me.registrar.Name = "registrar"
        Me.registrar.Size = New System.Drawing.Size(169, 36)
        Me.registrar.TabIndex = 15
        Me.registrar.Text = "Registrar Bodega"
        Me.registrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.registrar.UseVisualStyleBackColor = True
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(590, 8)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(191, 23)
        Me.Buscar.TabIndex = 14
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'tablabodega
        '
        Me.tablabodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablabodega.Location = New System.Drawing.Point(58, 65)
        Me.tablabodega.Name = "tablabodega"
        Me.tablabodega.Size = New System.Drawing.Size(682, 323)
        Me.tablabodega.TabIndex = 13
        '
        'FiltroBodega
        '
        Me.FiltroBodega.FormattingEnabled = True
        Me.FiltroBodega.Items.AddRange(New Object() {"Nombre Bodega", "Estatus Bodega", "Nombre Matriz ", "Clave Matriz", "Ciudad"})
        Me.FiltroBodega.Location = New System.Drawing.Point(95, 10)
        Me.FiltroBodega.Name = "FiltroBodega"
        Me.FiltroBodega.Size = New System.Drawing.Size(150, 21)
        Me.FiltroBodega.TabIndex = 12
        Me.FiltroBodega.Text = "Selecion de filtro"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(251, 10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(333, 20)
        Me.TextBox1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Filtro Bodega"
        '
        'Consulta_Bodega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.eliminar)
        Me.Controls.Add(Me.actualizar)
        Me.Controls.Add(Me.registrar)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.tablabodega)
        Me.Controls.Add(Me.FiltroBodega)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Consulta_Bodega"
        Me.Text = "Consulta_Bodega"
        CType(Me.tablabodega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents eliminar As Button
    Friend WithEvents actualizar As Button
    Friend WithEvents registrar As Button
    Friend WithEvents Buscar As Button
    Friend WithEvents tablabodega As DataGridView
    Friend WithEvents FiltroBodega As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
