Public Class BookPayerInfo
    Public BookFlightForm As BookFlight1
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim errorStr As New System.Text.StringBuilder()

        'Validate
        errorStr.AppendLine(If(txtName.Text = "", "- Please enter a name", ""))
        errorStr.AppendLine(If(txtEmail.Text = "", "- Please enter an email", ""))
        errorStr.AppendLine(If(txtCity.Text = "", "- Please enter the city for your address", ""))
        errorStr.AppendLine(If(txtCountry.Text = "", "- Please enter the country for your address", ""))
        errorStr.AppendLine(If(Not Quick.CheckRegex("[0-9]{4}\-[0-9]{4}\-[0-9]{4}\-[0-9]{4}", txtCard.Text), "- Ensure that your credit card number is following this format: XXXX-XXXX-XXXX-XXXX.", ""))
        errorStr.AppendLine(If(Quick.HasInvalidChar(txtName.Text), "- Name must contain alphabets only", ""))
        'Must be 18 years old or above
        Dim birthdate = New Date(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day)
        errorStr.AppendLine(If(DateAndTime.DateDiff(DateInterval.Year, birthdate, DateAndTime.Now()) < 18, "- You must be 18 years old or above", ""))


        If errorStr.ToString.Trim.Length > 0 Then
            'Has error
            Quick.ShowError("Incorrect fields", errorStr.ToString().Trim)
            Return
        Else
            If Not App.IsLoggedIn Then
                BookFlightForm.User = New User()
            End If
            With BookFlightForm.User
                .Name = txtName.Text
                .Email = txtEmail.Text
                .CreditCardNo = txtCard.Text
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


            BookFlightForm.UpdateLabel()
            Me.Close()
        End If
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged

    End Sub

    Private Sub BookPayerInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        TitleBar.Load(Me)
        Dim user = If(BookFlightForm.User Is Nothing, App.User, BookFlightForm.User)

        With user
            txtName.Text = If(user IsNot Nothing AndAlso .Name IsNot Nothing, .Name, "")
            txtEmail.Text = If(user IsNot Nothing AndAlso .Email IsNot Nothing, .Email, "")
            txtCard.Text = If(user IsNot Nothing AndAlso .CreditCardNo IsNot Nothing, .CreditCardNo, "")
            txtCity.Text = If(user IsNot Nothing AndAlso .City IsNot Nothing, .City, "")
            txtCountry.Text = If(user IsNot Nothing AndAlso .Country IsNot Nothing, .Country, "")
            dtpDate.Value = If(user IsNot Nothing AndAlso .DateOfBirth IsNot Nothing, .DateOfBirth, DateAndTime.Now())
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
End Class