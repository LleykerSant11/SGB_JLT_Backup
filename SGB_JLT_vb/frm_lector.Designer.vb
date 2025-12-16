<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_lector
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
        Dim CodLecLabel As System.Windows.Forms.Label
        Dim TipoLectorLabel As System.Windows.Forms.Label
        Dim NombreApellidosLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Me.pn_container = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CodLecTextBox = New System.Windows.Forms.TextBox()
        Me.LECTORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_BIBLIOTECA_V2DataSet = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSet()
        Me.TipoLectorComboBox = New System.Windows.Forms.ComboBox()
        Me.NombreApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        Me.btn_guardarL = New FontAwesome.Sharp.IconButton()
        Me.btn_nuevoL = New FontAwesome.Sharp.IconButton()
        Me.btn_actualizarL = New FontAwesome.Sharp.IconButton()
        Me.btn_eliminarL = New FontAwesome.Sharp.IconButton()
        Me.btn_modificarL = New FontAwesome.Sharp.IconButton()
        Me.lb_detusuario = New System.Windows.Forms.Label()
        Me.LECTORDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LECTORTableAdapter = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.LECTORTableAdapter()
        Me.TableAdapterManager = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.TableAdapterManager()
        CodLecLabel = New System.Windows.Forms.Label()
        TipoLectorLabel = New System.Windows.Forms.Label()
        NombreApellidosLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        Me.pn_container.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LECTORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_BIBLIOTECA_V2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LECTORDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodLecLabel
        '
        CodLecLabel.AutoSize = True
        CodLecLabel.Location = New System.Drawing.Point(21, 57)
        CodLecLabel.Name = "CodLecLabel"
        CodLecLabel.Size = New System.Drawing.Size(43, 13)
        CodLecLabel.TabIndex = 0
        CodLecLabel.Text = "Codigo:"
        '
        'TipoLectorLabel
        '
        TipoLectorLabel.AutoSize = True
        TipoLectorLabel.Location = New System.Drawing.Point(21, 83)
        TipoLectorLabel.Name = "TipoLectorLabel"
        TipoLectorLabel.Size = New System.Drawing.Size(64, 13)
        TipoLectorLabel.TabIndex = 2
        TipoLectorLabel.Text = "Tipo Lector:"
        '
        'NombreApellidosLabel
        '
        NombreApellidosLabel.AutoSize = True
        NombreApellidosLabel.Location = New System.Drawing.Point(21, 110)
        NombreApellidosLabel.Name = "NombreApellidosLabel"
        NombreApellidosLabel.Size = New System.Drawing.Size(92, 13)
        NombreApellidosLabel.TabIndex = 4
        NombreApellidosLabel.Text = "Nombre Apellidos:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(21, 136)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 6
        TelefonoLabel.Text = "Telefono:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(21, 162)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 8
        DireccionLabel.Text = "Direccion:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(21, 188)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 10
        EstadoLabel.Text = "Estado:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Location = New System.Drawing.Point(21, 214)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(41, 13)
        CorreoLabel.TabIndex = 12
        CorreoLabel.Text = "Correo:"
        '
        'pn_container
        '
        Me.pn_container.BackColor = System.Drawing.Color.White
        Me.pn_container.Controls.Add(Me.GroupBox1)
        Me.pn_container.Controls.Add(Me.btn_guardarL)
        Me.pn_container.Controls.Add(Me.btn_nuevoL)
        Me.pn_container.Controls.Add(Me.btn_actualizarL)
        Me.pn_container.Controls.Add(Me.btn_eliminarL)
        Me.pn_container.Controls.Add(Me.btn_modificarL)
        Me.pn_container.Controls.Add(Me.lb_detusuario)
        Me.pn_container.Dock = System.Windows.Forms.DockStyle.Left
        Me.pn_container.Enabled = False
        Me.pn_container.Location = New System.Drawing.Point(0, 0)
        Me.pn_container.Name = "pn_container"
        Me.pn_container.Size = New System.Drawing.Size(290, 607)
        Me.pn_container.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(CodLecLabel)
        Me.GroupBox1.Controls.Add(Me.CodLecTextBox)
        Me.GroupBox1.Controls.Add(TipoLectorLabel)
        Me.GroupBox1.Controls.Add(Me.TipoLectorComboBox)
        Me.GroupBox1.Controls.Add(NombreApellidosLabel)
        Me.GroupBox1.Controls.Add(Me.NombreApellidosTextBox)
        Me.GroupBox1.Controls.Add(TelefonoLabel)
        Me.GroupBox1.Controls.Add(Me.TelefonoTextBox)
        Me.GroupBox1.Controls.Add(DireccionLabel)
        Me.GroupBox1.Controls.Add(Me.DireccionTextBox)
        Me.GroupBox1.Controls.Add(EstadoLabel)
        Me.GroupBox1.Controls.Add(Me.EstadoTextBox)
        Me.GroupBox1.Controls.Add(CorreoLabel)
        Me.GroupBox1.Controls.Add(Me.CorreoTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 280)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos:"
        '
        'CodLecTextBox
        '
        Me.CodLecTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LECTORBindingSource, "CodLec", True))
        Me.CodLecTextBox.Enabled = False
        Me.CodLecTextBox.Location = New System.Drawing.Point(119, 54)
        Me.CodLecTextBox.Name = "CodLecTextBox"
        Me.CodLecTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CodLecTextBox.TabIndex = 1
        '
        'LECTORBindingSource
        '
        Me.LECTORBindingSource.DataMember = "LECTOR"
        Me.LECTORBindingSource.DataSource = Me.BD_BIBLIOTECA_V2DataSet
        '
        'BD_BIBLIOTECA_V2DataSet
        '
        Me.BD_BIBLIOTECA_V2DataSet.DataSetName = "BD_BIBLIOTECA_V2DataSet"
        Me.BD_BIBLIOTECA_V2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TipoLectorComboBox
        '
        Me.TipoLectorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LECTORBindingSource, "TipoLector", True))
        Me.TipoLectorComboBox.Enabled = False
        Me.TipoLectorComboBox.FormattingEnabled = True
        Me.TipoLectorComboBox.Items.AddRange(New Object() {"Estudiante", "Profesor", "Invitado"})
        Me.TipoLectorComboBox.Location = New System.Drawing.Point(119, 80)
        Me.TipoLectorComboBox.Name = "TipoLectorComboBox"
        Me.TipoLectorComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TipoLectorComboBox.TabIndex = 3
        '
        'NombreApellidosTextBox
        '
        Me.NombreApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LECTORBindingSource, "NombreApellidos", True))
        Me.NombreApellidosTextBox.Enabled = False
        Me.NombreApellidosTextBox.Location = New System.Drawing.Point(119, 107)
        Me.NombreApellidosTextBox.Name = "NombreApellidosTextBox"
        Me.NombreApellidosTextBox.Size = New System.Drawing.Size(121, 20)
        Me.NombreApellidosTextBox.TabIndex = 5
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LECTORBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Enabled = False
        Me.TelefonoTextBox.Location = New System.Drawing.Point(119, 133)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(121, 20)
        Me.TelefonoTextBox.TabIndex = 7
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LECTORBindingSource, "Direccion", True))
        Me.DireccionTextBox.Enabled = False
        Me.DireccionTextBox.Location = New System.Drawing.Point(119, 159)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(121, 20)
        Me.DireccionTextBox.TabIndex = 9
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LECTORBindingSource, "Estado", True))
        Me.EstadoTextBox.Enabled = False
        Me.EstadoTextBox.Location = New System.Drawing.Point(119, 185)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(121, 20)
        Me.EstadoTextBox.TabIndex = 11
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LECTORBindingSource, "Correo", True))
        Me.CorreoTextBox.Enabled = False
        Me.CorreoTextBox.Location = New System.Drawing.Point(119, 211)
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CorreoTextBox.TabIndex = 13
        '
        'btn_guardarL
        '
        Me.btn_guardarL.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_guardarL.ForeColor = System.Drawing.Color.White
        Me.btn_guardarL.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_guardarL.IconColor = System.Drawing.Color.White
        Me.btn_guardarL.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_guardarL.IconSize = 25
        Me.btn_guardarL.Location = New System.Drawing.Point(23, 373)
        Me.btn_guardarL.Name = "btn_guardarL"
        Me.btn_guardarL.Size = New System.Drawing.Size(163, 35)
        Me.btn_guardarL.TabIndex = 38
        Me.btn_guardarL.Text = "Guardar"
        Me.btn_guardarL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardarL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_guardarL.UseVisualStyleBackColor = False
        '
        'btn_nuevoL
        '
        Me.btn_nuevoL.BackColor = System.Drawing.Color.Indigo
        Me.btn_nuevoL.ForeColor = System.Drawing.Color.White
        Me.btn_nuevoL.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_nuevoL.IconColor = System.Drawing.Color.White
        Me.btn_nuevoL.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_nuevoL.IconSize = 25
        Me.btn_nuevoL.Location = New System.Drawing.Point(22, 335)
        Me.btn_nuevoL.Name = "btn_nuevoL"
        Me.btn_nuevoL.Size = New System.Drawing.Size(163, 35)
        Me.btn_nuevoL.TabIndex = 37
        Me.btn_nuevoL.Text = "Nuevo"
        Me.btn_nuevoL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevoL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_nuevoL.UseVisualStyleBackColor = False
        '
        'btn_actualizarL
        '
        Me.btn_actualizarL.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_actualizarL.ForeColor = System.Drawing.Color.White
        Me.btn_actualizarL.IconChar = FontAwesome.Sharp.IconChar.Broom
        Me.btn_actualizarL.IconColor = System.Drawing.Color.White
        Me.btn_actualizarL.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_actualizarL.IconSize = 25
        Me.btn_actualizarL.Location = New System.Drawing.Point(23, 455)
        Me.btn_actualizarL.Name = "btn_actualizarL"
        Me.btn_actualizarL.Size = New System.Drawing.Size(163, 35)
        Me.btn_actualizarL.TabIndex = 36
        Me.btn_actualizarL.Text = "Actualizar"
        Me.btn_actualizarL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_actualizarL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_actualizarL.UseVisualStyleBackColor = False
        '
        'btn_eliminarL
        '
        Me.btn_eliminarL.BackColor = System.Drawing.Color.Red
        Me.btn_eliminarL.ForeColor = System.Drawing.Color.White
        Me.btn_eliminarL.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_eliminarL.IconColor = System.Drawing.Color.White
        Me.btn_eliminarL.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_eliminarL.IconSize = 25
        Me.btn_eliminarL.Location = New System.Drawing.Point(22, 496)
        Me.btn_eliminarL.Name = "btn_eliminarL"
        Me.btn_eliminarL.Size = New System.Drawing.Size(163, 35)
        Me.btn_eliminarL.TabIndex = 35
        Me.btn_eliminarL.Text = "eliminar"
        Me.btn_eliminarL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminarL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_eliminarL.UseVisualStyleBackColor = False
        '
        'btn_modificarL
        '
        Me.btn_modificarL.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_modificarL.ForeColor = System.Drawing.Color.White
        Me.btn_modificarL.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_modificarL.IconColor = System.Drawing.Color.White
        Me.btn_modificarL.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_modificarL.IconSize = 25
        Me.btn_modificarL.Location = New System.Drawing.Point(22, 414)
        Me.btn_modificarL.Name = "btn_modificarL"
        Me.btn_modificarL.Size = New System.Drawing.Size(163, 35)
        Me.btn_modificarL.TabIndex = 34
        Me.btn_modificarL.Text = "Modificar"
        Me.btn_modificarL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_modificarL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_modificarL.UseVisualStyleBackColor = False
        '
        'lb_detusuario
        '
        Me.lb_detusuario.AutoSize = True
        Me.lb_detusuario.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_detusuario.Location = New System.Drawing.Point(18, 9)
        Me.lb_detusuario.Name = "lb_detusuario"
        Me.lb_detusuario.Size = New System.Drawing.Size(153, 22)
        Me.lb_detusuario.TabIndex = 0
        Me.lb_detusuario.Text = "Detalle de Lector:"
        '
        'LECTORDataGridView
        '
        Me.LECTORDataGridView.AutoGenerateColumns = False
        Me.LECTORDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LECTORDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.LECTORDataGridView.DataSource = Me.LECTORBindingSource
        Me.LECTORDataGridView.Location = New System.Drawing.Point(374, 170)
        Me.LECTORDataGridView.Name = "LECTORDataGridView"
        Me.LECTORDataGridView.Size = New System.Drawing.Size(737, 379)
        Me.LECTORDataGridView.TabIndex = 18
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CodLec"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CodLec"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TipoLector"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TipoLector"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NombreApellidos"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NombreApellidos"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Direccion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Estado"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Correo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Correo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'LECTORTableAdapter
        '
        Me.LECTORTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BIBLIOTECARIOTableAdapter = Nothing
        Me.TableAdapterManager.DETALLETableAdapter = Nothing
        Me.TableAdapterManager.LECTORTableAdapter = Me.LECTORTableAdapter
        Me.TableAdapterManager.MATERIAL_BIBLIOGRAFICOTableAdapter = Nothing
        Me.TableAdapterManager.PRESTACION_Y_DEVOLUCIONTableAdapter = Nothing
        Me.TableAdapterManager.TEMPORALTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_M_BIBLIOGRAFICOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frm_lector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1234, 607)
        Me.Controls.Add(Me.LECTORDataGridView)
        Me.Controls.Add(Me.pn_container)
        Me.MaximumSize = New System.Drawing.Size(1250, 646)
        Me.Name = "frm_lector"
        Me.Text = "frm_lector"
        Me.pn_container.ResumeLayout(False)
        Me.pn_container.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LECTORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_BIBLIOTECA_V2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LECTORDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pn_container As Panel
    Private WithEvents lb_detusuario As Label
    Private WithEvents btn_guardarL As FontAwesome.Sharp.IconButton
    Private WithEvents btn_nuevoL As FontAwesome.Sharp.IconButton
    Private WithEvents btn_actualizarL As FontAwesome.Sharp.IconButton
    Private WithEvents btn_eliminarL As FontAwesome.Sharp.IconButton
    Private WithEvents btn_modificarL As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BD_BIBLIOTECA_V2DataSet As BD_BIBLIOTECA_V2DataSet
    Friend WithEvents LECTORBindingSource As BindingSource
    Friend WithEvents LECTORTableAdapter As BD_BIBLIOTECA_V2DataSetTableAdapters.LECTORTableAdapter
    Friend WithEvents TableAdapterManager As BD_BIBLIOTECA_V2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CodLecTextBox As TextBox
    Friend WithEvents TipoLectorComboBox As ComboBox
    Friend WithEvents NombreApellidosTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents EstadoTextBox As TextBox
    Friend WithEvents CorreoTextBox As TextBox
    Friend WithEvents LECTORDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
