Public Class BookingItem
	Private Booking As Booking

	Sub New(Booking As Booking)

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		Me.Booking = Booking
	End Sub


	Private Sub BookingItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		lblSource.Text = DB.GetFlightSource(Booking.Flight.FlightID).City.Name
		lblDate.Text = Booking.Flight.DepartureTime.DayOfWeek.ToString & ", " & DateAndTime.MonthName(Booking.Flight.DepartureTime.Month) & " " & Booking.Flight.DepartureTime.Day.ToString

		lblDestination.Text = DB.GetFlightDestination(Booking.Flight.FlightID).City.Name
		lblArrivalTime.Text = Booking.Flight.ArrivalTime.ToString("HH:mm")
		lblDepartureTime.Text = Booking.Flight.DepartureTime.ToString("HH:mm")
		lblBookingId.Text = Booking.BookingID
		lblFlightId.Text = Booking.Flight.FlightNo

		If Booking.IsCancelled Then
			lblBookingId.ForeColor = Color.OrangeRed
			lblBookingId.Text = "CANCELLED"
			lblBookingId.Font = New Font(lblBookingId.Font.FontFamily, 20)
		End If
	End Sub

	Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
		Quick.Navigate(DirectCast(sender, Button).FindForm, New BookingDetails(Booking))
	End Sub
End Class
