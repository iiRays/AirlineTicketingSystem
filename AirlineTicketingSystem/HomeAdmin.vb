Public Class HomeAdmin
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Quick.Navigate(Me, New AdminDashboard)
    End Sub

    Private Sub btnFlights_Click(sender As Object, e As EventArgs) Handles btnFlights.Click
        Quick.Navigate(Me, New FlightSearch)
    End Sub

    Private Sub HomeAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        TitleBar.Load(Me)
    End Sub

    Private Sub BtnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        Quick.Navigate(Me, New Account)
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

    End Sub
End Class