Public Class AdminUsersRegister
    Private Sub AdminUsersRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        Me.DoubleBuffered = True
        TitleBar.Load(Me, True)
        rbMale.Checked = True
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New AdminUsersDashboard)
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim passwordText As String = txtPassword.Text

        Dim errors As New List(Of String)
        Dim errorsFound As Boolean = False

        If String.IsNullOrEmpty(name) Then
            errors.Add("- [Name] must not be empty.")
        End If

        If String.IsNullOrEmpty(email) Then
            errors.Add("- [Email] must not be empty.")
        End If

        If String.IsNullOrEmpty(passwordText) Then
            errors.Add("- [Password] must not be empty.")
        End If

        If Not errors.Count = 0 Then
            errorsFound = True
        End If

        If Not errorsFound Then
            Dim user As New User
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
            user.IsRegistered = True
            user.IsStaff = True

            DB.Insert(user)

            App.Session.Set("user", user)

            Quick.Navigate(Me, New AdminUsersRegisterSummary)
        Else
            Quick.ShowErrors("Errors found!", errors)
        End If
    End Sub
End Class