Public Class AdminRoutesAddSummary
    Private route As Route = App.Session.Get("route")
    Private Sub AdminRoutesAddSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)

        lblId.Text = route.RouteID
        lblSource.Text = DB.GetRouteSource(route.RouteID).City.Name
        lblDestination.Text = DB.GetRouteDestination(route.RouteID).City.Name
        lblHrs.Text = route.DurationHour.ToString()
        lblMins.Text = route.DurationMins.ToString()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        App.Session.Delete("route")
        Quick.Navigate(Me, AdminRoutesDashboard)
    End Sub

    Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        DB.Delete(DB.GetRouteSource(route.RouteID))
        DB.Delete(DB.GetRouteDestination(route.RouteID))
        DB.Delete(route)
        App.Session.Delete("route")
        Quick.Navigate(Me, AdminRoutesDashboard)
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        App.Session.Add("sourceScreen", "add")
        Quick.Navigate(Me, New AdminRoutesEdit)
    End Sub
End Class