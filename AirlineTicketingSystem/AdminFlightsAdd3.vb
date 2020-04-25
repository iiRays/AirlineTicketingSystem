Public Class AdminFlightsAdd3
    Dim route As Route = App.Session.Get("route")
    Dim plane As Plane = App.Session.Get("plane")
    Private Sub AdminFlightsAdd3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)

        txtRouteId.Text = route.RouteID
        txtPlaneId.Text = plane.PlaneID
        rbDailyNo.Checked = True

        dtpDeparture.CustomFormat = "hh:mm tt dd/MMM/yyyy"
        dtpDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        dtpDeparture.ShowUpDown = True
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        App.Session.Delete("plane")
        Quick.Navigate(Me, New AdminFlightsAdd2)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim flightNo As String = txtFlightNo.Text
        Dim departureTime As Date = dtpDeparture.Value
        Dim priceStr As String = txtPrice.Text
        Dim price As Decimal

        Dim errorMsg As String = ""
        Dim errorsFound As Boolean = False

        If String.IsNullOrEmpty(flightNo) Then
            errorMsg += "- [Flight no] must not be empty." & vbNewLine
        End If

        If departureTime < DateTime.Now Then
            errorMsg += "- [Departure time] should be after current date and time." & vbNewLine
        End If

        If String.IsNullOrEmpty(priceStr) Then
            errorMsg += "- [Price] must not be empty." & vbNewLine
        End If

        Try
            price = Convert.ToDecimal(priceStr)
        Catch ex As Exception
            errorMsg += "- [Price] should be numeric." & vbNewLine
        End Try

        If Not errorMsg = "" Then
            errorsFound = True
        End If

        If Not errorsFound Then
            Dim flight As New Flight
            flight.FlightID = Quick.GenerateId(Of Flight)
            flight.RouteID = route.RouteID
            flight.PlaneID = plane.PlaneID
            flight.FlightNo = flightNo
            flight.DepartureTime = departureTime
            Dim routeHrs As Integer = route.DurationHour
            Dim routeMins As Integer = route.DurationMins
            Dim arrivalTime As Date = departureTime.AddHours(routeHrs)
            arrivalTime = arrivalTime.AddMinutes(routeMins)
            flight.ArrivalTime = arrivalTime
            flight.Price = price
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
        Else
            MessageBox.Show("Errors found:" & vbNewLine & errorMsg, "Errors found!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class