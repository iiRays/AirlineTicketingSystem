Public Class AdminFlightsAdd3
    Dim route As Route = App.Session.Get("route")
    Dim plane As Plane = App.Session.Get("plane")
    Private Sub AdminFlightsAdd3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)

        txtRouteId.Text = route.RouteID
        txtPlaneId.Text = plane.PlaneID
        rbDailyNo.Checked = True
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        App.Session.Delete("plane")
        Quick.Navigate(Me, New AdminFlightsAdd2)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim flight As New Flight
        flight.FlightID = Quick.GenerateId(Of Flight)
        flight.RouteID = route.RouteID
        flight.PlaneID = plane.PlaneID
        flight.FlightNo = txtFlightNo.Text
        flight.DepartureTime = dtpDeparture.Value 'to add validation
        flight.ArrivalTime = dtpArrival.Value 'to add validation
        flight.Price = Convert.ToDecimal(txtPrice.Text) 'to add validation
        If rbDailyNo.Checked Then
            flight.IsDaily = False
            flight.IsFlightInstance = True
        ElseIf rbDailyYes.Checked Then
            flight.IsDaily = True
            flight.IsFlightInstance = False
        End If

        DB.Insert(flight)

        App.Session.Set("flight", flight)

        App.Session.Delete("route")
        App.Session.Delete("plane")

        Quick.Navigate(Me, New AdminFlightsAddSummary)
    End Sub
End Class