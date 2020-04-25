Public Class AdminDashboard
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True)
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New HomeAdmin)
    End Sub

    Private Sub BtnFlights_Click(sender As Object, e As EventArgs) Handles btnFlights.Click
        Quick.Navigate(Me, New AdminFlightsDashboard)
    End Sub

    Private Sub BtnRoutes_Click(sender As Object, e As EventArgs) Handles btnRoutes.Click
        Quick.Navigate(Me, New AdminRoutesDashboard)
    End Sub

    Private Sub BtnCities_Click(sender As Object, e As EventArgs) Handles btnCities.Click
        Quick.Navigate(Me, New AdminCitiesDashboard)
    End Sub

    Private Sub BtnPlanes_Click(sender As Object, e As EventArgs) Handles btnPlanes.Click
        Quick.Navigate(Me, New AdminPlanesDashboard)
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Quick.Navigate(Me, New AdminReport)
    End Sub

    Private Sub BtnBookings_Click(sender As Object, e As EventArgs) Handles btnBookings.Click
        Quick.Navigate(Me, New AdminBookingsDashboard)
    End Sub

    Private Sub BtnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Quick.Navigate(Me, New AdminUsersDashboard)
    End Sub
End Class