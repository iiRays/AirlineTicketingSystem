Public Class AdminFlightsAddSummary
    Private flight As Flight = App.Session.Get("flight")
    Private Sub AdminFlightsAddSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        Me.DoubleBuffered = True
        TitleBar.Load(Me, True)

        lblId.Text = Flight.FlightID
        lblSource.Text = DB.GetFlightSource(Flight.FlightID).City.Name
        lblDestination.Text = DB.GetFlightDestination(Flight.FlightID).City.Name
        lblHrs.Text = Flight.Route.DurationHour.ToString()
        lblMins.Text = Flight.Route.DurationMins.ToString()
        lblDate.Text = flight.DepartureTime.DayOfWeek.ToString.Substring(0, 3) & ", " &
            flight.DepartureTime.Day.ToString() & " " &
            DateAndTime.MonthName(flight.DepartureTime.Month).Substring(0, 3) & " " &
            flight.DepartureTime.Year.ToString()
        lblCapacity.Text = Flight.Plane.Capacity.ToString()
        lblRouteId.Text = Flight.RouteID
        lblPlaneId.Text = Flight.PlaneID
        lblDeparture.Text = Flight.DepartureTime.ToString("HH:mm")
        lblArrival.Text = Flight.ArrivalTime.ToString("HH:mm")
        lblPrice.Text = Flight.Price.ToString("RM 0.00")
        lblIsDaily.Text = Flight.IsDaily.ToString()
        lblIsInstance.Text = Flight.IsFlightInstance.ToString()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        App.Session.Delete("flight")
        Quick.Navigate(Me, AdminFlightsDashboard)
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        App.Session.Set("sourceScreen", "add")
        Quick.Navigate(Me, New AdminFlightsEdit)
    End Sub

    Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        DB.Delete(flight)
        App.Session.Delete("flight")
        Quick.Navigate(Me, AdminFlightsDashboard)
    End Sub
End Class