Public Class FlightList
    Private Sub FlightList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get list of flights
        Dim flights As List(Of Flight) = DB.GetAll(Of Flight)

        'Display each flight
        For Each flight As Flight In flights
            Dim flightItem As New FlightItem()
            flightItem.Location = New Point(130, 160)
            flightItem.lblId.Text = flight.FlightID
            flightItem.lblDate.Text = String.Format("{0:d\.hh\:mm}", flight.DepartureTime) 'https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-timespan-format-strings
            flightItem.lblDuration.Text = flight.Route.DurationHour.ToString & "h " & flight.Route.DurationMins.ToString & "m approx."
            flightItem.lblSource.Text = DB.GetFlightSource(flight.FlightID).City.Name
            flightItem.lblDepartureTime.Text = "???" 'String.Format("{0:hh\\:mm}", flight.DepartureTime)
            flightItem.lblDestination.Text = DB.GetFlightDestination(flight.FlightID).City.Name
            flightItem.lblArrivalTime.Text = "???" 'String.Format("{0:hh\\:mm}", flight.ArrivalTime)
            flightItem.lblSeats.Text = "???/???"
            Me.Controls.Add(flightItem)
        Next
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs)
        Quick.Navigate(Me, New FlightDetails)
    End Sub
End Class