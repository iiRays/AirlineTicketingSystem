Public Class Login
    Private Sub btnRedirect_Click(sender As Object, e As EventArgs) Handles btnRedirect.Click
        Quick.Navigate(Me, New Register)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Get user based on email
        Dim cResult = From cust In DB.context.Users
                      Where cust.Email = txtEmail.Text And cust.Password IsNot Nothing


        If cResult.Count = 0 Then
            Quick.ShowError("Login error", "Such user does not exist.")
        ElseIf cResult.Count > 1 Then
            Throw New Exception("Multiple users with the same email.")
        Else
            'Compare password
            If Not Hash.Compare(txtPassword.Text, cResult.First().Password, cResult.First().PasswordSalt) Then
                Quick.ShowError("Login error", "Password is incorrect")
            Else
                'Perform login
                App.User = cResult.First()
                Quick.Print("Login is successful.")
                Dim form As New HomeUser
                form.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New HomeGuest)
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleBar.Load(Me)
    End Sub
End Class