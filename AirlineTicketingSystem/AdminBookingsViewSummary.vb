Public Class AdminBookingsViewSummary
    Private booking As Booking = App.Session.Get("booking")
    Private Sub AdminBookingsViewSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        Me.DoubleBuffered = True
        TitleBar.Load(Me, True)

        lblId.Text = booking.BookingID
        lblUserId.Text = booking.UserID
        lblFlightId.Text = booking.FlightID
        lblFlightNo.Text = booking.Flight.FlightNo
        lblNoOfPassengers.Text = booking.NoOfPassengers.ToString()
        lblTotalPrice.Text = booking.TotalPrice.ToString("RM 0.00")
        lblPaymentDate.Text = booking.PaymentDate.ToString("d MMM yyyy")
        lblCreditCardNo.Text = booking.CreditCardNo
        lblIsCancelled.Text = booking.IsCancelled.ToString()
        lblExtraBaggageKg.Text = booking.ExtraBaggageKG.ToString("0 kg")
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        App.Session.Delete("booking")
        Quick.Navigate(Me, New AdminBookingsViewResults)
    End Sub

    Private Sub BtnViewTickets_Click(sender As Object, e As EventArgs) Handles btnViewTickets.Click
        Quick.Navigate(Me, New AdminBookingsViewSummaryTickets)
    End Sub
End Class