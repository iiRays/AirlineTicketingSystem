Public Class BookingSummary
    Private passengerList As List(Of Ticket) = App.Session.Get("passengerList")
    Private booking As Booking = App.Session.Get("Booking")
    Private flight As Flight = App.Session.Get("selectedFlight")
    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BookingSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleBar.Load(Me)
        lblPrice.Text = CType(App.Session.Get("Booking"), Booking).TotalPrice
        If flight.IsDaily Then
            lblDate.Text = "DAILY"
        Else
            lblDate.Text = flight.DepartureTime.DayOfWeek.ToString & ", " & DateAndTime.MonthName(flight.DepartureTime.Month) & " " & flight.DepartureTime.Day.ToString
        End If
        lblId.Text = flight.FlightNo
        lblDuration.Text = flight.Route.DurationHour.ToString & "h " & flight.Route.DurationMins.ToString
        lblSource.Text = DB.GetFlightSource(flight.FlightID).City.Name
        lblDepartureTime.Text = flight.DepartureTime.ToString("HH:mm")
        lblDestination.Text = DB.GetFlightDestination(flight.FlightID).City.Name
        lblArrivalTime.Text = flight.ArrivalTime.ToString("HH:mm")
        lblDuration.Text = flight.ArrivalTime.Subtract(flight.DepartureTime).Hours & "h " & flight.ArrivalTime.Subtract(flight.DepartureTime).Minutes & "M"

        'Get panel reference
        Dim namePanel As Panel = Me.Controls("panelPassengers")

        'Load names

        Dim count = 0
        For Each ticket As Ticket In passengerList
            count += 1
            Dim bookingSumItem As New BookingSummaryPassengerItem()
            bookingSumItem.Location = New Point(60, 49 + (count * 45))
            bookingSumItem.lblName.Text = ticket.Name
            bookingSumItem.lblNumber.Text = count
            namePanel.Controls.Add(bookingSumItem)
        Next

        lblPassengerCount.Text = count
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New BookFlight2)
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        booking.PaymentDate = DateAndTime.Now()
        booking.FlightID = flight.FlightID

        Dim user As User = App.Session.Get("payer")

        'IsUserLoggedIn
        If Not App.IsLoggedIn Then
            'Create guest
            user.IsStaff = False
            user.UserID = Quick.GenerateId(Of User)()
        End If


        Dim existingFlight = DB.GetExistingFlight(flight, CType(App.Session.Get("selectedDate"), Date))

        If existingFlight Is Nothing Then
            'If this flight doesn't exist
            flight.FlightID = Quick.GenerateId(Of Flight)()

            DB.Insert(flight)
        Else
            If existingFlight.Bookings.Count = existingFlight.Plane.Capacity Then
                ' Flight is full

                Quick.ShowError("Flight is full", "It seems that the flight is completely full, which might have happened as you were booking your flight. You are not allowed to book this flight any longer")
                Return
            End If
        End If

        booking.User = user
        booking.UserID = user.UserID

        booking.FlightID = flight.FlightID
        booking.Flight = flight

        DB.Insert(booking)
        For Each Ticket As Ticket In passengerList
            DB.Insert(Ticket)
        Next

        If App.IsLoggedIn Then
            DB.Update(user, user.UserID)
            App.User = DB.Get(Of User)(user.UserID)
        End If

        App.Session.Clear()

        Quick.Navigate(Me, New BookingFinish(booking))
    End Sub
End Class