Public Class frm_lector
    Private Sub LECTORBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LECTORBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_BIBLIOTECA_V2DataSet)

    End Sub

    Private Sub LECTORBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LECTORBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_BIBLIOTECA_V2DataSet)

    End Sub

    Private Sub frm_lector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_BIBLIOTECA_V2DataSet.LECTOR' table. You can move, or remove it, as needed.
        Me.LECTORTableAdapter.Fill(Me.BD_BIBLIOTECA_V2DataSet.LECTOR)

    End Sub

    Private Sub btn_nuevoL_Click(sender As Object, e As EventArgs) Handles btn_nuevoL.Click
        btn_nuevoL.Enabled = True
        btn_guardarL.Enabled = True
        btn_modificarL.Enabled = False
        btn_actualizarL.Enabled = False
        btn_eliminarL.Enabled = False
        LECTORDataGridView.Enabled = False
        CodLecTextBox.Enabled = True
        TipoLectorComboBox.Enabled = True
        NombreApellidosTextBox.Enabled = True
        TelefonoTextBox.Enabled = True
        DireccionTextBox.Enabled = True
        CorreoTextBox.Enabled = True
        EstadoTextBox.Enabled = True

        CodLecTextBox.Clear()
        TipoLectorComboBox.Items.Clear()
        NombreApellidosTextBox.Clear()
        TelefonoTextBox.Clear()
        DireccionTextBox.Clear()
        CorreoTextBox.Clear()
        EstadoTextBox.Clear()

        CodLecTextBox.Focus()
        TipoLectorComboBox.Focus()
        NombreApellidosTextBox.Focus()
        TelefonoTextBox.Focus()
        DireccionTextBox.Focus()
        CorreoTextBox.Focus()
        EstadoTextBox.Focus()
    End Sub

    Private Sub btn_guardarL_Click(sender As Object, e As EventArgs) Handles btn_guardarL.Click
        If Len(Trim(CodLecTextBox.Text)) = 0 Then
            MsgBox("Ingrese codigo", vbCritical, "Validando datos")
            CodLecTextBox.Focus()
            Exit Sub
        End If

        If Len(Trim(NombreApellidosTextBox.Text)) = 0 Then
            MsgBox("Ingrese Apellidos y Nombres", vbCritical, "Validando datos")
            NombreApellidosTextBox.Focus()
            Exit Sub
        End If

        btn_nuevoL.Enabled = True
        btn_guardarL.Enabled = False
        btn_modificarL.Enabled = True
        btn_actualizarL.Enabled = True
        btn_eliminarL.Enabled = True
        LECTORDataGridView.Enabled = True
        CodLecTextBox.Enabled = False
        TipoLectorComboBox.Enabled = False
        NombreApellidosTextBox.Enabled = False
        TelefonoTextBox.Enabled = False
        DireccionTextBox.Enabled = False
        EstadoTextBox.Enabled = False

        If MsgBox("¿Esta seguro de guardar?", vbYesNo) = vbYes Then
            Me.LECTORTableAdapter.INSERTARL(
        CodLecTextBox.Text,
        TipoLectorComboBox.Text,
        NombreApellidosTextBox.Text,
        TelefonoTextBox.Text,
        DireccionTextBox.Text,
        CorreoTextBox.Text,
        EstadoTextBox.Text
    )
            MsgBox("Bibliotecario registrado con éxito.", MsgBoxStyle.Information)
        Else
            ' ...
        End If
    End Sub

    Private Sub btn_modificarL_Click(sender As Object, e As EventArgs) Handles btn_modificarL.Click
        btn_nuevoL.Enabled = False
        btn_guardarL.Enabled = False
        btn_modificarL.Enabled = False
        btn_actualizarL.Enabled = True
        btn_eliminarL.Enabled = False
        LECTORDataGridView.Enabled = False
        CodLecTextBox.Enabled = False
        TipoLectorComboBox.Enabled = True
        NombreApellidosTextBox.Enabled = True
        TelefonoTextBox.Enabled = True
        DireccionTextBox.Enabled = True
        EstadoTextBox.Enabled = True
    End Sub

    Private Sub btn_actualizarL_Click(sender As Object, e As EventArgs) Handles btn_actualizarL.Click
        If (MsgBox("¿Estas seguro de modificar los datos?", vbYesNo, "Verificando Datos")) Then
            Me.LECTORTableAdapter.ACTUALIZARL(
            CodLecTextBox.Text,
            TipoLectorComboBox.Text,
            NombreApellidosTextBox.Text,
            TelefonoTextBox.Text,
            DireccionTextBox.Text,
            CorreoTextBox.Text,
            EstadoTextBox.Text,
            CodLecTextBox.Text)
            MsgBox("Datos del cliente actualizado con exito", vbInformation, "Insertar Datos")
            Me.LECTORTableAdapter.Fill(Me.BD_BIBLIOTECA_V2DataSet.LECTOR)
        End If

        btn_nuevoL.Enabled = True
        btn_guardarL.Enabled = True
        btn_modificarL.Enabled = True
        btn_actualizarL.Enabled = False
        btn_eliminarL.Enabled = False
        LECTORDataGridView.Enabled = True
        CodLecTextBox.Enabled = False
        TipoLectorComboBox.Enabled = False
        NombreApellidosTextBox.Enabled = False
        TelefonoTextBox.Enabled = False
        DireccionTextBox.Enabled = False
        EstadoTextBox.Enabled = False
    End Sub

    Private Sub btn_eliminarL_Click(sender As Object, e As EventArgs) Handles btn_eliminarL.Click
        Me.LECTORTableAdapter.ELIMINARL(CodLecTextBox.Text)
        Me.LECTORTableAdapter.Fill(Me.BD_BIBLIOTECA_V2DataSet.LECTOR)

        CodLecTextBox.Clear()
        TipoLectorComboBox.Items.Clear()
        NombreApellidosTextBox.Clear()
        TelefonoTextBox.Clear()
        DireccionTextBox.Clear()
        CorreoTextBox.Clear()
        EstadoTextBox.Clear()
    End Sub
End Class