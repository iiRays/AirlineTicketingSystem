Public Class RouteAddItem
    Public Route As Route
    Public Form As String
    Public AdminFlightsAdd1 As AdminFlightsAdd1
    Public AdminFlightsEditRoute As AdminFlightsEditRoute

    Private Sub RouteAddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblId.Text = Route.RouteID
        lblSource.Text = DB.GetRouteSource(Route.RouteID).City.Name
        lblDestination.Text = DB.GetRouteDestination(Route.RouteID).City.Name
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If Form = "AdminFlightAdd1" Then
            App.Session.Set("route", Route)
            Quick.Navigate(DirectCast(sender, Button).FindForm, New AdminFlightsAdd2)
        ElseIf Form = "AdminFlightsEditRoute" Then
            App.Session.Set("route", Route)
            Quick.Navigate(DirectCast(sender, Button).FindForm, New AdminFlightsEdit)
        End If
    End Sub
End Class
