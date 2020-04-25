Public Class AdminFlightsEdit
    Private flight As Flight = App.Session.Get("flight")
    Private Sub AdminFlightsEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)

        If App.Session.Get("route") Is Nothing Then
            App.Session.Set("route", flight.Route)
        End If

        If App.Session.Get("plane") Is Nothing Then
            App.Session.Set("plane", flight.Plane)
        End If

        Dim route As Route = App.Session.Get("route")
        Dim plane As Plane = App.Session.Get("plane")

        txtRouteId.Text = route.RouteID
        txtPlaneId.Text = plane.PlaneID
        txtFlightNo.Text = flight.FlightNo
        dtpDeparture.Value = flight.DepartureTime
        txtPrice.Text = flight.Price.ToString("0.00")
        If flight.IsDaily Then
            rbDailyYes.Checked = True
            rbDailyNo.Checked = False
        Else
            rbDailyYes.Checked = False
            rbDailyNo.Checked = True
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim flightNo As String = txtFlightNo.Text
        Dim priceStr As String = txtPrice.Text
        Dim price As Decimal

        Dim errorMsg As String = ""
        Dim errorsFound As Boolean = False

        If String.IsNullOrEmpty(flightNo) Then
            errorMsg += "- [Flight no] must not be empty." & vbNewLine
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
            Dim newFlight As Flight = DB.Get(Of Flight)(flight.FlightID)
            newFlight.FlightNo = flightNo
            newFlight.Price = price
            If rbDailyYes.Checked Then
                newFlight.IsDaily = True
                newFlight.IsFlightInstance = False
            ElseIf rbDailyNo.Checked Then
                newFlight.IsDaily = False
                newFlight.IsFlightInstance = True
            End If

            DB.Update(newFlight, flight.FlightID)

            App.Session.Delete("route")
            App.Session.Delete("plane")

            If App.Session.Get("sourceScreen") = "add" Then
                App.Session.Delete("sourceScreen")
                Quick.Navigate(Me, New AdminFlightsAddSummary)

            ElseIf App.Session.Get("sourceScreen") = "view" Then
                App.Session.Delete("sourceScreen")
                Quick.Navigate(Me, New AdminFlightsViewSummary)

            Else
                Quick.Navigate(Me, New AdminDashboard)
            End If
        Else
            MessageBox.Show("Errors found:" & vbNewLine & errorMsg, "Errors found!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnEditRoute_Click(sender As Object, e As EventArgs) Handles btnEditRoute.Click
        'Quick.Navigate(Me, New AdminFlightsEditRoute)
    End Sub

    Private Sub btnEditPlane_Click(sender As Object, e As EventArgs) Handles btnEditPlane.Click
        'Quick.Navigate(Me, New AdminFlightsEditPlane)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If App.Session.Get("sourceScreen") = "add" Then
            App.Session.Delete("sourceScreen")
            Quick.Navigate(Me, New AdminFlightsAddSummary)

        ElseIf App.Session.Get("sourceScreen") = "view" Then
            App.Session.Delete("sourceScreen")
            Quick.Navigate(Me, New AdminFlightsViewSummary)

        Else
            Quick.Navigate(Me, New AdminDashboard)
        End If
    End Sub
End Class