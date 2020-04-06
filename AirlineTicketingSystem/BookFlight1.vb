Public Class BookFlight1
    Private Flight As New Flight

    Private Sub BookFlight1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Check for existing
        If App.Session.Get("Booking") IsNot Nothing Then
            Dim booking As Booking = App.Session.Get("Booking")
            txtPeople.Text = booking.NoOfPassengers
            txtCard.Text = booking.CreditCardNo
        End If

        Dim user = App.User
        If user IsNot Nothing Then
            If user.CreditCardNo IsNot Nothing Then
                txtCard.Text = user.CreditCardNo
            End If
        End If


        Flight = App.Session.Get("selectedFlight")
        lblId.Text = Flight.FlightNo
        lblArrival.Text = Flight.ArrivalTime.ToString("HH:mm")
        lblDepartureTime.Text = Flight.DepartureTime.ToString("HH:mm")
        lblDestination.Text = DB.GetFlightDestination(Flight.FlightID).City.Name
        lblSource.Text = DB.GetFlightSource(Flight.FlightID).City.Name
        If Flight.IsDaily Then
            lblDate.Text = "DAILY"
        Else
            lblDate.Text = Flight.DepartureTime.DayOfWeek.ToString & ", " & DateAndTime.MonthName(Flight.DepartureTime.Month) & " " & Flight.DepartureTime.Day.ToString
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim peopleCount = 0
        Dim kgCount = 0
        Try
            peopleCount = CType(txtPeople.Text, Int32)
            kgCount = CType(txtLuggageKg.Text, Int32)
        Catch ex As Exception
            Quick.ShowError("Incorrect no. of people", "Ensure that your no. of people is in numerals only.")
            Return
        End Try

        If Not Quick.CheckRegex("[0-9]{4}\-[0-9]{4}\-[0-9]{4}\-[0-9]{4}", txtCard.Text) Then
            Quick.ShowError("Incorrect credit card format", "Ensure that your credit card number is following this format: XXXX-XXXX-XXXX-XXXX.")
            Return
        End If

        If kgCount > 50 Then
            Quick.ShowWarning("Max luggage exceeded", "We only allow a maximum of 50 kg per booking.")
            Return
        End If

        Dim selectedDate = New Date(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, Flight.DepartureTime.Hour, Flight.DepartureTime.Minute, Flight.DepartureTime.Second)
        If dtpDate.Value < (DateAndTime.Now()) Then
            Quick.ShowWarning("Wrong date", "Ensure that your selected date is at least 1 day after today.")
            Return
        End If

        If Flight.IsDaily Then

            Dim flightInstance = New Flight()

            'Check if such flight instance already exists
            Dim result = From flight In DB.context.Flights Where flight.FlightNo = flight.FlightNo And flight.DepartureTime = selectedDate

            If result.Count = 0 Then
                'Flight instance does not exist

                'Copy flight details
                flightInstance.FlightNo = Flight.FlightNo
                flightInstance.IsDaily = False
                flightInstance.PlaneID = Flight.PlaneID
                flightInstance.RouteID = Flight.RouteID
                flightInstance.Price = Flight.Price
                flightInstance.FlightID = Quick.GenerateId(Of Flight)()
                flightInstance.IsFlightInstance = True

                'Create flight instance on the selected date
                Dim dayDifference = 0

                If Flight.ArrivalTime.Day - Flight.DepartureTime.Day = 1 Then
                    'If the time crosses 1 day
                    dayDifference = 1
                End If

                flightInstance.DepartureTime = New Date(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, Flight.DepartureTime.Hour, Flight.DepartureTime.Minute, Flight.DepartureTime.Second)
                flightInstance.ArrivalTime = New Date(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day + dayDifference, Flight.ArrivalTime.Hour, Flight.ArrivalTime.Minute, Flight.ArrivalTime.Second)

                DB.Insert(flightInstance)
            Else
                'Flight instance exists, so we use that instance
                flightInstance = result.First()
            End If

            'Update flight in session
            App.Session.Set("selectedFlight", flightInstance)
        End If


        Dim booking As New Booking()
        'Perform initializations
        booking.NoOfPassengers = peopleCount
        booking.CreditCardNo = txtCard.Text
        booking.ExtraBaggageKG = kgCount
        booking.IsCancelled = False


        App.Session.Add("Booking", booking)

        'Save form state before proceeding

        Quick.Navigate(Me, New BookFlight2)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New FlightDetails())
    End Sub
End Class