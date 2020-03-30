Public Class FlightList
    Private Sub FlightList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get list of flights
        Dim flights As List(Of Flight) = DB.GetAll(Of Flight)
        Dim loopCount = 0

        'Display each flight
        For Each flight As Flight In flights
            Dim flightItem As New FlightItem()
            flightItem.lblSeats.Text = flight.Bookings.Count & "/" & flight.Plane.Capacity
            flightItem.lblDate.Text = flight.DepartureTime.DayOfWeek.ToString & ", " & DateAndTime.MonthName(flight.DepartureTime.Month) & " " & flight.DepartureTime.Day.ToString
            flightItem.Location = New Point(130, 160 + (loopCount * 250))
            flightItem.lblId.Text = flight.FlightID
            flightItem.lblDuration.Text = flight.Route.DurationHour.ToString & "h " & flight.Route.DurationMins.ToString & "m approx."
            flightItem.lblSource.Text = DB.GetFlightSource(flight.FlightID).City.Name
            flightItem.lblDepartureTime.Text = flight.DepartureTime.ToString("h:mm tt")
            flightItem.lblDestination.Text = DB.GetFlightDestination(flight.FlightID).City.Name
            flightItem.lblArrivalTime.Text = flight.ArrivalTime.ToString("h:mm tt")
            flightItem.lblDuration.Text = flight.ArrivalTime.Subtract(flight.DepartureTime).Hours & "h " & flight.ArrivalTime.Subtract(flight.DepartureTime).Minutes & "M approx."
            Me.Controls.Add(flightItem)
            loopCount += 1
        Next
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs)
        Quick.Navigate(Me, New FlightDetails)
    End Sub
End Class