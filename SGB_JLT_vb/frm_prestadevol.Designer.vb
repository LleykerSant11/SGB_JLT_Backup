<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_prestadevol
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
        Dim NumeroRegistroLabel As System.Windows.Forms.Label
        Dim FechaHoraPrestacionLabel As System.Windows.Forms.Label
        Dim FechaHoraDevolucionLabel As System.Windows.Forms.Label
        Dim CodLecLabel As System.Windows.Forms.Label
        Dim CodBli As System.Windows.Forms.Label
        Dim NumDetalleLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim EstadoMatLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim MatBibLabel As System.Windows.Forms.Label
        Dim NumeroRegistroLabel1 As System.Windows.Forms.Label
        Me.BIBLIOTECARIODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BIBLIOTECARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_BIBLIOTECA_V2DataSet = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSet()
        Me.LECTORDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LECTORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumeroRegistroTextBox = New System.Windows.Forms.TextBox()
        Me.PRESTACION_Y_DEVOLUCIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FechaHoraPrestacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechaHoraDevolucionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CodLecTextBox = New System.Windows.Forms.TextBox()
        Me.CODBIBLITextBox = New System.Windows.Forms.TextBox()
        Me.datosgenerales = New System.Windows.Forms.GroupBox()
        Me.detalle = New System.Windows.Forms.GroupBox()
        Me.NumeroRegistroTextBox1 = New System.Windows.Forms.TextBox()
        Me.DETALLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NumDetalleTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoMatTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.MatBibTextBox = New System.Windows.Forms.TextBox()
        Me.txt_buscaB = New System.Windows.Forms.TextBox()
        Me.txt_buscaL = New System.Windows.Forms.TextBox()
        Me.MATERIAL_BIBLIOGRAFICODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MATERIAL_BIBLIOGRAFICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_buscaMB = New System.Windows.Forms.TextBox()
        Me.btn_guardarPD = New FontAwesome.Sharp.IconButton()
        Me.btn_nuevoPD = New FontAwesome.Sharp.IconButton()
        Me.btn_actualizarPD = New FontAwesome.Sharp.IconButton()
        Me.btn_eliminarPD = New FontAwesome.Sharp.IconButton()
        Me.btn_modificarPD = New FontAwesome.Sharp.IconButton()
        Me.PRESTACION_Y_DEVOLUCIONDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BIBLIOTECARIOTableAdapter = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.BIBLIOTECARIOTableAdapter()
        Me.LECTORTableAdapter = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.LECTORTableAdapter()
        Me.TableAdapterManager = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.TableAdapterManager()
        Me.PRESTACION_Y_DEVOLUCIONTableAdapter = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.PRESTACION_Y_DEVOLUCIONTableAdapter()
        Me.TEMPORALTableAdapter = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.TEMPORALTableAdapter()
        Me.TEMPORALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DETALLETableAdapter = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.DETALLETableAdapter()
        Me.MATERIAL_BIBLIOGRAFICOTableAdapter = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.MATERIAL_BIBLIOGRAFICOTableAdapter()
        Me.BD_BIBLIOTECA_V2DataSet1 = New SGB_JLT_vb.BD_BIBLIOTECA_V2DataSet()
        NumeroRegistroLabel = New System.Windows.Forms.Label()
        FechaHoraPrestacionLabel = New System.Windows.Forms.Label()
        FechaHoraDevolucionLabel = New System.Windows.Forms.Label()
        CodLecLabel = New System.Windows.Forms.Label()
        CodBli = New System.Windows.Forms.Label()
        NumDetalleLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        EstadoMatLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        MatBibLabel = New System.Windows.Forms.Label()
        NumeroRegistroLabel1 = New System.Windows.Forms.Label()
        CType(Me.BIBLIOTECARIODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BIBLIOTECARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_BIBLIOTECA_V2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LECTORDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LECTORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRESTACION_Y_DEVOLUCIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.datosgenerales.SuspendLayout()
        Me.detalle.SuspendLayout()
        CType(Me.DETALLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MATERIAL_BIBLIOGRAFICODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MATERIAL_BIBLIOGRAFICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRESTACION_Y_DEVOLUCIONDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEMPORALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_BIBLIOTECA_V2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumeroRegistroLabel
        '
        NumeroRegistroLabel.AutoSize = True
        NumeroRegistroLabel.ForeColor = System.Drawing.SystemColors.Control
        NumeroRegistroLabel.Location = New System.Drawing.Point(13, 22)
        NumeroRegistroLabel.Name = "NumeroRegistroLabel"
        NumeroRegistroLabel.Size = New System.Drawing.Size(89, 13)
        NumeroRegistroLabel.TabIndex = 6
        NumeroRegistroLabel.Text = "Numero Registro:"
        '
        'FechaHoraPrestacionLabel
        '
        FechaHoraPrestacionLabel.AutoSize = True
        FechaHoraPrestacionLabel.ForeColor = System.Drawing.SystemColors.Control
        FechaHoraPrestacionLabel.Location = New System.Drawing.Point(137, 22)
        FechaHoraPrestacionLabel.Name = "FechaHoraPrestacionLabel"
        FechaHoraPrestacionLabel.Size = New System.Drawing.Size(119, 13)
        FechaHoraPrestacionLabel.TabIndex = 8
        FechaHoraPrestacionLabel.Text = "Fecha Hora Prestacion:"
        '
        'FechaHoraDevolucionLabel
        '
        FechaHoraDevolucionLabel.AutoSize = True
        FechaHoraDevolucionLabel.ForeColor = System.Drawing.SystemColors.Control
        FechaHoraDevolucionLabel.Location = New System.Drawing.Point(274, 22)
        FechaHoraDevolucionLabel.Name = "FechaHoraDevolucionLabel"
        FechaHoraDevolucionLabel.Size = New System.Drawing.Size(123, 13)
        FechaHoraDevolucionLabel.TabIndex = 10
        FechaHoraDevolucionLabel.Text = "Fecha Hora Devolucion:"
        '
        'CodLecLabel
        '
        CodLecLabel.AutoSize = True
        CodLecLabel.ForeColor = System.Drawing.SystemColors.Control
        CodLecLabel.Location = New System.Drawing.Point(13, 86)
        CodLecLabel.Name = "CodLecLabel"
        CodLecLabel.Size = New System.Drawing.Size(50, 13)
        CodLecLabel.TabIndex = 12
        CodLecLabel.Text = "Cod Lec:"
        '
        'CodBli
        '
        CodBli.AutoSize = True
        CodBli.ForeColor = System.Drawing.SystemColors.Control
        CodBli.Location = New System.Drawing.Point(137, 86)
        CodBli.Name = "CodBli"
        CodBli.Size = New System.Drawing.Size(40, 13)
        CodBli.TabIndex = 14
        CodBli.Text = "CodBli:"
        '
        'NumDetalleLabel
        '
        NumDetalleLabel.AutoSize = True
        NumDetalleLabel.Location = New System.Drawing.Point(185, 77)
        NumDetalleLabel.Name = "NumDetalleLabel"
        NumDetalleLabel.Size = New System.Drawing.Size(68, 13)
        NumDetalleLabel.TabIndex = 0
        NumDetalleLabel.Text = "Num Detalle:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(165, 27)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 2
        CantidadLabel.Text = "Cantidad:"
        '
        'EstadoMatLabel
        '
        EstadoMatLabel.AutoSize = True
        EstadoMatLabel.Location = New System.Drawing.Point(6, 51)
        EstadoMatLabel.Name = "EstadoMatLabel"
        EstadoMatLabel.Size = New System.Drawing.Size(64, 13)
        EstadoMatLabel.TabIndex = 4
        EstadoMatLabel.Text = "Estado Mat:"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(150, 51)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(81, 13)
        ObservacionesLabel.TabIndex = 6
        ObservacionesLabel.Text = "Observaciones:"
        '
        'MatBibLabel
        '
        MatBibLabel.AutoSize = True
        MatBibLabel.Location = New System.Drawing.Point(6, 27)
        MatBibLabel.Name = "MatBibLabel"
        MatBibLabel.Size = New System.Drawing.Size(46, 13)
        MatBibLabel.TabIndex = 10
        MatBibLabel.Text = "Mat Bib:"
        '
        'NumeroRegistroLabel1
        '
        NumeroRegistroLabel1.AutoSize = True
        NumeroRegistroLabel1.Location = New System.Drawing.Point(6, 81)
        NumeroRegistroLabel1.Name = "NumeroRegistroLabel1"
        NumeroRegistroLabel1.Size = New System.Drawing.Size(89, 13)
        NumeroRegistroLabel1.TabIndex = 11
        NumeroRegistroLabel1.Text = "Numero Registro:"
        '
        'BIBLIOTECARIODataGridView
        '
        Me.BIBLIOTECARIODataGridView.AutoGenerateColumns = False
        Me.BIBLIOTECARIODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BIBLIOTECARIODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.BIBLIOTECARIODataGridView.DataSource = Me.BIBLIOTECARIOBindingSource
        Me.BIBLIOTECARIODataGridView.Location = New System.Drawing.Point(15, 74)
        Me.BIBLIOTECARIODataGridView.Name = "BIBLIOTECARIODataGridView"
        Me.BIBLIOTECARIODataGridView.Size = New System.Drawing.Size(384, 104)
        Me.BIBLIOTECARIODataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CODBIBLI"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CodBibli"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombreApellidos"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NombreApellidos"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Direccion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Clave"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Clave"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Correo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Correo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
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
        Me.DataGridViewTextBoxColumn8.Visible = False
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
        'LECTORDataGridView
        '
        Me.LECTORDataGridView.AutoGenerateColumns = False
        Me.LECTORDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LECTORDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.LECTORDataGridView.DataSource = Me.LECTORBindingSource
        Me.LECTORDataGridView.Location = New System.Drawing.Point(15, 222)
        Me.LECTORDataGridView.Name = "LECTORDataGridView"
        Me.LECTORDataGridView.Size = New System.Drawing.Size(411, 104)
        Me.LECTORDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CodLec"
        Me.DataGridViewTextBoxColumn9.HeaderText = "CodLec"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "TipoLector"
        Me.DataGridViewTextBoxColumn10.HeaderText = "TipoLector"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 120
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "NombreApellidos"
        Me.DataGridViewTextBoxColumn11.HeaderText = "NombreApellidos"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 150
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Direccion"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Estado"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Correo"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Correo"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'LECTORBindingSource
        '
        Me.LECTORBindingSource.DataMember = "LECTOR"
        Me.LECTORBindingSource.DataSource = Me.BD_BIBLIOTECA_V2DataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(12, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Busca por nombre el Lector"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Busca por nombre el Bibliotecario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(581, 342)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(263, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Visualiza la prestacion y devolucion"
        '
        'NumeroRegistroTextBox
        '
        Me.NumeroRegistroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRESTACION_Y_DEVOLUCIONBindingSource, "NumeroRegistro", True))
        Me.NumeroRegistroTextBox.Location = New System.Drawing.Point(16, 41)
        Me.NumeroRegistroTextBox.Name = "NumeroRegistroTextBox"
        Me.NumeroRegistroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumeroRegistroTextBox.TabIndex = 7
        '
        'PRESTACION_Y_DEVOLUCIONBindingSource
        '
        Me.PRESTACION_Y_DEVOLUCIONBindingSource.DataMember = "PRESTACION_Y_DEVOLUCION"
        Me.PRESTACION_Y_DEVOLUCIONBindingSource.DataSource = Me.BD_BIBLIOTECA_V2DataSet
        '
        'FechaHoraPrestacionDateTimePicker
        '
        Me.FechaHoraPrestacionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PRESTACION_Y_DEVOLUCIONBindingSource, "FechaHoraPrestacion", True))
        Me.FechaHoraPrestacionDateTimePicker.Enabled = False
        Me.FechaHoraPrestacionDateTimePicker.Location = New System.Drawing.Point(140, 41)
        Me.FechaHoraPrestacionDateTimePicker.Name = "FechaHoraPrestacionDateTimePicker"
        Me.FechaHoraPrestacionDateTimePicker.Size = New System.Drawing.Size(116, 20)
        Me.FechaHoraPrestacionDateTimePicker.TabIndex = 9
        '
        'FechaHoraDevolucionDateTimePicker
        '
        Me.FechaHoraDevolucionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PRESTACION_Y_DEVOLUCIONBindingSource, "FechaHoraDevolucion", True))
        Me.FechaHoraDevolucionDateTimePicker.Enabled = False
        Me.FechaHoraDevolucionDateTimePicker.Location = New System.Drawing.Point(277, 41)
        Me.FechaHoraDevolucionDateTimePicker.Name = "FechaHoraDevolucionDateTimePicker"
        Me.FechaHoraDevolucionDateTimePicker.Size = New System.Drawing.Size(120, 20)
        Me.FechaHoraDevolucionDateTimePicker.TabIndex = 11
        '
        'CodLecTextBox
        '
        Me.CodLecTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRESTACION_Y_DEVOLUCIONBindingSource, "CodLec", True))
        Me.CodLecTextBox.Location = New System.Drawing.Point(16, 102)
        Me.CodLecTextBox.Name = "CodLecTextBox"
        Me.CodLecTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodLecTextBox.TabIndex = 13
        '
        'CODBIBLITextBox
        '
        Me.CODBIBLITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRESTACION_Y_DEVOLUCIONBindingSource, "CODBIBLI", True))
        Me.CODBIBLITextBox.Location = New System.Drawing.Point(135, 102)
        Me.CODBIBLITextBox.Name = "CODBIBLITextBox"
        Me.CODBIBLITextBox.Size = New System.Drawing.Size(111, 20)
        Me.CODBIBLITextBox.TabIndex = 15
        '
        'datosgenerales
        '
        Me.datosgenerales.Controls.Add(Me.FechaHoraPrestacionDateTimePicker)
        Me.datosgenerales.Controls.Add(NumeroRegistroLabel)
        Me.datosgenerales.Controls.Add(Me.CODBIBLITextBox)
        Me.datosgenerales.Controls.Add(Me.NumeroRegistroTextBox)
        Me.datosgenerales.Controls.Add(CodBli)
        Me.datosgenerales.Controls.Add(FechaHoraPrestacionLabel)
        Me.datosgenerales.Controls.Add(Me.CodLecTextBox)
        Me.datosgenerales.Controls.Add(CodLecLabel)
        Me.datosgenerales.Controls.Add(FechaHoraDevolucionLabel)
        Me.datosgenerales.Controls.Add(Me.FechaHoraDevolucionDateTimePicker)
        Me.datosgenerales.Enabled = False
        Me.datosgenerales.ForeColor = System.Drawing.SystemColors.Control
        Me.datosgenerales.Location = New System.Drawing.Point(489, 69)
        Me.datosgenerales.Name = "datosgenerales"
        Me.datosgenerales.Size = New System.Drawing.Size(412, 128)
        Me.datosgenerales.TabIndex = 16
        Me.datosgenerales.TabStop = False
        Me.datosgenerales.Text = "Datos generales:"
        '
        'detalle
        '
        Me.detalle.Controls.Add(NumeroRegistroLabel1)
        Me.detalle.Controls.Add(Me.NumeroRegistroTextBox1)
        Me.detalle.Controls.Add(NumDetalleLabel)
        Me.detalle.Controls.Add(Me.NumDetalleTextBox)
        Me.detalle.Controls.Add(CantidadLabel)
        Me.detalle.Controls.Add(Me.CantidadTextBox)
        Me.detalle.Controls.Add(EstadoMatLabel)
        Me.detalle.Controls.Add(Me.EstadoMatTextBox)
        Me.detalle.Controls.Add(ObservacionesLabel)
        Me.detalle.Controls.Add(Me.ObservacionesTextBox)
        Me.detalle.Controls.Add(MatBibLabel)
        Me.detalle.Controls.Add(Me.MatBibTextBox)
        Me.detalle.Enabled = False
        Me.detalle.ForeColor = System.Drawing.SystemColors.Control
        Me.detalle.Location = New System.Drawing.Point(489, 203)
        Me.detalle.Name = "detalle"
        Me.detalle.Size = New System.Drawing.Size(376, 136)
        Me.detalle.TabIndex = 17
        Me.detalle.TabStop = False
        Me.detalle.Text = "Detalle"
        '
        'NumeroRegistroTextBox1
        '
        Me.NumeroRegistroTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLEBindingSource, "NumeroRegistro", True))
        Me.NumeroRegistroTextBox1.Location = New System.Drawing.Point(101, 78)
        Me.NumeroRegistroTextBox1.Name = "NumeroRegistroTextBox1"
        Me.NumeroRegistroTextBox1.Size = New System.Drawing.Size(76, 20)
        Me.NumeroRegistroTextBox1.TabIndex = 12
        '
        'DETALLEBindingSource
        '
        Me.DETALLEBindingSource.DataMember = "DETALLE"
        Me.DETALLEBindingSource.DataSource = Me.BD_BIBLIOTECA_V2DataSet
        '
        'NumDetalleTextBox
        '
        Me.NumDetalleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLEBindingSource, "NumDetalle", True))
        Me.NumDetalleTextBox.Location = New System.Drawing.Point(256, 74)
        Me.NumDetalleTextBox.Name = "NumDetalleTextBox"
        Me.NumDetalleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumDetalleTextBox.TabIndex = 1
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLEBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(223, 24)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(62, 20)
        Me.CantidadTextBox.TabIndex = 3
        '
        'EstadoMatTextBox
        '
        Me.EstadoMatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLEBindingSource, "EstadoMat", True))
        Me.EstadoMatTextBox.Location = New System.Drawing.Point(76, 48)
        Me.EstadoMatTextBox.Name = "EstadoMatTextBox"
        Me.EstadoMatTextBox.Size = New System.Drawing.Size(68, 20)
        Me.EstadoMatTextBox.TabIndex = 5
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLEBindingSource, "Observaciones", True))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(237, 48)
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ObservacionesTextBox.TabIndex = 7
        '
        'MatBibTextBox
        '
        Me.MatBibTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLEBindingSource, "MatBib", True))
        Me.MatBibTextBox.Location = New System.Drawing.Point(49, 24)
        Me.MatBibTextBox.Name = "MatBibTextBox"
        Me.MatBibTextBox.Size = New System.Drawing.Size(110, 20)
        Me.MatBibTextBox.TabIndex = 11
        '
        'txt_buscaB
        '
        Me.txt_buscaB.Location = New System.Drawing.Point(269, 42)
        Me.txt_buscaB.Name = "txt_buscaB"
        Me.txt_buscaB.Size = New System.Drawing.Size(201, 20)
        Me.txt_buscaB.TabIndex = 18
        '
        'txt_buscaL
        '
        Me.txt_buscaL.Location = New System.Drawing.Point(226, 190)
        Me.txt_buscaL.Name = "txt_buscaL"
        Me.txt_buscaL.Size = New System.Drawing.Size(201, 20)
        Me.txt_buscaL.TabIndex = 19
        '
        'MATERIAL_BIBLIOGRAFICODataGridView
        '
        Me.MATERIAL_BIBLIOGRAFICODataGridView.AutoGenerateColumns = False
        Me.MATERIAL_BIBLIOGRAFICODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MATERIAL_BIBLIOGRAFICODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29})
        Me.MATERIAL_BIBLIOGRAFICODataGridView.DataSource = Me.MATERIAL_BIBLIOGRAFICOBindingSource
        Me.MATERIAL_BIBLIOGRAFICODataGridView.Location = New System.Drawing.Point(15, 369)
        Me.MATERIAL_BIBLIOGRAFICODataGridView.Name = "MATERIAL_BIBLIOGRAFICODataGridView"
        Me.MATERIAL_BIBLIOGRAFICODataGridView.Size = New System.Drawing.Size(541, 220)
        Me.MATERIAL_BIBLIOGRAFICODataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "TipoMB"
        Me.DataGridViewTextBoxColumn21.HeaderText = "TipoMB"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "MatBib"
        Me.DataGridViewTextBoxColumn22.HeaderText = "MatBib"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Editorial"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Editorial"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "FechAdquisicion"
        Me.DataGridViewTextBoxColumn25.HeaderText = "FechAdquisicion"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Visible = False
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Formato"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Formato"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Visible = False
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Estado"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Visible = False
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Autor"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Autor"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Visible = False
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "Ejemplares"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Ejemplares"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'MATERIAL_BIBLIOGRAFICOBindingSource
        '
        Me.MATERIAL_BIBLIOGRAFICOBindingSource.DataMember = "MATERIAL_BIBLIOGRAFICO"
        Me.MATERIAL_BIBLIOGRAFICOBindingSource.DataSource = Me.BD_BIBLIOTECA_V2DataSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(12, 342)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 14)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Busca por nombre el Lector"
        '
        'txt_buscaMB
        '
        Me.txt_buscaMB.Location = New System.Drawing.Point(235, 336)
        Me.txt_buscaMB.Name = "txt_buscaMB"
        Me.txt_buscaMB.Size = New System.Drawing.Size(201, 20)
        Me.txt_buscaMB.TabIndex = 21
        '
        'btn_guardarPD
        '
        Me.btn_guardarPD.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_guardarPD.Enabled = False
        Me.btn_guardarPD.ForeColor = System.Drawing.Color.White
        Me.btn_guardarPD.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_guardarPD.IconColor = System.Drawing.Color.White
        Me.btn_guardarPD.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_guardarPD.IconSize = 25
        Me.btn_guardarPD.Location = New System.Drawing.Point(1009, 143)
        Me.btn_guardarPD.Name = "btn_guardarPD"
        Me.btn_guardarPD.Size = New System.Drawing.Size(163, 35)
        Me.btn_guardarPD.TabIndex = 50
        Me.btn_guardarPD.Text = "Guardar"
        Me.btn_guardarPD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardarPD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_guardarPD.UseVisualStyleBackColor = False
        '
        'btn_nuevoPD
        '
        Me.btn_nuevoPD.BackColor = System.Drawing.Color.Indigo
        Me.btn_nuevoPD.ForeColor = System.Drawing.Color.White
        Me.btn_nuevoPD.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_nuevoPD.IconColor = System.Drawing.Color.White
        Me.btn_nuevoPD.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_nuevoPD.IconSize = 25
        Me.btn_nuevoPD.Location = New System.Drawing.Point(1008, 105)
        Me.btn_nuevoPD.Name = "btn_nuevoPD"
        Me.btn_nuevoPD.Size = New System.Drawing.Size(163, 35)
        Me.btn_nuevoPD.TabIndex = 49
        Me.btn_nuevoPD.Text = "Nuevo"
        Me.btn_nuevoPD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevoPD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_nuevoPD.UseVisualStyleBackColor = False
        '
        'btn_actualizarPD
        '
        Me.btn_actualizarPD.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_actualizarPD.Enabled = False
        Me.btn_actualizarPD.ForeColor = System.Drawing.Color.White
        Me.btn_actualizarPD.IconChar = FontAwesome.Sharp.IconChar.Broom
        Me.btn_actualizarPD.IconColor = System.Drawing.Color.White
        Me.btn_actualizarPD.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_actualizarPD.IconSize = 25
        Me.btn_actualizarPD.Location = New System.Drawing.Point(1009, 225)
        Me.btn_actualizarPD.Name = "btn_actualizarPD"
        Me.btn_actualizarPD.Size = New System.Drawing.Size(163, 35)
        Me.btn_actualizarPD.TabIndex = 48
        Me.btn_actualizarPD.Text = "Actualizar"
        Me.btn_actualizarPD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_actualizarPD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_actualizarPD.UseVisualStyleBackColor = False
        '
        'btn_eliminarPD
        '
        Me.btn_eliminarPD.BackColor = System.Drawing.Color.Red
        Me.btn_eliminarPD.ForeColor = System.Drawing.Color.White
        Me.btn_eliminarPD.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_eliminarPD.IconColor = System.Drawing.Color.White
        Me.btn_eliminarPD.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_eliminarPD.IconSize = 25
        Me.btn_eliminarPD.Location = New System.Drawing.Point(1008, 266)
        Me.btn_eliminarPD.Name = "btn_eliminarPD"
        Me.btn_eliminarPD.Size = New System.Drawing.Size(163, 35)
        Me.btn_eliminarPD.TabIndex = 47
        Me.btn_eliminarPD.Text = "eliminar"
        Me.btn_eliminarPD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminarPD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_eliminarPD.UseVisualStyleBackColor = False
        '
        'btn_modificarPD
        '
        Me.btn_modificarPD.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_modificarPD.ForeColor = System.Drawing.Color.White
        Me.btn_modificarPD.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_modificarPD.IconColor = System.Drawing.Color.White
        Me.btn_modificarPD.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_modificarPD.IconSize = 25
        Me.btn_modificarPD.Location = New System.Drawing.Point(1008, 184)
        Me.btn_modificarPD.Name = "btn_modificarPD"
        Me.btn_modificarPD.Size = New System.Drawing.Size(163, 35)
        Me.btn_modificarPD.TabIndex = 46
        Me.btn_modificarPD.Text = "Modificar"
        Me.btn_modificarPD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_modificarPD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_modificarPD.UseVisualStyleBackColor = False
        '
        'PRESTACION_Y_DEVOLUCIONDataGridView
        '
        Me.PRESTACION_Y_DEVOLUCIONDataGridView.AutoGenerateColumns = False
        Me.PRESTACION_Y_DEVOLUCIONDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRESTACION_Y_DEVOLUCIONDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.PRESTACION_Y_DEVOLUCIONDataGridView.DataSource = Me.PRESTACION_Y_DEVOLUCIONBindingSource
        Me.PRESTACION_Y_DEVOLUCIONDataGridView.Location = New System.Drawing.Point(583, 369)
        Me.PRESTACION_Y_DEVOLUCIONDataGridView.Name = "PRESTACION_Y_DEVOLUCIONDataGridView"
        Me.PRESTACION_Y_DEVOLUCIONDataGridView.Size = New System.Drawing.Size(545, 220)
        Me.PRESTACION_Y_DEVOLUCIONDataGridView.TabIndex = 50
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "NumeroRegistro"
        Me.DataGridViewTextBoxColumn16.HeaderText = "NumeroRegistro"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "FechaHoraPrestacion"
        Me.DataGridViewTextBoxColumn17.HeaderText = "FechaHoraPrestacion"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "FechaHoraDevolucion"
        Me.DataGridViewTextBoxColumn18.HeaderText = "FechaHoraDevolucion"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "CodLec"
        Me.DataGridViewTextBoxColumn19.HeaderText = "CodLec"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "CODBIBLI"
        Me.DataGridViewTextBoxColumn20.HeaderText = "CODBIBLI"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'BIBLIOTECARIOTableAdapter
        '
        Me.BIBLIOTECARIOTableAdapter.ClearBeforeFill = True
        '
        'LECTORTableAdapter
        '
        Me.LECTORTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BIBLIOTECARIOTableAdapter = Me.BIBLIOTECARIOTableAdapter
        Me.TableAdapterManager.DETALLETableAdapter = Nothing
        Me.TableAdapterManager.LECTORTableAdapter = Me.LECTORTableAdapter
        Me.TableAdapterManager.MATERIAL_BIBLIOGRAFICOTableAdapter = Nothing
        Me.TableAdapterManager.PRESTACION_Y_DEVOLUCIONTableAdapter = Me.PRESTACION_Y_DEVOLUCIONTableAdapter
        Me.TableAdapterManager.TEMPORALTableAdapter = Me.TEMPORALTableAdapter
        Me.TableAdapterManager.TIPO_M_BIBLIOGRAFICOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SGB_JLT_vb.BD_BIBLIOTECA_V2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PRESTACION_Y_DEVOLUCIONTableAdapter
        '
        Me.PRESTACION_Y_DEVOLUCIONTableAdapter.ClearBeforeFill = True
        '
        'TEMPORALTableAdapter
        '
        Me.TEMPORALTableAdapter.ClearBeforeFill = True
        '
        'TEMPORALBindingSource
        '
        Me.TEMPORALBindingSource.DataMember = "TEMPORAL"
        Me.TEMPORALBindingSource.DataSource = Me.BD_BIBLIOTECA_V2DataSet
        '
        'DETALLETableAdapter
        '
        Me.DETALLETableAdapter.ClearBeforeFill = True
        '
        'MATERIAL_BIBLIOGRAFICOTableAdapter
        '
        Me.MATERIAL_BIBLIOGRAFICOTableAdapter.ClearBeforeFill = True
        '
        'BD_BIBLIOTECA_V2DataSet1
        '
        Me.BD_BIBLIOTECA_V2DataSet1.DataSetName = "BD_BIBLIOTECA_V2DataSet"
        Me.BD_BIBLIOTECA_V2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frm_prestadevol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1234, 607)
        Me.Controls.Add(Me.PRESTACION_Y_DEVOLUCIONDataGridView)
        Me.Controls.Add(Me.btn_guardarPD)
        Me.Controls.Add(Me.btn_nuevoPD)
        Me.Controls.Add(Me.btn_actualizarPD)
        Me.Controls.Add(Me.btn_eliminarPD)
        Me.Controls.Add(Me.btn_modificarPD)
        Me.Controls.Add(Me.txt_buscaMB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MATERIAL_BIBLIOGRAFICODataGridView)
        Me.Controls.Add(Me.txt_buscaL)
        Me.Controls.Add(Me.txt_buscaB)
        Me.Controls.Add(Me.detalle)
        Me.Controls.Add(Me.datosgenerales)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LECTORDataGridView)
        Me.Controls.Add(Me.BIBLIOTECARIODataGridView)
        Me.MaximumSize = New System.Drawing.Size(1250, 646)
        Me.Name = "frm_prestadevol"
        Me.Text = "frm_prestadevol"
        CType(Me.BIBLIOTECARIODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BIBLIOTECARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_BIBLIOTECA_V2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LECTORDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LECTORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRESTACION_Y_DEVOLUCIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.datosgenerales.ResumeLayout(False)
        Me.datosgenerales.PerformLayout()
        Me.detalle.ResumeLayout(False)
        Me.detalle.PerformLayout()
        CType(Me.DETALLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MATERIAL_BIBLIOGRAFICODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MATERIAL_BIBLIOGRAFICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRESTACION_Y_DEVOLUCIONDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEMPORALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_BIBLIOTECA_V2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_BIBLIOTECA_V2DataSet As BD_BIBLIOTECA_V2DataSet
    Friend WithEvents BIBLIOTECARIOBindingSource As BindingSource
    Friend WithEvents BIBLIOTECARIOTableAdapter As BD_BIBLIOTECA_V2DataSetTableAdapters.BIBLIOTECARIOTableAdapter
    Friend WithEvents BIBLIOTECARIODataGridView As DataGridView
    Friend WithEvents LECTORBindingSource As BindingSource
    Friend WithEvents LECTORTableAdapter As BD_BIBLIOTECA_V2DataSetTableAdapters.LECTORTableAdapter
    Friend WithEvents TableAdapterManager As BD_BIBLIOTECA_V2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TEMPORALTableAdapter As BD_BIBLIOTECA_V2DataSetTableAdapters.TEMPORALTableAdapter
    Friend WithEvents LECTORDataGridView As DataGridView
    Friend WithEvents TEMPORALBindingSource As BindingSource
    Friend WithEvents PRESTACION_Y_DEVOLUCIONTableAdapter As BD_BIBLIOTECA_V2DataSetTableAdapters.PRESTACION_Y_DEVOLUCIONTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PRESTACION_Y_DEVOLUCIONBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents NumeroRegistroTextBox As TextBox
    Friend WithEvents FechaHoraPrestacionDateTimePicker As DateTimePicker
    Friend WithEvents FechaHoraDevolucionDateTimePicker As DateTimePicker
    Friend WithEvents CodLecTextBox As TextBox
    Friend WithEvents CODBIBLITextBox As TextBox
    Friend WithEvents datosgenerales As GroupBox
    Friend WithEvents detalle As GroupBox
    Friend WithEvents DETALLEBindingSource As BindingSource
    Friend WithEvents DETALLETableAdapter As BD_BIBLIOTECA_V2DataSetTableAdapters.DETALLETableAdapter
    Friend WithEvents NumDetalleTextBox As TextBox
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents EstadoMatTextBox As TextBox
    Friend WithEvents ObservacionesTextBox As TextBox
    Friend WithEvents MatBibTextBox As TextBox
    Friend WithEvents txt_buscaB As TextBox
    Friend WithEvents txt_buscaL As TextBox
    Friend WithEvents MATERIAL_BIBLIOGRAFICOBindingSource As BindingSource
    Friend WithEvents MATERIAL_BIBLIOGRAFICOTableAdapter As BD_BIBLIOTECA_V2DataSetTableAdapters.MATERIAL_BIBLIOGRAFICOTableAdapter
    Friend WithEvents MATERIAL_BIBLIOGRAFICODataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_buscaMB As TextBox
    Friend WithEvents BD_BIBLIOTECA_V2DataSet1 As BD_BIBLIOTECA_V2DataSet
    Private WithEvents btn_guardarPD As FontAwesome.Sharp.IconButton
    Private WithEvents btn_nuevoPD As FontAwesome.Sharp.IconButton
    Private WithEvents btn_actualizarPD As FontAwesome.Sharp.IconButton
    Private WithEvents btn_eliminarPD As FontAwesome.Sharp.IconButton
    Private WithEvents btn_modificarPD As FontAwesome.Sharp.IconButton
    Friend WithEvents PRESTACION_Y_DEVOLUCIONDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents NumeroRegistroTextBox1 As TextBox
End Class
