Public Class Login
    Private Sub btnRedirect_Click(sender As Object, e As EventArgs) Handles btnRedirect.Click
        Dim form As New Register
        form.Show()
        Me.Close()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Get customer based on email
        Dim cResult = From cust In DBUtil.db.Customers
                      Where cust.Email = txtEmail.Text


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
                Quick.Print("Login is successful.")
            End If
        End If
    End Sub
End Class