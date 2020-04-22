Public Class BookingViewItem
    Public Booking As Booking
    Public AdminBookingsViewResults As AdminBookingsViewResults
    Private Sub BookingViewItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblId.Text = Booking.BookingID
        lblFlightNo.Text = Booking.Flight.FlightNo
        lblUserId.Text = Booking.UserID
        lblDate.Text = Booking.Flight.DepartureTime.ToString("d MMM yyyy")
    End Sub

    Private Sub BtnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        App.Session.Add("booking", Booking)
        Quick.Navigate(AdminCitiesViewResults, New AdminBookingsViewSummary)
    End Sub
End Class
