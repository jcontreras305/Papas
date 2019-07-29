<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Minimizar = New System.Windows.Forms.Label()
        Me.Cerrar = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ConfiguracionMenuPrincipal = New System.Windows.Forms.Button()
        Me.ControlMenuPrincipal = New System.Windows.Forms.Button()
        Me.UtileriasMenuPrincipal = New System.Windows.Forms.Button()
        Me.NominaMenuPrincipal = New System.Windows.Forms.Button()
        Me.CatalogoMenuPrincipal = New System.Windows.Forms.Button()
        Me.ReporteMenuPrincipal = New System.Windows.Forms.Button()
        Me.InventarioMenuPrincipal = New System.Windows.Forms.Button()
        Me.VentasMenuPrincipal = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Minimizar)
        Me.Panel1.Controls.Add(Me.Cerrar)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1082, 42)
        Me.Panel1.TabIndex = 0
        '
        'Minimizar
        '
        Me.Minimizar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Minimizar.AutoSize = True
        Me.Minimizar.Location = New System.Drawing.Point(977, 11)
        Me.Minimizar.Name = "Minimizar"
        Me.Minimizar.Size = New System.Drawing.Size(50, 13)
        Me.Minimizar.TabIndex = 3
        Me.Minimizar.Text = "Minimizar"
        '
        'Cerrar
        '
        Me.Cerrar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Cerrar.AutoSize = True
        Me.Cerrar.Location = New System.Drawing.Point(1033, 12)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(35, 13)
        Me.Cerrar.TabIndex = 1
        Me.Cerrar.Text = "Cerrar"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1082, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel2.Controls.Add(Me.ConfiguracionMenuPrincipal)
        Me.Panel2.Controls.Add(Me.ControlMenuPrincipal)
        Me.Panel2.Controls.Add(Me.UtileriasMenuPrincipal)
        Me.Panel2.Controls.Add(Me.NominaMenuPrincipal)
        Me.Panel2.Controls.Add(Me.CatalogoMenuPrincipal)
        Me.Panel2.Controls.Add(Me.ReporteMenuPrincipal)
        Me.Panel2.Controls.Add(Me.InventarioMenuPrincipal)
        Me.Panel2.Controls.Add(Me.VentasMenuPrincipal)
        Me.Panel2.Location = New System.Drawing.Point(0, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(188, 492)
        Me.Panel2.TabIndex = 1
        '
        'ConfiguracionMenuPrincipal
        '
        Me.ConfiguracionMenuPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ConfiguracionMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ConfiguracionMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConfiguracionMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ConfiguracionMenuPrincipal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfiguracionMenuPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ConfiguracionMenuPrincipal.Location = New System.Drawing.Point(1, 427)
        Me.ConfiguracionMenuPrincipal.Name = "ConfiguracionMenuPrincipal"
        Me.ConfiguracionMenuPrincipal.Size = New System.Drawing.Size(181, 44)
        Me.ConfiguracionMenuPrincipal.TabIndex = 7
        Me.ConfiguracionMenuPrincipal.Text = "Configuración"
        Me.ConfiguracionMenuPrincipal.UseVisualStyleBackColor = True
        '
        'ControlMenuPrincipal
        '
        Me.ControlMenuPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ControlMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ControlMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ControlMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ControlMenuPrincipal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlMenuPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ControlMenuPrincipal.Location = New System.Drawing.Point(1, 370)
        Me.ControlMenuPrincipal.Name = "ControlMenuPrincipal"
        Me.ControlMenuPrincipal.Size = New System.Drawing.Size(181, 48)
        Me.ControlMenuPrincipal.TabIndex = 6
        Me.ControlMenuPrincipal.Text = "Control"
        Me.ControlMenuPrincipal.UseVisualStyleBackColor = True
        '
        'UtileriasMenuPrincipal
        '
        Me.UtileriasMenuPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.UtileriasMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.UtileriasMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UtileriasMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UtileriasMenuPrincipal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UtileriasMenuPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.UtileriasMenuPrincipal.Location = New System.Drawing.Point(0, 309)
        Me.UtileriasMenuPrincipal.Name = "UtileriasMenuPrincipal"
        Me.UtileriasMenuPrincipal.Size = New System.Drawing.Size(181, 51)
        Me.UtileriasMenuPrincipal.TabIndex = 5
        Me.UtileriasMenuPrincipal.Text = "Utilerias"
        Me.UtileriasMenuPrincipal.UseVisualStyleBackColor = True
        '
        'NominaMenuPrincipal
        '
        Me.NominaMenuPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NominaMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.NominaMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NominaMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NominaMenuPrincipal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NominaMenuPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NominaMenuPrincipal.Location = New System.Drawing.Point(0, 248)
        Me.NominaMenuPrincipal.Name = "NominaMenuPrincipal"
        Me.NominaMenuPrincipal.Size = New System.Drawing.Size(181, 51)
        Me.NominaMenuPrincipal.TabIndex = 4
        Me.NominaMenuPrincipal.Text = "Nomina"
        Me.NominaMenuPrincipal.UseVisualStyleBackColor = True
        '
        'CatalogoMenuPrincipal
        '
        Me.CatalogoMenuPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CatalogoMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CatalogoMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CatalogoMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CatalogoMenuPrincipal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CatalogoMenuPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CatalogoMenuPrincipal.Location = New System.Drawing.Point(0, 188)
        Me.CatalogoMenuPrincipal.Name = "CatalogoMenuPrincipal"
        Me.CatalogoMenuPrincipal.Size = New System.Drawing.Size(181, 51)
        Me.CatalogoMenuPrincipal.TabIndex = 3
        Me.CatalogoMenuPrincipal.Text = "Catalogo"
        Me.CatalogoMenuPrincipal.UseVisualStyleBackColor = True
        '
        'ReporteMenuPrincipal
        '
        Me.ReporteMenuPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ReporteMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ReporteMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReporteMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ReporteMenuPrincipal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReporteMenuPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ReporteMenuPrincipal.Location = New System.Drawing.Point(0, 130)
        Me.ReporteMenuPrincipal.Name = "ReporteMenuPrincipal"
        Me.ReporteMenuPrincipal.Size = New System.Drawing.Size(181, 47)
        Me.ReporteMenuPrincipal.TabIndex = 2
        Me.ReporteMenuPrincipal.Text = "Reportes"
        Me.ReporteMenuPrincipal.UseVisualStyleBackColor = True
        '
        'InventarioMenuPrincipal
        '
        Me.InventarioMenuPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.InventarioMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.InventarioMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.InventarioMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InventarioMenuPrincipal.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.InventarioMenuPrincipal.FlatAppearance.BorderSize = 10
        Me.InventarioMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.InventarioMenuPrincipal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventarioMenuPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.InventarioMenuPrincipal.Location = New System.Drawing.Point(2, 72)
        Me.InventarioMenuPrincipal.Name = "InventarioMenuPrincipal"
        Me.InventarioMenuPrincipal.Size = New System.Drawing.Size(182, 46)
        Me.InventarioMenuPrincipal.TabIndex = 1
        Me.InventarioMenuPrincipal.Text = "Inventario"
        Me.InventarioMenuPrincipal.UseVisualStyleBackColor = False
        '
        'VentasMenuPrincipal
        '
        Me.VentasMenuPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.VentasMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.VentasMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VentasMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VentasMenuPrincipal.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.VentasMenuPrincipal.FlatAppearance.BorderSize = 10
        Me.VentasMenuPrincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.VentasMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.VentasMenuPrincipal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentasMenuPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.VentasMenuPrincipal.Location = New System.Drawing.Point(1, 11)
        Me.VentasMenuPrincipal.Margin = New System.Windows.Forms.Padding(2, 3, 3, 1)
        Me.VentasMenuPrincipal.Name = "VentasMenuPrincipal"
        Me.VentasMenuPrincipal.Size = New System.Drawing.Size(182, 49)
        Me.VentasMenuPrincipal.TabIndex = 0
        Me.VentasMenuPrincipal.Text = "Ventas"
        Me.VentasMenuPrincipal.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(194, 49)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(875, 465)
        Me.Panel3.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(325, 220)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(508, 302)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1081, 526)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ConfiguracionMenuPrincipal As Button
    Friend WithEvents ControlMenuPrincipal As Button
    Friend WithEvents UtileriasMenuPrincipal As Button
    Friend WithEvents NominaMenuPrincipal As Button
    Friend WithEvents CatalogoMenuPrincipal As Button
    Friend WithEvents ReporteMenuPrincipal As Button
    Friend WithEvents InventarioMenuPrincipal As Button
    Friend WithEvents VentasMenuPrincipal As Button
    Friend WithEvents Minimizar As Label
    Friend WithEvents Cerrar As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
