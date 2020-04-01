Public Class FlightList
    Private Sub FlightList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get list of flights
        Dim flights As List(Of Flight) = DB.GetAll(Of Flight)
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
    End Sub
End Class