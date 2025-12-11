Public Class frm_bibliotecario
    Private Sub pn_container_Paint(sender As Object, e As PaintEventArgs) Handles pn_container.Paint

    End Sub

    Private Sub BIBLIOTECARIOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BIBLIOTECARIOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_BIBLIOTECA_V2DataSet)

    End Sub

    Private Sub frm_bibliotecario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_BIBLIOTECA_V2DataSet.BIBLIOTECARIO' table. You can move, or remove it, as needed.
        Me.BIBLIOTECARIOTableAdapter.Fill(Me.BD_BIBLIOTECA_V2DataSet.BIBLIOTECARIO)

    End Sub

    Private Sub btn_nuevoB_Click(sender As Object, e As EventArgs) Handles btn_nuevoB.Click
        btn_nuevoB.Enabled = True
        btn_guardarB.Enabled = True
        btn_modificarB.Enabled = False
        btn_actualizarB.Enabled = False
        btn_eliminarB.Enabled = False
        BIBLIOTECARIODataGridView.Enabled = False
        CODBIBLITextBox.Enabled = True
        NombreApellidosTextBox.Enabled = True
        TelefonoTextBox.Enabled = True
        DireccionTextBox.Enabled = True
        ClaveTextBox.Enabled = True
        CorreoTextBox.Enabled = True
        EstadoTextBox.Enabled = True
        UsuarioTextBox.Enabled = True


        CODBIBLITextBox.Clear()
        NombreApellidosTextBox.Clear()
        TelefonoTextBox.Clear()
        DireccionTextBox.Clear()
        CorreoTextBox.Clear()
        ClaveTextBox.Clear()
        EstadoTextBox.Clear()
        UsuarioTextBox.Clear()

        CODBIBLITextBox.Focus()
        NombreApellidosTextBox.Focus()
        TelefonoTextBox.Focus()
        DireccionTextBox.Focus()
        ClaveTextBox.Focus()
        CorreoTextBox.Focus()
        EstadoTextBox.Focus()
        UsuarioTextBox.Focus()
    End Sub

    Private Sub btn_guardarB_Click(sender As Object, e As EventArgs) Handles btn_guardarB.Click
        If Len(Trim(CODBIBLITextBox.Text)) = 0 Then
            MsgBox("Ingrese codigo", vbCritical, "Validando datos")
            CODBIBLITextBox.Focus()
            Exit Sub
        End If

        If Len(Trim(NombreApellidosTextBox.Text)) = 0 Then
            MsgBox("Ingrese Apellidos y Nombres", vbCritical, "Validando datos")
            NombreApellidosTextBox.Focus()
            Exit Sub
        End If

        btn_nuevoB.Enabled = True
        btn_guardarB.Enabled = False
        btn_modificarB.Enabled = True
        btn_actualizarB.Enabled = True
        btn_eliminarB.Enabled = True
        BIBLIOTECARIODataGridView.Enabled = True
        CODBIBLITextBox.Enabled = False
        NombreApellidosTextBox.Enabled = False
        TelefonoTextBox.Enabled = False
        DireccionTextBox.Enabled = False
        ClaveTextBox.Enabled = False
        EstadoTextBox.Enabled = False
        UsuarioTextBox.Enabled = False

        If MsgBox("¿Esta seguro de guardar?", vbYesNo) = vbYes Then
            Me.BIBLIOTECARIOTableAdapter.INSERTARB(
        CODBIBLITextBox.Text,
        NombreApellidosTextBox.Text,
        TelefonoTextBox.Text,
        DireccionTextBox.Text,
        ClaveTextBox.Text,
        CorreoTextBox.Text,
        EstadoTextBox.Text,
        UsuarioTextBox.Text
    )
            MsgBox("Bibliotecario registrado con éxito.", MsgBoxStyle.Information)
        Else
            ' ...
        End If
    End Sub

    Private Sub btn_modificarB_Click(sender As Object, e As EventArgs) Handles btn_modificarB.Click
        btn_nuevoB.Enabled = False
        btn_guardarB.Enabled = False
        btn_modificarB.Enabled = False
        btn_actualizarB.Enabled = True
        btn_eliminarB.Enabled = False
        BIBLIOTECARIODataGridView.Enabled = False
        CODBIBLITextBox.Enabled = False
        NombreApellidosTextBox.Enabled = True
        TelefonoTextBox.Enabled = True
        DireccionTextBox.Enabled = True
        ClaveTextBox.Enabled = True
        EstadoTextBox.Enabled = True
        UsuarioTextBox.Enabled = True
    End Sub

    Private Sub btn_actualizarB_Click(sender As Object, e As EventArgs) Handles btn_actualizarB.Click
        If (MsgBox("¿Estas seguro de modificar los datos?", vbYesNo, "Verificando Datos")) Then
            Me.BIBLIOTECARIOTableAdapter.ACTUALIZARB(
            CODBIBLITextBox.Text,
            NombreApellidosTextBox.Text,
            TelefonoTextBox.Text,
            DireccionTextBox.Text,
            ClaveTextBox.Text,
            CorreoTextBox.Text,
            EstadoTextBox.Text,
            UsuarioTextBox.Text,
            CODBIBLITextBox.Text)
            MsgBox("Datos del cliente actualizado con exito", vbInformation, "Insertar Datos")
            Me.BIBLIOTECARIOTableAdapter.Fill(Me.BD_BIBLIOTECA_V2DataSet.BIBLIOTECARIO)
        End If

        btn_nuevoB.Enabled = True
        btn_guardarB.Enabled = True
        btn_modificarB.Enabled = True
        btn_actualizarB.Enabled = False
        btn_eliminarB.Enabled = False
        BIBLIOTECARIODataGridView.Enabled = True
        CODBIBLITextBox.Enabled = False
        NombreApellidosTextBox.Enabled = False
        TelefonoTextBox.Enabled = False
        DireccionTextBox.Enabled = False
        ClaveTextBox.Enabled = False
        EstadoTextBox.Enabled = False
        UsuarioTextBox.Enabled = False
    End Sub

    Private Sub btn_eliminarB_Click(sender As Object, e As EventArgs) Handles btn_eliminarB.Click
        Me.BIBLIOTECARIOTableAdapter.ELIMINARB(CODBIBLITextBox.Text)
        Me.BIBLIOTECARIOTableAdapter.Fill(Me.BD_BIBLIOTECA_V2DataSet.BIBLIOTECARIO)

        CODBIBLITextBox.Clear()
        NombreApellidosTextBox.Clear()
        TelefonoTextBox.Clear()
        DireccionTextBox.Clear()
        CorreoTextBox.Clear()
        ClaveTextBox.Clear()
        EstadoTextBox.Clear()
        UsuarioTextBox.Clear()
    End Sub
End Class