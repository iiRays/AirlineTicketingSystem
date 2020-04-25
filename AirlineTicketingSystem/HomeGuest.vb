Public Class HomeGuest
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim form As New Login
        form.Show()
        Me.Close()

    End Sub

    Private Sub BtnFlights_Click(sender As Object, e As EventArgs) Handles btnFlights.Click
        Quick.Navigate(Me, New FlightSearch)
    End Sub

    Private Sub HomeGuest_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Quick.SetFormFont("Poppins", Me)
        Me.DoubleBuffered = True
        TitleBar.Load(Me, True, True)
    End Sub

    Private Sub btnBookingSearch_Click(sender As Object, e As EventArgs) Handles btnBookingSearch.Click
        Quick.Navigate(Me, New BookingSearch)
    End Sub
End Class