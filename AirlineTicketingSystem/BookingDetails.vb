Public Class BookingDetails
    Private Booking As Booking
    Sub New(Booking As Booking)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Booking = Booking
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub LblDestination_Click(sender As Object, e As EventArgs) Handles lblDestination.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub LblSource_Click(sender As Object, e As EventArgs) Handles lblSource.Click

    End Sub

    Private Sub LblDepartureTime_Click(sender As Object, e As EventArgs) Handles lblDepartureTime.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub BookingDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBookingId.Text = Booking.BookingID
        lblPrice.Text = "RM " & Booking.TotalPrice
        lblDuration.Text = Booking.Flight.Route.DurationHour.ToString & "h " & Booking.Flight.Route.DurationMins.ToString
        lblSource.Text = DB.GetFlightSource(Booking.Flight.FlightID).City.Name
        lblDepartureTime.Text = Booking.Flight.DepartureTime.ToString("HH:mm")
        lblDestination.Text = DB.GetFlightDestination(Booking.Flight.FlightID).City.Name
        lblArrivalTime.Text = Booking.Flight.ArrivalTime.ToString("HH:mm")
        lblDuration.Text = Booking.Flight.ArrivalTime.Subtract(Booking.Flight.DepartureTime).Hours & "h " & Booking.Flight.ArrivalTime.Subtract(Booking.Flight.DepartureTime).Minutes & "M approx."
    End Sub

    Private Sub LblPrice_Click(sender As Object, e As EventArgs) Handles lblPrice.Click

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New MyBookings)
    End Sub
End Class