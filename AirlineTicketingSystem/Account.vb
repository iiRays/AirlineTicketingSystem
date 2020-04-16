Public Class Account
    Private Sub Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleBar.Load(Me)

        'Get user detail
        txtName.Text &= App.User.Name

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New HomeUser)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim user = DB.Get(Of User)(App.User.UserID)
        user.name = txtName.Text
        user.password = txtPassword.Text
        user.email = txtEmail.Text
        user.dateOfBirth = txtDate.Text
        user.creditCardNo = txtCreditCardNo.Text
        user.country = txtCountry.Text
        user.city = txtCity.Text
        'DB.Update(Of User)(App.User)
        'App.User = updateUser
    End Sub
End Class