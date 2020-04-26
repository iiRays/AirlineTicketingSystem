Public Class BookingFinish
    Private Booking As Booking

    Sub New(booking As Booking)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Booking = booking
    End Sub

    Private Sub BookingFinish_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        TitleBar.Load(Me)
        Dim body As New System.Text.StringBuilder
        body.AppendLine("<h1>Booking success!</h1>")
        body.AppendLine("Booking ID: <h2>" & Booking.BookingID & "</h2>")
        body.AppendLine("Flight No: <h3>" & Booking.Flight.FlightNo & "</h3>")
        body.AppendLine("Leaves on <b>" & Booking.Flight.DepartureTime.ToString("dd/MM/yyyy hh:mm ss") & "</b><br>")
        body.AppendLine("Arrives on <b>" & Booking.Flight.ArrivalTime.ToString("dd/MM/yyyy hh:mm ss") & "</b><br>")
        body.AppendLine("<hr>")

        body.AppendLine("<h2>Passengers information</h2>")
        Dim counter = 0
        For Each ticket As Ticket In Booking.Tickets
            counter += 1
            body.AppendLine(counter & ". <b>" & ticket.Name & "</b>, Seat: " & ticket.Seat & "<br>")
        Next

        body.AppendLine("<h2>Total: " & Booking.Tickets.Count & " tickets </h2>")

        Email.Send("Successful booking " & Booking.BookingID, body.ToString, Booking.User.Email)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        BookingSearch.Search(Booking.BookingID)
        Me.Close()
    End Sub
End Class