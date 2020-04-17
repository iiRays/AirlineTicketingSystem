Public Class HomeGuest
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim form As New Login
        form.Show()
        Me.Close()

    End Sub

    Private Sub BtnFlights_Click(sender As Object, e As EventArgs) Handles btnFlights.Click
        Dim flightList As New FlightList
        flightList.Show()
        Me.Close()
    End Sub

    Private Sub HomeGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)

        TitleBar.Load(Me, True, False)
    End Sub

    Private Sub btnBookingSearch_Click(sender As Object, e As EventArgs) Handles btnBookingSearch.Click
        Quick.Navigate(Me, New BookingSearch)
    End Sub

End Class