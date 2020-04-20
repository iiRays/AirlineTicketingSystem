Public Class AdminRoutesEdit
    Private route As Route = App.Session.Get("route")
    Private Sub AdminRoutesEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)

        If App.Session.Get("source") Is Nothing Then
            App.Session.Set("source", DB.GetRouteSource(route.RouteID).City)
        End If

        If App.Session.Get("destination") Is Nothing Then
            App.Session.Set("destination", DB.GetRouteDestination(route.RouteID).City)
        End If

        Dim source As City = App.Session.Get("source")
        Dim destination As City = App.Session.Get("destination")

        txtID.Text = route.RouteID
        txtSource.Text = source.Name
        txtDestination.Text = destination.Name
        txtHrs.Text = route.DurationHour.ToString()
        txtMins.Text = route.DurationMins.ToString()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim newRoute As Route = DB.Get(Of Route)(route.RouteID)
        Dim newSource As [Stop] = DB.GetRouteSource(route.RouteID)
        Dim newDesination As [Stop] = DB.GetRouteDestination(route.RouteID)

        newRoute.DurationHour = Convert.ToInt32(txtHrs.Text) 'to add validation
        newRoute.DurationMins = Convert.ToInt32(txtMins.Text) 'to add validation

        Dim source As City = App.Session.Get("source")
        Dim destination As City = App.Session.Get("destination")

        newSource.CityID = source.CityID

        newDesination.CityID = source.CityID

        App.Session.Delete("source")
        App.Session.Delete("destination")

        Quick.Navigate(Me, New AdminRoutesViewSummary)
    End Sub

    Private Sub BtnEditSource_Click(sender As Object, e As EventArgs) Handles btnEditSource.Click
        Quick.Navigate(Me, New AdminRoutesEditSource)
    End Sub

    Private Sub BtnEditDestination_Click(sender As Object, e As EventArgs) Handles btnEditDestination.Click
        Quick.Navigate(Me, New AdminRoutesEditDestination)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If App.Session.Get("sourceScreen") = "add" Then
            App.Session.Delete("sourceScreen")
            Quick.Navigate(Me, New AdminRoutesAddSummary)

        ElseIf App.Session.Get("sourceScreen") = "view" Then
            App.Session.Delete("sourceScreen")
            Quick.Navigate(Me, New AdminRoutesViewSummary)

        Else
            Quick.Navigate(Me, New AdminDashboard)
        End If
    End Sub
End Class