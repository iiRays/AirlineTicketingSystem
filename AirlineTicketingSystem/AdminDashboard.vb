Public Class AdminDashboard
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)
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
        'Quick.Navigate(Me, New ???)
    End Sub
End Class