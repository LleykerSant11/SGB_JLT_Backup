<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.btn_ocultar = New FontAwesome.Sharp.IconButton()
        Me.btn_ver = New FontAwesome.Sharp.IconButton()
        Me.btn_salir = New FontAwesome.Sharp.IconButton()
        Me.btn_ingresar = New FontAwesome.Sharp.IconButton()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Ivory
        Me.Panel1.Controls.Add(Me.btn_ocultar)
        Me.Panel1.Controls.Add(Me.btn_ver)
        Me.Panel1.Controls.Add(Me.btn_salir)
        Me.Panel1.Controls.Add(Me.btn_ingresar)
        Me.Panel1.Controls.Add(Me.txt_clave)
        Me.Panel1.Controls.Add(Me.txt_usuario)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(30, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(371, 474)
        Me.Panel1.TabIndex = 1
        '
        'btn_ocultar
        '
        Me.btn_ocultar.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Me.btn_ocultar.IconColor = System.Drawing.Color.Black
        Me.btn_ocultar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_ocultar.IconSize = 25
        Me.btn_ocultar.Location = New System.Drawing.Point(305, 323)
        Me.btn_ocultar.Name = "btn_ocultar"
        Me.btn_ocultar.Size = New System.Drawing.Size(30, 31)
        Me.btn_ocultar.TabIndex = 9
        Me.btn_ocultar.UseVisualStyleBackColor = True
        Me.btn_ocultar.Visible = False
        '
        'btn_ver
        '
        Me.btn_ver.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.btn_ver.IconColor = System.Drawing.Color.Black
        Me.btn_ver.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_ver.IconSize = 25
        Me.btn_ver.Location = New System.Drawing.Point(305, 323)
        Me.btn_ver.Name = "btn_ver"
        Me.btn_ver.Size = New System.Drawing.Size(30, 31)
        Me.btn_ver.TabIndex = 8
        Me.btn_ver.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Red
        Me.btn_salir.ForeColor = System.Drawing.Color.White
        Me.btn_salir.IconChar = FontAwesome.Sharp.IconChar.SignOut
        Me.btn_salir.IconColor = System.Drawing.Color.White
        Me.btn_salir.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_salir.IconSize = 25
        Me.btn_salir.Location = New System.Drawing.Point(234, 389)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(101, 36)
        Me.btn_salir.TabIndex = 7
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btn_ingresar
        '
        Me.btn_ingresar.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_ingresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ingresar.ForeColor = System.Drawing.Color.White
        Me.btn_ingresar.IconChar = FontAwesome.Sharp.IconChar.SignInAlt
        Me.btn_ingresar.IconColor = System.Drawing.Color.White
        Me.btn_ingresar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_ingresar.IconSize = 25
        Me.btn_ingresar.Location = New System.Drawing.Point(53, 389)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(101, 36)
        Me.btn_ingresar.TabIndex = 6
        Me.btn_ingresar.Text = "Ingresar"
        Me.btn_ingresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ingresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ingresar.UseVisualStyleBackColor = False
        '
        'txt_clave
        '
        Me.txt_clave.Location = New System.Drawing.Point(53, 329)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(246, 20)
        Me.txt_clave.TabIndex = 5
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(53, 274)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(282, 20)
        Me.txt_usuario.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SGB_JLT_vb.My.Resources.Resources.logo_JLT
        Me.PictureBox1.Location = New System.Drawing.Point(109, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jose Lishner Tudela"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(432, 511)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(500, 550)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_ocultar As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_ver As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_salir As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_ingresar As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_clave As TextBox
    Friend WithEvents txt_usuario As TextBox
End Class
