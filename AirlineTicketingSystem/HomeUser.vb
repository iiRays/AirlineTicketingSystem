Public Class HomeUser
    Private Sub btnFlights_Click(sender As Object, e As EventArgs) Handles btnFlights.Click
        Quick.Navigate(Me, New FlightList)
    End Sub

    Private Sub HomeUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text &= App.GetUser().Name
        TitleBar.Load(Me)
    End Sub


    Private Sub loginMsg_Click(sender As Object, e As EventArgs) Handles lblLoginMsg.Click

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        App.Session.Clear()
        Quick.Navigate(Me, New HomeGuest)
    End Sub
End Class