Public Class FlightSearch
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New FlightList)
    End Sub

    Private Sub FlightSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleBar.Load(Me)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If dtpDate.Value < (DateAndTime.Now()) Then
            Quick.ShowWarning("Wrong date", "Ensure that your selected date is at least 1 day after today.")
            Return
        End If

        Dim selectedDate = New Date(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day)
        Dim results As List(Of Flight) = (From flight In DB.context.Flights Where txtFrom.Text = (From stops In DB.context.Stops Where stops.IsOrigin = True And stops.RouteID = flight.RouteID).First.City.Name And txtTo.Text = (From stops In DB.context.Stops Where stops.IsOrigin = False And stops.RouteID = flight.RouteID).First.City.Name And flight.Bookings.Count < flight.Plane.Capacity And flight.IsDaily Or (flight.DepartureTime.Day = selectedDate.Day And flight.DepartureTime.Month = selectedDate.Month And flight.DepartureTime.Year = selectedDate.Year)).ToList

        App.Session.Add("flightResults", results)
        App.Session.Add("selectedDate", selectedDate)

        Quick.Navigate(Me, New FlightList)
    End Sub

End Class