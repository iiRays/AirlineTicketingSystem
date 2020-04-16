Public Class HomeAdmin
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Quick.Navigate(Me, New AdminDashboard)
    End Sub

    Private Sub btnFlights_Click(sender As Object, e As EventArgs) Handles btnFlights.Click
        Quick.Navigate(Me, New AdminFlightList)
    End Sub

    Private Sub HomeAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleBar.Load(Me)
    End Sub
End Class