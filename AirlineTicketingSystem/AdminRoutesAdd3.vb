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

        Dim errorMsg As String = ""
        Dim errorsFound As Boolean = False

        If String.IsNullOrEmpty(hrsStr) Then
            errorMsg += "- [Hrs] must not be empty." & vbNewLine
        End If

        If String.IsNullOrEmpty(minsStr) Then
            errorMsg += "- [Mins] must not be empty." & vbNewLine
        End If

        Try
            hrs = Convert.ToInt32(hrsStr)
        Catch ex As Exception
            errorMsg += "- [Hrs] must be numeric." & vbNewLine
        End Try

        Try
            mins = Convert.ToInt32(minsStr)
        Catch ex As Exception
            errorMsg += "- [Mins] must be numeric." & vbNewLine
        End Try

        If Not errorMsg = "" Then
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
            MessageBox.Show("Errors found:" & vbNewLine & errorMsg, "Errors found!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class