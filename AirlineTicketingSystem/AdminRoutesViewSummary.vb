Public Class AdminRoutesViewSummary
    Private route As Route = App.Session.Get("route")
    Private Sub AdminRoutesViewSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)

        lblId.Text = route.RouteID
        lblSource.Text = DB.GetRouteSource(route.RouteID).City.Name
        lblDestination.Text = DB.GetRouteDestination(route.RouteID).City.Name
        lblHrs.Text = route.DurationHour.ToString()
        lblMins.Text = route.DurationMins.ToString()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        App.Session.Set("sourceScreen", "view")
        Quick.Navigate(Me, New AdminRoutesEdit)
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        App.Session.Delete("route")
        Quick.Navigate(Me, New AdminRoutesViewResults)
    End Sub
End Class