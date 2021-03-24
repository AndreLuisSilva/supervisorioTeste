Public Class Frm_menu
    Private Sub Frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dlg As New Frm_splash
        dlg.ShowDialog()
    End Sub
End Class
