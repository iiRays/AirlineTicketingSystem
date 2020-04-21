Public Class AdminFlightsEditRoute
    Private Sub AdminFlightsEditRoute_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Quick.Navigate(Me, AdminFlightsEdit)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchBy As String = cbSearchBy.SelectedItem
        Dim searchFor As String = If(String.IsNullOrEmpty(txtSearchFor.Text), "", txtSearchFor.Text)

        Dim routes As List(Of Route) = DB.GetList(Of Route)(searchBy, searchFor)
        Dim loopCount As Integer = 0

        For Each route In routes
            Dim routeAddItem As New RouteAddItem()
            routeAddItem.Location = New Point(130, 120 + (loopCount * 50))
            routeAddItem.Form = "AdminFlightsEditRoute"
            routeAddItem.Route = route
            routeAddItem.AdminFlightsEditRoute = Me
            Me.Controls.Add(routeAddItem)
            loopCount += 1
        Next
    End Sub
End Class