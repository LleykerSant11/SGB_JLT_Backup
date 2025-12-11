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
        Dim frmCategoria As New frm_inventario()
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
End Class