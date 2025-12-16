<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_tipomb
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
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim SiglasLabel As System.Windows.Forms.Label
        Me.pn_container = New System.Windows.Forms.Panel()
        Me.btn_guardarTMB = New FontAwesome.Sharp.IconButton()
        Me.btn_nuevoTMB = New FontAwesome.Sharp.IconButton()
        Me.btn_actualizarTMB = New FontAwesome.Sharp.IconButton()
        Me.btn_eliminarTMB = New FontAwesome.Sharp.IconButton()
        Me.btn_modificarTMB = New FontAwesome.Sharp.IconButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TipoMBTextBox = New System.Windows.Forms.TextBox()
        Me.TIPO_M_BIBLIOGRAFICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_BIBLIOTECA_V2DataSet = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSet()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.SiglasTextBox = New System.Windows.Forms.TextBox()
        Me.lb_detusuario = New System.Windows.Forms.Label()
        Me.TIPO_M_BIBLIOGRAFICOTableAdapter = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.TIPO_M_BIBLIOGRAFICOTableAdapter()
        Me.TableAdapterManager = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.TableAdapterManager()
        Me.TIPO_M_BIBLIOGRAFICODataGridView = New System.Windows.Forms.DataGridView()
        Me.TipoMB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        TipoMBLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        SiglasLabel = New System.Windows.Forms.Label()
        Me.pn_container.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TIPO_M_BIBLIOGRAFICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_BIBLIOTECA_V2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPO_M_BIBLIOGRAFICODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TipoMBLabel
        '
        TipoMBLabel.AutoSize = True
        TipoMBLabel.Location = New System.Drawing.Point(18, 55)
        TipoMBLabel.Name = "TipoMBLabel"
        TipoMBLabel.Size = New System.Drawing.Size(50, 13)
        TipoMBLabel.TabIndex = 0
        TipoMBLabel.Text = "Tipo MB:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(18, 81)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 2
        DescripcionLabel.Text = "Descripcion:"
        '
        'SiglasLabel
        '
        SiglasLabel.AutoSize = True
        SiglasLabel.Location = New System.Drawing.Point(18, 107)
        SiglasLabel.Name = "SiglasLabel"
        SiglasLabel.Size = New System.Drawing.Size(38, 13)
        SiglasLabel.TabIndex = 4
        SiglasLabel.Text = "Siglas:"
        '
        'pn_container
        '
        Me.pn_container.BackColor = System.Drawing.Color.White
        Me.pn_container.Controls.Add(Me.btn_guardarTMB)
        Me.pn_container.Controls.Add(Me.btn_nuevoTMB)
        Me.pn_container.Controls.Add(Me.btn_actualizarTMB)
        Me.pn_container.Controls.Add(Me.btn_eliminarTMB)
        Me.pn_container.Controls.Add(Me.btn_modificarTMB)
        Me.pn_container.Controls.Add(Me.GroupBox1)
        Me.pn_container.Controls.Add(Me.lb_detusuario)
        Me.pn_container.Dock = System.Windows.Forms.DockStyle.Left
        Me.pn_container.Location = New System.Drawing.Point(0, 0)
        Me.pn_container.Name = "pn_container"
        Me.pn_container.Size = New System.Drawing.Size(230, 607)
        Me.pn_container.TabIndex = 8
        '
        'btn_guardarTMB
        '
        Me.btn_guardarTMB.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_guardarTMB.Enabled = False
        Me.btn_guardarTMB.ForeColor = System.Drawing.Color.White
        Me.btn_guardarTMB.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_guardarTMB.IconColor = System.Drawing.Color.White
        Me.btn_guardarTMB.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_guardarTMB.IconSize = 25
        Me.btn_guardarTMB.Location = New System.Drawing.Point(32, 301)
        Me.btn_guardarTMB.Name = "btn_guardarTMB"
        Me.btn_guardarTMB.Size = New System.Drawing.Size(163, 35)
        Me.btn_guardarTMB.TabIndex = 45
        Me.btn_guardarTMB.Text = "Guardar"
        Me.btn_guardarTMB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardarTMB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_guardarTMB.UseVisualStyleBackColor = False
        '
        'btn_nuevoTMB
        '
        Me.btn_nuevoTMB.BackColor = System.Drawing.Color.Indigo
        Me.btn_nuevoTMB.ForeColor = System.Drawing.Color.White
        Me.btn_nuevoTMB.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_nuevoTMB.IconColor = System.Drawing.Color.White
        Me.btn_nuevoTMB.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_nuevoTMB.IconSize = 25
        Me.btn_nuevoTMB.Location = New System.Drawing.Point(31, 263)
        Me.btn_nuevoTMB.Name = "btn_nuevoTMB"
        Me.btn_nuevoTMB.Size = New System.Drawing.Size(163, 35)
        Me.btn_nuevoTMB.TabIndex = 44
        Me.btn_nuevoTMB.Text = "Nuevo"
        Me.btn_nuevoTMB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevoTMB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_nuevoTMB.UseVisualStyleBackColor = False
        '
        'btn_actualizarTMB
        '
        Me.btn_actualizarTMB.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_actualizarTMB.Enabled = False
        Me.btn_actualizarTMB.ForeColor = System.Drawing.Color.White
        Me.btn_actualizarTMB.IconChar = FontAwesome.Sharp.IconChar.Broom
        Me.btn_actualizarTMB.IconColor = System.Drawing.Color.White
        Me.btn_actualizarTMB.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_actualizarTMB.IconSize = 25
        Me.btn_actualizarTMB.Location = New System.Drawing.Point(32, 383)
        Me.btn_actualizarTMB.Name = "btn_actualizarTMB"
        Me.btn_actualizarTMB.Size = New System.Drawing.Size(163, 35)
        Me.btn_actualizarTMB.TabIndex = 43
        Me.btn_actualizarTMB.Text = "Actualizar"
        Me.btn_actualizarTMB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_actualizarTMB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_actualizarTMB.UseVisualStyleBackColor = False
        '
        'btn_eliminarTMB
        '
        Me.btn_eliminarTMB.BackColor = System.Drawing.Color.Red
        Me.btn_eliminarTMB.ForeColor = System.Drawing.Color.White
        Me.btn_eliminarTMB.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_eliminarTMB.IconColor = System.Drawing.Color.White
        Me.btn_eliminarTMB.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_eliminarTMB.IconSize = 25
        Me.btn_eliminarTMB.Location = New System.Drawing.Point(31, 424)
        Me.btn_eliminarTMB.Name = "btn_eliminarTMB"
        Me.btn_eliminarTMB.Size = New System.Drawing.Size(163, 35)
        Me.btn_eliminarTMB.TabIndex = 42
        Me.btn_eliminarTMB.Text = "eliminar"
        Me.btn_eliminarTMB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminarTMB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_eliminarTMB.UseVisualStyleBackColor = False
        '
        'btn_modificarTMB
        '
        Me.btn_modificarTMB.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_modificarTMB.ForeColor = System.Drawing.Color.White
        Me.btn_modificarTMB.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_modificarTMB.IconColor = System.Drawing.Color.White
        Me.btn_modificarTMB.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_modificarTMB.IconSize = 25
        Me.btn_modificarTMB.Location = New System.Drawing.Point(31, 342)
        Me.btn_modificarTMB.Name = "btn_modificarTMB"
        Me.btn_modificarTMB.Size = New System.Drawing.Size(163, 35)
        Me.btn_modificarTMB.TabIndex = 41
        Me.btn_modificarTMB.Text = "Modificar"
        Me.btn_modificarTMB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_modificarTMB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_modificarTMB.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(TipoMBLabel)
        Me.GroupBox1.Controls.Add(Me.TipoMBTextBox)
        Me.GroupBox1.Controls.Add(DescripcionLabel)
        Me.GroupBox1.Controls.Add(Me.DescripcionTextBox)
        Me.GroupBox1.Controls.Add(SiglasLabel)
        Me.GroupBox1.Controls.Add(Me.SiglasTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 164)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos:"
        '
        'TipoMBTextBox
        '
        Me.TipoMBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIPO_M_BIBLIOGRAFICOBindingSource, "TipoMB", True))
        Me.TipoMBTextBox.Enabled = False
        Me.TipoMBTextBox.Location = New System.Drawing.Point(90, 52)
        Me.TipoMBTextBox.Name = "TipoMBTextBox"
        Me.TipoMBTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TipoMBTextBox.TabIndex = 1
        '
        'TIPO_M_BIBLIOGRAFICOBindingSource
        '
        Me.TIPO_M_BIBLIOGRAFICOBindingSource.DataMember = "TIPO_M_BIBLIOGRAFICO"
        Me.TIPO_M_BIBLIOGRAFICOBindingSource.DataSource = Me.BD_BIBLIOTECA_V2DataSet
        '
        'BD_BIBLIOTECA_V2DataSet
        '
        Me.BD_BIBLIOTECA_V2DataSet.DataSetName = "BD_BIBLIOTECA_V2DataSet"
        Me.BD_BIBLIOTECA_V2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIPO_M_BIBLIOGRAFICOBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Enabled = False
        Me.DescripcionTextBox.Location = New System.Drawing.Point(90, 78)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionTextBox.TabIndex = 3
        '
        'SiglasTextBox
        '
        Me.SiglasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIPO_M_BIBLIOGRAFICOBindingSource, "Siglas", True))
        Me.SiglasTextBox.Enabled = False
        Me.SiglasTextBox.Location = New System.Drawing.Point(90, 104)
        Me.SiglasTextBox.Name = "SiglasTextBox"
        Me.SiglasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SiglasTextBox.TabIndex = 5
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
        'TIPO_M_BIBLIOGRAFICOTableAdapter
        '
        Me.TIPO_M_BIBLIOGRAFICOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BIBLIOTECARIOTableAdapter = Nothing
        Me.TableAdapterManager.DETALLETableAdapter = Nothing
        Me.TableAdapterManager.LECTORTableAdapter = Nothing
        Me.TableAdapterManager.MATERIAL_BIBLIOGRAFICOTableAdapter = Nothing
        Me.TableAdapterManager.PRESTACION_Y_DEVOLUCIONTableAdapter = Nothing
        Me.TableAdapterManager.TEMPORALTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_M_BIBLIOGRAFICOTableAdapter = Me.TIPO_M_BIBLIOGRAFICOTableAdapter
        Me.TableAdapterManager.UpdateOrder = SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TIPO_M_BIBLIOGRAFICODataGridView
        '
        Me.TIPO_M_BIBLIOGRAFICODataGridView.AllowUserToAddRows = False
        Me.TIPO_M_BIBLIOGRAFICODataGridView.AllowUserToDeleteRows = False
        Me.TIPO_M_BIBLIOGRAFICODataGridView.AutoGenerateColumns = False
        Me.TIPO_M_BIBLIOGRAFICODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TIPO_M_BIBLIOGRAFICODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TipoMB, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TIPO_M_BIBLIOGRAFICODataGridView.DataSource = Me.TIPO_M_BIBLIOGRAFICOBindingSource
        Me.TIPO_M_BIBLIOGRAFICODataGridView.Enabled = False
        Me.TIPO_M_BIBLIOGRAFICODataGridView.Location = New System.Drawing.Point(468, 115)
        Me.TIPO_M_BIBLIOGRAFICODataGridView.Name = "TIPO_M_BIBLIOGRAFICODataGridView"
        Me.TIPO_M_BIBLIOGRAFICODataGridView.ReadOnly = True
        Me.TIPO_M_BIBLIOGRAFICODataGridView.Size = New System.Drawing.Size(545, 343)
        Me.TIPO_M_BIBLIOGRAFICODataGridView.TabIndex = 21
        '
        'TipoMB
        '
        Me.TipoMB.DataPropertyName = "TipoMB"
        Me.TipoMB.HeaderText = "Tipo de Material Bbliografico"
        Me.TipoMB.Name = "TipoMB"
        Me.TipoMB.ReadOnly = True
        Me.TipoMB.Width = 190
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 180
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Siglas"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Siglas"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 130
        '
        'frm_tipomb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1234, 607)
        Me.Controls.Add(Me.TIPO_M_BIBLIOGRAFICODataGridView)
        Me.Controls.Add(Me.pn_container)
        Me.Name = "frm_tipomb"
        Me.Text = "frm_inventario"
        Me.pn_container.ResumeLayout(False)
        Me.pn_container.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TIPO_M_BIBLIOGRAFICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_BIBLIOTECA_V2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPO_M_BIBLIOGRAFICODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pn_container As Panel
    Private WithEvents lb_detusuario As Label
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents btn_guardarTMB As FontAwesome.Sharp.IconButton
    Private WithEvents btn_nuevoTMB As FontAwesome.Sharp.IconButton
    Private WithEvents btn_actualizarTMB As FontAwesome.Sharp.IconButton
    Private WithEvents btn_eliminarTMB As FontAwesome.Sharp.IconButton
    Private WithEvents btn_modificarTMB As FontAwesome.Sharp.IconButton
    Friend WithEvents BD_BIBLIOTECA_V2DataSet As BD_BIBLIOTECA_V2DataSet
    Friend WithEvents TIPO_M_BIBLIOGRAFICOBindingSource As BindingSource
    Friend WithEvents TIPO_M_BIBLIOGRAFICOTableAdapter As BD_BIBLIOTECA_V2DataSetTableAdapters.TIPO_M_BIBLIOGRAFICOTableAdapter
    Friend WithEvents TableAdapterManager As BD_BIBLIOTECA_V2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TipoMBTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents SiglasTextBox As TextBox
    Friend WithEvents TIPO_M_BIBLIOGRAFICODataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TipoMB As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
