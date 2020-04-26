Public Class AdminFlightsDashboard
    Private Sub AdminFlightsDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        Me.DoubleBuffered = True
        TitleBar.Load(Me, True)
    End Sub
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New AdminDashboard)
    End Sub

    Private Sub BtnFlights_Click(sender As Object, e As EventArgs) Handles btnFlights.Click
        Quick.Navigate(Me, New AdminFlightsAdd1)
    End Sub

    Private Sub BtnRoutes_Click(sender As Object, e As EventArgs) Handles btnRoutes.Click
        Quick.Navigate(Me, New AdminFlightsView)
    End Sub
End Class