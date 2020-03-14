Imports AirlineTicketingSystem.DBUtil
Public Class Register
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim cust As New Customer
        cust.Name = txtName.Text
        cust.Email = txtEmail.Text
        cust.CustomerID = "test"

        ' Hash password
        Dim hasher = New Hash(txtPassword.Text)
        cust.Password = hasher.hashedPassword
        cust.PasswordSalt = hasher.salt
        Quick.Print(cust.Password)

        Insert(cust)
    End Sub
End Class