Public Class AdminRoutesAdd3
    Dim source As City = App.Session.Get("source")
    Dim destination As City = App.Session.Get("destination")
    Private Sub AdminRoutesAdd3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)

        txtSource.Text = source.Name
        txtDestination.Text = destination.Name
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        App.Session.Delete("destination")
        Quick.Navigate(Me, New AdminRoutesAdd2)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim hrsStr As String = txtHrs.Text
        Dim minsStr As String = txtMins.Text
        Dim hrs As Integer
        Dim mins As Integer

        Dim errors As New List(Of String)
        Dim errorsFound As Boolean = False

        If String.IsNullOrEmpty(hrsStr) Then
            errors.Add("- [Hrs] must not be empty.")
        End If

        If String.IsNullOrEmpty(minsStr) Then
            errors.Add("- [Mins] must not be empty.")
        End If

        Try
            hrs = Convert.ToInt32(hrsStr)
        Catch ex As Exception
            errors.Add("- [Hrs] must be numeric.")
        End Try

        Try
            mins = Convert.ToInt32(minsStr)
        Catch ex As Exception
            errors.Add("- [Mins] must be numeric.")
        End Try

        If Not errors.Count = 0 Then
            errorsFound = True
        End If

        If Not errorsFound Then
            Dim route As New Route
            route.RouteID = Quick.GenerateId(Of Route)
            route.DurationHour = hrs
            route.DurationMins = mins

            Dim sourceStop As New [Stop]
            sourceStop.Route = route 'sourceStop.RouteID = route.RouteID
            sourceStop.City = source 'sourceStop.CityID = source.CityID
            sourceStop.IsOrigin = True

            route.Stops.Add(sourceStop) '?????

            Dim destinationStop As New [Stop]
            destinationStop.Route = route 'destinationStop.RouteID = route.RouteID
            destinationStop.City = destination 'destinationStop.CityID = destination.CityID
            destinationStop.IsOrigin = False

            route.Stops.Add(destinationStop) '?????

            DB.Insert(route)
            'DB.Insert(sourceStop)
            'DB.Insert(destinationStop)

            App.Session.Set("route", route)

            App.Session.Delete("source")
            App.Session.Delete("destination")

            Quick.Navigate(Me, New AdminRoutesAddSummary)
        Else
            Quick.ShowErrors("Errors found!", errors)
        End If
    End Sub
End Class