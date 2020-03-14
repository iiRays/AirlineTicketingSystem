Imports AirlineTicketingSystem.DBUtil
Public Class Register
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim cust As New Customer
        cust.Name = txtName.Text
        cust.Email = txtEmail.Text
        cust.CustomerID = Quick.GenerateId(Of Customer)

        If rbMale.Checked Then
            cust.Gender = Convert.ToChar("M")
        ElseIf rbFemale.Checked Then
            cust.Gender = Convert.ToChar("F")
        ElseIf rbNonBinary.Checked Then
            cust.Gender = Convert.ToChar("N")
        Else
            'No gender is chosen
            Quick.ShowError("Registration Failed", "Ensure gender is selected.")
        End If

        ' Hash password
        Dim hasher = New Hash(txtPassword.Text)
        cust.Password = hasher.hashedPassword
        cust.PasswordSalt = hasher.salt

        Insert(cust)
    End Sub

    Private Sub btnRedirect_Click(sender As Object, e As EventArgs) Handles btnRedirect.Click
        Dim form As New Login
        form.Show()
        Me.Close()
    End Sub
End Class