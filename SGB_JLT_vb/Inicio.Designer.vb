<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.menu_titulo = New System.Windows.Forms.MenuStrip()
        Me.label1 = New System.Windows.Forms.Label()
        Me.menu = New System.Windows.Forms.MenuStrip()
        Me.menu_inicio = New FontAwesome.Sharp.IconMenuItem()
        Me.menu_bibbliotecario = New FontAwesome.Sharp.IconMenuItem()
        Me.menu_transaciones = New FontAwesome.Sharp.IconMenuItem()
        Me.sm_prestacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.sm_devolucion = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_inventario = New FontAwesome.Sharp.IconMenuItem()
        Me.smenu_categorias = New System.Windows.Forms.ToolStripMenuItem()
        Me.smenu_matbibliografico = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_lectores = New FontAwesome.Sharp.IconMenuItem()
        Me.menureportes = New FontAwesome.Sharp.IconMenuItem()
        Me.menuacercade = New FontAwesome.Sharp.IconMenuItem()
        Me.DetalleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu_titulo
        '
        Me.menu_titulo.AutoSize = False
        Me.menu_titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.menu_titulo.Location = New System.Drawing.Point(0, 0)
        Me.menu_titulo.Name = "menu_titulo"
        Me.menu_titulo.Size = New System.Drawing.Size(1234, 56)
        Me.menu_titulo.TabIndex = 7
        Me.menu_titulo.Text = "menuStrip2"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.label1.Font = New System.Drawing.Font("Perpetua Titling MT", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(526, 34)
        Me.label1.TabIndex = 12
        Me.label1.Text = "Biblioteca ""Jose Lishner Tudela"""
        '
        'menu
        '
        Me.menu.BackColor = System.Drawing.Color.White
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_inicio, Me.menu_bibbliotecario, Me.menu_transaciones, Me.menu_inventario, Me.menu_lectores, Me.menureportes, Me.menuacercade})
        Me.menu.Location = New System.Drawing.Point(0, 56)
        Me.menu.Name = "menu"
        Me.menu.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.menu.Size = New System.Drawing.Size(1234, 73)
        Me.menu.TabIndex = 13
        Me.menu.Text = "menuStrip1"
        '
        'menu_inicio
        '
        Me.menu_inicio.AutoSize = False
        Me.menu_inicio.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.menu_inicio.IconColor = System.Drawing.Color.Black
        Me.menu_inicio.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.menu_inicio.IconSize = 50
        Me.menu_inicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menu_inicio.Name = "menu_inicio"
        Me.menu_inicio.Size = New System.Drawing.Size(94, 69)
        Me.menu_inicio.Text = "Inicio"
        Me.menu_inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'menu_bibbliotecario
        '
        Me.menu_bibbliotecario.AutoSize = False
        Me.menu_bibbliotecario.IconChar = FontAwesome.Sharp.IconChar.UserCog
        Me.menu_bibbliotecario.IconColor = System.Drawing.Color.Black
        Me.menu_bibbliotecario.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.menu_bibbliotecario.IconSize = 50
        Me.menu_bibbliotecario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menu_bibbliotecario.Name = "menu_bibbliotecario"
        Me.menu_bibbliotecario.Size = New System.Drawing.Size(94, 69)
        Me.menu_bibbliotecario.Text = "Bibliotecario"
        Me.menu_bibbliotecario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'menu_transaciones
        '
        Me.menu_transaciones.AutoSize = False
        Me.menu_transaciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sm_prestacion, Me.sm_devolucion, Me.DetalleToolStripMenuItem})
        Me.menu_transaciones.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench
        Me.menu_transaciones.IconColor = System.Drawing.Color.Black
        Me.menu_transaciones.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.menu_transaciones.IconSize = 50
        Me.menu_transaciones.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menu_transaciones.Name = "menu_transaciones"
        Me.menu_transaciones.Size = New System.Drawing.Size(94, 69)
        Me.menu_transaciones.Text = "Transaciones"
        Me.menu_transaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'sm_prestacion
        '
        Me.sm_prestacion.Name = "sm_prestacion"
        Me.sm_prestacion.Size = New System.Drawing.Size(134, 22)
        Me.sm_prestacion.Text = "Prestacion"
        '
        'sm_devolucion
        '
        Me.sm_devolucion.Name = "sm_devolucion"
        Me.sm_devolucion.Size = New System.Drawing.Size(134, 22)
        Me.sm_devolucion.Text = "Devolucion"
        '
        'menu_inventario
        '
        Me.menu_inventario.AutoSize = False
        Me.menu_inventario.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smenu_categorias, Me.smenu_matbibliografico})
        Me.menu_inventario.IconChar = FontAwesome.Sharp.IconChar.Book
        Me.menu_inventario.IconColor = System.Drawing.Color.Black
        Me.menu_inventario.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.menu_inventario.IconSize = 50
        Me.menu_inventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menu_inventario.Name = "menu_inventario"
        Me.menu_inventario.Size = New System.Drawing.Size(94, 69)
        Me.menu_inventario.Text = "Inventario"
        Me.menu_inventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'smenu_categorias
        '
        Me.smenu_categorias.Name = "smenu_categorias"
        Me.smenu_categorias.Size = New System.Drawing.Size(187, 22)
        Me.smenu_categorias.Text = "Categorias"
        '
        'smenu_matbibliografico
        '
        Me.smenu_matbibliografico.Name = "smenu_matbibliografico"
        Me.smenu_matbibliografico.Size = New System.Drawing.Size(187, 22)
        Me.smenu_matbibliografico.Text = "Material Bibliografico"
        '
        'menu_lectores
        '
        Me.menu_lectores.AutoSize = False
        Me.menu_lectores.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed
        Me.menu_lectores.IconColor = System.Drawing.Color.Black
        Me.menu_lectores.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.menu_lectores.IconSize = 50
        Me.menu_lectores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menu_lectores.Name = "menu_lectores"
        Me.menu_lectores.Size = New System.Drawing.Size(80, 69)
        Me.menu_lectores.Text = "Lectores"
        Me.menu_lectores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'menureportes
        '
        Me.menureportes.AutoSize = False
        Me.menureportes.IconChar = FontAwesome.Sharp.IconChar.BarChart
        Me.menureportes.IconColor = System.Drawing.Color.Black
        Me.menureportes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.menureportes.IconSize = 50
        Me.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menureportes.Name = "menureportes"
        Me.menureportes.Size = New System.Drawing.Size(80, 69)
        Me.menureportes.Text = "Reportes"
        Me.menureportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'menuacercade
        '
        Me.menuacercade.AutoSize = False
        Me.menuacercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo
        Me.menuacercade.IconColor = System.Drawing.Color.Black
        Me.menuacercade.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.menuacercade.IconSize = 50
        Me.menuacercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuacercade.Name = "menuacercade"
        Me.menuacercade.Size = New System.Drawing.Size(80, 69)
        Me.menuacercade.Text = "Acerca de"
        Me.menuacercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DetalleToolStripMenuItem
        '
        Me.DetalleToolStripMenuItem.Name = "DetalleToolStripMenuItem"
        Me.DetalleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DetalleToolStripMenuItem.Text = "Detalle"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 761)
        Me.Controls.Add(Me.menu)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.menu_titulo)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1250, 800)
        Me.MinimizeBox = False
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents menu_titulo As MenuStrip
    Private WithEvents label1 As Label
    Private WithEvents menu As MenuStrip
    Private WithEvents menu_inicio As FontAwesome.Sharp.IconMenuItem
    Private WithEvents menu_bibbliotecario As FontAwesome.Sharp.IconMenuItem
    Private WithEvents menu_transaciones As FontAwesome.Sharp.IconMenuItem
    Private WithEvents menu_inventario As FontAwesome.Sharp.IconMenuItem
    Private WithEvents menu_lectores As FontAwesome.Sharp.IconMenuItem
    Private WithEvents menureportes As FontAwesome.Sharp.IconMenuItem
    Private WithEvents menuacercade As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents sm_prestacion As ToolStripMenuItem
    Friend WithEvents sm_devolucion As ToolStripMenuItem
    Friend WithEvents smenu_categorias As ToolStripMenuItem
    Friend WithEvents smenu_matbibliografico As ToolStripMenuItem
    Friend WithEvents DetalleToolStripMenuItem As ToolStripMenuItem
End Class
