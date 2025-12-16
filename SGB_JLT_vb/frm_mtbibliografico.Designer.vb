<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_mtbibliografico
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TipoMBLabel As System.Windows.Forms.Label
        Dim MatBibLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim EditorialLabel As System.Windows.Forms.Label
        Dim FechAdquisicionLabel As System.Windows.Forms.Label
        Dim FormatoLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim AutorLabel As System.Windows.Forms.Label
        Dim EjemplaresLabel As System.Windows.Forms.Label
        Me.pn_container = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TipoMBTextBox = New System.Windows.Forms.TextBox()
        Me.MATERIAL_BIBLIOGRAFICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_BIBLIOTECA_V2DataSet = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSet()
        Me.MatBibTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.EditorialTextBox = New System.Windows.Forms.TextBox()
        Me.FechAdquisicionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FormatoTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.AutorTextBox = New System.Windows.Forms.TextBox()
        Me.EjemplaresTextBox = New System.Windows.Forms.TextBox()
        Me.btn_guardarMB = New FontAwesome.Sharp.IconButton()
        Me.btn_nuevoMB = New FontAwesome.Sharp.IconButton()
        Me.btn_actualizarMB = New FontAwesome.Sharp.IconButton()
        Me.btn_eliminarMB = New FontAwesome.Sharp.IconButton()
        Me.btn_modificarMB = New FontAwesome.Sharp.IconButton()
        Me.lb_detusuario = New System.Windows.Forms.Label()
        Me.MATERIAL_BIBLIOGRAFICOTableAdapter = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.MATERIAL_BIBLIOGRAFICOTableAdapter()
        Me.TableAdapterManager = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.TableAdapterManager()
        Me.MATERIAL_BIBLIOGRAFICODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        TipoMBLabel = New System.Windows.Forms.Label()
        MatBibLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        EditorialLabel = New System.Windows.Forms.Label()
        FechAdquisicionLabel = New System.Windows.Forms.Label()
        FormatoLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        AutorLabel = New System.Windows.Forms.Label()
        EjemplaresLabel = New System.Windows.Forms.Label()
        Me.pn_container.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MATERIAL_BIBLIOGRAFICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_BIBLIOTECA_V2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MATERIAL_BIBLIOGRAFICODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TipoMBLabel
        '
        TipoMBLabel.AutoSize = True
        TipoMBLabel.Location = New System.Drawing.Point(10, 65)
        TipoMBLabel.Name = "TipoMBLabel"
        TipoMBLabel.Size = New System.Drawing.Size(50, 13)
        TipoMBLabel.TabIndex = 0
        TipoMBLabel.Text = "Tipo MB:"
        '
        'MatBibLabel
        '
        MatBibLabel.AutoSize = True
        MatBibLabel.Location = New System.Drawing.Point(14, 42)
        MatBibLabel.Name = "MatBibLabel"
        MatBibLabel.Size = New System.Drawing.Size(46, 13)
        MatBibLabel.TabIndex = 2
        MatBibLabel.Text = "Mat Bib:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(10, 91)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Nombre:"
        '
        'EditorialLabel
        '
        EditorialLabel.AutoSize = True
        EditorialLabel.Location = New System.Drawing.Point(10, 117)
        EditorialLabel.Name = "EditorialLabel"
        EditorialLabel.Size = New System.Drawing.Size(47, 13)
        EditorialLabel.TabIndex = 6
        EditorialLabel.Text = "Editorial:"
        '
        'FechAdquisicionLabel
        '
        FechAdquisicionLabel.AutoSize = True
        FechAdquisicionLabel.Location = New System.Drawing.Point(10, 144)
        FechAdquisicionLabel.Name = "FechAdquisicionLabel"
        FechAdquisicionLabel.Size = New System.Drawing.Size(91, 13)
        FechAdquisicionLabel.TabIndex = 8
        FechAdquisicionLabel.Text = "Fech Adquisicion:"
        '
        'FormatoLabel
        '
        FormatoLabel.AutoSize = True
        FormatoLabel.Location = New System.Drawing.Point(10, 169)
        FormatoLabel.Name = "FormatoLabel"
        FormatoLabel.Size = New System.Drawing.Size(48, 13)
        FormatoLabel.TabIndex = 10
        FormatoLabel.Text = "Formato:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(10, 195)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 12
        EstadoLabel.Text = "Estado:"
        '
        'AutorLabel
        '
        AutorLabel.AutoSize = True
        AutorLabel.Location = New System.Drawing.Point(10, 221)
        AutorLabel.Name = "AutorLabel"
        AutorLabel.Size = New System.Drawing.Size(35, 13)
        AutorLabel.TabIndex = 14
        AutorLabel.Text = "Autor:"
        '
        'EjemplaresLabel
        '
        EjemplaresLabel.AutoSize = True
        EjemplaresLabel.Location = New System.Drawing.Point(10, 247)
        EjemplaresLabel.Name = "EjemplaresLabel"
        EjemplaresLabel.Size = New System.Drawing.Size(61, 13)
        EjemplaresLabel.TabIndex = 16
        EjemplaresLabel.Text = "Ejemplares:"
        '
        'pn_container
        '
        Me.pn_container.BackColor = System.Drawing.Color.White
        Me.pn_container.Controls.Add(Me.GroupBox1)
        Me.pn_container.Controls.Add(Me.btn_guardarMB)
        Me.pn_container.Controls.Add(Me.btn_nuevoMB)
        Me.pn_container.Controls.Add(Me.btn_actualizarMB)
        Me.pn_container.Controls.Add(Me.btn_eliminarMB)
        Me.pn_container.Controls.Add(Me.btn_modificarMB)
        Me.pn_container.Controls.Add(Me.lb_detusuario)
        Me.pn_container.Dock = System.Windows.Forms.DockStyle.Left
        Me.pn_container.Location = New System.Drawing.Point(0, 0)
        Me.pn_container.Name = "pn_container"
        Me.pn_container.Size = New System.Drawing.Size(273, 607)
        Me.pn_container.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(TipoMBLabel)
        Me.GroupBox1.Controls.Add(Me.TipoMBTextBox)
        Me.GroupBox1.Controls.Add(MatBibLabel)
        Me.GroupBox1.Controls.Add(Me.MatBibTextBox)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(EditorialLabel)
        Me.GroupBox1.Controls.Add(Me.EditorialTextBox)
        Me.GroupBox1.Controls.Add(FechAdquisicionLabel)
        Me.GroupBox1.Controls.Add(Me.FechAdquisicionDateTimePicker)
        Me.GroupBox1.Controls.Add(FormatoLabel)
        Me.GroupBox1.Controls.Add(Me.FormatoTextBox)
        Me.GroupBox1.Controls.Add(EstadoLabel)
        Me.GroupBox1.Controls.Add(Me.EstadoTextBox)
        Me.GroupBox1.Controls.Add(AutorLabel)
        Me.GroupBox1.Controls.Add(Me.AutorTextBox)
        Me.GroupBox1.Controls.Add(EjemplaresLabel)
        Me.GroupBox1.Controls.Add(Me.EjemplaresTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 284)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos:"
        '
        'TipoMBTextBox
        '
        Me.TipoMBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MATERIAL_BIBLIOGRAFICOBindingSource, "TipoMB", True))
        Me.TipoMBTextBox.Enabled = False
        Me.TipoMBTextBox.Location = New System.Drawing.Point(107, 62)
        Me.TipoMBTextBox.Name = "TipoMBTextBox"
        Me.TipoMBTextBox.Size = New System.Drawing.Size(108, 20)
        Me.TipoMBTextBox.TabIndex = 1
        '
        'MATERIAL_BIBLIOGRAFICOBindingSource
        '
        Me.MATERIAL_BIBLIOGRAFICOBindingSource.DataMember = "MATERIAL_BIBLIOGRAFICO"
        Me.MATERIAL_BIBLIOGRAFICOBindingSource.DataSource = Me.BD_BIBLIOTECA_V2DataSet
        '
        'BD_BIBLIOTECA_V2DataSet
        '
        Me.BD_BIBLIOTECA_V2DataSet.DataSetName = "BD_BIBLIOTECA_V2DataSet"
        Me.BD_BIBLIOTECA_V2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MatBibTextBox
        '
        Me.MatBibTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MATERIAL_BIBLIOGRAFICOBindingSource, "MatBib", True))
        Me.MatBibTextBox.Enabled = False
        Me.MatBibTextBox.Location = New System.Drawing.Point(107, 36)
        Me.MatBibTextBox.Name = "MatBibTextBox"
        Me.MatBibTextBox.Size = New System.Drawing.Size(108, 20)
        Me.MatBibTextBox.TabIndex = 3
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MATERIAL_BIBLIOGRAFICOBindingSource, "Nombre", True))
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(107, 88)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(108, 20)
        Me.NombreTextBox.TabIndex = 5
        '
        'EditorialTextBox
        '
        Me.EditorialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MATERIAL_BIBLIOGRAFICOBindingSource, "Editorial", True))
        Me.EditorialTextBox.Enabled = False
        Me.EditorialTextBox.Location = New System.Drawing.Point(107, 114)
        Me.EditorialTextBox.Name = "EditorialTextBox"
        Me.EditorialTextBox.Size = New System.Drawing.Size(108, 20)
        Me.EditorialTextBox.TabIndex = 7
        '
        'FechAdquisicionDateTimePicker
        '
        Me.FechAdquisicionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MATERIAL_BIBLIOGRAFICOBindingSource, "FechAdquisicion", True))
        Me.FechAdquisicionDateTimePicker.Enabled = False
        Me.FechAdquisicionDateTimePicker.Location = New System.Drawing.Point(107, 140)
        Me.FechAdquisicionDateTimePicker.Name = "FechAdquisicionDateTimePicker"
        Me.FechAdquisicionDateTimePicker.Size = New System.Drawing.Size(108, 20)
        Me.FechAdquisicionDateTimePicker.TabIndex = 9
        '
        'FormatoTextBox
        '
        Me.FormatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MATERIAL_BIBLIOGRAFICOBindingSource, "Formato", True))
        Me.FormatoTextBox.Enabled = False
        Me.FormatoTextBox.Location = New System.Drawing.Point(107, 166)
        Me.FormatoTextBox.Name = "FormatoTextBox"
        Me.FormatoTextBox.Size = New System.Drawing.Size(108, 20)
        Me.FormatoTextBox.TabIndex = 11
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MATERIAL_BIBLIOGRAFICOBindingSource, "Estado", True))
        Me.EstadoTextBox.Enabled = False
        Me.EstadoTextBox.Location = New System.Drawing.Point(107, 192)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(108, 20)
        Me.EstadoTextBox.TabIndex = 13
        '
        'AutorTextBox
        '
        Me.AutorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MATERIAL_BIBLIOGRAFICOBindingSource, "Autor", True))
        Me.AutorTextBox.Enabled = False
        Me.AutorTextBox.Location = New System.Drawing.Point(107, 218)
        Me.AutorTextBox.Name = "AutorTextBox"
        Me.AutorTextBox.Size = New System.Drawing.Size(108, 20)
        Me.AutorTextBox.TabIndex = 15
        '
        'EjemplaresTextBox
        '
        Me.EjemplaresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MATERIAL_BIBLIOGRAFICOBindingSource, "Ejemplares", True))
        Me.EjemplaresTextBox.Enabled = False
        Me.EjemplaresTextBox.Location = New System.Drawing.Point(107, 244)
        Me.EjemplaresTextBox.Name = "EjemplaresTextBox"
        Me.EjemplaresTextBox.Size = New System.Drawing.Size(108, 20)
        Me.EjemplaresTextBox.TabIndex = 17
        '
        'btn_guardarMB
        '
        Me.btn_guardarMB.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_guardarMB.Enabled = False
        Me.btn_guardarMB.ForeColor = System.Drawing.Color.White
        Me.btn_guardarMB.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_guardarMB.IconColor = System.Drawing.Color.White
        Me.btn_guardarMB.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_guardarMB.IconSize = 25
        Me.btn_guardarMB.Location = New System.Drawing.Point(31, 392)
        Me.btn_guardarMB.Name = "btn_guardarMB"
        Me.btn_guardarMB.Size = New System.Drawing.Size(163, 35)
        Me.btn_guardarMB.TabIndex = 33
        Me.btn_guardarMB.Text = "Guardar"
        Me.btn_guardarMB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardarMB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_guardarMB.UseVisualStyleBackColor = False
        '
        'btn_nuevoMB
        '
        Me.btn_nuevoMB.BackColor = System.Drawing.Color.Indigo
        Me.btn_nuevoMB.ForeColor = System.Drawing.Color.White
        Me.btn_nuevoMB.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_nuevoMB.IconColor = System.Drawing.Color.White
        Me.btn_nuevoMB.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_nuevoMB.IconSize = 25
        Me.btn_nuevoMB.Location = New System.Drawing.Point(30, 354)
        Me.btn_nuevoMB.Name = "btn_nuevoMB"
        Me.btn_nuevoMB.Size = New System.Drawing.Size(163, 35)
        Me.btn_nuevoMB.TabIndex = 32
        Me.btn_nuevoMB.Text = "Nuevo"
        Me.btn_nuevoMB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevoMB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_nuevoMB.UseVisualStyleBackColor = False
        '
        'btn_actualizarMB
        '
        Me.btn_actualizarMB.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_actualizarMB.Enabled = False
        Me.btn_actualizarMB.ForeColor = System.Drawing.Color.White
        Me.btn_actualizarMB.IconChar = FontAwesome.Sharp.IconChar.Broom
        Me.btn_actualizarMB.IconColor = System.Drawing.Color.White
        Me.btn_actualizarMB.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_actualizarMB.IconSize = 25
        Me.btn_actualizarMB.Location = New System.Drawing.Point(31, 474)
        Me.btn_actualizarMB.Name = "btn_actualizarMB"
        Me.btn_actualizarMB.Size = New System.Drawing.Size(163, 35)
        Me.btn_actualizarMB.TabIndex = 31
        Me.btn_actualizarMB.Text = "Actualizar"
        Me.btn_actualizarMB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_actualizarMB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_actualizarMB.UseVisualStyleBackColor = False
        '
        'btn_eliminarMB
        '
        Me.btn_eliminarMB.BackColor = System.Drawing.Color.Red
        Me.btn_eliminarMB.ForeColor = System.Drawing.Color.White
        Me.btn_eliminarMB.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_eliminarMB.IconColor = System.Drawing.Color.White
        Me.btn_eliminarMB.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_eliminarMB.IconSize = 25
        Me.btn_eliminarMB.Location = New System.Drawing.Point(30, 515)
        Me.btn_eliminarMB.Name = "btn_eliminarMB"
        Me.btn_eliminarMB.Size = New System.Drawing.Size(163, 35)
        Me.btn_eliminarMB.TabIndex = 30
        Me.btn_eliminarMB.Text = "eliminar"
        Me.btn_eliminarMB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminarMB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_eliminarMB.UseVisualStyleBackColor = False
        '
        'btn_modificarMB
        '
        Me.btn_modificarMB.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_modificarMB.ForeColor = System.Drawing.Color.White
        Me.btn_modificarMB.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_modificarMB.IconColor = System.Drawing.Color.White
        Me.btn_modificarMB.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_modificarMB.IconSize = 25
        Me.btn_modificarMB.Location = New System.Drawing.Point(30, 433)
        Me.btn_modificarMB.Name = "btn_modificarMB"
        Me.btn_modificarMB.Size = New System.Drawing.Size(163, 35)
        Me.btn_modificarMB.TabIndex = 29
        Me.btn_modificarMB.Text = "Modificar"
        Me.btn_modificarMB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_modificarMB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_modificarMB.UseVisualStyleBackColor = False
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
        'MATERIAL_BIBLIOGRAFICOTableAdapter
        '
        Me.MATERIAL_BIBLIOGRAFICOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BIBLIOTECARIOTableAdapter = Nothing
        Me.TableAdapterManager.DETALLETableAdapter = Nothing
        Me.TableAdapterManager.LECTORTableAdapter = Nothing
        Me.TableAdapterManager.MATERIAL_BIBLIOGRAFICOTableAdapter = Me.MATERIAL_BIBLIOGRAFICOTableAdapter
        Me.TableAdapterManager.PRESTACION_Y_DEVOLUCIONTableAdapter = Nothing
        Me.TableAdapterManager.TEMPORALTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_M_BIBLIOGRAFICOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MATERIAL_BIBLIOGRAFICODataGridView
        '
        Me.MATERIAL_BIBLIOGRAFICODataGridView.AutoGenerateColumns = False
        Me.MATERIAL_BIBLIOGRAFICODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MATERIAL_BIBLIOGRAFICODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.MATERIAL_BIBLIOGRAFICODataGridView.DataSource = Me.MATERIAL_BIBLIOGRAFICOBindingSource
        Me.MATERIAL_BIBLIOGRAFICODataGridView.Location = New System.Drawing.Point(279, 137)
        Me.MATERIAL_BIBLIOGRAFICODataGridView.Name = "MATERIAL_BIBLIOGRAFICODataGridView"
        Me.MATERIAL_BIBLIOGRAFICODataGridView.Size = New System.Drawing.Size(934, 413)
        Me.MATERIAL_BIBLIOGRAFICODataGridView.TabIndex = 21
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MatBib"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MatBib"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TipoMB"
        Me.DataGridViewTextBoxColumn1.HeaderText = "TipoMB"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Editorial"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Editorial"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FechAdquisicion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "FechAdquisicion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Formato"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Formato"
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
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Autor"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Autor"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Ejemplares"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Ejemplares"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'frm_mtbibliografico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1234, 607)
        Me.Controls.Add(Me.MATERIAL_BIBLIOGRAFICODataGridView)
        Me.Controls.Add(Me.pn_container)
        Me.MaximumSize = New System.Drawing.Size(1250, 646)
        Me.Name = "frm_mtbibliografico"
        Me.Text = "frm_mtbibliografico"
        Me.pn_container.ResumeLayout(False)
        Me.pn_container.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MATERIAL_BIBLIOGRAFICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_BIBLIOTECA_V2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MATERIAL_BIBLIOGRAFICODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pn_container As Panel
    Private WithEvents lb_detusuario As Label
    Private WithEvents btn_guardarMB As FontAwesome.Sharp.IconButton
    Private WithEvents btn_nuevoMB As FontAwesome.Sharp.IconButton
    Private WithEvents btn_actualizarMB As FontAwesome.Sharp.IconButton
    Private WithEvents btn_eliminarMB As FontAwesome.Sharp.IconButton
    Private WithEvents btn_modificarMB As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BD_BIBLIOTECA_V2DataSet As BD_BIBLIOTECA_V2DataSet
    Friend WithEvents MATERIAL_BIBLIOGRAFICOBindingSource As BindingSource
    Friend WithEvents MATERIAL_BIBLIOGRAFICOTableAdapter As BD_BIBLIOTECA_V2DataSetTableAdapters.MATERIAL_BIBLIOGRAFICOTableAdapter
    Friend WithEvents TableAdapterManager As BD_BIBLIOTECA_V2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TipoMBTextBox As TextBox
    Friend WithEvents MatBibTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents EditorialTextBox As TextBox
    Friend WithEvents FechAdquisicionDateTimePicker As DateTimePicker
    Friend WithEvents FormatoTextBox As TextBox
    Friend WithEvents EstadoTextBox As TextBox
    Friend WithEvents AutorTextBox As TextBox
    Friend WithEvents EjemplaresTextBox As TextBox
    Friend WithEvents MATERIAL_BIBLIOGRAFICODataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
End Class
