Public Class FlightItem
    Public Flight As Flight
    Public FlightList As FlightList
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim flightDetails As New FlightDetails()
        App.Session.Add("selectedFlight", Flight)
        flightDetails.Show()
        FlightList.Close() 'Closes the flightList screen
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub FlightItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSeats.Text = Flight.Bookings.Count & "/" & Flight.Plane.Capacity 'NOTE: Does not account for multiple passengers per booking YET
        If Flight.IsDaily Then
            lblDate.Text = "DAILY"
        Else
            lblDate.Text = Flight.DepartureTime.DayOfWeek.ToString & ", " & DateAndTime.MonthName(Flight.DepartureTime.Month) & " " & Flight.DepartureTime.Day.ToString
        End If

        lblPrice.Text = Flight.Price
        lblId.Text = Flight.FlightID
        lblDuration.Text = Flight.Route.DurationHour.ToString & "h " & Flight.Route.DurationMins.ToString
        lblSource.Text = DB.GetFlightSource(Flight.FlightID).City.Name
        lblDepartureTime.Text = Flight.DepartureTime.ToString("HH:mm")
        lblDestination.Text = DB.GetFlightDestination(Flight.FlightID).City.Name
        lblArrivalTime.Text = Flight.ArrivalTime.ToString("HH:mm")
        lblDuration.Text = Flight.ArrivalTime.Subtract(Flight.DepartureTime).Hours & "h " & Flight.ArrivalTime.Subtract(Flight.DepartureTime).Minutes & "M approx."
    End Sub

    Private Sub LblDepartureTime_Click(sender As Object, e As EventArgs) Handles lblDepartureTime.Click

    End Sub

    Private Sub LblId_Click(sender As Object, e As EventArgs) Handles lblId.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub LblSeats_Click(sender As Object, e As EventArgs) Handles lblSeats.Click

    End Sub

    Private Sub LblArrivalTime_Click(sender As Object, e As EventArgs) Handles lblArrivalTime.Click

    End Sub

    Private Sub LblDestination_Click(sender As Object, e As EventArgs) Handles lblDestination.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub LblSource_Click(sender As Object, e As EventArgs) Handles lblSource.Click

    End Sub

    Private Sub LblDuration_Click(sender As Object, e As EventArgs) Handles lblDuration.Click

    End Sub

    Private Sub LblDate_Click(sender As Object, e As EventArgs) Handles lblDate.Click

    End Sub
End Class
