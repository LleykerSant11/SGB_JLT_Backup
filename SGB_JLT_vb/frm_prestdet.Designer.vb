<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_prestdet
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
        Me.BD_BIBLIOTECA_V2DataSet = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSet()
        Me.DETALLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DETALLETableAdapter = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.DETALLETableAdapter()
        Me.TableAdapterManager = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.TableAdapterManager()
        Me.PRESTACION_Y_DEVOLUCIONTableAdapter = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.PRESTACION_Y_DEVOLUCIONTableAdapter()
        Me.DETALLEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRESTACION_Y_DEVOLUCIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRESTACION_Y_DEVOLUCIONDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BD_BIBLIOTECA_V2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DETALLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DETALLEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRESTACION_Y_DEVOLUCIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRESTACION_Y_DEVOLUCIONDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BD_BIBLIOTECA_V2DataSet
        '
        Me.BD_BIBLIOTECA_V2DataSet.DataSetName = "BD_BIBLIOTECA_V2DataSet"
        Me.BD_BIBLIOTECA_V2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DETALLEBindingSource
        '
        Me.DETALLEBindingSource.DataMember = "DETALLE"
        Me.DETALLEBindingSource.DataSource = Me.BD_BIBLIOTECA_V2DataSet
        '
        'DETALLETableAdapter
        '
        Me.DETALLETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BIBLIOTECARIOTableAdapter = Nothing
        Me.TableAdapterManager.DETALLETableAdapter = Me.DETALLETableAdapter
        Me.TableAdapterManager.LECTORTableAdapter = Nothing
        Me.TableAdapterManager.MATERIAL_BIBLIOGRAFICOTableAdapter = Nothing
        Me.TableAdapterManager.PRESTACION_Y_DEVOLUCIONTableAdapter = Me.PRESTACION_Y_DEVOLUCIONTableAdapter
        Me.TableAdapterManager.TEMPORALTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_M_BIBLIOGRAFICOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PRESTACION_Y_DEVOLUCIONTableAdapter
        '
        Me.PRESTACION_Y_DEVOLUCIONTableAdapter.ClearBeforeFill = True
        '
        'DETALLEDataGridView
        '
        Me.DETALLEDataGridView.AllowUserToAddRows = False
        Me.DETALLEDataGridView.AllowUserToDeleteRows = False
        Me.DETALLEDataGridView.AutoGenerateColumns = False
        Me.DETALLEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DETALLEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DETALLEDataGridView.DataSource = Me.DETALLEBindingSource
        Me.DETALLEDataGridView.Location = New System.Drawing.Point(173, 354)
        Me.DETALLEDataGridView.Name = "DETALLEDataGridView"
        Me.DETALLEDataGridView.ReadOnly = True
        Me.DETALLEDataGridView.Size = New System.Drawing.Size(645, 220)
        Me.DETALLEDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NumDetalle"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NumDetalle"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "EstadoMat"
        Me.DataGridViewTextBoxColumn3.HeaderText = "EstadoMat"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Observaciones"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "MatBib"
        Me.DataGridViewTextBoxColumn5.HeaderText = "MatBib"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NumeroRegistro"
        Me.DataGridViewTextBoxColumn6.HeaderText = "NumeroRegistro"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'PRESTACION_Y_DEVOLUCIONBindingSource
        '
        Me.PRESTACION_Y_DEVOLUCIONBindingSource.DataMember = "PRESTACION_Y_DEVOLUCION"
        Me.PRESTACION_Y_DEVOLUCIONBindingSource.DataSource = Me.BD_BIBLIOTECA_V2DataSet
        '
        'PRESTACION_Y_DEVOLUCIONDataGridView
        '
        Me.PRESTACION_Y_DEVOLUCIONDataGridView.AllowUserToAddRows = False
        Me.PRESTACION_Y_DEVOLUCIONDataGridView.AllowUserToDeleteRows = False
        Me.PRESTACION_Y_DEVOLUCIONDataGridView.AutoGenerateColumns = False
        Me.PRESTACION_Y_DEVOLUCIONDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRESTACION_Y_DEVOLUCIONDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.PRESTACION_Y_DEVOLUCIONDataGridView.DataSource = Me.PRESTACION_Y_DEVOLUCIONBindingSource
        Me.PRESTACION_Y_DEVOLUCIONDataGridView.Location = New System.Drawing.Point(173, 86)
        Me.PRESTACION_Y_DEVOLUCIONDataGridView.Name = "PRESTACION_Y_DEVOLUCIONDataGridView"
        Me.PRESTACION_Y_DEVOLUCIONDataGridView.ReadOnly = True
        Me.PRESTACION_Y_DEVOLUCIONDataGridView.Size = New System.Drawing.Size(631, 243)
        Me.PRESTACION_Y_DEVOLUCIONDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NumeroRegistro"
        Me.DataGridViewTextBoxColumn7.HeaderText = "NumeroRegistro"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FechaHoraPrestacion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "FechaHoraPrestacion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 120
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "FechaHoraDevolucion"
        Me.DataGridViewTextBoxColumn9.HeaderText = "FechaHoraDevolucion"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 120
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CodLec"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Codigo Lector"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CODBIBLI"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Codigo Bibliotecario"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 150
        '
        'frm_prestdet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(994, 649)
        Me.Controls.Add(Me.PRESTACION_Y_DEVOLUCIONDataGridView)
        Me.Controls.Add(Me.DETALLEDataGridView)
        Me.Name = "frm_prestdet"
        Me.Text = "frm_prestdet"
        CType(Me.BD_BIBLIOTECA_V2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DETALLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DETALLEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRESTACION_Y_DEVOLUCIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRESTACION_Y_DEVOLUCIONDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BD_BIBLIOTECA_V2DataSet As BD_BIBLIOTECA_V2DataSet
    Friend WithEvents DETALLEBindingSource As BindingSource
    Friend WithEvents DETALLETableAdapter As BD_BIBLIOTECA_V2DataSetTableAdapters.DETALLETableAdapter
    Friend WithEvents TableAdapterManager As BD_BIBLIOTECA_V2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PRESTACION_Y_DEVOLUCIONTableAdapter As BD_BIBLIOTECA_V2DataSetTableAdapters.PRESTACION_Y_DEVOLUCIONTableAdapter
    Friend WithEvents DETALLEDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents PRESTACION_Y_DEVOLUCIONBindingSource As BindingSource
    Friend WithEvents PRESTACION_Y_DEVOLUCIONDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
End Class
