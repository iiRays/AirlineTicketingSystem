Public Class FlightItem
    Public Flight As Flight
    Public FlightList As FlightList
    Public SelectedDate As Date
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        App.Session.Add("selectedFlight", Flight)
        Quick.Navigate(FlightList, New FlightDetails())
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub FlightItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Flight.IsDaily Then

            Dim flightInstance = New Flight()

            'Check if such flight instance already exists
            SelectedDate = New Date(SelectedDate.Year, SelectedDate.Month, SelectedDate.Day, Flight.DepartureTime.Hour, Flight.DepartureTime.Minute, Flight.DepartureTime.Second)
            Dim existingFlight = DB.GetExistingFlight(Flight, SelectedDate)

            If existingFlight Is Nothing Then
                'Flight instance does not exist

                'Copy references
                flightInstance.Route = Flight.Route
                flightInstance.Plane = Flight.Plane

                'Copy flight details
                flightInstance.FlightNo = Flight.FlightNo
                flightInstance.IsDaily = False
                flightInstance.PlaneID = Flight.PlaneID
                flightInstance.RouteID = Flight.RouteID
                flightInstance.Price = Flight.Price
                flightInstance.FlightID = Flight.FlightID
                flightInstance.IsFlightInstance = True



                'Create flight instance on the selected date
                Dim dayDifference = 0

                If Flight.ArrivalTime.Day - Flight.DepartureTime.Day = 1 Then
                    'If the time crosses 1 day
                    dayDifference = 1
                End If

                flightInstance.DepartureTime = New Date(SelectedDate.Year, SelectedDate.Month, SelectedDate.Day, Flight.DepartureTime.Hour, Flight.DepartureTime.Minute, Flight.DepartureTime.Second)
                flightInstance.ArrivalTime = New Date(SelectedDate.Year, SelectedDate.Month, SelectedDate.Day + dayDifference, Flight.ArrivalTime.Hour, Flight.ArrivalTime.Minute, Flight.ArrivalTime.Second)

            Else
                'Flight instance exists, so we use that instance
                flightInstance = existingFlight
            End If

            'Update flight in the list
            Flight = flightInstance


        End If

        Dim totalPassengers = DB.GetTotalPassengers(Flight.FlightID)

        lblSeats.Text = totalPassengers & "/" & CType(DB.Get(Of Plane)(Flight.PlaneID), Plane).Capacity


        lblPrice.Text = "RM " & Flight.Price
        lblId.Text = Flight.FlightNo
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblSeatsTitle.Click

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
