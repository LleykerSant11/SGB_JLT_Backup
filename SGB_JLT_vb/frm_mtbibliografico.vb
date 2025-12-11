Public Class frm_mtbibliografico
    Private Sub MATERIAL_BIBLIOGRAFICOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MATERIAL_BIBLIOGRAFICOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_BIBLIOTECA_V2DataSet)

    End Sub

    Private Sub frm_mtbibliografico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_BIBLIOTECA_V2DataSet.MATERIAL_BIBLIOGRAFICO' table. You can move, or remove it, as needed.
        Me.MATERIAL_BIBLIOGRAFICOTableAdapter.Fill(Me.BD_BIBLIOTECA_V2DataSet.MATERIAL_BIBLIOGRAFICO)

    End Sub

    Private Sub btn_nuevoMB_Click(sender As Object, e As EventArgs) Handles btn_nuevoMB.Click
        btn_nuevoMB.Enabled = True
        btn_guardarMB.Enabled = True
        btn_modificarMB.Enabled = False
        btn_actualizarMB.Enabled = False
        btn_eliminarMB.Enabled = False
        MATERIAL_BIBLIOGRAFICODataGridView.Enabled = False
        MatBibTextBox.Enabled = True
        TipoMBTextBox.Enabled = True
        NombreTextBox.Enabled = True
        EditorialTextBox.Enabled = True
        AutorTextBox.Enabled = True
        FechAdquisicionDateTimePicker.Enabled = True
        FormatoTextBox.Enabled = True
        EstadoTextBox.Enabled = True
        EjemplaresTextBox.Enabled = True

        MatBibTextBox.Clear()
        TipoMBTextBox.Clear()
        NombreTextBox.Clear()
        EditorialTextBox.Clear()
        AutorTextBox.Clear()
        FormatoTextBox.Clear()
        EstadoTextBox.Clear()
        EjemplaresTextBox.Enabled = True

        MatBibTextBox.Focus()
        TipoMBTextBox.Focus()
        NombreTextBox.Focus()
        EditorialTextBox.Focus()
        AutorTextBox.Focus()
        FechAdquisicionDateTimePicker.Focus()
        FormatoTextBox.Focus()
        EstadoTextBox.Focus()
        EjemplaresTextBox.Focus()
    End Sub

    Private Sub btn_guardarMB_Click(sender As Object, e As EventArgs) Handles btn_guardarMB.Click
        If Len(Trim(MatBibTextBox.Text)) = 0 Then
            MsgBox("Ingrese codigo", vbCritical, "Validando datos")
            MatBibTextBox.Focus()
            Exit Sub
        End If

        If Len(Trim(NombreTextBox.Text)) = 0 Then
            MsgBox("Ingrese Apellidos y Nombres", vbCritical, "Validando datos")
            NombreTextBox.Focus()
            Exit Sub
        End If

        btn_nuevoMB.Enabled = True
        btn_guardarMB.Enabled = False
        btn_modificarMB.Enabled = True
        btn_actualizarMB.Enabled = True
        btn_eliminarMB.Enabled = True
        MATERIAL_BIBLIOGRAFICODataGridView.Enabled = True
        MatBibTextBox.Enabled = False
        TipoMBTextBox.Enabled = False
        NombreTextBox.Enabled = False
        EditorialTextBox.Enabled = False
        AutorTextBox.Enabled = False
        FechAdquisicionDateTimePicker.Enabled = False
        FormatoTextBox.Enabled = False
        EstadoTextBox.Enabled = False
        EjemplaresTextBox.Enabled = False

        If MsgBox("¿Esta seguro de guardar?", vbYesNo) = vbYes Then
            Me.MATERIAL_BIBLIOGRAFICOTableAdapter.INSERTARMB(
        MatBibTextBox.Text,
        TipoMBTextBox.Text,
        NombreTextBox.Text,
        EditorialTextBox.Text,
        AutorTextBox.Text,
        FechAdquisicionDateTimePicker.Text,
        FormatoTextBox.Text,
        EstadoTextBox.Text,
        EjemplaresTextBox.Text
    )
            MsgBox("Bibliotecario registrado con éxito.", MsgBoxStyle.Information)
        Else
            ' ...
        End If
    End Sub
End Class