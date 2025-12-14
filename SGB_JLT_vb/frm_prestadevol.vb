Imports System.Data.SqlClient
Public Class frm_prestadevol
    Private buscaLec As New DataView
    Private buscaBib As New DataView
    Private buscaMB As New DataView
    Private dgvDetallePrestaci As New DataView
    Private Sub BIBLIOTECARIOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BIBLIOTECARIOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_BIBLIOTECA_V2DataSet)

    End Sub

    Private Sub frm_prestadevol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_BIBLIOTECA_V2DataSet.MATERIAL_BIBLIOGRAFICO' table. You can move, or remove it, as needed.
        Me.MATERIAL_BIBLIOGRAFICOTableAdapter.Fill(Me.BD_BIBLIOTECA_V2DataSet.MATERIAL_BIBLIOGRAFICO)
        'TODO: This line of code loads data into the 'BD_BIBLIOTECA_V2DataSet.DETALLE' table. You can move, or remove it, as needed.
        Me.DETALLETableAdapter.Fill(Me.BD_BIBLIOTECA_V2DataSet.DETALLE)
        'TODO: This line of code loads data into the 'BD_BIBLIOTECA_V2DataSet.PRESTACION_Y_DEVOLUCION' table. You can move, or remove it, as needed.
        Me.PRESTACION_Y_DEVOLUCIONTableAdapter.Fill(Me.BD_BIBLIOTECA_V2DataSet.PRESTACION_Y_DEVOLUCION)
        'TODO: This line of code loads data into the 'BD_BIBLIOTECA_V2DataSet.TEMPORAL' table. You can move, or remove it, as needed.
        Me.TEMPORALTableAdapter.Fill(Me.BD_BIBLIOTECA_V2DataSet.TEMPORAL)
        'TODO: This line of code loads data into the 'BD_BIBLIOTECA_V2DataSet.LECTOR' table. You can move, or remove it, as needed.
        Me.LECTORTableAdapter.Fill(Me.BD_BIBLIOTECA_V2DataSet.LECTOR)
        'TODO: This line of code loads data into the 'BD_BIBLIOTECA_V2DataSet.BIBLIOTECARIO' table. You can move, or remove it, as needed.
        Me.BIBLIOTECARIOTableAdapter.Fill(Me.BD_BIBLIOTECA_V2DataSet.BIBLIOTECARIO)

        'Lector
        abrir()
        Dim Lec As New SqlDataAdapter("SELECT * FROM LECTOR", conexion1)
        Dim tor As New DataSet
        Lec.Fill(tor)
        buscaLec.Table = tor.Tables(0)
        LECTORDataGridView.DataSource = buscaLec

        'bibliotecario
        abrir()
        Dim bib As New SqlDataAdapter("SELECT * FROM BIBLIOTECARIO", conexion1)
        Dim dsBib As New DataSet ' Usar un DataSet con nombre claro (dsBib)
        bib.Fill(dsBib) ' Llenar el DataSet
        buscaBib.Table = dsBib.Tables(0) '
        BIBLIOTECARIODataGridView.DataSource = buscaBib

        'material bibliografico
        abrir()
        Dim Mat As New SqlDataAdapter("SELECT * FROM MATERIAL_BIBLIOGRAFICO", conexion1)
        Dim Bibi As New DataSet
        Mat.Fill(Bibi) ' Llenar el DataSet
        buscaMB.Table = Bibi.Tables(0) '
        MATERIAL_BIBLIOGRAFICODataGridView.DataSource = buscaMB

    End Sub

    Private Sub txt_buscaB_TextChanged(sender As Object, e As EventArgs) Handles txt_buscaB.TextChanged
        buscaBib.RowFilter = String.Format("NombreApellidos like '%{0}%'", txt_buscaB.Text)
    End Sub

    Private Sub txt_buscaL_TextChanged(sender As Object, e As EventArgs) Handles txt_buscaL.TextChanged
        buscaLec.RowFilter = String.Format("NombreApellidos like '%{0}%'", txt_buscaL.Text)
    End Sub

    Private Sub txt_buscaMB_TextChanged(sender As Object, e As EventArgs) Handles txt_buscaMB.TextChanged
        buscaMB.RowFilter = String.Format("Nombre like '%{0}%'", txt_buscaMB.Text)
    End Sub

    Private Sub btn_nuevoPD_Click(sender As Object, e As EventArgs) Handles btn_nuevoPD.Click
        btn_nuevoPD.Enabled = True
        btn_guardarPD.Enabled = True
        btn_modificarPD.Enabled = False
        btn_actualizarPD.Enabled = False
        btn_eliminarPD.Enabled = False


        datosgenerales.Enabled = True
        detalle.Enabled = True


    End Sub

    Private Sub btn_guardarPD_Click(sender As Object, e As EventArgs) Handles btn_guardarPD.Click

    End Sub

    Private Sub btn_modificarPD_Click(sender As Object, e As EventArgs) Handles btn_modificarPD.Click
        btn_nuevoPD.Enabled = False
        btn_guardarPD.Enabled = False
        btn_modificarPD.Enabled = True
        btn_actualizarPD.Enabled = True
        btn_eliminarPD.Enabled = False


        datosgenerales.Enabled = True
        NumeroRegistroTextBox.Enabled = False
        CODBIBLITextBox.Enabled = False
        CodLecTextBox.Enabled = False
        FechaHoraDevolucionDateTimePicker.Enabled = True

        detalle.Enabled = True
        MatBibTextBox.Enabled = False
        CantidadTextBox.Enabled = False
        ObservacionesTextBox.Enabled = True
        EstadoMatTextBox.Enabled = True
        NumDetalleTextBox.Enabled = False

    End Sub
End Class