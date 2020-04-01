Public Class FlightDetails
    Private Flight As New Flight
    Private Sub FlightDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Flight = App.Session.Get("selectedFlight")
        lblSeats.Text = Flight.Bookings.Count & "/" & Flight.Plane.Capacity 'NOTE: Does not account for multiple passengers per booking YET
        If Flight.IsDaily Then
            lblDate.Text = "DAILY"
        Else
            lblDate.Text = Flight.DepartureTime.DayOfWeek.ToString & ", " & DateAndTime.MonthName(Flight.DepartureTime.Month) & " " & Flight.DepartureTime.Day.ToString
        End If
        lblId.Text = Flight.FlightID
        lblDuration.Text = Flight.Route.DurationHour.ToString & "h " & Flight.Route.DurationMins.ToString & "m approx."
        lblSource.Text = DB.GetFlightSource(Flight.FlightID).City.Name
        lblDepartureTime.Text = Flight.DepartureTime.ToString("h:mm tt")
        lblDestination.Text = DB.GetFlightDestination(Flight.FlightID).City.Name
        lblArrivalTime.Text = Flight.ArrivalTime.ToString("h:mm tt")
        lblDuration.Text = Flight.ArrivalTime.Subtract(Flight.DepartureTime).Hours & "h " & Flight.ArrivalTime.Subtract(Flight.DepartureTime).Minutes & "M approx."

        'Whether to show Edit Flight button or not
        If (App.Session.Get("role") = "staff") Then
            btnEdit.Show()
        Else
            btnEdit.Hide()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Clear selected flight
        App.Session.Delete("selectedFlight")

        Quick.Navigate(Me, New FlightList)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Quick.Navigate(Me, New BookFlight1)
    End Sub
End Class