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
        Me.DoubleBuffered = True
        TitleBar.Load(Me)
        lblFlightId.Text = Booking.Flight.FlightNo
        lblBaggageKg.Text = Booking.ExtraBaggageKG
        lblPassengers.Text = Booking.NoOfPassengers
        lblBookingId.Text = Booking.BookingID
        lblPrice.Text = "RM " & Booking.TotalPrice
        lblSource.Text = DB.GetFlightSource(Booking.Flight.FlightID).City.Name
        lblDepartureTime.Text = Booking.Flight.DepartureTime.ToString("HH:mm")
        lblDestination.Text = DB.GetFlightDestination(Booking.Flight.FlightID).City.Name
        lblArrivalTime.Text = Booking.Flight.ArrivalTime.ToString("HH:mm")
        lblPaymentDate.Text = Booking.PaymentDate.ToString("d MMM yyyy")

        Dim flight = Booking.Flight
        lblDate.Text = flight.DepartureTime.DayOfWeek.ToString & ", " & DateAndTime.MonthName(flight.DepartureTime.Month) & " " & flight.DepartureTime.Day.ToString


        If Booking.IsCancelled Then
            lblStatus.Text = "Cancelled"
            lblStatus.ForeColor = Color.OrangeRed
            btnCancel.Enabled = False
            btnCancel.Hide()
        End If

        If DateAndTime.DateDiff(DateInterval.DayOfYear, DateAndTime.Now(), Booking.Flight.DepartureTime,) < 2 Then
            'If less than 2 days until departure, don't allow cancellation
            btnCancel.Enabled = False
            btnCancel.Hide()
        End If
    End Sub



    Private Sub LblPrice_Click(sender As Object, e As EventArgs) Handles lblPrice.Click

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If App.User Is Nothing Then
            Quick.Navigate(Me, New BookingSearch())
        Else
            Quick.Navigate(Me, New MyBookings)
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnViewFlight.Click
        Quick.Navigate(Me, New FlightDetails(Booking))
    End Sub

    Private Sub btnViewTickets_Click(sender As Object, e As EventArgs) Handles btnViewTickets.Click
        Quick.Navigate(Me, New TicketList(Booking))
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim form As New BookCancel(Booking)
        form.BookingDetailsForm = Me
        form.ShowDialog()
    End Sub

    Public Sub UpdateBooking()
        If Booking.IsCancelled Then
            lblStatus.Text = "Cancelled"
            lblStatus.ForeColor = Color.OrangeRed
            btnCancel.Enabled = False
            btnCancel.Hide()
        End If
    End Sub
End Class