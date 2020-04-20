Public Class AdminFlightsViewResults
    Private Sub AdminFlightsViewResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)

        Dim flights As List(Of Flight) = New List(Of Flight)
        Dim loopCount As Integer = 0

        Dim viewAll As Boolean = App.Session.Get("viewAll")

        If viewAll Then
            flights = DB.GetAll(Of Flight)
        Else
            Dim searchBy As String = App.Session.Get("searchBy")
            Dim searchFor As String = App.Session.Get("searchFor")

            flights = DB.GetList(Of Flight)(searchBy, searchFor)
        End If

        For Each flight In flights
            Dim flightViewItem As New FlightViewItem()
            flightViewItem.Location = New Point(130, 120 + (loopCount * 100))
            flightViewItem.Flight = flight
            flightViewItem.AdminFlightsViewResults = Me
            Me.Controls.Add(flightViewItem)
            loopCount += 1
        Next
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        App.Session.Delete("viewAll")
        App.Session.Delete("searchBy")
        App.Session.Delete("searchFor")
        Quick.Navigate(Me, New AdminFlightsView)
    End Sub
End Class