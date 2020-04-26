Public Class AdminFlightsAdd1
    Private Sub AdminFlightsAdd1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        Me.DoubleBuffered = True
        TitleBar.Load(Me, True)

        cbSearchBy.SelectedIndex = 0
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New AdminFlightsDashboard)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        For Each control In Me.Controls
            If TypeOf control Is RouteAddItem Then
                Me.Controls.Remove(control)
                control.Dispose()
            End If
        Next

        Dim searchBy As String = cbSearchBy.SelectedItem
        Dim searchFor As String = If(String.IsNullOrEmpty(txtSearchFor.Text), "", txtSearchFor.Text)

        Dim routes As List(Of Route) = DB.GetList(Of Route)(searchBy, searchFor)
        Dim loopCount As Integer = 0

        For Each route In routes
            Dim routeAddItem As New RouteAddItem()
            routeAddItem.Location = New Point(500, 250 + (loopCount * 50))
            routeAddItem.Form = "AdminFlightsAdd1"
            routeAddItem.Route = route
            routeAddItem.AdminFlightsAdd1 = Me
            Me.Controls.Add(routeAddItem)
            loopCount += 1
        Next
    End Sub
End Class