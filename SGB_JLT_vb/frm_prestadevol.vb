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
        ' 1. VALIDACIÓN DE DATOS REQUERIDOS
        ' ----------------------------------

        If Len(Trim(NumeroRegistroTextBox.Text)) = 0 Then
            MsgBox("Ingrese el Número de Registro.", vbCritical, "Validando datos")
            NumeroRegistroTextBox.Focus()
            Exit Sub
        End If

        If Len(Trim(CodLecTextBox.Text)) = 0 Then
            MsgBox("Ingrese el Código del Lector (CodLec).", vbCritical, "Validando datos")
            CodLecTextBox.Focus()
            Exit Sub
        End If

        If Len(Trim(CODBIBLITextBox.Text)) = 0 Then
            MsgBox("Ingrese el Código del Bibliotecario (CodBli).", vbCritical, "Validando datos")
            CODBIBLITextBox.Focus()
            Exit Sub
        End If

        If Len(Trim(MatBibTextBox.Text)) = 0 Then
            MsgBox("Ingrese el Código de Material Bibliográfico (MatBib).", vbCritical, "Validando datos")
            MatBibTextBox.Focus()
            Exit Sub
        End If

        If Len(Trim(NumDetalleTextBox.Text)) = 0 Then
            MsgBox("Ingrese el Número de Detalle (NumDetalle).", vbCritical, "Validando datos")
            NumDetalleTextBox.Focus()
            Exit Sub
        End If

        ' Validar Cantidad (debe ser un número positivo, ya que es obligatorio)
        Dim cantidadPrestada As Integer
        If Not Integer.TryParse(CantidadTextBox.Text, cantidadPrestada) OrElse cantidadPrestada <= 0 Then
            MsgBox("La Cantidad debe ser un número positivo.", vbCritical, "Validando datos")
            CantidadTextBox.Focus()
            Exit Sub
        End If


        ' 2. CONFIRMACIÓN Y MANEJO DE NULLS PARA INSERCIÓN
        ' ----------------------------------------------------

        If MsgBox("¿Está seguro de registrar esta Prestación y su Detalle?", vbYesNo + vbQuestion, "Confirmar Guardado") = vbYes Then

            Try
                ' Manejo de NULLS (Solo aplica si dejas campos opcionales vacíos al insertar)
                Dim observacionesDetalle As Object = IIf(Len(Trim(ObservacionesTextBox.Text)) = 0, DBNull.Value, ObservacionesTextBox.Text)
                Dim estadoMaterial As Object = IIf(Len(Trim(EstadoMatTextBox.Text)) = 0, DBNull.Value, EstadoMatTextBox.Text)
                ' FechaHoraDevolucion también podría ser NULL al insertar si la devolución es futura.
                ' Asumimos que al guardar, la Fecha de Devolución puede ser NULL si el control no está 'Checked'.
                Dim fechaDevolucion As Object = IIf(FechaHoraDevolucionDateTimePicker.Checked = False, DBNull.Value, FechaHoraDevolucionDateTimePicker.Value)


                ' --- A. INSERCIÓN EN PRESTACION_Y_DEVOLUCION ---
                Me.PRESTACION_Y_DEVOLUCIONTableAdapter.InsertarPD(
                NumeroRegistroTextBox.Text,
                FechaHoraPrestacionDateTimePicker.Value,
                fechaDevolucion,
                CodLecTextBox.Text,
                CODBIBLITextBox.Text
            )

                ' --- B. INSERCIÓN EN DETALLE ---
                Me.DETALLETableAdapter.InsertarDet(
                NumDetalleTextBox.Text,
                cantidadPrestada,
                estadoMaterial,
                observacionesDetalle,
                MatBibTextBox.Text,
                NumeroRegistroTextBox.Text
            )

                MsgBox("Prestación y Detalle registrados con éxito.", MsgBoxStyle.Information, "Registro Exitoso")


                ' 3. RECARGA Y RECONFIGURACIÓN DE LA INTERFAZ
                ' ------------------------------------------

                Me.PRESTACION_Y_DEVOLUCIONTableAdapter.Fill(Me.BD_BIBLIOTECA_V2DataSet.PRESTACION_Y_DEVOLUCION)
                ' ESTA LÍNEA RECARGA EL DETALLE FILTRADO CON LOS DATOS NUEVOS
                Me.DETALLETableAdapter.FillBy(Me.BD_BIBLIOTECA_V2DataSet.DETALLE, NumeroRegistroTextBox.Text)


                btn_nuevoPD.Enabled = True
                btn_guardarPD.Enabled = False
                btn_modificarPD.Enabled = True
                btn_actualizarPD.Enabled = False
                btn_eliminarPD.Enabled = True

                ' Deshabilitar todos los campos de entrada
                ' (Necesitas mapear todos los campos de tu interfaz)
                ' ...

            Catch ex As Exception
                MsgBox("Ocurrió un error al guardar: " & ex.Message, vbCritical, "Error de Base de Datos")
                btn_guardarPD.Enabled = True
            End Try

        End If
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

    Private Sub btn_eliminarPD_Click(sender As Object, e As EventArgs) Handles btn_eliminarPD.Click
        ' 1. VALIDACIÓN
        ' ------------------

        If Len(Trim(NumeroRegistroTextBox.Text)) = 0 Then
            MsgBox("Debe seleccionar un Número de Registro para poder eliminar.", vbCritical, "Error de Selección")
            Exit Sub
        End If

        ' 2. CONFIRMACIÓN
        ' ------------------

        Dim numeroRegistroAEliminar As String = NumeroRegistroTextBox.Text

        If MsgBox("¿Está seguro de eliminar esta Prestación (" & numeroRegistroAEliminar & ") y todos sus Detalles?", vbYesNo + vbCritical, "Confirmar Eliminación") = vbYes Then

            Try
                ' El orden de eliminación es CRÍTICO: 
                ' 1. Detalle (Hijo)
                ' 2. Prestación (Padre)

                ' --- A. ELIMINAR REGISTROS DE DETALLE ---
                ' Asume que tienes un método ELIMINARDET en tu DETALLETableAdapter que elimina por NumeroRegistro
                Me.DETALLETableAdapter.EliminarDet(numeroRegistroAEliminar)

                ' --- B. ELIMINAR REGISTRO DE PRESTACION_Y_DEVOLUCION ---
                ' Asume que tienes un método ELIMINARPD en tu PRESTACION_Y_DEVOLUCIONTableAdapter que elimina por NumeroRegistro
                Me.PRESTACION_Y_DEVOLUCIONTableAdapter.EliminarPD(numeroRegistroAEliminar)

                ' 3. RECARGA Y LIMPIEZA DE INTERFAZ (Siguiendo tu patrón)
                ' --------------------------------------------------------

                MsgBox("Prestación y Detalles eliminados con éxito.", vbInformation, "Eliminación Exitosa")

                ' Recargar ambas tablas
                Me.PRESTACION_Y_DEVOLUCIONTableAdapter.Fill(Me.BD_BIBLIOTECA_V2DataSet.PRESTACION_Y_DEVOLUCION)
                ' Recargar la tabla DETALLE (para mostrarla vacía o con los nuevos filtros)
                Me.DETALLETableAdapter.Fill(Me.BD_BIBLIOTECA_V2DataSet.DETALLE)

                ' Limpiar campos de texto (Siguiendo tu estructura)
                NumeroRegistroTextBox.Clear()
                CodLecTextBox.Clear()
                CODBIBLITextBox.Clear()

                NumDetalleTextBox.Clear()
                CantidadTextBox.Clear()
                EstadoMatTextBox.Clear()
                ObservacionesTextBox.Clear()
                MatBibTextBox.Clear()

                ' Resetear fechas a valores por defecto si es necesario

            Catch ex As Exception
                MsgBox("Error al eliminar los registros: " & ex.Message, vbCritical, "Error de Base de Datos")
            End Try

        End If
    End Sub
End Class