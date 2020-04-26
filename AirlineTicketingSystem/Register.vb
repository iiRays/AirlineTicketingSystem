Imports AirlineTicketingSystem.DB
Public Class Register
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim cust As New User
        cust.Name = txtName.Text
        cust.Email = txtEmail.Text
        cust.UserID = Quick.GenerateId(Of User)
        cust.IsStaff = False

        If rbMale.Checked Then
            cust.Gender = Convert.ToChar("M")
        ElseIf rbFemale.Checked Then
            cust.Gender = Convert.ToChar("F")
        ElseIf rbNonBinary.Checked Then
            cust.Gender = Convert.ToChar("N")
        Else
            'No gender is chosen
            Quick.ShowError("Registration Failed", "Ensure gender is selected.")
            Return
        End If

        ' Hash password
        Dim hasher = New Hash(txtPassword.Text)
        cust.Password = hasher.hashedPassword
        cust.PasswordSalt = hasher.salt

        'Generate verification code
        Dim verificationCode = Quick.GetRandomString(10)

        Try
            'Send welcome email
            Email.Send("Welcome to Ao Zora!", "Hey " & cust.Name & "! Complete your registration by entering this verification code: <br><h2>" & verificationCode & "</h2>", cust.Email)

        Catch ex As Exception
            Quick.ShowError("You're almost there!", "The email you have entered (" & cust.Email & ") is an invalid email.")
            Return
        End Try

        'Redirect

        Dim form As New VerifyEmail()
        form.User = cust
        form.Code = verificationCode
        form.RegistrationForm = Me
        form.Show()
        Me.Hide()
    End Sub

    Private Sub btnRedirect_Click(sender As Object, e As EventArgs) Handles btnRedirect.Click
        Dim form As New Login
        form.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New Login)
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        TitleBar.Load(Me)
    End Sub
End Class