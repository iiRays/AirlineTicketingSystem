Public Class AdminUsersRegister
    Private Sub AdminUsersRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New AdminUsersDashboard)
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim passwordText As String = txtPassword.Text

        Dim errorMsg As String = ""
        Dim errorsFound As Boolean = False

        If String.IsNullOrEmpty(name) Then
            errorMsg += "- [Name] must not be empty." & vbNewLine
        End If

        If String.IsNullOrEmpty(email) Then
            errorMsg += "- [Email] must not be empty." & vbNewLine
        End If

        If String.IsNullOrEmpty(passwordText) Then
            errorMsg += "- [Password] must not be empty." & vbNewLine
        End If

        If Not errorMsg = "" Then
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
            MessageBox.Show("Errors found:" & vbNewLine & errorMsg, "Errors found!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class