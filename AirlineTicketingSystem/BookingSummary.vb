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

        Dim user = New User()

        'IsUserLoggedIn
        If App.IsLoggedIn Then
            user = App.User

        Else
            'Create guest
            user.Name = passengerList(0).Name 'First passenger will be the booking user
            user.IsStaff = False
            user.UserID = Quick.GenerateId(Of User)()
            user.Email = "tbc"
            user.CreditCardNo = booking.CreditCardNo
            user.DateOfBirth = DateAndTime.Now()
            user.Country = "tbc"
            user.City = "tbc"
            user.Gender = "G"

            'ToDo: show a dialog to fill in guest info
        End If

        booking.User = user

        DB.Insert(booking)
        For Each Ticket As Ticket In passengerList
            DB.Insert(Ticket)
        Next

        App.Session.Clear()
    End Sub
End Class