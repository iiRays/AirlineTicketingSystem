Public Class FlightList
    Private Sub FlightList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get list of flights that are not instances of daily flights
        Dim flights As List(Of Flight) = (From flight In DB.context.Flights Where flight.IsFlightInstance = False).ToList
        Dim loopCount = 0

        'Display each flight
        For Each flight As Flight In flights
            Dim flightItem As New FlightItem()
            flightItem.Location = New Point(130, 120 + (loopCount * 250))
            flightItem.Flight = flight 'Pass in flight data to each flight item
            flightItem.FlightList = Me 'So that you can close this screen from the flightItems
            Me.Controls.Add(flightItem)
            loopCount += 1
        Next

        TitleBar.Load(Me)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim user = App.User
        If user IsNot Nothing Then
            If user.IsStaff Then
                Quick.Navigate(Me, New HomeAdmin)
            Else
                Quick.Navigate(Me, New HomeUser)
            End If
        Else
            Quick.Navigate(Me, HomeGuest)
        End If
    End Sub
End Class