Public Class AdminUsersRegister
    Private Sub AdminUsersRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New AdminUsersDashboard)
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim user As User
        user.UserID = Quick.GenerateId(Of User)
        user.Name = txtName.Text
        user.Email = txtEmail.Text
        Dim hasher = New Hash(txtPassword.Text)
        user.Password = hasher.hashedPassword
        user.PasswordSalt = hasher.salt
        If rbMale.Checked Then
            user.Gender = Convert.ToChar("M")
        ElseIf rbFemale.Checked Then
            user.Gender = Convert.ToChar("F")
        ElseIf rbNonBinary.Checked Then
            user.Gender = Convert.ToChar("N")
        End If

        DB.Insert(user)

        App.Session.Set("user", user)

        Quick.Navigate(Me, New AdminUsersRegisterSummary)
    End Sub
End Class