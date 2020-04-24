Public Class Account
    Private Sub Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleBar.Load(Me)
        Dim user = If(App.User Is Nothing, App.User, App.User)

        With user
            txtName.Text = If(user IsNot Nothing AndAlso .Name IsNot Nothing, .Name, "")
            txtEmail.Text = If(user IsNot Nothing AndAlso .Email IsNot Nothing, .Email, "")
            txtCity.Text = If(user IsNot Nothing AndAlso .City IsNot Nothing, .City, "")
            txtCountry.Text = If(user IsNot Nothing AndAlso .Country IsNot Nothing, .Country, "")
            dtpDate.Value = If(user IsNot Nothing AndAlso .DateOfBirth IsNot Nothing, .DateOfBirth, DateAndTime.Now())
            txtCreditCardNo.Text = If(user IsNot Nothing AndAlso .CreditCardNo IsNot Nothing, .CreditCardNo, "")
            lblFlightHours.Text = GetTotalFlightHours()
        End With

        If user IsNot Nothing Then
            With user
                If .Gender = "M" Then
                    rbMale.Checked = True
                ElseIf .Gender = "F" Then
                    rbFemale.Checked = True
                Else
                    .Gender = "N"
                End If
            End With
        Else
            rbMale.Checked = True
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New HomeUser)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim errorStr As New System.Text.StringBuilder()

        'Validate
        errorStr.AppendLine(If(txtName.Text = "", "- Please enter a name", ""))
        errorStr.AppendLine(If(txtEmail.Text = "", "- Please enter an email", ""))
        errorStr.AppendLine(If(txtCity.Text = "", "- Please enter the city for your address", ""))
        errorStr.AppendLine(If(txtCountry.Text = "", "- Please enter the country for your address", ""))
        errorStr.AppendLine(If(Not Quick.CheckRegex("[0-9]{4}\-[0-9]{4}\-[0-9]{4}\-[0-9]{4}", txtCreditCardNo.Text), "- Ensure that your credit card number is following this format: XXXX-XXXX-XXXX-XXXX.", ""))

        'Must be 18 years old or above
        Dim birthdate = New Date(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day)
        errorStr.AppendLine(If(DateAndTime.DateDiff(DateInterval.Year, birthdate, DateAndTime.Now()) < 18, "- You must be 18 years old or above", ""))


        If errorStr.ToString.Trim.Length > 0 Then
            'Has error
            Quick.ShowError("Incorrect fields", errorStr.ToString().Trim)
            Return
        Else
            If Not App.IsLoggedIn Then
                App.User = New User()
            End If
            With App.User
                .Name = txtName.Text
                .Email = txtEmail.Text
                .CreditCardNo = txtCreditCardNo.Text
                .City = txtCity.Text
                .Country = txtCountry.Text
                .DateOfBirth = dtpDate.Value

                If rbMale.Checked Then
                    .Gender = "M"
                ElseIf rbFemale.Checked Then
                    .Gender = "F"
                Else
                    .Gender = "N"
                End If
            End With

            DB.Update(App.User, App.User.UserID)
            Quick.Navigate(Me, New HomeUser)
        End If
    End Sub

    Public Function GetTotalFlightHours() As Integer
        Dim hours = 0
        For Each booking In App.User.Bookings
            ' Get the difference in hours between flight departure & arrival
            hours += DateAndTime.DateDiff(DateInterval.Hour, booking.Flight.DepartureTime, booking.Flight.ArrivalTime)
        Next

        Return hours
    End Function
End Class