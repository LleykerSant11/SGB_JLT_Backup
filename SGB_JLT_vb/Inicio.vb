Public Class Inicio
    Private Sub menu_bibbliotecario_Click(sender As Object, e As EventArgs) Handles menu_bibbliotecario.Click
        For Each frmHijo As Form In Me.MdiChildren
            frmHijo.Dispose()
        Next
        Dim frmbibliotecario As New frm_bibliotecario()
        frmbibliotecario.MdiParent = Me
        frmbibliotecario.WindowState = FormWindowState.Maximized
        frmbibliotecario.Show()
    End Sub

    Private Sub menu_lectores_Click(sender As Object, e As EventArgs) Handles menu_lectores.Click
        For Each frmHijo As Form In Me.MdiChildren
            frmHijo.Dispose()
        Next
        Dim frmblector As New frm_lector()
        frmblector.MdiParent = Me
        frmblector.WindowState = FormWindowState.Maximized
        frmblector.Show()
    End Sub

    Private Sub menu_inicio_Click(sender As Object, e As EventArgs) Handles menu_inicio.Click

        For Each frmHijo As Form In Me.MdiChildren
            frmHijo.Dispose()
        Next
        Dim frmInicio As New frm_inicio()
        frmInicio.MdiParent = Me
        frmInicio.WindowState = FormWindowState.Maximized
        frmInicio.Show()

    End Sub
    Private Sub smenu_categorias_Click(sender As Object, e As EventArgs) Handles smenu_categorias.Click
        For Each frmHijo As Form In Me.MdiChildren
            frmHijo.Dispose()
        Next
        Dim frmCategoria As New frm_tipomb()
        frmCategoria.MdiParent = Me
        frmCategoria.WindowState = FormWindowState.Maximized
        frmCategoria.Show()

    End Sub

    Private Sub smenu_matbibliografico_Click(sender As Object, e As EventArgs) Handles smenu_matbibliografico.Click
        For Each frmHijo As Form In Me.MdiChildren
            frmHijo.Dispose()
        Next
        Dim frmmtbibliografico As New frm_mtbibliografico()
        frmmtbibliografico.MdiParent = Me
        frmmtbibliografico.WindowState = FormWindowState.Maximized
        frmmtbibliografico.Show()
    End Sub

    Private Sub sm_prestacion_Click(sender As Object, e As EventArgs) Handles sm_prestacion.Click
        For Each frmHijo As Form In Me.MdiChildren
            frmHijo.Dispose()
        Next
        Dim frmmtprestadev As New frm_prestadevol()
        frmmtprestadev.MdiParent = Me
        frmmtprestadev.WindowState = FormWindowState.Maximized
        frmmtprestadev.Show()
    End Sub

    Private Sub DetalleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetalleToolStripMenuItem.Click
        For Each frmHijo As Form In Me.MdiChildren
            frmHijo.Dispose()
        Next
        Dim frmmtprestdet As New frm_prestdet()
        frmmtprestdet.MdiParent = Me
        frmmtprestdet.WindowState = FormWindowState.Maximized
        frmmtprestdet.Show()
    End Sub
End Class