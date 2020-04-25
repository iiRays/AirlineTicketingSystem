Public Class FlightItem
    Public Flight As New Flight()
    Public FlightList As FlightList
    Public SelectedDate As Date
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        App.Session.Set("selectedFlight", Flight)
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

                'Copy flight details
                flightInstance = Quick.Clone(Of Flight)(Flight)
                flightInstance.IsDaily = False
                flightInstance.IsFlightInstance = True

                flightInstance.RouteID = Flight.RouteID
                flightInstance.PlaneID = Flight.PlaneID


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
            flightInstance.IsDaily = False
            'Update flight in the list
            Flight = flightInstance


        End If

        Dim totalPassengers = DB.GetTotalPassengers(Flight.FlightID)

        lblSeats.Text = totalPassengers & "/" & CType(DB.Get(Of Plane)(Flight.PlaneID), Plane).Capacity

        lblDate.Text = Flight.DepartureTime.DayOfWeek.ToString & ", " & DateAndTime.MonthName(Flight.DepartureTime.Month) & " " & Flight.DepartureTime.Day.ToString
        lblPrice.Text = "RM " & Flight.Price
        lblId.Text = Flight.FlightNo
        lblDuration.Text = DB.Get(Of Route)(Flight.RouteID).DurationHour.ToString & "h " & DB.Get(Of Route)(Flight.RouteID).DurationMins.ToString
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
