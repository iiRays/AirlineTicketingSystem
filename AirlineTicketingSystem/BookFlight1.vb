Imports System.Text

Public Class BookFlight1
    Private Flight As New Flight
    Public User As User

    Private Sub BookFlight1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleBar.Load(Me)
        'Check for existing
        If App.Session.Get("Booking") IsNot Nothing Then
            Dim booking As Booking = App.Session.Get("Booking")
            txtPeople.Text = booking.NoOfPassengers
            txtLuggageKg.Text = booking.ExtraBaggageKG
        End If

        User = App.Session.Get("payer")
        If User Is Nothing Then
            User = App.User
        End If

        UpdateLabel()

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
        Dim errorStr As New StringBuilder()
        Dim hasKgErrors = False

        errorStr.AppendLine(If(lblInfoStatus.Text = "not yet filled", "- Please fill in payer details.", ""))

        Try
            peopleCount = CType(txtPeople.Text, Int32)
        Catch ex As Exception
            errorStr.AppendLine(" - No. of people must be in numbers only")
        End Try

        Try
            kgCount = CType(txtLuggageKg.Text, Int32)
        Catch ex As Exception
            errorStr.AppendLine(" - Luggage kg. must be in numbers only")
            hasKgErrors = True
        End Try

        If kgCount > 50 And hasKgErrors = False Then
            errorStr.AppendLine(" - We only allow a maximum of 50 kg per booking.")
        End If

        If DB.GetExistingFlight(Flight, Flight.DepartureTime.Date) IsNot Nothing Then
            'If this flight already exists

            Dim passengerCount = DB.GetTotalPassengers(Flight.FlightID)
            If (peopleCount + passengerCount) > Flight.Plane.Capacity Then
                'Add in the selected passenger count with the total passengers already booked to ensure not overbooked
                errorStr.AppendLine(" - The maximum passengers you can book is " & (Flight.Plane.Capacity - passengerCount))
            End If

        Else
            'Since this flight has 0 passengers, limit to the capacity
            If peopleCount > Flight.Plane.Capacity Then
                errorStr.AppendLine(" - The maximum passengers you can book is " & Flight.Plane.Capacity)
            End If
        End If

        If errorStr.ToString.Trim.Length > 0 Then
            'Has error
            Quick.ShowError("Incorrect fields", errorStr.ToString().Trim)
            Return
        End If




        Dim booking As New Booking()
        'Perform initializations
        booking.NoOfPassengers = peopleCount
        booking.CreditCardNo = User.CreditCardNo
        booking.ExtraBaggageKG = kgCount
        booking.IsCancelled = False

        If App.Session.Get("Booking") Is Nothing Then
            App.Session.Set("Booking", booking)
        Else
            App.Session.Update("Booking", booking)
        End If

        App.Session.Set("payer", User)

        'Save form state before proceeding

        Quick.Navigate(Me, New BookFlight2)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New FlightDetails())
    End Sub



    Private Sub btnPayerInfo_Click(sender As Object, e As EventArgs) Handles btnPayerInfo.Click
        Dim form As New BookPayerInfo()
        form.BookFlightForm = Me 'To hold reference
        form.ShowDialog()
    End Sub

    Public Sub UpdateLabel()
        If User IsNot Nothing Then
            Dim hasError = False
            With User
                hasError = If(.Name.Trim.Length = 0, True, False)
                hasError = If(.Email.Trim.Length = 0, True, False)
                hasError = If(.DateOfBirth.HasValue = False OrElse DateAndTime.DateDiff(DateInterval.Year, .DateOfBirth.Value, DateAndTime.Now()) < 18, True, False)
                hasError = If(.Country Is Nothing OrElse .Country.Trim.Length = 0, True, False)
                hasError = If(.City Is Nothing OrElse .City.Trim.Length = 0, True, False)
                hasError = If(.Gender Is Nothing OrElse .Gender = "", True, False)
                hasError = If(.CreditCardNo Is Nothing OrElse .CreditCardNo.Trim.Length = 0, True, False)
            End With

            If hasError = False Then
                lblInfoStatus.Text = "already filled"
                lblInfoStatus.ForeColor = Color.Green
            End If

        End If
    End Sub
End Class