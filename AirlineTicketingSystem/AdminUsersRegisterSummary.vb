Public Class AdminUsersRegisterSummary
    Private user As User = App.Session.Get("user")
    Private Sub AdminUsersRegisterSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        Me.DoubleBuffered = True
        TitleBar.Load(Me, True)

        lblId.Text = user.UserID
        lblName.Text = user.Name
        lblGender.Text = user.Gender.ToString()
        lblEmail.Text = user.Email
        lblIsRegistered.Text = user.IsRegistered.ToString()
        lblIsStaff.Text = user.IsStaff.ToString()
    End Sub

    Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        DB.Delete(user)
        App.Session.Delete("user")
        Quick.Navigate(Me, New AdminUsersDashboard)
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        App.Session.Delete("user")
        Quick.Navigate(Me, New AdminUsersDashboard)
    End Sub
End Class