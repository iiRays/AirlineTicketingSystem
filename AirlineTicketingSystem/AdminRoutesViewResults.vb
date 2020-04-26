Public Class AdminRoutesViewResults
    Private Sub AdminRoutesViewResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True)

        Dim routes As List(Of Route) = New List(Of Route)
        Dim loopCount As Integer = 0

        Dim viewAll As Boolean = App.Session.Get("viewAll")

        If viewAll Then
            routes = DB.GetAll(Of Route)
        Else
            Dim searchBy As String = App.Session.Get("searchBy")
            Dim searchFor As String = App.Session.Get("searchFor")

            routes = DB.GetList(Of Route)(searchBy, searchFor)
        End If

        For Each route In routes
            Dim routeItem As New RouteItem()
            routeItem.Location = New Point(50, 120 + (loopCount * 100))
            routeItem.Route = route
            routeItem.AdminRoutesViewResults = Me
            Me.Controls.Add(routeItem)
            loopCount += 1
        Next
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'App.Session.Delete("viewAll")
        'App.Session.Delete("searchBy")
        'App.Session.Delete("searchFor")
        Quick.Navigate(Me, New AdminRoutesView)
    End Sub
End Class