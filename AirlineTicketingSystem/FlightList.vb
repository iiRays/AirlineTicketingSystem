Public Class FlightList
    Private Sub FlightList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Get list of flights that are not instances of daily flights
        Dim flights As List(Of Flight) = App.Session.Get("flightResults")
        Dim loopCount = 0

        If flights Is Nothing Then
            Quick.Navigate(Me, New FlightSearch)
            Return
        End If

        Dim flightNoList As New List(Of String)

        'Display each flight
        For Each flight As Flight In flights
            If Not flightNoList.Contains(flight.FlightNo) Then
                flightNoList.Add(flight.FlightNo)
                Dim flightItem As New FlightItem()
                flightItem.SelectedDate = App.Session.Get("selectedDate")
                flightItem.Location = New Point(100, 150 + (loopCount * 250))
                flightItem.Flight = flight 'Pass in flight data to each flight item
                flightItem.FlightList = Me 'So that you can close this screen from the flightItems
                Me.Controls.Add(flightItem)
                loopCount += 1
            End If
        Next

        TitleBar.Load(Me)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New FlightSearch())
    End Sub
End Class