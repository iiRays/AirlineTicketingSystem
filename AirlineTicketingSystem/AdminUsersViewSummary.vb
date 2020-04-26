Public Class AdminUsersViewSummary
    Private user As User = App.Session.Get("user")
    Private Sub AdminUsersViewSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)

        lblId.Text = user.UserID
        lblName.Text = user.Name
        lblGender.Text = user.Gender.ToString()
        lblEmail.Text = user.Email
        lblIsRegistered.Text = user.IsRegistered.ToString()
        lblDateOfBirth.Text = If(user.DateOfBirth IsNot Nothing, user.DateOfBirth, "N/A")
        lblPhoneNo.Text = If(user.PhoneNo IsNot Nothing, user.PhoneNo, "N/A")
        lblCreditCardNo.Text = If(user.CreditCardNo IsNot Nothing, user.CreditCardNo, "N/A")
        lblCountry.Text = If(user.Country IsNot Nothing, user.Country, "N/A")
        lblCity.Text = If(user.City IsNot Nothing, user.City, "N/A")
        lblIsStaff.Text = user.IsStaff.ToString()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        App.Session.Delete("user")
        Quick.Navigate(Me, New AdminUsersViewResults)
    End Sub
End Class