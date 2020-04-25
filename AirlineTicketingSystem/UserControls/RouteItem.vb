Public Class RouteItem
    Public Route As Route
    Public AdminRoutesViewResults As AdminRoutesViewResults
    Private Sub RouteItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblId.Text = Route.RouteID
        lblSource.Text = DB.GetRouteSource(Route.RouteID).City.Name
        lblDestination.Text = DB.GetRouteDestination(Route.RouteID).City.Name
    End Sub

    Private Sub BtnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        App.Session.Set("route", Route)
        Quick.Navigate(DirectCast(sender, Button).FindForm, New AdminRoutesViewSummary)
    End Sub
End Class
