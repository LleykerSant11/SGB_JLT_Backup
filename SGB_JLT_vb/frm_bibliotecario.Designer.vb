<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_bibliotecario
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
        Me.components = New System.ComponentModel.Container()
        Dim CODBIBLILabel As System.Windows.Forms.Label
        Dim NombreApellidosLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim ClaveLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim UsuarioLabel As System.Windows.Forms.Label
        Me.pn_container = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CODBIBLITextBox = New System.Windows.Forms.TextBox()
        Me.BIBLIOTECARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_BIBLIOTECA_V2DataSet = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSet()
        Me.NombreApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.ClaveTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.lb_detusuario = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txt_buscat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BIBLIOTECARIODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BIBLIOTECARIOTableAdapter = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.BIBLIOTECARIOTableAdapter()
        Me.TableAdapterManager = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.TableAdapterManager()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.btn_descargarexcel = New FontAwesome.Sharp.IconButton()
        Me.btn_guardarB = New FontAwesome.Sharp.IconButton()
        Me.btn_nuevoB = New FontAwesome.Sharp.IconButton()
        Me.btn_actualizarB = New FontAwesome.Sharp.IconButton()
        Me.btn_eliminarB = New FontAwesome.Sharp.IconButton()
        Me.btn_modificarB = New FontAwesome.Sharp.IconButton()
        CODBIBLILabel = New System.Windows.Forms.Label()
        NombreApellidosLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        ClaveLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        UsuarioLabel = New System.Windows.Forms.Label()
        Me.pn_container.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BIBLIOTECARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_BIBLIOTECA_V2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BIBLIOTECARIODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CODBIBLILabel
        '
        CODBIBLILabel.AutoSize = True
        CODBIBLILabel.Location = New System.Drawing.Point(22, 50)
        CODBIBLILabel.Name = "CODBIBLILabel"
        CODBIBLILabel.Size = New System.Drawing.Size(59, 13)
        CODBIBLILabel.TabIndex = 0
        CODBIBLILabel.Text = "CODBIBLI:"
        '
        'NombreApellidosLabel
        '
        NombreApellidosLabel.AutoSize = True
        NombreApellidosLabel.Location = New System.Drawing.Point(22, 76)
        NombreApellidosLabel.Name = "NombreApellidosLabel"
        NombreApellidosLabel.Size = New System.Drawing.Size(92, 13)
        NombreApellidosLabel.TabIndex = 2
        NombreApellidosLabel.Text = "Nombre Apellidos:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(22, 102)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 4
        TelefonoLabel.Text = "Telefono:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(22, 128)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 6
        DireccionLabel.Text = "Direccion:"
        '
        'ClaveLabel
        '
        ClaveLabel.AutoSize = True
        ClaveLabel.Location = New System.Drawing.Point(22, 154)
        ClaveLabel.Name = "ClaveLabel"
        ClaveLabel.Size = New System.Drawing.Size(37, 13)
        ClaveLabel.TabIndex = 8
        ClaveLabel.Text = "Clave:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Location = New System.Drawing.Point(22, 180)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(41, 13)
        CorreoLabel.TabIndex = 10
        CorreoLabel.Text = "Correo:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(22, 206)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 12
        EstadoLabel.Text = "Estado:"
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Location = New System.Drawing.Point(22, 232)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(46, 13)
        UsuarioLabel.TabIndex = 14
        UsuarioLabel.Text = "Usuario:"
        '
        'pn_container
        '
        Me.pn_container.BackColor = System.Drawing.Color.White
        Me.pn_container.Controls.Add(Me.GroupBox1)
        Me.pn_container.Controls.Add(Me.btn_guardarB)
        Me.pn_container.Controls.Add(Me.btn_nuevoB)
        Me.pn_container.Controls.Add(Me.btn_actualizarB)
        Me.pn_container.Controls.Add(Me.btn_eliminarB)
        Me.pn_container.Controls.Add(Me.btn_modificarB)
        Me.pn_container.Controls.Add(Me.lb_detusuario)
        Me.pn_container.Dock = System.Windows.Forms.DockStyle.Left
        Me.pn_container.Location = New System.Drawing.Point(0, 0)
        Me.pn_container.Name = "pn_container"
        Me.pn_container.Size = New System.Drawing.Size(252, 561)
        Me.pn_container.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(CODBIBLILabel)
        Me.GroupBox1.Controls.Add(Me.CODBIBLITextBox)
        Me.GroupBox1.Controls.Add(NombreApellidosLabel)
        Me.GroupBox1.Controls.Add(Me.NombreApellidosTextBox)
        Me.GroupBox1.Controls.Add(TelefonoLabel)
        Me.GroupBox1.Controls.Add(Me.TelefonoTextBox)
        Me.GroupBox1.Controls.Add(DireccionLabel)
        Me.GroupBox1.Controls.Add(Me.DireccionTextBox)
        Me.GroupBox1.Controls.Add(ClaveLabel)
        Me.GroupBox1.Controls.Add(Me.ClaveTextBox)
        Me.GroupBox1.Controls.Add(CorreoLabel)
        Me.GroupBox1.Controls.Add(Me.CorreoTextBox)
        Me.GroupBox1.Controls.Add(EstadoLabel)
        Me.GroupBox1.Controls.Add(Me.EstadoTextBox)
        Me.GroupBox1.Controls.Add(UsuarioLabel)
        Me.GroupBox1.Controls.Add(Me.UsuarioTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 304)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos:"
        '
        'CODBIBLITextBox
        '
        Me.CODBIBLITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BIBLIOTECARIOBindingSource, "CODBIBLI", True))
        Me.CODBIBLITextBox.Enabled = False
        Me.CODBIBLITextBox.Location = New System.Drawing.Point(120, 47)
        Me.CODBIBLITextBox.Name = "CODBIBLITextBox"
        Me.CODBIBLITextBox.Size = New System.Drawing.Size(100, 20)
        Me.CODBIBLITextBox.TabIndex = 1
        '
        'BIBLIOTECARIOBindingSource
        '
        Me.BIBLIOTECARIOBindingSource.DataMember = "BIBLIOTECARIO"
        Me.BIBLIOTECARIOBindingSource.DataSource = Me.BD_BIBLIOTECA_V2DataSet
        '
        'BD_BIBLIOTECA_V2DataSet
        '
        Me.BD_BIBLIOTECA_V2DataSet.DataSetName = "BD_BIBLIOTECA_V2DataSet"
        Me.BD_BIBLIOTECA_V2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombreApellidosTextBox
        '
        Me.NombreApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BIBLIOTECARIOBindingSource, "NombreApellidos", True))
        Me.NombreApellidosTextBox.Enabled = False
        Me.NombreApellidosTextBox.Location = New System.Drawing.Point(120, 73)
        Me.NombreApellidosTextBox.Name = "NombreApellidosTextBox"
        Me.NombreApellidosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreApellidosTextBox.TabIndex = 3
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BIBLIOTECARIOBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Enabled = False
        Me.TelefonoTextBox.Location = New System.Drawing.Point(120, 99)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 5
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BIBLIOTECARIOBindingSource, "Direccion", True))
        Me.DireccionTextBox.Enabled = False
        Me.DireccionTextBox.Location = New System.Drawing.Point(120, 125)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox.TabIndex = 7
        '
        'ClaveTextBox
        '
        Me.ClaveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BIBLIOTECARIOBindingSource, "Clave", True))
        Me.ClaveTextBox.Enabled = False
        Me.ClaveTextBox.Location = New System.Drawing.Point(120, 151)
        Me.ClaveTextBox.Name = "ClaveTextBox"
        Me.ClaveTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClaveTextBox.TabIndex = 9
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BIBLIOTECARIOBindingSource, "Correo", True))
        Me.CorreoTextBox.Enabled = False
        Me.CorreoTextBox.Location = New System.Drawing.Point(120, 177)
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CorreoTextBox.TabIndex = 11
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BIBLIOTECARIOBindingSource, "Estado", True))
        Me.EstadoTextBox.Enabled = False
        Me.EstadoTextBox.Location = New System.Drawing.Point(120, 203)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EstadoTextBox.TabIndex = 13
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BIBLIOTECARIOBindingSource, "Usuario", True))
        Me.UsuarioTextBox.Enabled = False
        Me.UsuarioTextBox.Location = New System.Drawing.Point(120, 229)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsuarioTextBox.TabIndex = 15
        '
        'lb_detusuario
        '
        Me.lb_detusuario.AutoSize = True
        Me.lb_detusuario.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_detusuario.Location = New System.Drawing.Point(12, 9)
        Me.lb_detusuario.Name = "lb_detusuario"
        Me.lb_detusuario.Size = New System.Drawing.Size(206, 22)
        Me.lb_detusuario.TabIndex = 0
        Me.lb_detusuario.Text = "Detalle de Bibliotecario:"
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
        Me.Panel1.Location = New System.Drawing.Point(287, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(785, 66)
        Me.Panel1.TabIndex = 19
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(307, 23)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'txt_buscat
        '
        Me.txt_buscat.Location = New System.Drawing.Point(434, 23)
        Me.txt_buscat.Name = "txt_buscat"
        Me.txt_buscat.Size = New System.Drawing.Size(288, 20)
        Me.txt_buscat.TabIndex = 14
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
        Me.Label6.Size = New System.Drawing.Size(227, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Listado de Bibliotecario:"
        '
        'BIBLIOTECARIODataGridView
        '
        Me.BIBLIOTECARIODataGridView.AutoGenerateColumns = False
        Me.BIBLIOTECARIODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BIBLIOTECARIODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.BIBLIOTECARIODataGridView.DataSource = Me.BIBLIOTECARIOBindingSource
        Me.BIBLIOTECARIODataGridView.Location = New System.Drawing.Point(258, 108)
        Me.BIBLIOTECARIODataGridView.Name = "BIBLIOTECARIODataGridView"
        Me.BIBLIOTECARIODataGridView.Size = New System.Drawing.Size(821, 220)
        Me.BIBLIOTECARIODataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CODBIBLI"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CODBIBLI"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombreApellidos"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NombreApellidos"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Direccion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Clave"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Clave"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Correo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Correo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Estado"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Usuario"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'BIBLIOTECARIOTableAdapter
        '
        Me.BIBLIOTECARIOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BIBLIOTECARIOTableAdapter = Me.BIBLIOTECARIOTableAdapter
        Me.TableAdapterManager.DETALLETableAdapter = Nothing
        Me.TableAdapterManager.LECTORTableAdapter = Nothing
        Me.TableAdapterManager.MATERIAL_BIBLIOGRAFICOTableAdapter = Nothing
        Me.TableAdapterManager.PRESTACION_Y_DEVOLUCIONTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_M_BIBLIOGRAFICOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'btn_guardarB
        '
        Me.btn_guardarB.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_guardarB.Enabled = False
        Me.btn_guardarB.ForeColor = System.Drawing.Color.White
        Me.btn_guardarB.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_guardarB.IconColor = System.Drawing.Color.White
        Me.btn_guardarB.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_guardarB.IconSize = 25
        Me.btn_guardarB.Location = New System.Drawing.Point(42, 390)
        Me.btn_guardarB.Name = "btn_guardarB"
        Me.btn_guardarB.Size = New System.Drawing.Size(163, 35)
        Me.btn_guardarB.TabIndex = 38
        Me.btn_guardarB.Text = "Guardar"
        Me.btn_guardarB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardarB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_guardarB.UseVisualStyleBackColor = False
        '
        'btn_nuevoB
        '
        Me.btn_nuevoB.BackColor = System.Drawing.Color.Teal
        Me.btn_nuevoB.ForeColor = System.Drawing.Color.White
        Me.btn_nuevoB.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_nuevoB.IconColor = System.Drawing.Color.White
        Me.btn_nuevoB.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_nuevoB.IconSize = 25
        Me.btn_nuevoB.Location = New System.Drawing.Point(41, 352)
        Me.btn_nuevoB.Name = "btn_nuevoB"
        Me.btn_nuevoB.Size = New System.Drawing.Size(163, 35)
        Me.btn_nuevoB.TabIndex = 37
        Me.btn_nuevoB.Text = "Nuevo"
        Me.btn_nuevoB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevoB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_nuevoB.UseVisualStyleBackColor = False
        '
        'btn_actualizarB
        '
        Me.btn_actualizarB.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_actualizarB.Enabled = False
        Me.btn_actualizarB.ForeColor = System.Drawing.Color.White
        Me.btn_actualizarB.IconChar = FontAwesome.Sharp.IconChar.Broom
        Me.btn_actualizarB.IconColor = System.Drawing.Color.White
        Me.btn_actualizarB.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_actualizarB.IconSize = 25
        Me.btn_actualizarB.Location = New System.Drawing.Point(42, 472)
        Me.btn_actualizarB.Name = "btn_actualizarB"
        Me.btn_actualizarB.Size = New System.Drawing.Size(163, 35)
        Me.btn_actualizarB.TabIndex = 36
        Me.btn_actualizarB.Text = "Actualizar"
        Me.btn_actualizarB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_actualizarB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_actualizarB.UseVisualStyleBackColor = False
        '
        'btn_eliminarB
        '
        Me.btn_eliminarB.BackColor = System.Drawing.Color.Red
        Me.btn_eliminarB.ForeColor = System.Drawing.Color.White
        Me.btn_eliminarB.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_eliminarB.IconColor = System.Drawing.Color.White
        Me.btn_eliminarB.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_eliminarB.IconSize = 25
        Me.btn_eliminarB.Location = New System.Drawing.Point(41, 513)
        Me.btn_eliminarB.Name = "btn_eliminarB"
        Me.btn_eliminarB.Size = New System.Drawing.Size(163, 35)
        Me.btn_eliminarB.TabIndex = 35
        Me.btn_eliminarB.Text = "eliminar"
        Me.btn_eliminarB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminarB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_eliminarB.UseVisualStyleBackColor = False
        '
        'btn_modificarB
        '
        Me.btn_modificarB.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_modificarB.ForeColor = System.Drawing.Color.White
        Me.btn_modificarB.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_modificarB.IconColor = System.Drawing.Color.White
        Me.btn_modificarB.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_modificarB.IconSize = 25
        Me.btn_modificarB.Location = New System.Drawing.Point(41, 431)
        Me.btn_modificarB.Name = "btn_modificarB"
        Me.btn_modificarB.Size = New System.Drawing.Size(163, 35)
        Me.btn_modificarB.TabIndex = 34
        Me.btn_modificarB.Text = "Modificar"
        Me.btn_modificarB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_modificarB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_modificarB.UseVisualStyleBackColor = False
        '
        'frm_bibliotecario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1084, 561)
        Me.Controls.Add(Me.BIBLIOTECARIODataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pn_container)
        Me.MaximumSize = New System.Drawing.Size(1100, 600)
        Me.Name = "frm_bibliotecario"
        Me.Text = "frm_bibliotecario"
        Me.pn_container.ResumeLayout(False)
        Me.pn_container.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BIBLIOTECARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_BIBLIOTECA_V2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BIBLIOTECARIODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pn_container As Panel
    Private WithEvents lb_detusuario As Label
    Private WithEvents Panel1 As Panel
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_buscat As TextBox
    Friend WithEvents btn_descargarexcel As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Private WithEvents btn_guardarB As FontAwesome.Sharp.IconButton
    Private WithEvents btn_nuevoB As FontAwesome.Sharp.IconButton
    Private WithEvents btn_actualizarB As FontAwesome.Sharp.IconButton
    Private WithEvents btn_eliminarB As FontAwesome.Sharp.IconButton
    Private WithEvents btn_modificarB As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BD_BIBLIOTECA_V2DataSet As BD_BIBLIOTECA_V2DataSet
    Friend WithEvents BIBLIOTECARIOBindingSource As BindingSource
    Friend WithEvents BIBLIOTECARIOTableAdapter As BD_BIBLIOTECA_V2DataSetTableAdapters.BIBLIOTECARIOTableAdapter
    Friend WithEvents TableAdapterManager As BD_BIBLIOTECA_V2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CODBIBLITextBox As TextBox
    Friend WithEvents NombreApellidosTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents ClaveTextBox As TextBox
    Friend WithEvents CorreoTextBox As TextBox
    Friend WithEvents EstadoTextBox As TextBox
    Friend WithEvents UsuarioTextBox As TextBox
    Friend WithEvents BIBLIOTECARIODataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
