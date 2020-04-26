Public Class AdminCitiesViewResults
    Private Sub AdminCitiesViewResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True)

        Dim cities As List(Of City) = New List(Of City)
        Dim loopCount As Integer = 0

        Dim viewAll As Boolean = App.Session.Get("viewAll")

        If viewAll Then
            cities = DB.GetAll(Of City)
        Else
            Dim searchBy As String = App.Session.Get("searchBy")
            Dim searchFor As String = App.Session.Get("searchFor")

            cities = DB.GetList(Of City)(searchBy, searchFor)
        End If

        For Each city In cities
            Dim cityItem As New CityItem()
            cityItem.Location = New Point(50, 120 + (loopCount * 100))
            cityItem.City = city
            cityItem.AdminCitiesViewResults = Me
            Me.Controls.Add(cityItem)
            loopCount += 1
        Next
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        App.Session.Delete("viewAll")
        App.Session.Delete("searchBy")
        App.Session.Delete("searchFor")
        Quick.Navigate(Me, New AdminCitiesView)
    End Sub
End Class