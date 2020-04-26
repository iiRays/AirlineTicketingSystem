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

        Dim errors As New List(Of String)
        Dim errorsFound As Boolean = False

        If String.IsNullOrEmpty(flightNo) Then
            errors.Add("- [Flight no] must not be empty.")
        End If

        If String.IsNullOrEmpty(priceStr) Then
            errors.Add("- [Price] must not be empty.")
        End If

        Try
            price = Convert.ToDecimal(priceStr)
        Catch ex As Exception
            errors.Add("- [Price] should be numeric.")
        End Try

        If Not errors.Count = 0 Then
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
            Quick.ShowErrors("Errors found!", errors)
        End If
    End Sub

    Private Sub BtnEditRoute_Click(sender As Object, e As EventArgs) Handles btnEditRoute.Click
        'Quick.Navigate(Me, New AdminFlightsEditRoute)
        Quick.ShowWarning("Function disabled!", "[Route] may not be edited.]")
    End Sub

    Private Sub btnEditPlane_Click(sender As Object, e As EventArgs) Handles btnEditPlane.Click
        'Quick.Navigate(Me, New AdminFlightsEditPlane)
        Quick.ShowWarning("Function disabled!", "[Plane] may not be edited.]")
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

    Private Sub TxtRouteId_DoubleClick(sender As Object, e As EventArgs) Handles txtRouteId.DoubleClick
        Quick.ShowWarning("Function disabled!", "[Route ID] may not be edited.]")
    End Sub

    Private Sub TxtPlaneId_DoubleClick(sender As Object, e As EventArgs) Handles txtPlaneId.DoubleClick
        Quick.ShowWarning("Function disabled!", "[Plane ID] may not be edited.]")
    End Sub

    Private Sub RbDailyYes_Click(sender As Object, e As EventArgs) Handles rbDailyYes.Click
        Quick.ShowWarning("Function disabled!", "[Is daily] may not be edited.]")
    End Sub

    Private Sub RbDailyNo_Click(sender As Object, e As EventArgs) Handles rbDailyNo.Click
        Quick.ShowWarning("Function disabled!", "[Is daily] may not be edited.]")
    End Sub

    Private Sub DtpDeparture_Click(sender As Object, e As EventArgs) Handles dtpDeparture.Click
        Quick.ShowWarning("Function disabled!", "[Departure time] may not be edited.]")
    End Sub
End Class