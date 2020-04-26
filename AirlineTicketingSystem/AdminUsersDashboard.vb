Public Class AdminUsersDashboard
    Private Sub AdminUsersDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        Me.DoubleBuffered = True
        TitleBar.Load(Me, True)
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New AdminDashboard)
    End Sub

    Private Sub BtnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Quick.Navigate(Me, New AdminUsersView)
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Quick.Navigate(Me, New AdminUsersRegister)
    End Sub
End Class