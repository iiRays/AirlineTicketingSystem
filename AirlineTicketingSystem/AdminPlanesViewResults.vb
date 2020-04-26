Public Class AdminPlanesViewResults
    Private Sub AdminPlanesViewResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True)

        Dim planes As List(Of Plane) = New List(Of Plane)
        Dim loopCount As Integer = 0

        Dim viewAll As Boolean = App.Session.Get("viewAll")

        If viewAll Then
            planes = DB.GetAll(Of Plane)
        Else
            Dim searchBy As String = App.Session.Get("searchBy")
            Dim searchFor As String = App.Session.Get("searchFor")

            planes = DB.GetList(Of Plane)(searchBy, searchFor)
        End If

        For Each plane In planes
            Dim planeItem As New PlaneItem()
            planeItem.Location = New Point(130, 120 + (loopCount * 100))
            planeItem.Plane = plane
            planeItem.AdminPlanesViewResults = Me
            Me.Controls.Add(planeItem)
            loopCount += 1
        Next
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'App.Session.Delete("viewAll")
        'App.Session.Delete("searchBy")
        'App.Session.Delete("searchFor")
        Quick.Navigate(Me, New AdminPlanesView)
    End Sub
End Class