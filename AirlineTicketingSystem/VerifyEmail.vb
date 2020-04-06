Public Class VerifyEmail
    Public Code As String
    Public User As User
    Public RegistrationForm As Register
    Private Timeout
    Private TimeoutTimer As New Windows.Forms.Timer()
    Private Sub VerifyEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblEmail.Text = "Sent to " & User.Email
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click

        If txtCode.Text.Length > 0 AndAlso txtCode.Text = Code Then
            'Code is correct
            DB.Insert(User)

            'Send welcome email
            Email.Send("Welcome to Ao Zora!", "Hey " & User.Name & "! Welcome to your new journey with us across the blue (ao) skies (zora). We hope you will have a great time with us.", User.Email)
            RegistrationForm.Close()
            Quick.Navigate(Me, New Login)
        Else
            Quick.ShowError("Invalid code", "The verification code that you have entered is incorrect.")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Quick.Navigate(Me, RegistrationForm)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Email.Send("You're almost there!", "Hey " & User.Name & "! Complete your registration by entering this verification code: <br><h2>" & Code & "</h2>", User.Email)
        TimeoutTimer.Interval = 1000
        Timeout = 60
        btnReset.BackColor = Color.Gray
        btnReset.Enabled = False
        AddHandler TimeoutTimer.Tick, AddressOf ShowCountDown
        TimeoutTimer.Start()
    End Sub

    Private Sub ShowCountDown()
        If Timeout <= 0 Then
            TimeoutTimer.Stop()
            btnReset.Text = "resend"
            btnReset.BackColor = Color.FromArgb(149, 190, 201)
            btnReset.Enabled = True
            TimeoutTimer = New Windows.Forms.Timer()
        Else
            Timeout -= 1
            btnReset.Text = "resend  (" & Timeout & ")"
        End If
    End Sub
End Class