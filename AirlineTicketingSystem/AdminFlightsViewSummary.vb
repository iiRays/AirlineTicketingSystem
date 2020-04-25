Public Class AdminFlightsViewSummary
    Private flight As Flight = App.Session.Get("flight")
    Private Sub AdminFlightsViewSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)

        lblId.Text = flight.FlightID
        lblSource.Text = DB.GetFlightSource(flight.FlightID).City.Name
        lblDestination.Text = DB.GetFlightDestination(flight.FlightID).City.Name
        lblHrs.Text = flight.Route.DurationHour.ToString()
        lblMins.Text = flight.Route.DurationMins.ToString()
        lblDate.Text = flight.DepartureTime.DayOfWeek.ToString & ", " & DateAndTime.MonthName(flight.DepartureTime.Month).ToString("MMM") & " " & flight.DepartureTime.Day.ToString
        lblCapacity.Text = flight.Plane.Capacity.ToString()
        lblRouteId.Text = flight.RouteID
        lblPlaneId.Text = flight.PlaneID
        lblDeparture.Text = flight.DepartureTime.ToString("HH:mm")
        lblArrival.Text = flight.ArrivalTime.ToString("HH:mm")
        lblPrice.Text = flight.Price.ToString("RM 0.00")
        lblIsDaily.Text = flight.IsDaily.ToString()
        lblIsInstance.Text = flight.IsFlightInstance.ToString()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        App.Session.Set("sourceScreen", "view")
        Quick.Navigate(Me, New AdminFlightsEdit)
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        App.Session.Delete("flight")
        Quick.Navigate(Me, New AdminFlightsViewResults)
    End Sub
End Class