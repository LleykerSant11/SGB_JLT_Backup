<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mtbibliografico
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.txt_buscat = New System.Windows.Forms.TextBox()
        Me.btn_descargarexcel = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pn_container = New System.Windows.Forms.Panel()
        Me.lb_detusuario = New System.Windows.Forms.Label()
        Me.btn_guardar = New FontAwesome.Sharp.IconButton()
        Me.btn_nuevo = New FontAwesome.Sharp.IconButton()
        Me.btn_actualizar = New FontAwesome.Sharp.IconButton()
        Me.btn_eliminar = New FontAwesome.Sharp.IconButton()
        Me.btn_modificar = New FontAwesome.Sharp.IconButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.pn_container.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.IconButton2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.txt_buscat)
        Me.Panel1.Controls.Add(Me.btn_descargarexcel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(279, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(843, 66)
        Me.Panel1.TabIndex = 20
        '
        'IconButton2
        '
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Broom
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 20
        Me.IconButton2.Location = New System.Drawing.Point(763, 23)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(29, 23)
        Me.IconButton2.TabIndex = 17
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(307, 23)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'IconButton1
        '
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 20
        Me.IconButton1.Location = New System.Drawing.Point(728, 23)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(29, 23)
        Me.IconButton1.TabIndex = 16
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'txt_buscat
        '
        Me.txt_buscat.Location = New System.Drawing.Point(434, 23)
        Me.txt_buscat.Name = "txt_buscat"
        Me.txt_buscat.Size = New System.Drawing.Size(288, 20)
        Me.txt_buscat.TabIndex = 14
        '
        'btn_descargarexcel
        '
        Me.btn_descargarexcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel
        Me.btn_descargarexcel.IconColor = System.Drawing.Color.Green
        Me.btn_descargarexcel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_descargarexcel.IconSize = 20
        Me.btn_descargarexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_descargarexcel.Location = New System.Drawing.Point(7, 26)
        Me.btn_descargarexcel.Name = "btn_descargarexcel"
        Me.btn_descargarexcel.Size = New System.Drawing.Size(130, 28)
        Me.btn_descargarexcel.TabIndex = 14
        Me.btn_descargarexcel.Text = "Descargar Excel"
        Me.btn_descargarexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_descargarexcel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(234, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Busacr por: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(245, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Listado de M.Bibliografico:"
        '
        'pn_container
        '
        Me.pn_container.BackColor = System.Drawing.Color.White
        Me.pn_container.Controls.Add(Me.GroupBox1)
        Me.pn_container.Controls.Add(Me.btn_guardar)
        Me.pn_container.Controls.Add(Me.btn_nuevo)
        Me.pn_container.Controls.Add(Me.btn_actualizar)
        Me.pn_container.Controls.Add(Me.btn_eliminar)
        Me.pn_container.Controls.Add(Me.btn_modificar)
        Me.pn_container.Controls.Add(Me.lb_detusuario)
        Me.pn_container.Dock = System.Windows.Forms.DockStyle.Left
        Me.pn_container.Location = New System.Drawing.Point(0, 0)
        Me.pn_container.Name = "pn_container"
        Me.pn_container.Size = New System.Drawing.Size(239, 561)
        Me.pn_container.TabIndex = 21
        '
        'lb_detusuario
        '
        Me.lb_detusuario.AutoSize = True
        Me.lb_detusuario.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_detusuario.Location = New System.Drawing.Point(3, 9)
        Me.lb_detusuario.Name = "lb_detusuario"
        Me.lb_detusuario.Size = New System.Drawing.Size(233, 22)
        Me.lb_detusuario.TabIndex = 0
        Me.lb_detusuario.Text = "Detalle del M.Bibliografico:"
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_guardar.IconColor = System.Drawing.Color.White
        Me.btn_guardar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_guardar.IconSize = 25
        Me.btn_guardar.Location = New System.Drawing.Point(31, 392)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(163, 35)
        Me.btn_guardar.TabIndex = 33
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.Teal
        Me.btn_nuevo.ForeColor = System.Drawing.Color.White
        Me.btn_nuevo.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_nuevo.IconColor = System.Drawing.Color.White
        Me.btn_nuevo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_nuevo.IconSize = 25
        Me.btn_nuevo.Location = New System.Drawing.Point(30, 354)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(163, 35)
        Me.btn_nuevo.TabIndex = 32
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_actualizar
        '
        Me.btn_actualizar.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_actualizar.ForeColor = System.Drawing.Color.White
        Me.btn_actualizar.IconChar = FontAwesome.Sharp.IconChar.Broom
        Me.btn_actualizar.IconColor = System.Drawing.Color.White
        Me.btn_actualizar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_actualizar.IconSize = 25
        Me.btn_actualizar.Location = New System.Drawing.Point(31, 474)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(163, 35)
        Me.btn_actualizar.TabIndex = 31
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_actualizar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Red
        Me.btn_eliminar.ForeColor = System.Drawing.Color.White
        Me.btn_eliminar.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_eliminar.IconColor = System.Drawing.Color.White
        Me.btn_eliminar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_eliminar.IconSize = 25
        Me.btn_eliminar.Location = New System.Drawing.Point(30, 515)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(163, 35)
        Me.btn_eliminar.TabIndex = 30
        Me.btn_eliminar.Text = "eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_modificar.ForeColor = System.Drawing.Color.White
        Me.btn_modificar.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_modificar.IconColor = System.Drawing.Color.White
        Me.btn_modificar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_modificar.IconSize = 25
        Me.btn_modificar.Location = New System.Drawing.Point(30, 433)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(163, 35)
        Me.btn_modificar.TabIndex = 29
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(21, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 280)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos:"
        '
        'frm_mtbibliografico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1134, 561)
        Me.Controls.Add(Me.pn_container)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(1150, 600)
        Me.Name = "frm_mtbibliografico"
        Me.Text = "frm_mtbibliografico"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pn_container.ResumeLayout(False)
        Me.pn_container.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Panel1 As Panel
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_buscat As TextBox
    Friend WithEvents btn_descargarexcel As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Private WithEvents pn_container As Panel
    Private WithEvents lb_detusuario As Label
    Private WithEvents btn_guardar As FontAwesome.Sharp.IconButton
    Private WithEvents btn_nuevo As FontAwesome.Sharp.IconButton
    Private WithEvents btn_actualizar As FontAwesome.Sharp.IconButton
    Private WithEvents btn_eliminar As FontAwesome.Sharp.IconButton
    Private WithEvents btn_modificar As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox1 As GroupBox
End Class
