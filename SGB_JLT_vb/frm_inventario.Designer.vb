<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_inventario
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
        Me.pn_container = New System.Windows.Forms.Panel()
        Me.btn_limpiar = New FontAwesome.Sharp.IconButton()
        Me.btn_eliminar = New FontAwesome.Sharp.IconButton()
        Me.btn_guardar = New FontAwesome.Sharp.IconButton()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.textBox5 = New System.Windows.Forms.TextBox()
        Me.textBox6 = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.lb_detusuario = New System.Windows.Forms.Label()
        Me.pn_container.SuspendLayout()
        Me.SuspendLayout()
        '
        'pn_container
        '
        Me.pn_container.BackColor = System.Drawing.Color.White
        Me.pn_container.Controls.Add(Me.btn_limpiar)
        Me.pn_container.Controls.Add(Me.btn_eliminar)
        Me.pn_container.Controls.Add(Me.btn_guardar)
        Me.pn_container.Controls.Add(Me.textBox3)
        Me.pn_container.Controls.Add(Me.textBox4)
        Me.pn_container.Controls.Add(Me.textBox5)
        Me.pn_container.Controls.Add(Me.textBox6)
        Me.pn_container.Controls.Add(Me.label7)
        Me.pn_container.Controls.Add(Me.label9)
        Me.pn_container.Controls.Add(Me.label2)
        Me.pn_container.Controls.Add(Me.label8)
        Me.pn_container.Controls.Add(Me.textBox1)
        Me.pn_container.Controls.Add(Me.label3)
        Me.pn_container.Controls.Add(Me.label4)
        Me.pn_container.Controls.Add(Me.lb_detusuario)
        Me.pn_container.Dock = System.Windows.Forms.DockStyle.Left
        Me.pn_container.Location = New System.Drawing.Point(0, 0)
        Me.pn_container.Name = "pn_container"
        Me.pn_container.Size = New System.Drawing.Size(216, 495)
        Me.pn_container.TabIndex = 8
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_limpiar.ForeColor = System.Drawing.Color.White
        Me.btn_limpiar.IconChar = FontAwesome.Sharp.IconChar.Broom
        Me.btn_limpiar.IconColor = System.Drawing.Color.White
        Me.btn_limpiar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_limpiar.IconSize = 25
        Me.btn_limpiar.Location = New System.Drawing.Point(28, 371)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(163, 35)
        Me.btn_limpiar.TabIndex = 26
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Red
        Me.btn_eliminar.ForeColor = System.Drawing.Color.White
        Me.btn_eliminar.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_eliminar.IconColor = System.Drawing.Color.White
        Me.btn_eliminar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_eliminar.IconSize = 25
        Me.btn_eliminar.Location = New System.Drawing.Point(27, 412)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(163, 35)
        Me.btn_eliminar.TabIndex = 25
        Me.btn_eliminar.Text = "eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_guardar.IconColor = System.Drawing.Color.White
        Me.btn_guardar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_guardar.IconSize = 25
        Me.btn_guardar.Location = New System.Drawing.Point(27, 330)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(163, 35)
        Me.btn_guardar.TabIndex = 24
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(28, 228)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(163, 20)
        Me.textBox3.TabIndex = 12
        '
        'textBox4
        '
        Me.textBox4.Location = New System.Drawing.Point(28, 189)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(163, 20)
        Me.textBox4.TabIndex = 13
        '
        'textBox5
        '
        Me.textBox5.Location = New System.Drawing.Point(28, 150)
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New System.Drawing.Size(163, 20)
        Me.textBox5.TabIndex = 14
        '
        'textBox6
        '
        Me.textBox6.Location = New System.Drawing.Point(28, 111)
        Me.textBox6.Name = "textBox6"
        Me.textBox6.Size = New System.Drawing.Size(163, 20)
        Me.textBox6.TabIndex = 15
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(25, 251)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(0, 13)
        Me.label7.TabIndex = 14
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(25, 212)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(111, 13)
        Me.label9.TabIndex = 16
        Me.label9.Text = "Confirmar Contraseña:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(25, 56)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(85, 13)
        Me.label2.TabIndex = 10
        Me.label2.Text = "Nro Documento:"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(24, 173)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(64, 13)
        Me.label8.TabIndex = 15
        Me.label8.Text = "Contraseña:"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(27, 72)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(164, 20)
        Me.textBox1.TabIndex = 10
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(25, 134)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(41, 13)
        Me.label3.TabIndex = 11
        Me.label3.Text = "Correo:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(25, 95)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(94, 13)
        Me.label4.TabIndex = 12
        Me.label4.Text = "Nombre Completo:"
        '
        'lb_detusuario
        '
        Me.lb_detusuario.AutoSize = True
        Me.lb_detusuario.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_detusuario.Location = New System.Drawing.Point(7, 9)
        Me.lb_detusuario.Name = "lb_detusuario"
        Me.lb_detusuario.Size = New System.Drawing.Size(206, 22)
        Me.lb_detusuario.TabIndex = 0
        Me.lb_detusuario.Text = "Detalle de Bibliotecario:"
        '
        'frm_inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1051, 495)
        Me.Controls.Add(Me.pn_container)
        Me.Name = "frm_inventario"
        Me.Text = "frm_inventario"
        Me.pn_container.ResumeLayout(False)
        Me.pn_container.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pn_container As Panel
    Private WithEvents btn_limpiar As FontAwesome.Sharp.IconButton
    Private WithEvents btn_eliminar As FontAwesome.Sharp.IconButton
    Private WithEvents btn_guardar As FontAwesome.Sharp.IconButton
    Private WithEvents textBox3 As TextBox
    Private WithEvents textBox4 As TextBox
    Private WithEvents textBox5 As TextBox
    Private WithEvents textBox6 As TextBox
    Private WithEvents label7 As Label
    Private WithEvents label9 As Label
    Private WithEvents label2 As Label
    Private WithEvents label8 As Label
    Private WithEvents textBox1 As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label4 As Label
    Private WithEvents lb_detusuario As Label
End Class
