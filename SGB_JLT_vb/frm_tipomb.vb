Imports System.Data.SqlClient
Public Class frm_tipomb


    Private Sub lb_detusuario_Click(sender As Object, e As EventArgs) Handles lb_detusuario.Click

    End Sub

    Private Sub TIPO_M_BIBLIOGRAFICOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TIPO_M_BIBLIOGRAFICOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_BIBLIOTECA_V2DataSet)

    End Sub

    Private Sub frm_tipomb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_BIBLIOTECA_V2DataSet.TIPO_M_BIBLIOGRAFICO' table. You can move, or remove it, as needed.
        Me.TIPO_M_BIBLIOGRAFICOTableAdapter.Fill(Me.BD_BIBLIOTECA_V2DataSet.TIPO_M_BIBLIOGRAFICO)


    End Sub

    Private Sub btn_nuevoTMB_Click(sender As Object, e As EventArgs) Handles btn_nuevoTMB.Click
        btn_nuevoTMB.Enabled = True
        btn_guardarTMB.Enabled = True
        btn_modificarTMB.Enabled = False
        btn_actualizarTMB.Enabled = False
        btn_eliminarTMB.Enabled = False
        TIPO_M_BIBLIOGRAFICODataGridView.Enabled = False
        TipoMBTextBox.Enabled = True
        DescripcionTextBox.Enabled = True
        SiglasTextBox.Enabled = True

        TipoMBTextBox.Clear()
        DescripcionTextBox.Clear()
        SiglasTextBox.Clear()

        TipoMBTextBox.Focus()
        DescripcionTextBox.Focus()
        SiglasTextBox.Focus()
    End Sub

    Private Sub btn_guardarTMB_Click(sender As Object, e As EventArgs) Handles btn_guardarTMB.Click
        If Len(Trim(TipoMBTextBox.Text)) = 0 Then
            MsgBox("Ingrese codigo", vbCritical, "Validando datos")
            TipoMBTextBox.Focus()
            Exit Sub
        End If

        If Len(Trim(DescripcionTextBox.Text)) = 0 Then
            MsgBox("Ingrese Apellidos y Nombres", vbCritical, "Validando datos")
            DescripcionTextBox.Focus()
            Exit Sub
        End If

        btn_nuevoTMB.Enabled = True
        btn_guardarTMB.Enabled = False
        btn_modificarTMB.Enabled = True
        btn_actualizarTMB.Enabled = True
        btn_eliminarTMB.Enabled = True
        TIPO_M_BIBLIOGRAFICODataGridView.Enabled = True
        TipoMBTextBox.Enabled = False
        DescripcionTextBox.Enabled = False
        SiglasTextBox.Enabled = False


        If MsgBox("¿Esta seguro de guardar?", vbYesNo) = vbYes Then
            Me.TIPO_M_BIBLIOGRAFICOTableAdapter.INSERTARTMB(
        TipoMBTextBox.Text,
        DescripcionTextBox.Text,
        SiglasTextBox.Text
    )
            MsgBox("Bibliotecario registrado con éxito.", MsgBoxStyle.Information)
        Else
            ' ...
        End If
    End Sub

    Private Sub btn_modificarTMB_Click(sender As Object, e As EventArgs) Handles btn_modificarTMB.Click
        btn_nuevoTMB.Enabled = False
        btn_guardarTMB.Enabled = False
        btn_modificarTMB.Enabled = False
        btn_actualizarTMB.Enabled = True
        btn_eliminarTMB.Enabled = False
        TIPO_M_BIBLIOGRAFICODataGridView.Enabled = False
        TipoMBTextBox.Enabled = False
        DescripcionTextBox.Enabled = True
        SiglasTextBox.Enabled = True
    End Sub

    Private Sub btn_actualizarTMB_Click(sender As Object, e As EventArgs) Handles btn_actualizarTMB.Click
        If (MsgBox("¿Estas seguro de modificar los datos?", vbYesNo, "Verificando Datos")) Then
            Me.TIPO_M_BIBLIOGRAFICOTableAdapter.ACTUALIZARTMB(
            TipoMBTextBox.Text,
            DescripcionTextBox.Text,
            SiglasTextBox.Text,
            0)
            MsgBox("Datos del cliente actualizado con exito", vbInformation, "Insertar Datos")
            Me.TIPO_M_BIBLIOGRAFICOTableAdapter.Fill(Me.BD_BIBLIOTECA_V2DataSet.TIPO_M_BIBLIOGRAFICO)
        End If

        btn_nuevoTMB.Enabled = True
        btn_guardarTMB.Enabled = True
        btn_modificarTMB.Enabled = True
        btn_actualizarTMB.Enabled = False
        btn_eliminarTMB.Enabled = False
        TIPO_M_BIBLIOGRAFICODataGridView.Enabled = True
        TipoMBTextBox.Enabled = False
        DescripcionTextBox.Enabled = False
        SiglasTextBox.Enabled = False

    End Sub

    Private Sub btn_eliminarTMB_Click(sender As Object, e As EventArgs) Handles btn_eliminarTMB.Click
        Me.TIPO_M_BIBLIOGRAFICOTableAdapter.ELIMINARTMB(TipoMBTextBox.Text)
        Me.TIPO_M_BIBLIOGRAFICOTableAdapter.Fill(Me.BD_BIBLIOTECA_V2DataSet.TIPO_M_BIBLIOGRAFICO)

        TipoMBTextBox.Clear()
        DescripcionTextBox.Clear()
        SiglasTextBox.Clear()
    End Sub


    Private Sub txt_buscaTMBI_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class