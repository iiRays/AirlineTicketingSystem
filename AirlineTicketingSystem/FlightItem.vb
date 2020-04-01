Public Class FlightItem
    Public Flight As Flight
    Public FlightList As FlightList
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim flightDetails As New FlightDetails()
        flightDetails.Flight = Flight
        flightDetails.Show()
        FlightList.Close() 'Closes the flightList screen
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub FlightItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSeats.Text = Flight.Bookings.Count & "/" & Flight.Plane.Capacity 'NOTE: Does not account for multiple passengers per booking YET
        lblDate.Text = Flight.DepartureTime.DayOfWeek.ToString & ", " & DateAndTime.MonthName(Flight.DepartureTime.Month) & " " & Flight.DepartureTime.Day.ToString
        lblId.Text = Flight.FlightID
        lblDuration.Text = Flight.Route.DurationHour.ToString & "h " & Flight.Route.DurationMins.ToString & "m approx."
        lblSource.Text = DB.GetFlightSource(Flight.FlightID).City.Name
        lblDepartureTime.Text = Flight.DepartureTime.ToString("h:mm tt")
        lblDestination.Text = DB.GetFlightDestination(Flight.FlightID).City.Name
        lblArrivalTime.Text = Flight.ArrivalTime.ToString("h:mm tt")
        lblDuration.Text = Flight.ArrivalTime.Subtract(Flight.DepartureTime).Hours & "h " & Flight.ArrivalTime.Subtract(Flight.DepartureTime).Minutes & "M approx."
    End Sub
End Class
