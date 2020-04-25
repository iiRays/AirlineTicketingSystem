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

            Dim dailyFlight = App.Session.Get("selectedFlight")

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

        Dim plane = booking.Flight.Plane

        DB.Insert(booking)
        For Each ticket As Ticket In passengerList

            'Dim result As New Ticket
            ''Generate seat number
            'Dim selectedSeat = ""
            'Do
            '    selectedSeat = Quick.GetRandomInt(1, (plane.Capacity / plane.MaxColumns)).ToString & Quick.IntToChar(Quick.GetRandomInt(1, plane.MaxColumns)).ToString

            '    result = (From dbTicket In DB.context.Tickets Where dbTicket.Booking.Flight.FlightID = flight.FlightID And dbTicket.Seat = selectedSeat).FirstOrDefault

            'Loop While result IsNot Nothing 'Loop if this seat already exists (means already booked)

            'ticket.Seat = selectedSeat

            DB.Insert(ticket)
        Next

        If App.IsLoggedIn Then
            DB.Update(user, user.UserID)
            App.User = DB.Get(Of User)(user.UserID)
        End If


        Quick.Navigate(Me, New BookingFinish(booking))
    End Sub

    Private Function GenerateSeat(tickets As List(Of Ticket)) As List(Of Ticket)
        Dim plane = tickets.First.Booking.Flight.Plane

        ''Attempt to group passengers together

        ''Find a row with available seats
        'For rowCount As Integer = 1 To (plane.Capacity / plane.MaxColumns)
        '    Dim rs = From ticket In DB.context.Tickets Where ticket.Booking.Flight.Plane.PlaneID = plane.PlaneID And ticket.Seat.Chars(0).ToString = rowCount.ToString

        '    'If rs = Nothing, then the first seat at row (rowCount) is empty
        '    If rs.Count = 0 Then
        '        For columnCount As Integer = 1 To plane.MaxColumns
        '            ' Loop through each seat in that column
        '            Dim secondRs = From ticket In DB.context.Tickets Where ticket.Booking.Flight.Plane.PlaneID = plane.PlaneID And ticket.Seat.Chars(0).ToString = rowCount.ToString
        '        Next
        '    End If
        'Next
        'If number of tickets exceed column count, go the next nearest column



    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Quick.Navigate(Me, New FlightList)
    End Sub
End Class